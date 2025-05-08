using System.IO;

//MM-2023.11.08
//Lotto
Console.WriteLine("Lotto");
Console.WriteLine("------");

/*StreamReader be = new StreamReader("lotto.txt");

string sor = be.ReadLine();
string[] lotto = sor.Split(' ');
int szam = 0;


while(sor != null)
{
    szam++;
    sor = be.ReadLine();
}
be.Close();
be = new StreamReader("lotto.txt");

int osszeszam = 0;
int[,] lotto_D = new int[szam, osszeszam];

for (int i = 0; i < lotto.GetLength(0); i++)
{
    sor = be.ReadLine();
    lotto = sor.Split(" ");
    for (int j = 0; j < lotto.GetLength(1); j++)
    {
        Console.Write(lotto_D[i, j] + " | ");
    }
    Console.WriteLine();
}
*/

/*string[] sor = File.ReadAllLines("lotto.txt");
int[][] lotto_szam = new int[sor.Length][];
for (int i = 0; i < sor.Length; i++)
{
    string[] szam = sor[i].Split(' ');
    for (int j = 0; j < szam.Length; j++)
    {
        lotto_szam[i][j] = int.Parse(szam[j]);
    double average = lotto_szam[i].Average();
    Console.WriteLine(lotto_szam[i]);
    }
    
}
*/

StreamReader be = new StreamReader("lotto.txt");
string sor = be.ReadLine();
string[] reszek = sor.Split(' ');
int oszlopsz = reszek.Length; //5

int sorsz = 0;
while (sor != null)
{
    sorsz++;
    sor = be.ReadLine();
}
be.Close();

be = new StreamReader("lotto.txt");
int[,] szamok = new int[sorsz, oszlopsz];

for (int i = 0; i < sorsz; i++)
{
    sor = be.ReadLine();
    reszek = sor.Split(' ');
    for (int j = 0; j < reszek.Length; j++)
    {
        szamok[i, j] = int.Parse(reszek[j]);
    }
}

for (int i = 0; i < szamok.GetLength(0); i++)
{
    Console.Write(i + 1 + ". -");
    double ossz = 0;
    double db = 0;

    for (int j = 0; j < szamok.GetLength(1); j++)
    {
        ossz += szamok[i, j];
        db++;
        Console.Write(szamok[i, j]+ " ");
    }
    Console.WriteLine("-->" + " " + ossz / db);
}

Console.ReadKey();