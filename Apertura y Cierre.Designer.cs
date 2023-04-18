namespace Comercial_y_Ferreteria_Sumar
{
    partial class Apertura_y_Cierre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Apertura_y_Cierre));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSaldoInicial = new System.Windows.Forms.TextBox();
            this.txtTotalVentas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCierreCaja = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnApertura = new System.Windows.Forms.Button();
            this.btnCierre = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblApertura = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(189, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saldo Inicial:";
            // 
            // txtSaldoInicial
            // 
            this.txtSaldoInicial.Location = new System.Drawing.Point(276, 74);
            this.txtSaldoInicial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSaldoInicial.Name = "txtSaldoInicial";
            this.txtSaldoInicial.Size = new System.Drawing.Size(170, 23);
            this.txtSaldoInicial.TabIndex = 1;
            // 
            // txtTotalVentas
            // 
            this.txtTotalVentas.Enabled = false;
            this.txtTotalVentas.Location = new System.Drawing.Point(276, 129);
            this.txtTotalVentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalVentas.Name = "txtTotalVentas";
            this.txtTotalVentas.Size = new System.Drawing.Size(170, 23);
            this.txtTotalVentas.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(189, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Ventas:";
            // 
            // txtCierreCaja
            // 
            this.txtCierreCaja.Enabled = false;
            this.txtCierreCaja.Location = new System.Drawing.Point(276, 189);
            this.txtCierreCaja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCierreCaja.Name = "txtCierreCaja";
            this.txtCierreCaja.Size = new System.Drawing.Size(170, 23);
            this.txtCierreCaja.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(178, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cierre de Caja:";
            // 
            // btnMenu
            // 
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(584, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(104, 39);
            this.btnMenu.TabIndex = 78;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnApertura
            // 
            this.btnApertura.Location = new System.Drawing.Point(178, 266);
            this.btnApertura.Name = "btnApertura";
            this.btnApertura.Size = new System.Drawing.Size(88, 36);
            this.btnApertura.TabIndex = 79;
            this.btnApertura.Text = "Apertura";
            this.btnApertura.UseVisualStyleBackColor = true;
            this.btnApertura.Click += new System.EventHandler(this.btnApertura_Click);
            // 
            // btnCierre
            // 
            this.btnCierre.Location = new System.Drawing.Point(380, 266);
            this.btnCierre.Name = "btnCierre";
            this.btnCierre.Size = new System.Drawing.Size(84, 36);
            this.btnCierre.TabIndex = 80;
            this.btnCierre.Text = "Cierre";
            this.btnCierre.UseVisualStyleBackColor = true;
            this.btnCierre.Click += new System.EventHandler(this.btnCierre_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(472, 123);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(82, 31);
            this.btnCalcular.TabIndex = 81;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblApertura
            // 
            this.lblApertura.AutoSize = true;
            this.lblApertura.Location = new System.Drawing.Point(452, 77);
            this.lblApertura.Name = "lblApertura";
            this.lblApertura.Size = new System.Drawing.Size(40, 15);
            this.lblApertura.TabIndex = 82;
            this.lblApertura.Text = "label4";
            // 
            // Apertura_y_Cierre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.lblApertura);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnCierre);
            this.Controls.Add(this.btnApertura);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.txtCierreCaja);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotalVentas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSaldoInicial);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Apertura_y_Cierre";
            this.Text = "Apertura_y_Cierre";
            this.Load += new System.EventHandler(this.Apertura_y_Cierre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtSaldoInicial;
        private TextBox txtTotalVentas;
        private Label label2;
        private TextBox txtCierreCaja;
        private Label label3;
        private Button btnMenu;
        private Button btnApertura;
        private Button btnCierre;
        private Button btnCalcular;
        private Label lblApertura;
    }
}