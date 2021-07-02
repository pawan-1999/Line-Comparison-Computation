using System;

namespace UC_1_CalculateDistanceBetweenTwoPointsOfLine
{
    class Program
    {
        static void Main(string[] args)
        {
            //For firts line distance:
            String X1, X2, Y1, Y2;

            int a1, b1, a2, b2;

            Console.WriteLine("For First Line length : ");
            Console.WriteLine("Enter the Co-ordinates of first point as A(x1,y1) : ");
            X1 = Console.ReadLine();
            a1 = Convert.ToInt32(X1);
            Y1 = Console.ReadLine();
            b1 = Convert.ToInt32(Y1);

            Console.WriteLine("Enter the Co-ordinates of second point as B(x2,y2) : ");
            X2 = Console.ReadLine();
            a2 = Convert.ToInt32(X2);
            Y2 = Console.ReadLine();
            b2 = Convert.ToInt32(Y2);

            String p1, p2, q1, q2;

            int x1, x2, y1, y2;

            Console.WriteLine("For second line length : ");
            Console.WriteLine("Enter the Co-ordinates of first point as C(x1,y1) : ");
            p1 = Console.ReadLine();
            x1 = Convert.ToInt32(p1);
            q1 = Console.ReadLine();
            y1 = Convert.ToInt32(q1);

            Console.WriteLine("Enter the Co-ordinates of second point as D(x2,y2) : ");
            p2 = Console.ReadLine();
            x2 = Convert.ToInt32(p2);
            q2 = Console.ReadLine();
            y2 = Convert.ToInt32(q2);

            Console.WriteLine("The length of 1st line is : " + Math.Round(distance(a1, b1, a2, b2) * 100000.0) / 100000.0);
            Console.WriteLine("The length of 2nd line is : " + Math.Round(distance(x1, y1, x2, y2) * 100000.0) / 100000.0);

            double s1, s2;
            string f1, f2;

            s1 = Math.Round(distance(a1, b1, a2, b2) * 100000.0) / 100000.0;
            f1 = Convert.ToString(s1);
            s2 = Math.Round(distance(x1, y1, x2, y2) * 100000.0) / 100000.0;
            f2 = Convert.ToString(s2);

            UC_3_ToCompareTwoLines a = new UC_3_ToCompareTwoLines();
            a.compareTwoLine(f1, f2);
        }
        static double distance(int x1, int y1, int x2, int y2)
        {
            // Calculating distance
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) * 1.0);
        }
    }
}


using System;
using System.Collections.Generic;
using System.Text;

namespace UC_1_CalculateDistanceBetweenTwoPointsOfLine
{
    class UC_3_ToCompareTwoLines
    {
        public void compareTwoLine( String a, String b)
        {
            double c;
            c = a.CompareTo(b);

            if (c == 0)
            {
                Console.WriteLine("The lengths of two line is equal");
            }
            else if (c > 0)
            {
                Console.WriteLine("Length of first line is greater than length of second line");
            }
            else
            {
                Console.WriteLine("Length of first line is less than length of second line");
            }
        }
    }
}

