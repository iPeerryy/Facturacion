using SistemaFacturacion.Models.Context;
using SistemaFacturacion.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SistemaFacturacion.Models.Entities.Empleado;

namespace SistemaFacturacion.Models.Repositories
{
    public class EmpleadoRepository : IEmpleados<Empleado>
    {
        private readonly CafeteriaContext _context;

        public EmpleadoRepository(CafeteriaContext context)
        {
            _context = context;
        }

        public Empleado Autenticar(string username, string password)
        {
            return _context.Empleados.FirstOrDefault(e => e.cedula == username && e.cargo == password);
        }

        public Empleado ObtenerPorCedula(string cedula)
        {
            return _context.Empleados.FirstOrDefault(e => e.cedula == cedula);
        }

        public List<Empleado> ObtenerTodos()
        {
            return _context.Empleados.ToList();
        }

        public void AgregarEmpleado(Empleado empleado)
        {
            _context.Empleados.Add(empleado);
            _context.SaveChanges();
        }

        public void ActualizarEmpleado(Empleado empleado)
        {
            var empleadoExistente = _context.Empleados.FirstOrDefault(e => e.cedula == empleado.cedula);
            if (empleadoExistente != null)
            {
                empleadoExistente.nombre = empleado.nombre;
                empleadoExistente.cargo = empleado.cargo;
                empleadoExistente.salario = empleado.salario;
                _context.SaveChanges();
            }
        }

        public void EliminarEmpleado(string cedula)
        {
            var empleado = _context.Empleados.FirstOrDefault(e => e.cedula == cedula);
            if (empleado != null)
            {
                _context.Empleados.Remove(empleado);
                _context.SaveChanges();
            }
        }
    }
}
