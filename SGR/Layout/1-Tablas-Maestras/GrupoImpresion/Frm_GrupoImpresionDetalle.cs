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

namespace SGR.WinApp.Layout._1_Tablas_Maestras.GrupoImpresion
{
    public partial class Frm_GrupoImpresionDetalle : Form
    {
        private Mant_GrupoImpresion mant_GrupoImpresion;
        private Mant_GrupoImpresionDataService Mant_GrupoImprensionDataService = new Mant_GrupoImpresionDataService();
        private Pred_TributoDataService Pred_TributoDataService = new Pred_TributoDataService();
        private Conf_MultitablaDataService Conf_MultiTablaDataService = new Conf_MultitablaDataService();

        public Frm_GrupoImpresionDetalle()
        {
            InitializeComponent();
        }

        public Frm_GrupoImpresionDetalle(Mant_GrupoImpresion mant_GrupoImpresion)
        {
            InitializeComponent();
            this.mant_GrupoImpresion = mant_GrupoImpresion;
        }

        private void Frm_GrupoImpresionDetalle_Load(object sender, EventArgs e)
        {
            try
            {
                llenarperiodo();
                llenarTipoTributo();
                llenarGrupoImpresion();
                if (mant_GrupoImpresion != null)
                {
                    cboGrupoTipoImpresion.SelectedValue = mant_GrupoImpresion.grupoTipoImpresion;
                    cboTipoTributo.SelectedValue = mant_GrupoImpresion.tipo_tributo.Trim();
                    cboPeriodo.SelectedValue = mant_GrupoImpresion.periodo_ID;
                    llenarTodosTributo();
                    cboTributo.SelectedValue = mant_GrupoImpresion.tributo_ID;
                    chkActivo.Checked = mant_GrupoImpresion.estado;
                    cboTributo.Enabled = false;
                    cboGrupoTipoImpresion.Enabled = false;
                    cboTipoTributo.Enabled = false;
                    cboPeriodo.Enabled = false;
                } else
                {
                    llenarTributo();
                    chkActivo.Checked = true;
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void llenarTodosTributo()
        {
            cboTributo.DisplayMember = "descripcion";
            cboTributo.ValueMember = "tributos_ID";
            cboTributo.DataSource = Pred_TributoDataService.listarTributoCbo();
        }
        private void llenarTributo()
        {
            cboTributo.DisplayMember = "descripcion";
            cboTributo.ValueMember = "tributos_ID";
            cboTributo.DataSource = Mant_GrupoImprensionDataService.listarTributoporGrupoImpresion(cboGrupoTipoImpresion.SelectedValue.ToString(), Convert.ToInt32(cboPeriodo.SelectedValue), Convert.ToString(cboTipoTributo.SelectedValue));
        }
        private void llenarGrupoImpresion()
        {
            cboGrupoTipoImpresion.DisplayMember = "Multc_vDescripcion";
            cboGrupoTipoImpresion.ValueMember = "Multc_cValor";
            cboGrupoTipoImpresion.DataSource = Mant_GrupoImprensionDataService.listarGrupoTipoImpresion();
        }
        private void llenarperiodo()
        {
            cboPeriodo.DisplayMember = "Peric_canio";
            cboPeriodo.ValueMember = "Peric_canio";
            cboPeriodo.DataSource = Mant_GrupoImprensionDataService.listarPeriodo();
        }
        private void llenarTipoTributo()
        {
            cboTipoTributo.DisplayMember = "Multc_vDescripcion";
            cboTipoTributo.ValueMember = "Multc_cValor";
            cboTipoTributo.DataSource = Conf_MultiTablaDataService.GetCboConf_Multitabla("1");
        }

        private void cboGrupoTipoImpresion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboPeriodo.SelectedValue != null && cboTipoTributo.SelectedValue != null && cboGrupoTipoImpresion.SelectedValue !=null)
            llenarTributo();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea Grabar?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if(mant_GrupoImpresion == null)
                    {
                        Mant_GrupoImpresion mant_GrupoImpresion = new Mant_GrupoImpresion()
                        {
                            tributo_ID = cboTributo.SelectedValue.ToString(),
                            grupoTipoImpresion = cboGrupoTipoImpresion.SelectedValue.ToString(),
                            estado = chkActivo.Checked,
                            periodo_ID = Convert.ToInt32(cboPeriodo.SelectedValue),
                            tipo_tributo = cboTipoTributo.SelectedValue.ToString(),
                            registro_fecha_add = DateTime.Now,
                            registro_user_add = Globales.UsuarioPrueba,
                            registro_pc_add = Environment.MachineName
                        };
                        Mant_GrupoImprensionDataService.insertar(mant_GrupoImpresion);
                    }else
                    {
                        mant_GrupoImpresion.tributo_ID = cboTributo.SelectedValue.ToString();
                        mant_GrupoImpresion.grupoTipoImpresion = cboGrupoTipoImpresion.SelectedValue.ToString();
                        mant_GrupoImpresion.estado = chkActivo.Checked;
                        mant_GrupoImpresion.periodo_ID = Convert.ToInt32(cboPeriodo.SelectedValue);
                        mant_GrupoImpresion.tipo_tributo = cboTipoTributo.SelectedValue.ToString();
                        mant_GrupoImpresion.registro_fecha_update = DateTime.Now;
                        mant_GrupoImpresion.registro_user_update = Globales.UsuarioPrueba;
                        mant_GrupoImpresion.registro_pc_update = Environment.MachineName;
                        Mant_GrupoImprensionDataService.update(mant_GrupoImpresion);
                    }
                    this.Dispose();
                }
                }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cboPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPeriodo.SelectedValue != null && cboTipoTributo.SelectedValue != null && cboGrupoTipoImpresion.SelectedValue != null)
                llenarTributo();
        }

        private void cboTipoTributo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPeriodo.SelectedValue != null && cboTipoTributo.SelectedValue != null && cboGrupoTipoImpresion.SelectedValue != null)
                llenarTributo();
        }
    }
}
