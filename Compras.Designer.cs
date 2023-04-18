namespace Comercial_y_Ferreteria_Sumar
{
    partial class Compras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compras));
            this.dtpfechaCOM = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btneliminarCOM = new System.Windows.Forms.Button();
            this.btnagregarCOM = new System.Windows.Forms.Button();
            this.dgvcomprasCOM = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Linea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnmenuCOM = new System.Windows.Forms.Button();
            this.txtpreciocostoCOM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcantidadCOM = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnComprar = new System.Windows.Forms.Button();
            this.lblcantidadapagarVT = new System.Windows.Forms.Label();
            this.txtimpuestoVT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbltotalapagarVT = new System.Windows.Forms.Label();
            this.txtsubtotalVT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.epCOM = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addproveedor = new System.Windows.Forms.Button();
            this.addproducto = new System.Windows.Forms.Button();
            this.addempleado = new System.Windows.Forms.Button();
            this.txtidproveedor = new System.Windows.Forms.TextBox();
            this.txtidproducto = new System.Windows.Forms.TextBox();
            this.txtidempleado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.txtproveedor = new System.Windows.Forms.TextBox();
            this.txtempleado = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCodCompra = new System.Windows.Forms.TextBox();
            this.txtexistencia = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcomprasCOM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCOM)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpfechaCOM
            // 
            this.dtpfechaCOM.CustomFormat = "YYYY-MM-DD";
            this.dtpfechaCOM.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechaCOM.Location = new System.Drawing.Point(407, 75);
            this.dtpfechaCOM.Name = "dtpfechaCOM";
            this.dtpfechaCOM.Size = new System.Drawing.Size(183, 23);
            this.dtpfechaCOM.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Fecha";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(205, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(321, 32);
            this.label10.TabIndex = 52;
            this.label10.Text = "Adminitración de Compras";
            // 
            // btneliminarCOM
            // 
            this.btneliminarCOM.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btneliminarCOM.Location = new System.Drawing.Point(704, 377);
            this.btneliminarCOM.Name = "btneliminarCOM";
            this.btneliminarCOM.Size = new System.Drawing.Size(104, 39);
            this.btneliminarCOM.TabIndex = 56;
            this.btneliminarCOM.Text = "Eliminar";
            this.btneliminarCOM.UseVisualStyleBackColor = true;
            this.btneliminarCOM.Click += new System.EventHandler(this.btneliminarCOM_Click);
            // 
            // btnagregarCOM
            // 
            this.btnagregarCOM.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnagregarCOM.Location = new System.Drawing.Point(704, 322);
            this.btnagregarCOM.Name = "btnagregarCOM";
            this.btnagregarCOM.Size = new System.Drawing.Size(104, 39);
            this.btnagregarCOM.TabIndex = 54;
            this.btnagregarCOM.Text = "Agregar";
            this.btnagregarCOM.UseVisualStyleBackColor = true;
            this.btnagregarCOM.Click += new System.EventHandler(this.btnagregarCOM_Click);
            // 
            // dgvcomprasCOM
            // 
            this.dgvcomprasCOM.AllowUserToAddRows = false;
            this.dgvcomprasCOM.AllowUserToDeleteRows = false;
            this.dgvcomprasCOM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcomprasCOM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Producto,
            this.Precio,
            this.Cantidad,
            this.Existencia,
            this.Linea});
            this.dgvcomprasCOM.Location = new System.Drawing.Point(53, 322);
            this.dgvcomprasCOM.Name = "dgvcomprasCOM";
            this.dgvcomprasCOM.ReadOnly = true;
            this.dgvcomprasCOM.RowHeadersWidth = 51;
            this.dgvcomprasCOM.RowTemplate.Height = 25;
            this.dgvcomprasCOM.Size = new System.Drawing.Size(631, 157);
            this.dgvcomprasCOM.TabIndex = 53;
            this.dgvcomprasCOM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcomprasCOM_CellClick);
            this.dgvcomprasCOM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcomprasCOM_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 125;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 125;
            // 
            // Existencia
            // 
            this.Existencia.HeaderText = "Existencia";
            this.Existencia.MinimumWidth = 6;
            this.Existencia.Name = "Existencia";
            this.Existencia.ReadOnly = true;
            this.Existencia.Visible = false;
            this.Existencia.Width = 125;
            // 
            // Linea
            // 
            this.Linea.HeaderText = "Linea";
            this.Linea.MinimumWidth = 6;
            this.Linea.Name = "Linea";
            this.Linea.ReadOnly = true;
            this.Linea.Width = 125;
            // 
            // btnmenuCOM
            // 
            this.btnmenuCOM.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnmenuCOM.Image = ((System.Drawing.Image)(resources.GetObject("btnmenuCOM.Image")));
            this.btnmenuCOM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmenuCOM.Location = new System.Drawing.Point(704, 16);
            this.btnmenuCOM.Name = "btnmenuCOM";
            this.btnmenuCOM.Size = new System.Drawing.Size(104, 39);
            this.btnmenuCOM.TabIndex = 77;
            this.btnmenuCOM.Text = "Menu";
            this.btnmenuCOM.UseVisualStyleBackColor = true;
            this.btnmenuCOM.Click += new System.EventHandler(this.btnmenuCOM_Click);
            // 
            // txtpreciocostoCOM
            // 
            this.txtpreciocostoCOM.Location = new System.Drawing.Point(163, 226);
            this.txtpreciocostoCOM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpreciocostoCOM.Name = "txtpreciocostoCOM";
            this.txtpreciocostoCOM.Size = new System.Drawing.Size(183, 23);
            this.txtpreciocostoCOM.TabIndex = 82;
            this.txtpreciocostoCOM.TextChanged += new System.EventHandler(this.txtpreciocostoCOM_TextChanged);
            this.txtpreciocostoCOM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpreciocostoCOM_KeyPress);
            this.txtpreciocostoCOM.Validating += new System.ComponentModel.CancelEventHandler(this.txtpreciocostoCOM_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(77, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 81;
            this.label4.Text = "Precio Costo";
            // 
            // txtcantidadCOM
            // 
            this.txtcantidadCOM.Location = new System.Drawing.Point(460, 224);
            this.txtcantidadCOM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcantidadCOM.Name = "txtcantidadCOM";
            this.txtcantidadCOM.Size = new System.Drawing.Size(183, 23);
            this.txtcantidadCOM.TabIndex = 84;
            this.txtcantidadCOM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidadCOM_KeyPress);
            this.txtcantidadCOM.Validating += new System.ComponentModel.CancelEventHandler(this.txtcantidadCOM_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(395, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 83;
            this.label5.Text = "Cantidad";
            // 
            // btnComprar
            // 
            this.btnComprar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnComprar.Location = new System.Drawing.Point(704, 431);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(104, 39);
            this.btnComprar.TabIndex = 85;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // lblcantidadapagarVT
            // 
            this.lblcantidadapagarVT.AutoSize = true;
            this.lblcantidadapagarVT.Location = new System.Drawing.Point(549, 287);
            this.lblcantidadapagarVT.Name = "lblcantidadapagarVT";
            this.lblcantidadapagarVT.Size = new System.Drawing.Size(34, 15);
            this.lblcantidadapagarVT.TabIndex = 91;
            this.lblcantidadapagarVT.Text = "00.00";
            // 
            // txtimpuestoVT
            // 
            this.txtimpuestoVT.Location = new System.Drawing.Point(325, 285);
            this.txtimpuestoVT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtimpuestoVT.Name = "txtimpuestoVT";
            this.txtimpuestoVT.Size = new System.Drawing.Size(119, 23);
            this.txtimpuestoVT.TabIndex = 90;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(257, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 89;
            this.label8.Text = "Impuesto";
            // 
            // lbltotalapagarVT
            // 
            this.lbltotalapagarVT.AutoSize = true;
            this.lbltotalapagarVT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbltotalapagarVT.Location = new System.Drawing.Point(458, 287);
            this.lbltotalapagarVT.Name = "lbltotalapagarVT";
            this.lbltotalapagarVT.Size = new System.Drawing.Size(80, 15);
            this.lbltotalapagarVT.TabIndex = 88;
            this.lbltotalapagarVT.Text = "Total a Pagar:\r\n";
            // 
            // txtsubtotalVT
            // 
            this.txtsubtotalVT.Location = new System.Drawing.Point(118, 285);
            this.txtsubtotalVT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsubtotalVT.Name = "txtsubtotalVT";
            this.txtsubtotalVT.Size = new System.Drawing.Size(119, 23);
            this.txtsubtotalVT.TabIndex = 87;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(56, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 15);
            this.label7.TabIndex = 86;
            this.label7.Text = "Subtotal";
            // 
            // epCOM
            // 
            this.epCOM.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addproveedor);
            this.groupBox1.Controls.Add(this.addproducto);
            this.groupBox1.Controls.Add(this.addempleado);
            this.groupBox1.Controls.Add(this.txtidproveedor);
            this.groupBox1.Controls.Add(this.txtidproducto);
            this.groupBox1.Controls.Add(this.txtidempleado);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtproducto);
            this.groupBox1.Controls.Add(this.txtproveedor);
            this.groupBox1.Controls.Add(this.txtempleado);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.dtpfechaCOM);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(53, 76);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(656, 124);
            this.groupBox1.TabIndex = 92;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // addproveedor
            // 
            this.addproveedor.Location = new System.Drawing.Point(595, 34);
            this.addproveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addproveedor.Name = "addproveedor";
            this.addproveedor.Size = new System.Drawing.Size(50, 22);
            this.addproveedor.TabIndex = 102;
            this.addproveedor.Text = "...";
            this.addproveedor.UseVisualStyleBackColor = true;
            this.addproveedor.Click += new System.EventHandler(this.addproveedor_Click);
            // 
            // addproducto
            // 
            this.addproducto.Location = new System.Drawing.Point(271, 74);
            this.addproducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addproducto.Name = "addproducto";
            this.addproducto.Size = new System.Drawing.Size(50, 22);
            this.addproducto.TabIndex = 101;
            this.addproducto.Text = "...";
            this.addproducto.UseVisualStyleBackColor = true;
            this.addproducto.Click += new System.EventHandler(this.addproducto_Click);
            // 
            // addempleado
            // 
            this.addempleado.Location = new System.Drawing.Point(271, 33);
            this.addempleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addempleado.Name = "addempleado";
            this.addempleado.Size = new System.Drawing.Size(50, 22);
            this.addempleado.TabIndex = 96;
            this.addempleado.Text = "...";
            this.addempleado.UseVisualStyleBackColor = true;
            this.addempleado.Click += new System.EventHandler(this.addempleado_Click);
            // 
            // txtidproveedor
            // 
            this.txtidproveedor.Location = new System.Drawing.Point(407, 34);
            this.txtidproveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtidproveedor.Name = "txtidproveedor";
            this.txtidproveedor.Size = new System.Drawing.Size(36, 23);
            this.txtidproveedor.TabIndex = 100;
            this.txtidproveedor.Visible = false;
            // 
            // txtidproducto
            // 
            this.txtidproducto.Location = new System.Drawing.Point(83, 75);
            this.txtidproducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtidproducto.Name = "txtidproducto";
            this.txtidproducto.Size = new System.Drawing.Size(36, 23);
            this.txtidproducto.TabIndex = 99;
            this.txtidproducto.Visible = false;
            this.txtidproducto.TextChanged += new System.EventHandler(this.txtidproducto_TextChanged);
            // 
            // txtidempleado
            // 
            this.txtidempleado.Location = new System.Drawing.Point(83, 33);
            this.txtidempleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtidempleado.Name = "txtidempleado";
            this.txtidempleado.Size = new System.Drawing.Size(36, 23);
            this.txtidempleado.TabIndex = 93;
            this.txtidempleado.TextChanged += new System.EventHandler(this.txtidempleado_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 15);
            this.label9.TabIndex = 95;
            this.label9.Text = "Producto";
            // 
            // txtproducto
            // 
            this.txtproducto.Location = new System.Drawing.Point(83, 75);
            this.txtproducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(183, 23);
            this.txtproducto.TabIndex = 98;
            // 
            // txtproveedor
            // 
            this.txtproveedor.Location = new System.Drawing.Point(407, 34);
            this.txtproveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtproveedor.Name = "txtproveedor";
            this.txtproveedor.Size = new System.Drawing.Size(183, 23);
            this.txtproveedor.TabIndex = 97;
            // 
            // txtempleado
            // 
            this.txtempleado.Location = new System.Drawing.Point(83, 33);
            this.txtempleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtempleado.Name = "txtempleado";
            this.txtempleado.Size = new System.Drawing.Size(183, 23);
            this.txtempleado.TabIndex = 96;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(334, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 15);
            this.label11.TabIndex = 94;
            this.label11.Text = "Proveedor";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 15);
            this.label12.TabIndex = 93;
            this.label12.Text = "Empleado";
            // 
            // txtCodCompra
            // 
            this.txtCodCompra.Location = new System.Drawing.Point(76, 25);
            this.txtCodCompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodCompra.Name = "txtCodCompra";
            this.txtCodCompra.Size = new System.Drawing.Size(110, 23);
            this.txtCodCompra.TabIndex = 93;
            this.txtCodCompra.Visible = false;
            // 
            // txtexistencia
            // 
            this.txtexistencia.Location = new System.Drawing.Point(460, 248);
            this.txtexistencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtexistencia.Name = "txtexistencia";
            this.txtexistencia.Size = new System.Drawing.Size(56, 23);
            this.txtexistencia.TabIndex = 94;
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(850, 491);
            this.Controls.Add(this.txtexistencia);
            this.Controls.Add(this.txtCodCompra);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblcantidadapagarVT);
            this.Controls.Add(this.txtimpuestoVT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbltotalapagarVT);
            this.Controls.Add(this.txtsubtotalVT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.txtcantidadCOM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtpreciocostoCOM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnmenuCOM);
            this.Controls.Add(this.btneliminarCOM);
            this.Controls.Add(this.btnagregarCOM);
            this.Controls.Add(this.dgvcomprasCOM);
            this.Controls.Add(this.label10);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Compras";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.Compras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcomprasCOM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCOM)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DateTimePicker dtpfechaCOM;
        private Label label3;
        private Label label10;
        private Button btneliminarCOM;
        private Button btnagregarCOM;
        private DataGridView dgvcomprasCOM;
        private Button btnmenuCOM;
        private Label label4;
        private TextBox txtcantidadCOM;
        private Label label5;
        private Button btnComprar;
        private Label lblcantidadapagarVT;
        private TextBox txtimpuestoVT;
        private Label label8;
        private Label lbltotalapagarVT;
        private TextBox txtsubtotalVT;
        private Label label7;
        private ErrorProvider epCOM;
        private GroupBox groupBox1;
        private Label label9;
        private TextBox txtempleado;
        private Label label11;
        private Label label12;
        public TextBox txtidempleado;
        public TextBox txtidproveedor;
        public TextBox txtidproducto;
        private Button addproveedor;
        private Button addproducto;
        private Button addempleado;
        public TextBox txtproveedor;
        public TextBox txtpreciocostoCOM;
        public TextBox txtproducto;
        private TextBox txtCodCompra;
        private TextBox txtexistencia;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Existencia;
        private DataGridViewTextBoxColumn Linea;
    }
}