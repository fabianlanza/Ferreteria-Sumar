namespace Comercial_y_Ferreteria_Sumar
{
    partial class Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.btneliminarProd = new System.Windows.Forms.Button();
            this.btnactualizarProd = new System.Windows.Forms.Button();
            this.btnagregarPROD = new System.Windows.Forms.Button();
            this.dgvproductosPROD = new System.Windows.Forms.DataGridView();
            this.cbcategoriaPROD = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbproveedorPROD = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtprecioPROD = new System.Windows.Forms.TextBox();
            this.txtExistenciaPROD = new System.Windows.Forms.TextBox();
            this.txtnombrePROD = new System.Windows.Forms.TextBox();
            this.txtdescripcionPROD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btnmenuPROD = new System.Windows.Forms.Button();
            this.epPROD = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductosPROD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPROD)).BeginInit();
            this.SuspendLayout();
            // 
            // btneliminarProd
            // 
            this.btneliminarProd.Location = new System.Drawing.Point(688, 406);
            this.btneliminarProd.Name = "btneliminarProd";
            this.btneliminarProd.Size = new System.Drawing.Size(104, 39);
            this.btneliminarProd.TabIndex = 28;
            this.btneliminarProd.Text = "Eliminar";
            this.btneliminarProd.UseVisualStyleBackColor = true;
            this.btneliminarProd.Click += new System.EventHandler(this.btneliminarProd_Click);
            // 
            // btnactualizarProd
            // 
            this.btnactualizarProd.Location = new System.Drawing.Point(688, 348);
            this.btnactualizarProd.Name = "btnactualizarProd";
            this.btnactualizarProd.Size = new System.Drawing.Size(104, 39);
            this.btnactualizarProd.TabIndex = 27;
            this.btnactualizarProd.Text = "Actualizar";
            this.btnactualizarProd.UseVisualStyleBackColor = true;
            this.btnactualizarProd.Click += new System.EventHandler(this.btnactualizarProd_Click);
            // 
            // btnagregarPROD
            // 
            this.btnagregarPROD.Location = new System.Drawing.Point(688, 289);
            this.btnagregarPROD.Name = "btnagregarPROD";
            this.btnagregarPROD.Size = new System.Drawing.Size(104, 39);
            this.btnagregarPROD.TabIndex = 26;
            this.btnagregarPROD.Text = "Agregar";
            this.btnagregarPROD.UseVisualStyleBackColor = true;
            this.btnagregarPROD.Click += new System.EventHandler(this.btnagregarPROD_Click);
            // 
            // dgvproductosPROD
            // 
            this.dgvproductosPROD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproductosPROD.Location = new System.Drawing.Point(38, 289);
            this.dgvproductosPROD.Name = "dgvproductosPROD";
            this.dgvproductosPROD.RowHeadersWidth = 51;
            this.dgvproductosPROD.RowTemplate.Height = 25;
            this.dgvproductosPROD.Size = new System.Drawing.Size(631, 157);
            this.dgvproductosPROD.TabIndex = 25;
            this.dgvproductosPROD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproductosPROD_CellClick);
            this.dgvproductosPROD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproductosPROD_CellContentClick);
            this.dgvproductosPROD.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproductosPROD_CellDoubleClick);
            // 
            // cbcategoriaPROD
            // 
            this.cbcategoriaPROD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcategoriaPROD.FormattingEnabled = true;
            this.cbcategoriaPROD.Location = new System.Drawing.Point(116, 86);
            this.cbcategoriaPROD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbcategoriaPROD.Name = "cbcategoriaPROD";
            this.cbcategoriaPROD.Size = new System.Drawing.Size(183, 23);
            this.cbcategoriaPROD.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "Proveedor";
            // 
            // cbproveedorPROD
            // 
            this.cbproveedorPROD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbproveedorPROD.FormattingEnabled = true;
            this.cbproveedorPROD.Location = new System.Drawing.Point(428, 86);
            this.cbproveedorPROD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbproveedorPROD.Name = "cbproveedorPROD";
            this.cbproveedorPROD.Size = new System.Drawing.Size(183, 23);
            this.cbproveedorPROD.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 33;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 34;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(358, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 35;
            this.label5.Text = "Existencia";
            // 
            // txtprecioPROD
            // 
            this.txtprecioPROD.Location = new System.Drawing.Point(116, 142);
            this.txtprecioPROD.Name = "txtprecioPROD";
            this.txtprecioPROD.Size = new System.Drawing.Size(212, 23);
            this.txtprecioPROD.TabIndex = 36;
            this.txtprecioPROD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprecioPROD_KeyPress);
            this.txtprecioPROD.Validating += new System.ComponentModel.CancelEventHandler(this.txtprecioPROD_Validating);
            // 
            // txtExistenciaPROD
            // 
            this.txtExistenciaPROD.Location = new System.Drawing.Point(428, 205);
            this.txtExistenciaPROD.Name = "txtExistenciaPROD";
            this.txtExistenciaPROD.Size = new System.Drawing.Size(212, 23);
            this.txtExistenciaPROD.TabIndex = 37;
            this.txtExistenciaPROD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExistenciaPROD_KeyPress);
            this.txtExistenciaPROD.Validating += new System.ComponentModel.CancelEventHandler(this.txtExistenciaPROD_Validating);
            // 
            // txtnombrePROD
            // 
            this.txtnombrePROD.Location = new System.Drawing.Point(428, 145);
            this.txtnombrePROD.Name = "txtnombrePROD";
            this.txtnombrePROD.Size = new System.Drawing.Size(212, 23);
            this.txtnombrePROD.TabIndex = 38;
            this.txtnombrePROD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombrePROD_KeyPress);
            this.txtnombrePROD.Validating += new System.ComponentModel.CancelEventHandler(this.txtnombrePROD_Validating);
            // 
            // txtdescripcionPROD
            // 
            this.txtdescripcionPROD.Location = new System.Drawing.Point(116, 205);
            this.txtdescripcionPROD.Name = "txtdescripcionPROD";
            this.txtdescripcionPROD.Size = new System.Drawing.Size(212, 23);
            this.txtdescripcionPROD.TabIndex = 40;
            this.txtdescripcionPROD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdescripcionPROD_KeyPress);
            this.txtdescripcionPROD.Validating += new System.ComponentModel.CancelEventHandler(this.txtdescripcionPROD_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 39;
            this.label6.Text = "Descrpcion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(209, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(291, 32);
            this.label10.TabIndex = 41;
            this.label10.Text = "Inventario de Productos";
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(304, 253);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(88, 26);
            this.btnbuscar.TabIndex = 75;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 74;
            this.label7.Text = "Buscar :";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(98, 256);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(201, 23);
            this.txtbuscar.TabIndex = 73;
            // 
            // btnmenuPROD
            // 
            this.btnmenuPROD.Image = ((System.Drawing.Image)(resources.GetObject("btnmenuPROD.Image")));
            this.btnmenuPROD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmenuPROD.Location = new System.Drawing.Point(688, 11);
            this.btnmenuPROD.Name = "btnmenuPROD";
            this.btnmenuPROD.Size = new System.Drawing.Size(104, 39);
            this.btnmenuPROD.TabIndex = 76;
            this.btnmenuPROD.Text = "Menu";
            this.btnmenuPROD.UseVisualStyleBackColor = true;
            this.btnmenuPROD.Click += new System.EventHandler(this.btnmenuPROD_Click);
            // 
            // epPROD
            // 
            this.epPROD.ContainerControl = this;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(824, 466);
            this.Controls.Add(this.btnmenuPROD);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtdescripcionPROD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtnombrePROD);
            this.Controls.Add(this.txtExistenciaPROD);
            this.Controls.Add(this.txtprecioPROD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbproveedorPROD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbcategoriaPROD);
            this.Controls.Add(this.btneliminarProd);
            this.Controls.Add(this.btnactualizarProd);
            this.Controls.Add(this.btnagregarPROD);
            this.Controls.Add(this.dgvproductosPROD);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductosPROD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPROD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btneliminarProd;
        private Button btnactualizarProd;
        private Button btnagregarPROD;
        private DataGridView dgvproductosPROD;
        private ComboBox cbcategoriaPROD;
        private Label label1;
        private Label label2;
        private ComboBox cbproveedorPROD;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtprecioPROD;
        private TextBox txtExistenciaPROD;
        private TextBox txtnombrePROD;
        private TextBox txtdescripcionPROD;
        private Label label6;
        private Label label10;
        private Button btnbuscar;
        private Label label7;
        private TextBox txtbuscar;
        private Button btnmenuPROD;
        private ErrorProvider epPROD;
    }
}