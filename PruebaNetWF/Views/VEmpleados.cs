using Newtonsoft.Json;
using PruebaNetWF.Controladores;
using PruebaNetWF.Models;
using PruebaNetWF.Views;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace PruebaNetWF
{
    public partial class VEmpleados : Form
    {
        public VEmpleados()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetEmpleados();
        }
        public void Actualizar()
        {
            GetEmpleados();
        }

        private async void GetEmpleados()
        {
            EmpleadoController Emp = new EmpleadoController();
            String respuesta = await Emp.getEmpleados();

            if (respuesta != null)
            {
                List<Empleado> lstEmpleados = JsonConvert.DeserializeObject<List<Empleado>>(respuesta);

                //MessageBox.Show(respuesta);

                dataGridView1.DataSource = null;// Limpiar las filas
                dataGridView1.Columns.Clear(); // Limpiar las columnas

                dataGridView1.AutoGenerateColumns = false;

                DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
                idColumn.HeaderText = "Id";
                idColumn.DataPropertyName = "Id";
                dataGridView1.Columns.Add(idColumn);

                DataGridViewTextBoxColumn nombreColumn = new DataGridViewTextBoxColumn();
                nombreColumn.HeaderText = "Nombre";
                nombreColumn.DataPropertyName = "Nombre";
                dataGridView1.Columns.Add(nombreColumn);

                DataGridViewTextBoxColumn apellidoPaternoColumn = new DataGridViewTextBoxColumn();
                apellidoPaternoColumn.HeaderText = "Apellido Paterno";
                apellidoPaternoColumn.DataPropertyName = "Apellido_Paterno";
                dataGridView1.Columns.Add(apellidoPaternoColumn);

                DataGridViewTextBoxColumn apellidoMaternoColumn = new DataGridViewTextBoxColumn();
                apellidoMaternoColumn.HeaderText = "Apellido Materno";
                apellidoMaternoColumn.DataPropertyName = "Apellido_Materno";
                dataGridView1.Columns.Add(apellidoMaternoColumn);

                // Crear una columna para mostrar la fecha de nacimiento del empleado
                DataGridViewTextBoxColumn fechaNacimientoColumn = new DataGridViewTextBoxColumn();
                fechaNacimientoColumn.HeaderText = "Fecha de Nacimiento";
                fechaNacimientoColumn.DataPropertyName = "Fecha_Nacimiento";
                dataGridView1.Columns.Add(fechaNacimientoColumn);

                // Crear una columna para mostrar el sueldo del empleado
                DataGridViewTextBoxColumn sueldoColumn = new DataGridViewTextBoxColumn();
                sueldoColumn.HeaderText = "Sueldo";
                sueldoColumn.DataPropertyName = "Sueldo";
                dataGridView1.Columns.Add(sueldoColumn);

                // Crear una columna para mostrar el nombre del área del empleado
                DataGridViewTextBoxColumn areaColumn = new DataGridViewTextBoxColumn();
                areaColumn.HeaderText = "Área";
                areaColumn.DataPropertyName = "nombreArea";
                dataGridView1.Columns.Add(areaColumn);


                dataGridView1.DataSource = lstEmpleados;
                dataGridView1.Refresh();
            }
        }

        private void btnEditarEmpleado_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener el valor del ID de la fila seleccionada
                int idEmpleado = (int)dataGridView1.SelectedRows[0].Cells[0].Value;

                Form EditarEmp = new EditarBorrarEmpleado(idEmpleado, this, false);
                EditarEmp.Show();
                // Ahora puedes usar el ID del empleado según sea necesario
                // Por ejemplo, puedes pasarlo a un método para obtener los detalles del empleado:
            }
            else
            {
                MessageBox.Show("Selecciona un empleado");
            }
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener el valor del ID de la fila seleccionada
                int idEmpleado = (int)dataGridView1.SelectedRows[0].Cells[0].Value;

                Form EliminarEmp = new EditarBorrarEmpleado(idEmpleado, this, true);
                EliminarEmp.Show();
                // Ahora puedes usar el ID del empleado según sea necesario
                // Por ejemplo, puedes pasarlo a un método para obtener los detalles del empleado:
            }
            else
            {
                MessageBox.Show("Selecciona un empleado");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Marea = new VAreas();
            Marea.Show();

        }
    }
}
