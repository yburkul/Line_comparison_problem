using System;

namespace Line_Comparison_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 12;
            int x2 = 15;
            int y1 = 10;
            int y2 = 5;
            var Length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Length of Line: " + Length);
        }
    }
}
