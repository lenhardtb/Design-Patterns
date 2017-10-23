using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Observer_Pattern
{
    public partial class MapMaker : Form
    {
        List<RectangleEditor> rects;

        public MapMaker()
        {
            InitializeComponent();

            rects = new List<RectangleEditor>(1);

            add_Editor(this, EventArgs.Empty);
        }

        private void refreshRectangles()
        {
            viewPanel.Controls.Clear();

            foreach (RectangleEditor editor in rects)
            {
                Panel p = new Panel();
                p.Bounds = editor.Rectangle;

                p.BackColor = Color.Gray;
                p.BorderStyle = BorderStyle.FixedSingle;
                viewPanel.Controls.Add(p);
            }
        }

        private Button NewAddButton
        {
            get
            {
                Button b = new Button();
                b.Size = new Size(30, 30);
                b.Location = new Point(0, 0);
                b.Text = "+";
                b.TextAlign = ContentAlignment.MiddleCenter;
                b.Click += add_Editor;

                return b;
            }
        }

        private void add_Editor(object source, EventArgs args)
        {
            RectangleEditor editor = new RectangleEditor();
            editor.Size = new Size(100, 50);
            if (rects.Count == 0)
                editor.Location = new Point(4, 4);
            else
                editor.Location = new Point(4 , rects[rects.Count - 1].Bottom + 4);
            editor.RectangleChanged += delegate (object src, RectangleEventArgs rectArgs)
            {
                refreshRectangles();
            };

            rects.Add(editor);

            rectanglesPanel.Controls.Add(editor);

            //be able to add on another one
            Button b = NewAddButton;
            b.Location = new Point(editor.Right + 3, editor.Top);

            rectanglesPanel.Controls.Add(b);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();

            DialogResult result = dialog.ShowDialog();

            if(result == DialogResult.OK)
            {
                FileInfo file = new FileInfo(dialog.FileName);

                Stream stream = file.OpenWrite();

                BinaryFormatter formatter = new BinaryFormatter();

                foreach(RectangleEditor editor in rects)
                {
                    formatter.Serialize(stream, editor.Rectangle);
                }

                stream.Close();
            }
        }
    }

    public class RectangleEditor : UserControl
    {
        private NumericUpDown x;
        private NumericUpDown y;
        private NumericUpDown width;
        private NumericUpDown height;

        public delegate void RectangleEventHandler(object sender, RectangleEventArgs args);
        public event RectangleEventHandler RectangleChanged;

        public Rectangle Rectangle
        {
            get
            {
                return new Rectangle(
                    (int)x.Value, (int)y.Value, 
                    (int)width.Value, (int)height.Value);
            }
        }

        public RectangleEditor()
        {
            x = new NumericUpDown();
            y = new NumericUpDown();
            width = new NumericUpDown();
            height = new NumericUpDown();

            x.Minimum = int.MinValue;
            x.Maximum = int.MaxValue;
            y.Minimum = int.MinValue;
            y.Maximum = int.MaxValue;
            width.Minimum = int.MinValue;
            width.Maximum = int.MaxValue;
            height.Minimum = int.MinValue;
            height.Maximum = int.MaxValue;


            x.ValueChanged += rect_changed;
            y.ValueChanged += rect_changed;
            width.ValueChanged += rect_changed;
            height.ValueChanged += rect_changed;
            
            Size defaultSize = new Size(40,20);
            x.Size = defaultSize;
            y.Size = defaultSize;
            width.Size = defaultSize;
            height.Size = defaultSize;

            x.Location = new Point(2, 2);
            y.Location = new Point(2, x.Bottom + 2);
            width.Location = new Point(x.Right + 2, 2);
            height.Location = new Point(y.Right + 2, width.Bottom + 2);

            Controls.Add(x);
            Controls.Add(y);
            Controls.Add(width);
            Controls.Add(height);

        }

        private void rect_changed(object sender, EventArgs args)
        {
            RectangleChanged(this, new RectangleEventArgs(Rectangle));
        }
    }

    
    public class RectangleEventArgs : EventArgs
    {
        public Rectangle Rectangle;

        public RectangleEventArgs() { }

        public RectangleEventArgs(Rectangle rect)
        {
            Rectangle = rect;
        }
    }
}
