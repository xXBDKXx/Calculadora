using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadura
{
    class Program
    {
        static void Main(string[] args)
        {
            ControlCalculadora control = new ControlCalculadora();
            control.Operacao();
            Console.ReadLine();//Manter Aberto
        }//Fim do Metodo main
    }//FIm da Classe program
}//FIm do projeto calculadora
