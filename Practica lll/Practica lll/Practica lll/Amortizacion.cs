using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica_lll
{
    public class Amortizacion
    {
        public double Monto { get; set; }
        public int Cantidad_Cuotas { get; set; }
        public double Interes_Anual { get; set; }

        public static double Cuotas_Mensuales(double monto, int cantidad_cuotas, double interes_anual)
        {
            double interes = (interes_anual / 100) / 12;
            double monto_g = monto * interes;
            double cuotas_mensuales = (monto_g) / (1 - Math.Pow((1+interes), -cantidad_cuotas));

            if(cuotas_mensuales is double.NaN)
            {
                return 0.00;
            }
            else
            {
                return Math.Round(cuotas_mensuales, 2);
            }
        }
    }
}
