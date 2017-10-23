using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CommandPattern
{
    public enum Direction { UP, DOWN, LEFT, RIGHT };
    public class Piece
    {
        public delegate void PieceMovedHandler(object source, PieceMovedEventArgs args);
        public event PieceMovedHandler Moved;

        private Point location;

        //relative points, e.g. if it has (0,-1) 
        //then it has the location and one above it
        private Point[] relativePoints;
        public Color Color;

        public Piece() : this(new Point[] { }) { }
        public Piece(Point[] relativePoints) : this(relativePoints, Color.Gray) { }
        public Piece(Point[] relativePoints, Color c)
        {
            this.relativePoints = relativePoints;
            Color = c;
        }

        public Point Location
        {
            get
            {
                return location;
            }
            set
            {
                location = value;

                if(Moved != null)
                    Moved(this, new PieceMovedEventArgs(this));
            }
        }

        public void Move(Direction d)
        {
            Location = Location.Adjacent(d);
        }

        public bool ContainsPoint(Point p)
        {
            if (Location.Equals(p)) return true;

            foreach (Point relation in relativePoints)
            {
                if(Location.Add(relation).Equals(p))
                {
                    return true;
                }
            }

            return false;
        }

        public bool WouldContainPointIfMoved(Point move, Point p)
        {
            Point basePoint = Location.Add(move);

            if (basePoint.Equals(p)) return true;

            foreach (Point relation in relativePoints)
            {
                if (basePoint.Add(relation).Equals(p))
                {
                    return true;
                }
            }

            return false;
        }
    }

    public class PieceMovedEventArgs: EventArgs
    {
        public Piece Piece;
        public Point Location;

        public PieceMovedEventArgs(Piece p)
        {
            Piece = p;
            Location = p.Location;
        }
    }
}//namespace
