using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGR.Entity.Model;
using SGR.Core.Service;
using SGR.Core.Service.Combos;
using SGR.Entity.Model.Combos;
using SGR.WinApp.Layout._5_Reportes_Gestion;
using Microsoft.Reporting.WinForms;
using SGR.Entity;
using WeifenLuo.WinFormsUI.Docking;

namespace SGR.WinApp.Layout._4_Procesos.Predio.Exoneracion
{
    public partial class Frm_ListadoExoneracionGeneral : DockContent
    {
        Mant_PeriodoDataService mant_PeriodoDataService = new Mant_PeriodoDataService();
        private Pred_Descuentos_ExoneracionDataService Descuentos_ExoneracionDataService = new Pred_Descuentos_ExoneracionDataService();
        private Mant_ContribuyenteDataService Mant_ContribuyenteDataService = new Mant_ContribuyenteDataService();
        private List<Pred_Descuentos_Exoneracion> Coleccion;
        private Mant_PeriodoDataService PeriodoDataService = new Mant_PeriodoDataService();
        public Frm_ListadoExoneracionGeneral()
        {
            try
            {
                InitializeComponent();
                comboBusquedaAnio.ValueMember = "Peric_canio";
                comboBusquedaAnio.DisplayMember = "Peric_canio";
                comboBusquedaAnio.DataSource = PeriodoDataService.llenarPeriodo();
                string tipo_operacion = "";
                if (rbtExonerado.Checked)
                    tipo_operacion = "1";
                else if (rbtPrescrito.Checked)
                    tipo_operacion = "4";
                string razon_social = "%" + txtPersona.Text.TrimEnd() + "%";
                int periodoActivo = PeriodoDataService.GetPeriodoActivo();
                comboBusquedaAnio.SelectedValue = periodoActivo;
                string periodo = comboBusquedaAnio.SelectedValue.ToString();
                Coleccion = Descuentos_ExoneracionDataService.listarPreExon(periodo, razon_social, tipo_operacion, ckbTodosLosAños.Checked);
                dgvExoneracion.DataSource = Coleccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Globales.Global_MessageBox);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string tipo_operacion = "";
                if (rbtExonerado.Checked)
                    tipo_operacion = "1";
                else if (rbtPrescrito.Checked)
                    tipo_operacion = "4";
                string razon_social = "%" + txtPersona.Text.TrimEnd() + "%";
                string periodo = comboBusquedaAnio.SelectedValue.ToString();
                bool todosAnios = ckbTodosLosAños.Checked;
                Coleccion = Descuentos_ExoneracionDataService.listarPreExon(periodo, razon_social, tipo_operacion, todosAnios);
                dgvExoneracion.DataSource = Coleccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Globales.Global_MessageBox);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            Frm_Visor_Global frm_Visor_Global = new Frm_Visor_Global();
            try
            {
                string descripcion = "", anioo = "";
                if (rbtExonerado.Checked)
                    descripcion = "Exonerado";
                else
                    descripcion = "Preescrito";
                if (ckbTodosLosAños.Checked)
                    anioo = "Todos los años";
                else
                    anioo = comboBusquedaAnio.SelectedValue.ToString();
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._5_Reportes_Gestion.Rep_Exoneracion.RptExoneadosPreescritos.rdlc";
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", Coleccion));
                ReportParameter[] paramsx = new ReportParameter[4];
                paramsx[0] = new ReportParameter("Periodo", anioo);
                paramsx[1] = new ReportParameter("Usuario", GlobalesV1.Global_str_Nombre);
                paramsx[2] = new ReportParameter("Tipo", descripcion);
                paramsx[3] = new ReportParameter("Persona", txtPersona.Text.TrimEnd());
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

        private void ckbTodosLosAños_CheckedChanged(object sender, EventArgs e)
        {
            btnBuscar.PerformClick();
        }

        private void comboBusquedaAnio_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnBuscar.PerformClick();
        }

        private void rbtPrescrito_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtPrescrito.Checked)
                btnBuscar.PerformClick();
        }

        private void rbtExonerado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtExonerado.Checked)
                btnBuscar.PerformClick();
        }
    }
}
