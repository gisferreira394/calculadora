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
        String operacao = " ";
        public Form1()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text+= "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text+= "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
           textBoxResultado.Text+= "3"; 
        }

        private void button4_Click(object sender, EventArgs e)
        {
textBoxResultado.Text+= "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text+= "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
textBoxResultado.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBoxResultado.Text != "")
            {
                valor1 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);
                textBoxResultado.Text = "";
                operacao = "SOMA";
                labeloperacao.Text = "+";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a soma ");
            }
        }

        private void button14_Click(object sender, EventArgs e)
            
        {
            if(textBoxResultado.Text != "") { 
            valor1 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);
            textBoxResultado.Text = "";
            operacao = "SUB";
            labeloperacao.Text = "-";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a subtração");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBoxResultado.Text != "")
            {
                valor1 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);
                textBoxResultado.Text = "";
                operacao = "MULT";
                labeloperacao.Text = "X";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a Multiplicação");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBoxResultado.Text != "") 
            {
                valor1 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);
                textBoxResultado.Text = "";
                operacao = "DIV";
                labeloperacao.Text = "/";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a divisão");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text = " ";
            labeloperacao.Text = " ";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text = " ";
            valor1 = 0;
            valor2 = 0;
            labeloperacao.Text = " ";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);
            if (operacao == "SOMA")
            {
                textBoxResultado.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacao == "SUB")
            {
                textBoxResultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "MULT")
            {
                textBoxResultado.Text = Convert.ToString(valor1 * valor2);
            }
            else if (operacao == "PORC")
            {
                textBoxResultado.Text = Convert.ToString((valor1/100) * valor2);
            }
            else if (operacao == "EXP")
            {
                textBoxResultado.Text = Convert.ToString (Math.Pow(Convert.ToDouble(valor1), Convert.ToDouble(valor2)));
            }
  else if (operacao == "RAIZ")
            {
                

            }
            else 
            {
                textBoxResultado.Text = Convert.ToString(valor1 / valor2);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += ".";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_por100_Click(object sender, EventArgs e)
        {
            if (textBoxResultado.Text != "")
            {
                valor1 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);
                textBoxResultado.Text = "";
                operacao = "PORC";
                labeloperacao.Text = "%";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a porcentagem");
            }
        }

        private void buttonExpo_Click(object sender, EventArgs e)
        {
            if (textBoxResultado.Text != "")
            {
                valor1 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);
                textBoxResultado.Text = "";
                operacao = "EXP";
                labeloperacao.Text = "^";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a Exponenciação");
            }
        }

        private void buttonRaiz_Click(object sender, EventArgs e)
        {



            if (textBoxResultado.Text != "")
            {
                valor1 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);
                textBoxResultado.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(valor1)));
                labeloperacao.Text = "";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a Raiz");
            }
        }

        private void buttonPI_Click(object sender, EventArgs e)
        {
            valor1 = (decimal)Math.PI;
            textBoxResultado.Text = valor1.ToString();
             }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "9";
        }
    }
}
