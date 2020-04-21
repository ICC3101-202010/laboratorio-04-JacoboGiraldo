using System;
using System.Collections.Generic;

namespace Laboratorio04
{
    public class ComputadorCentral : ICheckReboot
    {

        // Set Encendido Time 7:00AM
        // Set Apagado Time 6:00PM

        
        private DateTime TiempoEncendido = new DateTime(2020, 04, 21, 7, 00, 00);
        private DateTime TiempoApagado = new DateTime(2020, 04, 21, 18, 00, 00);

        
        Recepcion R1 = new Recepcion();
        Almacenamiento A1 = new Almacenamiento();
        Ensamblaje EN1 = new Ensamblaje();
        Verificacion V1 = new Verificacion();
        Empaque EM1 = new Empaque();
        


        public void encendidoTotal()
        {
            R1.Encendido(TiempoEncendido.AddMinutes(1),"Recepcion");          
            A1.Encendido(TiempoEncendido.AddMinutes(2), "Almacenamiento");
            EN1.Encendido(TiempoEncendido.AddMinutes(3),"Ensamblaje");
            V1.Encendido(TiempoEncendido.AddMinutes(4), "Verificacion");
            EM1.Encendido(TiempoEncendido.AddMinutes(5), "Empaque");
        }
        public void apagadoTotal()
        {
            R1.Apagado(TiempoApagado.AddMinutes(-5), "Recepcion");
            A1.Apagado(TiempoApagado.AddMinutes(-4), "Almacenamiento");
            EN1.Encendido(TiempoApagado.AddMinutes(-3), "Ensamblaje");
            V1.Encendido(TiempoApagado.AddMinutes(-2), "Verificacion");
            EM1.Encendido(TiempoApagado.AddMinutes(-1), "Empaque");
        }
        public void ChequeoMemoria()
        {

            if (R1.ChequeoMemoria() == 4)
            {
                bool X1 = true;
                R1.CheckReboot(X1, "Recepcion"); 
            }
            else if (R1.ChequeoMemoria()!=4)
            {
                bool Y1 = false;
                R1.CheckReboot(Y1, "Recepcion");
            }
            if (A1.ChequeoMemoria() == 4)
            {
                bool X2 = true;
                A1.CheckReboot(X2,"Almacenamiento");
            }
            else if (A1.ChequeoMemoria() != 4)
            {
                bool Y2 = false;
                A1.CheckReboot(Y2, "Almacenamiento");
            }
            if (EN1.ChequeoMemoria() == 4)
            {
                bool X3 = true;
                EN1.CheckReboot(X3, "Ensamblaje");
            }
            else if (EN1.ChequeoMemoria() != 4)
            {
                bool Y3 = false;
                EN1.CheckReboot(Y3, "Ensamblaje");
            }
            if (V1.ChequeoMemoria() == 4)
            {
                bool X4 = true;
                V1.CheckReboot(X4, "Verificacion");
            }
            else if (V1.ChequeoMemoria() != 4)
            {
                bool Y4 = false;
                V1.CheckReboot(Y4, "Verificacion");
            }
            if (EM1.ChequeoMemoria() == 4)
            {
                bool X5 = true;
                EM1.CheckReboot(X5, "Empaque");
            }
            else if (EM1.ChequeoMemoria() != 4)
            {
                bool Y5 = false;
                EM1.CheckReboot(Y5, "Empaque");
            }
        }

        public void CheckReboot(bool Boolean, string name)
        {
            
        }
    }
}
