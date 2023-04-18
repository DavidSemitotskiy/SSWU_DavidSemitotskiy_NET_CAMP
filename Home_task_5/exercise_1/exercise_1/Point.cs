using System;

namespace exercise_1
{
    public class Point : ICloneable
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public static double Distance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
        }

        public static Orientation GetOrientation(Point p1, Point p2, Point p3)
        {
            int orientation = ((p3.Y - p2.Y) * (p2.X - p1.X)) - ((p2.Y - p1.Y) * (p3.X - p2.X));
            if (orientation > 0)
            {
                return Orientation.CounterClockWise;
            }

            if (orientation < 0)
            {
                return Orientation.ClockWise;
            }

            return Orientation.Collinear;
        }

        public object Clone()
        {
            return new Point(X, Y);
        }

        public static bool operator == (Point p1, Point p2)
        {
            return p1.X == p2.X && p1.Y == p2.Y;
        }

        public static bool operator != (Point p1, Point p2)
        {
            return !(p1 == p2);
        }
    }
}