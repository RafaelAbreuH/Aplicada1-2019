﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicada1_2019.EjerciciosCSharp.Capitulo4
{
    public class Ejercicio1
    {
        static void Main(string[] args)
        {
            int num;
            int resultado;
            Console.WriteLine("Ingrese el numero a multiplicar");
            num = int.Parse(Console.ReadLine());

            for (int i = 0; i < 11; i++)
            {
                resultado = num * i;
                Console.WriteLine(num + "*" + i + "=" + resultado);
            }
            Console.Read();
        }
    }
}
