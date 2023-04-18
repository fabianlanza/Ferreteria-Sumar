namespace Comercial_y_Ferreteria_Sumar
{
    partial class Empleados
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleados));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombresEMP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvempleadosEMP = new System.Windows.Forms.DataGridView();
            this.txtapellidosEMP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpfechanacimientoEMP = new System.Windows.Forms.DateTimePicker();
            this.cbpuestosEMP = new System.Windows.Forms.ComboBox();
            this.cbsucursalEMP = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txttelefonoEMP = new System.Windows.Forms.TextBox();
            this.txtidentidadEMP = new System.Windows.Forms.TextBox();
            this.btnagregarEMP = new System.Windows.Forms.Button();
            this.btnActualizarEMP = new System.Windows.Forms.Button();
            this.btneliminarEMP = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcorreoEMP = new System.Windows.Forms.TextBox();
            this.cbjornadaEMP = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcontraEMP = new System.Windows.Forms.TextBox();
            this.txtusuarioEMP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtdireccionEMP = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtsalarioEMP = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnmenuEMP = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.epEMP = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvempleadosEMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEMP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(71, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(69, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos";
            // 
            // txtnombresEMP
            // 
            this.txtnombresEMP.Location = new System.Drawing.Point(137, 64);
            this.txtnombresEMP.Name = "txtnombresEMP";
            this.txtnombresEMP.Size = new System.Drawing.Size(212, 23);
            this.txtnombresEMP.TabIndex = 2;
            this.txtnombresEMP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombresEMP_KeyPress);
            this.txtnombresEMP.Validating += new System.ComponentModel.CancelEventHandler(this.txtnombresEMP_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(20, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha Nacimiento";
            // 
            // dgvempleadosEMP
            // 
            this.dgvempleadosEMP.AllowUserToAddRows = false;
            this.dgvempleadosEMP.AllowUserToDeleteRows = false;
            this.dgvempleadosEMP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvempleadosEMP.Location = new System.Drawing.Point(49, 410);
            this.dgvempleadosEMP.Name = "dgvempleadosEMP";
            this.dgvempleadosEMP.ReadOnly = true;
            this.dgvempleadosEMP.RowHeadersWidth = 51;
            this.dgvempleadosEMP.RowTemplate.Height = 25;
            this.dgvempleadosEMP.Size = new System.Drawing.Size(877, 157);
            this.dgvempleadosEMP.TabIndex = 4;
            this.dgvempleadosEMP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvempleadosEMP_CellClick);
            this.dgvempleadosEMP.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvempleadosEMP_CellDoubleClick);
            // 
            // txtapellidosEMP
            // 
            this.txtapellidosEMP.Location = new System.Drawing.Point(137, 120);
            this.txtapellidosEMP.Name = "txtapellidosEMP";
            this.txtapellidosEMP.Size = new System.Drawing.Size(212, 23);
            this.txtapellidosEMP.TabIndex = 5;
            this.txtapellidosEMP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapellidosEMP_KeyPress);
            this.txtapellidosEMP.Validating += new System.ComponentModel.CancelEventHandler(this.txtapellidosEMP_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(408, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Puesto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(408, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sucursal";
            // 
            // dtpfechanacimientoEMP
            // 
            this.dtpfechanacimientoEMP.Location = new System.Drawing.Point(137, 217);
            this.dtpfechanacimientoEMP.Name = "dtpfechanacimientoEMP";
            this.dtpfechanacimientoEMP.Size = new System.Drawing.Size(212, 23);
            this.dtpfechanacimientoEMP.TabIndex = 11;
            // 
            // cbpuestosEMP
            // 
            this.cbpuestosEMP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbpuestosEMP.FormattingEnabled = true;
            this.cbpuestosEMP.Location = new System.Drawing.Point(483, 64);
            this.cbpuestosEMP.Name = "cbpuestosEMP";
            this.cbpuestosEMP.Size = new System.Drawing.Size(181, 23);
            this.cbpuestosEMP.TabIndex = 12;
            // 
            // cbsucursalEMP
            // 
            this.cbsucursalEMP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbsucursalEMP.FormattingEnabled = true;
            this.cbsucursalEMP.Location = new System.Drawing.Point(483, 120);
            this.cbsucursalEMP.Name = "cbsucursalEMP";
            this.cbsucursalEMP.Size = new System.Drawing.Size(181, 23);
            this.cbsucursalEMP.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(68, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Identidad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(62, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Teléfono";
            // 
            // txttelefonoEMP
            // 
            this.txttelefonoEMP.Location = new System.Drawing.Point(137, 262);
            this.txttelefonoEMP.Name = "txttelefonoEMP";
            this.txttelefonoEMP.Size = new System.Drawing.Size(212, 23);
            this.txttelefonoEMP.TabIndex = 18;
            this.txttelefonoEMP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttelefonoEMP_KeyPress);
            this.txttelefonoEMP.Validating += new System.ComponentModel.CancelEventHandler(this.txttelefonoEMP_Validating);
            // 
            // txtidentidadEMP
            // 
            this.txtidentidadEMP.Location = new System.Drawing.Point(137, 167);
            this.txtidentidadEMP.Name = "txtidentidadEMP";
            this.txtidentidadEMP.Size = new System.Drawing.Size(212, 23);
            this.txtidentidadEMP.TabIndex = 19;
            this.txtidentidadEMP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtidentidadEMP_KeyPress);
            this.txtidentidadEMP.Validating += new System.ComponentModel.CancelEventHandler(this.txtidentidadEMP_Validating);
            // 
            // btnagregarEMP
            // 
            this.btnagregarEMP.Location = new System.Drawing.Point(954, 410);
            this.btnagregarEMP.Name = "btnagregarEMP";
            this.btnagregarEMP.Size = new System.Drawing.Size(104, 39);
            this.btnagregarEMP.TabIndex = 22;
            this.btnagregarEMP.Text = "Agregar";
            this.btnagregarEMP.UseVisualStyleBackColor = true;
            this.btnagregarEMP.Click += new System.EventHandler(this.btnagregarEMP_Click);
            // 
            // btnActualizarEMP
            // 
            this.btnActualizarEMP.Location = new System.Drawing.Point(954, 469);
            this.btnActualizarEMP.Name = "btnActualizarEMP";
            this.btnActualizarEMP.Size = new System.Drawing.Size(104, 39);
            this.btnActualizarEMP.TabIndex = 23;
            this.btnActualizarEMP.Text = "Actualizar";
            this.btnActualizarEMP.UseVisualStyleBackColor = true;
            this.btnActualizarEMP.Click += new System.EventHandler(this.btnActualizarEMP_Click);
            // 
            // btneliminarEMP
            // 
            this.btneliminarEMP.Location = new System.Drawing.Point(954, 527);
            this.btneliminarEMP.Name = "btneliminarEMP";
            this.btneliminarEMP.Size = new System.Drawing.Size(104, 39);
            this.btneliminarEMP.TabIndex = 24;
            this.btneliminarEMP.Text = "Eliminar";
            this.btneliminarEMP.UseVisualStyleBackColor = true;
            this.btneliminarEMP.Click += new System.EventHandler(this.btneliminarEMP_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(244, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(344, 32);
            this.label10.TabIndex = 25;
            this.label10.Text = "Adminitración de Empleados";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(408, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Correo";
            // 
            // txtcorreoEMP
            // 
            this.txtcorreoEMP.Location = new System.Drawing.Point(483, 220);
            this.txtcorreoEMP.Name = "txtcorreoEMP";
            this.txtcorreoEMP.Size = new System.Drawing.Size(181, 23);
            this.txtcorreoEMP.TabIndex = 17;
            this.txtcorreoEMP.Validating += new System.ComponentModel.CancelEventHandler(this.txtcorreoEMP_Validating);
            // 
            // cbjornadaEMP
            // 
            this.cbjornadaEMP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbjornadaEMP.FormattingEnabled = true;
            this.cbjornadaEMP.Location = new System.Drawing.Point(483, 167);
            this.cbjornadaEMP.Name = "cbjornadaEMP";
            this.cbjornadaEMP.Size = new System.Drawing.Size(181, 23);
            this.cbjornadaEMP.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(408, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 15);
            this.label9.TabIndex = 26;
            this.label9.Text = "Jornada";
            // 
            // txtcontraEMP
            // 
            this.txtcontraEMP.Location = new System.Drawing.Point(842, 268);
            this.txtcontraEMP.Name = "txtcontraEMP";
            this.txtcontraEMP.Size = new System.Drawing.Size(156, 23);
            this.txtcontraEMP.TabIndex = 32;
            // 
            // txtusuarioEMP
            // 
            this.txtusuarioEMP.Location = new System.Drawing.Point(842, 215);
            this.txtusuarioEMP.Name = "txtusuarioEMP";
            this.txtusuarioEMP.Size = new System.Drawing.Size(156, 23);
            this.txtusuarioEMP.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(785, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 15);
            this.label12.TabIndex = 29;
            this.label12.Text = "Usuario";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(764, 271);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 15);
            this.label11.TabIndex = 30;
            this.label11.Text = "Contraseña";
            // 
            // txtdireccionEMP
            // 
            this.txtdireccionEMP.Location = new System.Drawing.Point(483, 266);
            this.txtdireccionEMP.Name = "txtdireccionEMP";
            this.txtdireccionEMP.Size = new System.Drawing.Size(212, 23);
            this.txtdireccionEMP.TabIndex = 30;
            this.txtdireccionEMP.Validating += new System.ComponentModel.CancelEventHandler(this.txtdireccionEMP_Validating);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(408, 268);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 15);
            this.label13.TabIndex = 29;
            this.label13.Text = "Direccion";
            // 
            // txtsalarioEMP
            // 
            this.txtsalarioEMP.Location = new System.Drawing.Point(137, 308);
            this.txtsalarioEMP.Name = "txtsalarioEMP";
            this.txtsalarioEMP.Size = new System.Drawing.Size(212, 23);
            this.txtsalarioEMP.TabIndex = 32;
            this.txtsalarioEMP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsalarioEMP_KeyPress);
            this.txtsalarioEMP.Validating += new System.ComponentModel.CancelEventHandler(this.txtsalarioEMP_Validating);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(62, 311);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 15);
            this.label14.TabIndex = 31;
            this.label14.Text = "Salario";
            // 
            // btnmenuEMP
            // 
            this.btnmenuEMP.Image = ((System.Drawing.Image)(resources.GetObject("btnmenuEMP.Image")));
            this.btnmenuEMP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmenuEMP.Location = new System.Drawing.Point(924, 11);
            this.btnmenuEMP.Name = "btnmenuEMP";
            this.btnmenuEMP.Size = new System.Drawing.Size(104, 39);
            this.btnmenuEMP.TabIndex = 68;
            this.btnmenuEMP.Text = "Menu";
            this.btnmenuEMP.UseVisualStyleBackColor = true;
            this.btnmenuEMP.Click += new System.EventHandler(this.btnmenuEMP_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(310, 370);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(88, 26);
            this.btnbuscar.TabIndex = 78;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(53, 376);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 15);
            this.label15.TabIndex = 77;
            this.label15.Text = "Buscar :";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(104, 374);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(201, 23);
            this.txtbuscar.TabIndex = 76;
            // 
            // epEMP
            // 
            this.epEMP.ContainerControl = this;
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1072, 586);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.btnmenuEMP);
            this.Controls.Add(this.txtcontraEMP);
            this.Controls.Add(this.txtusuarioEMP);
            this.Controls.Add(this.txtsalarioEMP);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtdireccionEMP);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbjornadaEMP);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btneliminarEMP);
            this.Controls.Add(this.btnActualizarEMP);
            this.Controls.Add(this.btnagregarEMP);
            this.Controls.Add(this.txtidentidadEMP);
            this.Controls.Add(this.txttelefonoEMP);
            this.Controls.Add(this.txtcorreoEMP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbsucursalEMP);
            this.Controls.Add(this.cbpuestosEMP);
            this.Controls.Add(this.dtpfechanacimientoEMP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtapellidosEMP);
            this.Controls.Add(this.dgvempleadosEMP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnombresEMP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Empleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.Empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvempleadosEMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtnombresEMP;
        private Label label3;
        private DataGridView dgvempleadosEMP;
        private TextBox txtapellidosEMP;
        private Label label5;
        private Label label6;
        private DateTimePicker dtpfechanacimientoEMP;
        private ComboBox cbpuestosEMP;
        private ComboBox cbsucursalEMP;
        private Label label4;
        private Label label8;
        private TextBox txttelefonoEMP;
        private TextBox txtidentidadEMP;
        private Button btnagregarEMP;
        private Button btnActualizarEMP;
        private Button btneliminarEMP;
        private Label label10;
        private Label label7;
        private TextBox txtcorreoEMP;
        private ComboBox cbjornadaEMP;
        private Label label9;
        private TextBox txtcontraEMP;
        private TextBox txtusuarioEMP;
        private Label label12;
        private Label label11;
        private TextBox txtdireccionEMP;
        private Label label13;
        private TextBox txtsalarioEMP;
        private Label label14;
        private Button btnmenuEMP;
        private Button btnbuscar;
        private Label label15;
        private TextBox txtbuscar;
        private ErrorProvider epEMP;
    }
}