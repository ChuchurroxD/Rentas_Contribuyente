using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SGR.Core.Service;
using SGR.Entity;
using WeifenLuo.WinFormsUI.Docking;
using Microsoft.Reporting.WinForms;
using SGR.Entity.Model;
using System.IO;
using SGR.Entity;
using SGR.WinApp.Layout._5_Reportes_Gestion;
using WeifenLuo.WinFormsUI.Docking;

namespace SGR.WinApp.Layout._4_Procesos.Coactivo
{
    public partial class Frm_Coactivo : DockContent
    {
        private Coa_expediente_coactivoDataService coa_expediente_coactivoDataService = new Coa_expediente_coactivoDataService();
        public Frm_Coactivo()
        {
            InitializeComponent();
        }
        private void txtCodContribuyente_KeyUp(object sender, KeyEventArgs e)
        {

        }
        private void txtNomRazon_KeyUp(object sender, KeyEventArgs e)
        {

        }
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                String perso = (String)dataGridView1.SelectedRows[0].Cells["persona_ID"].Value;
                int cod =(int)dataGridView1.SelectedRows[0].Cells["codigo"].Value; 

                if (dataGridView1.Columns[e.ColumnIndex].Name == "Anular")
                {
                    if (MessageBox.Show("Desea Eliminar?", Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string estado = "";
                        if (rbtAnulado.Checked)
                            estado = "4";
                        else if (rbtArchivao.Checked)
                            estado = "3";
                        else if (rbtnuevo.Checked)
                            estado = "1";
                        else if (rbtNotificado.Checked)
                            estado = "2";
                        else if (rbtTodo.Checked)
                            estado = "%";
                        coa_expediente_coactivoDataService.anular(cod);
                        MessageBox.Show("Se eliminó correctamente", Globales.Global_MessageBox);
                        btnBuscar.PerformClick();
                    }
                }
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Imprimir")
                {//modifi
                    impresionOrdenPago(perso,2016);
                }
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Notificar")
                {
                    //poner
                    Frm_Notificacion frm_Notificacion = new Frm_Notificacion();
                    frm_Notificacion.StartPosition = FormStartPosition.CenterParent;
                    frm_Notificacion.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void impresion(string persona,int notificacion)
        {
            try
            {
                RepoValoresCobranzaDataService operaciones = new RepoValoresCobranzaDataService();
                string codigoPersona = persona;
                int notificacion_id = notificacion;
                //impresionNotificacion(notificacion_id,codigoPersona);
                List<RepoValoresCobranza> coleccionPersona = operaciones.datosContribuyente(notificacion_id);
                List<RepoValoresCobranza> documentosNotificados = operaciones.documentosNotificados(notificacion);
                List<Valo_ValoresCobranzaReporte> listaValores = operaciones.listarValores(notificacion);
                Frm_Visor_Global frmVisor = new Frm_Visor_Global();
                frmVisor.reportViewer1.LocalReport.DataSources.Clear();
                frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._4_Procesos.Valores_Cobranza.rptCoactivo.rdlc";
                frmVisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsContribuyente", coleccionPersona));
                frmVisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsDocumentos", documentosNotificados));

                //ReportParameter[] param = new ReportParameter[2];
                //param[0] = new ReportParameter("AñoActual", Convert.ToString(coleccionPersona[0].año));
                //param[1] = new ReportParameter("Documento", Convert.ToString(coleccionPersona[0].numero));
                //frmVisor.reportViewer1.LocalReport.SetParameters(param);
                frmVisor.reportViewer1.RefreshReport();
                frmVisor.StartPosition = FormStartPosition.CenterParent;
                frmVisor.ShowDialog();
            }
            catch (Exception ex)
            {

            }
        }
        public void impresionOrdenPago(string persona_ID, int anio_curso)
        {
            try
            {
                Valo_ValoresCobranzaDataService valo_ValoresDataService = new Valo_ValoresCobranzaDataService();
                var coleccion = new List<Valo_OrdenPago>();
                coleccion = valo_ValoresDataService.generarReporte(anio_curso, persona_ID, "3");
                Frm_Visor_Global frmVisor = new Frm_Visor_Global();
                frmVisor.reportViewer1.LocalReport.DataSources.Clear();
                frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._4_Procesos.Valores_Cobranza.rptCoactivo.rdlc";
                frmVisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", coleccion));

                List<Frac_CuentaFraccionada> origen2 = new List<Frac_CuentaFraccionada>();
                Frac_CuentaFraccionada elementoo = new Frac_CuentaFraccionada();
                string _path = Path.Combine(Application.StartupPath, @"LogoCabecera.jpg");
                elementoo.logoEmpresa = File.ReadAllBytes(_path);
                elementoo.convenio = "convenio";
                origen2.Add(elementoo);
                ReportDataSource dataSourceEmpresa = new ReportDataSource("DataSet2", origen2);
                frmVisor.reportViewer1.LocalReport.DataSources.Add(dataSourceEmpresa);


                //ReportParameter[] param = new ReportParameter[1];
                //param[0] = new ReportParameter("Empresa", Globales.NombreEmpresa);
                //frmVisor.reportViewer1.LocalReport.SetParameters(param);
                frmVisor.reportViewer1.RefreshReport();
                frmVisor.StartPosition = FormStartPosition.CenterParent;
                frmVisor.ShowDialog();
            }
            catch (Exception ex)
            {

            }
        }
        private void Impprimir()
        {
            DateTime fechaHoy = DateTime.Now;
            DateTime diaHoy = DateTime.Now;
            try
            {

                Frm_Visor_Global frm_Visor_Global = new Frm_Visor_Global();
                Mant_ContribuyenteDataService mant_ContribuyenteDataService1 = new Mant_ContribuyenteDataService();
                //ColeccionMPC = mant_ContribuyenteDataService1.listarIdContribuyente(xpersona);
                //Coleccion = repo_HojaResumenService.listarPrediosxPerContribuyente(xpersona.ToString(), periodo);
                //ColeccionPC = repo_HojaResumenService.listarDeterminacionImpuesto(xpersona.ToString(), periodo);
                //ColeccionMP = repo_HojaResumenService.listarMontosPagar(xpersona.ToString(), periodo);
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                //chuchuro modificas aqui el normbre dded tu repote sin formato
                frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._1_Tablas_Maestras.Contribuyente.Reporte_Contribuyente_SinFormato.rdlc";
                //frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetContribuyente", ColeccionMPC));
                //frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetRelacionPredios", Coleccion));
                //frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetDeterminacionImpuesto", ColeccionPC));
                //frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetMontosPagar", ColeccionMP));
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
                paramsx[0] = new ReportParameter("NombreEmpresa", Globales.NombreEmpresa);
                paramsx[1] = new ReportParameter("UsuarioPrueba", GlobalesV1.Global_str_Usuario);
                paramsx[2] = new ReportParameter("Año", fechaHoy.Year.ToString());
                paramsx[3] = new ReportParameter("Dia", fechaHoy.Day.ToString());
                paramsx[4] = new ReportParameter("Mes", fechaHoy.Month.ToString());
                paramsx[5] = new ReportParameter("RucEmpresa", Globales.RucEmpresa);
                frm_Visor_Global.reportViewer1.LocalReport.SetParameters(paramsx);
                frm_Visor_Global.reportViewer1.RefreshReport();
                frm_Visor_Global.StartPosition = FormStartPosition.CenterScreen;
                frm_Visor_Global.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodContribuyente.Text = "";
            txtNomRazon.Text = "";
            txtExpedienteN.Text = "";
            ttxtExpedienteAnio.Text = "";
        }
        private void btnNUevo_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_ExpedienteCoactivo Frm_ExpedienteCoactivo = new Frm_ExpedienteCoactivo();
                Frm_ExpedienteCoactivo.StartPosition = FormStartPosition.CenterParent;
                Frm_ExpedienteCoactivo.ShowDialog();

                string estado = "";
                if (rbtAnulado.Checked)
                    estado = "4";
                else if (rbtArchivao.Checked)
                    estado = "3";
                else if (rbtnuevo.Checked)
                    estado = "1";
                else if (rbtNotificado.Checked)
                    estado = "2";
                else if (rbtTodo.Checked)
                    estado = "%";
                btnBuscar.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string estado = "";
                if (rbtAnulado.Checked)
                    estado = "4";
                else if (rbtArchivao.Checked)
                    estado = "3";
                else if (rbtnuevo.Checked)
                    estado = "1";
                else if (rbtNotificado.Checked)
                    estado = "2";
                else if (rbtTodo.Checked)
                    estado = "0";
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = coa_expediente_coactivoDataService.listartodos(dtpFechaIni.Value, dtpFechaFin.Value, txtCodContribuyente.Text, txtNomRazon.Text, ttxtExpedienteAnio.Text, estado, txtExpedienteN.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }
    }
}
