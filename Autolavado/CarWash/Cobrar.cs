using System;
using System.Collections.Generic;
using System.Text;
using Autolavado.Personas;

namespace Autolavado.Personas
{
    public class Cobrar
    {

        private double precioLavado = 16.25;
        private double precioShampoo = 16.25;
        private double precioCepillado = 16.25;
        private double precioSecado = 16.25;

        public double PrecioLavado
        {
            get => precioLavado;
            set => precioLavado = value;
        }
        public double PrecioShampoo
        {
            get => precioShampoo;
            set => precioShampoo = value;
        }
        public double PrecioCepillado
        {
            get => precioCepillado;
            set => precioCepillado = value;
        }
        public double PrecioSecado
        {
            get => this.precioSecado;
            set => precioSecado = value;
        }



        public Cobrar() 
        { 
        
        }
    }
}
