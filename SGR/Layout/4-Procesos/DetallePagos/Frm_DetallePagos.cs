using Microsoft.Reporting.WinForms;
using SGR.Core.Service;
using SGR.Entity.Model;
using SGR.WinApp.Layout._5_Reportes_Gestion;
using SGR.WinApp.Layout._5_Reportes_Gestion.Rep_CajaResumen;
using SGR.WinApp.Layout._5_Reportes_Gestion.Rep_FacturadoCobrado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace SGR.WinApp.Layout._4_Procesos.DetallePagos
{
    public partial class Frm_DetallePagos : DockContent
    {
        private List<Repo_DetallePagos> coleccion;
        Repo_DetallePagosDataService repo_DetallePagosDataService = new Repo_DetallePagosDataService();
        Pago_CajaDataService pago_CajaDataService = new Pago_CajaDataService();
        public Frm_DetallePagos()
        {
            InitializeComponent();
        }

        public void llenarComboCaja()
        {
            comboBusquedaCaja.DisplayMember = "Descripcion";
            comboBusquedaCaja.ValueMember = "Caja_id";
            comboBusquedaCaja.DataSource = pago_CajaDataService.llenarcomboCajav2();
        }

        private void botonListar_Click(object sender, EventArgs e)
        {
            try
            {
                coleccion = repo_DetallePagosDataService.ListarDetallePagos(dtpFechaPagoDesde.Value.ToShortDateString().Trim(), 
                    dtpFechaPagoHasta.Value.ToShortDateString().Trim(), (Int32)comboBusquedaCaja.SelectedValue);
                dgvListarDetallePagos.DataSource = coleccion;
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
            Frm_Visor_Global frm_Visor_Global = new Frm_Visor_Global();
            try
            {
                coleccion = repo_DetallePagosDataService.ListarDetallePagos(dtpFechaPagoDesde.Value.ToShortDateString().Trim(), dtpFechaPagoHasta.Value.ToShortDateString().Trim(), (Int32)comboBusquedaCaja.SelectedValue);
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._4_Procesos.DetallePagos.Reporte_DetallePagos.rdlc";
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetDetallePagos", coleccion));
                //INGRESAR LOGO EMPRESA - INICIO
                List<Frac_CuentaFraccionada> List_CuentaFraccionada = new List<Frac_CuentaFraccionada>();
                Frac_CuentaFraccionada frac_CuentaFraccionada = new Frac_CuentaFraccionada();
                String _path = Path.Combine(Application.StartupPath, @"LogoCabecera.jpg");
                frac_CuentaFraccionada.logoEmpresa = File.ReadAllBytes(_path);
                frac_CuentaFraccionada.convenio = "convenio";
                List_CuentaFraccionada.Add(frac_CuentaFraccionada);
                ReportDataSource reportDataSource = new ReportDataSource("DataSetLogoEmpresa", List_CuentaFraccionada);
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                //LOGO EMPRESA FIN

                ReportParameter[] paramsx = new ReportParameter[6];
                paramsx[0] = new ReportParameter("UsuarioPrueba", GlobalesV1.Global_str_Usuario);
                paramsx[1] = new ReportParameter("NombreEmpresa", Globales.NombreEmpresa);
                paramsx[2] = new ReportParameter("RucEmpresa", Globales.RucEmpresa);
                paramsx[3] = new ReportParameter("FechaPagoDesde", dtpFechaPagoDesde.Text);
                paramsx[4] = new ReportParameter("FechaPagoHasta", dtpFechaPagoHasta.Text);
                paramsx[5] = new ReportParameter("Nro_Caja", comboBusquedaCaja.Text);
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

        private void comboBusquedaCaja_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                coleccion = repo_DetallePagosDataService.ListarDetallePagos(dtpFechaPagoDesde.Value.ToShortDateString().Trim(), dtpFechaPagoHasta.Value.ToShortDateString().Trim(), (Int32)comboBusquedaCaja.SelectedValue);
                dgvListarDetallePagos.DataSource = coleccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Frm_DetallePagos_Load(object sender, EventArgs e)
        {
            try
            {
                llenarComboCaja();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void botonFacturadoCobrado_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_FacturadoCobrado frm_FacturadoCobrado = new Frm_FacturadoCobrado();
                frm_FacturadoCobrado.StartPosition = FormStartPosition.CenterParent;
                frm_FacturadoCobrado.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void botonCajaResumen_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_CajaResumen frm_CajaResumen = new Frm_CajaResumen();
                frm_CajaResumen.StartPosition = FormStartPosition.CenterParent;
                frm_CajaResumen.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }
    }
}
