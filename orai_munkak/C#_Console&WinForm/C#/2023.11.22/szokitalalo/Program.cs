//MM-2023.11.22
//Szókitaláló
Console.WriteLine("\t|------------|");
Console.WriteLine("\t Szókitaláló");
Console.WriteLine("\t|------------|");

StreamReader be = new StreamReader("szokitalalo.txt");
StreamWriter ki = new StreamWriter("megoldas.txt");
Random rnd = new Random();

string sor = be.ReadLine();
string[] reszek = sor.Split(", ");

foreach (var szo in reszek)
{
    ki.WriteLine($"\t    {szo}");
}

string gen_szo = reszek[rnd.Next(reszek.Length-1)]; //reszek[0] = fuvola, reszek[10] = gerinc

Console.WriteLine($"\t   {gen_szo}");

bool megy = true;
while (megy)
{
    Console.Write(" Tipp: ");
    string tipp = Console.ReadLine();
    if (tipp == gen_szo)
    {
        Console.WriteLine("Eltaláltad a szót!");
        Console.WriteLine($"|{gen_szo}|");
        megy  = false;
    }
    else
    {
        Console.WriteLine("Nem találtad el!");
        Console.WriteLine($"A helyes megoldás |{gen_szo}| volt ");
        for (int i = 0; i < gen_szo.Length; i++)
        {
            if (tipp[i] == gen_szo[i])
            {
                Console.Write(tipp[i]);
            }
            else
            {
                Console.Write(".");
            }
            Console.WriteLine();

        }
    }
}


ki.Close();
be.Close();

Console.ReadKey();