using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    public class Jet : IFillable
    {
        WaterSource source;
        IFillable output;

        public readonly double GPS;
        private bool state;
        
        //is never really empty or full, it just shoots water out at higher speeds into something else
        public bool IsFull => false;
        public bool IsEmpty => false;

        public Jet(WaterSource source, IFillable output, double gps)
        {
            GPS = gps;
            state = false;

            this.source = source;
            this.output = output;
        }

        public bool State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;

                if (value)//on
                {
                    source.Open(this, GPS);
                }
                else//off
                {
                    source.Close(this);
                }
            }
        }
        
        public bool Empty(double amount)
        {
            //it doesn't really ... contain water
            return false;
        }

        public bool Fill(double amount)
        {
            return output.Fill(amount);
        }
    }//class(Jet)
}//namespace
