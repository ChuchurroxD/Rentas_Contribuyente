using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGR.Core.Service;
using SGR.Core;
using SGR.Entity.Model;
using SGR.Entity;
using WeifenLuo.WinFormsUI.Docking;
using SGR.Core.Service.Combos;
using SGR.WinApp.Layout._5_Reportes_Gestion;
using Microsoft.Reporting.WinForms;
using SGR.WinApp.Layout._1_Tablas_Maestras.Contribuyente;

namespace SGR.WinApp.Layout._4_Procesos.Coactivo
{
    public partial class Frm_ExpedienteCoactivo : Form
    {

        Pago_PersonaDataService persona = new Pago_PersonaDataService();
        Mant_PeriodoDataService Mant_PeriodoDataService = new Mant_PeriodoDataService();
        Conf_MultitablaDataService conf_MultitablaDataService = new Conf_MultitablaDataService();
        Coa_expediente_coactivoDataService coa_expediente_coactivoDataService = new Coa_expediente_coactivoDataService();
        Coa_coactivo_ctaDataService Coa_coactivo_ctaDataService = new Coa_coactivo_ctaDataService();
        public Frm_ExpedienteCoactivo()
        {
            try
            {

                InitializeComponent();
                cboTipo.DisplayMember = "Multc_vDescripcion";
                cboTipo.ValueMember = "Multc_cValor";
                cboTipo.DataSource = conf_MultitablaDataService.GetCboConf_Multitabla("1");
                txtAnio.Text = Mant_PeriodoDataService.GetPeriodoActivo().ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), Globales.Global_MessageBox);
            }
        }
        private string Verificar(string dato)
        {

            lblTipo.ForeColor = System.Drawing.Color.Black;
            lblNroResolucion.ForeColor = System.Drawing.Color.Black;
            lblNroFolios.ForeColor = System.Drawing.Color.Black;
            lblExpediente.ForeColor = System.Drawing.Color.Black;
            if (dataGridView1.SelectedRows.Count == 0)
            {
                dato = dato + "Contribuyente, ";
            }
            if (cboTipo.SelectedIndex == -1)
            {
                dato = dato + "Tipo, ";
                lblTipo.ForeColor = System.Drawing.Color.Red;
            }
            if (txtExpedienteAnio.Text.Trim().Length == 0)
            {
                dato = dato + "Anio de Expediente, ";
                lblExpediente.ForeColor = System.Drawing.Color.Red;
            }
            if (txtExpedienteN.Text.Trim().Length == 0)
            {
                dato = dato + "Nro de Expediente, ";
                lblExpediente.ForeColor = System.Drawing.Color.Red;
            }
            if (txtNroFolios.Text.Trim().Length == 0)
            {
                dato = dato + "Nro de Folio, ";
                lblNroFolios.ForeColor = System.Drawing.Color.Red;
            }
            if (txtNroResolucio.Text.Trim().Length == 0)
            {
                dato = dato + "Nro de Resolución,";
                lblNroResolucion.ForeColor = System.Drawing.Color.Red;
            }
            return dato;
        }
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                string dato = Verificar("");
                if (dato.Trim().Length != 0)
                {
                    MessageBox.Show("Falta " + dato, Globales.Global_MessageBox);
                    return;
                }
                Coa_expediente_coactivo expediente_coactivo = new Coa_expediente_coactivo();
                expediente_coactivo.anio_expediente = Convert.ToInt32(txtExpedienteAnio.Text);
                expediente_coactivo.descripcion_exp = txtExpedienteN.Text.TrimEnd();
                expediente_coactivo.tipo_exp = Convert.ToInt16(cboTipo.SelectedValue);
                expediente_coactivo.nro_resolucion = txtNroResolucio.Text.TrimEnd();
                expediente_coactivo.fecha_emision = dtpFecha.Value;
                expediente_coactivo.folios = Convert.ToInt32(txtNroFolios.Text);
                expediente_coactivo.observacion = txtObservacion.Text.TrimEnd();
                expediente_coactivo.coactivo_cta_ID = (int)dataGridView1.SelectedRows[0].Cells["coactivo_cta_ID"].Value;
                coa_expediente_coactivoDataService.Insert(expediente_coactivo);
                MessageBox.Show("Se grabó correctamente", Globales.Global_MessageBox);
                this.Dispose();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), Globales.Global_MessageBox);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int anio = 0;
                if (txtAnio.Text.Trim().Length > 0)
                {

                    anio = Convert.ToInt32(txtAnio.Text);
                }
                else
                    MessageBox.Show("Falta año", Globales.Global_MessageBox);
                string cod_persona = "%";
                if (txtCodPersona.Text.Trim().Length > 0)
                {
                    cod_persona = txtCodPersona.Text;
                }
                string namepersona = "%";
                if (txtRazonSocial.Text.Trim().Length > 0)
                {
                    namepersona = txtRazonSocial.Text;
                }
                dataGridView1.DataSource = Coa_coactivo_ctaDataService.listartodos(anio, namepersona, cod_persona);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), Globales.Global_MessageBox);
            }
        }
    }
}
