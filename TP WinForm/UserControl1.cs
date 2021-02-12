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
    public partial class UserControl1 : UserControl
    {
        public delegate void DelegateBtn(string button);
        public event DelegateBtn clicButton;


        public UserControl1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (clicButton != null)
            {
                clicButton(((Button)sender).Text);
            }
        }
    }
}
