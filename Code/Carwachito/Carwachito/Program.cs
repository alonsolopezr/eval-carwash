using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carwachito.Personas;
using Carwachito.CarWash;

namespace Carwachito
{
    public class Program
    {
        static int turno = 0;

        public static void Main(string[] args)
        {
            Cliente client;
            Cajero clerk = new Cajero();
            Proceso pros = new Proceso();
            EntregaCarro valet = new EntregaCarro();
            string res;
            string[] datos = new string[4];
            bool lop = true;
            while (lop)
            {

                Console.WriteLine("Bienvenido al Carwachito...\n¿Es cliente o empleado?");
                Console.WriteLine("1. Cliente \n2.Empleado");
                res = Console.ReadLine();
                if (res[0] == '1')
                {

                    Console.WriteLine("Ingrese su primer nombre");
                    datos[0] = Console.ReadLine();
                    Console.WriteLine("Ingrese sus Apellidos separados por una coma \",\"");
                    datos[1] = Console.ReadLine();
                    Console.WriteLine("Ingrese su correo");
                    datos[2] = Console.ReadLine();
                    Console.WriteLine("Ingrese su numero de celular a 10 digitos");
                    datos[3] = Console.ReadLine();

                    client = new Cliente(datos[0], datos[1], datos[2], datos[3]);


                    pros.listaLavado.Add(client);
                    pros.IniciarProceso(client);
                    turno++;
                    Console.WriteLine("El total del servicio es de $" + pros.costoLavado);

                    clerk.CobrarLavado(client);

                    valet.Entregar(client);
                }
                else if (res[0] == '2')
                {
                    Console.WriteLine("Ingrese su primer nombre");
                    datos[0] = Console.ReadLine();
                    Console.WriteLine("Ingrese sus Apellidos separados por una coma \",\"");
                    datos[1] = Console.ReadLine();
                    Console.WriteLine("Ingrese su correo");
                    datos[2] = Console.ReadLine();
                    Console.WriteLine("Ingrese su numero de celular a 10 digitos");
                    datos[3] = Console.ReadLine();

                    clerk = new Cajero(datos[0], datos[1], datos[2], datos[3]);

                }
                else
                {
                    Console.WriteLine("Opcion no valida");
                    lop = true;
                }


                Console.WriteLine("presione X para salir");
                res = Console.ReadLine().ToUpper();
                if (res[0] == 'X')
                {
                    lop = false;
                }

            }
        }

    }
}

