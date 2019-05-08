using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicada1_2019.EjerciciosCSharp.Capitulo2
{
    public class Ejercicio3
    {
        static void Main(string[] args)
        {
            string valor;
            double grados;
            double radianes;
            Console.WriteLine("Digite los grados:");
            valor = Console.ReadLine();
            grados = Convert.ToDouble(valor);

            radianes = grados * (180 / Math.PI);
            Console.WriteLine("{0} Grados = {1} Radianes", grados, radianes);
            Console.Read();
        }
    }
}
