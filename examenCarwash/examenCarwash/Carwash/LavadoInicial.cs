using System;
using System.Threading;
using examenCarwash.Personas;

namespace examenCarwash.Carwash
{
    class LavadoInicial : EtapaLavado
    {

        public int empezar(Cliente cli)
        {
            //sacamos el turno de la lista de lcientes
            int turno = Proceso.listaLavado.IndexOf(cli);
            //tomamos el tiempo INCIAL
            this.tiempoInicial = DateTime.Now; //toma hora fecha del sistema
            Console.WriteLine("Inicio del lavado inicial a las " + this.tiempoInicial.ToLongTimeString());
        
            //imprimir inicio del proceso
            //creamos un Sleep con un tiempo entre 8 y 12 segs
            Thread.Sleep(8000 + new Random().Next(4000));
            //tomamos el tiempo FINALAL
            this.tiempoFinal = DateTime.Now;
            //imrpimir final
            Console.WriteLine("Final de la etapa Lavado Inciial a las " + this.tiempoFinal.ToLongTimeString());
            //imprimir el fin del rpoceso
            Console.WriteLine($"El proceso llevó {this.tiempoFinal.Subtract(this.tiempoInicial).Seconds} segundos");
            return turno;
        }
    }
}