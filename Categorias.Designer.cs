namespace Comercial_y_Ferreteria_Sumar
{
    partial class Categorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categorias));
            this.btneliminarCAT = new System.Windows.Forms.Button();
            this.btnactualizarCAT = new System.Windows.Forms.Button();
            this.btnagregarCAT = new System.Windows.Forms.Button();
            this.dgvCategoriasCAT = new System.Windows.Forms.DataGridView();
            this.txtnombreCAT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btnmenuCAT = new System.Windows.Forms.Button();
            this.epCAT = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoriasCAT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCAT)).BeginInit();
            this.SuspendLayout();
            // 
            // btneliminarCAT
            // 
            this.btneliminarCAT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btneliminarCAT.Location = new System.Drawing.Point(679, 354);
            this.btneliminarCAT.Name = "btneliminarCAT";
            this.btneliminarCAT.Size = new System.Drawing.Size(104, 39);
            this.btneliminarCAT.TabIndex = 60;
            this.btneliminarCAT.Text = "Eliminar";
            this.btneliminarCAT.UseVisualStyleBackColor = true;
            this.btneliminarCAT.Click += new System.EventHandler(this.btneliminarCAT_Click);
            // 
            // btnactualizarCAT
            // 
            this.btnactualizarCAT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnactualizarCAT.Location = new System.Drawing.Point(679, 293);
            this.btnactualizarCAT.Name = "btnactualizarCAT";
            this.btnactualizarCAT.Size = new System.Drawing.Size(104, 39);
            this.btnactualizarCAT.TabIndex = 59;
            this.btnactualizarCAT.Text = "Actualizar";
            this.btnactualizarCAT.UseVisualStyleBackColor = true;
            this.btnactualizarCAT.Click += new System.EventHandler(this.btnactualizarCAT_Click);
            // 
            // btnagregarCAT
            // 
            this.btnagregarCAT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnagregarCAT.Location = new System.Drawing.Point(679, 236);
            this.btnagregarCAT.Name = "btnagregarCAT";
            this.btnagregarCAT.Size = new System.Drawing.Size(104, 39);
            this.btnagregarCAT.TabIndex = 58;
            this.btnagregarCAT.Text = "Agregar";
            this.btnagregarCAT.UseVisualStyleBackColor = true;
            this.btnagregarCAT.Click += new System.EventHandler(this.btnagregarCAT_Click);
            // 
            // dgvCategoriasCAT
            // 
            this.dgvCategoriasCAT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoriasCAT.Location = new System.Drawing.Point(29, 236);
            this.dgvCategoriasCAT.Name = "dgvCategoriasCAT";
            this.dgvCategoriasCAT.RowHeadersWidth = 51;
            this.dgvCategoriasCAT.RowTemplate.Height = 25;
            this.dgvCategoriasCAT.Size = new System.Drawing.Size(631, 157);
            this.dgvCategoriasCAT.TabIndex = 57;
            this.dgvCategoriasCAT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoriasCAT_CellClick);
            // 
            // txtnombreCAT
            // 
            this.txtnombreCAT.Location = new System.Drawing.Point(282, 111);
            this.txtnombreCAT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnombreCAT.Name = "txtnombreCAT";
            this.txtnombreCAT.Size = new System.Drawing.Size(212, 23);
            this.txtnombreCAT.TabIndex = 62;
            this.txtnombreCAT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombreCAT_KeyPress);
            this.txtnombreCAT.Validating += new System.ComponentModel.CancelEventHandler(this.txtnombreCAT_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(226, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 61;
            this.label6.Text = "Nombre";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(202, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(341, 32);
            this.label10.TabIndex = 63;
            this.label10.Text = "Adminitración de Categorias";
            // 
            // btnbuscar
            // 
            this.btnbuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnbuscar.Location = new System.Drawing.Point(500, 184);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(88, 26);
            this.btnbuscar.TabIndex = 66;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(226, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 65;
            this.label1.Text = "Buscar ";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(282, 187);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(212, 23);
            this.txtbuscar.TabIndex = 64;
            // 
            // btnmenuCAT
            // 
            this.btnmenuCAT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnmenuCAT.Image = ((System.Drawing.Image)(resources.GetObject("btnmenuCAT.Image")));
            this.btnmenuCAT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmenuCAT.Location = new System.Drawing.Point(710, 10);
            this.btnmenuCAT.Name = "btnmenuCAT";
            this.btnmenuCAT.Size = new System.Drawing.Size(104, 39);
            this.btnmenuCAT.TabIndex = 67;
            this.btnmenuCAT.Text = "Menu";
            this.btnmenuCAT.UseVisualStyleBackColor = true;
            this.btnmenuCAT.Click += new System.EventHandler(this.btnmenuCAT_Click);
            // 
            // epCAT
            // 
            this.epCAT.ContainerControl = this;
            // 
            // Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(825, 421);
            this.Controls.Add(this.btnmenuCAT);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtnombreCAT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btneliminarCAT);
            this.Controls.Add(this.btnactualizarCAT);
            this.Controls.Add(this.btnagregarCAT);
            this.Controls.Add(this.dgvCategoriasCAT);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Categorias";
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.Categorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoriasCAT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCAT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btneliminarCAT;
        private Button btnactualizarCAT;
        private Button btnagregarCAT;
        private DataGridView dgvCategoriasCAT;
        private TextBox txtnombreCAT;
        private Label label6;
        private Label label10;
        private Button btnbuscar;
        private Label label1;
        private TextBox txtbuscar;
        private Button btnmenuCAT;
        private ErrorProvider epCAT;
    }
}