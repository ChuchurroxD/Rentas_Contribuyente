using Microsoft.Reporting.WinForms;
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

namespace SGR.WinApp.Layout._5_Reportes_Gestion.Rep_Ingresos
{
    public partial class Frm_PlanillaIngresosResumen : Form
    {
        private List<Repo_PlanillaIngresos> coleccionResumenPorDia;
        private List<Repo_PlanillaIngresos> coleccionResumenPorDevolucion;
        private List<Repo_PlanillaIngresos> coleccionResumenPorPartida;
        Repo_PlanillaIngresosDataService repo_PlanillaIngresosDataService = new Repo_PlanillaIngresosDataService();
        Pago_PagosDataService pagos = new Pago_PagosDataService();
        public Frm_PlanillaIngresosResumen()
        {
            InitializeComponent();
        }

        public void cargarCombos()
        {
            try
            {
                cboConceptoAgrupado.DisplayMember = "Multc_vDescripcion";
                cboConceptoAgrupado.ValueMember = "Multc_cValor";
                //cboConceptoAgrupado.DataSource = pagos.listarConceptos();
                cboConceptoAgrupado.DataSource = pagos.listarConceptosPlanilla();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor registre la tasa de cambio para el día de hoy", Globales.Global_MessageBox);
                this.Close();
            }
        }

        private void botonListar_Click(object sender, EventArgs e)
        {
            try
            {
                if (chk_filtro.Checked)
                {
                    coleccionResumenPorDia = repo_PlanillaIngresosDataService.listarResumenPorDiaConcepto(dtpFechaDesde.Value.ToShortDateString().Trim(),
                    dtpFechaHasta.Value.ToShortDateString().Trim(), (string)cboConceptoAgrupado.SelectedValue);
                    dgvResumenDelDia.DataSource = coleccionResumenPorDia;
                    coleccionResumenPorDevolucion = repo_PlanillaIngresosDataService.listarResumenPorDevolucionPlanilla(dtpFechaDesde.Value.ToShortDateString(),
                        dtpFechaHasta.Value.ToShortDateString(), (string)cboConceptoAgrupado.SelectedValue);
                    dgvDevolucion.DataSource = coleccionResumenPorDevolucion;
                    coleccionResumenPorPartida = repo_PlanillaIngresosDataService.listarResumenPorPartidaPlanilla(dtpFechaDesde.Value.ToShortDateString().Trim(),
                        dtpFechaHasta.Value.ToShortDateString().Trim(), (string)cboConceptoAgrupado.SelectedValue);
                    dgvResumenPorPartida.DataSource = coleccionResumenPorPartida;
                } else
                {
                    coleccionResumenPorDia = repo_PlanillaIngresosDataService.listarResumenPorDia(dtpFechaDesde.Value.ToShortDateString().Trim(),
                    dtpFechaHasta.Value.ToShortDateString().Trim());
                    dgvResumenDelDia.DataSource = coleccionResumenPorDia;
                    coleccionResumenPorDevolucion = repo_PlanillaIngresosDataService.listarResumenPorDevolucion(dtpFechaDesde.Value.ToShortDateString(),
                        dtpFechaHasta.Value.ToShortDateString());
                    dgvDevolucion.DataSource = coleccionResumenPorDevolucion;
                    coleccionResumenPorPartida = repo_PlanillaIngresosDataService.listarResumenPorPartida(dtpFechaDesde.Value.ToShortDateString().Trim(),
                        dtpFechaHasta.Value.ToShortDateString().Trim());
                    dgvResumenPorPartida.DataSource = coleccionResumenPorPartida;
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void botonGenerarResumen_Click(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            Frm_Visor_Global frm_Visor_Global = new Frm_Visor_Global();
            try
            {
                if (chk_filtro.Checked)
                {
                    coleccionResumenPorDia = repo_PlanillaIngresosDataService.listarResumenPorDiaConcepto(dtpFechaDesde.Value.ToShortDateString().Trim(),
                   dtpFechaHasta.Value.ToShortDateString().Trim(), (string)cboConceptoAgrupado.SelectedValue);
                    coleccionResumenPorDevolucion = repo_PlanillaIngresosDataService.listarResumenPorDevolucionPlanilla(dtpFechaDesde.Value.ToShortDateString(),
                        dtpFechaHasta.Value.ToShortDateString(), (string)cboConceptoAgrupado.SelectedValue);
                    coleccionResumenPorPartida = repo_PlanillaIngresosDataService.listarResumenPorPartidaPlanilla(dtpFechaDesde.Value.ToShortDateString().Trim(),
                         dtpFechaHasta.Value.ToShortDateString().Trim(), (string)cboConceptoAgrupado.SelectedValue);
                    frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                    frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._5_Reportes_Gestion.Rep_Ingresos.Reporte_PlanillaIngresosResumen.rdlc";
                    frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetResumenPorDia", coleccionResumenPorDia));
                    frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetResumenPorDevolucion", coleccionResumenPorDevolucion));
                    frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetResumenPorPartida", coleccionResumenPorPartida));
                    ReportParameter[] paramsx = new ReportParameter[5];
                    paramsx[0] = new ReportParameter("UsuarioPrueba", GlobalesV1.Global_str_Usuario);
                    paramsx[1] = new ReportParameter("NombreEmpresa", Globales.NombreEmpresa);
                    paramsx[2] = new ReportParameter("FechaDesde", dtpFechaDesde.Text);
                    paramsx[3] = new ReportParameter("FechaHasta", dtpFechaHasta.Text);
                    paramsx[4] = new ReportParameter("RucEmpresa", Globales.RucEmpresa);
                    frm_Visor_Global.reportViewer1.LocalReport.SetParameters(paramsx);
                    frm_Visor_Global.reportViewer1.RefreshReport();
                    frm_Visor_Global.StartPosition = FormStartPosition.CenterScreen;
                    frm_Visor_Global.ShowDialog();
                } else
                {
                    coleccionResumenPorDia = repo_PlanillaIngresosDataService.listarResumenPorDia(dtpFechaDesde.Value.ToShortDateString().Trim(),
                    dtpFechaHasta.Value.ToShortDateString().Trim());
                    coleccionResumenPorDevolucion = repo_PlanillaIngresosDataService.listarResumenPorDevolucion(dtpFechaDesde.Value.ToShortDateString().Trim(),
                        dtpFechaHasta.Value.ToShortDateString().Trim());
                    coleccionResumenPorPartida = repo_PlanillaIngresosDataService.listarResumenPorPartida(dtpFechaDesde.Value.ToShortDateString().Trim(),
                        dtpFechaHasta.Value.ToShortDateString().Trim());
                    frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                    frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._5_Reportes_Gestion.Rep_Ingresos.Reporte_PlanillaIngresosResumen.rdlc";
                    frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetResumenPorDia", coleccionResumenPorDia));
                    frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetResumenPorDevolucion", coleccionResumenPorDevolucion));
                    frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetResumenPorPartida", coleccionResumenPorPartida));
                    ReportParameter[] paramsx = new ReportParameter[5];
                    paramsx[0] = new ReportParameter("UsuarioPrueba", GlobalesV1.Global_str_Usuario);
                    paramsx[1] = new ReportParameter("NombreEmpresa", Globales.NombreEmpresa);
                    paramsx[2] = new ReportParameter("FechaDesde", dtpFechaDesde.Text);
                    paramsx[3] = new ReportParameter("FechaHasta", dtpFechaHasta.Text);
                    paramsx[4] = new ReportParameter("RucEmpresa", Globales.RucEmpresa);
                    frm_Visor_Global.reportViewer1.LocalReport.SetParameters(paramsx);
                    frm_Visor_Global.reportViewer1.RefreshReport();
                    frm_Visor_Global.StartPosition = FormStartPosition.CenterScreen;
                    frm_Visor_Global.ShowDialog();
                }
                
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

        private void chk_filtro_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_filtro.Checked)
            {
                cboConceptoAgrupado.Enabled = true;
                cargarCombos();
            } else
            {
                cboConceptoAgrupado.Enabled = false;
                cboConceptoAgrupado.DataSource = null;
                cboConceptoAgrupado.Items.Clear();
            }
        }
    }
}
