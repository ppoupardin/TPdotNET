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
    public partial class Form1 : Form
    {
        public string fuel;
        public Form1()
        {
            InitializeComponent();
            userControl11.clicButton += UserControl11_clicButton;
            fuelChoice1.clicButton += FuelChoice1_clicButton;
            code1.clicButton += Code1_clicButton;
            ticket1.clicButton += Ticket1_clicButton;
            retirercarte1.clicButton += Retirercarte1_clicButton;
        }

        private void Retirercarte1_clicButton(string button)
        {
            if (button == "x")
            {
                label3.Visible = false;
                retirercarte1.Visible = false;
                label2.Visible = false;
                merci1.Visible = false;
                cancel1.Visible = true;
            } else
            {
                label3.Visible = false;
                retirercarte1.Visible = false;
                label2.Visible = true;
                merci1.Visible = true;
            }
        }

        private void Ticket1_clicButton(string button)
        {
            if (button == "x")
            {
                ticket1.Visible = false;
                label3.Visible = false;
                retirercarte1.Visible = false;
                cancel1.Visible = true;
            }
            else
            {
                ticket1.Visible = false;
                label3.Visible = true;
                label3.Text = this.fuel;
                retirercarte1.Visible = true;
            }
        }

        private void Code1_clicButton(string button)
        {
            if(button == "ok")
            {
                code1.Visible = false;
                textBox1.Visible = false;
                ticket1.Visible = true;
            }
            else if (button == "x")
            {
                code1.Visible = false;
                textBox1.Visible = false;
                ticket1.Visible = false;
                cancel1.Visible = true;
            } else if (button == "<")
            {
                textBox1.Text = "";
            } else
            {
                textBox1.Text += button;
            }
        }

        private void FuelChoice1_clicButton(string button)
        {
            if (button == "x")
            {
                code1.Visible = false;
                textBox1.Visible = false;
                fuelChoice1.Visible = false;
                cancel1.Visible = true;
            }
            else
            {
                this.fuel = button;
                code1.Visible = true;
                textBox1.Visible = true;
                fuelChoice1.Visible = false;
            }
        }

        private void UserControl11_clicButton(string button)
        {
            userControl11.Visible = false;
            fuelChoice1.Visible = true;
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
