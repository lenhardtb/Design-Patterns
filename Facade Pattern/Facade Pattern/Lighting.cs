using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    public abstract class Lighting
    {
        public const int ON = 255;
        public const int OFF = 0;
        public const int MIDPOINT = (ON + OFF) / 2;
        
        protected int power;
        public virtual int Power
        {
            get
            {
                return power;
            }
            set
            {
                if (power < OFF) power = OFF;
                else if (power > ON) power = ON;
                else
                    power = value;
            }
        }
    }

    public class DialLighting : Lighting
    {
        //this used to be the base class and now it's not any different from the new base class
    }
    public class SwitchLighting : Lighting
    {
        private bool state = false;
        public bool State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
                if (value)
                {
                    Power = ON;
                }
                else
                {
                    Power = OFF;
                }
            }
        }

        public override int Power
        {
            //get is the same, no need to override that
            set
            {
                if (value >= MIDPOINT)
                    power = ON;
                else
                    power = OFF;
            }
        }
    }//class(SwitchLighting)
}//namespace
