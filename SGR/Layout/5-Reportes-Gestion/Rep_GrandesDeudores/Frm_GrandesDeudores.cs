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

namespace SGR.WinApp.Layout._5_Reportes_Gestion.Rep_GrandesDeudores
{
    public partial class Frm_GrandesDeudores : DockContent
    {
        Mant_PeriodoDataService mant_PeriodoDataService = new Mant_PeriodoDataService();
        Pred_SectorDataService pred_SectorDataService = new Pred_SectorDataService();
        Valo_ValoresCobranzaDataService valo_ValoresCobranzaDataService = new Valo_ValoresCobranzaDataService();
        List<RepoGrandesDeudores> coleccion = new List<RepoGrandesDeudores>();

        public Frm_GrandesDeudores()
        {
            InitializeComponent();
        }

        private void Frm_GrandesDeudores_Load(object sender, EventArgs e)
        {
            llenarcomboPeriodo();
            llenarcomboSector();
            //dgReporte.DataSource = valo_ValoresCobranzaDataService.listarGrandesDeudores((Int32)cboSector.SelectedValue, (Int32)cboDesde.SelectedValue,(Int32)cboHasta.SelectedValue, 50);           
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

        private void llenarcomboSector()
        {
            try
            {
                cboSector.ValueMember = "sector_id";
                cboSector.DisplayMember = "descripcion";
                cboSector.DataSource = pred_SectorDataService.listarSectorCboValidos();
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
                dgReporte.DataSource = valo_ValoresCobranzaDataService.listarGrandesDeudores((Int32)cboSector.SelectedValue, (Int32)cboDesde.SelectedValue, (Int32)cboHasta.SelectedValue, Convert.ToInt32(txtNumero.Text.Trim()));
                coleccion = valo_ValoresCobranzaDataService.listarGrandesDeudores((Int32)cboSector.SelectedValue, (Int32)cboDesde.SelectedValue, (Int32)cboHasta.SelectedValue, Convert.ToInt32(txtNumero.Text.Trim()));

                frmVisor.reportViewer1.LocalReport.DataSources.Clear();
                frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._5_Reportes_Gestion.Rep_GrandesDeudores.rptGrandeDeudores.rdlc";
                frmVisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsRepoGrandesDeudores", coleccion));

                ReportParameter[] paramsx = new ReportParameter[3];
                paramsx[0] = new ReportParameter("FechaImpresion", DateTime.Today.ToString());
                paramsx[1] = new ReportParameter("Usuario", GlobalesV1.Global_str_Nombre);
                paramsx[2] = new ReportParameter("Sector", cboSector.Text);
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

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (txtNumero.Text.Trim().Length <= 0)
                    throw new Exception("Llenar número de deudores.");
                dgReporte.DataSource = valo_ValoresCobranzaDataService.listarGrandesDeudores((Int32)cboSector.SelectedValue, (Int32)cboDesde.SelectedValue, (Int32)cboHasta.SelectedValue, Convert.ToInt32(txtNumero.Text.Trim()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void cboSector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
