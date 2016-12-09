using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGR.Core.Service;
using SGR.Entity.Model;
using SGR.WinApp.Layout._5_Reportes_Gestion;
using WeifenLuo.WinFormsUI.Docking;
using Microsoft.Reporting.WinForms;
using System.IO;

namespace SGR.WinApp.Layout._4_Procesos.Pagos.Reportes
{
    public partial class Frm_ConsultarPagos : DockContent
    {
        private Pago_PagoDataService Pago_PagoDataService = new Pago_PagoDataService();
        Pago_PagosDataService pagos = new Pago_PagosDataService();
        public Frm_ConsultarPagos()
        {
            InitializeComponent();
        }
        private int obtenerPago()
        {
            return (int)dgvPago.SelectedRows[0].Cells["pagos_ID"].Value;
        }

        private void Frm_ConsultarPagos_Load(object sender, EventArgs e)
        {
            dgvPago.AutoGenerateColumns = false;
            dgvPago.DataSource = Pago_PagoDataService.consultarPagosPorFechaPago(dtpFechaPagoDesde.Value.ToShortDateString().Trim(), dtpFechaPagoHasta.Value.ToShortDateString().Trim());
            rbtFechaPago.Checked = true;
            dgDeuda.Visible = false;
        }

        private void dgvPago_KeyDown(object sender, KeyEventArgs e)
        {
            dgvDetalle.DataSource = Pago_PagoDataService.listarDetallePagos(obtenerPago());
            dgvDTributo.AutoGenerateColumns = false;
            dgvDTributo.DataSource = Pago_PagoDataService.listarDetalleTributo(obtenerPago());
        }

        private void dgvPago_DoubleClick(object sender, EventArgs e)
        {
            int codigo = obtenerPago();
            dgvDetalle.DataSource = Pago_PagoDataService.listarDetallePagos(codigo);
            dgvDTributo.AutoGenerateColumns = false;
            dgvDTributo.DataSource = Pago_PagoDataService.listarDetalleTributo(codigo);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (rbtFechaPago.Checked == true)
            {
                dgvPago.DataSource = Pago_PagoDataService.consultarPagosPorFechaPago(dtpFechaPagoDesde.Value.ToShortDateString().Trim(), dtpFechaPagoHasta.Value.ToShortDateString().Trim());
                dgDeuda.Visible = false;
                dgvPago.Visible = true;
            }
            if (rbtFechaDeuda.Checked == true)
            {
                dgDeuda.DataSource = Pago_PagoDataService.consultarPagosPorFechaDeuda(dtpFechaPagoDesde.Value.ToShortDateString().Trim(), dtpFechaPagoHasta.Value.ToShortDateString().Trim());
                dgvPago.Visible = false;
                dgDeuda.Visible = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void generarRecibo(int pago_id, int opcion)
        {
            try
            {
                List<Pago_ReciboPago> coleccion = new List<Pago_ReciboPago>();
                Frm_Visor_Global frmVisor = new Frm_Visor_Global();
                if (opcion == 4 || opcion == 11 || opcion == 13)
                    coleccion = pagos.listarReciboOtrosPagos(pago_id);
                else
                    coleccion = pagos.listarRecibo(pago_id);
                frmVisor.reportViewer1.LocalReport.DataSources.Clear();
                frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._4_Procesos.Pagos.rptPagos.rdlc";
                frmVisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", coleccion));
                ReportParameter[] param = new ReportParameter[3];
                param[0] = new ReportParameter("Fecha", DateTime.Now.ToShortDateString().Trim());
                param[1] = new ReportParameter("Ruc", Globales.RucEmpresa);
                param[2] = new ReportParameter("N", GlobalesV1.Global_str_Usuario);
                frmVisor.reportViewer1.LocalReport.SetParameters(param);
                frmVisor.reportViewer1.RefreshReport();
                frmVisor.StartPosition = FormStartPosition.CenterParent;
                frmVisor.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            try
            {
                List<Pago_PagoXDeuda> coleccion1 = new List<Pago_PagoXDeuda>();
                List<Pago_Pago> coleccion2 = new List<Pago_Pago>();
                Frm_Visor_Global frmVisor = new Frm_Visor_Global();
                if(rbtFechaDeuda.Checked == true)
                {
                    coleccion1 = Pago_PagoDataService.consultarPagosPorFechaDeuda(dtpFechaPagoDesde.Value.ToShortDateString().Trim(), dtpFechaPagoHasta.Value.ToShortDateString().Trim());
                    frmVisor.reportViewer1.LocalReport.DataSources.Clear();
                    frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._4_Procesos.Pagos.Reportes.rptPagoFechaDeuda.rdlc";


                    List<Frac_CuentaFraccionada> origen2 = new List<Frac_CuentaFraccionada>();
                    Frac_CuentaFraccionada elementoo = new Frac_CuentaFraccionada();
                    string _path = Path.Combine(Application.StartupPath, @"LogoCabecera.jpg");
                    elementoo.logoEmpresa = File.ReadAllBytes(_path);
                    elementoo.convenio = "convenio";
                    origen2.Add(elementoo);
                    ReportDataSource dataSourceEmpresa = new ReportDataSource("DataSet2", origen2);
                    frmVisor.reportViewer1.LocalReport.DataSources.Add(dataSourceEmpresa);




                    frmVisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", coleccion1));
                    ReportParameter[] param = new ReportParameter[3];
                    param[0] = new ReportParameter("FechaDesde", dtpFechaPagoDesde.Value.ToShortDateString().Trim());
                    param[1] = new ReportParameter("FechaHasta", dtpFechaPagoHasta.Value.ToShortDateString().Trim());
                    param[2] = new ReportParameter("Ruc", Globales.RucEmpresa);
                    frmVisor.reportViewer1.LocalReport.SetParameters(param);
                    frmVisor.reportViewer1.RefreshReport();
                    frmVisor.StartPosition = FormStartPosition.CenterParent;
                    frmVisor.ShowDialog();
                }
                if (rbtFechaPago.Checked == true)
                {
                    coleccion2 = Pago_PagoDataService.consultarPagosPorFechaPago(dtpFechaPagoDesde.Value.ToShortDateString().Trim(), dtpFechaPagoHasta.Value.ToShortDateString().Trim());
                    frmVisor.reportViewer1.LocalReport.DataSources.Clear();
                    frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._4_Procesos.Pagos.Reportes.rptPagoFechaPago.rdlc";

                    List<Frac_CuentaFraccionada> origen2 = new List<Frac_CuentaFraccionada>();
                    Frac_CuentaFraccionada elementoo = new Frac_CuentaFraccionada();
                    string _path = Path.Combine(Application.StartupPath, @"LogoCabecera.jpg");
                    elementoo.logoEmpresa = File.ReadAllBytes(_path);
                    elementoo.convenio = "convenio";
                    origen2.Add(elementoo);
                    ReportDataSource dataSourceEmpresa = new ReportDataSource("DataSet2", origen2);
                    frmVisor.reportViewer1.LocalReport.DataSources.Add(dataSourceEmpresa);




                    frmVisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", coleccion2));
                    ReportParameter[] param = new ReportParameter[3];
                    param[0] = new ReportParameter("FechaDesde", dtpFechaPagoDesde.Value.ToShortDateString().Trim());
                    param[1] = new ReportParameter("FechaHasta", dtpFechaPagoHasta.Value.ToShortDateString().Trim());
                    param[2] = new ReportParameter("Ruc", Globales.RucEmpresa);
                    frmVisor.reportViewer1.LocalReport.SetParameters(param);
                    frmVisor.reportViewer1.RefreshReport();
                    frmVisor.StartPosition = FormStartPosition.CenterParent;
                    frmVisor.ShowDialog();
                }  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dgvPago.Columns[e.ColumnIndex].Name == "imprimir")
                {
                    int codigo = (Int32)dgvPago.Rows[e.RowIndex].Cells["Pagos_ID"].Value;
                    int tipo = Convert.ToInt32((string)dgvPago.Rows[e.RowIndex].Cells["TipoPago"].Value);
                    generarRecibo(codigo, tipo);
                }
                }catch(Exception ex)
            {

            }
        }

        //private void toolStripButton1_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (Cursor.Current == Cursors.WaitCursor)
        //            return;
        //        Cursor.Current = Cursors.WaitCursor;
        //        var coleccion = new List<Pago_PagoDetalleTributo>();
        //        coleccion = Pago_PagoDataService.reporteTributoMontoAnual(2016);
        //        Frm_Visor_Global frmVisor = new Frm_Visor_Global();
        //        frmVisor.reportViewer1.LocalReport.DataSources.Clear();
        //        frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._4_Procesos.Pagos.Reportes.tributoAnual.rdlc";
        //        frmVisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1",coleccion));
        //        frmVisor.reportViewer1.RefreshReport();
        //        frmVisor.StartPosition = FormStartPosition.CenterParent;
        //        frmVisor.ShowDialog();
        //    }catch(Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //    }
        //    finally
        //    {
        //        Cursor.Current = Cursors.Default;
        //    }
        //}
    }
}
