using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Practica_lll.Pages
{
    public class PrestamoModel : PageModel
    {
        public double Monto_P { get; set; }
        public int Cuotas_M { get; set; }
        public double Interes_A { get; set; }

        public void OnGet(double monto, int cantidad_cuotas, double interes_anual)
        {
            Math.Round(this.Monto_P = monto, 2);
            this.Cuotas_M = cantidad_cuotas;
            this.Interes_A = interes_anual;
        }
    }
}
