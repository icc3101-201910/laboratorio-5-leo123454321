using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio5_LeonardoHuilitraro
{
    class Cuadrado : ICalcular
    {
        public int Calcular(int i)
        {
            int n = i * i;
            return n;
        }
    }
}
