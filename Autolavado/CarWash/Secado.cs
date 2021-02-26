using System;
using System.Collections.Generic;
using System.Text;

namespace Autolavado
{
    class Secado : EtapaLavado
    {
        public int Cliente;
        public Secado(int cliente)
        {
            this.Cliente = cliente;
            return; 
        }
    }
}
