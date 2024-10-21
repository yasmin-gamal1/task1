using System;
class program
{
    static void Main()
    {
        int num1, num2, choice;
        bool exit = false;

        Console.Write("Enter the first number: ");
        num1=Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        while (!exit)
        {
            Console.WriteLine("\nHere are the optionS:");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            Console.WriteLine("5 - Exit");

            Console.Write("Enter your choice:");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"The Addition of {num1} and {num2} is: {num1 + num2}");
                    break;

                case 2:
                    Console.WriteLine($"The Subtraction of {num1} and {num2} is: {num1 - num2}");
                    break;
                case 3:
                    Console.WriteLine($"The Multiplication of {num1} and {num2} is: {num1 * num2}");
                    break;
                case 4:
                    if (num2 != 0)

                        Console.WriteLine($"The Division of {num1} and {num2} is: {num1 / (float)num2}");
                    else
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    break;
                    case 5:
                    exit= true;
                    Console.WriteLine("Exiting the program...");
                    break;
                    default:
                    Console.WriteLine("Invalid Choice. please try again.");
                    break ;


            }

        }
    }
}

