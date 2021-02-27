using System;
using System.Collections.Generic;
using System.Text;

namespace Autolavado
{
    class AplicadorShampoo : EtapaLavado
    {
        public int Cliente;

        public AplicadorShampoo()
        {
        }

        public AplicadorShampoo(int cliente) 
        {
            Console.WriteLine("Se está aplicando shampoo para carros");
            this.Cliente = cliente;
        }
    }
}
