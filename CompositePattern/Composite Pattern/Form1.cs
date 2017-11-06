using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Composite_Pattern
{
    public partial class Form1 : Form
    {
        //the invisible CompositeAnimation that contains editable animations
        private CompositeAnimation a = new CompositeAnimation();

        public Form1()
        {
            InitializeComponent();

            timeBar.SmallChange = 2;
            filmLengthNumericUpDown.Value = 3;

            editPanel.MouseDown += context_MouseDown;
            viewPanel.MouseDown += context_MouseDown;
        }

        private void viewPanel_Paint(object sender, PaintEventArgs e)
        {
            Point translation = a.Translation.PointAt(timeBar.Value);
            e.Graphics.DrawImage(a.Image(timeBar.Value), translation);
        }

        private void timeBar_ValueChanged(object sender, EventArgs e)
        {
            viewPanel.Invalidate();
        }

        Control rightClickContext;
        private void context_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                rightClickContext = (Control)sender;
                addItemsContextMenuStrip.Show(rightClickContext, new Point(e.X, e.Y));
            }
        }
        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConcreteAnimationControl animationControl = new ConcreteAnimationControl();
            animationControl.Animation.Parent = a;
            a.Add(animationControl.Animation);
            editPanel.Controls.Add(animationControl);
        }
        private void addGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompositeAnimationControl animationControl = new CompositeAnimationControl();
            animationControl.Animation.Parent = a;
            a.Add(animationControl.Animation);
            editPanel.Controls.Add(animationControl);
        }

        private void editPanel_ControlAddedOrRemoved(object sender, ControlEventArgs e)
        {
            VerticallyArrangeContents(editPanel, false);
        }

        private void filmLengthNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            timeBar.Maximum = (int)(filmLengthNumericUpDown.Value * 1000);
        }

        private void framerateNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            timeBar.SmallChange = (int)(1000 / framerateNumericUpDown.Value);
        }

        #region helpers
        private void ShowImage(Image image)
        {
            Form form = new Form();
            form.Size = new Size(image.Size.Width, image.Size.Height + 20);

            PictureBox box = new PictureBox();
            box.Image = image;
            box.Location = new Point(0, 0);
            box.Dock = DockStyle.Fill;

            form.Controls.Add(box);
            form.Location = Location;

            form.Show();
        }
        
        /// <summary>
        /// Arranges the contents of the container vertically.
        /// </summary>
        /// <param name="container"></param>
        /// <param name="recursing"></param>
        public static void VerticallyArrangeContents(Control container, bool recursing)
        {
            Control previous = null;
            foreach (Control c in container.Controls)
            {
                //ignore arranging if it's not there for the user
                if (c.Visible)
                {
                    if (recursing)
                    {
                        VerticallyArrangeContents(c, recursing);
                    }

                    if (previous == null)//first
                    {
                        Console.WriteLine("First done");
                        c.Location = new Point(2, 0);
                    }
                    else
                    {
                        c.Location = new Point(2, previous.Bottom + 2);
                    }

                    previous = c;
                }//if(control is visible)
            }//foreach(control in container's controls)
        }//VerticallyArrangeContents
        #endregion
        
        
    }//class(Form1)
}//namespace
