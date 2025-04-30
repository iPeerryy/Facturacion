using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacion.Models.Entities
{
    public class Empleado : Persona
    {
        public string cargo { get; set; }
        public int salario { get; set; }
    }
}
