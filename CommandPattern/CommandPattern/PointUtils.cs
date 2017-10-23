using System.Drawing;

namespace CommandPattern
{
    public static class PointUtils
    {
        public static Point Adjacent(this Point p, Direction d)
        {
            switch (d)
            {
                case Direction.UP:
                    return new Point(p.X, p.Y - 1);
                case Direction.DOWN:
                    return new Point(p.X, p.Y + 1);
                case Direction.LEFT:
                    return new Point(p.X - 1, p.Y + 1);
                case Direction.RIGHT:
                    return new Point(p.X + 1, p.Y - 1);
            }
            //make compiler happy
            return new Point(0,0);
        }

        public static Point Add(this Point a, Point b)
        {
            return new Point(a.X + b.X, a.Y + b.Y);
        }
        public static Point Subtract(this Point a, Point b)
        {
            return new Point(a.X - b.X, a.Y - b.Y);
        }
    }//class(PointUtils)
}//namespace
