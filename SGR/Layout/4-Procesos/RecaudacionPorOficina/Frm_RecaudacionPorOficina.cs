using Microsoft.Reporting.WinForms;
using SGR.Core.Service;
using SGR.Entity.Model;
using SGR.WinApp.Layout._5_Reportes_Gestion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace SGR.WinApp.Layout._4_Procesos.RecaudacionPorOficina
{
    public partial class Frm_RecaudacionPorOficina : DockContent
    {
        Pago_OficinaDataService pago_OficinaDataService = new Pago_OficinaDataService();
        List<Pred_Tributo> ListadoTributo = new List<Pred_Tributo>();
        Mant_RecaudacionPorOficinaDataService mant_RecaudacionPorOficinaDataService = new Mant_RecaudacionPorOficinaDataService();
        private List<Mant_RecaudacionPorOficina> coleccion;
        Mant_PeriodoDataService mant_PeriodoDataService = new Mant_PeriodoDataService();
        public Frm_RecaudacionPorOficina()
        {
            InitializeComponent();
        }

        private void Frm_RecaudacionPorOficina_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaHoy = DateTime.Now;
                llenarcomboPeriodoDesde();
                llenarcomboPeriodoHasta();
                comboBusquedaDesde.SelectedValue = Convert.ToInt32(fechaHoy.Year.ToString());
                comboBusquedaHasta.SelectedValue = Convert.ToInt32(fechaHoy.Year.ToString());
                llenarComboOficina();
                coleccion = mant_RecaudacionPorOficinaDataService.listarTodos(comboBusquedaOficina.SelectedValue.ToString());
                dgvListarRecaudacionPorOficina.DataSource = coleccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void llenarComboOficina()
        {
            comboBusquedaOficina.DisplayMember = "Descripcion";
            comboBusquedaOficina.ValueMember = "oficina_id";
            comboBusquedaOficina.DataSource = pago_OficinaDataService.listarComboOficina();
        }

        private void llenarcomboPeriodoDesde()
        {
            try
            {
                comboBusquedaDesde.DisplayMember = "Peric_canio";
                comboBusquedaDesde.ValueMember = "Peric_canio";
                comboBusquedaDesde.DataSource = mant_PeriodoDataService.llenarPeriodo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void llenarcomboPeriodoHasta()
        {
            try
            {
                comboBusquedaHasta.DisplayMember = "Peric_canio";
                comboBusquedaHasta.ValueMember = "Peric_canio";
                comboBusquedaHasta.DataSource = mant_PeriodoDataService.llenarPeriodo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }
        private void comboBusquedaOficina_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                coleccion = mant_RecaudacionPorOficinaDataService.listarTodos(comboBusquedaOficina.SelectedValue.ToString());
                dgvListarRecaudacionPorOficina.DataSource = coleccion;
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
                coleccion = mant_RecaudacionPorOficinaDataService.listarPorPeriodoDesdeHasta((Int32)comboBusquedaDesde.SelectedValue, (Int32)comboBusquedaHasta.SelectedValue,(Int32)comboBusquedaOficina.SelectedValue);
                dgvListarRecaudacionPorOficina.DataSource = coleccion;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void botonReporte_Click(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            Frm_Visor_Global frm_Visor_Global = new Frm_Visor_Global();
            try
            {
                coleccion = mant_RecaudacionPorOficinaDataService.listarPorPeriodoDesdeHasta((Int32)comboBusquedaDesde.SelectedValue, (Int32)comboBusquedaHasta.SelectedValue, (Int32)comboBusquedaOficina.SelectedValue);
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._4_Procesos.RecaudacionPorOficina.Reporte_RecaudacionPorOficina.rdlc";
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetRecaudacionPorOficina", coleccion));
                ReportParameter[] paramsx = new ReportParameter[4];
                paramsx[0] = new ReportParameter("UsuarioPrueba", GlobalesV1.Global_str_Usuario);
                paramsx[1] = new ReportParameter("PeriodoDesde", comboBusquedaDesde.SelectedValue.ToString());
                paramsx[2] = new ReportParameter("PeriodoHasta", comboBusquedaHasta.SelectedValue.ToString());
                paramsx[3] = new ReportParameter("Oficina", comboBusquedaOficina.Text);
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
