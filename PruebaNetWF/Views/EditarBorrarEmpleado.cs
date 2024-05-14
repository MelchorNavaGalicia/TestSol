using Newtonsoft.Json;
using PruebaNetWF.Controladores;
using PruebaNetWF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaNetWF.Views
{
    public partial class EditarBorrarEmpleado : Form
    {
        int _Id;
        VEmpleados _emp;
        bool _borrar;
        public EditarBorrarEmpleado(int Id, VEmpleados emp, bool borrar)
        {
            InitializeComponent();
            _Id = Id;
            _emp = emp;
            _borrar = borrar;
        }

        private void EditarEmpleado_Load(object sender, EventArgs e)
        {
            if (_borrar)
            {
                Desable();
                textdel();
            }

            CargarInformacionAsync();
        }

        private async void CargarInformacionAsync()
        {
            EmpleadoController emp = new EmpleadoController();
            string empleadoJson = await emp.getEmpleadoById(_Id);

            Empleado empleado = JsonConvert.DeserializeObject<Empleado>(empleadoJson);

            if (empleado != null)
            {
                txbNombre.Text = empleado.Nombre.ToString();
                txbApellidoP.Text = empleado.Apellido_Paterno.ToString();
                txbApellidoM.Text = empleado.Apellido_Materno.ToString();
                txbSueldo.Text = empleado.Sueldo.ToString();

                dTPFechaNacimiento.Value = empleado.Fecha_Nacimiento;

                AreaController areaController = new AreaController();

                string areasJson = await areaController.getAreas();

                List<Area> areas = JsonConvert.DeserializeObject<List<Area>>(areasJson);


                cbArea.DataSource = areas;
                cbArea.DisplayMember = "NombreArea";
                cbArea.ValueMember = "IdArea";

                cbArea.DropDownStyle = ComboBoxStyle.DropDownList;

                cbArea.SelectedValue = empleado.IdArea;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (_borrar)
            {
                DeleteEmp();
            }
            else
            {
                UpdateEmp();
            }
        }

        private async void UpdateEmp()
        {
            string nombreEmp = txbNombre.Text;
            string ApPat = txbApellidoP.Text;
            string ApMat = txbApellidoM.Text;
            string Sueldo = txbSueldo.Text;

            int IdArea = ((Area)cbArea.SelectedItem).IdArea;

            string fechaN = dTPFechaNacimiento.Text;

            if (cbArea.SelectedIndex == -1 || string.IsNullOrEmpty(nombreEmp) || string.IsNullOrEmpty(ApPat) || string.IsNullOrEmpty(ApMat) || string.IsNullOrEmpty(Sueldo) || string.IsNullOrEmpty(fechaN))
            {
                MessageBox.Show("Se deben llenar todos los registros");

            }
            else
            {
                Empleado empleadoActualizado = new Empleado
                {
                    Id = _Id,
                    Nombre = nombreEmp,
                    Apellido_Paterno = ApPat,
                    Apellido_Materno = ApMat,
                    Fecha_Nacimiento = dTPFechaNacimiento.Value,
                    IdArea = IdArea,
                    Sueldo = Convert.ToDouble(txbSueldo.Text) // Convertir el sueldo a double
                };

                // Instanciar el controlador de empleados
                EmpleadoController empleadoControlador = new EmpleadoController();

                // Llamar al método putEmpleado para actualizar el empleado
                bool resultado = await empleadoControlador.PutEmpleado(empleadoActualizado);

                // Verificar si la operación fue exitosa
                if (resultado)
                {
                    MessageBox.Show("Empleado actualizado exitosamente.");
                    _emp.Actualizar();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el empleado.");
                }
            }
        }

        private async void DeleteEmp()
        {
           
            EmpleadoController empleadoControlador = new EmpleadoController();

            
            bool resultado = await empleadoControlador.deleteEmpleado(_Id);

            
            if (resultado)
            {
                MessageBox.Show("Empleado eliminado exitosamente.");
                _emp.Actualizar();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al eliminar el empleado.");
            }
        }

        private void Desable()
        {
            txbApellidoM.Enabled = false;
            txbNombre.Enabled = false;
            txbApellidoP.Enabled = false;
            txbSueldo.Enabled = false;
            dTPFechaNacimiento.Enabled = false;
            cbArea.Enabled = false;
        }

        private void textdel()
        {
            lbTitulo.Text = "ELIMINAR EMPLEADO";
            btnEditar.Text = "Eliminar";
        }
    }
}
