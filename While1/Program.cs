using ExpressionsLibrary;


int n;

while (true)
{
    Console.Write("Enter n:");

    bool valid = int.TryParse(Console.ReadLine(), out n);

    if (valid)
        break;

    Console.WriteLine("Please, enter a valid integer number");
}

double a = Expressions.ArcTgSeries(n);

double b = Expressions.BaselSeries(n);

double c = Expressions.SumOfFactorials(n);

Console.WriteLine("\nResults:\na = {0}\nb={1}\nc={2}", a, b, c);
