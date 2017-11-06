using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Composite_Pattern
{
    public static class MyUtils
    {
        #region Image
        public static Point Center(this Image i)
        {
            return new Point(i.Width / 2, i.Height / 2);
        }//Center() - extension of Image

        public static Image Rotate(this Image i, double rad)
        {
            return i.Rotate(i.Center(), rad);
        }//Rotate() - extension of Image
        public static Image Rotate(this Image i, Point center, double rad)
        {
            if (rad == 0d) return i;

            Bitmap pixelReader = new Bitmap(i);//need to be able to read pixels

            Size size = i.RotatedSize(center, rad);
            //this assumes it's a square and that center is the center ... calculate later
            //maximum extra size needed is 45 degrees, meaning the diagonal (now horizontal/vertical) distance is sqrt(2) * original
            Bitmap returner;// = new Bitmap((int)(i.Width * Math.Sqrt(2)) + 1, (int)(i.Height * Math.Sqrt(2)) + 1);
            returner = new Bitmap(size.Width, size.Height);
            //make entire image transparent
            returner.MakeTransparent(returner.GetPixel(0, 0));
            Point newCenter = returner.Center();

            //for each rotated pixel in new image, find the equivalent pixel in original and set color
            for (int x = 0; x < returner.Width; x++)
            {
                for (int y = 0; y < returner.Height; y++)
                {
                    Point oldPoint = new Point(x, y).Rotate(center, -rad);

                    //ignore if calculated pixel was out of bounds
                    if (oldPoint.X >= pixelReader.Width || oldPoint.X < 0 || oldPoint.Y >= pixelReader.Height || oldPoint.Y < 0)
                        continue;

                    Color pixel = pixelReader.GetPixel(oldPoint.X, oldPoint.Y);
                    
                    returner.SetPixel(x, y, pixel);
                }
            }

            return returner;
        }//Rotate() - extension of Image
        public static Size RotatedSize(this Image i, Point center, double angle)
        {
            Point newTopLeftCorner = new Point(0, 0).Rotate(center, angle);
            Point newTopRightCorner = new Point(i.Width, 0).Rotate(center, angle);
            Point newBottomLeftCorner = new Point(0, i.Height).Rotate(center, angle);
            Point newBottomRightCorner = new Point(i.Width, i.Height).Rotate(center, angle);
            
            int maxX = Math.Max(Math.Max(newTopLeftCorner.X, newTopRightCorner.X), Math.Max(newBottomLeftCorner.X, newBottomRightCorner.X));
            int minX = Math.Min(Math.Min(newTopLeftCorner.X, newTopRightCorner.X), Math.Min(newBottomLeftCorner.X, newBottomRightCorner.X));
            int newWidth = maxX - minX;

            int maxY = Math.Max(Math.Max(newTopLeftCorner.Y, newTopRightCorner.Y), Math.Max(newBottomLeftCorner.Y, newBottomRightCorner.Y));
            int minY = Math.Min(Math.Min(newTopLeftCorner.Y, newTopRightCorner.Y), Math.Min(newBottomLeftCorner.Y, newBottomRightCorner.Y));
            int newHeight = maxY - minY;

            return new Size(newWidth, newHeight);
        }
        #endregion

        #region Point
        public static Point Add(this Point a, Point b)
        {
            return new Point(a.X + b.X, a.Y + b.Y);
        }//Add - extension of Point
        public static Point Subtract(this Point a, Point b)
        {
            return new Point(a.X - b.X, a.Y - b.Y);
        }//Subtract - extension of Point
        public static Point Rotate(this Point p, Point center, double angle)
        {
            int dx = (p.X - center.X);
            int dy = (p.Y - center.Y);
            
            double distance = Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dy, 2));
            
            //prevent dividebyzero
            double oldAngle;
            if (dx == 0)
            {
                if (dy > 0)
                    oldAngle = Math.PI / 2;
                else if (dy < 0)
                    oldAngle = Math.PI * 3 / 2;
                else//both are 0. point is center
                    oldAngle = 0;//angle irrelevant
            }
            else
            {
                oldAngle = Math.Atan((double)dy / dx);
                if (dx < 0)
                    oldAngle += Math.PI;
            }
            
            
            double newAngle = (oldAngle + angle) % (Math.PI * 2);
            if (newAngle < 0) newAngle += Math.PI * 2;

            int newdX = (int)(distance * Math.Cos(newAngle));
            int newdY = (int)(distance * Math.Sin(newAngle));
            
            return new Point(newdX + center.X, newdY + center.Y);
        }
        #endregion
    }//MyUtils
}//namespace
