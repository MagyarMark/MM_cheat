//MM-2023.11.22
//Virág
Console.WriteLine("\t|-----|");
Console.WriteLine("\t Virág");
Console.WriteLine("\t|-----|");


Dictionary<char, int> virag_szamlalo = new Dictionary<char, int>
{
    {'r', 0}, // rózsa
    {'t', 0}, // tulipán
    {'i', 0}, // ibolya
    {'g', 0}, // gerbera
    {'n', 0}, // nárcisz
    {'j', 0}  // jácint              
};

try
{
    string[] b;
    if (File.Exists("virag.txt"))
    {
        b = File.ReadAllLines("virag.txt");
    }
    else
    {
        Console.WriteLine("Adja meg a virágvásárlási adatokat (pl. rtjgir): ");
        string input = Console.ReadLine();
        b = new string[] { input };
    }

    foreach (string line in b)
    {
        foreach (char virag in line)
        {
            if (virag_szamlalo.ContainsKey(virag))
            {
                virag_szamlalo[virag]++;
            }
        }
    }

    Console.WriteLine($"(a) Hányszor vett rózsát: {virag_szamlalo['r']}");
    Console.WriteLine($"(b) Vett-e gerberát: {(virag_szamlalo['g'] > 0 ? "Igen" : "Nem")}");

    Console.WriteLine("(c) Melyik virágból mennyit vett:");
    foreach (var szam in virag_szamlalo)
    {
        Console.WriteLine($"    {GetFlowerName(szam.Key)}: {szam.Value}");
    }

    char legtobb_vett = ' ';
    char legkevesebb_vett = ' ';
    foreach (var szam in virag_szamlalo)
    {
        if (legtobb_vett == ' ' || virag_szamlalo[legtobb_vett] < szam.Value)
        {
            legtobb_vett = szam.Key;
        }
        if (legkevesebb_vett == ' ' || virag_szamlalo[legkevesebb_vett] > szam.Value)
        {
            legkevesebb_vett = szam.Key;
        }
    }
    Console.WriteLine($"(d) Melyik virágból volt a legtöbb: {GetFlowerName(legtobb_vett)}");
    Console.WriteLine($"    Melyik virágból volt a legkevesebb: {GetFlowerName(legkevesebb_vett)}");

    Console.WriteLine($"(e) Volt-e tulipán, és ha igen, mennyi: {virag_szamlalo['t']}");
    Console.WriteLine($"(f) Volt-e ibolya, és ha igen, akkor hány: {virag_szamlalo['i']}");
}
catch (Exception ex)
{
    Console.WriteLine($"Hiba történt: {ex.Message}");
}

Console.ReadLine();

static string GetFlowerName(char viragK)
{
    switch (viragK)
    {
        case 'r': return "rózsa";
        case 't': return "tulipán";
        case 'i': return "ibolya";
        case 'g': return "gerbera";
        case 'n': return "nárcisz";
        case 'j': return "jácint";
        default: return "Ismeretlen virág";
    }
}

Console.ReadKey();