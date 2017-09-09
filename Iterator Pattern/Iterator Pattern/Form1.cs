using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iterator_Pattern
{
    public partial class Form1 : Form
    {
        LinkedList list;

        public Form1()
        {
            InitializeComponent();

            list = new LinkedList();
        }

        private void addNameButton_Click(object sender, EventArgs e)
        {
            list.Add(addNameBox.Text);
            addNameBox.Text = "";
        }

        private void removeNameButton_Click(object sender, EventArgs e)
        {
            list.Remove(removeNameBox.Text);
            removeNameBox.Text = "";
        }

        private void refreshBox_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            IEnumerator iterator = list.GetEnumerator();

            while (iterator.MoveNext()) 
            {
                listBox1.Items.Add(iterator.Current == null ? "[null]" : iterator.Current.ToString());
            }//while(iterator.MoveNext())
        }//refreshBox_Click
    }//class(Form1)
}//namespace
