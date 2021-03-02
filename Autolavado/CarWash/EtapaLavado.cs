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
                Console.WriteLine("Fecha del lavado: "+ DateTime.Now.ToString("MM/dd/yyyy hh:mm tt"));
                Console.WriteLine("-> El proceso del lavado del automovil se llevó a cabo siguiendo este orden: ");
                LavadoInicial lavadoInicial = new LavadoInicial();
                lavadoInicial.menuLavadoInicial();
                AplicadorShampoo aplicadorShampoo = new AplicadorShampoo();
                aplicadorShampoo.menuAplicadorShampoo();
                Cepillado cepillado = new Cepillado();
                cepillado.menuCepillado();
                Secado secado = new Secado();
                secado.menuSecado();
                EntregaCarro entregaCarro = new EntregaCarro();
                entregaCarro.menuEntregaCarro();
                


        }

        public EtapaLavado(){ }
                
        


    }
}
