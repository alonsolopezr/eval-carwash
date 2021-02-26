using System;
using System.Collections.Generic;
using System.Text;

namespace Autolavado.Personas
{
    public class Cajero : Persona
    {
        public Cajero()
        {
        }

        public Cajero(string nombre, string apellidos, string email, string celular)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Email = email;
            this.Celular = celular;
        }

        public void menu()
        {
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("Cajero #" + i + ", tome su lugar");
                Console.ReadLine();
            }
            
        }

    }
}
