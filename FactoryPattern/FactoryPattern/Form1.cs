using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryPattern
{
    public partial class Form1 : Form
    {
        DispenserStation wheel = new DispenserStation();

        Slushee cup;

        public Form1()
        {
            InitializeComponent();
            wheel.Add(new CherryDispenser());
            wheel.Add(new BlueRazzDispenser());
            wheel.Add(new GreenAppleDispenser());
            wheel.Add(new OrangeDispenser());
            wheel.Add(new MangoDispenser());
            wheel.Add(new CokeDispenser());

            cup = new Slushee();
        }

        //start adding slushee from current dispenser
        private void leverButton_MouseDown(object sender, MouseEventArgs e)
        {
            dispenseTimer.Start();
            leverButton.Text = "Stop"; ;
        }

        //stop adding slushee from current dispenser
        private void leverButton_MouseUp(object sender, MouseEventArgs e)
        {
            dispenseTimer.Stop();
            leverButton.Text = "Pull";
        }

        private void FillCup(object source, EventArgs args)
        {
            cup += wheel.Current().Dispense(0.875);

            //update content list
            flavorProfileBox.Items.Clear();
            foreach(Flavor f in cup.Flavors)
            {
                String item = "(" + cup.PercentOf(f).ToStringRounded(2) + "%) - " + f.Name;
                flavorProfileBox.Items.Add(item);
            }
            //update amount
            amountLabel.Text = "" + cup.Amount;

            //update color
            Graphics g = colorPanel.CreateGraphics();
            Brush b = new SolidBrush(cup.Color);
            g.FillRectangle(b, colorPanel.ClientRectangle);
        }

        #region Paint dispenser displays
        private void currentDispenserPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(wheel.Current().Flavor.Color), e.ClipRectangle);
        }

        private void previousDispenserPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(wheel.Previous().Flavor.Color), e.ClipRectangle);
        }

        private void nextDispenserPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(wheel.Next().Flavor.Color), e.ClipRectangle);
        }
        #endregion

        private void previousButton_Click(object sender, EventArgs e)
        {
            wheel.MovePrevious();
            //force repaint of all panels
            previousDispenserPanel.Invalidate();
            currentDispenserPanel.Invalidate();
            nextDispenserPanel.Invalidate();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            wheel.MoveNext();
            //force repaint of all panels
            previousDispenserPanel.Invalidate();
            currentDispenserPanel.Invalidate();
            nextDispenserPanel.Invalidate();
        }
    }

    public static class DoubleUtil
    {
        public static String ToStringRounded(this double d, int places)
        {
            double power = Math.Pow(10, places);
            double newAmount = Math.Round(d * power) / power;

            return "" + newAmount;
        }
    }
}
