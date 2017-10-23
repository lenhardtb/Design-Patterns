using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Observer_Pattern
{
    public partial class Form1 : Form
    {
        IFormatter formatter = new BinaryFormatter();
        bool gamePaused = false;
        bool gameLost = false;
        int points = 0;

        public Form1()
        {
            InitializeComponent();

            foregroundColorDialog.Color = Color.DarkGray;
            backgroundColorDialog.Color = Color.LightGray;
            playAreaPanel.BackColor = Color.LightGray;
        }

        //pressing the space bar starts and stops the game - while focused on it anyway
        private void button_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ' && !gameLost)
            {
                updateTimer.Enabled = !updateTimer.Enabled;
                gamePaused = !gamePaused;
            }
        }

        public void LoadMap(String path)
        {
            FileInfo file = new FileInfo(path);

            if (!file.Exists)
            {
                MessageBox.Show(this, "File not found!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                //this will just create a blank file,
                //so I can see where it was actually referring to 
                //if this was the wrong path - it's an error check
                file.Create();
                
                return;
            }
            
            Stream stream = file.OpenRead();

            Rectangle[] rects = GetRects(stream);

            stream.Close();

            foreach (Rectangle rect in rects)
            {
                Panel newPanel = new Panel();
                newPanel.Bounds = rect;
                newPanel.MouseEnter += LoseGame;
                newPanel.BackColor = foregroundColorDialog.Color;

                playAreaPanel.Controls.Add(newPanel);
            }

            playAreaPanel.VerticalScroll.Value = 0;
        }

        public void LoseGame(object sender, EventArgs args)
        {
            //if the game was paused, then it's okay 
            //that the mouse enetered the panel's area
            if (!gamePaused)
            {
                updateTimer.Stop();

                
                //do other stuff
                points = 0;
                pointsLabel.Text = "0";
            }
        }

        private Rectangle[] GetRects(Stream stream)
        {
            LinkedList<Rectangle> rects = new LinkedList<Rectangle>();

            while(true)
            {
                try
                {
                    rects.AddLast((Rectangle)formatter.Deserialize(stream));
                }
                catch
                {
                    break;
                }
            }

            return rects.ToArray();
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            if(!(playAreaPanel.VerticalScroll.Value < playAreaPanel.VerticalScroll.Value + 5))
                playAreaPanel.VerticalScroll.Value += 5;

            points += 1;
            pointsLabel.Text = "" + points;
        }

        private void foregroundColorButton_Click(object sender, EventArgs e)
        {
            DialogResult result = foregroundColorDialog.ShowDialog();

            if(result == DialogResult.OK)
            {
                foregroundColorButton.BackColor = foregroundColorDialog.Color;

                foreach(Control c in playAreaPanel.Controls)
                {
                    c.BackColor = foregroundColorDialog.Color;
                }
            }
        }

        private void backgroundColorButton_Click(object sender, EventArgs e)
        {
            DialogResult result = backgroundColorDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                backgroundColorButton.BackColor = backgroundColorDialog.Color;
                playAreaPanel.BackColor = backgroundColorDialog.Color;
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            DialogResult result = dialog.ShowDialog();

            if(result == DialogResult.OK)
            {
                try
                {
                    LoadMap(dialog.FileName);
                }
                catch
                {
                    MessageBox.Show("Unsucessful attempt to read file.");
                }
            }
        }

        private void mapMakerButton_Click(object sender, EventArgs e)
        {
            new MapMaker().Show();
        }

        private void button_Click(object sender, EventArgs e)
        {
            updateTimer.Enabled = !updateTimer.Enabled;
            gamePaused = !gamePaused;

            if (gamePaused) button.Text = "Start";
            else button.Text = "Stop";
        }
    }


}
