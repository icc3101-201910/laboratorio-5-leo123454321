using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio5_LeonardoHuilitraro
{
    class Cubo : ICalcular
    {
        public int Calcular(int i)
        {
            int n = i * i*i;
            return n;
        }
    }
}
