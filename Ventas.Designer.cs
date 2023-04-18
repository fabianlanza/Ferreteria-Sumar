namespace Comercial_y_Ferreteria_Sumar
{
    partial class Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            this.btneliminarVT = new System.Windows.Forms.Button();
            this.btnagregarVT = new System.Windows.Forms.Button();
            this.dgvventasVT = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Linea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.txtpreciounitarioVT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbtipodepagoVT = new System.Windows.Forms.GroupBox();
            this.cmbtipopago = new System.Windows.Forms.ComboBox();
            this.txtsubtotalVT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbltotalapagarVT = new System.Windows.Forms.Label();
            this.txtimpuestoVT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblcantidadapagarVT = new System.Windows.Forms.Label();
            this.btnmenuVT = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpfechanaVT = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.gbfleteVT = new System.Windows.Forms.GroupBox();
            this.cbnoVT = new System.Windows.Forms.RadioButton();
            this.rbsiVT = new System.Windows.Forms.RadioButton();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnvenderVT = new System.Windows.Forms.Button();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txtempleado = new System.Windows.Forms.TextBox();
            this.TxtIdProducto = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addproducto = new System.Windows.Forms.Button();
            this.TxtExistencia = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtidcliente = new System.Windows.Forms.TextBox();
            this.txtidempleado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtcodventa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvventasVT)).BeginInit();
            this.gbtipodepagoVT.SuspendLayout();
            this.gbfleteVT.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btneliminarVT
            // 
            this.btneliminarVT.Location = new System.Drawing.Point(734, 400);
            this.btneliminarVT.Name = "btneliminarVT";
            this.btneliminarVT.Size = new System.Drawing.Size(104, 39);
            this.btneliminarVT.TabIndex = 31;
            this.btneliminarVT.Text = "Eliminar";
            this.btneliminarVT.UseVisualStyleBackColor = true;
            this.btneliminarVT.Click += new System.EventHandler(this.btneliminarVT_Click);
            // 
            // btnagregarVT
            // 
            this.btnagregarVT.Location = new System.Drawing.Point(734, 356);
            this.btnagregarVT.Name = "btnagregarVT";
            this.btnagregarVT.Size = new System.Drawing.Size(104, 39);
            this.btnagregarVT.TabIndex = 29;
            this.btnagregarVT.Text = "Agregar";
            this.btnagregarVT.UseVisualStyleBackColor = true;
            this.btnagregarVT.Click += new System.EventHandler(this.btnagregarVT_Click);
            // 
            // dgvventasVT
            // 
            this.dgvventasVT.AllowUserToAddRows = false;
            this.dgvventasVT.AllowUserToDeleteRows = false;
            this.dgvventasVT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvventasVT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Producto,
            this.Precio,
            this.Cantidad,
            this.Existencia,
            this.Linea});
            this.dgvventasVT.Location = new System.Drawing.Point(54, 361);
            this.dgvventasVT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvventasVT.Name = "dgvventasVT";
            this.dgvventasVT.ReadOnly = true;
            this.dgvventasVT.RowHeadersWidth = 51;
            this.dgvventasVT.RowTemplate.Height = 29;
            this.dgvventasVT.Size = new System.Drawing.Size(653, 179);
            this.dgvventasVT.TabIndex = 28;
            this.dgvventasVT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvventasVT_CellClick);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 32;
            this.label6.Text = "Producto";
            // 
            // txtpreciounitarioVT
            // 
            this.txtpreciounitarioVT.Location = new System.Drawing.Point(438, 21);
            this.txtpreciounitarioVT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpreciounitarioVT.Name = "txtpreciounitarioVT";
            this.txtpreciounitarioVT.Size = new System.Drawing.Size(180, 23);
            this.txtpreciounitarioVT.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 34;
            this.label1.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 36;
            this.label2.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 38;
            this.label3.Text = "Cliente";
            // 
            // gbtipodepagoVT
            // 
            this.gbtipodepagoVT.Controls.Add(this.cmbtipopago);
            this.gbtipodepagoVT.Location = new System.Drawing.Point(149, 136);
            this.gbtipodepagoVT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbtipodepagoVT.Name = "gbtipodepagoVT";
            this.gbtipodepagoVT.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbtipodepagoVT.Size = new System.Drawing.Size(191, 82);
            this.gbtipodepagoVT.TabIndex = 40;
            this.gbtipodepagoVT.TabStop = false;
            this.gbtipodepagoVT.Text = "Tipo de Pago";
            // 
            // cmbtipopago
            // 
            this.cmbtipopago.FormattingEnabled = true;
            this.cmbtipopago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta de Credito",
            "Transferencia"});
            this.cmbtipopago.Location = new System.Drawing.Point(19, 30);
            this.cmbtipopago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbtipopago.Name = "cmbtipopago";
            this.cmbtipopago.Size = new System.Drawing.Size(133, 23);
            this.cmbtipopago.TabIndex = 44;
            this.cmbtipopago.SelectedIndexChanged += new System.EventHandler(this.cmbtipopago_SelectedIndexChanged);
            // 
            // txtsubtotalVT
            // 
            this.txtsubtotalVT.Location = new System.Drawing.Point(116, 324);
            this.txtsubtotalVT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsubtotalVT.Name = "txtsubtotalVT";
            this.txtsubtotalVT.Size = new System.Drawing.Size(119, 23);
            this.txtsubtotalVT.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 41;
            this.label4.Text = "Subtotal";
            // 
            // lbltotalapagarVT
            // 
            this.lbltotalapagarVT.AutoSize = true;
            this.lbltotalapagarVT.Location = new System.Drawing.Point(456, 326);
            this.lbltotalapagarVT.Name = "lbltotalapagarVT";
            this.lbltotalapagarVT.Size = new System.Drawing.Size(80, 15);
            this.lbltotalapagarVT.TabIndex = 45;
            this.lbltotalapagarVT.Text = "Total a Pagar:\r\n";
            // 
            // txtimpuestoVT
            // 
            this.txtimpuestoVT.Location = new System.Drawing.Point(323, 324);
            this.txtimpuestoVT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtimpuestoVT.Name = "txtimpuestoVT";
            this.txtimpuestoVT.Size = new System.Drawing.Size(119, 23);
            this.txtimpuestoVT.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(256, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 46;
            this.label8.Text = "Impuesto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(283, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 28);
            this.label9.TabIndex = 48;
            this.label9.Text = "Venta de Productos";
            // 
            // lblcantidadapagarVT
            // 
            this.lblcantidadapagarVT.AutoSize = true;
            this.lblcantidadapagarVT.Location = new System.Drawing.Point(547, 326);
            this.lblcantidadapagarVT.Name = "lblcantidadapagarVT";
            this.lblcantidadapagarVT.Size = new System.Drawing.Size(38, 15);
            this.lblcantidadapagarVT.TabIndex = 49;
            this.lblcantidadapagarVT.Text = "00.00";
            // 
            // btnmenuVT
            // 
            this.btnmenuVT.Image = ((System.Drawing.Image)(resources.GetObject("btnmenuVT.Image")));
            this.btnmenuVT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmenuVT.Location = new System.Drawing.Point(734, 14);
            this.btnmenuVT.Name = "btnmenuVT";
            this.btnmenuVT.Size = new System.Drawing.Size(104, 39);
            this.btnmenuVT.TabIndex = 77;
            this.btnmenuVT.Text = "Menu";
            this.btnmenuVT.UseVisualStyleBackColor = true;
            this.btnmenuVT.Click += new System.EventHandler(this.btnmenuVT_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 79;
            this.label5.Text = "Empleado";
            // 
            // dtpfechanaVT
            // 
            this.dtpfechanaVT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechanaVT.Location = new System.Drawing.Point(469, 51);
            this.dtpfechanaVT.Name = "dtpfechanaVT";
            this.dtpfechanaVT.Size = new System.Drawing.Size(253, 23);
            this.dtpfechanaVT.TabIndex = 83;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(423, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 82;
            this.label7.Text = "Fecha";
            // 
            // gbfleteVT
            // 
            this.gbfleteVT.Controls.Add(this.cbnoVT);
            this.gbfleteVT.Controls.Add(this.rbsiVT);
            this.gbfleteVT.Controls.Add(this.txtKm);
            this.gbfleteVT.Controls.Add(this.label10);
            this.gbfleteVT.Location = new System.Drawing.Point(456, 128);
            this.gbfleteVT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbfleteVT.Name = "gbfleteVT";
            this.gbfleteVT.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbfleteVT.Size = new System.Drawing.Size(228, 82);
            this.gbfleteVT.TabIndex = 44;
            this.gbfleteVT.TabStop = false;
            this.gbfleteVT.Text = "Felete";
            // 
            // cbnoVT
            // 
            this.cbnoVT.AutoSize = true;
            this.cbnoVT.Location = new System.Drawing.Point(122, 20);
            this.cbnoVT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbnoVT.Name = "cbnoVT";
            this.cbnoVT.Size = new System.Drawing.Size(41, 19);
            this.cbnoVT.TabIndex = 42;
            this.cbnoVT.TabStop = true;
            this.cbnoVT.Text = "No";
            this.cbnoVT.UseVisualStyleBackColor = true;
            this.cbnoVT.CheckedChanged += new System.EventHandler(this.cbnoVT_CheckedChanged);
            // 
            // rbsiVT
            // 
            this.rbsiVT.AutoSize = true;
            this.rbsiVT.Location = new System.Drawing.Point(36, 20);
            this.rbsiVT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbsiVT.Name = "rbsiVT";
            this.rbsiVT.Size = new System.Drawing.Size(35, 19);
            this.rbsiVT.TabIndex = 41;
            this.rbsiVT.TabStop = true;
            this.rbsiVT.Text = "Si";
            this.rbsiVT.UseVisualStyleBackColor = true;
            this.rbsiVT.CheckedChanged += new System.EventHandler(this.rbsiVT_CheckedChanged);
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(122, 47);
            this.txtKm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(92, 23);
            this.txtKm.TabIndex = 85;
            this.txtKm.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 15);
            this.label10.TabIndex = 84;
            this.label10.Text = "Cantidad de KM :";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // btnvenderVT
            // 
            this.btnvenderVT.Location = new System.Drawing.Point(734, 501);
            this.btnvenderVT.Name = "btnvenderVT";
            this.btnvenderVT.Size = new System.Drawing.Size(104, 39);
            this.btnvenderVT.TabIndex = 86;
            this.btnvenderVT.Text = "Vender";
            this.btnvenderVT.UseVisualStyleBackColor = true;
            this.btnvenderVT.Click += new System.EventHandler(this.btnvenderVT_Click);
            // 
            // txtproducto
            // 
            this.txtproducto.Location = new System.Drawing.Point(82, 18);
            this.txtproducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(180, 23);
            this.txtproducto.TabIndex = 87;
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(138, 52);
            this.txtcliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(180, 23);
            this.txtcliente.TabIndex = 89;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(82, 58);
            this.txtcantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(180, 23);
            this.txtcantidad.TabIndex = 90;
            // 
            // txtempleado
            // 
            this.txtempleado.Location = new System.Drawing.Point(138, 87);
            this.txtempleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtempleado.Name = "txtempleado";
            this.txtempleado.Size = new System.Drawing.Size(180, 23);
            this.txtempleado.TabIndex = 91;
            // 
            // TxtIdProducto
            // 
            this.TxtIdProducto.Location = new System.Drawing.Point(230, 17);
            this.TxtIdProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtIdProducto.Name = "TxtIdProducto";
            this.TxtIdProducto.Size = new System.Drawing.Size(37, 23);
            this.TxtIdProducto.TabIndex = 92;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addproducto);
            this.groupBox1.Controls.Add(this.TxtExistencia);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtcantidad);
            this.groupBox1.Controls.Add(this.TxtIdProducto);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtpreciounitarioVT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtproducto);
            this.groupBox1.Location = new System.Drawing.Point(66, 224);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(634, 94);
            this.groupBox1.TabIndex = 93;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // addproducto
            // 
            this.addproducto.Location = new System.Drawing.Point(272, 17);
            this.addproducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addproducto.Name = "addproducto";
            this.addproducto.Size = new System.Drawing.Size(60, 22);
            this.addproducto.TabIndex = 94;
            this.addproducto.Text = "...";
            this.addproducto.UseVisualStyleBackColor = true;
            this.addproducto.Click += new System.EventHandler(this.addproducto_Click);
            // 
            // TxtExistencia
            // 
            this.TxtExistencia.Location = new System.Drawing.Point(438, 58);
            this.TxtExistencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtExistencia.Name = "TxtExistencia";
            this.TxtExistencia.Size = new System.Drawing.Size(176, 23);
            this.TxtExistencia.TabIndex = 94;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(368, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 15);
            this.label11.TabIndex = 93;
            this.label11.Text = "Existencia";
            // 
            // txtidcliente
            // 
            this.txtidcliente.Location = new System.Drawing.Point(138, 52);
            this.txtidcliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtidcliente.Name = "txtidcliente";
            this.txtidcliente.Size = new System.Drawing.Size(43, 23);
            this.txtidcliente.TabIndex = 94;
            this.txtidcliente.Visible = false;
            // 
            // txtidempleado
            // 
            this.txtidempleado.Location = new System.Drawing.Point(138, 87);
            this.txtidempleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtidempleado.Name = "txtidempleado";
            this.txtidempleado.Size = new System.Drawing.Size(43, 23);
            this.txtidempleado.TabIndex = 95;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 51);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 22);
            this.button1.TabIndex = 95;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(323, 84);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 22);
            this.button2.TabIndex = 96;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtcodventa
            // 
            this.txtcodventa.Location = new System.Drawing.Point(83, 9);
            this.txtcodventa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcodventa.Name = "txtcodventa";
            this.txtcodventa.Size = new System.Drawing.Size(43, 23);
            this.txtcodventa.TabIndex = 97;
            this.txtcodventa.Visible = false;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(877, 578);
            this.Controls.Add(this.txtcodventa);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtidempleado);
            this.Controls.Add(this.txtidcliente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtempleado);
            this.Controls.Add(this.txtcliente);
            this.Controls.Add(this.btnvenderVT);
            this.Controls.Add(this.gbfleteVT);
            this.Controls.Add(this.dtpfechanaVT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnmenuVT);
            this.Controls.Add(this.lblcantidadapagarVT);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtimpuestoVT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbltotalapagarVT);
            this.Controls.Add(this.txtsubtotalVT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gbtipodepagoVT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btneliminarVT);
            this.Controls.Add(this.btnagregarVT);
            this.Controls.Add(this.dgvventasVT);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvventasVT)).EndInit();
            this.gbtipodepagoVT.ResumeLayout(false);
            this.gbfleteVT.ResumeLayout(false);
            this.gbfleteVT.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btneliminarVT;
        private Button btnagregarVT;
        private DataGridView dgvventasVT;
        private Label label6;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox gbtipodepagoVT;
        private TextBox txtsubtotalVT;
        private Label label4;
        private Label lbltotalapagarVT;
        private TextBox txtimpuestoVT;
        private Label label8;
        private Label label9;
        private Label lblcantidadapagarVT;
        private Button btnmenuVT;
        private Label label5;
        private DateTimePicker dtpfechanaVT;
        private Label label7;
        private GroupBox gbfleteVT;
        private RadioButton cbnoVT;
        private RadioButton rbsiVT;
        private TextBox txtKm;
        private Label label10;
        private Button btnvenderVT;
        private TextBox txtcantidad;
        private GroupBox groupBox1;
        private Button addproducto;
        private Label label11;
        private Button button1;
        private Button button2;
        public TextBox TxtIdProducto;
        public TextBox txtpreciounitarioVT;
        public TextBox txtproducto;
        public TextBox txtcliente;
        public TextBox txtempleado;
        public TextBox TxtExistencia;
        public TextBox txtidcliente;
        public TextBox txtidempleado;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Existencia;
        private DataGridViewTextBoxColumn Linea;
        public TextBox txtcodventa;
        private ComboBox cmbtipopago;
    }
}