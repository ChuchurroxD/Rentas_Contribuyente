using Microsoft.Reporting.WebForms;
using SGR.Core.Service;
using SGR.Entity.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SGR.WinApp.Layout._5_Reportes_Gestion.Rep_CajaResumen
{
    public partial class Frm_CajaResumen : Form
    {
        Pago_OficinaDataService pago_OficinaDataService = new Pago_OficinaDataService();
        private List<Repo_CajaResumen> ColeccionDT;
        private List<Repo_CajaResumen> ColeccionDC;
        Repo_CajaResumenDataService repo_CajaResumenDataService = new Repo_CajaResumenDataService();
        public Frm_CajaResumen()
        {
            InitializeComponent();
        }
        public void llenarComboOficina()
        {
            comboBusquedaOficina.DisplayMember = "Descripcion";
            comboBusquedaOficina.ValueMember = "oficina_id";
            comboBusquedaOficina.DataSource = pago_OficinaDataService.listarComboOficinaCajero(GlobalesV1.Global_int_idoficina);
        }

        private void Frm_CajaResumen_Load(object sender, EventArgs e)
        {
            llenarComboOficina();
            try
            {
                dgvDatosCaja.Columns["MontoTotal"].DefaultCellStyle.Format = "###,##0.00";
                dgvDatosFormaPago.Columns["pMontototal"].DefaultCellStyle.Format = "###,##0.00";
                dgvFuenteFinanciamiento.Columns["xMontoTotal"].DefaultCellStyle.Format = "###,##0.00";
                dgvDatosTributos.Columns["tImporteTotal"].DefaultCellStyle.Format = "###,##0.00";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void botonListar_Click(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                ColeccionDT = repo_CajaResumenDataService.ListarDatosTributos(dtpBusquedaFechaDesde.Value.ToShortDateString().Trim(), dtpBusquedaFechaHasta.Value.ToShortDateString().Trim(), (int)comboBusquedaOficina.SelectedValue);
                dgvDatosTributos.DataSource = ColeccionDT;
                ColeccionDC = repo_CajaResumenDataService.ListarDatosCaja(dtpBusquedaFechaDesde.Value.ToShortDateString().Trim(), dtpBusquedaFechaHasta.Value.ToShortDateString().Trim(), (int)comboBusquedaOficina.SelectedValue);
                dgvDatosCaja.DataSource = ColeccionDC;
                ColeccionDC = repo_CajaResumenDataService.ListarDatosCaja(dtpBusquedaFechaDesde.Value.ToShortDateString().Trim(), dtpBusquedaFechaHasta.Value.ToShortDateString().Trim(), (int)comboBusquedaOficina.SelectedValue);
                dgvDatosFormaPago.DataSource = ColeccionDC;
                ColeccionDC = repo_CajaResumenDataService.ListarDatosCaja(dtpBusquedaFechaDesde.Value.ToShortDateString().Trim(), dtpBusquedaFechaHasta.Value.ToShortDateString().Trim(), (int)comboBusquedaOficina.SelectedValue);
                dgvFuenteFinanciamiento.DataSource = ColeccionDC;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void comboBusquedaOficina_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void botonGenerarResumen_Click_1(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            Frm_Visor_Global frm_Visor_Global = new Frm_Visor_Global();
            try
            {
                ColeccionDT = repo_CajaResumenDataService.ListarDatosTributos(dtpBusquedaFechaDesde.Value.ToShortDateString().Trim(), dtpBusquedaFechaHasta.Value.ToShortDateString().Trim(), (int)comboBusquedaOficina.SelectedValue);
                ColeccionDC = repo_CajaResumenDataService.ListarDatosCaja(dtpBusquedaFechaDesde.Value.ToShortDateString().Trim(), dtpBusquedaFechaHasta.Value.ToShortDateString().Trim(), (int)comboBusquedaOficina.SelectedValue);
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._5_Reportes_Gestion.Rep_CajaResumen.Reporte_CajaResumen.rdlc";
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSetDatosTributos", ColeccionDT));
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSetDatosCaja", ColeccionDC));

                //INGRESAR LOGO EMPRESA - INICIO
                List<Frac_CuentaFraccionada> List_CuentaFraccionada = new List<Frac_CuentaFraccionada>();
                Frac_CuentaFraccionada frac_CuentaFraccionada = new Frac_CuentaFraccionada();
                String _path = Path.Combine(Application.StartupPath, @"LogoCabecera.jpg");
                frac_CuentaFraccionada.logoEmpresa = File.ReadAllBytes(_path);
                frac_CuentaFraccionada.convenio = "convenio";
                List_CuentaFraccionada.Add(frac_CuentaFraccionada);
                Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new Microsoft.Reporting.WinForms.ReportDataSource("DataSetLogoEmpresa", List_CuentaFraccionada);
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                //LOGO EMPRESA FIN

                Microsoft.Reporting.WinForms.ReportParameter[] paramsx = new Microsoft.Reporting.WinForms.ReportParameter[6];
                paramsx[0] = new Microsoft.Reporting.WinForms.ReportParameter("UsuarioPrueba", GlobalesV1.Global_str_Usuario);
                paramsx[1] = new Microsoft.Reporting.WinForms.ReportParameter("NombreEmpresa", Globales.NombreEmpresa);
                paramsx[2] = new Microsoft.Reporting.WinForms.ReportParameter("RucEmpresa", Globales.RucEmpresa);
                paramsx[3] = new Microsoft.Reporting.WinForms.ReportParameter("FechaDesde", dtpBusquedaFechaDesde.Text);
                paramsx[4] = new Microsoft.Reporting.WinForms.ReportParameter("FechaHasta", dtpBusquedaFechaHasta.Text);
                paramsx[5] = new Microsoft.Reporting.WinForms.ReportParameter("Oficina", comboBusquedaOficina.Text);
                frm_Visor_Global.reportViewer1.LocalReport.SetParameters(paramsx);
                frm_Visor_Global.reportViewer1.RefreshReport();
                frm_Visor_Global.StartPosition = FormStartPosition.CenterScreen;
                frm_Visor_Global.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
    }
}
