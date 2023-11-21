double a, b, c;


Console.WriteLine("QuadraticEquation: ax^2 + bx + c");
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
    Console.WriteLine("Please, enter a valid double number `a`.");
}

Console.Write("Input coefficient `c`: ");
while (true)
{
    bool valid = double.TryParse(Console.ReadLine(), out b);
    if (valid) break;
    Console.WriteLine("Please, enter a valid double number `a`.");
}