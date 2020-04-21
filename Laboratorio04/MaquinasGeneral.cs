using System;
using System.Collections.Generic;

namespace Laboratorio04
{
    public abstract class MaquinasGeneral : IConfirmReboot
    {
        protected string name;

        


        //Encendido
        public void Encendido(DateTime HoraE, string name)
        {
            Console.WriteLine("La Maquina de "+ name +" ha sido encendida a las " + HoraE);
        }

        //Reinicio
        public void ConfirmReboot(bool Boolean,string name)
        {
            if (Boolean == true)
            {
                Console.WriteLine("Se ha vaciado la memoria de la maquina de "+ name);
            }
            else if (Boolean == false)
            {
                Console.WriteLine("La maquina de "+name+" aun no ha llegado a la capacidad total de su memoria");
            }
        }
        //Apagado
        public void Apagado(DateTime HoraA, string name)
        {
            Console.WriteLine("La Maquina de " + name + " ha sido apagada a las " + HoraA);
        }

        //Memoria
        public int ChequeoReinicio()
        {
            Random random = new Random();
            int Cont = random.Next(0, 5);
            return Cont;


        }

        


    }
}
