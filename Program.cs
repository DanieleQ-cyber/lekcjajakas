using System.ComponentModel.Design.Serialization;

Console.Write("Jaki program chcesz odpalić?: ");
int falsada = int.Parse(Console.ReadLine()!);
if (falsada==1){
Console.Write("Podaj kierunek w jakim idziesz: północ = 1, południe = 2, wschód = 3, zachód = 4: ");
int kierunek = int.Parse(Console.ReadLine()!);
switch (kierunek)
{
    case 1:
            Console.WriteLine("Wyruszasz w stronę gór.");
        
        break;
    case 2:
            Console.WriteLine("Wyruszasz w stronę pustyni.");
        
        break;
    case 3:
            Console.WriteLine("Wyruszasz w stronę lasu.");
        break;
    case 4:
            Console.WriteLine("Wyruszasz w stronę morza.");    
        break;

}
}
if (falsada==2)
{
    Console.WriteLine("Jakie aktualne punkty zycia:");
    int zycie = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Podstawowy dps broni:");
    int dps = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Masz miksture?:");
    bool mikstura = bool.Parse(Console.ReadLine()!);
    Console.WriteLine(mikstura);

}
if (falsada==3)
{
int liczba = 1;
    while (liczba <= 10)
    {
        Console.Write($"{liczba} ");
        liczba++;
    }
    Console.WriteLine("");
    Console.WriteLine("For:");
    for(int licz = 10; licz >= 1; licz--)
    {
        Console.Write($"{licz} ");
    }

        Console.WriteLine("");
        Console.WriteLine("For parzyste:");

      for(int licz = 20; licz >= 2; licz--)
    {
        Console.Write($"{licz} ");
        licz--;
    }
}
if (falsada==4)
{
    Console.Write("Ile dni będziesz na wyprawie: ");
    int dni = int.Parse(Console.ReadLine()!);
    int wynik = 0;
    int zloto = 0;
    int gold = 0;
    while (dni <= 7 && dni >= 1)
    {
        Console.WriteLine($"Ile golda zarobiłeś w dniu? {dni}: ");
        gold = int.Parse(Console.ReadLine()!);
        zloto = zloto + gold;
        dni--;
        if(gold > 10)
        {
            wynik++;
        }

    }

    Console.WriteLine($"Twoja wyprawa się zakończyła zdobyłeś: {zloto} golda");
    Console.WriteLine($"Ilość dni z wynikiem powyzej 10: {wynik}");
    
}
if (falsada == 5)
{
    float zdrowieBohatera = 60;
    float zdrowiePrzeciwnika = 45;
    int liczbaMikstur = 2;
    int liczbaMikstur2 = 2;
    int numerTury = 1;
    while(zdrowieBohatera >= 0 || zdrowiePrzeciwnika >= 0)
    {
        Console.Write("Wymierz akcje jaką chcesz zrobić: ");
        int akcja = int.Parse(Console.ReadLine()!);
        if(akcja >= 4)
        {
         Console.Write("Zła wartośćc ");
         continue;
        }
        switch (akcja)
        {
          case 1:
          Console.WriteLine("Zaatakowałeś");
          zdrowiePrzeciwnika = zdrowiePrzeciwnika - 12;
        break;
          case 2:
        
                    Console.WriteLine("Wybrałeś mikstrure");
                    zdrowieBohatera = zdrowieBohatera + 15;
                    liczbaMikstur--;
                    break;
        
        case 3:
    
             Console.WriteLine("SPIERDALAMY!!!");
                zdrowieBohatera = 0;
             break;
                 
     
        
        }
        if(zdrowieBohatera <= 0)
        {
            Console.WriteLine("Przejebałeś");
            break;
        }
         
        
        Console.Write("Wymierz akcje jaką chcesz zrobić2 : ");
        int akcja2 = int.Parse(Console.ReadLine()!);
        if(akcja2 >= 4)
        {
         Console.Write("Zła wartość ");
         continue;
        }
        switch (akcja2)
        {
          case 1:
          Console.WriteLine("Zaatakowałeś");
          zdrowieBohatera = zdrowieBohatera - 12;
        break;
          case 2:
        
                    Console.WriteLine("Wybrałeś mikstrure");
                    zdrowiePrzeciwnika = zdrowiePrzeciwnika + 15;
                    liczbaMikstur2--;
                    break;
        
        case 3:
        
             Console.WriteLine("SPIERDALAMY!!!");
             zdrowiePrzeciwnika = 0;
             break;       
            
        }
        if(zdrowiePrzeciwnika <= 0) 
        {
            Console.WriteLine("Przejebałeś");
            break;
        }  
            numerTury++;
        }
        }
          
         
         


         
        
    
        
    
       
        
        
          
    
