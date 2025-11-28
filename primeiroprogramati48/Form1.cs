using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;




namespace primeiroprojetoti48
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        decimal valor1, valor2, resultado;
        string operacao = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            valor1 = 0;
            valor2 = 0;
            resultado = 0;
        }

        // -------------------------- NÚMEROS --------------------------

        private void btn0_Click(object sender, EventArgs e) => txtDisplay.Text += "0";
        private void btn1_Click(object sender, EventArgs e) => txtDisplay.Text += "1";
        private void btn2_Click(object sender, EventArgs e) => txtDisplay.Text += "2";
        private void btn3_Click(object sender, EventArgs e) => txtDisplay.Text += "3";
        private void btn4_Click(object sender, EventArgs e) => txtDisplay.Text += "4";
        private void btn5_Click(object sender, EventArgs e) => txtDisplay.Text += "5";
        private void btn6_Click(object sender, EventArgs e) => txtDisplay.Text += "6";
        private void btn7_Click(object sender, EventArgs e) => txtDisplay.Text += "7";
        private void btn8_Click(object sender, EventArgs e) => txtDisplay.Text += "8";
        private void btn9_Click(object sender, EventArgs e) => txtDisplay.Text += "9";

        private void btnPonto_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Contains(","))
                txtDisplay.Text += ",";
        }

        // -------------------------- OPERADORES --------------------------

        private void btnMais_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "") return;
            operacao = "Adicao";
            valor1 = decimal.Parse(txtDisplay.Text);
            txtResultado.Text = valor1 + " + ";
            txtDisplay.Clear();
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "") return;
            operacao = "Subtracao";
            valor1 = decimal.Parse(txtDisplay.Text);
            txtResultado.Text = valor1 + " - ";
            txtDisplay.Clear();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "") return;
            operacao = "Multiplicacao";
            valor1 = decimal.Parse(txtDisplay.Text);
            txtResultado.Text = valor1 + " * ";
            txtDisplay.Clear();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "") return;
            operacao = "Divisao";
            valor1 = decimal.Parse(txtDisplay.Text);
            txtResultado.Text = valor1 + " / ";
            txtDisplay.Clear();
        }

        // -------------------------- IGUAL --------------------------

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "") return;

            valor2 = decimal.Parse(txtDisplay.Text);

            switch (operacao)
            {
                case "Adicao":
                    resultado = valor1 + valor2;
                    txtResultado.Text = $"{valor1} + {valor2} =";
                    break;

                case "Subtracao":
                    resultado = valor1 - valor2;
                    txtResultado.Text = $"{valor1} - {valor2} =";
                    break;

                case "Multiplicacao":
                    resultado = valor1 * valor2;
                    txtResultado.Text = $"{valor1} * {valor2} =";
                    break;

                case "Divisao":
                    if (valor2 == 0)
                    {
                        txtDisplay.Text = "ERRO";
                        return;
                    }
                    resultado = valor1 / valor2;
                    txtResultado.Text = $"{valor1} / {valor2} =";
                    break;
            }

            txtDisplay.Text = resultado.ToString();
        }

        // -------------------------- CLEAR --------------------------

        private void btnClear_Click(object sender, EventArgs e)
        {
            operacao = "";
            valor1 = 0;
            valor2 = 0;
            resultado = 0;
            txtDisplay.Clear();
            txtResultado.Clear();
        }
        // ------------------------- MaisMenos -----------------------
        private void btnMaisMenos_Click(object sender, EventArgs e)
        {
            
        }
    }
}
