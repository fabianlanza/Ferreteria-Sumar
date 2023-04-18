using Comercial_y_Ferreteria_Sumar.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comercial_y_Ferreteria_Sumar
{
    public partial class Apertura_y_Cierre : Form
    {
        Funciones fun = new Funciones();
        
        public Apertura_y_Cierre()
        {
            InitializeComponent();
        }

        private void Apertura_y_Cierre_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.MaximizeBox = false;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            lblApertura.Enabled = false;

            lblApertura.Text = Variables.Apertura.ToString();


        }



        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show(this);
            this.Hide();
        }

        private void btnApertura_Click(object sender, EventArgs e)
        {
            lblApertura.Enabled = true;

            Variables.Apertura = Convert.ToDouble(txtSaldoInicial.Text);

            lblApertura.Text = Variables.Apertura.ToString();
        }

        private void btnCierre_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show(this);
            this.Hide();
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            fun.abrir();

            fun.calculoventas();

            txtTotalVentas.Text = Variables.ventas.ToString();

            txtCierreCaja.Text = (Variables.ventas + Variables.Apertura).ToString();

            fun.cerrar();
        }
    }
}
