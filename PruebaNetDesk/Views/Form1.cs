
using Newtonsoft.Json;
using PruebaNetDesk.Controllers.Services;
using PruebaNetDesk.Models;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace PruebaNetDesk
{
    public partial class Form1 : Form
    {
        private EmpleadoService _empleadoService;

        public Form1()
        {
            InitializeComponent();
            _empleadoService = new EmpleadoService();

        }

        private async void Form1_Load(object sender, EventArgs e)
        {

            ResponseDto? response = await _empleadoService.GetEmpleadosAsync();

            //List<Empleado> lst = response?.Data!
            // Verifica si la operación fue exitosa y muestra un mensaje
            if (response != null && response.IsSuccess)
            {
                List<Empleado> lst = JsonConvert.DeserializeObject<List<Empleado>>(response.Data);
                dataGridView1.DataSource = lst;
                MessageBox.Show("Empleado creado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hubo un error al crear el empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
