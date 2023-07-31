using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelaCalculadora
{
    class Model
    {
        private double operacao;
        public Model()
        {
            ConsultarOperacao = 0;
        }//fim do construtor

        public double ConsultarOperacao
        {
            get { return operacao; }
            set { this.operacao = value; }
        }//fim do método
        public double Somar(double num)
        {
            return ConsultarOperacao += num;
        }//fim do somar

        public double Subtrair(double num)
        {
            return ConsultarOperacao -= num;
        }//fim do subtrair

        public double Divisao(double num)
        {
            return ConsultarOperacao /= num;
        }//Fim do Dividir

        public double Multiplicar(double num)
        { 
            return ConsultarOperacao %= num;
        }//Fim do Multiplicar
    }//Fim da Classe
}//FIm do Projeto
