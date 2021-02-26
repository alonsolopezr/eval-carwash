using System;
using Autolavado.Personas;

namespace Autolavado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Evaluación Autolavado---");

            Cajero cajero = new Cajero();
            Proceso proceso = new Proceso();

            proceso.Inicio("");

            

        }
    }
}
