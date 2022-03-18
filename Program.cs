using System;

namespace Line_Comparison_Problem
{
    class Comparison
    {
        double Length_of_first_line;
        double Length_of_second_line;
        public void Calculation()
        {
            int x1 = 35;
            int x2 = 15;
            int y1 = 13;
            int y2 = 10;

            Length_of_first_line = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Length of First Line: " + Length_of_first_line);

            int x3 = 22;
            int x4 = 18;
            int y3 = 13;
            int y4 = 10;
            Length_of_second_line = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
            Console.WriteLine("Length of Second Line: " + Length_of_second_line);

            if (Length_of_first_line == Length_of_second_line)
            {
                Console.WriteLine("Length are equal");
            }
            else
            {
                Console.WriteLine("Length are not equal");
            }

            if (Length_of_first_line > Length_of_second_line)
            {
                Console.WriteLine("First line is greater than Second line");
            }
            else
            {
                Console.WriteLine("First line is less than second line");
            }
            Console.WriteLine("Comparison of two length: " + Length_of_first_line.CompareTo(Length_of_second_line));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Comparison comparison = new Comparison();
            comparison.Calculation();
        }
    }
}


