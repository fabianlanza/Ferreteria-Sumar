﻿namespace Comercial_y_Ferreteria_Sumar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtusuariolg = new System.Windows.Forms.TextBox();
            this.txtclavelg = new System.Windows.Forms.TextBox();
            this.btningresarlg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(150, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(55, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(55, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Clave";
            // 
            // txtusuariolg
            // 
            this.txtusuariolg.Location = new System.Drawing.Point(133, 114);
            this.txtusuariolg.Name = "txtusuariolg";
            this.txtusuariolg.Size = new System.Drawing.Size(149, 23);
            this.txtusuariolg.TabIndex = 3;
            // 
            // txtclavelg
            // 
            this.txtclavelg.Location = new System.Drawing.Point(133, 227);
            this.txtclavelg.Name = "txtclavelg";
            this.txtclavelg.Size = new System.Drawing.Size(149, 23);
            this.txtclavelg.TabIndex = 4;
            // 
            // btningresarlg
            // 
            this.btningresarlg.BackColor = System.Drawing.Color.Turquoise;
            this.btningresarlg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btningresarlg.Image = ((System.Drawing.Image)(resources.GetObject("btningresarlg.Image")));
            this.btningresarlg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btningresarlg.Location = new System.Drawing.Point(150, 305);
            this.btningresarlg.Name = "btningresarlg";
            this.btningresarlg.Size = new System.Drawing.Size(117, 37);
            this.btningresarlg.TabIndex = 5;
            this.btningresarlg.Text = "Ingresar";
            this.btningresarlg.UseVisualStyleBackColor = false;
            this.btningresarlg.Click += new System.EventHandler(this.btningresarlg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(401, 364);
            this.Controls.Add(this.btningresarlg);
            this.Controls.Add(this.txtclavelg);
            this.Controls.Add(this.txtusuariolg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Iniciar Sesion";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtusuariolg;
        private TextBox txtclavelg;
        private Button btningresarlg;
    }
}