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

            Console.WriteLine("\nWhat should it multiply to?");
            string x = Console.ReadLine();
            Console.WriteLine("\nWhat should it add to?");
            string y = Console.ReadLine();
            Console.WriteLine("\nDoes x^2 have a coefficient?");
            string z = Console.ReadLine();

            int.TryParse(x, out multiply);
            int.TryParse(y, out addition);
            if (int.TryParse(z, out coefficient))
            {
                multiply = multiply * coefficient;
            }

            if (Solve(multiply, addition) is (int a, int b))
            {
                Console.WriteLine($"\nThe two numbers are {a} and {b}");
            }
            else
            {
                Console.WriteLine("\nDoesn't work. Sda.");
            }

            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }

        static (int, int)? Solve(int multiply, int addition)
        {
            int candidate = 1;
            bool mulitplyIsNegative = multiply < 0;

            if (mulitplyIsNegative)
            {
                candidate = -1;
            }

            while (true)
            {
                if (multiply % candidate == 0 && candidate + (multiply / candidate) == addition)
                {
                    return (candidate, multiply / candidate);
                }
                else
                {
                    if (candidate < multiply && candidate > 0 && !mulitplyIsNegative)
                    {
                        candidate++;
                    }
                    else if (candidate > -multiply && candidate < 0 && !mulitplyIsNegative)
                    {
                        candidate--;
                    }
                    else if (candidate > 0 && !mulitplyIsNegative)
                    {
                        candidate = -1;
                    }
                    else if (candidate > multiply && candidate < 0 && mulitplyIsNegative)
                    {
                        candidate--;
                    }
                    else if (candidate < -multiply && candidate > 0 && mulitplyIsNegative)
                    {
                        candidate++;
                    }
                    else if (candidate < 0 && mulitplyIsNegative)
                    {
                        candidate = 1;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }
    }
}
