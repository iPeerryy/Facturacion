using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacion.Models.Entities
{
    public class Persona
    {
        
        public string nombre { get; set; }
        [Key]
        public string cedula { get; set; }
    }
}
