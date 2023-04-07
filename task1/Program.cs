namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter number: ");
            int number2 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number2; i++)
            {
                for (int j = number2; j >= 1; j--)
                {
                    if (i >= j)
                    {
                        Console.Write("* ");
                    }
                    else { Console.Write(" "); }

                }
                Console.WriteLine();
            }

            for (int i = number2; i >= 1; i--)
            {
                for (int j = number2; j >= 2; j--)
                {
                    if (i >= j)
                    {
                        Console.Write(" *");
                    }
                    else { Console.Write(" "); }

                }
                Console.WriteLine();
            }

        }
     }
    }
