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


        
        public void menu() 
        {
            for (int i = 1; i < 7; i++)
            {
                Console.WriteLine("Se está lavando el carro siguiendo este orden: ");
                Cepillado cepillado = new Cepillado();
                AplicadorShampoo aplicadorShampoo = new AplicadorShampoo();
                LavadoInicial lavadoInicial = new LavadoInicial();
                Secado secado = new Secado();
                EntregaCarro entregaCarro = new EntregaCarro();

                Console.WriteLine(turnoDeLista = i);
            }
        }
            
                
        


    }
}
