using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadura
{
    class ModelCalculadora
    {
        //Declarando uma Variavel
        private double num1;
        private double num2;

        //MEtodo Construtor
        public ModelCalculadora()
        {
            getSetNum1 = 0;
            getSetNum2 = 0;
        }//Fim do Construtor

        //Metodos Get e Set
        public double getSetNum1
        {
            get { return this.num1; }
            set { this.num1 = value; }
        }// Fim do GetSet

        public double getSetNum2
        {
            get { return this.num2; }
            set { this.num2 = value; }
        }//Fim do GetSet

        public double Somar()
        {
            return getSetNum1 + getSetNum2;
        }//Fim do Metodo Somar

        public double Subtrair()
        {
            return getSetNum1 - getSetNum2;
        }//Fim do Metodo Subtrair

        public double Dividir()
        {
            if (getSetNum2 <= 0)
            {
                return -1;
            }
            else
            {
                return getSetNum1 / getSetNum2;
            }
        }//Fim do Dividir

        public double Multiplicar()
        {
            return getSetNum1 * getSetNum2;
        }//Fim do Metodo Multiplicar

        public double Potencia()
        {
            return Math.Pow(getSetNum1, getSetNum2);
        }//Fim do Metodo Potencia

        public string Raiz()
        {
            string msg = "Raiz do Primeiro Numero:" + Math.Sqrt(getSetNum1) + "\nRaiz do Segundo Numero:" + Math.Sqrt(getSetNum2);
            return msg;
        }//Fim do Metodo Raiz

        public string TabuadaNum1()
        {
            string resultado = "";
            for (int i = 0; i <= 10; i++)
            {
                resultado += "\n" + getSetNum1 + " * " + i + " = " + (getSetNum1 * i);
            }//Fim do For
            return resultado;
        }//Fim do Metodo Tabuada NUm1

        public string TabuadaNum2()
        {
            string resultado = "";
            for (int i = 0; i <= 10; i++)
            {
                resultado += "\n" + getSetNum2 + " * " + i + " = " + (getSetNum2 * i);
            }//Fim do For
            return resultado;
        }//Fim do Metodo Tabuada Num2

        public string BinarioDecimal()
        {
            
            return 
        }
    }
}//Fim do Projeto
