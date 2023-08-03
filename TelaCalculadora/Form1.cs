using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaCalculadora
{
    public partial class Form1 : Form
    {
        Model Operacao;
        public Boolean flag;
        public double exp;
        public double bas;
        public Form1()
        {
            InitializeComponent();
            Operacao = new Model();
            flag = false;
        }//FIm do Construtor

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }//Fim do Titulo

        private void label2_Click(object sender, EventArgs e)
        {

        }//Fim do Subtitulo

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do Coletar numeros

        private void BotãoSoma_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" + this.Operacao.Somar(Convert.ToDouble(maskedTextBox1.Text));
            maskedTextBox1.Text = "";
        }//Botão Soma

        private void BotãoSubtração_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" + this.Operacao.Subtrair(Convert.ToDouble(maskedTextBox1.Text));
            maskedTextBox1.Text = "";
        }//Botão Menos
        
        
        private void BotãoDivisão_Click(object sender, EventArgs e)
        {

            if (Chave(flag) == true)
            {
                exp = Convert.ToDouble(maskedTextBox1.Text);
            }
            else
            {
                bas = Convert.ToDouble(maskedTextBox1.Text);
            }//Fim do If

            textBox1.Text = "" + this.Operacao.Divisao(exp, bas);
            flag = Chave(flag);
        }//Divisão               

        private void BotãoMulti_Click(object sender, EventArgs e)
        {
            if (Chave(flag) == true)
            {
                exp = Convert.ToDouble(maskedTextBox1.Text);
            }
            else
            {
                bas = Convert.ToDouble(maskedTextBox1.Text);
            }//Fim do If

            textBox1.Text = "" + this.Operacao.Multiplicar(exp, bas);
            flag = Chave(flag);
        }//Multiplicar

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Potencia_Click(object sender, EventArgs e)
        {
            if(Chave(flag) == true)
            {
                exp = Convert.ToDouble(maskedTextBox1.Text);
            }
            else
            {
                bas = Convert.ToDouble(maskedTextBox1.Text);
            }//Fim do If

            textBox1.Text = "" + this.Operacao.Potencia(exp, bas);
            flag = Chave(flag);
        }//Fim do Potencia

        private void BotãoRaiz_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" + this.Operacao.Raiz(Convert.ToDouble(maskedTextBox1.Text));
            maskedTextBox1.Text = "";
        }

        //--------------------------------------------CHAVES--------------------------------------------
        //----------------------------------------------------------------------------------------------
        public Boolean Chave(Boolean entrada)
        {
            if (entrada == true)
            {
                return false;
            }
            else
            { 
                return true; 
            }//Fim do IF
        }//Fim do Metodo
        //-----------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------
    }//Fim da Classe
}//Fim do Projeto
