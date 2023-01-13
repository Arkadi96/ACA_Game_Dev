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

Console.WriteLine();
Console.WriteLine("**** 3rd exe. Calculate math operations with the given array ****");
Console.WriteLine();

Console.WriteLine("Insert array size");
int arraySize = Convert.ToInt32(Console.ReadLine());
Random rand = new Random();

int[] array = new int[arraySize];
Console.WriteLine("The given array is: ");
for (int i = 0; i < arraySize; ++i)
{
    array[i] = rand.Next(0, 20);
    Console.Write($"{array[i]} ");
}

Console.WriteLine();
Console.WriteLine("**** multiplication of all elements that divide by 5 ****");
Console.WriteLine();
int mul = 1;
for (int i = 0; i < arraySize; ++i)
{
    if (array[i] % 5 == 0)
    {
        mul *= array[i];
    }
}
Console.WriteLine($"The result is: {mul} ");

Console.WriteLine();
Console.WriteLine("**** those elements sum of squares which indexes divide by 3 ****");
Console.WriteLine();
int sum = 0;
for (int i = 0; i < arraySize; ++i)
{
    if (i % 3 == 0)
    {
        sum += array[i] * array[i];
    }
}
Console.WriteLine($"The result is: {sum} ");

Console.WriteLine();
Console.WriteLine("**** find and remove all elements that are less than the given k number ****");
Console.WriteLine("Insert the k number");
Console.WriteLine();
int k = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < arraySize; ++i)
{
    if (array[i] >= k)
    {
        ++count;
    }
}

int[] newArray = new int[count];
count = 0;
for (int i = 0; i < arraySize; ++i)
{
    if (array[i] >= k)
    {
        newArray[count] = array[i];
        ++count;
    }
}

Console.WriteLine("The new array is: ");
for (int i = 0; i < count; ++i)
{
    Console.Write($"{newArray[i]} ");
}

Console.WriteLine();
Console.WriteLine("**** BONUS: sort array in increasing order (n^2 - Big-O complexity) ****");

int tempNumber = 0;
for (int i = 0; i < arraySize; ++i)
{
    for (int j = i + 1; j < arraySize; ++j)
    {
        if (array[i] > array[j])
        {
            tempNumber = array[j];
            array[j] = array[i];
            array[i] = tempNumber;
        }
    }
}

Console.WriteLine("The sorted array is: ");
for (int i = 0; i < arraySize; ++i)
{
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
