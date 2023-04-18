﻿using Comercial_y_Ferreteria_Sumar.Clases;
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
    public partial class Empleados : Form
    {
        Funciones fun = new Funciones();
        int posicion = 0;
        int codigo = 0;
        Validaciones val = new Validaciones();
        //Variables variables = new Variables();//

        public Empleados()
        {
            InitializeComponent();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.ControlBox = false;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            fun.abrir();

            fun.mostrarempleados(dgvempleadosEMP);
            fun.mostrarsucursal(cbsucursalEMP);
            fun.mostrarpuestos(cbpuestosEMP);
            fun.mostrarjornada(cbjornadaEMP);

            fun.cerrar();
        }

        private void btnagregarEMP_Click(object sender, EventArgs e)
        {
            fun.abrir();
            
            MessageBox.Show(fun.agregarempleado((int)cbsucursalEMP.SelectedValue, (int)cbjornadaEMP.SelectedValue, (int)cbpuestosEMP.SelectedValue, txtnombresEMP.Text, txtapellidosEMP.Text, txtidentidadEMP.Text,
            dtpfechanacimientoEMP.Value, txtcorreoEMP.Text, txttelefonoEMP.Text, txtdireccionEMP.Text, txtusuarioEMP.Text, txtcontraEMP.Text, Convert.ToDouble(txtsalarioEMP.Text)));
            
            fun.cerrar();
            
            fun.mostrarempleados(dgvempleadosEMP);
        }

        private void btnActualizarEMP_Click(object sender, EventArgs e)
        {
            fun.abrir();

            MessageBox.Show(fun.actualizarempleado((int)cbsucursalEMP.SelectedValue, (int)cbjornadaEMP.SelectedValue, (int)cbpuestosEMP.SelectedValue, txtnombresEMP.Text, txtapellidosEMP.Text, txtidentidadEMP.Text,
            dtpfechanacimientoEMP.Value, txtcorreoEMP.Text, txttelefonoEMP.Text, txtdireccionEMP.Text, txtusuarioEMP.Text, txtcontraEMP.Text, Convert.ToDouble(txtsalarioEMP.Text), codigo ));

            fun.cerrar();

            fun.mostrarempleados(dgvempleadosEMP);
        }

        private void btneliminarEMP_Click(object sender, EventArgs e)
        {
            fun.abrir();

            MessageBox.Show(fun.eliminarempleado(codigo));

            fun.cerrar();

            fun.mostrarempleados(dgvempleadosEMP);
        }

        private void dgvempleadosEMP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnmenuEMP_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show(this);
            this.Hide();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            fun.abrir();

            if (txtbuscar.Text == "")
            {
                fun.mostrarempleados(dgvempleadosEMP);
            }
            else
            {
                fun.buscarempleados(dgvempleadosEMP, txtbuscar.Text);
            }

            fun.cerrar();
        }

        private void txtnombresEMP_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.sololetras(txtnombresEMP, e);
        }

        private void txtapellidosEMP_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.sololetras(txtapellidosEMP, e);
        }

        private void txttelefonoEMP_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.solonumeros(txttelefonoEMP, e);
        }

        private void txtsalarioEMP_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.solonumeros(txtsalarioEMP, e);
        }

        private void txtnombresEMP_Validating(object sender, CancelEventArgs e)
        {
            val.validarvacios(txtnombresEMP, epEMP);
        }

        private void txtapellidosEMP_Validating(object sender, CancelEventArgs e)
        {
            val.validarvacios(txtapellidosEMP, epEMP);
        }

        private void txtidentidadEMP_Validating(object sender, CancelEventArgs e)
        {
            val.validarvacios(txtidentidadEMP, epEMP);
        }

        private void txttelefonoEMP_Validating(object sender, CancelEventArgs e)
        {
            val.validarvacios(txttelefonoEMP, epEMP);
        }

        private void txtsalarioEMP_Validating(object sender, CancelEventArgs e)
        {
            val.validarvacios(txtsalarioEMP, epEMP);
        }

        private void txtcorreoEMP_Validating(object sender, CancelEventArgs e)
        {
            val.validarvacios(txtcorreoEMP, epEMP);
        }

        private void txtdireccionEMP_Validating(object sender, CancelEventArgs e)
        {
            val.validarvacios(txtdireccionEMP, epEMP);
        }

        private void txtidentidadEMP_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.solonumeros(txtapellidosEMP, e);
        }

        private void dgvempleadosEMP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dgvempleadosEMP.CurrentRow.Index;

            if (Variables.Valuepemp == 1)
            {
                codigo = Convert.ToInt32(dgvempleadosEMP.Rows[posicion].Cells[0].Value);
                cbsucursalEMP.Text = dgvempleadosEMP.Rows[posicion].Cells[1].Value.ToString();
                cbjornadaEMP.SelectedItem = dgvempleadosEMP.Rows[posicion].Cells[2].Value.ToString();
                cbpuestosEMP.SelectedItem = dgvempleadosEMP.Rows[posicion].Cells[3].Value.ToString();
                txtnombresEMP.Text = dgvempleadosEMP.Rows[posicion].Cells[4].Value.ToString();
                txtapellidosEMP.Text = dgvempleadosEMP.Rows[posicion].Cells[5].Value.ToString();
                txtidentidadEMP.Text = dgvempleadosEMP.Rows[posicion].Cells[6].Value.ToString();
                dtpfechanacimientoEMP.Text = dgvempleadosEMP.Rows[posicion].Cells[7].Value.ToString();
                txtcorreoEMP.Text = dgvempleadosEMP.Rows[posicion].Cells[8].Value.ToString();
                txttelefonoEMP.Text = dgvempleadosEMP.Rows[posicion].Cells[9].Value.ToString();
                txtdireccionEMP.Text = dgvempleadosEMP.Rows[posicion].Cells[10].Value.ToString();
                txtusuarioEMP.Text = dgvempleadosEMP.Rows[posicion].Cells[11].Value.ToString();
                txtcontraEMP.Text = dgvempleadosEMP.Rows[posicion].Cells[12].Value.ToString();
                txtsalarioEMP.Text = dgvempleadosEMP.Rows[posicion].Cells[13].Value.ToString();
            }
            else { 
                Variables.Validemp = dgvempleadosEMP.Rows[posicion].Cells[0].Value.ToString();
                Variables.Valemp = dgvempleadosEMP.Rows[posicion].Cells[4].Value.ToString() + ' ' + dgvempleadosEMP.Rows[posicion].Cells[5].Value.ToString();
                if (Variables.Valuepemp == 2)
                    {
                        Ventas ventas = new Ventas();
                        ventas.Show();
                        this.Close();
                    }
                else if (Variables.Valuepemp == 3)
                {
                    Compras compras = new Compras();
                    compras.Show();
                    this.Hide();
                }
            }


        }















    }
}
