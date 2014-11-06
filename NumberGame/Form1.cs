using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGame
{
    public partial class Form1 : Form
    {
        int[] val = { 0, 0, 2, 2, 3 };
        int c = -1,count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = val[1].ToString();
            button2.Text = val[2].ToString();
            button3.Text = val[3].ToString();
            button4.Text = val[4].ToString();
            label1.Text = val[0].ToString();
            label2.Text = "";
            label3.Text = "+";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            update(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            update(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            update(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            update(4);
        }

        private void update(int button)
        {
            int v = -1 * (((count % 2) * 2) - 1);
            if (-1 == v)
            {
                label3.Text = "+";
            }
            else if (1 == v)
            {
                label3.Text = "-";
            }
            v *= val[button];
            count++;
            label1.Text = count.ToString();
            for (int i = 1; i <= 4; i++)
            {
                if (i == button)
                {
                    continue;
                }
                val[i] += v;
            }
            if (160 <= label2.Text.Length)
            {
                label2.Text = "Scrub";
                label2.Text += "          \n";
                label2.Text += "          ";
                label2.Text += "          \n";
                label2.Text += "          ";
                label2.Text += "          \n";
                label2.Text += "          ";
                label2.Text += "          \n";
                label2.Text += "          ";
                label2.Text += "          \n";
                label2.Text += "          ";
                label2.Text += "          \n";
                label2.Text += "          ";
                label2.Text += "          \n";
                label2.Text += "          ";
                label2.Text += "          \n";
                label2.Text += "          ";
            }
            else
            {
                label2.Text += button.ToString();
            }
            switch (button)
            {
                case 1:
                    button2.Text = val[2].ToString();
                    button3.Text = val[3].ToString();
                    button4.Text = val[4].ToString();
                    break;
                case 2:
                    button1.Text = val[1].ToString();
                    button3.Text = val[3].ToString();
                    button4.Text = val[4].ToString();
                    break;
                case 3:
                    button1.Text = val[1].ToString();
                    button2.Text = val[2].ToString();
                    button4.Text = val[4].ToString();
                    break;
                case 4:
                    button1.Text = val[1].ToString();
                    button2.Text = val[2].ToString();
                    button3.Text = val[3].ToString();
                    break;
                default:
                    break;
            }
            if (0 == (label2.Text.Length - c) % 20 && label2.Text.Length > 1)
            {
                label2.Text += "\n";
            }
            if (val[1] == val[2] && val[2] == val[3] && val[3] == val[4])
            {
                label1.Text = "You won in " + label1.Text + " moves!";
            }
        }
    }
}
