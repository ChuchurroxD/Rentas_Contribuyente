using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGR.Entity;
using SGR.Entity.Model;
using SGR.Core.Service;
using SGR.WinApp.Layout._5_Reportes_Gestion;
using Microsoft.Reporting.WinForms;
using System.IO;

namespace SGR.WinApp.Layout._4_Procesos.Plataforma.ConsultarPlataforma
{
    public partial class Frm_EstadoDeudas : Form
    {
        private string persona_ID;
        private Pago_CuentaCorrienteDataService Pago_CuentaCorrienteDataService = new Pago_CuentaCorrienteDataService();
        private Mant_PeriodoDataService Mant_PeriodoDataService = new Mant_PeriodoDataService();
        private Pred_TributoDataService Pred_TributoDataService = new Pred_TributoDataService();
        private List<Pago_CuentaCorriente> coleccion = new List<Pago_CuentaCorriente>();       


        public Frm_EstadoDeudas()
        {
            InitializeComponent();
        }


        public Frm_EstadoDeudas(string persona_ID)
        {
            this.persona_ID = persona_ID;
            InitializeComponent();
            listarPeriodo();
            llenarComboTributo();
            cboPeriodo.SelectedValue = Mant_PeriodoDataService.GetPeriodoActivo();
            //var coleccion = new List<Pred_PredioContribuyente>();
            //coleccion = Pred_PredioContribuyenteDataService.listarPorPeriodoContribuyente(Convert.ToInt32(cboPeriodo.SelectedValue), persona_ID);
            //dataGridView1.AutoGenerateColumns = false;
            //dataGridView1.DataSource = coleccion;
        }

        private void listarPeriodo()
        {
            cboPeriodo.DisplayMember = "Peric_vdescripcion";
            cboPeriodo.ValueMember = "Peric_canio";
            cboPeriodo.DataSource = Mant_PeriodoDataService.listarCboPeriodov2();
        }

        private void llenarComboTributo()
        {
            cboTributo.DisplayMember = "tributo";
            cboTributo.ValueMember = "tributo_ID";
            cboTributo.DataSource = Pred_TributoDataService.listarTributoCbov2(persona_ID);
        }

        private void Frm_EstadoDeudas_Load(object sender, EventArgs e)
        {
            try
            {
                listarPeriodo();
                llenarComboTributo();
                lblDeuda.Text = "La deuda mostrada es la Generada a la fecha : " + DateTime.Now.ToShortDateString();
                //this.reportViewer1.RefreshReport();
                coleccion = Pago_CuentaCorrienteDataService.estadoDeuda(persona_ID);
                dataGridView1.DataSource = coleccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }                        
        }

        private void cboPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            coleccion = Pago_CuentaCorrienteDataService.estadoDeudaTributos(persona_ID, Convert.ToString(cboTributo.SelectedValue), Convert.ToInt32(cboPeriodo.SelectedValue));
            dataGridView1.DataSource = coleccion;
        }

        private void cboTributo_SelectedIndexChanged(object sender, EventArgs e)
        {
            coleccion = Pago_CuentaCorrienteDataService.estadoDeudaTributos(persona_ID, Convert.ToString(cboTributo.SelectedValue), Convert.ToInt32(cboPeriodo.SelectedValue));
            dataGridView1.DataSource = coleccion;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
       
            try
            {
                string anio = "";
                if (Convert.ToInt32(cboPeriodo.SelectedValue) == 0)
                    anio = "TODOS";
                else
                    anio = cboPeriodo.SelectedValue.ToString();
                Liqu_TributosAfectos Pred_Tri = new Liqu_TributosAfectos();
                Pred_Tri = (Liqu_TributosAfectos)cboTributo.SelectedItem;
                coleccion = Pago_CuentaCorrienteDataService.estadoDeudaTributos(persona_ID, Convert.ToString(cboTributo.SelectedValue), Convert.ToInt32(cboPeriodo.SelectedValue));
                Frm_Visor_Global frmVisor = new Frm_Visor_Global();
                frmVisor.reportViewer1.LocalReport.DataSources.Clear();
                frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._4_Procesos.Plataforma.ConsultarPlataforma.Rep_EstadoCuenta.rdlc";
                frmVisor.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", coleccion));

                ReportParameter[] paramsx = new ReportParameter[2];
                paramsx[0] = new ReportParameter("Anio",anio);
                paramsx[1] = new ReportParameter("Tributo", Pred_Tri.tributo);
                frmVisor.reportViewer1.LocalReport.SetParameters(paramsx);

                frmVisor.reportViewer1.RefreshReport();
                frmVisor.StartPosition = FormStartPosition.CenterParent;
                frmVisor.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
