using System;
using System.Collections.Generic;
using System.Text;

namespace Autolavado
{
    class Secado : EtapaLavado
    {
        public int Cliente;

        public Secado()
        {
        }

        public Secado(int cliente)
        {
            Console.WriteLine("Se está secando el carro");
            return; 
        }
    }
}
