using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facade_Pattern
{
    public partial class Form1 : Form
    {
        SpaTub tub;

        Timer repaintTimer = new Timer();
        public Form1()
        {
            InitializeComponent();
            WaterSource pipes = new WaterSource(5);
            WaterSink drains = new WaterSink(8);

            tub = new SpaTub(pipes, drains);
            tub.roomLights = new SwitchLighting();

            //needs to have the filling panel reflect the current fill level
            repaintTimer.Interval = 40;
            repaintTimer.Tick += updateUIToCurrent;
            repaintTimer.Start();
        }

        private void updateUIToCurrent(object sender, EventArgs args)
        {
            //needs try/catch because setting these things' values also alters the tub
            //so some operations get changed mid-attempt
            //it's fine, just try again half a second later
            try
            {
                //repaints "tub"
                tubFillPanel.Invalidate();

                faucetBar.Value = (int)(tub.pipes.CurrentFlow(tub) * faucetBar.Maximum / tub.pipes.GPS);
                drainBar.Value = (int)(tub.drains.CurrentFlow(tub) * drainBar.Maximum / tub.drains.GPS);

                bottomFrontJetButton.Text = tub.bottomFrontJet.State ? "On" : "Off";
                bottomBackJetButton.Text = tub.bottomBackJet.State ? "On" : "Off";
                surfaceFrontJetButton.Text = tub.surfaceFrontJet.State ? "On" : "Off";
                surfaceBackJetButton.Text = tub.surfaceBackJet.State ? "On" : "Off";

                internalLightsBar.Value = tub.internalLights.Power;
                roomLightsBar.Value = tub.roomLights.Power;
            }
            catch { }
        }

        private void tubFillPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int height = (int)(tub.WaterLevel / tub.MaxLevel * tubFillPanel.Height); 

            Rectangle rect = new Rectangle(0, tubFillPanel.Height - height, tubFillPanel.Width, height);

            g.FillRectangle(new SolidBrush(Color.Blue), rect);

        }

        private void roomLightsBar_Scroll(object sender, EventArgs e)
        {
            tub.roomLights.Power = roomLightsBar.Value;
        }

        private void internalLightsBar_Scroll(object sender, EventArgs e)
        {
            tub.internalLights.Power = internalLightsBar.Value;
        }

        private void faucetBar_Scroll(object sender, EventArgs e)
        {
            double flowAmount = faucetBar.Value / 100.0;

            tub.pipes.Open(tub, flowAmount);

            if (faucetBar.Value == 0) tub.pipes.Close(tub);

            //force repaint;
            tubFillPanel.Invalidate();
        }

        private void drainBar_Scroll(object sender, EventArgs e)
        {
            double flowAmount = drainBar.Value / 100.0;

            tub.drains.Open(tub, flowAmount);

            if (drainBar.Value == 0) tub.drains.Close(tub);
        }

        private void presetButton_Click(object sender, ColumnClickEventArgs args)
        {
            
        }

        private void surfaceFrontJetButton_Click(object sender, EventArgs e)
        {
            tub.FlipJet(SpaTub.JetPosition.SurfaceFront);
            if(tub.surfaceFrontJet.State)
            {
                surfaceFrontJetButton.Text = "On";
            }
            else
            {
                surfaceFrontJetButton.Text = "Off";
            }
        }

        private void surfaceBackJetButton_Click(object sender, EventArgs e)
        {
            tub.FlipJet(SpaTub.JetPosition.SurfaceBack);
            if (tub.surfaceBackJet.State)
            {
                surfaceBackJetButton.Text = "On";
            }
            else
            {
                surfaceBackJetButton.Text = "Off";
            }
        }

        private void bottomFrontJetButton_Click(object sender, EventArgs e)
        {
            tub.FlipJet(SpaTub.JetPosition.BottomFront);
            if (tub.bottomFrontJet.State)
            {
                bottomFrontJetButton.Text = "On";
            }
            else
            {
                bottomFrontJetButton.Text = "Off";
            }
        }

        private void bottomBackJetButton_Click(object sender, EventArgs e)
        {
            tub.FlipJet(SpaTub.JetPosition.BottomBack);
            if (tub.bottomBackJet.State)
            {
                bottomBackJetButton.Text = "On";
            }
            else
            {
                bottomBackJetButton.Text = "Off";
            }
        }

        private void allJetOnButton_Click(object sender, EventArgs e)
        {
            tub.StartAllJets();
        }

        private void allJetsOffButton_Click(object sender, EventArgs e)
        {
            tub.StopAllJets();
        }

        private void autoFillButton_Click(object sender, EventArgs e)
        {
            tub.StartFilling();
        }

        private void autoDrainButton_Click(object sender, EventArgs e)
        {
            tub.StartDraining();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tub.UseSetting(SpaTub.Preset.Basic);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tub.UseSetting(SpaTub.Preset.Full);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tub.UseSetting(SpaTub.Preset.Wakefulness);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tub.UseSetting(SpaTub.Preset.Night);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tub.UseSetting(SpaTub.Preset.Relaxation);
        }
    }
}//namespace
