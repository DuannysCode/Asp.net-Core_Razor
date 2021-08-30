using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Practica_ll.Pages
{
    public class NominaModel : PageModel
    {
        public List<string> Nombres { get; set; } = new List<string>() { "Elianny", "Maria", "Richard", "Amanda", "Alejandro" };
        public List<string> Apellidos { get; set; } = new List<string>() { "Arias", "Batista", "Arias", "Paradis", "Cuevas" };
        public List<string> Cargo { get; set; } = new List<string>() { "Enc. Contabilidad", "Diseñadora Grafica", "IT Manager", "Secretaria", "Chofer" };
        public List<double> Salario { get; set; } = new List<double>() { 100000.00, 90000.00, 275000.00, 18000.00, 35000.00 };

        //Funcion SFS
        public double SFS(List<double> salarios)
        {
            double sfs = 0.0304;
            double descuento = 0.0;
            int id = 0;
            while (id < 5)
            {
                descuento = salarios[id] * sfs;
                id++;
            }
            return descuento;
        }

        public void OnGet()
        {

        }
    }
}
