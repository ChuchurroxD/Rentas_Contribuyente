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
namespace SGR.WinApp.Layout._1_Tablas_Maestras.Periodo
{
    public partial class Frm_Periodo_Detalle : Form
    {
        private Mant_Periodo mant_Periodo;
        private Sistema.Globales.Validaciones obValidacion = new Sistema.Globales.Validaciones();
        public Frm_Periodo_Detalle()
        {
            InitializeComponent();
            DateTime fechaHoy = DateTime.Now;
            txtAnio.Text = fechaHoy.Year.ToString();
            txtAnio.Enabled = true;
            txtUit.MaxLength = 10;
        }
        public Frm_Periodo_Detalle(Mant_Periodo mant_Periodo)
        {
            InitializeComponent();
            txtUit.MaxLength = 10;
            this.mant_Periodo = mant_Periodo;
            if (mant_Periodo != null)
            {
                txtAnio.Enabled = false;
                txtDescripcion.Text = mant_Periodo.Peric_vdescripcion;
                txtAnio.Text = Convert.ToString(mant_Periodo.Peric_canio);
                txtMoraAlcabala.Text = mant_Periodo.Peric_nmoraAlcaba.ToString();
                txtTasaAlacabala.Text = mant_Periodo.Peric_ntasaAlcabala.ToString();
                txtUit.Text = mant_Periodo.Peric_euit.ToString();
                txtUitAlcabala.Text = mant_Periodo.Peric_iuitAlcabala.ToString();
                txtInteres.Text = mant_Periodo.Interes.ToString();
                txtFactorOfi.Text = mant_Periodo.FactorOficilizacion.ToString();
                textBox2.Text = mant_Periodo.MinimoPredio.ToString();
                txtTopeUit.Text = mant_Periodo.TopeUITPension.ToString();
                ckbEstado.Checked = mant_Periodo.Peric_bactivo;
                txtFormulario.Text = mant_Periodo.Formulario.ToString();

            }
        }
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Mant_PeriodoDataService Mant_PeriodoDataService = new Mant_PeriodoDataService();
            int codigo, cantidad;
            try
            {
                if (txtAnio.Text.Trim().Length > 0 && txtUit.Text.Trim().Length > 0 && txtUitAlcabala.Text.Trim().Length > 0
                        && txtMoraAlcabala.Text.Trim().Length > 0 && txtTasaAlacabala.Text.Trim().Length > 0 &&
                         txtInteres.Text.Trim().Length > 0 && txtFactorOfi.Text.Trim().Length > 0
                         && txtFormulario.Text.Trim().Length > 0)
                {
                    Mant_Periodo mant_Periodoo = new Mant_Periodo();
                    mant_Periodoo.Peric_vdescripcion = txtDescripcion.Text.Trim();
                    mant_Periodoo.Peric_canio = Convert.ToInt32(txtAnio.Text);
                    mant_Periodoo.Peric_euit = Convert.ToDecimal(txtUit.Text);
                    mant_Periodoo.Peric_iuitAlcabala = int.Parse(txtUitAlcabala.Text);
                    mant_Periodoo.Peric_nmoraAlcaba = Convert.ToDecimal(txtMoraAlcabala.Text);
                    mant_Periodoo.Peric_ntasaAlcabala = Convert.ToDecimal(txtTasaAlacabala.Text);
                    mant_Periodoo.Interes = Convert.ToDecimal(txtInteres.Text);
                    mant_Periodoo.FactorOficilizacion = Convert.ToDecimal(txtFactorOfi.Text);
                    mant_Periodoo.MinimoPredio = Convert.ToDecimal(textBox2.Text);
                    mant_Periodoo.TopeUITPension = Convert.ToDecimal(txtTopeUit.Text);
                    mant_Periodoo.Peric_bactivo = ckbEstado.Checked;
                    mant_Periodoo.Formulario = Convert.ToDecimal(txtFormulario.Text);
                    if (mant_Periodo == null)//nuevo
                    {
                        if (Convert.ToInt32(txtAnio.Text) <= 2000)
                        {
                            MessageBox.Show("Año Invalido", Globales.Global_MessageBox);
                            return;
                        }
                        cantidad = Mant_PeriodoDataService.GetExisteAnioNuevo(mant_Periodoo.Peric_canio);
                        if (cantidad > 0)
                        {
                            MessageBox.Show("Existe Año", Globales.Global_MessageBox);
                            return;
                        }
                        if (Mant_PeriodoDataService.ExistePeriodoActivoNuevo() > 0 && ckbEstado.Checked)
                        {
                            MessageBox.Show("Ya hay un Periodo Activo", Globales.Global_MessageBox);
                            return;
                        }
                    }
                    else
                    {
                        if (Mant_PeriodoDataService.ExistePeriodoActivoModificar(mant_Periodoo.Peric_canio) > 0 && ckbEstado.Checked)
                        {
                            MessageBox.Show("Ya hay un Periodo Activo", Globales.Global_MessageBox);
                            return;
                        }
                    }
                    if (MessageBox.Show("Desea Grabar?", Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (mant_Periodo == null)
                        {
                            codigo = Mant_PeriodoDataService.Insert(mant_Periodoo);
                            MessageBox.Show("Se Grabó Correctamente", Globales.Global_MessageBox);
                            this.Close();
                        }
                        else
                        {

                            Mant_PeriodoDataService.Update(mant_Periodoo);
                            MessageBox.Show("Se Grabó Correctamente", Globales.Global_MessageBox);
                            mant_Periodo = null;
                            this.Close();
                        }
                    }
                }
                else MessageBox.Show("Falta llenar algún texto", Globales.Global_MessageBox);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtAnio_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.validaNumeroEntero(e, Globales.Global_MessageBox);
        }

        private void txtUit_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.ValidarNumeroDecimal(e, txtUit.Text, Globales.Global_MessageBox);
        }

        private void txtTasaAlacabala_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.ValidarNumeroDecimal(e, txtTasaAlacabala.Text, Globales.Global_MessageBox);
        }

        private void txtUitAlcabala_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.validaNumeroEntero(e, Globales.Global_MessageBox);
        }

        private void txtMoraAlcabala_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.ValidarNumeroDecimal(e, txtMoraAlcabala.Text, Globales.Global_MessageBox);
        }

        private void txtInteres_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.ValidarNumeroDecimal(e, txtInteres.Text, Globales.Global_MessageBox);
        }

        private void txtFactorOfi_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.ValidarNumeroDecimal(e, txtFactorOfi.Text, Globales.Global_MessageBox);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.ValidarNumeroDecimal(e, textBox2.Text, Globales.Global_MessageBox);
        }

        private void txtTopeUit_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.ValidarNumeroDecimal(e, txtTopeUit.Text, Globales.Global_MessageBox);
        }

        private void txtFormulario_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.ValidarNumeroDecimal(e, txtFormulario.Text, Globales.Global_MessageBox);
        }
    }
}
