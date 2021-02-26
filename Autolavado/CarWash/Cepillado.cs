using System;
using System.Collections.Generic;
using System.Text;

namespace Autolavado
{
    
    class Cepillado : EtapaLavado
    {
        public int Cliente;
        public Cepillado(int cliente) 
        {
            this.Cliente = cliente;
        }
    }
}
