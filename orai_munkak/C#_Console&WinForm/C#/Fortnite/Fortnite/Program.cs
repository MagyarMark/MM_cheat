using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Player
{
    public string Name { get; set; }
    public int Level { get; set; }
    public int Health { get; set; }
    public int Shield { get; set; }
    public List<Weapon> Weapons { get; set; } = new List<Weapon>();
    public List<Ammo> Ammo { get; set; } = new List<Ammo>();
    public List<Treasure> Treasures { get; set; } = new List<Treasure>();
    public int Score { get; set; }
}

class Enemy
{
    public string Name { get; set; }
    public int Level { get; set; }
    public int Health { get; set; }
    public int Shield { get; set; }
    public List<Weapon> Weapons { get; set; } = new List<Weapon>();
    public List<Ammo> Ammo { get; set; } = new List<Ammo>();
    public List<Treasure> Treasures { get; set; } = new List<Treasure>();
    public int Score { get; set; }
}
class Weapon
{
    public string Name { get; set; }
}

class Ammo
{
    public string Type { get; set; }
    public int Quantity { get; set; }
}

class Treasure
{
    public string Name { get; set; }
}

class Program
{
    static Player player = new Player();
    static Enemy enemy = new Enemy();

    static void Main()
    {
        DisplayMenu();
    }

    static void DisplayMenu()
    {
        while (true)
        {
            Console.WriteLine("\n----- Játék Menü -----");
            Console.WriteLine("1. Játékos Információk");
            Console.WriteLine("2. Fegyverek és Lőszerek");
            Console.WriteLine("3. Csata Szimuláció");
            Console.WriteLine("4. Itemek");
            Console.WriteLine("5. Ranglista");
            Console.WriteLine("6. Kilépés");
            Console.Write("Válassz egy menüpontot (1-6): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    PlayerInfo();
                    break;
                case "2":
                    WeaponsAndAmmo();
                    break;
                case "3":
                    BattleSimulation();
                    break;
                case "4":
                    AddTreasure();
                    break;
                case "5":
                    UpdateAndDisplayRankings();
                    break;
                case "6":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Érvénytelen választás. Kérlek, válassz újra.");
                    break;
            }
        }
    }

    static void PlayerInfo()
    {
        Random randomlevel = new Random();
        int rlevel = randomlevel.Next(1, 200);

        Random randomhp = new Random();
        int rhp = randomhp.Next(0, 100);

        Random randomshield = new Random();
        int rshield = randomshield.Next(0, 100);

        Random randomlevel2 = new Random();
        int rlevel2 = randomlevel2.Next(1, 200);

        Random randomhp2 = new Random();
        int rhp2 = randomhp2.Next(0, 100);

        Random randomshield2 = new Random();
        int rshield2 = randomshield2.Next(0, 100);

        Console.WriteLine("\n----- Játékos Információk -----");
        Console.Write("Adja meg a játékos nevét: ");
        player.Name = Console.ReadLine();
        Console.WriteLine($"Játékos szintje: {rlevel}");
        player.Level = rlevel;
        Console.WriteLine($"Játékos életereje: {rhp} ");
        player.Health = rhp;
        Console.WriteLine($"Játékos Pajzsa: {rshield}");
        player.Shield = rshield;

        Console.WriteLine();

        Console.Write("Add meg az ellenfeled nevét: ");
        enemy.Name = Console.ReadLine();
        Console.WriteLine($"Ellenfél szintje: {rlevel2} ");
        enemy.Level = rlevel2;
        Console.WriteLine($"Ellenfél életereje: {rhp2} ");
        enemy.Health = rhp2;
        Console.WriteLine($"Ellenfél Pajzsa: {rshield2} ");
        enemy.Shield = rshield2;

        Console.WriteLine("\ninformációk frissítve.");
    }

    static void WeaponsAndAmmo()
    {
        Random randomammo = new Random();
        int rammo = randomammo.Next(0, 25);

        Random randomammo2 = new Random();
        int rammo2 = randomammo2.Next(0, 25);

        List<string> items = new List<string>
            {
                "Enforcer AR",
                "Striker AR",
                "Sideways Rifle",
                "Heavy Assault Rifle",
                "Hammer Assault Rifle",
                "Chrome Assault Rifle",
                "Snowball Launcher",
                "Lock On Pistol",
                "Frenzy Auto Shotgun",
                "Thunder SMG",
                "Infantry Rifle",
                "Rocket Launcher",
                "Reaper Sniper Rifle",
                "Ranger Pistol",

            };
        Random random = new Random();
        int firstIndex = random.Next(items.Count);
        int secondIndex = random.Next(items.Count);
        int weapon = random.Next(items.Count);
        int wapon = random.Next(items.Count);
        int wapon2 = random.Next(items.Count);
        int wapon3 = random.Next(items.Count);
        int wapon4 = random.Next(items.Count);

        Console.WriteLine("\n----- Fegyverek és Lőszerek -----");
        Console.Write("1. játékos fegyvere: ");
        Console.WriteLine($"{items[firstIndex]}");
        string weaponName = items[firstIndex];
        player.Weapons.Add(new Weapon { Name = weaponName });
        Console.WriteLine($"Tölténye: {rammo}");

        Console.WriteLine();

        Console.Write("1. Játékos Tárolt fegyverei:\n ");
        Console.WriteLine(string.Join(System.Environment.NewLine, items[firstIndex]));
        Console.WriteLine(string.Join(System.Environment.NewLine, items[weapon]));
        Console.WriteLine(string.Join(System.Environment.NewLine, items[wapon]));
        Console.WriteLine(string.Join(System.Environment.NewLine, items[wapon2]));
        Console.WriteLine(string.Join(System.Environment.NewLine, items[wapon3]));
        Console.WriteLine(string.Join(System.Environment.NewLine, items[wapon4]));

        Console.WriteLine();

        Console.Write("2. játékos fegyvere: ");
        Console.WriteLine($"{items[secondIndex]}");
        string EnemyWeapon = items[secondIndex];
        enemy.Weapons.Add(new Weapon { Name = EnemyWeapon });
        Console.WriteLine($"Tölténye: {rammo2} ");

        Console.WriteLine();

        Console.Write("2. játékos Tárolt fegyverei:\n ");
        Console.WriteLine(string.Join(System.Environment.NewLine, items[secondIndex]));
        Console.WriteLine(string.Join(System.Environment.NewLine, items[wapon4]));
        Console.WriteLine(string.Join(System.Environment.NewLine, items[weapon]));
        Console.WriteLine(string.Join(System.Environment.NewLine, items[wapon3]));
        Console.WriteLine(string.Join(System.Environment.NewLine, items[wapon]));
        Console.WriteLine(string.Join(System.Environment.NewLine, items[wapon2]));


        Console.WriteLine("\nFegyver és lőszer felvéve!");   
    }

    static void BattleSimulation()
    {

        Random randomammo = new Random();
        int rammo = randomammo.Next(0, 25);

        Random randomammo2 = new Random();
        int rammo2 = randomammo2.Next(0, 25);
        Console.WriteLine("\n----- Csata Szimuláció -----");
        Console.WriteLine($"Játékos: {player.Name} (Szint: {player.Level}, Életerő: {player.Health})");
        Console.WriteLine($"Ellenség: {enemy.Name} (Szint: {enemy.Level}, Életerő: {enemy.Health})");

        while (player.Health > 0 && enemy.Health > 0)
        {

            int playerAttack = new Random().Next(rammo);
            enemy.Health -= playerAttack;
            Console.WriteLine($"{player.Name} támadott! Ellenség életereje: {enemy.Health}");

            Console.WriteLine();

            int enemyAttack = new Random().Next(rammo2);
            player.Health -= enemyAttack;
            Console.WriteLine($"{enemy.Name} támadott! Játékos életereje: {player.Health}");
        }
        Console.WriteLine();

        if (player.Health <= 0)
        {
            Console.WriteLine($"{player.Name} győzött a csatában!");
        }
        else
        {
            Console.WriteLine($"{enemy.Name} győzött a csatában!");
        }
    }

    static void AddTreasure()
    {
        List<string> items = new List<string>
            {
                "Ant-Man",
                "Spider Man",
                "Hulk",
                "She Hulk",
                "Iron Man",
                "Blade",
                "Black Panther",
                "Thor",
                "Black Widow",
                "Captain America",
                "Captain Marvel",
                "Captain America-Sam",
                "Carnage",
                "Clint",
                "Deadpool",
                "Daredevil",
                "Dark Phoenix",
                "Doctor Strange",
                "Doctor Doom",
                "Eddie Brock",
                "Gambit",
                "Gamora",
                "Ghost Rider",
                "Green Goblin",
                "Groot",
                "Hawk Eye",
                "Jennifer Walters",
                "Loki Laufeyson",
                "Mj",
                "Moon Knight",

            };
        Random random = new Random();
        int firstIndex = random.Next(0, items.Count);
        int secondIndex = random.Next(0, items.Count);
        int threeIndex = random.Next(0, items.Count);
        int fourIndex = random.Next(0, items.Count);
        int fiveIndex = random.Next(0, items.Count);
        int sixIndex = random.Next(0, items.Count);
        int sevenIndex = random.Next(0, items.Count);
        int eightIndex = random.Next(0, items.Count);
        int nineIndex = random.Next(0, items.Count);
        int tenIndex = random.Next(0, items.Count);
        int elevenIndex = random.Next(0, items.Count);
        int twelveIndex = random.Next(0, items.Count);
        int thirteenIndex = random.Next(0, items.Count);
        int fourteenIndex = random.Next(0, items.Count);
        int fiveteenIndex = random.Next(0, items.Count);
        int sixteenIndex = random.Next(0, items.Count);


        Console.WriteLine("\n----- Itemek -----");
        Console.Write("1. játékos dolgai: ");
        Console.WriteLine($"\n{items[firstIndex]}, {items[threeIndex]}");
        Console.WriteLine($"{items[fiveIndex]}, {items[sevenIndex]}");
        Console.WriteLine($"{items[nineIndex]}, {items[elevenIndex]}");
        Console.WriteLine($"{items[thirteenIndex]}, {items[fiveteenIndex]}");

        Console.WriteLine();

        Console.Write("2. játékos dolgai: ");
        Console.WriteLine($"\n{items[secondIndex]}, {items[fourIndex]}");
        Console.WriteLine($"{items[sixIndex]}, {items[eightIndex]}");
        Console.WriteLine($"{items[tenIndex]}, {items[twelveIndex]}");
        Console.WriteLine($"{items[fourteenIndex]}, {items[sixteenIndex]}");

        Console.WriteLine("\nItemek hozzáadva a gyűjteményhez.");
    }

    static void UpdateAndDisplayRankings()
    {

        List<string> items = new List<string>
            {
                "Enforcer AR",
                "Striker AR",
                "Sideways Rifle",
                "Heavy Assault Rifle",
                "Hammer Assault Rifle",
                "Chrome Assault Rifle",
                "Snowball Launcher",
                "Lock On Pistol",
                "Frenzy Auto Shotgun",
                "Thunder SMG",
                "Infantry Rifle",
                "Rocket Launcher",
                "Reaper Sniper Rifle",
                "Ranger Pistol",
            };
        Random random = new Random();
        int firstIndex = random.Next(0, items.Count);
        int secondIndex = random.Next(0, items.Count);
        int weapon = random.Next(items.Count);
        int wapon = random.Next(items.Count);
        int wapon2 = random.Next(items.Count);
        int wapon3 = random.Next(items.Count);
        int wapon4 = random.Next(items.Count);

        List<string> items2 = new List<string>
            {
                "Ant-Man",
                "Spider Man",
                "Hulk",
                "She Hulk",
                "Iron Man",
                "Blade",
                "Black Panther",
                "Thor",
                "Black Widow",
                "Captain America",
                "Captain Marvel",
                "Captain America-Sam",
                "Carnage",
                "Clint",
                "Deadpool",
                "Daredevil",
                "Dark Phoenix",
                "Doctor Strange",
                "Doctor Doom",
                "Eddie Brock",
                "Gambit",
                "Gamora",
                "Ghost Rider",
                "Green Goblin",
                "Groot",
                "Hawk Eye",
                "Jennifer Walters",
                "Loki Laufeyson",
                "Mj",
                "Moon Knight",
            };
        Random random2 = new Random();
        int firstIndex2 = random2.Next(0, items2.Count);
        int secondIndex2 = random2.Next(0, items2.Count);
        int threeIndex2 = random.Next(0, items.Count);
        int fourIndex2 = random.Next(0, items.Count);
        int fiveIndex2 = random.Next(0, items.Count);
        int sixIndex2 = random.Next(0, items.Count);
        int sevenIndex2 = random.Next(0, items.Count);
        int eightIndex2 = random.Next(0, items.Count);
        int nineIndex2 = random.Next(0, items.Count);
        int tenIndex2 = random.Next(0, items.Count);
        int elevenIndex2 = random.Next(0, items.Count);
        int twelveIndex2 = random.Next(0, items.Count);
        int thirteenIndex2 = random.Next(0, items.Count);
        int fourteenIndex2 = random.Next(0, items.Count);

        Random killrandom = new Random();
        int kill = killrandom.Next(0,99);
        int kill2 = killrandom.Next(0,98);

        Console.WriteLine("\n----- Ranglista -----");

        Console.WriteLine();
        Console.WriteLine("Játékosnév \t Életerő \t Kill \t Szint");
        Console.WriteLine(player.Name + " \t\t " + player.Health +" \t\t " + kill + " \t " + player.Level);
        Console.WriteLine(enemy.Name + " \t\t " + enemy.Health + " \t\t " + kill2 + "  \t " + enemy.Level);
        Console.WriteLine();

        Console.ReadKey();

        StreamWriter ranglista = new StreamWriter("ranglista.txt", append: true);

        ranglista.WriteLine("Játékosnév \t Életerő \t Kill \t Szint \t Itemek \t\t Fegyverek");
        ranglista.WriteLine(player.Name + " \t\t " + player.Health + " \t\t " + kill + " \t " + player.Level + " \t " + items2[firstIndex2] + "\t\t" + items[firstIndex]);   
        ranglista.WriteLine("\t\t\t\t\t\t"+ items2[firstIndex2]  + "\t\t" + items[firstIndex]);
        ranglista.WriteLine("\t\t\t\t\t\t"+ items2[secondIndex2] + "\t\t" + items[secondIndex]);
        ranglista.WriteLine("\t\t\t\t\t\t"+ items2[threeIndex2]  + "\t\t" + items[weapon]);
        ranglista.WriteLine("\t\t\t\t\t\t"+ items2[fourIndex2]   + "\t\t" + items[wapon]);
        ranglista.WriteLine("\t\t\t\t\t\t"+ items2[fiveIndex2]   + "\t\t" + items[wapon2]);
        ranglista.WriteLine("\t\t\t\t\t\t"+ items2[sixIndex2]    + "\t\t" + items[wapon3]);
        ranglista.WriteLine("\t\t\t\t\t\t"+ items2[sevenIndex2]  + "\t\t" + items[wapon4]);

        ranglista.WriteLine("\t");

        ranglista.WriteLine("Játékosnév \t Életerő \t Kill \t Szint \t Itemek \t\t Fegyverek");
        ranglista.WriteLine(enemy.Name + " \t\t " + enemy.Health + " \t\t " + kill2 +" \t " + enemy.Level + "\t " + items2[secondIndex2]+ "\t\t" + items[secondIndex]);
        ranglista.WriteLine("\t\t\t\t\t\t" + items2[eightIndex2]    + "\t\t" + items[firstIndex]);
        ranglista.WriteLine("\t\t\t\t\t\t" + items2[nineIndex2]     + "\t\t" + items[secondIndex]);
        ranglista.WriteLine("\t\t\t\t\t\t" + items2[tenIndex2]      + "\t\t" + items[wapon3]);
        ranglista.WriteLine("\t\t\t\t\t\t" + items2[elevenIndex2]   + "\t\t" + items[weapon]);
        ranglista.WriteLine("\t\t\t\t\t\t" + items2[twelveIndex2]   + "\t\t" + items[wapon4]);
        ranglista.WriteLine("\t\t\t\t\t\t" + items2[thirteenIndex2] + "\t\t" + items[weapon]);
        ranglista.WriteLine("\t\t\t\t\t\t" + items2[fourteenIndex2] + "\t\t" + items[wapon2]);

        ranglista.WriteLine("\t");

        ranglista.Close();
        System.Environment.Exit(0);

        Console.ReadKey();
    }
}