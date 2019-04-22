using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio5_LeonardoHuilitraro
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ICalcular> lista = new List<ICalcular>();
            Cubo cubo = new Cubo();
            RobotFibonacci robotFibonacci = new RobotFibonacci();
            PerroFactorial perroFactorial = new PerroFactorial();
            PersonaQueSuma5 personaQueSuma5 = new PersonaQueSuma5();
            Cuadrado cuadrado = new Cuadrado();
            lista.Add(robotFibonacci);
            lista.Add(cubo);
            lista.Add(perroFactorial);
            lista.Add(personaQueSuma5);
            lista.Add(cuadrado);
            Console.WriteLine("-------CALCULADORA----------");
            Console.WriteLine("------TENGO DISTINOS TIPOS DE OPERACIONES---------");
            Console.WriteLine("INGRESE UN VALOR INICIAL: ");
            int inicial = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------INGRESA UN NUMERO Y REALIZARE ESA CANTIDAD DE OPERACIONES---------");
            int ciclos = Convert.ToInt32(Console.ReadLine());
            Calculadora calculadora = new Calculadora(inicial, lista);
            for (int i = 0; i < ciclos; i++)
            {
                Console.WriteLine("EL " + (i + 1) + " CALCULO ES: ");
                Console.WriteLine(calculadora.Calcular());
                Console.ReadLine();
            }
            Console.WriteLine("Ahora podras seleccionar la operacion que quieres realizar.");
            while (true)
            {
                Console.WriteLine("Ingrese el valor inicial: ");
                inicial = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Los tipos de calculos son los siguientes: ;");
                Console.WriteLine("0-ROBOT FIBONACCI");
                Console.WriteLine("1-CUBO");
                Console.WriteLine("2-PERRO FACTORIAL");
                Console.WriteLine("3-PERSONA QUE SUMA 5");
                Console.WriteLine("4-CUADRADO");
                Console.WriteLine("5-SALIR");
                Console.WriteLine("Ingrese una opcion: ");
                int seleccion = Convert.ToInt32(Console.ReadLine());
                if (seleccion == 5)
                {
                    break;
                }
                Calculadora2 calculadora2 = new Calculadora2(inicial, lista);
                Console.WriteLine("El numero es: ");
                Console.WriteLine(calculadora2.Calcular(seleccion));
                Console.ReadLine();
            }


        }
    }
}
