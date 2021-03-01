using System;
using System.Collections.Generic;
using System.Text;

namespace Autolavado.Personas
{
    public class Cajero : Cliente
    {
        public Cajero()
        {
        }

        //public Cajero(string nombre, string apellidos, string email, string celular)
        //{
        //    this.Nombre = nombre;
        //    this.Apellidos = apellidos;
        //    this.Email = email;
        //    this.Celular = celular;
        //}

        public void menuCajero()
        {
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("Cajero #" + i + ", tome su lugar");
                break;
            }
            
            
        }

        public void menuRecibirCliente() 
        {
            Console.WriteLine("Escriba su nombre, dos apellidos, correo (email) y su número de celular:\n");
            
                
        }
        
        public void menuCobrarCliente()
        {
            Cliente cliente = new Cliente();
            
            Console.WriteLine("Ingrese su nombre, dos apellidos, correo (email) y su número de celular:\n");
            Console.WriteLine("Nombre:");
            cliente.Nombre = Console.ReadLine();
            Console.WriteLine("Apellidos:");
            cliente.Apellidos = Console.ReadLine();
            Console.WriteLine("Correo (Email):");
            cliente.Email = Console.ReadLine();
            Console.WriteLine("Número de Celular:");
            cliente.Celular = Console.ReadLine();
            //EMPIEZA EL COBRO
            Console.WriteLine("\nBienvenido " + cliente.Nombre + " " + cliente.Apellidos + ", se le cobrará: "); //AGREGAR COBRO
            Cobrar cobrar = new Cobrar();
            Console.WriteLine("\nLavado Inicial $" + cobrar.PrecioLavado);
            Console.WriteLine("Aplicado de Shampoo $" + cobrar.PrecioShampoo);
            Console.WriteLine("Cepillado $" + cobrar.PrecioCepillado);
            Console.WriteLine("Secado $" + cobrar.PrecioSecado);
            //SE SUMA EL COBRO
            double Total = cobrar.PrecioLavado + cobrar.PrecioShampoo + cobrar.PrecioCepillado + cobrar.PrecioSecado;
            Console.WriteLine("Sería un total de $" + Total);
        }
        

    }
}
