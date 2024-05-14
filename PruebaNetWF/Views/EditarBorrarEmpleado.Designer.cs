namespace PruebaNetWF.Views
{
    partial class EditarBorrarEmpleado
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
            dTPFechaNacimiento = new DateTimePicker();
            cbArea = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txbSueldo = new TextBox();
            txbApellidoP = new TextBox();
            txbApellidoM = new TextBox();
            txbNombre = new TextBox();
            btnCancelar = new Button();
            btnEditar = new Button();
            lbTitulo = new Label();
            SuspendLayout();
            // 
            // dTPFechaNacimiento
            // 
            dTPFechaNacimiento.Format = DateTimePickerFormat.Short;
            dTPFechaNacimiento.Location = new Point(213, 292);
            dTPFechaNacimiento.Name = "dTPFechaNacimiento";
            dTPFechaNacimiento.Size = new Size(273, 27);
            dTPFechaNacimiento.TabIndex = 34;
            // 
            // cbArea
            // 
            cbArea.FormattingEnabled = true;
            cbArea.Location = new Point(503, 153);
            cbArea.Name = "cbArea";
            cbArea.Size = new Size(249, 28);
            cbArea.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(503, 130);
            label7.Name = "label7";
            label7.Size = new Size(43, 20);
            label7.TabIndex = 32;
            label7.Text = "Area:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(142, 350);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 31;
            label6.Text = "Sueldo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 292);
            label5.Name = "label5";
            label5.Size = new Size(152, 20);
            label5.TabIndex = 30;
            label5.Text = "Fecha de Nacimiento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 235);
            label4.Name = "label4";
            label4.Size = new Size(129, 20);
            label4.TabIndex = 29;
            label4.Text = "Apellido Materno:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 181);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 28;
            label3.Text = "Apellido Paterno:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(133, 133);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 27;
            label2.Text = "Nombre:";
            // 
            // txbSueldo
            // 
            txbSueldo.Location = new Point(213, 347);
            txbSueldo.Name = "txbSueldo";
            txbSueldo.Size = new Size(273, 27);
            txbSueldo.TabIndex = 26;
            // 
            // txbApellidoP
            // 
            txbApellidoP.Location = new Point(213, 178);
            txbApellidoP.Name = "txbApellidoP";
            txbApellidoP.Size = new Size(273, 27);
            txbApellidoP.TabIndex = 25;
            // 
            // txbApellidoM
            // 
            txbApellidoM.Location = new Point(213, 232);
            txbApellidoM.Name = "txbApellidoM";
            txbApellidoM.Size = new Size(273, 27);
            txbApellidoM.TabIndex = 24;
            // 
            // txbNombre
            // 
            txbNombre.Location = new Point(213, 130);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(273, 27);
            txbNombre.TabIndex = 23;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(118, 452);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(245, 39);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(507, 452);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(245, 39);
            btnEditar.TabIndex = 21;
            btnEditar.Text = "Editar Empleado";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTitulo.Location = new Point(281, 23);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(255, 38);
            lbTitulo.TabIndex = 20;
            lbTitulo.Text = "EDITAR EMPLEADO";
            // 
            // EditarBorrarEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 514);
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
            Controls.Add(btnEditar);
            Controls.Add(lbTitulo);
            Name = "EditarBorrarEmpleado";
            Text = "EditarEmpleado";
            Load += EditarEmpleado_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dTPFechaNacimiento;
        private ComboBox cbArea;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txbSueldo;
        private TextBox txbApellidoP;
        private TextBox txbApellidoM;
        private TextBox txbNombre;
        private Button btnCancelar;
        private Button btnEditar;
        private Label lbTitulo;
    }
}