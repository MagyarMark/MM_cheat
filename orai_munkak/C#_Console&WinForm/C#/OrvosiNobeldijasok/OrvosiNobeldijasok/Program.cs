// MM-2023.11.15
// OrvosiNobelDíjasok

Console.WriteLine("\tOrvosiNobelDíjasok");
Console.WriteLine("\t------------------");

string[,] nobel = new string[500, 4];

StreamReader be = new StreamReader("nobel.txt");
string sor = be.ReadLine();
string[] reszek;
int sorszamlalo = 0;
sor = be.ReadLine();

//sorszámláló->
while (sor != null)
{
    reszek =sor.Split(';');
	for (int oszlop = 0; oszlop < reszek.Length; oszlop++)
	{
		nobel[sorszamlalo, oszlop] = reszek[oszlop];
	}
	sorszamlalo++;
	sor = be.ReadLine();
}

for (int i = 0; i < sorszamlalo; i++)
{
	for (int j = 0; j < nobel.GetLength(1); j++)
	{
		Console.Write(nobel[i, j]+" ");
    }
	Console.WriteLine();
}

//3. feladat->
Console.WriteLine($"3. feladat: összes díjazott: {sorszamlalo} Fő");

//4. feladat->
int[] evek = new int[sorszamlalo];
for (int i = 0; i < sorszamlalo; i++)
{
	evek[i] = int.Parse(nobel[i,0]);
}  
Console.WriteLine($"4. feladat: Utolsó év: {evek.Max()}");

//5. feladat->
Console.Write($"5.feladat: Kérem adja meg egy ország Kódját: ");
string orszagkod = Console.ReadLine();
int talalat = 0;
int egytalalat = 0;
Console.WriteLine("\t A megadott ország díjazottja: ");
for (int i = 0; i < sorszamlalo; i++)
{
	if (nobel[i, 3] == orszagkod)
	{
		talalat++;
		egytalalat = i;
	}
}
if (talalat == 0)
    Console.WriteLine("A megadott országból nem volt díjazott!");
else if (talalat == 1)
{
    Console.WriteLine($"\t Név: {nobel[egytalalat, 1]}");
    Console.WriteLine($"\t Év: {nobel[egytalalat, 0]}");
    Console.WriteLine($"\t Sz/H: {nobel[egytalalat, 2]}");
}
else
    Console.WriteLine($"A megadott országból {talalat} Fő díjazott!");

//6. feladat->
Console.WriteLine("6. feldata: Statisztika:");

Dictionary<string,int> dic = new Dictionary<string,int>();
for (int i = 0; i < sorszamlalo; i++)
{
	if (dic.ContainsKey(nobel[i, 3])) dic[nobel[i, 3]]++;
	else dic.Add(nobel[i, 3], 1);
}

foreach (var item in dic)
{
	if (item.Value > 5) Console.WriteLine($"\t{item.Key} - {item.Value} Fő");
}
Console.ReadKey();