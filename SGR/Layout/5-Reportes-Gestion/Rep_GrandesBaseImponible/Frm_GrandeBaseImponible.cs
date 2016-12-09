using SGR.Core.Service;
using SGR.Entity.Model;
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

namespace SGR.WinApp.Layout._5_Reportes_Gestion.Rep_GrandesBaseImponible
{
    public partial class Frm_GrandeBaseImponible : DockContent
    {
        Mant_PeriodoDataService mant_PeriodoDataService = new Mant_PeriodoDataService();
        Repo_GrandesBasesImponiblesDataService repo_GrandesBasesImponiblesDataService = new Repo_GrandesBasesImponiblesDataService();
        List<Repo_GrandesBasesImponibles> coleccion = new List<Repo_GrandesBasesImponibles>();

        public Frm_GrandeBaseImponible()
        {
            InitializeComponent();
        }

        private void Frm_GrandeBaseImponible_Load(object sender, EventArgs e)
        {
            llenarcomboPeriodo();
        }

        private void llenarcomboPeriodo()
        {
            try
            {
                cboHasta.DisplayMember = "Peric_canio";
                cboHasta.ValueMember = "Peric_canio";
                cboHasta.DataSource = mant_PeriodoDataService.llenarPeriodo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (txtNumero.Text.Trim().Length <= 0)
                    throw new Exception("Llenar top de predios con mayores bases imponibles.");
                dgReporte.DataSource = repo_GrandesBasesImponiblesDataService.generarReporte((Int32)cboHasta.SelectedValue, Convert.ToInt32(txtNumero.Text.Trim()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                if (txtNumero.Text.Trim().Length <= 0)
                    throw new Exception("Llenar top de predios con mayores bases imponibles.");

                dgReporte.DataSource = repo_GrandesBasesImponiblesDataService.generarReporte((Int32)cboHasta.SelectedValue, Convert.ToInt32(txtNumero.Text.Trim()));
                coleccion = repo_GrandesBasesImponiblesDataService.generarReporte((Int32)cboHasta.SelectedValue, Convert.ToInt32(txtNumero.Text.Trim()));

                frmVisor.reportViewer1.LocalReport.DataSources.Clear();
                frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._5_Reportes_Gestion.Rep_GrandesBaseImponible.rptGrandesBasesImponibles.rdlc";
                frmVisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsGrandesBasesImponibles", coleccion));

                ReportParameter[] paramsx = new ReportParameter[2];
                paramsx[0] = new ReportParameter("FechaImpresion", DateTime.Today.ToString());
                paramsx[1] = new ReportParameter("Usuario", GlobalesV1.Global_str_Nombre);
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
