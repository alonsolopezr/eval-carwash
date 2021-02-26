using System;
using CarWash.CarWash;
using CarWash.Personas;
using System.Collections.Generic;

namespace CarWash
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Proceso proceso = new Proceso();
            Cliente nuevo1 = new Cliente("juan", "cabrera", "juanExtremo@gmail.com", "666248852");
            proceso.listaLAvado = new List<Cliente>();
            proceso.listaLAvado.Add(nuevo1);

        }
    }
}
