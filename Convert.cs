using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3_cs_ex2
{
    internal class Convert
    {
        public List<double> Transferidor(List<string> listaS)
        {
            List<double> listaD = new List<double>();
            listaD = listaS.ConvertAll(double.Parse);

            return listaD; 
        }
        public List<double> Calculador(List<double> listaD1)     
        {
            List<double> listaD2 = new List<double>();

            listaD2.Add((-listaD1[1] + Math.Sqrt((listaD1[1] * listaD1[1]) -4 * listaD1[0] * listaD1[2])) / (2 * listaD1[0]));
            listaD2.Add((-listaD1[1] - Math.Sqrt((listaD1[1] * listaD1[1]) -4 * listaD1[0] * listaD1[2])) / (2 * listaD1[0]));
            
            return listaD2;
        }
    
    }
}
