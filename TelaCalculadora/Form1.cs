using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaCalculadora
{
    public partial class Form1 : Form
    {
        Model Operacao;
        public Form1()
        {
            InitializeComponent();
            Operacao = new Model();
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
            maskedTextBox1.Text = "" + this.Operacao.Somar(Convert.ToDouble(maskedTextBox1.Text));
        }//Botão Soma

        private void BotãoSubtração_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "" + this.Operacao.Subtrair(Convert.ToDouble(maskedTextBox1.Text));
        }//Botão Menos

        private void BotãoDivisão_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "" + this.Operacao.Divisao(Convert.ToDouble(maskedTextBox1.Text));
        }//Divisão

        private void BotãoMulti_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "" + this.Operacao.Multiplicar(Convert.ToDouble(maskedTextBox1.Text));
        }//Multiplicar
    }//Fim da Classe
}//Fim do Projeto
