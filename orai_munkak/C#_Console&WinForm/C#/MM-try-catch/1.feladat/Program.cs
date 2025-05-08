Console.WriteLine("             |----M-M----|");
Console.WriteLine("             | 1.feladat |");
Console.WriteLine("             |---12-06---|");





try
{
    Console.Write("Adj meg egy számot: ");
    int szam1 = int.Parse(Console.ReadLine());
    List<int> lista = new List<int>();
    lista.Add((int)szam1);
    Console.WriteLine(string.Join(System.Environment.NewLine, szam1));


    Console.Write("Adj meg egy számot: ");
    int szam2 = int.Parse(Console.ReadLine());
    lista.Add((int)szam2);
    Console.WriteLine(string.Join(System.Environment.NewLine, szam1, szam2));

    Console.Write("Adj meg egy számot: ");
    int szam3 = int.Parse(Console.ReadLine());
    lista.Add((int)szam3);
    Console.WriteLine(string.Join(System.Environment.NewLine, szam1, szam2, szam3));

}
catch (Exception e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine("Nem számot adtál meg!");
}


Console.ReadKey();