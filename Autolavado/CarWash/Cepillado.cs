using System;
using System.Collections.Generic;
using System.Text;

namespace Autolavado
{
    
    class Cepillado : EtapaLavado
    {
        public int Cliente;

        public Cepillado()
        {
        }

        public Cepillado(int cliente) 
        {
            Console.WriteLine("Se está cepillando el carro");
            this.Cliente = cliente;
        }
    }
}
