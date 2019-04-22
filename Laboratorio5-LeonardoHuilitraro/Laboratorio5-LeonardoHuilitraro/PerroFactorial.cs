using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio5_LeonardoHuilitraro
{
    class PerroFactorial: ICalcular
    { 
        public int Calcular(int i)
        {
            if (i >= 13)
            {
                i = 13;
            }
            int aux = 1;
            for(int k=1; k<=i; k++)
            {
                aux = aux * k;
            }
            return aux;
        }
    
    }
}
