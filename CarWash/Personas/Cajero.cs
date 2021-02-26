using System;
using System.Collections.Generic;
using System.Text;

namespace CarWash.Personas
{
    class Cajero:Persona
    {


        //metodos
        public int cobrarLavado(Cliente cliente) 
        {
            /*Aqui recibira si el
             * pago fue hecho por el cliente(bool)
             y retorna el pago o algo asi*/
            return 1;
        }

        //constructor

        public Cajero(string nombre, string apellidos, string email, string cel) 
        {
            this.setNombre = nombre;
            this.setEmail = email;
            this.setCel = cel;
            this.setApellidos = apellidos;
        }
    }
}
