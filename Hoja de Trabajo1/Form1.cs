using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoja_de_Trabajo1
{
    public partial class Form1 : Form
    {
        int x;
        int y;
        int resp;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
             x = int.Parse(textBox1.Text);
            y = int.Parse(textBox2.Text);
            resp = x ^ y + (x + y) / x;
            label5.Text = "x^y+(x + y)/x";
            richTextBox1.Text = Convert.ToString(resp);
        }
            catch 
            {
                label5.Text = "datos incorrectos";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                x = int.Parse(textBox1.Text);
                y = int.Parse(textBox2.Text);
                resp = x * y + x ^ 2 / x;
                label5.Text = "x* y+x ^ 2 / x";
                richTextBox1.Text = Convert.ToString(resp);
            }
            catch
            {
                label5.Text = "datos incorrectos";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                x = int.Parse(textBox1.Text);
                y = int.Parse(textBox2.Text);
                resp = x*100 -y + (x^y);
                label5.Text = "x*100 -y + (x^y)";
                richTextBox1.Text = Convert.ToString(resp) + " \n usted escribio x = "+ x +
                    " \n usted escribio y = " + y;
            }
            catch
            {
                label5.Text = "datos incorrectos";
            }
        }
    }
}
