using Comercial_y_Ferreteria_Sumar.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comercial_y_Ferreteria_Sumar
{
    public partial class Menu : Form
    {
        //Variables variables = new Variables();//

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.ControlBox = false;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void btnusuariosMEN_Click(object sender, EventArgs e)
        {

            Compras compras = new Compras();
            compras.Show();
            this.Hide();
        }

        private void btnempleadosMEN_Click(object sender, EventArgs e)
        {
            Variables.Valuepemp = 1;
            Empleados empleados = new Empleados();
            empleados.Show();
            this.Hide();
        }

        private void btnpuestosMEN_Click(object sender, EventArgs e)
        {
            Puestros puestos = new Puestros();
            puestos.Show();
            this.Hide();
        }

        private void btnsucursalesMEN_Click(object sender, EventArgs e)
        {
            Sucursales sucursales = new Sucursales();
            sucursales.Show();
            this.Hide();
        }

        private void btnventasMEN_Click(object sender, EventArgs e)
        {
            Ventas ventas = new Ventas();
            ventas.Show();
            this.Hide();
        }

        private void btnproveedoresMEN_Click(object sender, EventArgs e)
        {
            Variables.valueproov = 1;
            Proveedores proveedores = new Proveedores();
            proveedores.Show();
            this.Hide();
        }

        private void btnclientesMEN_Click(object sender, EventArgs e)
        {
            Variables.Valuecli = 1;
            Clientes clientes = new Clientes();
            clientes.Show();
            this.Hide();
        }

        private void btnproductosMEN_Click(object sender, EventArgs e)
        {
            Variables.Valueprod = 1;
            Productos productos = new Productos();
            productos.Show();
            this.Hide();
        }

        private void btncerrarsesionMEN_Click(object sender, EventArgs e)
        {
            Form1 Login = new Form1();
            Login.Show();
            this.Hide();
        }

        private void btncategoriaMEN_Click(object sender, EventArgs e)
        {
         
            Categorias categorias = new Categorias();
            categorias.Show();
            this.Hide();
        }

        private void btnAperturaCierre_Click(object sender, EventArgs e)
        {
            Apertura_y_Cierre apertura = new Apertura_y_Cierre();
            apertura.Show();
            this.Hide();
        }
    }
}
