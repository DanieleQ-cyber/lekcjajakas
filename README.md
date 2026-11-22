# <MyApp>

[![Build](https://github.com/DanieleQ-cyber/lekcjajakas/actions/workflows/build.yml/badge.svg)](https://github.com/DanieleQ/lekcjajakas/actions/workflows/build.yml)

Aplikacja konsolowa .NET przygotowana w ramach przedmiotu Warsztat Programisty.

## Uruchomienie lokalne

```powershell
dotnet build "./lekcjajakas.csproj" --configuration Release
dotnet run --project "./lekcjajakas.csproj"
```

## GitHub Actions

Repozytorium korzysta z GitHub Actions. Workflow jest zdefiniowany w pliku `.github/workflows/build.yml`.

### Kiedy uruchamia się workflow

- `push` do brancha `main`,
- `pull_request` skierowany do brancha `main`

### Sprawdzany projekt

- Projekt: `./lekcjajakas.csproj` (zmienna `PROJECT_PATH` w sekcji `env` workflow)
- Wersja .NET: `<8.0.x>`
- Runner: `ubuntu-latest`

### Wykonywane kontrole

Job `build` wykonuje kolejno:

1. **Checkout repository**: pobiera kod repozytorium.
2. **Check repository structure**: uruchamia skrypt `scripts/check-repository.sh`, który sprawdza, czy:
   - podano ścieżkę do projektu,
   - plik `.csproj` istnieje,
   - plik `README.md` istnieje i nie jest pusty.
   Gdy któryś warunek nie jest spełniony, skrypt wypisuje komunikat `ERROR: ...` i kończy się kodem `1`. Job zostaje wtedy przerwany, a kolejne kroki są pomijane.
3. **Setup .NET**: instaluje SDK .NET.
4. **Restore**: `dotnet restore` przywraca zależności.
5. **Build**: `dotnet build` w konfiguracji `Release`.
6. **Publish project**: `dotnet publish` zapisuje uporządkowany wynik do `./artifacts/app`.
7. **Upload build artifact**: wysyła katalog `./artifacts/app` jako artefakt przez `actions/upload-artifact@v4`.

### Artefakt

- Nazwa: `app-<SHA commita>`, np. `app-3f2a9c1...`. Dzięki temu artefakt jest jednoznacznie powiązany z wersją kodu.
- Czas przechowywania: **7 dni**.
- Gdy katalog z wynikiem jest pusty, krok kończy się błędem (`if-no-files-found: error`).

Artefakt to wynik kompilacji do pobrania. Nie jest wdrożeniem aplikacji ani stroną GitHub Pages.

### Gdzie znaleźć logi i artefakty

1. Otwórz zakładkę **Actions** w repozytorium albo sekcję **Checks** w Pull Requeście.
2. Wybierz konkretne uruchomienie workflow **Build**.
3. **Logi:** kliknij job **build** i rozwiń wybrany step. Przy błędzie szukaj pierwszego czerwonego kroku i komunikatu zaczynającego się od `ERROR:`.
4. **Artefakty:** na stronie podsumowania uruchomienia (Summary) przewiń do sekcji **Artifacts** i pobierz paczkę `app-<sha>`.