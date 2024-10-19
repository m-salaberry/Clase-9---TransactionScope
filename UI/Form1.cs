using Entity;
using BLL;
namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Business business = new Business();
        Empleado emp = new Empleado();
        List<Empleado> borradorEmpleados = new List<Empleado>();

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                emp = new Empleado
                {
                    ApellidoNombre = txtNombre.Text + " " + txtApellido.Text,
                    Dni = Convert.ToInt32(txtDni.Text),
                    SueldoBruto = Convert.ToDouble(txtSueldoBruto.Text)
                };
                borradorEmpleados.Add(emp);
                MessageBox.Show("Empleado agregado correctamente");
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }
            
        }

        public void CargarGrilla()
        {
            try
            {
                List<Empleado> empleados = business.ObtenerEmpleados();
                dgvEmpleados.DataSource = null;
                dgvEmpleados.DataSource = empleados;
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                business.CargarEmpleado(borradorEmpleados);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
