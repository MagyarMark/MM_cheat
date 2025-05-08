// See https://aka.ms/new-console-template for more information

Console.Write("Szia, ");
Console.WriteLine("Szia, Magyar Márk");

//Console.WriteLine("Szeptember"); //Az aktuális hónap

//Console.WriteLine("13-a");
/*
int a = 7; //változó létrehozása, értékadás
int b = 3; //változó létrehozása, értékadás
//az ab változóba lesz eltárolva a + b eredménye 
int ab = a + b;

int aszorb = a * b; //21

b = b + 3; //ugyan azt az eredményt kapjuk, csak rövidítve 
b += 3; //Például az alábbi képlet megegyezik: 
a -= 2;
 

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(ab);
Console.WriteLine(aszorb);



//stringek összeadása/összefűzése 
string str1 = "alma";
string str2 = "fa";
string ossz = str1 + str2; //az eredmény: almafa

Console.WriteLine(str1);
Console.WriteLine(str2);
Console.WriteLine(ossz);

char car = 'c';
Console.WriteLine(car);

bool megnyerte_e = true;
Console.WriteLine(megnyerte_e);

byte r = 125;
byte g = 76;
byte B = 204;

Console.Write("RGB("); //RGB(125,76,204)
Console.Write(r + ",");
Console.Write(g + ",");
Console.WriteLine(B + ")");

float suly = 65;
Console.WriteLine(suly +4.15);

int szamlalo = 0;
szamlalo++;

Console.WriteLine(szamlalo);

int a = 2, b = 4, c; //több változó létrehozása egy sorban


 int a = 2;
 int b = 4;
 int c;
 */

/*
Console.Write("Add meg a becenevedet: ");
string becenev = Console.ReadLine();
Console.Write("Szia, " + becenev);
*/


Console.Write("Add meg a számot: ");
string beker = Console.ReadLine();//szöveg bekérése és eltárolása a beker változóban 
int szam1 = int.Parse(beker); //változó = típus.Parse(string típus) 
int szam2 = Convert.ToInt32(beker); //változó = Convert.To+típus+(valamilyen típus)

Console.WriteLine(beker + " Eredmény 2x:" + (szam1 + szam2));

Console.ReadKey();