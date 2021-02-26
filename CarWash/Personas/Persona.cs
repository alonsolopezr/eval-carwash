using System;
using System.Collections.Generic;
using System.Text;

namespace CarWash.Personas
{
    public class Persona
    {
        //Atributos

        public string nombre;
        public string apellidos;
        public string email;
        public string cel;



        //metodos


        //Construtor

        //get y set
        public string setNombre 
        { 
            set { nombre = value; }
        }
        //public string getNombre { get {*RETURN --- }; } ---recordar get
        public string setApellidos 
        { 
            set { apellidos = value; } 
        }
        public string setEmail
        {
            set { { email = value; } }

        }
        public string setCel
        {
            set{ cel = value; }
        }

    }
}
