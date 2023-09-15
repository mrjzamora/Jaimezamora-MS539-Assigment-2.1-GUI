using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jaime_Zamora___Assignment_2._1_GUI
{
    public partial class Form1 : Form
    {
        int num1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Have a wonderful day!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out num1))
            {
                MessageBox.Show("valid int");
            }
            else
            {
                MessageBox.Show("NOt Valid");
            }



        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

