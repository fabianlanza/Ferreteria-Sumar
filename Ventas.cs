using Comercial_y_Ferreteria_Sumar.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comercial_y_Ferreteria_Sumar
{
    public partial class Ventas : Form
    {
        string pago;
        Funciones fun = new Funciones();
        Validaciones val = new Validaciones();

        string idclienteanterior;
        string clienteanterior;
        string idempanterior;
        string empleadoanterior;
        string idprodanterior;
        string productoanterior;
        string precioant;
        string existant;
        private string valortext = "";
        //Variables Variables = new Variables();//////////////

        public string Pago { get => pago; set => pago = value; }

        public Ventas()
        {
            InitializeComponent();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.MaximizeBox = false;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            txtcliente.Text = Variables.valclie;
            txtidcliente.Text = Variables.validclie;
            txtempleado.Text = Variables.Valemp;
            txtidempleado.Text = Variables.Validemp;
            TxtIdProducto.Text = Variables.Validprod;
            txtproducto.Text = Variables.Valprod;
            txtpreciounitarioVT.Text = Variables.Valprecio;
            TxtExistencia.Text = Variables.Valexist;
            cmbtipopago.Text = Variables.valtipopago;
            txtKm.Text = Variables.distancia;
            llenargird();
            Autonum();
            cbnoVT.Checked = true;
            btnvenderVT.Enabled = false;
            if (TxtIdProducto.Text != "")
            {
                txtcantidad.Enabled = true;
            }
            else
            {
                txtcantidad.Enabled = false;
            }


            if (dgvventasVT.RowCount > 0)
            {
                btneliminarVT.Visible = true;
            }
            else
            {
                btneliminarVT.Visible = false;
            }
        }

        private void llenararreglo()
        {
            if (dgvventasVT.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvventasVT.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string id = row.Cells[0].Value.ToString();
                        string produc = row.Cells[1].Value.ToString();
                        int canti = Convert.ToInt32(row.Cells[3].Value);
                        decimal preci = Convert.ToDecimal(row.Cells[2].Value);
                        int exi = Convert.ToInt32(row.Cells[4].Value);
                        decimal total = preci * canti;

                        DataRow[] existingRows = Variables.dt.Select("ID = " + id);
                        if (existingRows.Length > 0)
                        {
                        }
                        else
                        {
                            // El registro no existe, agrégalo al DataTable
                            Variables.dt.Rows.Add(id, produc, preci, canti, exi, total);
                        }





                    }
                }
            }
        }

        private void llenargird()
        {
            if (Variables.dt.Rows.Count > 0)
            {
                dgvventasVT.Rows.Clear();

                foreach (DataRow row in Variables.dt.Rows)
                {
                    object[] rowData = row.ItemArray;
                    dgvventasVT.Rows.Add(rowData);
                    //dgvventasVT.DataSource = Variables.dt;
                }


            }
        }

        private void btnmenuVT_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show(this);
            this.Hide();
        }

        private void btnagregarVT_Click(object sender, EventArgs e)
        {
            if (txtcantidad.Text != "")
            {
                if (int.Parse(txtcantidad.Text) > int.Parse(TxtExistencia.Text))
                {
                    MessageBox.Show("La cantidad no puede ser mayor a la existencia", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string id = TxtIdProducto.Text;
                    string produc = txtproducto.Text;
                    int canti = int.Parse(txtcantidad.Text);
                    decimal preci = decimal.Parse(txtpreciounitarioVT.Text);
                    int exi = int.Parse(TxtExistencia.Text);
                    decimal total = canti * preci;
                    object[] rowValues = new object[] { id, produc, preci, canti, exi, total };
                    dgvventasVT.Rows.Add(rowValues);
                    llenararreglo();
                    sumatoria();
                    btnvenderVT.Enabled = true;
                    btneliminarVT.Visible = true;
                }




            }

        }

        private void sumatoria()
        {
            decimal suma = 0;
            foreach (DataGridViewRow row in dgvventasVT.Rows)
            {
                suma += Convert.ToDecimal(row.Cells[5].Value);
            }
            txtsubtotalVT.Text = suma.ToString();
            decimal isv = suma * (decimal)0.15;
            txtimpuestoVT.Text = isv.ToString();
            decimal totneto = suma + isv;
            lblcantidadapagarVT.Text = totneto.ToString();
        }

        private void btneliminarVT_Click(object sender, EventArgs e)
        {


            if (dgvventasVT.SelectedRows.Count > 0)
            {
                int index = dgvventasVT.SelectedRows[0].Index;
                dgvventasVT.Rows.RemoveAt(index);
                Variables.dt.Rows.RemoveAt(index);
                sumatoria();
            }


        }

        private void dgvventasVT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvventasVT.Rows[e.RowIndex];
            row.Selected = true;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Variables.distancia = txtKm.Text;
        }

        private void addproducto_Click(object sender, EventArgs e)
        {
            Variables.Valueprod = 2;
            Productos productos = new Productos();
            productos.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Variables.Valuecli = 2;
            Clientes clientes = new Clientes();
            clientes.Show();
            this.Hide();


        }

        private void button2_Click(object sender, EventArgs e)
        {

            Variables.Valuepemp = 2;
            Empleados empleados = new Empleados();
            empleados.Show();
            this.Hide();

        }

        private void btnvenderVT_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txtKm.Text))
            {
                txtKm.Text = "0";
            }

            string fechaConvertida = dtpfechanaVT.Value.ToString("yyyy-MM-dd");
            string query = "insert into Ventas values('" + txtcodventa.Text + "', '" + txtidempleado.Text + "', '" + txtidcliente.Text + "', '" + fechaConvertida + "', '" + txtKm.Text + "', '" + cmbtipopago.Text + "' ,'" + lblcantidadapagarVT.Text + "')";
            fun.manipular(query);//aqui guarda la compra

            for (int i = 0; i < dgvventasVT.Rows.Count; i++)
            {
                string val1 = dgvventasVT.Rows[i].Cells[0].Value.ToString();
                int val3 = Convert.ToInt32(dgvventasVT.Rows[i].Cells[3].Value.ToString());
                int ex = Convert.ToInt32(dgvventasVT.Rows[i].Cells[4].Value.ToString());
                string query2 = "Insert into DetalleVentas Values('" + txtcodventa.Text + "', '" + val1 + "', '" + val3 + "')";
                fun.manipular(query2);//aqui el detalle

                int diferencia = (int)ex - (int)val3;


                string query3 = "update Productos set Existencia= " + diferencia + " where CodigoProducto =  '" + val1 + "'";
                fun.manipular(query3);//aqui actualiza la nueva existencia
            }

            fun.cerrar();
            MessageBox.Show("La Venta se ha realizado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //nuevooo
            fun.limpiar(txtcodventa, txtidempleado, txtempleado, txtidcliente, txtcliente, TxtIdProducto, txtproducto, TxtExistencia, txtcantidad, txtpreciounitarioVT, txtsubtotalVT, txtimpuestoVT);
            txtKm.Text = "";
            dgvventasVT.DataSource = "";
        }

        private void Autonum()
        {
            SqlDataReader dr = null;
            string query = "select CodigoVentas from Ventas";
            if (fun.val(query) == true)
            {
                query = "select Max(CodigoVentas) from Ventas";
                dr = fun.leerdato(query);
                while (dr.Read())
                {
                    txtcodventa.Text = Convert.ToString(Convert.ToInt32(dr.GetValue(0)) + 1);
                }
                dr.Close();
            }
            else
            {
                txtcodventa.Text = "1";
            }
        }

        private void cmbtipopago_SelectedIndexChanged(object sender, EventArgs e)
        {
            Variables.valtipopago = cmbtipopago.Text;
        }

        private void rbsiVT_CheckedChanged(object sender, EventArgs e)
        {
            if (rbsiVT.Checked == true)
            {
                txtKm.Visible = true;
            }
            else
            {
                txtKm.Visible = false;
            }
        }

        private void cbnoVT_CheckedChanged(object sender, EventArgs e)
        {
            if (cbnoVT.Checked == true)
            {
                txtKm.Visible = false;
            }
            else
            {
                txtKm.Visible = true;
            }
        }
    }

}