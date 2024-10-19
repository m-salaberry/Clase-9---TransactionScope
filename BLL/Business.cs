using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL;
using Entity;
using System.Transactions;
using System.Timers;
using System.Diagnostics.CodeAnalysis;

namespace BLL
{
    public class Business
    {
        EmpleadosDAO dao = new EmpleadosDAO();
        public List<Empleado> ObtenerEmpleados()
        {
            try
            {
                return dao.ObtenerEmpleados();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void CargarEmpleado(List<Empleado> empleados)
        {
            try
            {
                using(var trx = new TransactionScope())
                {
                    foreach(var emp in empleados)
                    {
                        VerificarEmpleado(emp);
                    }
                    trx.Complete();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void VerificarEmpleado(Empleado emp)
        {
            try
            {
                using(var trx = new TransactionScope())
                {
                    if (emp.ApellidoNombre.Length < 5)
                    {
                        throw new Exception("El nombre y apellido del empleado debe ser mayor a 5 caracteres");
                    }
                    if (emp.Dni.ToString().Length < 5)
                    {
                        throw new Exception("El DNI debe tener más de 11 digitos");
                    }
                    if (emp.SueldoBruto < 100000)
                    {
                        throw new Exception("El sueldo bruto no puede ser menor al SMV ($100.000)");
                    }
                   
                    dao.CargarEmpleado(emp);
                    trx.Complete();
                }
                
            }
            catch (Exception e)
            {

                throw new Exception(e.Message + "No se ha registrado en la base de datos");
            }
        }

    }
}
