using System;

namespace UC_1_CalculateDistanceBetweenTwoPointsOfLine
{
    class Program
    {
        static void Main(string[] args)
        {
            String X1, X2, Y1, Y2;

            int a1, b1, a2, b2;
            Console.WriteLine("Enter the Co-ordinates of first point as A(x1,y1) : ");
            X1= Console.ReadLine();
            a1 = Convert.ToInt32(X1);
            Y1 = Console.ReadLine();
            b1 = Convert.ToInt32(Y1);
            Console.WriteLine("Enter the Co-ordinates of second point as B(x2,y2) : ");
            X2 = Console.ReadLine();
            a2 = Convert.ToInt32(X2);
            Y2 = Console.ReadLine();
            b2 = Convert.ToInt32(Y2);

            Console.WriteLine("The Distance between two points is : "+Math.Round(distance(a1, b1, a2, b2) * 100000.0 ) / 100000.0);
        }

        static double distance(int x1, int y1, int x2, int y2)
        {
            // Calculating distance
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) * 1.0);
        }
    }
}
