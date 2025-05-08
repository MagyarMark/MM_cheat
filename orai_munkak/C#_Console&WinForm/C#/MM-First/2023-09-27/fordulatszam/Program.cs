// MM- 2023-09-27
//fordulatszam

Console.WriteLine("fordulatszam");
Console.WriteLine("------------");


//1. feladat a rész:
Console.Write("Add meg a maximális fordulatszámot ezres csoportban pl.: 8000, Fordulatszám: ");

int fordulat_szam = int.Parse(Console.ReadLine());

int fordulat_osszeg = fordulat_szam * 1000;
Console.WriteLine("A fordulat szám " + " " + fordulat_osszeg);

//1. feladat b rész:
Console.Write("Add meg, hogy járjon a motor vagy nem [Igen/Nem]:  ");
string motor = Console.ReadLine();
if (motor == "igen" || motor == "Igen")
{
    Console.WriteLine("Be van indítva");
}
else
    Console.WriteLine("Le van állítva");

//1. feladat c rész:
if (motor == "nem" || motor == "Nem")
{
    Console.WriteLine("Autó motorja nem jár");
}
if (motor == "nem")
{
    Console.WriteLine("A motor 900 rpm-en van");
}
    
//1. feladat d rész:

if (fordulat_szam > 0)
{
    Console.WriteLine("A motor jár");
}
else
{
    if (fordulat_szam > 2000)
    {
        Console.WriteLine("A motor 2.sebességben van");
    }
    else if (fordulat_szam > 3000)
    {
        Console.WriteLine("A motor 3.sebességben van");
    }
    else if (fordulat_szam > 4000)
    {
        Console.WriteLine("A motor 4.sebességben van");
    }
    else if (fordulat_szam > 5000)
    {
        Console.WriteLine("A motor 5.sebességben van");
    }
    else if (fordulat_szam > 6000)
    {
        Console.WriteLine("A motor 6.sebességben van");
    }
    else
    {
        Console.WriteLine("A motor nem jár");
    }
}

//1. feladat e rész:

int seb = 0;
int maxseb = 0;
int[] rpm = { 0, 1500, 2000, 2500, 3000, 3500, 4000, 4500 };
int jelrpm = 0;

while (motor == "igen" || motor == "Igen")
{
    if (fordulat_szam == 0)
    {
        break;
    }

    Console.WriteLine($"{seb + 1}. sebesség");
    Console.WriteLine($"{fordulat_szam} {jelrpm} rpm");

    if (seb < maxseb) 
    {
        seb++;
        seb = rpm[jelrpm];
    }
    else
    {
        seb= 0;
        jelrpm = rpm[seb];
    }
    break;
}

Console.ReadKey();