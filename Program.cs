using System;

namespace nonmonicsolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiply = 0;
            int addition = 0;
            int coefficient = 0;
            bool multiplyIsNegative = false;

            Console.WriteLine("\nWhat should it multiply to?");
            string x = Console.ReadLine();
            Console.WriteLine("\nWhat should it add to?");
            string y = Console.ReadLine();
            Console.WriteLine("\nDoes x^2 have a coefficient?");
            string z = Console.ReadLine();

            int candidate = 1;
            int.TryParse(x, out multiply);
            int.TryParse(y, out addition);
            if (int.TryParse(z, out coefficient))
            {
                multiply = multiply * coefficient;
            }

            if (multiply < 0)
            {
                multiplyIsNegative = true;
                candidate = -1;
            }

            while (true)
            {
                if (multiply % candidate == 0 && candidate + (multiply / candidate) == addition)
                {
                    Console.WriteLine($"\nThe two numbers are {candidate} and {(multiply / candidate)}");
                    Console.WriteLine("Press enter to exit");
                    Console.ReadLine();
                    return;
                }
                else
                {
                    if (candidate < multiply && candidate > 0 && !multiplyIsNegative)
                    {
                        candidate++;
                    }
                    else if (candidate > -multiply && candidate < 0 && !multiplyIsNegative)
                    {
                        candidate--;
                    }
                    else if (candidate > 0 && !multiplyIsNegative)
                    {
                        candidate = -1;
                    }
                    else if (candidate > multiply && candidate < 0 && multiplyIsNegative)
                    {
                        candidate--;
                    }
                    else if (candidate < -multiply && candidate > 0 && multiplyIsNegative)
                    {
                        candidate++;
                    }
                    else if (candidate < 0 && multiplyIsNegative)
                    {
                        candidate = 1;
                    }
                    else
                    {
                        Console.WriteLine("\nDoesn't work. Sda.");
                        Console.WriteLine("Press enter to exit");
                        Console.ReadLine();
                        break;
                    }
                }
            }
        }
    }
}