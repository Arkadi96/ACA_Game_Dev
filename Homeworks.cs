Console.WriteLine("***** 1th type of exercises ******");
Console.WriteLine("***** Exe #4 ******");
Console.WriteLine("Insert x:");
int x = Convert.ToInt32(Console.ReadLine());
double res = Math.Log(Math.E, (Math.Pow(Math.E, x) + 1)) + Math.Pow((Math.Pow(x, 2) + 4), (float)1/3);
Console.WriteLine($"The result is: {res}");

Console.WriteLine("***** Exe #8 ******");
Console.WriteLine("Insert x:");
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insert y:");
int y = Convert.ToInt32(Console.ReadLine());
res = Math.Pow(Math.Pow(x, 2) + Math.Pow(Math.Pow(y, 2) + 4, (float)1/3), (float)1 / 4) + Math.Pow((Math.Abs(x) + Math.Abs(y)), 10);
Console.WriteLine($"The result is: {res}");

Console.WriteLine("***** Exe #9 ******");
Console.WriteLine("Insert x:");
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insert y:");
y = Convert.ToInt32(Console.ReadLine());
double z = Math.Pow((x+4) / Math.Pow(Math.Pow(y, 2) + 4,3), (float)1/5);
res = Math.Pow(Math.Sin(x + z), 2) + 3 * z + y / Math.Pow(x, 2);
Console.WriteLine($"The result is: {res}");

Console.WriteLine("***** 2nd type of exercises ******");
Console.WriteLine("***** Exe #11 ******");
Console.WriteLine("Insert x:");
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insert a:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insert b:");
int b = Convert.ToInt32(Console.ReadLine());
res = ((a * a + b * b) > 5) ? (3 * Math.Pow(Math.E, (a - x)) + Math.Log(3, (a * a + b * b + 5))) :
      ((a * a + b * b) < 1) ? Math.Pow(Math.Tan(a + b), 4) : -3;
Console.WriteLine($"The result is: {res}");

Console.WriteLine("***** Exe #11 ******");
Console.WriteLine("Insert x:");
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insert a:");
a = Convert.ToInt32(Console.ReadLine());
res = (x >= -5 && x <= 5) ? (Math.Pow(1 + a * a, 6)) :
      (x > 5) ? (Math.Cos(Math.Pow(Math.Log(Math.E, Math.Abs(x)), 2)) + Math.Pow(x, 8)) : a;
Console.WriteLine($"The result is: {res}");

Console.WriteLine("***** 3rd type of exercises ******");
Console.WriteLine("***** Exe #74 ******");
Console.WriteLine("The results are: ");
for (float xx = -3.8f; xx <= 5.4f; xx += 0.3f)
{
    res = Math.Pow(2, xx + 4);
    Console.Write($"{(float)res} ");
}

Console.WriteLine();
Console.WriteLine("***** Exe #77 ******");
Console.WriteLine("The results are: ");
for (x = -8; x <= 8; x += 3)
{
    res = (x > 3) ? (x * x + 4 * Math.Pow(x, 8)) : 0;
    Console.Write($"{(float)res} ");
}

Console.WriteLine();
Console.WriteLine("***** 4th type of exercises ******");
Console.WriteLine("***** Exe #111 ******");
Console.WriteLine("Insert x:");
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insert n:");
int n = Convert.ToInt32(Console.ReadLine());
res = Math.Pow(x, 4 * n + 1) / 4 * n + 1;
Console.WriteLine($"The result is: {res}");

Console.WriteLine("***** Exe #118 ******");
Console.WriteLine("Insert x:");
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insert n:");
n = Convert.ToInt32(Console.ReadLine());
res = Math.Pow(Math.Abs(2 * x + n), n) / ((n + 1) * (n + 2));
Console.WriteLine($"The result is: {res}");