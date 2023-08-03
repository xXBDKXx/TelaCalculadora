using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }//fim do get set

        public double Somar(double num)
        {
            return ConsultarOperacao += num;
        }//fim do somar

        public double Subtrair(double num)
        {
            return ConsultarOperacao -= num;
        }//fim do subtrair

        public double Divisao(double bas, double exp)
        {
            return bas / exp;
        }//Fim do Dividir

        public double Multiplicar(double bas, double exp)
        { 
            return bas * exp;
        }//Fim do Multiplicar

        public double Potencia(double bas, double exp)
        {
            return Math.Pow(bas, exp);
        }//Fim do Potencia

        public double Raiz(double num)
        {
            return Math.Sqrt(num);
        }//Fim da Raiz
    }//Fim da Classe
}//FIm do Projeto
