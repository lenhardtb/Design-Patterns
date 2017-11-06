using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Composite_Pattern
{
    public partial class CompositeAnimationControl : UserControl
    {
        private CompositeAnimation animation;
        public CompositeAnimation Animation
        {
            get => animation;
            set
            {
                animation = value;

                //set values
            }
        }

        public CompositeAnimationControl():this(new CompositeAnimation())
        {}
        public CompositeAnimationControl(CompositeAnimation c)
        {
            InitializeComponent();
            Animation = c;

            subAnimationBox.MouseDown += subAnimationPanel_MouseDown;

            rotationBox.SelectedIndex = 0;
            startNumericUpDown.Value = 0.000M;
            endNumericUpDown.Value = 0.000M;

            translationBox.SelectedIndex = 0;
            fromLocationTextBox.Text = "(   0,    0)";
            toLocationTextBox.Text = "(   0,    0)";
        }

        
        private void visibleBox_Click(object sender, EventArgs e)
        {
            Animation.Visible = !Animation.Visible;
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {
            nameBox.Visible = true;
            nameBox.BringToFront();
            nameBox.Focus();
        }
        private void nameBox_LeaveFocus(object sender, EventArgs e)
        {
            Animation.Name = nameBox.Text;
            nameLabel.Text = nameBox.Text;
            nameBox.Visible = false;
        }
        private void nameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nameLabel.Focus();//cause text box to lose focus
            }
        }

        #region Transformations
        private void rotationBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (rotationBox.SelectedItem)
            {
                case "(none)":
                    Animation.Rotation = new NonRotate(((double)initialAngleNumericUpDown.Value * Math.PI / 180));
                    break;
                case "Linear":
                    Animation.Rotation = new LinearRotate(
                        (double)initialAngleNumericUpDown.Value * Math.PI / 180, //initial
                        (double)angleChangeNumericUpDown.Value * Math.PI / 180,  //change
                        Animation.Start - Animation.End);        //length (time in millis)
                    break;
            }
        }

        private void initialAngleNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Animation.Rotation.From = (double)initialAngleNumericUpDown.Value;
        }

        private void angleChangeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Animation.Rotation.From = (double)angleChangeNumericUpDown.Value;
        }

        private void translationBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (translationBox.SelectedItem)
            {
                case "(none)":
                    Animation.Translation = new Static(PointFromText(fromLocationTextBox.Text));
                    break;
                case "Linear":
                    Animation.Translation = new Linear(
                        PointFromText(fromLocationTextBox.Text), //start
                        PointFromText(toLocationTextBox.Text),   //end
                        Animation.Start - Animation.End);        //length (time in millis)
                    break;
            }
        }

        private void fromLocationTextBox_TextChanged(object sender, EventArgs e)
        {
            Animation.Translation.From = PointFromText(fromLocationTextBox.Text);
        }

        private void toLocationTextBox_TextChanged(object sender, EventArgs e)
        {
            Animation.Translation.To = PointFromText(toLocationTextBox.Text);
        }

        private Point PointFromText(String text)
        {
            try
            {
                String[] broken = text.Split(new char[] { '(', ',', ')', ' ' });

                int x = -1;
                int y = -1;

                foreach (String s in broken)
                {
                    int val = -1;
                    if(int.TryParse(s, out val))
                    {
                        if(x == -1)
                        {
                            x = val;
                        }
                        else
                        {
                            y = val;
                            break;
                        }
                    }
                }

                if (x == -1 || y == -1) throw new Exception();

                return new Point(x, y);
            }
            catch
            {
                return new Point(0, 0);
            }
        }
        #endregion

        #region Adding Sub Animations
        Control rightClickContext;
        private void subAnimationPanel_MouseDown(object sender, MouseEventArgs e)
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
            animationControl.Animation.Parent = Animation;
            Animation.Add(animationControl.Animation);
            subAnimationPanel.Controls.Add(animationControl);
        }
        private void addGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompositeAnimationControl animationControl = new CompositeAnimationControl();
            animationControl.Animation.Parent = Animation;
            Animation.Add(animationControl.Animation);
            subAnimationPanel.Controls.Add(animationControl);
        }
        
        private void subAnimationPanel_ControlAddedOrRemoved(object sender, ControlEventArgs e)
        {
            VerticallyArrangeContents(subAnimationPanel, false);
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
    }
}
