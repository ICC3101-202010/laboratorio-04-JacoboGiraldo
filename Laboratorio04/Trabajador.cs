using System;
namespace Laboratorio04
{
    public class Trabajador : IConfirmReboot
    {
        protected string nameT;
        protected string rutT;
        protected int ageT;

        public Trabajador(string name, string rut, int age)
        {
            nameT = name;
            rutT = rut;
            ageT = age;

        }
        public string NR()
        {
            string Info = nameT + " con Rut " + rutT;
            return Info;
        }
        public void ConfirmReboot(bool Boolean, string nameT)
        {
            Console.WriteLine("Desea efectuar el el control manual de reinicio para la maquina? (Si/No) Dependiendo de su decision el computador central informara el status de sus acciones");
            string confirmacion = Console.ReadLine();

            if (confirmacion == "Si" & Boolean == true)
            {
                Console.WriteLine("El trabajador "+nameT +" ha vaciado la memoria de la maquina");

            }
            if (confirmacion =="No")
            {
                Console.WriteLine("La maquina ha sido vaciada por el computador central");
            }
        }
    }
}
