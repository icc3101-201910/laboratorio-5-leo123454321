using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio5_LeonardoHuilitraro
{
    class Calculadora
    {
        int numero;
        public List<ICalcular> calculadoras;
        public Calculadora(int numero, List<ICalcular> calculadoras)
        {
            this.numero = numero;
            this.calculadoras = calculadoras;
        }
        public int GetNumero()
        {
            return numero;
        }
        public int Calcular()
        {
            Random random = new Random();
            int num = calculadoras[random.Next(calculadoras.Count())].Calcular(numero);
            return num;
        }
    }
}
