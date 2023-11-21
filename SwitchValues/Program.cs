using System.Text;

// Ukrainian lang
Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

int number = 0;
while (number != -1)
{
    Console.Write("Input number you want to convert to text version: ");
    bool valid = int.TryParse(Console.ReadLine(), out number);
    if ((number < 0 || number > 9) && number != -1) valid = false;
    

    if (number == -1) break;

    if(!valid) Console.WriteLine("Incorrect input. Number should be in [0, 9].");
    else if (valid) {
        switch (number)
        {
            case 0:
                Console.WriteLine("Ви ввели нуль. ");
                break;
            case 1:
                Console.WriteLine("Ви ввели один. ");
                break;
            case 2:
                Console.WriteLine("Ви ввели два. ");
                break;
            case 3:
                Console.WriteLine("Ви ввели три. ");
                break;
            case 4:
                Console.WriteLine("Ви ввели чотири. ");
                break;
            case 5:
                Console.WriteLine("Ви ввели п`ять. ");
                break;
            case 6:
                Console.WriteLine("Ви ввели шість. ");
                break;
            case 7:
                Console.WriteLine("Ви ввели сім. ");
                break;
            case 8:
                Console.WriteLine("Ви ввели вісім. ");
                break;
            case 9:
                Console.WriteLine("Ви ввели дев`ять. ");
                break;
        }
    }
}
