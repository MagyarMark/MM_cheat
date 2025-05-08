// MM- 2023-09-27
//If-else if-else

Console.WriteLine("If-else if-else");
Console.WriteLine("------------------");

Console.Write("Adj meg egy számot: ");
int szam = int .Parse(Console.ReadLine());

if (szam < 0)
    Console.WriteLine("A szám negatív");
else if (szam == 0)
    Console.WriteLine("A szám nulla");
else
    Console.WriteLine("A szám pozitív");

if (szam % 2 == 0)
    //{}-csak akkor kell ha több értéket akarunk egyszerre ki írtani
    Console.WriteLine("A szám páros");
else 
    Console.WriteLine("A szám páratlan");

Console.ReadKey();