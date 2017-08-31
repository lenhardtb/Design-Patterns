using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Singleton_Pattern
{
    public partial class Form1 : Form
    {
        OxfordEnglishDictionary dict;

        LinkedList<Form1> subForms = new LinkedList<Form1>();

        public Form1()
        {
            InitializeComponent();

            dict = OxfordEnglishDictionary.getDictionary();
            
        }

        private void entryBox_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Return)
            {
                String entry = entryBox.Text;

                entryBox.Enabled = false;
                
                Dictionary<String, ICollection<String>> definition = dict.getDefinition(entry);

                entryBox.Enabled = true;

                label.Text = entry.ToUpper() + "\n\n";
                foreach(String type in definition.Keys)
                {
                    label.Text += type + "\n";

                    foreach(String def in definition[type])
                    {
                        label.Text += "    " + def + "\n";
                    }
                    label.Text += "\n";
                }//for each type
            }//if enter pressed
        }//entryBox_KeyPress

        private void entryBox_TextChanged(object sender, EventArgs e)
        {
            String txt = entryBox.Text;

            SizeF size = entryBox.CreateGraphics().MeasureString(txt, entryBox.Font);

            //expand if necessary
            if (size.Width >= entryBox.Width) entryBox.Width = (int)size.Width;
            //cut off at edge of control
            if (entryBox.Right - entryBox.Margin.Right >= Right) entryBox.Width = (Right - entryBox.Margin.Right) - entryBox.Left;
        }

        private void newWindowButton_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Visible = true;
            newForm.Size = Size;
            subForms.AddLast(newForm);

            newForm.FormClosed += delegate (object source, FormClosedEventArgs args) 
            {
                subForms.Remove((Form1)source);
            };
        }
    }
}
