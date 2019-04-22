using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio5_LeonardoHuilitraro
{
    class Calculadora2
    {
        int numero;
        public List<ICalcular> calculadoras;
        public Calculadora2(int numero, List<ICalcular> calculadoras)
        {
            this.numero = numero;
            this.calculadoras = calculadoras;
        }
        public int GetNumero()
        {
            return numero;
        }
        public int Calcular(int a)
        {
            int num = calculadoras[a].Calcular(numero);
            return num;
        }
    }
}
