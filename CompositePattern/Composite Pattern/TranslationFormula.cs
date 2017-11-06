using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Composite_Pattern
{
    public abstract class TranslationFormula
    {
        protected Point from;
        public Point From { get { return from; } set { from = value; } }

        protected Point to;
        public Point To { get { return to; } set { to = value; } }

        protected long length;
        public long Length { get { return length; } set { length = value; } }
        
        public abstract Point PointAt(long millis);
    }
    
    public class Static : TranslationFormula
    {
        public Static(Point p)
        {
            From = p;
        }

        public override Point PointAt(long millis)
        {
            return From;
        }
    }

    public class Linear : TranslationFormula
    {
        public long Length;
        
        public Linear(Point from, Point to, long length)
        {
            this.From = from;
            this.To = to;
            this.Length = length;
        }
        
        public override Point PointAt(long millis)
        {
            Point returner = new Point();
            
            //x
             returner.X = (int)((double)millis * (To.X - From.X) / Length) + From.X;
            
            //y
            returner.Y = (int)((double)millis * (To.Y - From.Y) / Length) + From.Y;
            
            return returner;
        }
    }

    ////...we'll figure this one out
    //public static Formula Quadratic(float apexX, float apexY)
    //{
    //    return delegate (double percentThrough, Point from, Point to)
    //    {
    //        Point returner = new Point();


    //        return returner;
    //    };
    //}
}
