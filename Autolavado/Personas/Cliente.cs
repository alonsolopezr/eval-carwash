using System;
using System.Collections.Generic;
using System.Text;

namespace Autolavado.Personas
{
    public class Cliente : Persona
    {
        public Cliente()
        {
        }

        public Cliente(string nombre, string apellidos, string email, string celular) 
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Email = email;
            this.Celular = celular;
        }

        public void menu()
        {
            
            
            for (int i = 1; i < 20; i++)
            {
                Console.WriteLine("Cliente #"+i+" del día. \nBienvenido al Autolavado");
                Console.WriteLine("Ingrese su nombre, dos apellidos, correo (email) y su número de celular:");
                Console.WriteLine("Nombre:");
                Nombre = Console.ReadLine();
                Console.WriteLine("Apellidos:");
                Apellidos = Console.ReadLine();
                Console.WriteLine("Correo (Email):");
                Email = Console.ReadLine();
                Console.WriteLine("Número de Celular:");
                Celular = Console.ReadLine();
                Console.WriteLine("Bienvenido "+Nombre+" "+Apellidos+", se le cobrará $"); //AGREGAR COBRO
                Console.WriteLine("Está de acuerdo? s/n");
                string sioNo = (Console.ReadLine());
                if (sioNo == ("s"))
                {
                    EtapaLavado etapaLavado = new EtapaLavado();
                    EtapaLavado.menu();
                }
                
            }
            
        }





    }
}
