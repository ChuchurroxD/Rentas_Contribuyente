using SGR.Core.Service;
using SGR.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SGR.WinApp.Layout._1_Tablas_Maestras.ParametroMes
{
    public partial class Frm_ParametroMes_Detalle : Form
    {
        private Mant_ParametroMes mant_ParametroMes;
        Mant_PeriodoDataService mant_PeriodoDataService = new Mant_PeriodoDataService();
        Conf_MultitablaDataService conf_MultitablaDataService = new Conf_MultitablaDataService();
        Mant_ParametroMesDataService mant_ParametroMesDataService = new Mant_ParametroMesDataService();
        public Frm_ParametroMes_Detalle()
        {
            InitializeComponent();
        }
        public Frm_ParametroMes_Detalle(Mant_ParametroMes mant_ParametroMes)
        {
            InitializeComponent();
            this.mant_ParametroMes = mant_ParametroMes;
        }
        private void Frm_ParametroMes_Detalle_Load(object sender, EventArgs e)
        {
            try
            {
                llenarComboTipo();
                llenarcomboPeriodo();
                if (mant_ParametroMes != null)
                {
                    txtParametroMesID.Text = mant_ParametroMes.parametro_mes_ID.ToString();
                    txtMes.Text = mant_ParametroMes.mes.ToString(); 
                    comboPeriodo.Text = mant_ParametroMes.periodo_id.ToString();
                    comboTipo.SelectedValue = mant_ParametroMes.tipo.ToString();
                    dtpFechaEmision.Value = mant_ParametroMes.fecha_emision;
                    dtpFechaVencimiento.MinDate = dtpFechaEmision.Value;
                    dtpFechaVencimiento.Value = mant_ParametroMes.fecha_vence;
                    chkEstado.Checked = mant_ParametroMes.estado;
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

        private void botonGrabar_Click(object sender, EventArgs e)
        {
            Mant_ParametrosDataService mant_ParametrosDataService = new Mant_ParametrosDataService();
            Mant_ParametroMes mant_ParametroMes = new Mant_ParametroMes();
            try
            {
                if (VerificarCombos() && verificarDiferenteCero() && ValidarMes())
                {
                    MessageBox.Show("¿Esta seguro que desea Guardar?", Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (txtParametroMesID.Text.Length == 0) //Es nuevo ?
                    {
                        mant_ParametroMes.periodo_id = short.Parse(comboPeriodo.Text);
                        mant_ParametroMes.tipo = Convert.ToInt32(comboTipo.SelectedValue);
                        mant_ParametroMes.mes = short.Parse(txtMes.Text.Trim());
                        mant_ParametroMes.fecha_emision = DateTime.Parse(dtpFechaEmision.Text);
                        mant_ParametroMes.fecha_vence = DateTime.Parse(dtpFechaVencimiento.Text);
                        mant_ParametroMes.estado = chkEstado.Checked;
                        mant_ParametroMes.registro_user_add = "UsuarioPrueba";
                        if (mant_ParametroMesDataService.VerificaMes(mant_ParametroMes) > 0)
                        {
                            MessageBox.Show("Datos Existentes");
                            return;
                        }
                        mant_ParametroMesDataService.Insert(mant_ParametroMes);
                        MessageBox.Show("Se Registro Correctamente", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        Mant_ParametroMes mant_ParametroMes1 = new Mant_ParametroMes();
                        mant_ParametroMes1.parametro_mes_ID = int.Parse(txtParametroMesID.Text);
                        mant_ParametroMes1.periodo_id = short.Parse(comboPeriodo.Text);
                        mant_ParametroMes1.tipo = Convert.ToInt32(comboTipo.SelectedValue);
                        mant_ParametroMes1.mes = short.Parse(txtMes.Text.Trim());
                        mant_ParametroMes1.fecha_emision = DateTime.Parse(dtpFechaEmision.Text);
                        mant_ParametroMes1.fecha_vence = DateTime.Parse(dtpFechaVencimiento.Text);
                        mant_ParametroMes1.estado = chkEstado.Checked;
                        mant_ParametroMes1.registro_user_update = "UsuarioPrueba";
                        if (mant_ParametroMesDataService.VerificarModificarMes(mant_ParametroMes1) > 0)
                        {
                            MessageBox.Show("Datos Existentes");
                            return;
                        }
                        mant_ParametroMesDataService.Update(mant_ParametroMes1);
                        mant_ParametroMes1 = null;
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

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #region Metodos y Funciones
        private bool VerificarCombos()
        {
            if (comboPeriodo.SelectedIndex == -1 ||
                comboTipo.SelectedIndex == -1 )
                return false;
            else
                return true;
        }
        
        private bool verificarDiferenteCero()
        {
            Boolean control = true;

            if (txtMes.Text == "0")
            {
                MessageBox.Show("No se Permite Mes Cero. Ingrese Mes Valido", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                control = false;
            }

            return control;
        }
        private void llenarcomboPeriodo()
        {
            try
            {
                comboPeriodo.DisplayMember = "Peric_canio";
                comboPeriodo.ValueMember = "Peric_canio";
                comboPeriodo.DataSource = mant_PeriodoDataService.llenarPeriodo();
                comboPeriodo.SelectedValue = 2016;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void llenarComboTipo()
        {
            try
            {
                comboTipo.DisplayMember = "Multc_vDescripcion";
                comboTipo.ValueMember = "Multc_cValor";
                comboTipo.DataSource = conf_MultitablaDataService.GetCboConf_Multitabla("77");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool ValidarMes()
        {
            Boolean control = true;
            int mes;
            mes = Int32.Parse(txtMes.Text);
            if (mes < 1 || mes > 12)
            {
                MessageBox.Show("Ingresar Mes Valido : 1 al 12", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                control = false;
            }
            return control;
        }
        #endregion

        private void dtpFechaEmision_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaVencimiento.MinDate = dtpFechaEmision.Value;
        }

        private void comboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}