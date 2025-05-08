//MM-2023.11.22
//Autó
Console.WriteLine("\t|-----|");
Console.WriteLine("\t  Autó");
Console.WriteLine("\t|-----|");

string[] lines = File.ReadAllLines("Auto.txt");

string[] auto = new string[lines.Length];
string[] auto_marka = new string[lines.Length];
string[] auto_szin = new string[lines.Length];
int[] auto_ev = new int[lines.Length];
string[] autok = new string[lines.Length];
int[] ar = new int[lines.Length];

for (int i = 0; i < lines.Length; i++)
{
   string[] parts = lines[i].Split(';');
   auto[i] = parts[0].Trim('"');
   auto_marka[i] = parts[1].Trim('"');
   auto_szin[i] = parts[2].Trim('"');
   auto_ev[i] = int.Parse(parts[3]);
   autok[i] = parts[4].Trim('"');
   ar[i] = int.Parse(parts[5]);
}

Console.WriteLine("2. feladat: ");
int suzuki = 0;
for (int i = 0; i < auto_marka.Length; i++)
{
    if (auto_marka[i].Equals("Suzuki"))
    {
        suzuki++;
    }
}
 Console.WriteLine("Összes Suzuki: " + suzuki);
Console.WriteLine("\n\n");

Console.WriteLine("3. feladat:");
Console.WriteLine("Fekete autók:");
for (int i = 0; i < auto_szin.Length; i++)
{
    if (auto_szin[i].Equals("Fekete"))
    {
        Console.WriteLine($"Márka: {auto_marka[i]}, Szín: {auto_szin[i]}, Tulajdonos: {autok[i]}");
    }
}

Console.WriteLine("\n\n");

Console.WriteLine("4. feladat: ");
Console.WriteLine("1990 és 1995 között gyártott autók:");
for (int i = 0; i < auto_ev.Length; i++)
{
    if (auto_ev[i] >= 1990 && auto_ev[i] <= 1995)
    {
        Console.WriteLine($"Márka: {auto_marka[i]}, Gyártási év: {auto_ev[i]}");
    }
}
Console.WriteLine("\n\n");

Console.WriteLine("5. feladat: ");
int ferrari = 0;
for (int i = 0; i < auto_marka.Length; i++)
{
    if (auto_marka[i].Equals("Ferrari"))
    {
        ferrari += ar[i];
    }
}
Console.WriteLine("Az összes Ferrari ára: " + ferrari + "Ft");

Console.ReadKey();