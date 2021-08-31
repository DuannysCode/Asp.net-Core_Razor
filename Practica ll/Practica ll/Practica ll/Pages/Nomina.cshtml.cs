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
        public List<Nomina> Nominas { get; set; }

        public NominaModel()
            {
            this.Nominas = new List<Nomina>() {
                new Nomina() {Nombre = "Richard", Apellido = "Arias", Cargo = "Senior Developer III", Sueldo_Bruto = 245000 },
                new Nomina() {Nombre = "Elianny", Apellido = "Arias", Cargo = "Enc. Contabilidad", Sueldo_Bruto = 95000 },
                new Nomina() {Nombre = "Maria", Apellido = "Batista", Cargo = "Publicista", Sueldo_Bruto = 45000 },
                new Nomina() {Nombre = "Alejandro", Apellido = "Paradis", Cargo = "Chofer", Sueldo_Bruto = 30000 },
                new Nomina() {Nombre = "Amanda", Apellido = "Encarnacion", Cargo = "Conserje", Sueldo_Bruto = 21000 }
            };

            }
        public void OnGet()
        {

        }
    }
}
