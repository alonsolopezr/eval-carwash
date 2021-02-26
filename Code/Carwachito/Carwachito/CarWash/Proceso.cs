using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carwachito.Personas;

namespace Carwachito.CarWash
{
    public class Proceso
    {
        public List<Cliente> listaLavado= new List<Cliente>();
        public double costoLavado=300;
        public List<EtapaLavado> procedimiento= new List<EtapaLavado>();

        public Proceso() { 
        
        
        }


        public bool IniciarProceso(Cliente cliente) {
            EtapaLavado etapa = new EtapaLavado();
            LavadoInicial lavIni=new LavadoInicial();
            AplicadorShampoo aplicShamp= new AplicadorShampoo();
            Secado secado= new Secado();
            Cepillado cep= new Cepillado();
            etapa.tiempoInicial= DateTime.UtcNow;
            costoLavado = 0;
            

            costoLavado+=aplicShamp.Aplicar(cliente);
            costoLavado+=lavIni.empezar(cliente);
            costoLavado+=secado.Secar(cliente);
            costoLavado+=cep.Cepillar(cliente);

            etapa.tiempoFinal = DateTime.UtcNow;
            procedimiento.Add(etapa);
            return true;
        }
    }
}
