using Newtonsoft.Json;
using PruebaNetWF.Controladores;
using PruebaNetWF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaNetWF.Views
{
    public partial class VAreas : Form
    {
        int _IdArea = -1;
        public VAreas()
        {
            InitializeComponent();

        }
        private void VAreas_Load(object sender, EventArgs e)
        {
            GetAreas();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                _IdArea = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                string nombreArea = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txbNombreArea.Text = nombreArea;
                EnabledEdit(true);
            }
        }

        private void EnabledEdit(bool editar)
        {
            btnAgregar.Enabled = !editar;
            btnEditarEmpleado.Enabled = editar;
            btnEliminarEmpleado.Enabled = editar;
        }

        private async void GetAreas()
        {
            AreaController area = new AreaController();
            String respuesta = await area.getAreas();

            if (respuesta != null)
            {
                List<Area> lstArea = JsonConvert.DeserializeObject<List<Area>>(respuesta);

                //MessageBox.Show(respuesta);
                _IdArea = -1;
                dataGridView1.DataSource = null;// Limpiar las filas
                dataGridView1.Columns.Clear(); // Limpiar las columnas

                dataGridView1.AutoGenerateColumns = false;

                DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
                idColumn.HeaderText = "Id";
                idColumn.DataPropertyName = "IdArea";
                dataGridView1.Columns.Add(idColumn);

                DataGridViewTextBoxColumn nombreColumn = new DataGridViewTextBoxColumn();
                nombreColumn.HeaderText = "Nombre Area";
                nombreColumn.DataPropertyName = "NombreArea";
                dataGridView1.Columns.Add(nombreColumn);

                dataGridView1.DataSource = lstArea;
                dataGridView1.Refresh();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            PostArea();
        }

        private async void PostArea()
        {
            string nombreArea = txbNombreArea.Text;

            if (string.IsNullOrEmpty(nombreArea))
            {
                MessageBox.Show("Aigna un nombre al Area");

            }
            else
            {
                Area area = new Area
                {
                    IdArea = 0,
                    nombreArea = nombreArea
                };
                AreaController areaController = new AreaController();
                string respuesta = await areaController.PostArea(area);

                // Verificar la respuesta del servidor
                if (!string.IsNullOrEmpty(respuesta))
                {
                    MessageBox.Show("Area agregada exitosamente");

                    txbNombreArea.Text = "";
                    GetAreas();
                    EnabledEdit(false);
                }
                else
                {
                    MessageBox.Show("Error al agregar el Area.");
                }
            }
        }

        private async void PutArea()
        {
            string nombreArea = txbNombreArea.Text;

            if (string.IsNullOrEmpty(nombreArea))
            {
                MessageBox.Show("No puedes guardar en blanco");

            }
            else
            {
                Area areaActualizado = new Area
                {
                    IdArea = _IdArea,
                    nombreArea = nombreArea,
                };

                // Instanciar el controlador de empleados
                AreaController areaControlador = new AreaController();

                // Llamar al método putEmpleado para actualizar el empleado
                bool resultado = await areaControlador.PutArea(areaActualizado);

                // Verificar si la operación fue exitosa
                if (resultado)
                {
                    MessageBox.Show("Area actualizada exitosamente.");
                    txbNombreArea.Text = "";
                    GetAreas();
                    EnabledEdit(false);
                }
                else
                {
                    MessageBox.Show("Error al actualizar el Area.");
                }
            }
        }

        private async void DeleteArea()
        {
            AreaController areaControlador = new AreaController();


            bool resultado = await areaControlador.deleteArea(_IdArea);


            if (resultado)
            {
                MessageBox.Show("Area eliminada exitosamente.");
                txbNombreArea.Text = "";
                GetAreas();
                EnabledEdit(false);
            }
            else
            {
                MessageBox.Show("Error al eliminar el Area.");
            }
        }

        private void btnEditarEmpleado_Click(object sender, EventArgs e)
        {
            PutArea();

        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            DeleteArea();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
