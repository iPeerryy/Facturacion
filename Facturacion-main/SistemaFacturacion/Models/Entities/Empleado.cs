using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacion.Models.Entities
{
    public class Empleado : Persona
    {
        public string cargo { get; set; }
        public int salario { get; set; }

        public interface IEmpleados<T>
        {
            T Autenticar(string username, string password);
            T ObtenerPorCedula(string cedula);
            List<T> ObtenerTodos();
            void AgregarEmpleado(T empleado);
            void ActualizarEmpleado(T empleado);
            void EliminarEmpleado(string cedula);
        }
    }
}
