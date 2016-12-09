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

namespace SGR.WinApp.Layout._4_Procesos.Predio.Segmentacion
{
    public partial class Frm_Segmentacion_Detalle : Form
    {
        Pago_PersonaDataService persona = new Pago_PersonaDataService();
        Pred_Segmentacion_ContribuyenteDataService Segmentacion_ContribuyenteDataService = new Pred_Segmentacion_ContribuyenteDataService();
        private Conf_MultitablaDataService conf_MultitablaDataService = new Conf_MultitablaDataService();
        Pred_Segmentacion_Contribuyente Segmentacion_Contribuyente= new Pred_Segmentacion_Contribuyente();
        String usser = "nada";
        public Frm_Segmentacion_Detalle()
        {
            InitializeComponent();
            try
            {
                llenarTipoPersona();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, Globales.Global_MessageBox);
            }
        }
        public Frm_Segmentacion_Detalle(Pred_Segmentacion_Contribuyente Pred_Segmentacion_Contribuyente)
        {
            InitializeComponent();
            try
            {
                llenarTipoPersona();
                cboPersona.SelectedValue = Pred_Segmentacion_Contribuyente.persona_id;
                cboSegmentacion.SelectedValue = Pred_Segmentacion_Contribuyente.segmentacion_id;
                ckbEstado.Checked = Pred_Segmentacion_Contribuyente.estado;
                Segmentacion_Contribuyente.segmentacion_contribuyente_id = Pred_Segmentacion_Contribuyente.segmentacion_contribuyente_id;
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, Globales.Global_MessageBox);
            }
        }
        private void llenarTipoPersona()
        {
            cboSegmentacion.DisplayMember = "Multc_vDescripcion";
            cboSegmentacion.ValueMember = "Multc_cValor";
            cboSegmentacion.DataSource = conf_MultitablaDataService.GetCboConf_Multitabla("1");
        }
        private String Verificadato(string dato)
        {
            lblPersona.ForeColor = System.Drawing.Color.Black;
            lblSegmentacion.ForeColor = System.Drawing.Color.Black;
            if (cboSegmentacion.SelectedIndex == -1)
            {
                lblSegmentacion.ForeColor = System.Drawing.Color.Red;
                dato = dato + "Falta Segmentación, ";
            }
            if (cboPersona.SelectedIndex == -1 || cboPersona.SelectedIndex == 0)
            {
                lblPersona.ForeColor = System.Drawing.Color.Red;
                dato = dato + "Falta Persona";
            }
            return dato;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                String elementofaltante = Verificadato("");
                if (elementofaltante.Length != 0)
                {
                    MessageBox.Show(elementofaltante, Globales.Global_MessageBox);
                    return;
                }
                if (MessageBox.Show("Desea Grabar?", Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Segmentacion_Contribuyente.persona_id = cboPersona.SelectedValue.ToString();
                    Segmentacion_Contribuyente.segmentacion_id = Convert.ToInt32(cboSegmentacion.SelectedValue);
                    Segmentacion_Contribuyente.registro_user_add = usser;
                    Segmentacion_Contribuyente.registro_user_update = usser;
                    Segmentacion_Contribuyente.estado = ckbEstado.Checked;
                    if (Segmentacion_Contribuyente.segmentacion_contribuyente_id != 0)//nuevo
                    {
                        Segmentacion_ContribuyenteDataService.Update(Segmentacion_Contribuyente);
                        MessageBox.Show("Se grabó correctamente", Globales.Global_MessageBox);
                    }
                    else
                    {
                        Segmentacion_ContribuyenteDataService.Insert(Segmentacion_Contribuyente);
                        MessageBox.Show("Se grabó correctamente", Globales.Global_MessageBox);
                    }
                    this.Dispose();

                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, Globales.Global_MessageBox);
            }            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBusqueda.Text.TrimEnd().Length != 0)
                {
                    cboPersona.Enabled = true;
                    cboPersona.DisplayMember = "persona_Desc";
                    cboPersona.ValueMember = "persona_ID";
                    cboPersona.DataSource = persona.listarcontribuyentes(txtBusqueda.Text.TrimEnd());
                    this.cboPersona.AutoCompleteMode = AutoCompleteMode.Suggest;
                    this.cboPersona.AutoCompleteSource = AutoCompleteSource.CustomSource;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
