using SGR.Core.Service;
using SGR.Entity.Model;
using SGR.WinApp.Sistema.Globales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SGR.WinApp.Layout._1_Tablas_Maestras.ValoresArbitrios
{
    public partial class Frm_ValoresArbitrios_Detalle : Form
    {
        Validaciones validaciones = new Validaciones();
        private Mant_ValoresArbitrios mant_ValoresArbitriosp;
        Mant_PeriodoDataService mant_PeriodoDataService = new Mant_PeriodoDataService();
        Mant_TablaArancelDataService mant_TablaArancelDataService = new Mant_TablaArancelDataService();
        public Frm_ValoresArbitrios_Detalle()
        {
            InitializeComponent();
        }
        public Frm_ValoresArbitrios_Detalle(Mant_ValoresArbitrios mant_ValoresArbitrios)
        {
            InitializeComponent();
            this.mant_ValoresArbitriosp = mant_ValoresArbitrios;
        }
        #region Metodos y Funciones
        private bool VerificarCombos()
        {
            if (comboPeriodo.SelectedIndex == -1 ||
                comboTablaArancel.SelectedIndex == -1 )
                return false;
            else
                return true;
        }
        private bool verificarTexto()
        {
            if (txtCosto.Text.Trim().Length == 0 && txtCodificador.Text.Trim().Length == 0
                && txtRecurso.Text.Trim().Length == 0 && txtRubro.Text.Trim().Length == 0)
            {
                return false;
            }
            else
                return true;
        }
        private void llenarcomboPeriodo()
        {
            try
            {
                comboPeriodo.DisplayMember = "Peric_canio";
                comboPeriodo.ValueMember = "Peric_canio";
                comboPeriodo.DataSource = mant_PeriodoDataService.llenarPeriodo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }
        private void llenarcomboTablaArancel()
        {
            try
            {
                comboTablaArancel.DisplayMember = "Descripcion";
                comboTablaArancel.ValueMember = "idTablaArancel";
                comboTablaArancel.DataSource = mant_TablaArancelDataService.llenarcomboTablaArancel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }
        #endregion
        private void Frm_ValoresArbitrios_Detalle_Load(object sender, EventArgs e)
        {
            try
            {
                llenarcomboTablaArancel();
                llenarcomboPeriodo();

                if (mant_ValoresArbitriosp != null)
                {
                    txtCodigoOculto.Text = mant_ValoresArbitriosp.idValoresArbitrio.ToString();
                    txtCodificador.Text = mant_ValoresArbitriosp.idCodificador.ToString();
                    comboPeriodo.Text = mant_ValoresArbitriosp.idPeriodo.ToString();
                    comboTablaArancel.Text = mant_ValoresArbitriosp.descripcionTablaArancel;
                    txtCosto.Text = mant_ValoresArbitriosp.Costo.ToString();
                    txtRecurso.Text = mant_ValoresArbitriosp.Recurso.ToString();
                    txtRubro.Text = mant_ValoresArbitriosp.Rubro.ToString();
                    chkEstado.Checked = mant_ValoresArbitriosp.Estado;
                }
                else
                {
                    DateTime fechaHoy = DateTime.Now;
                    comboPeriodo.SelectedValue = Convert.ToInt32(fechaHoy.Year.ToString());
                    chkEstado.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validaciones.ValidarNumeroDecimal(e, txtCosto.Text, "Ingresar Valor Valido");
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            Mant_ValoresArbitriosDataService mant_ValoresArbitriosDataService = new Mant_ValoresArbitriosDataService();
            Mant_ValoresArbitrios mant_ValoresArbitrios = new Mant_ValoresArbitrios();
            try
            {
                if (VerificarCombos() && verificarTexto())
                {
                    MessageBox.Show("¿Esta seguro que Desea Grabar?", Globales.Global_MessageBox, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (txtCodigoOculto.Text.Length == 0)
                    {
                        mant_ValoresArbitrios.idPeriodo = int.Parse(comboPeriodo.Text);
                        mant_ValoresArbitrios.Costo = Decimal.Parse(txtCosto.Text.Trim());
                        mant_ValoresArbitrios.idTablaArancel = int.Parse(comboTablaArancel.SelectedValue.ToString());
                        mant_ValoresArbitrios.idCodificador = txtCodificador.Text;
                        mant_ValoresArbitrios.Rubro = txtRubro.Text;
                        mant_ValoresArbitrios.Recurso = txtRecurso.Text;
                        mant_ValoresArbitrios.Estado = chkEstado.Checked;
                        mant_ValoresArbitrios.registro_user_add = "UsuarioPrueba";
                        mant_ValoresArbitriosDataService.Insert(mant_ValoresArbitrios);
                        MessageBox.Show("Se Registro Correctamente", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        Mant_ValoresArbitrios mant_ValoresArbitrios1 = new Mant_ValoresArbitrios();
                        mant_ValoresArbitrios1.idValoresArbitrio = int.Parse(txtCodigoOculto.Text);
                        mant_ValoresArbitrios1.idPeriodo = int.Parse(comboPeriodo.Text);
                        mant_ValoresArbitrios1.Costo = Decimal.Parse(txtCosto.Text.Trim());
                        mant_ValoresArbitrios1.idTablaArancel = int.Parse(comboTablaArancel.SelectedValue.ToString());
                        mant_ValoresArbitrios1.idCodificador = txtCodificador.Text;
                        mant_ValoresArbitrios1.Rubro = txtRubro.Text;
                        mant_ValoresArbitrios1.Recurso = txtRecurso.Text;
                        mant_ValoresArbitrios1.Estado = chkEstado.Checked;
                        mant_ValoresArbitrios1.registro_user_add = "UsuarioPrueba";
                        mant_ValoresArbitriosDataService.Update(mant_ValoresArbitrios1);
                        mant_ValoresArbitrios1 = null;
                        MessageBox.Show("Se Modifico Correctamente", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Ingresar los Datos Correctamente", Globales.Global_MessageBox);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Globales.Global_MessageBox);
            }
        }
    }
}
