using Comercial_y_Ferreteria_Sumar.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comercial_y_Ferreteria_Sumar
{
    public partial class Compras : Form
    {

        Funciones fun = new Funciones();
        Validaciones val = new Validaciones();
        //Variables Variables = new Variables();//
        Mantenimiento mant = new Mantenimiento();

        public Compras()
        {
            InitializeComponent();
        }


        private void Compras_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.MaximizeBox = false;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            txtempleado.Text = Variables.Valemp;
            txtidproveedor.Text = Variables.Validprv;
            txtproveedor.Text = Variables.Valprv;
            txtidempleado.Text = Variables.Validemp;
            txtidproducto.Text = Variables.Validprod;
            txtproducto.Text = Variables.Valprod;
            txtpreciocostoCOM.Text = Variables.Valprecio;
            txtexistencia.Text = Variables.Valexist;
            llenargird();
            Autonum();

            //NUEVO
            btneliminarCOM.Enabled = false;
            btnComprar.Enabled = false;
            txtempleado.Enabled = false;
            txtproveedor.Enabled = false;
            txtproducto.Enabled = false;
            txtidproducto.Enabled = false; 
            dtpfechaCOM.Enabled = false;
            txtpreciocostoCOM.Enabled = false;
            txtexistencia.Enabled = false;

            

        }

        private void llenararreglo()
        {
            if (dgvcomprasCOM.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvcomprasCOM.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string id = row.Cells[0].Value.ToString();
                        string produc = row.Cells[1].Value.ToString();
                        decimal preci = Convert.ToDecimal(row.Cells[2].Value);
                        int canti = Convert.ToInt32(row.Cells[3].Value);
                        int exist = Convert.ToInt32(row.Cells[4].Value);
                        decimal total = preci * canti;
                       

                        DataRow[] existingRows = Variables.dtCompras.Select("ID = " + id);
                        if (existingRows.Length > 0)
                        {
                        }
                        else
                        {
                            // El registro no existe, agrégalo al DataTable
                            Variables.dtCompras.Rows.Add(id, produc,  preci, canti, exist, total);
                        }
                    }
                }
            }
        }

        private void llenargird()
        {
            if (Variables.dtCompras.Rows.Count > 0)
            {
                dgvcomprasCOM.Rows.Clear();

                foreach (DataRow row in Variables.dtCompras.Rows)
                {
                    object[] rowData = row.ItemArray;
                    dgvcomprasCOM.Rows.Add(rowData);
                    //dgvventasVT.DataSource = Variables.dt;
                }


            }
        }
        private void btnmenuCOM_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show(this);
            this.Hide();
        }

        private void btnagregarCOM_Click(object sender, EventArgs e)
        {
            if(txtcantidadCOM.Text == "")
            {

            }
            else
            {
                string id = txtidproducto.Text;
                string produc = txtproducto.Text;
                int canti = int.Parse(txtcantidadCOM.Text);
                decimal preci = decimal.Parse(txtpreciocostoCOM.Text);
                decimal total = canti * preci;
                int existencia = int.Parse(txtexistencia.Text);
                object[] rowValues = new object[] { id, produc, preci, canti, existencia,  total };
                dgvcomprasCOM.Rows.Add(rowValues);
                llenararreglo();
                sumatoria();
            }

            //NUEVOOOO
            mant.habilitar_btn(this);
            addempleado.Enabled = false;
        }

       

        private void btnactualizarCOM_Click(object sender, EventArgs e)
        {

        }

        private void sumatoria()
        {
            decimal suma = 0;
            foreach (DataGridViewRow row in dgvcomprasCOM.Rows)
            {
                suma += Convert.ToDecimal(row.Cells[5].Value);
            }
            txtsubtotalVT.Text = suma.ToString();
            decimal isv = suma * (decimal)0.15;
            txtimpuestoVT.Text = isv.ToString();
            decimal totneto = suma + isv;
            lblcantidadapagarVT.Text = totneto.ToString();
        }

        private void btneliminarCOM_Click(object sender, EventArgs e)
        {
            int index = dgvcomprasCOM.SelectedRows[0].Index;
            dgvcomprasCOM.Rows.RemoveAt(index);
            Variables.dtCompras.Rows.RemoveAt(index);
            sumatoria();
        }

        private void dgvcomprasCOM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvcomprasCOM.Rows[e.RowIndex];
            row.Selected = true;
        }

        private void txtpreciocostoCOM_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.solonumeros(txtpreciocostoCOM, e);
        }

        private void txtpreciocostoCOM_Validating(object sender, CancelEventArgs e)
        {
            val.validarvacios(txtpreciocostoCOM, epCOM);
        }

        private void txtcantidadCOM_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.solonumeros(txtcantidadCOM, e);
        }

        private void txtcantidadCOM_Validating(object sender, CancelEventArgs e)
        {
            val.validarvacios(txtcantidadCOM, epCOM);
        }

        private void dgvcomprasCOM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addproducto_Click(object sender, EventArgs e)
        {
            Variables.Valueprod = 3;

            Productos productos = new Productos();
            productos.ShowDialog();
            this.Hide();
        }

        private void addempleado_Click(object sender, EventArgs e)
        {
            Variables.Valuepemp = 3;

            Empleados empleados = new Empleados();
            empleados.ShowDialog();
            this.Hide();
        }

        private void addproveedor_Click(object sender, EventArgs e)
        {
            Variables.valueproov = 2;

            Proveedores proveedores = new Proveedores();
            proveedores.Show();
            this.Hide();
        }

        private void txtidproducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            string fechaConvertida = dtpfechaCOM.Value.ToString("yyyy-MM-dd");
            string query = "insert into Compras values('" + txtCodCompra.Text + "', '" + txtidempleado.Text + "', '" + txtidproveedor.Text + "', '" + fechaConvertida + "', '" + lblcantidadapagarVT.Text + "')";
            fun.manipular(query);//aqui guarda la compra

            for (int i=0;i<dgvcomprasCOM.Rows.Count;i++)
            {
                string val1 = dgvcomprasCOM.Rows[i].Cells[0].Value.ToString();
                int val3 = Convert.ToInt32(dgvcomprasCOM.Rows[i].Cells[3].Value.ToString());
                int ex = Convert.ToInt32(dgvcomprasCOM.Rows[i].Cells[4].Value.ToString());
                query = "Insert into DetalleCompras Values('" + txtCodCompra.Text + "', '" + val1 + "', '" + val3 + "')";
                fun.manipular(query);//aqui el detalle

                int diferencia = (int)ex + (int)val3;

                query = "update Productos set Existencia= " + diferencia + " where CodigoProducto =  '" + val1 + "'";
                fun.manipular(query);//aqui actualiza la nueva existencia
            }

            

            fun.cerrar();

            //NUEVO
            addempleado.Enabled = true;
            //mant.limpiar(this);
        }

        private void Autonum()
        {
            SqlDataReader dr = null;
            string query = "select CodigoCompra from Compras";
            if(fun.val(query) == true)
            {
                query = "select Max(CodigoCompra) from Compras";
                dr = fun.leerdato(query);
                while(dr.Read())
                {
                    txtCodCompra.Text = Convert.ToString(Convert.ToInt32(dr.GetValue(0)) + 1);
                }
                dr.Close();
            }
            else
            {
                txtCodCompra.Text = "1";
            }
        }

        private void txtidempleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpreciocostoCOM_TextChanged(object sender, EventArgs e)
        {

        }
    }
       
}
