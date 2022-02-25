using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

            if(operacao == "SOMA")
            {

                txtResultado.Text = Convert.ToString(valor1 + valor2);

            } else if(operacao == "SUB")
            {

                txtResultado.Text = Convert.ToString(valor1 - valor2);

            } else if(operacao == "MULT")
            {
                txtResultado.Text = Convert.ToString(valor1 * valor2);

            } else
            {
                txtResultado.Text = Convert.ToString(valor1 / valor2);

            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SUB";
                lblOperacao.Text = "-";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a conta!");
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "MULT";
                lblOperacao.Text = "X";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a conta!");
            }

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if(txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "DIV";
                lblOperacao.Text = "/";

            } else
            {
                MessageBox.Show("Informe um valor para efetuar a conta!");
            }
            
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            lblOperacao.Text = "";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if(txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SOMA";
                lblOperacao.Text = "+";

            } else
            {
                MessageBox.Show("Informe um valor para efetuar a conta!");
            }
           
        }
    }
}
