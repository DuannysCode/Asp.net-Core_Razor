using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica_ll
{
    public class Nomina
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cargo { get; set; }
        public double Sueldo_Bruto { get; set; }
        //public static double SFS { get; set; }

        public double SFS(double sueldo_bruto)
        {
            double sfs = 0.0304;
            double descuento = sueldo_bruto * sfs;

            return Math.Round(descuento, 2);
        }

        public double AFP(double sueldo_bruto)
        {
            double afp = 0.0287;
            double descuento = sueldo_bruto * afp;

            return Math.Round(descuento, 2);
        }

        public double ISR(double sfs, double afp, double sueldo_bruto)
        {
            double deducciones = sfs + afp;
            double ISR = (sueldo_bruto - deducciones)*12;
            double Escala1 = 416220.00;
            double Escala2 = 416220.01;
            double Escala3 = 624329.00;
            double Escala4 = 624329.01;
            double Escala5 = 867123.00;
            double Escala6 = 867123.01;
            double porcentaje1 = 0.15;
            double porcentaje2 = 0.20;
            double porcentaje3 = 0.25;
            double monto_fijo1 = 31216.00;
            double monto_fijo2 = 79776.00;
            double isr = 0.0;
            double descuento = 0.0;

            if (ISR <= Escala1)
            {
                ISR = 0.0;
            }
            else if(ISR>=Escala2 && ISR<=Escala3)
            {
                isr = ISR - Escala2;
                descuento = isr * porcentaje1;
                Math.Round(ISR = descuento / 12, 2);
            }
            else if(ISR>=Escala4 && ISR<=Escala5)
            {
                isr = ISR - Escala4;
                descuento = isr * porcentaje2;
                double monto_fijo = descuento + monto_fijo1;
                ISR = monto_fijo / 12;
            }
            else if (ISR >= Escala6)
            {
                isr = ISR - Escala6;
                descuento = isr * porcentaje3;
                double monto_fijo = descuento + monto_fijo2;
                ISR = monto_fijo / 12;
            }

            return Math.Round(ISR, 2);
        }

        public double Total_TSS(double sfs, double afp)
        {
            double tss = sfs + afp;
            return Math.Round(tss, 2);
        }

        public double Total_Desc(double total_tss, double isr)
        {
            double total_desc = total_tss + isr;
            return Math.Round(total_desc, 2);
        }

        public double Sueldo_Neto(double sueldo_bruto, double sfs, double afp, double isr)
        {
            double sueldo_neto = sueldo_bruto - (sfs + afp + isr);
            return Math.Round(sueldo_neto, 2);
        }
    }
}
