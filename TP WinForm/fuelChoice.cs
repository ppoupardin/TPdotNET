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
    public partial class fuelChoice : UserControl
    {
        public delegate void DelegateBtn(string button);
        public event DelegateBtn clicButton;

        public fuelChoice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sp98
            if (clicButton != null)
            {
                clicButton(((Button)sender).Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //e10
            if (clicButton != null)
            {
                clicButton(((Button)sender).Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //go
            if (clicButton != null)
            {
                clicButton(((Button)sender).Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (clicButton != null)
            {
                clicButton(((Button)sender).Text);
            }
        }
    }
}
