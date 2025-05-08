using System;
using System.IO;

//MM-2023.11.08
//Enaplo

Console.WriteLine("\tEnaplo");
Console.WriteLine("\t------");
StreamReader be = new StreamReader("enaplo.txt");
string sor = be.ReadLine();
string[] reszek = sor.Split(' ');

int sszam = 0;
while (sor != null)
{
    sszam++;
    sor = be.ReadLine();
}
be.Close();
be = new StreamReader("enaplo.txt");

string[] nevek = new string[sszam];
for (int i = 0; i < nevek.Length; i++)
{
    sor = be.ReadLine();
    reszek = sor.Split(' ');
    nevek[i] = reszek[0]+ " "+ reszek[1];
}
/*for (int i = 0; i < nevek.Length; i++)
{
    Console.WriteLine(nevek[i]);
}
*/
foreach (string nev in nevek)
{
    Console.WriteLine($"{nev}\t--> {nev.Length-1}");
}

Console.ReadKey();