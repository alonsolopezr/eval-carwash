using System;
using System.Collections.Generic;
using examenCarwash.Personas;

namespace examenCarwash.Carwash
{
    public class Proceso
    {
        //atrributos
        //lo vamos a hacer static para poderlo acceder DESDE LA CLASE
        public static List<Cliente> listaLavado = new List<Cliente>();
        //costo del lavado, static para poder hacer: Proceso.costoLavado
        public static double costoLavado;

        //lista de Etapas de Lavado
        public List<EtapaLavado> procedimiento;

        //INCIIALIZA MIEMBROS STATIC
        static Proceso()
        {
            Proceso.costoLavado = 202.20;
        }

        //CONSTRUYE OBJETOS DE ESTE TIPO -Proceso-
        public Proceso()
        {
            this.procedimiento = new List<EtapaLavado>()
            {
                new Cobrar(),
                new LavadoInicial(),
                new AplicadorShampoo(),
                new Cepillado(),
                new Secado(),
                new EntregaCarro(),
            };
        }

        //redefinimos ToString()
        public override string ToString()
        {
            return $"Lavado en Operación "+Environment.NewLine+
                $" El costo del servicio es {Proceso.costoLavado}."+Environment.NewLine+
                $"Atendiendo a {Proceso.listaLavado.Count} clientes este día {DateTime.Now.ToLongDateString()}.";
        }

    }
}
