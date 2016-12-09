using SGR.Core.Service;
using SGR.Entity.Model;
using SGR.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using Microsoft.Reporting.WinForms;
using SGR.WinApp.Layout._5_Reportes_Gestion;

namespace SGR.WinApp.Layout._5_Reportes_Gestion.Rep_PorcentajePredio
{
    public partial class Frm_PorcentajePredios : DockContent
    {
        Mant_PeriodoDataService mant_PeriodoDataService = new Mant_PeriodoDataService();
        Repo_PorcentajePrediosDataService repo_PorcentajePrediosDataService = new Repo_PorcentajePrediosDataService();
        List<Repo_PorcentajePredios> coleccion = new List<Repo_PorcentajePredios>();

        public Frm_PorcentajePredios()
        {
            InitializeComponent();
        }

        private void Frm_PorcentajePredios_Load(object sender, EventArgs e)
        {
            llenarcomboPeriodo();
            rbtRusticoUrbano.Checked = true;
        }

        private void llenarcomboPeriodo()
        {
            try
            {
                cboDesde.DisplayMember = "Peric_canio";
                cboDesde.ValueMember = "Peric_canio";
                cboDesde.DataSource = mant_PeriodoDataService.llenarPeriodo();

                cboHasta.DisplayMember = "Peric_canio";
                cboHasta.ValueMember = "Peric_canio";
                cboHasta.DataSource = mant_PeriodoDataService.llenarPeriodo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void botonGenerarReporte_Click(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            Frm_Visor_Global frmVisor = new Frm_Visor_Global();
            try
            {
                if (rbtRusticoUrbano.Checked == true)
                {
                    coleccion = repo_PorcentajePrediosDataService.listarPorcentaje(Convert.ToInt32(cboDesde.SelectedValue.ToString()), Convert.ToInt32(cboHasta.SelectedValue.ToString()));//(Int32)cboHasta.SelectedValue, Convert.ToInt32(txtNumero.Text.Trim()));

                    frmVisor.reportViewer1.LocalReport.DataSources.Clear();
                    frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._5_Reportes_Gestion.Rep_PorcentajePredio.rptPorcentajePredios.rdlc";
                    frmVisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", coleccion));
                }
                if (rbtClasiDepreciacion.Checked == true)
                {
                    coleccion = repo_PorcentajePrediosDataService.listarPorcentaje2(Convert.ToInt32(cboDesde.SelectedValue.ToString()), Convert.ToInt32(cboHasta.SelectedValue.ToString()));//(Int32)cboHasta.SelectedValue, Convert.ToInt32(txtNumero.Text.Trim()));

                    frmVisor.reportViewer1.LocalReport.DataSources.Clear();
                    frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._5_Reportes_Gestion.Rep_PorcentajePredio.rptPorcentajeClasificacion.rdlc";
                    frmVisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsPorcentajePredio", coleccion));
                }
                ReportParameter[] paramsx = new ReportParameter[4];
                paramsx[0] = new ReportParameter("FechaImpresion", DateTime.Today.ToString());
                paramsx[1] = new ReportParameter("Usuario", GlobalesV1.Global_str_Nombre);
                paramsx[2] = new ReportParameter("anioDesde", cboDesde.SelectedValue.ToString());
                paramsx[3] = new ReportParameter("anioHasta", cboHasta.SelectedValue.ToString());

                frmVisor.reportViewer1.LocalReport.SetParameters(paramsx);

                frmVisor.reportViewer1.RefreshReport();
                frmVisor.StartPosition = FormStartPosition.CenterParent;
                frmVisor.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
