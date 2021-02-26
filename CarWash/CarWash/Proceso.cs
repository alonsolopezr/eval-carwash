using System;
using System.Collections.Generic;
using System.Text;
using CarWash.Personas;

namespace CarWash.CarWash
{
    public class Proceso
    {
        //atributos
        public List<Cliente> listaLAvado;
        public double costoLavado;
        public List<EtapaLavado> procedimiento;

        //aprender a usar las listas en objetos




        //Contstructor
        public Proceso()
        {
            /*
             * Cada proceso se crea una Etapalista de 
             * lavado,(identificado por turno de a lista) 
             */
            EtapaLavado etapasLavado = new EtapaLavado();
        }
    }
}
