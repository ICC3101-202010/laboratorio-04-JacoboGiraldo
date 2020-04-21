using System;
using System.Collections.Generic;

namespace Laboratorio04
{
    public class ComputadorCentral : IConfirmReboot
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
        Trabajador Trabajador = new Trabajador("Andres Howard","17800678-9");


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

            if (R1.ChequeoReinicio() == 4)
            {
                bool X1 = true;
                Trabajador.ConfirmReboot(X1, Trabajador.NR());
                R1.ConfirmReboot(X1, "Recepcion"); 
            }
            else if (R1.ChequeoReinicio()!=4)
            {
                bool Y1 = false;
                R1.ConfirmReboot(Y1, "Recepcion");
            }
            if (A1.ChequeoReinicio() == 4)
            {
                bool X2 = true;
                Trabajador.ConfirmReboot(X2, Trabajador.NR());
                A1.ConfirmReboot(X2,"Almacenamiento");
            }
            else if (A1.ChequeoReinicio() != 4)
            {
                bool Y2 = false;
                A1.ConfirmReboot(Y2, "Almacenamiento");
            }
            if (EN1.ChequeoReinicio() == 4)
            {
                bool X3 = true;
                Trabajador.ConfirmReboot(X3, Trabajador.NR());
                EN1.ConfirmReboot(X3, "Ensamblaje");
            }
            else if (EN1.ChequeoReinicio() != 4)
            {
                bool Y3 = false;
                EN1.ConfirmReboot(Y3, "Ensamblaje");
            }
            if (V1.ChequeoReinicio() == 4)
            {
                bool X4 = true;
                Trabajador.ConfirmReboot(X4, Trabajador.NR());
                V1.ConfirmReboot(X4, "Verificacion");
            }
            else if (V1.ChequeoReinicio() != 4)
            {
                bool Y4 = false;
                V1.ConfirmReboot(Y4, "Verificacion");
            }
            if (EM1.ChequeoReinicio() == 4)
            {
                bool X5 = true;
                Trabajador.ConfirmReboot(X5, Trabajador.NR());
                EM1.ConfirmReboot(X5, "Empaque");
            }
            else if (EM1.ChequeoReinicio() != 4)
            {
                bool Y5 = false;
                EM1.ConfirmReboot(Y5, "Empaque");
            }
        }

        public void ConfirmReboot(bool Boolean, string name)
        {
            
        }
    }
}
