using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carwachito.Personas;


namespace Carwachito.CarWash
{
    public class AplicadorShampoo : EtapaLavado
    {
        public int Aplicar(Cliente cliente ) 
        {
            Console.WriteLine("Se aplica el shampoo");
            return 100;
        }
    }
}
