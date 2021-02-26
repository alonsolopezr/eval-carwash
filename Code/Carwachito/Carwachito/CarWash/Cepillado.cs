using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carwachito.Personas;


namespace Carwachito.CarWash
{
    public class Cepillado : EtapaLavado
    {
        public int Cepillar(Cliente cliente) 
        {
            Console.WriteLine("Se cepilla el interior");
            return 100;
        }

    }
}
