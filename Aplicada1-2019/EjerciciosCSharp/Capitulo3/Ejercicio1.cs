using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicada1_2019.EjerciciosCSharp.Capitulo3
{
    public class Ejercicio1
    {
        static void Main(String[] args)
        {
            int valor;
            Console.WriteLine.("Ingrese un numero para saber si es par o impar");
            valor = Convert.ToInt16(Console.ReadLine());

            if ((valor % 2) == 0)
                Console.WriteLine("Es par");
            else
                Console.WriteLine("Es impar");
            Console.Read();
        }
    }
}
