using System;
using System.Collections.Generic;
using System.Text;

namespace Autolavado
{
    class LavadoInicial : EtapaLavado
    {
        public int Cliente;
        public int Empezar;
        public LavadoInicial()
        {
        }

        public LavadoInicial(int cliente) 
        {
            Console.WriteLine("Se está empezando a lavar el carro");
            this.Cliente = cliente;
        }

        

    }
}
