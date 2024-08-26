using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3_cs_ex2
{
    
    /*Escreva um programa em C# que leia 3 valores a, b e c, coeficientes de uma 
    equação de segundo grau, e calcule e escreva as raízes da equação.*/ 
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Program start = new Program();
        }
        public Program() 
        { 
            Convert converter = new Convert();
            List<string> listaS = new List<string>();
            List<double> listaD1 = new List<double>();
            List<double> listaD2 = new List<double>();

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Digite o valor 0{0}: ", i + 1);
                listaS.Add(Console.ReadLine());
            }

            listaD1 = converter.Transferidor(listaS);
            listaD2 = converter.Calculador(listaD1);

            foreach (double x in listaD2)
            {
                Console.WriteLine("O valor de x foi: {0}",  x);
            }
            Console.ReadKey();
        }
    
    
    }
}
