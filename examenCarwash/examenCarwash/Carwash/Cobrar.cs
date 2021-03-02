using System;
using examenCarwash.Personas;

namespace examenCarwash.Carwash
{
    public class Cobrar : EtapaLavado
    {
        //constructor
        public Cobrar() { }

        public static int cobrar(Cliente cli)
        {
            int turno = 0;
            //imprimir el costo del lavado
            Console.WriteLine($"El costo del lavado es {Proceso.costoLavado}");

            //no proceder hasta qye cubra el costo
            double cambio = -1;//la feria del pago por el lavado
            while (true)
            {
                //pedir el pago al cliente
                Console.WriteLine("¿Con cuanto paga el lavado?");
                double pago = double.Parse(Console.ReadLine());
                //sacar la uenta del cobro
                cambio = pago - Proceso.costoLavado;
                if (cambio < 0) Console.WriteLine("No has pagado suficiente...");
            }
            //imprimir el cambio
            Console.WriteLine("Tu cambio es $"+cambio);
            //agregar el cliente a la lista de PROCESO
            Proceso.listaLavado.Add(cli);
            //buscamos el turno del cliente que se acaba de agregar
            turno = Proceso.listaLavado.IndexOf(cli);
            //devolver el turno
            return turno;
        }
    }
}