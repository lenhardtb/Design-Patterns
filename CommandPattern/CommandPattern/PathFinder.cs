using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CommandPattern
{
    /// <summary>
    /// Copied over from another project that needed an A* search algorithm
    /// </summary>
    public class PathFinder
    {
        public static Direction[] path(Point start, Point end, List<Point> obstacles)
        {
            List<PathNode> explored = new List<PathNode>();
            List<PathNode> unexplored = new List<PathNode>();

            //set up obstacles issues
            bool containedEnd = false;
            if (obstacles == null)
                obstacles = new List<Point>();
            else
                containedEnd = obstacles.Remove(end);//make sure we can open into end

            //start searching from first node
            PathNode startNode = new PathNode(start, null);
            explored.Add(startNode);
            unexplored.AddRange(startNode.openNodes());

            PathNode exploring = least(end, unexplored);

            //explore one node
            while (!exploring.Equals(end))
            {
                foreach (PathNode node in exploring.openNodes())
                {
                    if (node.Equals(end))
                    {
                        exploring = node;
                        break;
                    }
                    else if (!explored.Contains(node) && !obstacles.Contains(node))
                        unexplored.Add(node);
                }
                exploring = least(end, unexplored);
                explored.Add(exploring);
                unexplored.Remove(exploring);
            }

            //exploring IS the final node at end of loop
            List<PathNode> path2 = exploring.fullPath();

            Direction[] returner = new Direction[path2.Count];
            for (int i = 0; i < path2.Count; i++)
                returner[i] = path2[i].Dir;

            if (containedEnd)
                obstacles.Add(end);

            return returner;
        }

        public static List<Point> path2(Point start, Point end, List<Point> obstacles)
        {
            List<PathNode> explored = new List<PathNode>();
            List<PathNode> unexplored = new List<PathNode>();

            //set up obstacles issues
            bool containedEnd = false;
            if (obstacles == null)
                obstacles = new List<Point>();
            else
                containedEnd = obstacles.Remove(end);//make sure we can open into end

            //start searching from first node
            PathNode startNode = new PathNode(start, null);

            PathNode exploring = startNode;

            //explore one node
            while (!exploring.Equals(end))
            {
                //open new from existing (if it's at this point it's not the end)
                foreach (PathNode node in exploring.openNodes())
                {
                    if (!explored.Contains(node) && !obstacles.Contains(node))
                        unexplored.Add(node);
                }
                //try the next closest
                exploring = least(end, unexplored);
                //remove/add from lists as appropriate
                explored.Add(exploring);
                unexplored.Remove(exploring);
            }
            //exploring IS the final node at end of loop
            List<PathNode> path = exploring.fullPath();
            List<Point> returner = new List<Point>();
            foreach (PathNode node in path)
                returner.Add(node);


            if (containedEnd)
                obstacles.Add(end);

            return returner;
        }

        private static PathNode least(Point end, List<PathNode> checking)
        {
            Console.Write("Finding least to: " + end.X + "," + end.Y);
            int distance = int.MaxValue;//the distance to beat
            PathNode closest = null;

            int heuristic = int.MaxValue;//saving space bY putting this outside loop
            foreach (PathNode node in checking)
            {
                heuristic = node.heuristic(end);
                if (heuristic < distance)
                {
                    closest = node;
                    distance = heuristic;

                    if (heuristic == 0)
                    {
                        Console.Write("    Foundin " + closest.X + "," + closest.Y);
                        return closest;
                    }
                }
            }
            Console.Write("    Foundin " + closest.X + "," + closest.Y + " - " + heuristic);
            return closest;
        }

    }
    class PathNode
    {
        public PathNode Previous;
        public Direction Dir;
        public int X;
        public int Y;

        public PathNode(int x, int y, PathNode previous)
        {
            this.Previous = previous;
            this.X = x;
            this.Y = y;

            //determine direction
            if (Previous != null)
            {
                if (Y == Previous.Y)
                {
                    if (X > Previous.X)
                    {
                        Dir = Direction.RIGHT;
                    }
                    else
                    {
                        Dir = Direction.LEFT;
                    }
                }
                else
                {
                    if (Y > previous.Y)
                    {
                        Dir = Direction.DOWN;
                    }
                    else
                    {
                        Dir = Direction.UP;
                    }
                }
            }
        }

        public PathNode(Point loc, PathNode previous) : this(loc.X, loc.Y, previous)
        { }

        public int heuristic(Point end)
        {
            return Math.Abs(end.Y - Y) + Math.Abs(end.X - X);
        }

        public List<PathNode> openNodes()
        {
            List<PathNode> nodes = new List<PathNode>(4);

            foreach (Direction dir in DirectionUtils.Values)
            {
                //minor speed improvement - can't go back in upon itself, that is guaranteed to be explored
                //check against null for start node
                if (!(Dir == null) && dir == Dir.Opposite())
                    continue;

                Point newPoint = new Point(0, 0);
                switch (dir)
                {
                    case Direction.LEFT:
                        newPoint = new Point(X - 1, Y);
                        break;
                    case Direction.RIGHT:
                        newPoint = new Point(X + 1, Y);
                        break;
                    case Direction.UP:
                        newPoint = new Point(X, Y - 1);
                        break;
                    case Direction.DOWN:
                        newPoint = new Point(X, Y + 1);
                        break;
                }

                PathNode newNode = new PathNode(newPoint, this);

                nodes.Add(newNode);

            }
            return nodes;
        }

        public List<PathNode> fullPath()
        {
            List<PathNode> path = new List<PathNode>();
            //construct
            PathNode prev = this;
            while (prev != null)
            {
                path.Add(prev);
                prev = prev.Previous;
            }
            //flip
            path.Reverse();

            //return
            return path;
        }

        public override bool Equals(object obj)
        {
            if (obj is Point)
            {
                Point p = (Point)obj;
                return X == p.X && Y == p.Y;
            }
            else if (obj is PathNode)
            {
                PathNode p = (PathNode)obj;
                return X == p.X && Y == p.Y;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return 7 * X + 7 * Y + 7 * Dir.Ordinal();
        }


        public static implicit operator Point(PathNode p)
        {
            return new Point(p.X, p.Y);
        }
        public static explicit operator PathNode(Point p)
        {
            return new PathNode(p, null);
        }
    }

    public static class DirectionUtils
    {
        public static Direction[] Values
        {
            get
            {
                return new Direction[] { Direction.LEFT, Direction.RIGHT, Direction.UP, Direction.DOWN };
            }
        }

        private static Random rnd = new Random();
        public static Direction Random()
        {
            return Values[rnd.Next(4)];
        }

        public static Direction Opposite(this Direction dir)
        {
            switch (dir)
            {
                case Direction.LEFT:
                    return Direction.RIGHT;
                case Direction.RIGHT:
                    return Direction.LEFT;
                case Direction.UP:
                    return Direction.DOWN;
                case Direction.DOWN:
                    return Direction.UP;

            }
            return Direction.DOWN;
        }

        public static int Ordinal(this Direction dir)
        {
            switch (dir)
            {
                case Direction.LEFT:
                    return 0;
                case Direction.RIGHT:
                    return 1;
                case Direction.UP:
                    return 2;
                case Direction.DOWN:
                    return 3;
            }
            return -1;
        }

        public static String ToString(this Direction dir)
        {
            switch (dir)
            {
                case Direction.LEFT:
                    return "LEFT";
                case Direction.RIGHT:
                    return "RIGHT";
                case Direction.UP:
                    return "UP";
                case Direction.DOWN:
                    return "DOWN";
            }
            return null;
        }

        public static Direction ValueOf(String s)
        {
            switch (s)
            {
                case "LEFT":
                    return Direction.LEFT;
                case "RIGHT":
                    return Direction.RIGHT;
                case "UP":
                    return Direction.UP;
                case "DOWN":
                    return Direction.DOWN;
            }
            return Direction.DOWN;
        }//ValueOf
    }//class(DirectionUtils)
}
