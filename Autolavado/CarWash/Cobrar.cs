using System;
using System.Collections.Generic;
using System.Text;

namespace Autolavado
{
    public class Cobrar
    {
        public string Costo 
        {
            get;
            set;
        }
        public double Precio 
        {
            get;
            set;
        }

        public int Cliente;
        public Cobrar(string cobro, double precio, int cliente) 
        {
            this.Cliente = cliente;

           // this.Costo = cobro;
           // this.Precio = precio;
        }
    }
}
