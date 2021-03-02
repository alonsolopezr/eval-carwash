using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carwachito.Personas;


namespace Carwachito.CarWash
{
    public class Secado : EtapaLavado
    {

        public int Secar(Cliente cliente)
        {
            Console.WriteLine("Se seca el carro");
            return 100;
        }

    }
}
