using Microsoft.Reporting.WinForms;
using SGR.Core.Service;
using SGR.Core.Service.Combos;
using SGR.Entity;
using SGR.Entity.Model;
using SGR.Entity.Model.Combos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SGR.WinApp.Layout._5_Reportes_Gestion.Rep_FacturadoCobrado
{
    public partial class Frm_FacturadoCobrado : Form
    {
        Repo_FacturadoCobrado repo_FacturadoCobrado = new Repo_FacturadoCobrado();
        Mant_PeriodoDataService mant_PeriodoDataService = new Mant_PeriodoDataService();
        Pago_OficinaDataService pago_OficinaDataService = new Pago_OficinaDataService();
        private List<Repo_FacturadoCobrado> coleccion;
        private MesDataService mesDataService = new MesDataService();
        private List<Mes> meses = new List<Mes>();
        Repo_FacturadoCobradoDataService repo_FacturadoCobradoDataService = new Repo_FacturadoCobradoDataService();
        public Frm_FacturadoCobrado()
        {
            InitializeComponent();
        }
        public void llenarComboOficina()
        {
            comboBusquedaOficina.DisplayMember = "Descripcion";
            comboBusquedaOficina.ValueMember = "oficina_id";
            comboBusquedaOficina.DataSource = pago_OficinaDataService.listarComboOficinaCajero(GlobalesV1.Global_int_idoficina);
        }
        private void llenarcomboPeriodo()
        {
            try
            {
                comboBusquedaPeriodo.DisplayMember = "Peric_canio";
                comboBusquedaPeriodo.ValueMember = "Peric_canio";
                comboBusquedaPeriodo.DataSource = mant_PeriodoDataService.llenarPeriodo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }
        private void LlenarcomboMes()
        {
            comboBusquedaMes.DisplayMember = "mes";
            comboBusquedaMes.ValueMember = "mes_ID";
            comboBusquedaMes.DataSource = mesDataService.listartodos();

            comboBusquedaMesHasta.DisplayMember = "mes";
            comboBusquedaMesHasta.ValueMember = "mes_ID";
            comboBusquedaMesHasta.DataSource = mesDataService.listartodos();
        }
        private void Frm_FacturadoCobrado_Load(object sender, EventArgs e)
        {
            
            try
            {
                comboBusquedaOficina.Visible = false;
                label2.Visible = false;
                LlenarcomboMes();
                llenarcomboPeriodo();
                DateTime fechaHoy = DateTime.Now;
                comboBusquedaPeriodo.SelectedValue = Convert.ToInt32(fechaHoy.Year.ToString());
                llenarComboOficina();
                dgvFacturadoCobrado.Columns["abono"].DefaultCellStyle.Format = "###,##0.00";
                dgvFacturadoCobrado.Columns["cargo"].DefaultCellStyle.Format = "###,##0.00";
                dgvFacturadoCobrado.Columns["Saldo"].DefaultCellStyle.Format = "###,##0.00";
                dgvFacturadoCobrado.Columns["Cobrado"].DefaultCellStyle.Format = "###,##0.00";
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
                //coleccion = repo_FacturadoCobradoDataService.ListarFacturadoCobrado((int)comboBusquedaPeriodo.SelectedValue, Convert.ToInt32((string)comboBusquedaMes.SelectedValue), Convert.ToInt32((string)comboBusquedaMesHasta.SelectedValue), (int)comboBusquedaOficina.SelectedValue);
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._5_Reportes_Gestion.Rep_FacturadoCobrado.Reporte_FacturadoCobrado.rdlc";
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetFacturadoCobrado", coleccion));

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
                paramsx[0] = new ReportParameter("NombreEmpresa",Globales.NombreEmpresa);
                paramsx[1] = new ReportParameter("RucEmpresa", Globales.RucEmpresa);
                paramsx[2] = new ReportParameter("Periodo", comboBusquedaPeriodo.Text);
                paramsx[3] = new ReportParameter("Mes", comboBusquedaMes.Text);
                paramsx[4] = new ReportParameter("MesFin", comboBusquedaMesHasta.Text);
                paramsx[5] = new ReportParameter("Oficina", comboBusquedaOficina.Text);
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

        private void comboBusquedaMes_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void botonListar_Click(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                //coleccion = repo_FacturadoCobradoDataService.ListarFacturadoCobrado((Int32)comboBusquedaPeriodo.SelectedValue, Convert.ToInt32((string)comboBusquedaMes.SelectedValue), Convert.ToInt32((string)comboBusquedaMesHasta.SelectedValue), (Int32)comboBusquedaOficina.SelectedValue);
                //dgvFacturadoCobrado.DataSource = coleccion;
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

        private void dgvFacturadoCobrado_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
