Console.WriteLine("             |----M-M----|");
Console.WriteLine("             | 2.feladat |");
Console.WriteLine("             |---12-06---|");





try
{
    Console.Write("Adj meg egy számot: ");
    int szam1 = int.Parse(Console.ReadLine());
    Console.WriteLine(string.Join(System.Environment.NewLine, szam1));

    Console.Write("Adj meg egy számot: ");
    int szam2 = int.Parse(Console.ReadLine());
    Console.WriteLine(string.Join(System.Environment.NewLine, szam1, szam2));
    Console.WriteLine($"{szam1}:{szam2}={szam2/szam1}, maradék {szam2}", szam1, szam2, szam1 / szam2, szam1 % szam2);


}
catch (Exception e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine("Nem számot adtál meg!");
}


Console.ReadKey();