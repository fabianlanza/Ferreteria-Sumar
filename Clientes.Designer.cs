namespace Comercial_y_Ferreteria_Sumar
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.btneliminarCL = new System.Windows.Forms.Button();
            this.btnactualizarCL = new System.Windows.Forms.Button();
            this.btnagregarCL = new System.Windows.Forms.Button();
            this.dgvclientesCL = new System.Windows.Forms.DataGridView();
            this.txtapellidosCL = new System.Windows.Forms.TextBox();
            this.txtnombresCL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txttelefonoCL = new System.Windows.Forms.TextBox();
            this.txtcorreoCL = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btnmenuCL = new System.Windows.Forms.Button();
            this.epCL = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvclientesCL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCL)).BeginInit();
            this.SuspendLayout();
            // 
            // btneliminarCL
            // 
            this.btneliminarCL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btneliminarCL.Location = new System.Drawing.Point(711, 340);
            this.btneliminarCL.Name = "btneliminarCL";
            this.btneliminarCL.Size = new System.Drawing.Size(104, 39);
            this.btneliminarCL.TabIndex = 35;
            this.btneliminarCL.Text = "Eliminar";
            this.btneliminarCL.UseVisualStyleBackColor = true;
            this.btneliminarCL.Click += new System.EventHandler(this.btneliminarCL_Click);
            // 
            // btnactualizarCL
            // 
            this.btnactualizarCL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnactualizarCL.Location = new System.Drawing.Point(711, 282);
            this.btnactualizarCL.Name = "btnactualizarCL";
            this.btnactualizarCL.Size = new System.Drawing.Size(104, 39);
            this.btnactualizarCL.TabIndex = 34;
            this.btnactualizarCL.Text = "Actualizar";
            this.btnactualizarCL.UseVisualStyleBackColor = true;
            this.btnactualizarCL.Click += new System.EventHandler(this.btnactualizarCL_Click);
            // 
            // btnagregarCL
            // 
            this.btnagregarCL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnagregarCL.Location = new System.Drawing.Point(711, 223);
            this.btnagregarCL.Name = "btnagregarCL";
            this.btnagregarCL.Size = new System.Drawing.Size(104, 39);
            this.btnagregarCL.TabIndex = 33;
            this.btnagregarCL.Text = "Agregar";
            this.btnagregarCL.UseVisualStyleBackColor = true;
            this.btnagregarCL.Click += new System.EventHandler(this.btnagregarCL_Click);
            // 
            // dgvclientesCL
            // 
            this.dgvclientesCL.AllowUserToAddRows = false;
            this.dgvclientesCL.AllowUserToDeleteRows = false;
            this.dgvclientesCL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvclientesCL.Location = new System.Drawing.Point(32, 228);
            this.dgvclientesCL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvclientesCL.Name = "dgvclientesCL";
            this.dgvclientesCL.ReadOnly = true;
            this.dgvclientesCL.RowHeadersWidth = 51;
            this.dgvclientesCL.RowTemplate.Height = 29;
            this.dgvclientesCL.Size = new System.Drawing.Size(653, 194);
            this.dgvclientesCL.TabIndex = 32;
            this.dgvclientesCL.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvclientesCL_CellClick);
            this.dgvclientesCL.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvclientesCL_CellDoubleClick);
            // 
            // txtapellidosCL
            // 
            this.txtapellidosCL.Location = new System.Drawing.Point(458, 74);
            this.txtapellidosCL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtapellidosCL.Name = "txtapellidosCL";
            this.txtapellidosCL.Size = new System.Drawing.Size(212, 23);
            this.txtapellidosCL.TabIndex = 44;
            this.txtapellidosCL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapellidosCL_KeyPress);
            this.txtapellidosCL.Validating += new System.ComponentModel.CancelEventHandler(this.txtapellidosCL_Validating);
            // 
            // txtnombresCL
            // 
            this.txtnombresCL.Location = new System.Drawing.Point(100, 74);
            this.txtnombresCL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnombresCL.Name = "txtnombresCL";
            this.txtnombresCL.Size = new System.Drawing.Size(212, 23);
            this.txtnombresCL.TabIndex = 42;
            this.txtnombresCL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombresCL_KeyPress);
            this.txtnombresCL.Validating += new System.ComponentModel.CancelEventHandler(this.txtnombresCL_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(33, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 41;
            this.label6.Text = "Nombres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(390, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 38;
            this.label2.Text = "Apellidos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 37;
            // 
            // txttelefonoCL
            // 
            this.txttelefonoCL.Location = new System.Drawing.Point(100, 126);
            this.txttelefonoCL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttelefonoCL.Name = "txttelefonoCL";
            this.txttelefonoCL.Size = new System.Drawing.Size(212, 23);
            this.txttelefonoCL.TabIndex = 49;
            this.txttelefonoCL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttelefonoCL_KeyPress);
            this.txttelefonoCL.Validating += new System.ComponentModel.CancelEventHandler(this.txttelefonoCL_Validating);
            // 
            // txtcorreoCL
            // 
            this.txtcorreoCL.Location = new System.Drawing.Point(458, 126);
            this.txtcorreoCL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcorreoCL.Name = "txtcorreoCL";
            this.txtcorreoCL.Size = new System.Drawing.Size(212, 23);
            this.txtcorreoCL.TabIndex = 48;
            this.txtcorreoCL.Validating += new System.ComponentModel.CancelEventHandler(this.txtcorreoCL_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(406, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 47;
            this.label7.Text = "Correo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(36, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 15);
            this.label8.TabIndex = 46;
            this.label8.Text = "Telefono";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(226, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(266, 28);
            this.label9.TabIndex = 50;
            this.label9.Text = "Administracion de Clientes";
            // 
            // btnbuscar
            // 
            this.btnbuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnbuscar.Location = new System.Drawing.Point(286, 194);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(88, 26);
            this.btnbuscar.TabIndex = 72;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(30, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 71;
            this.label3.Text = "Buscar :";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(80, 196);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(201, 23);
            this.txtbuscar.TabIndex = 70;
            // 
            // btnmenuCL
            // 
            this.btnmenuCL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnmenuCL.Image = ((System.Drawing.Image)(resources.GetObject("btnmenuCL.Image")));
            this.btnmenuCL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmenuCL.Location = new System.Drawing.Point(711, 12);
            this.btnmenuCL.Name = "btnmenuCL";
            this.btnmenuCL.Size = new System.Drawing.Size(104, 39);
            this.btnmenuCL.TabIndex = 77;
            this.btnmenuCL.Text = "Menu";
            this.btnmenuCL.UseVisualStyleBackColor = true;
            this.btnmenuCL.Click += new System.EventHandler(this.btnmenuCL_Click);
            // 
            // epCL
            // 
            this.epCL.ContainerControl = this;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(852, 472);
            this.Controls.Add(this.btnmenuCL);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txttelefonoCL);
            this.Controls.Add(this.txtcorreoCL);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtapellidosCL);
            this.Controls.Add(this.txtnombresCL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btneliminarCL);
            this.Controls.Add(this.btnactualizarCL);
            this.Controls.Add(this.btnagregarCL);
            this.Controls.Add(this.dgvclientesCL);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvclientesCL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btneliminarCL;
        private Button btnactualizarCL;
        private Button btnagregarCL;
        private DataGridView dgvclientesCL;
        private TextBox txtapellidosCL;
        private TextBox txtnombresCL;
        private Label label6;
        private Label label2;
        private Label label1;
        private TextBox txttelefonoCL;
        private TextBox txtcorreoCL;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnbuscar;
        private Label label3;
        private TextBox txtbuscar;
        private Button btnmenuCL;
        private ErrorProvider epCL;
    }
}