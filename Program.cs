Console.Write("DIGITE SEU NOME:");
string nomedigitado = Console.ReadLine()!;
 Console.ForegroundColor = ConsoleColor.Blue;
 Console.ResetColor();
string nomeninja = nomedigitado 
.ToLower()    
.Replace("A" ,  "ka" )
.Replace("B",  "zu"  )
.Replace("C" , "mi ")
.Replace("D" , "te")
.Replace("E" , "ku")
.Replace("F" , "lu")
.Replace("G" , "ji")
.Replace("H" , "ri")
.Replace("I" , "ki")
.Replace("J" , "zus")
.Replace("K" , "me")
.Replace("L" , "ta")
.Replace("M" , "rin")
.Replace("N" , "to")
.Replace("O" , "mo")
.Replace("P" , "no")
.Replace("Q" , "ke")
.Replace("R" , "shi")
.Replace("S" , "ari")
.Replace("T" , "chi")
.Replace("U" , "do")
.Replace("V" , "ru")
.Replace("W" , "mei")
.Replace("X" , "na")
.Replace("Y" ,  "fu")
.Replace("Z" ,  "zi");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"Seu nome ninja é:{nomeninja.Substring(0,1).ToUpper()}{nomeninja.Substring(1).ToLower()}");
Console.ResetColor();