

namespace PruebaNetWF.Views
{
    partial class VAreas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            btnEliminarEmpleado = new Button();
            btnEditarEmpleado = new Button();
            btnAgregar = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            txbNombreArea = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(810, 475);
            button1.Name = "button1";
            button1.Size = new Size(209, 39);
            button1.TabIndex = 12;
            button1.Text = "Menú Empleados";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnEliminarEmpleado
            // 
            btnEliminarEmpleado.Enabled = false;
            btnEliminarEmpleado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminarEmpleado.Location = new Point(358, 172);
            btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            btnEliminarEmpleado.Size = new Size(158, 39);
            btnEliminarEmpleado.TabIndex = 11;
            btnEliminarEmpleado.Text = "Eliminar Area";
            btnEliminarEmpleado.UseVisualStyleBackColor = true;
            btnEliminarEmpleado.Click += btnEliminarEmpleado_Click;
            // 
            // btnEditarEmpleado
            // 
            btnEditarEmpleado.Enabled = false;
            btnEditarEmpleado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditarEmpleado.Location = new Point(174, 172);
            btnEditarEmpleado.Name = "btnEditarEmpleado";
            btnEditarEmpleado.Size = new Size(178, 39);
            btnEditarEmpleado.TabIndex = 10;
            btnEditarEmpleado.Text = "Guardar Cambios";
            btnEditarEmpleado.UseVisualStyleBackColor = true;
            btnEditarEmpleado.Click += btnEditarEmpleado_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(10, 172);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(158, 39);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar Area";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(321, 18);
            label1.Name = "label1";
            label1.Size = new Size(215, 38);
            label1.TabIndex = 7;
            label1.Text = "LISTA DE AREAS";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Location = new Point(48, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(369, 416);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // txbNombreArea
            // 
            txbNombreArea.Location = new Point(152, 112);
            txbNombreArea.Name = "txbNombreArea";
            txbNombreArea.Size = new Size(339, 27);
            txbNombreArea.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 119);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 14;
            label2.Text = "Nombre de Area";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnEliminarEmpleado);
            panel1.Controls.Add(txbNombreArea);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(btnEditarEmpleado);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(469, 111);
            panel1.Name = "panel1";
            panel1.Size = new Size(550, 241);
            panel1.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(137, 33);
            label3.Name = "label3";
            label3.Size = new Size(215, 38);
            label3.TabIndex = 16;
            label3.Text = "LISTA DE AREAS";
            // 
            // VAreas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 526);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "VAreas";
            Text = "Areas";
            Load += VAreas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Button button1;
        private Button btnEliminarEmpleado;
        private Button btnEditarEmpleado;
        private Button btnAgregar;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox txbNombreArea;
        private Label label2;
        private Panel panel1;
        private Label label3;
    }
}