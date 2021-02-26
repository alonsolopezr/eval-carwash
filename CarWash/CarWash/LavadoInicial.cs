using System;
using System.Collections.Generic;
using System.Text;
using CarWash.Personas;

namespace CarWash.CarWash
{
    class LavadoInicial:EtapaLavado
    {
        //metodos
        public int empezar(Cliente cliente) 
        {
            //funcionalidad en proceso de ser aprendida
            this.tiempoInicial = DateTime.Now;
            return 1;
        }
    }
}
