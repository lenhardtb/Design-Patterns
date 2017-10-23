using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class MoveCommand : Command
    {
        public Piece Piece;
        public System.Drawing.Point Change;

        public override void Execute()
        {
            Piece.Location = Piece.Location.Add(Change);
        }

        public override void UnExecute()
        {
            Piece.Location = Piece.Location.Subtract(Change);
        }
    }
}
