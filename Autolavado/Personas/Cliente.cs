using System;
using System.Collections.Generic;
using System.Text;

namespace Autolavado.Personas
{
    public class Cliente : Persona
    {
        //inicializamos cobro
        //Cobrar cobrar = new Cobrar();
        public Cliente()
        {
        }

        

        private string nombre;
        private string apellidos;
        private string email;
        private string celular;
        public new string Nombre 
        { 
            get { return nombre; }
            set { nombre = value; }
        }
        public new string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public new string Email
        {
            get { return email; }
            set { email = value; }
        }
        public new string Celular
        {
            get { return celular; }
            set { celular = value; }
        }
        
        public void menu()
        {
            for (int i = 1; i < 20; i++)
            {
                Cajero cajero1 = new Cajero();
                Console.WriteLine("\nCliente #"+i+" del día. \nBienvenido al Autolavado");
                //
                //SE INICIA EL REGISTRO CON EL CAJERO
                Cajero cajero = new Cajero();
                cajero.menuCobrarCliente();
                //DESPUÉS DE DECIR EL TOTAL DEL COBRO SE PREGUNTA SI ESTA DE ACUERDO
                Console.WriteLine("\nEstá de acuerdo? s/n");
                string sioNo = (Console.ReadLine());
                //SI ESTÁ DE ACUERDO SE INICIA EL LAVADO
                if (sioNo == ("s"))
                {
                    Console.WriteLine("SE IMPRIME EL TICKET\n");
                    EtapaLavado etapaLavado = new EtapaLavado();
                    etapaLavado.menuEtapaLavado();
                    break;
                    
                }
                if (sioNo == ("n")){
                    i = i - 1;
                    Console.WriteLine("\nGracias por su visita");
                    break;
                }
                else
                {
                    break;
                }





            }
            
        }





    }
}
