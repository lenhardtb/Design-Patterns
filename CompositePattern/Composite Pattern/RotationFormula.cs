using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern
{
    /// <summary>
    /// Encapsulates an interface that calculates an angle in radians at a cetain point in time, under certain methods of rotation.
    /// </summary>
    public abstract class RotationFormula
    {
        protected double from;
        protected double change;
        protected long length;

        public double From { get { return from; } set { from = value; } }
        public double Change { get { return change; } set { change = value; } }
        public long Length { get { return length; } set { length = value; } }
        
        public abstract double Angle(long millis); 
    }

    public class NonRotate : RotationFormula
    {
        public NonRotate() : this(0d) { }
        public NonRotate(double angle)
        {
            From = angle;
        }
        public override double Angle(long millis)
        {
            return From;
        }
    }

    public class LinearRotate : RotationFormula
    {
        
        public LinearRotate(double change, long length) 
            : this(0d, change, length)
        {}
        public LinearRotate(double from, double change, long length)
        {
            From = from;
            Change = change;
            Length = length;
        }

        public override double Angle(long millis)
        {
            return (From + Change * millis / Length) % (Math.PI * 2);
        }
    }
}
