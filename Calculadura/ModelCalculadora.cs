using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
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

        public string DecimalBinario(int n)
        {
            int resto;
            string result = string.Empty;
            while (n > 0)
            {
                resto = n % 2;
                n /= 2;
                result += resto.ToString(); 
            }

            string invertido = "";

            for (int i = result.Length; i > 0; i--)
            {
                string letra = result.Substring(i - 1, 1);
                invertido += letra;
            }
            return invertido;
        }//fim do método

        //It just works!!
        public string BinarioDecimal(int n)
        {
            int dec = 0;
            int resto, basenum = 1;
            while (n > 0)
            {
                resto = n % 10;
                dec += resto * basenum;
                basenum *=  2;
                n /= 10;
            }//Fim do While
            return dec.ToString();
        }//Fim do metodo

        public string Bhaskara(double num)
        {
            double delta = 0;
            string msg = "";
            double x1 = 0;
            double x2 = 0;
            delta = (Math.Pow(getSetNum2, 2) -4 * getSetNum1 * num);

            if (delta < 0)
            {
                msg = "Impossivel Calcular delta. O valor de delta é: " + delta;
                return msg;
            }
            else
            {
                x1 = (-getSetNum2 + Math.Sqrt(delta)) / (2 * getSetNum1);
                x2 = (-getSetNum2 - Math.Sqrt(delta)) / (2 * getSetNum1);
                msg = "X1: " + x1 + "X2: " + x2 + "Delta: " + delta;
                return msg;
            }//Fim do If Else
        }//Fim do Metodo

        public string DecimalHexa()
        {
            int num_decimal = 0;
            string num_hexadecimal;

            Console.WriteLine("Informe um numero em decimal : ");
            num_decimal = int.Parse(Console.ReadLine());

            string an = num_hexadecimal = num_decimal.ToString("X");
            return an;
        }//Fim do Metodo

        public double ConverterHexaDecimal(string hexadecimal)
        {
            double dec = 0;
            string caract = "";
            int num = 0;
            int tamanho = hexadecimal.Length;
            int pote = tamanho;
            for (int i = 0; i < tamanho; i++)
            {
                pote--;
                caract = hexadecimal.Substring(i, 1);
                switch (caract)
                {
                    case "A":
                        num = 10;
                        break;
                    case "B":
                        num = 11;
                        break;
                    case "C":
                        num = 12;
                        break;
                    case "D":
                        num = 13;
                        break;
                    case "E":
                        num = 14;
                        break;
                    case "F":
                        num = 15;
                        break;
                    default:
                        num = Convert.ToInt32(caract);
                        break;
                }//fim do switch
                dec += num * Math.Pow(16, pote);
            }//fim do for
            return dec;
        }//fim do método converter decimal
        

    }//fim da classe
}//Fim do Projeto
