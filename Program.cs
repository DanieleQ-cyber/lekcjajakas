Console.Write("Jaki program chcesz odpalić?: ");
int falsada = int.Parse(Console.ReadLine()!);
if (falsada==1){
Console.Write("Podaj kierunek w jakim idziesz: północ = 1, południe = 2, wschód = 3, zachód = 4: ");
int kierunek = int.Parse(Console.ReadLine());
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
    Console.WriteLine(mikstura)

}
if (falsada==3)
{
    
}a