StreamWriter ki = new StreamWriter("ki.txt");

ki.WriteLine("alma");

ki.Close();

StreamReader be = new StreamReader("ki.txt");
Console.WriteLine(be.ReadLine());

be.Close();
