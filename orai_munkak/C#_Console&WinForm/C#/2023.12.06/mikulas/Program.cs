﻿Console.WriteLine("             |----M-M----|");
Console.WriteLine("             |  Mikulás  |");
Console.WriteLine("             |---12-06---|");

Console.WriteLine("   |,\\/,| |[_' |[_]) |[_]) \\\\//\n    ||\\/|| |[_, ||'\\, ||'\\,  ||\n\n            ___ __ __ ____  __  __  ____  _  _    __    __\n           // ' |[_]| |[_]) || ((_' '||' |,\\/,|  //\\\\  ((_'\n           \\\\_, |[']| ||'\\, || ,_))  ||  ||\\/|| //``\\\\ ,_))\n                                                               \n\n                                         ,;7,\n                                       _ ||:|,\n                     _,---,_           )\\'  '|\n                   .'_.-.,_ '.         ',')  j\n                  /,'   ___}  \\        _/   /\n      .,         ,1  .''  =\\ _.''.   ,`';_ |\n    .'  \\        (.'T ~, (' ) ',.'  /     ';',\n    \\   .\\(\\O/)_. \\ (    _Z-'`>--, .'',      ;\n     \\  |   I  _|._>;--'`,-j-'    ;    ',  .'\n    __\\_|   _.'.-7 ) `'-' \"       (      ;'\n  .'.'_.'|.' .'   \\ ',_           .'\\   /\n  | |  |.'  /      \\   \\          l  \\ /\n  | _.-'   /        '. ('._   _ ,.'   \\i\n,--' ---' / k  _.-,.-|__L, '-' ' ()    ;\n '._     (   ';   (    _-}             |\n  / '     \\   ;    ',.__;         ()   /\n /         |   ;    ; ___._._____.: :-j\n|           \\,__',-' ____: :_____.: :-\\\n|               F :   .  ' '        ,  L\n',             J  |   ;             j  |\n  \\            |  |    L            |  J\n   ;         .-F  |    ;           J    L\n    \\___,---' J'--:    j,---,___   |_   |\n              |   |'--' L       '--| '-'|\n               '.,L     |----.__   j.__.'\n                | '----'   |,   '-'  }\n                j         / ('-----';\n               { \"---'--;'  }       |\n               |        |   '.----,.'\n               ',.__.__.'    |=, _/\n                |     /      |    '.\n                |'= -x       L___   '--,\n          Mikulás   L   __\\          '-----'\n                 '.____)");

Random random = new Random();
byte[] b = new byte[1];
random.NextBytes(b);
//Console.WriteLine(b.GetValue(0));
Console.WriteLine("Cukorka:");
Console.WriteLine(b[0]);

for (int i = b[0]; i > 0; i--)
{
    try
    {
        Console.Write("   \r\n                           _...--...  \r\n                        ..'        **-`  \r\n                      ,******     *****\\  \r\n                    ,*********-`.*******)  \r\n                  ,'     ~**'    )******)  \r\n                ,'       ,'     ,^     /  \r\n              ,*********'     ,******,'  \r\n            ,********'       (******,  \r\n          ,*********'         `-**'  \r\n        ,'       ,'  \r\n      ,'       ,'  \r\n    ,*********'  \r\n  ,*********'  \r\n (********'  \r\n  `-.  ,'  \r\n     `'  \r\n   \r\n Cukor");
        Console.WriteLine("\n" + i + " " + b[0]);
        b[0]-=10;
    }
    catch(Exception e)
    {
        Console.WriteLine(e.Message);
    }
}
Console.WriteLine(b[0]);

Console.ReadKey();