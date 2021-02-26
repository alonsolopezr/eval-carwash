using System;
using System.Collections.Generic;
using System.Text;

namespace CarWash.Personas
{
    public class Cliente:Persona
    {


        
        //metodos
        public bool pagar(double efectivo) 
        {

            /*Hacer que salga un 
             Mensaje que oago con cierto
            dinero"*/
            return true;
        }

        //constructor
        public Cliente(string nombre, string apellidos, string email, string cel) 
        {
            this.setNombre = nombre;
            this.setEmail = email;
            this.setCel = cel;
            this.setApellidos = apellidos; 
        
        
        }
    }
}
