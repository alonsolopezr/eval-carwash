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
        

        private string cajeroNombre;
        private string apellidos;
        private string email;
        private string celular;
        public string CajeroNombre
        {
            get { return cajeroNombre; }
            set { cajeroNombre = value; }
        }
        public new string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public new string Email
        {
            get { return email; }
            set { email = value; }
        }
        public new string Celular
        {
            get { return celular; }
            set { celular = value; }
        }
        //INGRESO DEL CAJERO A CAJA------------------------------------------------
        private string contraseña;
        public void menuCajero()
        {
            Cajero cajero = new Cajero();
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("Cajero #" + i + ", ingrese su usuario: ");
                cajero.CajeroNombre = Console.ReadLine();
                
                if (cajero.CajeroNombre == ("eval_PEREZ"))
                {
                    Console.WriteLine("\nBienvenido cajero eval_PEREZ");
                    Console.WriteLine("Ingrese su contraseña: ");
                    contraseña = Console.ReadLine();
                    if (contraseña == ("12345"))
                    {
                        Console.WriteLine("Adelante eval_PEREZ tome su lugar.");
                        break;
                    }
                    else 
                    {
                        Console.WriteLine("Contraseña incorrecta");
                    }
                }
                else
                {
                    Console.WriteLine("Usted no se encuentra registrado, hable con el administrador.");
                    break;
                } 
            }
            
            
        }

        public void menuRecibirCliente() 
        {
            Console.WriteLine("Escriba su nombre, dos apellidos, correo (email) y su número de celular:\n");
            
                
        }
            Cliente cliente = new Cliente();
        public void menuCobrarCliente()
        {
            
            
            Console.WriteLine("\nIngrese su nombre:");
            cliente.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su apellido:");
            cliente.Apellidos = Console.ReadLine();
            Console.WriteLine("Ingrese su correo (Email):");
            cliente.Email = Console.ReadLine();
            Console.WriteLine("Ingrese su número de Celular:");
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
        //MENU PARA EL TICKET
        public void menuTicketCliente() 
        {
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Autolavado eval-carwash");
            //Console.WriteLine("\nAtendido por el cajero: "+cajero.CajeroNombre);
            Console.WriteLine("\nAtendido por el cajero: eval_PEREZ"+CajeroNombre);
            Console.WriteLine("\nCliente: "+cliente.Nombre +" "+ cliente.Apellidos+ "{0}Celular: "+cliente.Celular + "{0}Email: " + cliente.Email,Environment.NewLine);
            
        }
        

    }
}
