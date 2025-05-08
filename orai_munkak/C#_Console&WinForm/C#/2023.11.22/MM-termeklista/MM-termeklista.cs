//MM-2023.11.22
//Terméklista
Console.WriteLine("\t|-----------|");
Console.WriteLine("\t Terméklista");
Console.WriteLine("\t|-----------|");

string[,] termek = new string[600, 6];

StreamReader be = new StreamReader("termekek.txt");
string sor = be.ReadLine();
string[] reszek;
int sorszamlalo = 0;
sor = be.ReadLine();

//sorszámláló->
while (sor != null)
{
    reszek = sor.Split(';');
    for (int oszlop = 0; oszlop < reszek.Length; oszlop++)
    {
        termek[sorszamlalo, oszlop] = reszek[oszlop];
    }
    sorszamlalo++;
    sor = be.ReadLine();
}

for (int i = 0; i < sorszamlalo; i++)
{
    for (int j = 0; j < termek.GetLength(1); j++)
    {
        Console.Write(termek[i, j] + " ");
    }
    Console.WriteLine();
}


//double atlagAr = termek.Average();

//Console.WriteLine($"A termékek átlagos ára: {atlagAr:C2}");

Console.ReadKey();