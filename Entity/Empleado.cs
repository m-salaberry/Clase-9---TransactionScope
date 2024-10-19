using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Empleado
    {

        private string apellidoNombre;
        private int dni;
        private double sueldoBruto;

        public string ApellidoNombre { get => apellidoNombre; set => apellidoNombre = value; }
        public int Dni { get => dni; set => dni = value; }
        public double SueldoBruto { get => sueldoBruto; set => sueldoBruto = value; }

       
    }
}
