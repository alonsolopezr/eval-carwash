using System;
using System.Collections.Generic;
using System.Text;

namespace Autolavado.Personas
{
    public class Persona
    {
        private string nombre;
        private string apellidos;
        private string email;
        //private int cel;

        protected string Nombre 
        {
            get => this.nombre;
            set => this.nombre=value;
        }

        protected string Apellidos 
        {
            get => this.apellidos;
            set => this.apellidos = value;
        }
        protected string Email
        {
            get => this.email;
            set => this.email = value;
        }

        protected string Celular 
        {
            get;
            set;
        }


    }
}
