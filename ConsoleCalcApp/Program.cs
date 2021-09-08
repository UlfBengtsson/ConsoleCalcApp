using System;

namespace ConsoleCalcApp
{
    class Program
    {
        static void Main(string[] args)
        {

            bool looping = true;

            do
            {
                Console.Clear();
                Console.WriteLine("--- Menu ---\n1: Addition\n2: Subtraction\n3: Multiplication\n4: Division\n9: Quit");

                char selection = Console.ReadKey(true).KeyChar;

                double numberA = 0;
                double numberB = 0;

                //char '1' can be repesented as int number 49
                //char '2' can be repesented as int number 50
                //char '3' can be repesented as int number 51
                //char '4' can be repesented as int number 52
                if (selection >= 49 && selection <= 52)// I only want to ask for numbers if its one of my math menu options
                {
                    numberA = AskUserForNumber("first number");
                    numberB = AskUserForNumber("second number");
                }

                switch (selection)
                {
                    case '1':
                        Console.WriteLine($"{numberA} + {numberB} = {Addition(numberA, numberB)}");
                        break;
                    case '2':
                        Console.WriteLine($"{numberA} - {numberB} = {Subtraction(numberA, numberB)}");
                        break;
                    case '3':
                        Console.WriteLine($"{numberA} * {numberB} = {Multiplication(numberA, numberB)}");
                        break;
                    case '4':
                        Console.WriteLine($"{numberA} / {numberB} = {Division(numberA, numberB)}");
                        break;

                    case '9':
                        looping = false;
                        break;

                    default:
                        Console.WriteLine("Invalid selection");
                        break;
                }

                if (looping)
                {
                    PressAnyKeyTo("continue");
                }
                else
                {
                    PressAnyKeyTo("close this program.\nThanks for using it!");
                }
               

            } while (looping);
        }

        private static double Addition(double numberA, double numberB)
        {
            return numberA + numberB;
        }

        private static double Subtraction(double numberA, double numberB)
        {
            return numberA - numberB;
        }

        private static double Multiplication(double numberA, double numberB)
        {
            return numberA * numberB;
        }

        private static double Division(double numberA, double numberB)
        {
            if (numberB == 0)
            {
                Console.WriteLine("You are dividing by zero! result will be a 8 (infinity symbol turned 90 degrees)");
            }
            return numberA / numberB;
        }

        static double AskUserForNumber(string what)
        {
            bool notNumber = true;
            double number = 0;

            while (notNumber)
            {
                if (double.TryParse(AskUserFor(what), out number))
                {
                    notNumber = false;
                }
                else
                {
                    Console.WriteLine("was not a number, please try once more.");
                }
            }

            return number;
        }

        static string AskUserFor(string what)
        {
            Console.Write($"Please enter {what}: ");
            return Console.ReadLine();
        }

        static void PressAnyKeyTo(string message)
        {
            Console.WriteLine("Press any key to {0}.", message);
            Console.ReadKey(true);
        }
    }
}
