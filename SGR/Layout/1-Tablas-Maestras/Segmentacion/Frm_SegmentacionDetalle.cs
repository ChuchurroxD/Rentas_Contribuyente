using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGR.Entity.Model;
using SGR.Core.Service;
namespace SGR.WinApp.Layout._1_Tablas_Maestras.Segmentacion
{
    public partial class Frm_SegmentacionDetalle : Form
    {
        private Sistema.Globales.Validaciones obValidacion = new Sistema.Globales.Validaciones();
        Mant_SegmentacionDataService SegmentacionDataService = new Mant_SegmentacionDataService();
        Mant_Segmentacion Segmentacion= new Mant_Segmentacion();
        String usser = GlobalesV1.Global_str_Usuario;
        public Frm_SegmentacionDetalle(string periodo)
        {
            InitializeComponent();
            txtPeriodo.Text = periodo;
        }

        public Frm_SegmentacionDetalle(Mant_Segmentacion Segmentacionn)
        {
            this.Segmentacion = Segmentacionn;
            InitializeComponent();
            txtPeriodo.Text = Segmentacion.periodo_id.ToString();
            txtDescripcion.Text = Segmentacion.descripcion;
            txtMontoFin.Text = Segmentacion.monto_fin.ToString();
            txtMontoInicio.Text = Segmentacion.monto_inicio.ToString();
            ckbEstado.Checked = Segmentacion.estado;
            if (Convert.ToInt32(Segmentacion.tipo) == 1)
            {
                rbtAbono.Checked = true;
            }
            else
                rbtCargo.Checked = true;

        }
        private string verificarDato(string dato)
        {
            lblMontoFin.ForeColor = System.Drawing.Color.Black;
            lblMontoInicio.ForeColor = System.Drawing.Color.Black;
            lblPeriodo.ForeColor = System.Drawing.Color.Black;
            if (txtMontoFin.Text.Length == 0)
            {
                dato = dato + "Falta Monto Fin,";
                lblMontoFin.ForeColor = System.Drawing.Color.Red;
            }
            if (txtMontoInicio.Text.Length == 0)
            {
                dato = dato + "Falta Monto Inicio,";
                lblMontoInicio.ForeColor = System.Drawing.Color.Red;
            }
            if (txtPeriodo.Text.Length == 0)
            {
                dato = dato + "Falta Periodo";
                lblPeriodo.ForeColor = System.Drawing.Color.Red;
            }
            return dato;
        }
        private void btnGrabar_Click(object sender, EventArgs e)
        {

            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                string dato = verificarDato("");
                if (Convert.ToDecimal(txtMontoFin.Text) <= Convert.ToDecimal(txtMontoInicio.Text))
                {
                    MessageBox.Show("El Monto Final debe ser mayor que el monto Inicial", Globales.Global_MessageBox); ;
                    return;
                }
                if (dato.Trim().Length == 0)
                {
                    if (MessageBox.Show("Desea Grabar?", Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Segmentacion.descripcion = txtDescripcion.Text;
                        Segmentacion.estado = ckbEstado.Checked;
                        Segmentacion.monto_fin = Convert.ToDecimal(txtMontoFin.Text);
                        Segmentacion.monto_inicio = Convert.ToDecimal(txtMontoInicio.Text);
                        Segmentacion.periodo_id = Convert.ToInt32(txtPeriodo.Text);
                        Segmentacion.registro_user_add = usser;
                        Segmentacion.registro_user_update = usser;
                        if (rbtAbono.Checked)
                            Segmentacion.tipo = 1;
                        else if (rbtCargo.Checked)
                            Segmentacion.tipo = 2;
                        else
                            Segmentacion.tipo = 3;
                        if (Segmentacion.segmentacion_id == 0)
                        {
                            if (SegmentacionDataService.Insert(Segmentacion) > 0)
                                {
                                    MessageBox.Show("Se Grabó Correctamente", Globales.Global_MessageBox);
                                }

                            this.Close();

                        }
                        else
                        {
                            SegmentacionDataService.Update(Segmentacion);
                            MessageBox.Show("Se Grabó Correctamente", Globales.Global_MessageBox);
                            Segmentacion = null;
                            this.Close();
                        }
                    }
                }
                else
                    MessageBox.Show(dato, Globales.Global_MessageBox);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtMontoInicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.ValidarNumeroDecimal(e, txtMontoInicio.Text, Globales.Global_MessageBox);
        }

        private void txtMontoFin_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.ValidarNumeroDecimal(e, txtMontoFin.Text, Globales.Global_MessageBox);
        }
    }
}
