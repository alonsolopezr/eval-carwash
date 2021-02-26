using System;
using System.Collections.Generic;
using System.Text;

namespace Autolavado
{
    class LavadoInicial : EtapaLavado
    {
        public int Cliente;
        public int empezar;
        public LavadoInicial(int cliente) 
        {
            this.Cliente = cliente;
        }

        

    }
}
