using System;
using System.Windows.Forms;

namespace Binomial_theorem
{
    public partial class Form1 : Form
    {
        int Kaijo(int x)
        {
            int a = 1;
            for(int i = 1; i <= x; i++)
            {
                a *= i;
            }
            return a;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text += "";
            int r = 0;
            bool a;
            do
            {
                try
                {
                    r = int.Parse(textBox1.Text);
                    a = true;
                }
                catch (SystemException)
                {
                    a = false;
                }
            } while (!a);
            for(int i = 0; i <= r; i++)
            {
                label1.Text += Kaijo(r) / Kaijo(r - i) / Kaijo(i);
                if (r - i != 0)
                {
                    label1.Text += "x^";
                    label1.Text += r - i;
                }
                if (i != 0)
                {
                    label1.Text += "y^";
                    label1.Text += i;
                }
                if (i != r)
                {
                    label1.Text += " + ";
                }
            }
        }
    }
}
