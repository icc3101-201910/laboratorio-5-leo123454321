using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio5_LeonardoHuilitraro
{
    class RobotFibonacci: ICalcular
    {
        public int Calcular(int i) {
            int a = 0;
            int b = 1;
            if (i >= 46)
            {
                i = 46;
            }
            for ( int k= 0;k < i; k++)  
            {
                int aux = a;
                a = b; 
                b = aux + a; 
            }
            return a;
        }
    } }

