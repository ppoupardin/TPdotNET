using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class code : UserControl
    {
        public delegate void DelegateBtn(string button);
        public event DelegateBtn clicButton;

        public code()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1
            if (clicButton != null)
            {
                clicButton(((Button)sender).Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //2
            if (clicButton != null)
            {
                clicButton(((Button)sender).Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //3
            if (clicButton != null)
            {
                clicButton(((Button)sender).Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //4
            if (clicButton != null)
            {
                clicButton(((Button)sender).Text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //5
            if (clicButton != null)
            {
                clicButton(((Button)sender).Text);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //6
            if (clicButton != null)
            {
                clicButton(((Button)sender).Text);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //7
            if (clicButton != null)
            {
                clicButton(((Button)sender).Text);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //8
            if (clicButton != null)
            {
                clicButton(((Button)sender).Text);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //9
            if (clicButton != null)
            {
                clicButton(((Button)sender).Text);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //0
            if (clicButton != null)
            {
                clicButton(((Button)sender).Text);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //ok
            if (clicButton != null)
            {
                clicButton(((Button)sender).Text);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //x
            if (clicButton != null)
            {
                clicButton(((Button)sender).Text);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //<
            if (clicButton != null)
            {
                clicButton(((Button)sender).Text);
            }
        }
    }
}
