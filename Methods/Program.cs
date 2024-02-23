//Add();
//int result = Add2();

//int number1 = 20; //out keywordunde int number1; baştan set etmek istiyorsak ref
//int number2 = 100;
//var result2 =Add3(ref number1, number2);
//Console.WriteLine(result2);
//Console.WriteLine(number1);
Console.WriteLine(Multiply(2, 4));
Console.WriteLine(Multiply(2, 4, 5));
Console.WriteLine(Add4(1,2,3,4,5,6));
Console.ReadLine();

static void Add()
{
    Console.WriteLine("Added!");
}
static int Add2(int number1 = 20, int number2 = 30)
{
    var result = number1 + number2;
    return result;
}
static int Add3(ref int number1, int number2)
{
    number1 = 30; //outlarda metodun içinde set edilmesi lazım
    return number1 + number2;
}
static int Multiply(int number1, int number2)
{
    return number1 * number2;
}
static int Multiply(int number1, int number2, int number3)
{
    return number1 * number2 * number3;
}
static int Add4(int number, params int[] numbers)
{
    return numbers.Sum();
}