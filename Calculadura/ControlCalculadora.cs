﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadura
{
    class ControlCalculadora
    {
        //Criando um objeto calculadora na Memoria 
        ModelCalculadora calculadora = new ModelCalculadora();

        //Metodo Construtor
        public ControlCalculadora() 
        {
            this.calculadora = new ModelCalculadora();    
        }//Fim do Construtor

        public void Coletar()
        {
            Console.WriteLine("Informe um Numero: ");
            this.calculadora.getSetNum1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe outro Numero: ");
            this.calculadora.getSetNum2 = Convert.ToDouble(Console.ReadLine());
        }//Fim do Coletar

        public int Menu()
        {
            Console.WriteLine("-----Menu-----" + 
                              "\n1.Somar " + 
                              "\n2.Subtrair" + 
                              "\n3.Dividir" + 
                              "\n4.Multiplicar" + 
                              "\n5.Potência" + 
                              "\n6.Raiz " + 
                              "\n7.Tabuada " + 
                              "\n8.Decimal para Binario" +
                              "\n0.Sair" +
                              "\n\nEscolha uma das opções acima: ");

            int opcao = Convert.ToInt32(Console.ReadLine());
            return opcao;
        }//Fim do Metodo Menu

        public void Operacao()
        {
            int opcao = -1;
            do
            {
                opcao = Menu();
                Console.Clear();
                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado");
                        break;

                    case 1:
                        Coletar();
                        Console.WriteLine("Soma: " + this.calculadora.Somar());
                        break;

                    case 2:
                        Coletar();
                        Console.WriteLine("Subtrair:" + this.calculadora.Subtrair());
                        break;

                    case 3:
                        Coletar();
                        if (this.calculadora.Dividir() == -1)
                        {
                            Console.WriteLine("Impossivel de Dividir");
                        }
                        else
                        {
                            Console.WriteLine("Divisão: " + this.calculadora.Dividir());
                        }
                        break;
                    case 4:
                        Coletar();
                        Console.WriteLine("Multiplicar: " + this.calculadora.Multiplicar());
                        break;
                    case 5:
                        Coletar();
                        Console.WriteLine("Potência: " + this.calculadora.Potencia());
                        break;
                    case 6:
                        Coletar();
                        Console.WriteLine("Raiz: " + this.calculadora.Raiz());
                        break;
                    case 7:
                        Console.WriteLine("Informe um Numero: ");
                        this.calculadora.getSetNum1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.calculadora.TabuadaNum1());
                        break;
                    case 8:
                        Console.WriteLine("Informe um Numero: ");
                        this.calculadora.getSetNum1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.calculadora.DecimalBinario());
                    break;
                    default:
                        Console.WriteLine("Opção Invalida");
                        break;
                }//Fim do Switch
            }while(opcao != 0);  

        }//Fim da Operacao
    }//Fim da Classe
}//Fim do Projeto