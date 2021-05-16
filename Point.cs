using System;

namespace ObjectPractice{
    
    class Point
    {
        public readonly int X;
        public readonly int Y;

        public Point(int x, int y){
            X = x;
            Y = y;
        }

        public int DistanceTo(int x, int y)
        {
            /* Same as the other return below
            int xDiff = X - x;
            int yDiff = Y - y;

            int xDiffSquared = xDiff *xDiff;
            int yDiffSquared = yDiff *yDiff;

            return (int)Math.Sqrt(xDiffSquared + yDiffSquared);
            */

            return (int)Math.Sqrt(Math.Pow(X-x, 2) + Math.Pow(Y-y, 2));

        }

        //Overloading the method, having two methods with dame name but take different parameters
        public int DistanceTo(Point point)
        {
            return DistanceTo(point.X, point.Y);
        }
    }
}