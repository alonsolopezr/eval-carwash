using System;
using System.Collections.Generic;
using System.Text;
using CarWash.Personas;

namespace CarWash.CarWash
{
    class EntregaCarro:EtapaLavado
    {


        //metodos
        public int entregar(Cliente cliente) 
        {
            return 1;

            this.tiempoFinal = DateTime.Now;
        
        }
    }
}
