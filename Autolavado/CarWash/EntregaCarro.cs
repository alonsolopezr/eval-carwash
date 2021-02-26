using System;
using System.Collections.Generic;
using System.Text;

namespace Autolavado.Personas
{
    public class EntregaCarro : EtapaLavado
    {

        private int Cliente;
        public EntregaCarro(int cliente)
        {
            this.Cliente = cliente;
        }



    }
}
