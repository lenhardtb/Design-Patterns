using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    public class BinaryCharacter : Character
    {
        private int value;
        public int Value
        {
            get
            {
                return this.value;
            }
            set
            {
                if (value > 255 || value < 0) throw new ArgumentException("Character value must be between 0-255");
                this.value = value;
            }
        }

        public BinaryCharacter() { }
        public BinaryCharacter(int value) { Value = value; }

        public override String WrittenForm()
        {
            String flippedBinaryDigits = "";
            int val = Value;

            while(val > 0)
            {
                flippedBinaryDigits += val % 2;
                val = val / 2;
            }

            String returner = (String)(flippedBinaryDigits.Reverse());

            return returner;
        }

        public static implicit operator int(BinaryCharacter b)
        {
            return b.Value;
        }

        public static implicit operator BinaryCharacter(int i)
        {
            return new BinaryCharacter(i);
        }
    }
}
