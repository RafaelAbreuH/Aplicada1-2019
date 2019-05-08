using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicada1_2019.EjerciciosCSharp.Capitulo2
{
    public class Ejercicio1
    {
        static void Main(string[] args)
        {
            float Nlados;
            float Vlados;
            string valor;
            float perimetro;

            Console.WriteLine("Digite Los lados del angulo:");
            valor = Console.ReadLine();
            Nlados = Convert.ToSingle(valor);

            Console.WriteLine("Digite el valor de los lados: ");
            valor = Console.ReadLine();
            Vlados = Convert.ToSingle(valor);

            perimetro = Nlados * Vlados;

            Console.WriteLine("El perimetro es: {0} ", perimetro);
            Console.Read();
        }
    }
}
