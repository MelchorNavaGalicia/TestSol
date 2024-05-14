
using PruebaNetWF.Views;

namespace PruebaNetWF
{
    partial class VEmpleados
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label1 = new Label();
            btnAgregar = new Button();
            btnEditarEmpleado = new Button();
            btnEliminarEmpleado = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Location = new Point(42, 108);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(916, 362);
            dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(302, 32);
            label1.Name = "label1";
            label1.Size = new Size(289, 38);
            label1.TabIndex = 1;
            label1.Text = "LISTA DE EMPLEADOS";
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(25, 511);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(198, 39);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar Empleado";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditarEmpleado
            // 
            btnEditarEmpleado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditarEmpleado.Location = new Point(238, 511);
            btnEditarEmpleado.Name = "btnEditarEmpleado";
            btnEditarEmpleado.Size = new Size(198, 39);
            btnEditarEmpleado.TabIndex = 4;
            btnEditarEmpleado.Text = "Editar Información";
            btnEditarEmpleado.UseVisualStyleBackColor = true;
            btnEditarEmpleado.Click += btnEditarEmpleado_Click;
            // 
            // btnEliminarEmpleado
            // 
            btnEliminarEmpleado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminarEmpleado.Location = new Point(452, 511);
            btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            btnEliminarEmpleado.Size = new Size(198, 39);
            btnEliminarEmpleado.TabIndex = 5;
            btnEliminarEmpleado.Text = "Eliminar Empleado";
            btnEliminarEmpleado.UseVisualStyleBackColor = true;
            btnEliminarEmpleado.Click += btnEliminarEmpleado_Click;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(846, 511);
            button1.Name = "button1";
            button1.Size = new Size(130, 39);
            button1.TabIndex = 6;
            button1.Text = "Menú Areas";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // VEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 587);
            Controls.Add(button1);
            Controls.Add(btnEliminarEmpleado);
            Controls.Add(btnEditarEmpleado);
            Controls.Add(btnAgregar);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "VEmpleados";
            Text = "Lista de Empleados";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Form Agregar = new AgregarEmpleado(this);

            Agregar.Show();
        }

        
        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button btnAgregar;
        private Button btnEditarEmpleado;
        private Button btnEliminarEmpleado;
        private Button button1;
    }
}
