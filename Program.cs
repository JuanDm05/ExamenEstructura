﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenEstructura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese numero base");
            int numeroBase = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa numero final");
            int numeroFinal = Convert.ToInt32(Console.ReadLine());
            Metodos metodos = new Metodos();
            metodos.SecuenciaNumeros(numeroBase, numeroFinal);

            Console.WriteLine("Ingresa su curp");
            string sentencia = Console.ReadLine();
            Console.WriteLine(metodos.Curp(sentencia));
        }
    }
}
