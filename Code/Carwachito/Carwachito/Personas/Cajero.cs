using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carwachito.CarWash;

namespace Carwachito.Personas
{
    public class Cajero : Persona
    {
        Cobrar cobro = new Cobrar();

        public Cajero() { }

        public Cajero(string nom, string apell, string correo, string cel)
        {
            this.nombre = nom;
            this.apellidos = apell;
            this.email = correo;
            this.cel = cel;
        }


        public int CobrarLavado(Cliente cliente)
        {
            Console.WriteLine("Inicia cobro");
            cobro.Cobro(cliente);

            return 1;
        }

    }
}
