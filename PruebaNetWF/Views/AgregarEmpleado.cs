using Microsoft.VisualBasic;
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
    public partial class AgregarEmpleado : Form
    {

        private VEmpleados _formularioPadre;
        public AgregarEmpleado(VEmpleados formularioPadre)
        {
            InitializeComponent();
            _formularioPadre = formularioPadre;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void AgregarEmpleado_Load(object sender, EventArgs e)
        {
            AreaController areaController = new AreaController();

            // Obtener la lista de áreas
            string areasJson = await areaController.getAreas();

            // Deserializar la respuesta JSON en una lista de áreas
            List<Area> areas = JsonConvert.DeserializeObject<List<Area>>(areasJson);

            // Mostrar las áreas en un ComboBox (suponiendo que tienes un control ComboBox llamado comboBoxAreas)

            cbArea.DataSource = areas;
            cbArea.DisplayMember = "NombreArea"; // Mostrar el nombre del área en el ComboBox
            cbArea.ValueMember = "IdArea"; // Asignar el valor del Id del área al ComboBox si lo necesitas para otras operaciones

            cbArea.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            PostEmpleado();


        }

        private async void PostEmpleado()
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
                double suel;
                if (double.TryParse(Sueldo, out suel))
                {
                    Empleado emp = new Empleado
                    {
                        Nombre = nombreEmp,
                        Apellido_Paterno = ApPat,
                        Apellido_Materno = ApMat,
                        Sueldo = suel,
                        Fecha_Nacimiento = dTPFechaNacimiento.Value,
                        IdArea = IdArea,
                    };
                    EmpleadoController empleadoController = new EmpleadoController();
                    string respuesta = await empleadoController.PostEmpleado(emp);

                    // Verificar la respuesta del servidor
                    if (!string.IsNullOrEmpty(respuesta))
                    {
                        MessageBox.Show("Empleado agregado exitosamente");

                        _formularioPadre.Actualizar();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Error al agregar el empleado.");
                    }

                }
            }
        }
    }
}
