Console.WriteLine("**** 1th exe. Printing Fibonaci numbers with <n> elements ****");

int prev1 = 0, prev2 = -1;
int realNumbersCount;
int runCount = 0;

void fibNumbersRec(int value)
{
    if (runCount == realNumbersCount)
    {
        return;
    }

    if (value == 0)
    {
        runCount++;
        Console.Write($"{value} ");
        prev1 = value;
        value++;
        fibNumbersRec(value);
    }
    else if (value == 1 && prev2 == -1)
    {
        runCount++;
        Console.Write($"{value} ");
        prev2 = prev1;
        prev1 = value;
        fibNumbersRec(value);
    }
    else if (value == 1 && prev2 != -1)
    {
        runCount++;
        Console.Write($"{value} ");
        prev2 = prev1;
        prev1 = value;
        value = prev1 + prev2;
        fibNumbersRec(value);
    }
    else
    {
        runCount++;
        Console.Write($"{value} ");
        prev2 = prev1;
        prev1 = value;
        value = prev1 + prev2;
        fibNumbersRec(value);
    }
}

void fibNumbersNoRec()
{
    prev1 = 1;
    prev2 = 0;
    int value;
    Console.Write($"{prev2} {prev1} ");
    for (int i = 0; i < realNumbersCount - 2; ++i)
    {
        value = prev1 + prev2;
        prev2 = prev1;
        prev1 = value;
        Console.Write($"{value} ");
    }
}

Console.WriteLine("Insert number of fib elements ");
realNumbersCount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("**** with recursion ****");
fibNumbersRec(0);

Console.WriteLine();
Console.WriteLine("***** no recursion ****");
fibNumbersNoRec();


Console.WriteLine();
Console.WriteLine("**** 2nd exe. Factorial for a given <n> element ****");
Console.WriteLine();

int number;
int nextNumber;

int factorialRec(int value)
{
    if (value == 0)
    {
        return 1;
    }

    nextNumber = value - 1;

    return (value) * factorialRec(nextNumber);
}

int factorialNoRec(int value)
{
    int result = value;
    while (value > 1)
    {
        value = value - 1;
        result *= value;
    }

    return result;
}

Console.WriteLine("Insert number for counting the factorial");
number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("**** with recursion ****");
Console.WriteLine($"{factorialRec(number)} ");

Console.WriteLine();
Console.WriteLine("***** no recursion ****");
Console.WriteLine($"{factorialNoRec(number)} ");
