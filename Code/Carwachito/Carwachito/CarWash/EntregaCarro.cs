using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carwachito.Personas;


namespace Carwachito.CarWash
{
    class EntregaCarro : EtapaLavado
    {
        public int Entregar(Cliente cliente) {
            Console.WriteLine("Se entrega el vehiculo ");
            return 1;
        }

    }
}
