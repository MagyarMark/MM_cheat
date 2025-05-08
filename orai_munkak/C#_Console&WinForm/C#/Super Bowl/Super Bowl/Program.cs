// MM-2023.11.15
// Super Bowl

Console.WriteLine("\t\t\t\t\tSuper Bowl");
Console.WriteLine("\t\t\t\t\t----------");

string[,] superbowl = new string[100, 8];

StreamReader be = new StreamReader("super.txt");
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
        superbowl[sorszamlalo, oszlop] = reszek[oszlop];
    }
    sorszamlalo++;
    sor = be.ReadLine();
}

for (int i = 0; i < sorszamlalo; i++)
{
    for (int j = 0; j < superbowl.GetLength(1); j++)
    {
        Console.Write(superbowl[i, j] + " ");
    }
    Console.WriteLine();
}
Console.Write("\n\n");

//4. feladat->
Console.WriteLine($"4. feladat: \tDöntők száma: {sorszamlalo} ");
Console.WriteLine("\n");

//5. feladat->

Console.WriteLine("5. feladat:"); 
Dictionary<string, int> dic = new Dictionary<string, int>();
for (int i = 0; i < sorszamlalo; i++)
{
    if (dic.ContainsKey(superbowl[i, 3])) dic[superbowl[i, 3]]++;
    else dic.Add(superbowl[i, 3], 1);
}

foreach (var item in dic)
{
    if (item.Value > 0) Console.WriteLine($"\tÁtlag pontkülönbség: {item.Key}");
}

Console.ReadKey();