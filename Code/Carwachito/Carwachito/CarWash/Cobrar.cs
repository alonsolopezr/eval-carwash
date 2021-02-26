using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carwachito.Personas;


namespace Carwachito.CarWash
{
    public class Cobrar : EtapaLavado
    {

        public int Cobro(Cliente cliente) {

            Console.WriteLine("Se cobra al cliente \n¿Con cuanto pago el cliente?");
            double efectivo = double.Parse(Console.ReadLine());
            cliente.Pagar(efectivo);



            Console.WriteLine("");
            
            return 1; }
    }
}
