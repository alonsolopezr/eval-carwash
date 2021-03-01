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

        public void menuSecado()
        {
            Console.WriteLine("4.- Secado de automovil");
            return; 
        }
    }
}
