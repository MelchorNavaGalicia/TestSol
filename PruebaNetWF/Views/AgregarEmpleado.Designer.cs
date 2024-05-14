namespace PruebaNetWF.Views
{
    partial class AgregarEmpleado
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
            label1 = new Label();
            btnAgregar = new Button();
            btnCancelar = new Button();
            txbNombre = new TextBox();
            txbApellidoM = new TextBox();
            txbApellidoP = new TextBox();
            txbSueldo = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            cbArea = new ComboBox();
            dTPFechaNacimiento = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(243, 31);
            label1.Name = "label1";
            label1.Size = new Size(287, 38);
            label1.TabIndex = 2;
            label1.Text = "AGREGAR EMPLEADO";
            label1.Click += label1_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(469, 460);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(245, 39);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar Empleado";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(80, 460);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(245, 39);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += button1_Click;
            // 
            // txbNombre
            // 
            txbNombre.Location = new Point(175, 138);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(273, 27);
            txbNombre.TabIndex = 6;
            // 
            // txbApellidoM
            // 
            txbApellidoM.Location = new Point(175, 240);
            txbApellidoM.Name = "txbApellidoM";
            txbApellidoM.Size = new Size(273, 27);
            txbApellidoM.TabIndex = 7;
            // 
            // txbApellidoP
            // 
            txbApellidoP.Location = new Point(175, 186);
            txbApellidoP.Name = "txbApellidoP";
            txbApellidoP.Size = new Size(273, 27);
            txbApellidoP.TabIndex = 8;
            // 
            // txbSueldo
            // 
            txbSueldo.Location = new Point(175, 355);
            txbSueldo.Name = "txbSueldo";
            txbSueldo.Size = new Size(273, 27);
            txbSueldo.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 141);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 12;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 189);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 13;
            label3.Text = "Apellido Paterno:";

            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 243);
            label4.Name = "label4";
            label4.Size = new Size(129, 20);
            label4.TabIndex = 14;
            label4.Text = "Apellido Materno:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 300);
            label5.Name = "label5";
            label5.Size = new Size(152, 20);
            label5.TabIndex = 15;
            label5.Text = "Fecha de Nacimiento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(104, 358);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 16;
            label6.Text = "Sueldo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(465, 138);
            label7.Name = "label7";
            label7.Size = new Size(43, 20);
            label7.TabIndex = 17;
            label7.Text = "Area:";
            // 
            // cbArea
            // 
            cbArea.FormattingEnabled = true;
            cbArea.Location = new Point(465, 161);
            cbArea.Name = "cbArea";
            cbArea.Size = new Size(249, 28);
            cbArea.TabIndex = 18;
            // 
            // dTPFechaNacimiento
            // 
            dTPFechaNacimiento.Format = DateTimePickerFormat.Short;
            dTPFechaNacimiento.Location = new Point(175, 300);
            dTPFechaNacimiento.Name = "dTPFechaNacimiento";
            dTPFechaNacimiento.Size = new Size(273, 27);
            dTPFechaNacimiento.TabIndex = 19;
            // 
            // AgregarEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 511);
            Controls.Add(dTPFechaNacimiento);
            Controls.Add(cbArea);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txbSueldo);
            Controls.Add(txbApellidoP);
            Controls.Add(txbApellidoM);
            Controls.Add(txbNombre);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(label1);
            Name = "AgregarEmpleado";
            Text = "AgregarEmpleado";
            Load += AgregarEmpleado_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAgregar;
        private Button btnCancelar;
        private TextBox txbNombre;
        private TextBox txbApellidoM;
        private TextBox txbApellidoP;
        private TextBox txbSueldo;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cbArea;
        private DateTimePicker dTPFechaNacimiento;
    }
}