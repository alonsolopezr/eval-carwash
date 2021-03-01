using Autolavado.Personas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Autolavado
{
    public class EtapaLavado
    {
        public int turnoDeLista;
        public DateTime tiempoInicial;
        public DateTime tiempoFinal;


        
        public void menuEtapaLavado() 
        {
                Console.WriteLine("Comienzo del lavado a las: "+DateTime.Now.ToString("hh:mm tt"));
                Console.WriteLine("-> Se procederá a lavar el automovil siguiendo este orden: ");
                LavadoInicial lavadoInicial = new LavadoInicial();
                lavadoInicial.menuLavadoInicial();
                AplicadorShampoo aplicadorShampoo = new AplicadorShampoo();
                aplicadorShampoo.menuAplicadorShampoo();
                Cepillado cepillado = new Cepillado();
                cepillado.menuCepillado();
                Secado secado = new Secado();
                secado.menuSecado();
                Console.WriteLine("Hora a la que se terminó de lavar: " + DateTime.Now.ToString("hh:mm tt"));
                EntregaCarro entregaCarro = new EntregaCarro();
                entregaCarro.menuEntregaCarro();
                


        }

        public EtapaLavado(){ }
                
        


    }
}
