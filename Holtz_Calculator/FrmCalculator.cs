using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Holtz_Calculator
{
    public partial class FrmCalculator : Form
    {
        public FrmCalculator()
        {
            InitializeComponent();
        }
        private void FrmCalculator_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad1:
                    txtVisor.Text += "1";
                    break;
                case Keys.NumPad2:
                    txtVisor.Text += "2";
                    break;
                case Keys.NumPad3:
                    txtVisor.Text += "3";
                    break;
                case Keys.NumPad4:
                    txtVisor.Text += "4";
                    break;
                case Keys.NumPad5:
                    txtVisor.Text += "5";
                    break;
                case Keys.NumPad6:
                    txtVisor.Text += "6";
                    break;
                case Keys.NumPad7:
                    txtVisor.Text += "7";
                    break;
                case Keys.NumPad8:
                    txtVisor.Text += "8";
                    break;
                case Keys.NumPad9:
                    txtVisor.Text += "9";
                    break;
                case Keys.NumPad0:
                    txtVisor.Text += "0";
                    break;
                case Keys.Multiply:
                    txtVisor.Text += "*";
                    break;
                case Keys.Divide:
                    txtVisor.Text += "/";
                    break;
                /*case Keys.:
                    txtVisor.Text += "*";
                    break;*/
            }
        }

        private void BtnOne_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "1";
        }

        private void BtnTwo_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "2";
        }

        private void BtnTrue_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "3";
        }

        private void BtnFour_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "4";
        }

        private void BtnFive_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "5";
        }

        private void BtnSix_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "6";
        }

        private void BtnSeven_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "7";
        }

        private void BtnEight_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "8";
        }

        private void BtnNine_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "9";
        }

        private void BtnZero_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "0";
        }

        private void BtnDoubleZero_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "00";
        }

        private void BtnComma_Click(object sender, EventArgs e)
        {
            txtVisor.Text += ",";
        }

        private void BtnMore_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "+";
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "=";
        }

        private void BtnLower_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "-";
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            txtVisor.Text = "0";
        }

        private void txtVisor_TextChanged(object sender, EventArgs e)
        {
            //Verify leading zeros (Verificar zeros a esquerda)
            foreach(var letra in txtVisor.Text)
            {

            }
        }
    }
}
