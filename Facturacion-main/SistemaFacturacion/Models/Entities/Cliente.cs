using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace SistemaFacturacion.Models.Entities
{
    public class Cliente : Persona
    {
        [Key]
        public string cedula { get; set; } 
        public string nombre { get; set; }
        public bool esFrecuente { get; set; }
      
    }
}

    

