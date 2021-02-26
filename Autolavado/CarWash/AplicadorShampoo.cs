using System;
using System.Collections.Generic;
using System.Text;

namespace Autolavado
{
    class AplicadorShampoo : EtapaLavado
    {
        public int Cliente;
        public AplicadorShampoo(int cliente) 
        {
            this.Cliente = cliente;
        }
    }
}
