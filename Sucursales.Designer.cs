namespace Comercial_y_Ferreteria_Sumar
{
    partial class Sucursales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sucursales));
            this.btneliminarSU = new System.Windows.Forms.Button();
            this.btnactualizarSU = new System.Windows.Forms.Button();
            this.btnagregarSU = new System.Windows.Forms.Button();
            this.dgvsucursalesSU = new System.Windows.Forms.DataGridView();
            this.txtdescripcionPROD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnombrePROD = new System.Windows.Forms.TextBox();
            this.txtprecioPROD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnmenuSU = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsucursalesSU)).BeginInit();
            this.SuspendLayout();
            // 
            // btneliminarSU
            // 
            this.btneliminarSU.Location = new System.Drawing.Point(677, 368);
            this.btneliminarSU.Name = "btneliminarSU";
            this.btneliminarSU.Size = new System.Drawing.Size(104, 39);
            this.btneliminarSU.TabIndex = 32;
            this.btneliminarSU.Text = "Eliminar";
            this.btneliminarSU.UseVisualStyleBackColor = true;
            this.btneliminarSU.Click += new System.EventHandler(this.btneliminarSU_Click);
            // 
            // btnactualizarSU
            // 
            this.btnactualizarSU.Location = new System.Drawing.Point(677, 309);
            this.btnactualizarSU.Name = "btnactualizarSU";
            this.btnactualizarSU.Size = new System.Drawing.Size(104, 39);
            this.btnactualizarSU.TabIndex = 31;
            this.btnactualizarSU.Text = "Actualizar";
            this.btnactualizarSU.UseVisualStyleBackColor = true;
            this.btnactualizarSU.Click += new System.EventHandler(this.btnactualizarSU_Click);
            // 
            // btnagregarSU
            // 
            this.btnagregarSU.Location = new System.Drawing.Point(677, 250);
            this.btnagregarSU.Name = "btnagregarSU";
            this.btnagregarSU.Size = new System.Drawing.Size(104, 39);
            this.btnagregarSU.TabIndex = 30;
            this.btnagregarSU.Text = "Agregar";
            this.btnagregarSU.UseVisualStyleBackColor = true;
            this.btnagregarSU.Click += new System.EventHandler(this.btnagregarSU_Click);
            // 
            // dgvsucursalesSU
            // 
            this.dgvsucursalesSU.AllowUserToAddRows = false;
            this.dgvsucursalesSU.AllowUserToDeleteRows = false;
            this.dgvsucursalesSU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsucursalesSU.Location = new System.Drawing.Point(27, 250);
            this.dgvsucursalesSU.Name = "dgvsucursalesSU";
            this.dgvsucursalesSU.ReadOnly = true;
            this.dgvsucursalesSU.RowHeadersWidth = 51;
            this.dgvsucursalesSU.RowTemplate.Height = 25;
            this.dgvsucursalesSU.Size = new System.Drawing.Size(631, 157);
            this.dgvsucursalesSU.TabIndex = 29;
            this.dgvsucursalesSU.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsucursalesSU_CellClick);
            // 
            // txtdescripcionPROD
            // 
            this.txtdescripcionPROD.Location = new System.Drawing.Point(91, 162);
            this.txtdescripcionPROD.Name = "txtdescripcionPROD";
            this.txtdescripcionPROD.Size = new System.Drawing.Size(212, 23);
            this.txtdescripcionPROD.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 47;
            this.label6.Text = "Telefono";
            // 
            // txtnombrePROD
            // 
            this.txtnombrePROD.Location = new System.Drawing.Point(403, 102);
            this.txtnombrePROD.Name = "txtnombrePROD";
            this.txtnombrePROD.Size = new System.Drawing.Size(212, 23);
            this.txtnombrePROD.TabIndex = 46;
            // 
            // txtprecioPROD
            // 
            this.txtprecioPROD.Location = new System.Drawing.Point(91, 102);
            this.txtprecioPROD.Name = "txtprecioPROD";
            this.txtprecioPROD.Size = new System.Drawing.Size(212, 23);
            this.txtprecioPROD.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 42;
            this.label4.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 41;
            this.label3.Text = "Ciudad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(165, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(340, 32);
            this.label10.TabIndex = 49;
            this.label10.Text = "Adminitración de Sucursales";
            // 
            // btnmenuSU
            // 
            this.btnmenuSU.Image = ((System.Drawing.Image)(resources.GetObject("btnmenuSU.Image")));
            this.btnmenuSU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmenuSU.Location = new System.Drawing.Point(732, 10);
            this.btnmenuSU.Name = "btnmenuSU";
            this.btnmenuSU.Size = new System.Drawing.Size(104, 39);
            this.btnmenuSU.TabIndex = 77;
            this.btnmenuSU.Text = "Menu";
            this.btnmenuSU.UseVisualStyleBackColor = true;
            this.btnmenuSU.Click += new System.EventHandler(this.btnmenuSU_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(91, 210);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(212, 23);
            this.txtBuscar.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 79;
            this.label1.Text = "Buscar";
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(320, 209);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 80;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // Sucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(868, 429);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnmenuSU);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtdescripcionPROD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtnombrePROD);
            this.Controls.Add(this.txtprecioPROD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btneliminarSU);
            this.Controls.Add(this.btnactualizarSU);
            this.Controls.Add(this.btnagregarSU);
            this.Controls.Add(this.dgvsucursalesSU);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Sucursales";
            this.Text = "Sucursales";
            this.Load += new System.EventHandler(this.Sucursales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsucursalesSU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btneliminarSU;
        private Button btnactualizarSU;
        private Button btnagregarSU;
        private DataGridView dgvsucursalesSU;
        private TextBox txtdescripcionPROD;
        private Label label6;
        private TextBox txtnombrePROD;
        private TextBox txtprecioPROD;
        private Label label4;
        private Label label3;
        private Label label10;
        private Button btnmenuSU;
        private TextBox txtBuscar;
        private Label label1;
        private Button Buscar;
    }
}