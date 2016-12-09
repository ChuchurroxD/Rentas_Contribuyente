using SGR.Core.Service;
using SGR.Entity.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGR.WinApp.Sistema.Globales;


namespace SGR.WinApp.Layout._1_Tablas_Maestras.TasaCambio
{
    public partial class Frm_TasaCambio_Detalle : Form
    {
        private Mant_TasaCambio mant_TasaCambio;
        Validaciones validaciones = new Validaciones();

        public Frm_TasaCambio_Detalle()
        {
            InitializeComponent();
        }

        public Frm_TasaCambio_Detalle(Mant_TasaCambio mant_TasaCambio)
        {
            InitializeComponent();
            this.mant_TasaCambio = mant_TasaCambio;
        }

        private void botonGrabar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Grabar?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Mant_TasaCambioDataService mant_TasaCambioDataService = new Mant_TasaCambioDataService();
                try
                {
                    if (txtidTasaCambio.Text.Length == 0)
                    {
                        if (txtPrecioVenta.Text.Trim().Length < 0)
                            MessageBox.Show("Debe Ingresar una descripcion");
                        if (txtPrecioCompra.Text.Trim().Length < 0)
                            MessageBox.Show("Seleccione una opción");
                        if (dtpFecha.Text.Trim().Length < 0)
                            MessageBox.Show("Debe Seleccionar Fecha");
                        if (txtPrecioVenta.Text.Length > 0 || txtPrecioVenta.Text.Length > 0 || dtpFecha.Text.Length > 0)
                        {
                            Mant_TasaCambio mant_TasaCambio1 = new Mant_TasaCambio();
                            mant_TasaCambio1.fecha = dtpFecha.Value;
                            mant_TasaCambio1.precioVenta = Decimal.Parse(txtPrecioVenta.Text);
                            mant_TasaCambio1.precioCompra = Decimal.Parse(txtPrecioCompra.Text);
                            mant_TasaCambio1.estado = chkEstado.Checked;
                            mant_TasaCambio1.registro_user_add = "UsuarioPrueba";
                            mant_TasaCambioDataService.insertarTasaCambio(mant_TasaCambio1);
                            MessageBox.Show("Se Registro Correctamente", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();

                        }
                    }
                    else
                    {
                        mant_TasaCambio.idTasaCambio = int.Parse(txtidTasaCambio.Text);
                        mant_TasaCambio.fecha = dtpFecha.Value;
                        mant_TasaCambio.precioVenta = Decimal.Parse(txtPrecioVenta.Text);
                        mant_TasaCambio.precioCompra = Decimal.Parse(txtPrecioCompra.Text);
                        mant_TasaCambio.estado = chkEstado.Checked;
                        mant_TasaCambio.registro_user_update = "UsuarioPrueba";
                        mant_TasaCambioDataService.updateTasaCambio(mant_TasaCambio);
                        mant_TasaCambio = null;
                        MessageBox.Show("Se Grabó Correctamente", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Globales.Global_MessageBox);
                }
            }
        }

        private void Frm_TasaCambio_Detalle_Load(object sender, EventArgs e)
        {
            try
            {
                if (mant_TasaCambio != null)
                {
                    txtidTasaCambio.Text = mant_TasaCambio.idTasaCambio.ToString();
                    dtpFecha.Text = mant_TasaCambio.fecha.ToString();
                    txtPrecioVenta.Text = mant_TasaCambio.precioVenta.ToString();
                    txtPrecioCompra.Text = mant_TasaCambio.precioCompra.ToString();
                    chkEstado.Checked = mant_TasaCambio.estado;
                    txtPrecioVenta.Focus();
                    dtpFecha.Value.ToShortDateString();
                }
                else
                {
                    chkEstado.Checked = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception (ex.Message);
            }
            
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.ValidarNumeroDecimal(e, txtPrecioVenta.Text,Globales.Global_MessageBox);
        }

        private void txtPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.ValidarNumeroDecimal(e, txtPrecioCompra.Text, Globales.Global_MessageBox);
        }

        private void txtPrecioVenta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
