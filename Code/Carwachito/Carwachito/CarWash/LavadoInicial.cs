using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carwachito.Personas;

namespace Carwachito.CarWash
{
    public class LavadoInicial : EtapaLavado
    {
        public int empezar(Cliente cliente) 
        {
            Console.WriteLine("Se inicia el lavado");
            return 100;
        
        }

    }
}
