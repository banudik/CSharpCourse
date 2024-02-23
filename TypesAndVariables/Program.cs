//Value Types
//Console.WriteLine("Hello, World!");
double number5 = 10.4; //64 bitlik veri tutuşu , sonra 15 16 karakter
decimal number6 = 10.4m; //, sonra 28 29 karakter değer tutabiliyor
char character = 'A';//ASCII
bool condition = true; //false;
byte number4 = 255; // 0-255 arasında değer
short number3 = -32768; // 32767 -> 16 bitlik yer
int number1 = 2147483647;//-2147483648 -> 32 bitlik yer
long number2 = -9223372036854775808;// 9223372036854775807
//bellekte 2x yer kaplar sınırı:19 karakterden oluşuyor -> 64 bitlik yer
var number7 = 10;
number7 = 'A';

Console.WriteLine("Number1 is {0}", number1);
Console.WriteLine("Number2 is {0}", number2);
Console.WriteLine("Number3 is {0}", number3);
Console.WriteLine("Number4 is {0}", number4);
Console.WriteLine("Number5 is {0}", number5);
Console.WriteLine("Number7 is {0}", number7);
Console.WriteLine("Character is : {0}",(int) character);
Console.WriteLine((int)Days.Friday);
Console.ReadLine();

enum Days
{
    Monday=10, Tuesday=20, Wednesday=30, Thursday, Friday, Saturday, Sunday
}