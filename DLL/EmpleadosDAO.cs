using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Transactions;

namespace DLL
{
    public class EmpleadosDAO
    {

        public List<Empleado> ObtenerEmpleados()
        {
			try
			{
				List<Empleado> empleados = new List<Empleado>();
				using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBSql"].ConnectionString))
				{
					using(SqlCommand cmd = new SqlCommand("SELECT * FROM EMPLEADO", con))
					{
						SqlDataReader dr = cmd.ExecuteReader();
						while (dr.Read())
						{
							Empleado emp = new Empleado
							{
								ApellidoNombre = dr["APELLIDO_NOMBRE"].ToString(),
								Dni = Convert.ToInt32(dr["DNI"]),
								SueldoBruto = Convert.ToDouble(dr["SUELDO_NETO"])
							};
							empleados.Add(emp);
                        }
					}
				}
				return empleados;
			}
			catch (Exception)
			{

				throw;
			}
        }

		public void CargarEmpleado(Empleado emp)
		{
			try
			{
				using(SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBSql"].ConnectionString))
				{
					using (SqlCommand cmd = new SqlCommand("INSERT INTO EMPLEADO (APELLIDO_NOMBRE,DNI,SUELDO_NETO) VALUES (@nom,@dni,@sueldo)", con))
					{
						cmd.Parameters.AddWithValue("@nom", emp.ApellidoNombre);
						cmd.Parameters.AddWithValue("@dni", emp.Dni);
						cmd.Parameters.AddWithValue("@sueldo", CalcularSueldoNeto(emp.SueldoBruto));
						cmd.ExecuteNonQuery();
					}
				}
			}
			catch (Exception)
			{

				throw;
			}
		}

		public double CalcularSueldoNeto(double sueldoBruto)
		{
			try
			{
				return sueldoBruto * 0.83;
			}
			catch (Exception)
			{

				throw;
			}
		}

    }
}
