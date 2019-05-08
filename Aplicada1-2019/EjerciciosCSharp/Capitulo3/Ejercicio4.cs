using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicada1_2019.EjerciciosCSharp.Capitulo3
{
    public class Ejercicio4
    {
        static void main(string[] args)
        {
            int dia;
            Console.WriteLine("Ingrese numero del dia:");
            dia = Convert.ToInt16(Console.Read());

            switch(dia)
            {
                case 1: Console.WriteLine("Lunes"); Console.Read(); break;
                case 2: Console.WriteLine("Martes"); Console.Read(); break;
                case 3: Console.WriteLine("Miercoles"); Console.Read(); break;
                case 4: Console.WriteLine("Jueves"); Console.Read(); break;
                case 5: Console.WriteLine("viernes"); Console.Read(); break;
                case 6: Console.WriteLine("Sabado"); Console.Read(); break;
                case 7: Console.WriteLine("Domingo"); Console.Read(); break;
                default: Console.WriteLine("Solo hay 7 Dias."); Console.Read(); break;
            }
        }
    }
}
