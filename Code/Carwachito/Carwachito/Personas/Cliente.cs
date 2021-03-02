using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwachito.Personas
{
    public class Cliente : Persona
    {
        public double dinero;
        public bool Pagar( double efectivo) {

            Console.WriteLine("cliente paga $"+efectivo);
            dinero = efectivo;
            return true;
        }
        public Cliente() { 
        
        }
        public Cliente(string nom, string apell, string correo, string cel) {

            this.nombre = nom;
            this.apellidos = apell;
            this.email = correo;
            this.cel=cel;
        }
    }
}
