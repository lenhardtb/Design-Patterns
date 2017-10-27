using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    public class ASCIICharacter : BinaryCharacter
    {
        //Value is already in BinaryCharacter

        public ASCIICharacter() :base() { }
        public ASCIICharacter(int i) :base(i){ }

        public override string WrittenForm()
        {
            return "" + (char)(Value);
        }
    }
}
