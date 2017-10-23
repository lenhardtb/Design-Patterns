using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandPattern
{
    public partial class Form1 : Form
    {
        const int GridSize = 7;
        private Stack<Command> undoStack;
        private Stack<Command> redoStack;

        private bool dragging = false;
        private Control dragStartPanel;

        private Point relativeToPiece;
        private MoveCommand currentCommand;

        private List<Piece> pieces;

        public Form1()
        {
            InitializeComponent();

            pieces = new List<Piece>();
            undoStack = new Stack<Command>();
            redoStack = new Stack<Command>();

            
            LoadGame();
        }

        public void SpacePanel_MouseDown(object source, MouseEventArgs args)
        {
            Control sourcePanel = (Control)source;//activating panel - will use its relative location to get source within table
            Point tableMouseCoordinates = sourcePanel.Location.Add(new Point(args.X, args.Y));
            sourcePanel = tablePanel.GetChildAtPoint(tableMouseCoordinates);
            Point location = getCoordinatesOf(sourcePanel);
            Piece currentPiece = getPieceAt(location);
            
            if (currentPiece == null) return;

            //create command
            currentCommand = new MoveCommand();
            currentCommand.Piece = currentPiece;
            currentCommand.Change = new Point();

            //do dragging
            dragging = true;
            dragStartPanel = sourcePanel;
            relativeToPiece = currentPiece.Location.Subtract(location);
        }
        public void SpacePanel_DragEnter(object source, EventArgs args)
        {
            //Control sourceControl = (Control)source;//activating panel - will use its relative location to get source within table
            //Point tableCoordinates = sourceControl.Location.Add(new Point(args.X, args.Y));
            //sourceControl = tablePanel.GetChildAtPoint(tableCoordinates);
            
            //currentCommand.Change = getCoordinatesOf(sourceControl)
            //    .Subtract(currentCommand.Piece.Location);

        }
        public void SpacePanel_DragLeave(object source, EventArgs args)
        {
            if (!dragging) return;

            //repaint to possibly stop highlight
            //((Panel)source).Invalidate();
        }
        public void SpacePanel_DragDrop(object source, MouseEventArgs args)
        {
            if (!dragging) return;

            dragging = false;

            //don't make a move if no moving occured
            Control sourceControl = (Control)source;//activating panel - will use its relative location to get source within table
            Point tableMouseCoordinates = sourceControl.Location.Add(new Point(args.X, args.Y));
            sourceControl = tablePanel.GetChildAtPoint(tableMouseCoordinates);
            if (sourceControl == dragStartPanel) return;

            currentCommand.Change = getCoordinatesOf(sourceControl)
                .Subtract(currentCommand.Piece.Location).Add(relativeToPiece);

            //only vertical or horizontal moves allowed
            if (currentCommand.Change.X != 0 && currentCommand.Change.Y != 0) return;

            //determine if valid move
            for (int i = 0; i < GridSize; i++)
            {
                for (int o = 0; o < GridSize; o++)//check each point
                {
                    Point testPoint = new Point(i, o);
                    foreach (Piece p in pieces)//check each existing piece
                    {
                        //ignore new position conflicting with current position of itself
                        if (currentCommand.Piece == p) continue;

                        //check if new location causes a conflict with an existing piece
                        if (p.ContainsPoint(testPoint) &&
                            currentCommand.Piece.WouldContainPointIfMoved(currentCommand.Change, testPoint))
                            return;

                    }
                }
            }
            
            //execute command
            currentCommand.Execute();
            undoStack.Push(currentCommand);
            undoButton.Enabled = true;
            //clear redo stack
            redoStack.Clear();
            redoButton.Enabled = false;

            Refresh();
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            Command c = undoStack.Pop();
            c.UnExecute();
            redoStack.Push(c);
            redoButton.Enabled = true;
            if (undoStack.Count == 0) undoButton.Enabled = false;

            Refresh();
        }

        private void redoButton_Click(object sender, EventArgs e)
        {
            Command c = redoStack.Pop();
            c.Execute();
            undoStack.Push(c);
            if (redoStack.Count == 0) redoButton.Enabled = false;
            undoButton.Enabled = true;
            Refresh();
        }

        private void spacePanel_Paint(object sender, PaintEventArgs args)
        {
            Panel spacePanel = (Panel)sender;
            Point coord = getCoordinatesOf(spacePanel);
            Piece piece = getPieceAt(coord);

            Color fillColor = Color.LightGray;
            if(piece != null)
            {
                fillColor = piece.Color;
            }
            else if(dragging && 
                currentCommand.Piece.WouldContainPointIfMoved(currentCommand.Change, coord))
            {
                //highlight - lighter version of piece color
                Color start = currentCommand.Piece.Color;
                int newR = start.R + (255 - start.R) / 2;
                int newG = start.G + (255 - start.G) / 2;
                int newB = start.B + (255 - start.B) / 2;

                fillColor = Color.FromArgb(newR, newG, newB);
                fillColor = Color.LightBlue;
            }
            else
            {
                fillColor = Color.LightGray;
            }

            args.Graphics.FillRectangle(new SolidBrush(fillColor), args.Graphics.ClipBounds);
        }

        /// <summary>
        /// Returns a Point representing the ro and column of the panel's location in the table
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        private Point getCoordinatesOf(Control p)
        {
            int x = tablePanel.GetColumn(p);
            int y = tablePanel.GetRow(p);
            return new Point(x, y);
        }

        /// <summary>
        /// Returns a single piece whose current area contains the given point. 
        /// Written with the assumption that there is only one piece that could contain that point.
        /// (Which is true if the game hasn't broken)
        /// </summary>
        /// <param name="p">A point</param>
        /// <returns></returns>
        private Piece getPieceAt(Point p)
        {
            foreach(Piece pc in pieces)
            {
                if (pc.ContainsPoint(p))
                    return pc;
            }
            return null;
        }

        public void LoadGame()
        {
            tablePanel.RowCount = GridSize;
            tablePanel.ColumnCount = GridSize;

            tablePanel.ColumnStyles.Clear();
            tablePanel.RowStyles.Clear();
            for (int i = 0; i < GridSize; i++)
            {
                tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F / GridSize));
                tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F / GridSize));
            }

            for (int i = 0; i < GridSize; i++)
            {
                for (int o = 0; o < GridSize; o++)
                {
                    Panel panel = new Panel();
                    //panel.AllowDrop = true;
                    panel.MouseDown += SpacePanel_MouseDown;
                    panel.MouseEnter += SpacePanel_DragEnter;
                    panel.MouseLeave += SpacePanel_DragLeave;
                    panel.MouseUp += SpacePanel_DragDrop;

                    panel.Paint += spacePanel_Paint;
                    tablePanel.Controls.Add(panel, o, i);
                }
            }

            Piece player = new Piece(new Point[] { new Point(0,1) });
            player.Location = new Point(3,5);
            player.Color = Color.Yellow;

            Piece piece1 = new Piece(new Point[] {
                new Point(1,0), new Point(0,1), new Point(1,1)});
            piece1.Location = new Point(3, 3);
            piece1.Color = Color.Orange;

            Piece piece2 = new Piece(new Point[] {
                new Point(1,0), new Point(2,0)});
            piece2.Location = new Point(1, 1);
            piece2.Color = Color.DarkBlue;

            pieces.Add(player);
            pieces.Add(piece1);
            pieces.Add(piece2);

            //generate borders
            for(int i = 0; i < GridSize; i++)
            {
                Piece edge = new Piece();
                edge.Location = new Point(-1, i);
                pieces.Add(edge);

                edge = new Piece();
                edge.Location = new Point(GridSize, i);
                pieces.Add(edge);

                edge = new Piece();
                edge.Location = new Point(i, -1);
                pieces.Add(edge);

                edge = new Piece();
                edge.Location = new Point(i, GridSize);
                pieces.Add(edge);
            }
        }
    }//class(Form1)
}//namespace
