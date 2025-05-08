using System.IO;

//MM-2023.11.08
//Iskola
Console.WriteLine("Iskola");
Console.WriteLine("------");

StreamReader be = new StreamReader("nevek.txt");
    
string sor = be.ReadLine();
string[] reszek = sor.Split(',');
int oszlopszamlalo = reszek.Length;

int sorszamlalo = 0;
while (sor != null)
{
    sorszamlalo++;
    sor = be.ReadLine();
}
Console.WriteLine(sorszamlalo + ".Sor van");
be.Close();
be = new StreamReader("nevek.txt");

string[,] nevek_2D = new string[sorszamlalo, oszlopszamlalo];

for (int i = 0; i < sorszamlalo; i++)
{
    sor = be.ReadLine();

    reszek = sor.Split(";");
    for (int j = 0; j < reszek.Length; j++)
    {
        nevek_2D[i, j] = reszek[j];
        //nevek_2D[0] = 2006;
        //nevek_2D[1] = c;
        //nevek_2D[2] = Bodnár Szilvia;
    }
}

for (int i = 0; i < nevek_2D.GetLength(0); i++)
{
    Console.Write(i+1 + " - ");

    for (int j = 0; j < nevek_2D.GetLength(1); j++)
    {
        Console.Write(nevek_2D[i,j]+" | ");
    }
    Console.WriteLine();
}
Console.ReadKey();