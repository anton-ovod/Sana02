double a, b, c;


Console.WriteLine("Quadratic Equation: ax^2 + bx + c");
Console.Write("Input coefficient `a`: ");
while(true)
{
    bool valid = double.TryParse(Console.ReadLine(), out a);
    if (valid) break;
    Console.WriteLine("Please, enter a valid double number `a`.");
}

Console.Write("Input coefficient `b`: ");
while (true)
{
    bool valid = double.TryParse(Console.ReadLine(), out b);
    if (valid) break;
    Console.WriteLine("Please, enter a valid double number `b`.");
}

Console.Write("Input coefficient `c`: ");
while (true)
{
    bool valid = double.TryParse(Console.ReadLine(), out c);
    if (valid) break;
    Console.WriteLine("Please, enter a valid double number `c`.");
}

double d = Math.Pow(b, 2) - 4 * a * c;

if(d > 0)
{
    double x1 = (-b + Math.Sqrt(d)) / (2 * a);
    double x2 = (-b - Math.Sqrt(d)) / (2 * a);

    Console.WriteLine("D = {0}, hence there are two possible answers " +
        "x1 = {1} and x2 = {2}", d, x1, x2);
}
else if(d == 0)
{
    double x = -b / (2 * a);
    Console.WriteLine("D = 0, hence there is only one possible" +
        "answer x1 and it's equal to {0}", x);
}
else
{
    Console.WriteLine("D < 0, hence there are no possible answers for the provided equation.");

}
