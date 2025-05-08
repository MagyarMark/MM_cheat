// MM- 2023-09-27
//Jegyadas

Console.WriteLine("Jegyadas");
Console.WriteLine("------------------");


Console.Write("Add meg a dolgozat maximális pontszámát: ");
int dogamaxp = int.Parse(Console.ReadLine());

Console.Write("Add meg a dolgozatban elért pontszámot: ");
int dogaelertp = int.Parse(Console.ReadLine());

double szazalek = (double)dogaelertp / dogamaxp * 100;

Console.WriteLine("Az elért százalék: " + Math.Round(szazalek,2) + "%");

if (szazalek > 85)
{
    Console.WriteLine("A dolgozat jegye: 5");
}
else
{
    if (szazalek > 75)
    {
        Console.WriteLine("A dolgozat jegye: 4");
    }
    else if (szazalek > 50)
    {
        Console.WriteLine("A dolgozat jegye: 3");
    }
    else if (szazalek > 35)
    {
        Console.WriteLine("A dolgozat jegye: 2");
    }
    else
    {
        Console.WriteLine("A dolgozat jegye: 1");
    }
}
Console.ReadKey();