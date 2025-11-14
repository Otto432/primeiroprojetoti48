using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace primeiroprogramati48
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal resultado;
        decimal valor1;
        decimal valor2;
        string operacao;    
        public void Form1_Load(object sender, EventArgs e)
        {
            resultado = 0;
            valor1 = 0;
            valor2 = 0;
            operacao = "Adição";
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void labelval1_TextChanged(object sender, EventArgs e)
        {

        }
        //-----------------------FUNÇÕES DOS BOTÕES!----------------------------//
        private void but1_Click(object sender, EventArgs e)//1
        {
            labelval1.Text += but1.Text;
        }
        private void but2_Click(object sender, EventArgs e)//2
        {
            labelval1.Text += but2.Text;
        }
        private void but3_Click(object sender, EventArgs e)//3
        {
            labelval1.Text += but3.Text;
        }
        private void but4_Click(object sender, EventArgs e)//4
        {
            labelval1.Text += but4.Text;
        }
        private void but5_Click(object sender, EventArgs e)//5
        {
            labelval1.Text += but5.Text;
        }
        private void but6_Click(object sender, EventArgs e)//6
        {
            labelval1.Text += but6.Text;
        }
        private void but7_Click(object sender, EventArgs e)//7
        {
            labelval1.Text += but7.Text;
        }
        private void but8_Click(object sender, EventArgs e)//8
        {
            labelval1.Text += but8.Text;
        }
        private void but9_Click(object sender, EventArgs e)//9
        {
            labelval1.Text += but9.Text;
        }
        private void but0_Click(object sender, EventArgs e)//0
        {
            labelval1.Text += but0.Text;
        }
        //-------------------------Códigos DE SINAL-----------------------------//

        private void btmsoma_Click(object sender, EventArgs e)//soma
        {
            operacao = "Adicao";

            if (operacao == "Adicao")
                    {
            labeval3.Text = valor1.ToString() + " + ";
            }

        }

        private void btnmenos_Click(object sender, EventArgs e)//menos
        {
            labelval1.Text += btnmenos.Text;
        }

        private void btnvezes_Click(object sender, EventArgs e)//vezes
        {
            labelval1.Text += btnvezes.Text;
        }

        private void btndivisão_Click(object sender, EventArgs e)//divisao
        {
            labelval1.Text += btndivisão.Text;
        }
        private void igual_Click(object sender, EventArgs e)
        {
            
        }
        // Fim botão sinais

        private void labeval3_TextChanged(object sender, EventArgs e)
        {
        }

    }
}
