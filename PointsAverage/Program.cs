using System;

double sumOfPoints = 0;

double numberOfPoints = 5;

for (int i = 0; i < numberOfPoints; i++)
{
    double point = 0;

    Console.Write("Input mark number [{0}]: ", i + 1);
    while(true)
    {
        bool valid = double.TryParse(Console.ReadLine(), out point);
        if (point < 0 || point > 100) valid = false;
        if (valid) break;
        Console.WriteLine("Incorrect mark. Try again.");
    }
    sumOfPoints += point;
}

double averagePoint = sumOfPoints / numberOfPoints;

Console.WriteLine(averagePoint >= 50 ? "Average of student's points is greater or equal to 50, hence he/she is allowed to take an exam." :
    "Average of student's points is less than 50, hence he/she is not allowed to take an exam.");
