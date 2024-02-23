//ForLoop();
//WhileLoop();
//DoWhileLoop();
//ForEachLoop();


static void WhileLoop()
{
    int number = 100;
    while (number >= 0)
    {
        Console.WriteLine(number);
        number--;
    }
    Console.WriteLine("Now number is {0}", number);
}

Console.ReadLine();

static void ForLoop()
{
    for (int i = 1; i <= 100; i++) //i+=2
    { //i=100,i>=0 i-=2
        Console.WriteLine(i);
    }
    Console.WriteLine("Finished!");
}


Console.ReadLine();

static void DoWhileLoop()
{
    int number = 10;
    do
    {
        Console.WriteLine(number);
        number--;

    } while (number >= 0);
}

Console.ReadLine();


 static void ForEachLoop()
{
    string[] students = new string[3] { "Engin", "Derin", "Salih" };
    foreach (var student in students)
    {
        Console.WriteLine(student);
    }
}

Console.ReadLine();

 static bool IsPrimeNumber(int number)
{
    bool result = true;
    for (int i = 2; i < number; i++)
    {
        if (number%i==0)
        {
            result = false;
            i = number;
        }
    }
    return result;
}

if (IsPrimeNumber(6))
{
    Console.WriteLine("This is a prime number");
}
else
{
    Console.WriteLine("This is not a prime number");
}
Console.ReadLine ();