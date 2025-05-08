//MM-2023.11.08
//London

Console.WriteLine("\tLondon");
Console.WriteLine("\t------");
StreamReader be = new StreamReader("london.txt");

string sor = be.ReadLine();
string[] reszek = sor.Split(";");

int sorsz = 0;
while (sor != null)
{
    sorsz++;
    sor = be.ReadLine();
}
be.Close();
be = new StreamReader("london.txt");

string[] pontsz = new string[sorsz];
for (int i = 0; i < pontsz.Length; i++)
{
    sor = be.ReadLine();
    reszek = sor.Split(";");
    pontsz[i] = reszek[0];
    int p = 0;

    for (int j = 1; j < reszek.Length; j++)
    {
        p += int.Parse(reszek[j]);
        
    }
    Console.WriteLine($"{pontsz[i]}-->{p}"); 
}


Console.ReadKey();