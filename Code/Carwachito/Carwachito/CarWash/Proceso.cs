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
        public List<Cliente> listaLavado = new List<Cliente>();
        public double costoLavado = 0;
        public List<EtapaLavado> procedimiento = new List<EtapaLavado>();
        private EtapaLavado etapa = new EtapaLavado();
        private LavadoInicial lavIni = new LavadoInicial();
        private AplicadorShampoo aplicShamp = new AplicadorShampoo();
        private Secado secado = new Secado();
        private Cepillado cep = new Cepillado();

        public Proceso()
        {

        }

        public bool YesNoQ(string preg)
        {
            string resp = "";
            do
            {
                Console.WriteLine(preg);
                resp = Console.ReadLine();
                resp = resp.ToUpper();
                if (resp[0] == 'Y')
                {
                    return true;
                }
                else if (resp[0] == 'N')
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Respuesta no valida ingrese 'Y' o 'N' para responder");
                }

            } while (true);

        }


        public bool IniciarProceso(Cliente cliente)
        {
            etapa.tiempoInicial = DateTime.UtcNow;

            if (YesNoQ("Desea aplicar el shampoo? y/n"))
            {
                this.costoLavado += aplicShamp.Aplicar(cliente);
            }

            if (YesNoQ("Desea Enjuagar? y/n"))
            {
                this.costoLavado += lavIni.empezar(cliente);
            }

            if (YesNoQ("Desea Secar? y/n"))
            {
                this.costoLavado += secado.Secar(cliente);
            }

            if (YesNoQ("Desea Cepillar? y/n"))
            {
                this.costoLavado += cep.Cepillar(cliente);
            }

            etapa.tiempoFinal = DateTime.UtcNow;
            procedimiento.Add(etapa);
            return true;
        }
    }
}
