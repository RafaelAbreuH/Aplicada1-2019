using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicada1_2019.EjerciciosCSharp.Capitulo2
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {
            double celsius;
            double fahrenheit;
            string valor;
            Console.WriteLine("Digite los gracos celcius: ");
            valor = Console.ReadLine();
            celsius = Convert.ToDouble(valor);

            fahrenheit = (9 / 5 * celsius) + 32;

            Console.WriteLine("{0} celcius = {1} fahrenheit", celsius, fahrenheit);
            Console.Read();
        }
    }
}
