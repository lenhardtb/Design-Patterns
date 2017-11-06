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
    public partial class ConcreteAnimationControl : UserControl
    {
        private ConcreteAnimation animation;
        public ConcreteAnimation Animation
        {
            get => animation;
            set
            {
                animation = value;
            }
        }

        public ConcreteAnimationControl():this(new ConcreteAnimation())
        {}

        public ConcreteAnimationControl(ConcreteAnimation c)
        {
            InitializeComponent();
            Animation = c;

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

        #region Name
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
        #endregion

        private void imageBox_Click(object sender, EventArgs e)
        {
            DialogResult result = imageFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    Image i = Image.FromFile(imageFileDialog.FileName);

                    imageBox.Image = i.GetThumbnailImage(imageBox.Width, imageBox.Height, null, IntPtr.Zero);

                    Animation.BaseImage = i;
                }
                catch
                {
                    MessageBox.Show("Error Loading File.");
                }
            }
        }

        #region Translations
        private void startNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Animation.Start = (long)(startNumericUpDown.Value * 1000);
        }

        private void endNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Animation.End = (long)(endNumericUpDown.Value * 1000);
        }

        private void rotationBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(rotationBox.SelectedItem)
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
                String[] broken = text.Split(new char[] { '(', ',', ')' });

                int x = int.Parse(broken[1]);
                int y = int.Parse(broken[3]);

                return new Point(x, y);
            }
            catch
            {
                Console.WriteLine("Point conversion failed: \"" + text + "\"");
                return new Point();
            }
        }
        #endregion

    }//class(ConcreteAnimationControl)
}//namespace
