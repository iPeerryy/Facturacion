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
        public  string cedula { get; set; } // Clave primaria
        public string nombre { get; set; }
        public bool esFrecuente { get; set; }
    }
}

namespace SistemaFacturacion.Models.Interfaces
{
    public interface ICliente<T>
    {
        void AgregarCliente(T cliente);
        void ActualizarCliente(T cliente);
        void EliminarCliente(string cedula);
        T ObtenerCliente(string cedula);
        List<T> ObtenerTodos();
    }
}
    

