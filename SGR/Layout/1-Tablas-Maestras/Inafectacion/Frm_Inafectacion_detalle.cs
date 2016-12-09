using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using SGR.Core.Service.Combos;
using SGR.Entity.Model.Combos;
using System.Windows.Forms;
using SGR.Core.Service;
using SGR.Entity.Model;

namespace SGR.WinApp.Layout._1_Tablas_Maestras.Inafectacion
{
    public partial class Frm_Inafectacion_detalle : Form
    {
        private Pago_PersonaDataService persona = new Pago_PersonaDataService();
        private Mant_PeriodoDataService mant_PeriodoDataService = new Mant_PeriodoDataService();
        private Mant_Inafectacion mant_Inafectacion;
        private Mant_InafectacionDataService mant_InafectacionDataService = new Mant_InafectacionDataService();

        public Frm_Inafectacion_detalle()
        {
            InitializeComponent();
        }

        public Frm_Inafectacion_detalle(Mant_Inafectacion mant_Inafectacion)
        {
            InitializeComponent();
            this.mant_Inafectacion = mant_Inafectacion;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBusqueda.Text.TrimEnd().Length != 0)
                {
                    cboPersona.Enabled = true;
                    listarPersona(txtBusqueda.Text.TrimEnd());
                    this.cboPersona.AutoCompleteMode = AutoCompleteMode.Suggest;
                    this.cboPersona.AutoCompleteSource = AutoCompleteSource.CustomSource;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listarPersona(string contribuyente)
        {
            cboPersona.DisplayMember = "persona_Desc";
            cboPersona.ValueMember = "persona_ID";
            cboPersona.DataSource = persona.listarcontribuyentes(contribuyente);
            this.cboPersona.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.cboPersona.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    BtnBuscar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Frm_Inafectacion_detalle_Load(object sender, EventArgs e)
        {
            listarPeriodo();

            if (mant_Inafectacion != null)
            {
                txtBusqueda.Text = mant_Inafectacion.nombre;
                BtnBuscar_Click(sender, EventArgs.Empty);
                cboPeriodo.SelectedValue = mant_Inafectacion.exp_anio;
                txtDescripcion.Text = mant_Inafectacion.exp_descripcion;
                txtObservacion.Text = mant_Inafectacion.observacion;
                txtResolucion.Text = mant_Inafectacion.resolucion;
                chkActivo.Checked = mant_Inafectacion.estado;
            }
            else
            {
                chkActivo.Checked = true;
                chkActivo.Enabled = false;
            }
        }

        private void listarPeriodo()
        {
            cboPeriodo.DisplayMember = "Peric_canio";
            cboPeriodo.ValueMember = "Peric_canio";
            cboPeriodo.DataSource = mant_PeriodoDataService.llenarPeriodo();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtResolucion.Text.Trim().Length <= 0)
                    throw new Exception("Debe ingresar un expediente.");
                if (txtDescripcion.Text.Trim().Length <= 0)
                    throw new Exception("Debe ingresar una descripción.");
                if (txtObservacion.Text.Trim().Length <= 0)
                    throw new Exception("Debe ingresar una observación.");

                if (MessageBox.Show("Desea Grabar?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (mant_Inafectacion == null)
                    {
                        Mant_Inafectacion mant_Inafectacion1 = new Mant_Inafectacion();
                        mant_Inafectacion1.persona_id = cboPersona.SelectedValue.ToString();
                        mant_Inafectacion1.exp_descripcion = txtDescripcion.Text.Trim();
                        mant_Inafectacion1.exp_anio = Convert.ToInt32(cboPeriodo.SelectedValue.ToString());
                        mant_Inafectacion1.resolucion = txtResolucion.Text.Trim();
                        mant_Inafectacion1.observacion = txtObservacion.Text.Trim();
                        mant_Inafectacion1.registro_user_add = GlobalesV1.Global_str_Usuario;
                        mant_Inafectacion1.registro_user_update = GlobalesV1.Global_str_Usuario;
                        mant_Inafectacion1.estado = chkActivo.Checked;
                        mant_InafectacionDataService.Insert(mant_Inafectacion1);
                        MessageBox.Show("Se Grabó Correctamente");
                        this.Close();
                    }
                    else
                    {
                        mant_Inafectacion.persona_id = cboPersona.SelectedValue.ToString();
                        mant_Inafectacion.exp_descripcion = txtDescripcion.Text.Trim();
                        mant_Inafectacion.exp_anio = Convert.ToInt32(cboPeriodo.SelectedValue.ToString());
                        mant_Inafectacion.resolucion = txtResolucion.Text.Trim();
                        mant_Inafectacion.observacion = txtObservacion.Text.Trim();
                        mant_Inafectacion.registro_user_update = GlobalesV1.Global_str_Usuario;
                        mant_Inafectacion.estado = chkActivo.Checked;

                        mant_InafectacionDataService.Update(mant_Inafectacion);
                        MessageBox.Show("Se Grabó Correctamente");
                        mant_Inafectacion = null;
                        this.Close();
                    }
                }
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
    }
}
