Console.WriteLine("1.Aufgabe");


Console.WriteLine(short.MaxValue);
Console.WriteLine(short.MinValue);
/*
    16 Bit
    32767
    -32768
*/


Console.WriteLine(int.MaxValue);
Console.WriteLine(int.MinValue);
/*
 * 2147483647
-2147483648
*/


Console.WriteLine(long.MaxValue);
Console.WriteLine(long.MinValue);
/*
 * 9223372036854775807
-9223372036854775808
*/


Console.WriteLine(float.MaxValue);
Console.WriteLine(float.MinValue);
/*
 * 3,4028235E+38
-3,4028235E+38
*/


Console.WriteLine(double.MaxValue);
Console.WriteLine(double.MinValue);
/*
 * 1,7976931348623157E+308
-1,7976931348623157E+308
*/


Console.WriteLine(decimal.MaxValue);
Console.WriteLine(decimal.MinValue);
/*
 * 79228162514264337593543950335
-79228162514264337593543950335
*/



Console.WriteLine("2.Aufgabe (effizienteDeklarierung)");


string vorname = "Can";
short alter = 18;
bool frage = true;

Console.WriteLine("Ihre Antworten:");
Console.WriteLine($"1. {vorname}\n2. {alter}\n3. {frage}");



Console.WriteLine("3.Aufgabe (explizite Umwandlung)");


int DollarZahl = 36;
char Dollar = DollarZahl;



Console.WriteLine("4.Aufgabe (‘Convert‘Klasse)");


Console.WriteLine("Geben sie die erste Variable ein");
string v1_str = Console.ReadLine();

short v1_short = Convert.ToInt16(v1_str);

Console.WriteLine(v1_short);