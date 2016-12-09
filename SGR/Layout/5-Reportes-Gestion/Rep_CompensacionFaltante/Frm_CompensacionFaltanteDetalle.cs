using DgvFilterPopup;
using SGR.Core.Service;
using SGR.Core;
using SGR.Entity;
using System;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using SGR.WinApp.Layout._5_Reportes_Gestion;
using SGR.Entity.Model;
using System.Collections.Generic;
using Microsoft.Reporting.WinForms;
using System.Drawing.Printing;
using System.Drawing.Imaging;
using System.IO;
using System.Drawing;
using System.Text;

namespace SGR.WinApp.Layout._5_Reportes_Gestion.Rep_CompensacionFaltante
{
    public partial class Frm_CompensacionFaltanteDetalle : DockContent
    {
        //private Mant_Per_Cont mant_Per_Cont;
        private Mant_PeriodoDataService Mant_PeriodoDataService = new Mant_PeriodoDataService();
        private Repo_CompensacionFaltanteDataService repo_CompensacionFaltanteDataService = new Repo_CompensacionFaltanteDataService();
        private List<Repo_CompensacionFaltante> coleccion = new List<Repo_CompensacionFaltante>();

        public Frm_CompensacionFaltanteDetalle()
        {
            InitializeComponent();
        }

        private void Frm_CompensacionFaltanteDetalle_Load(object sender, EventArgs e)
        {
            try
            {
                llenarComboPeriodo();
                coleccion = repo_CompensacionFaltanteDataService.listarCompensacionesFaltantes(Convert.ToInt32(cboPeriodo.SelectedValue.ToString().Trim()));
                dgCompensacionFaltante.DataSource = coleccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void llenarComboPeriodo()
        {
            cboPeriodo.DisplayMember = "Peric_vdescripcion";
            cboPeriodo.ValueMember = "Peric_canio";
            cboPeriodo.DataSource = Mant_PeriodoDataService.listarCboPeriodov2();
        }

        private void cboPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                coleccion = repo_CompensacionFaltanteDataService.listarCompensacionesFaltantes(Convert.ToInt32(cboPeriodo.SelectedValue.ToString().Trim()));
                dgCompensacionFaltante.DataSource = coleccion;
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
                string anio = "";
                if (Convert.ToInt32(cboPeriodo.SelectedValue.ToString().Trim()) == 0)
                {
                    anio = "Todos";
                }
                else
                {
                    anio = cboPeriodo.SelectedValue.ToString().Trim();
                }

                if (txtContribuyente.Text.Trim().Length > 0)
                {
                    coleccion = coleccion = repo_CompensacionFaltanteDataService.buscar(Convert.ToInt32(cboPeriodo.SelectedValue.ToString()), txtContribuyente.Text.Trim());
                }
                else
                {
                    coleccion = repo_CompensacionFaltanteDataService.listarCompensacionesFaltantes(Convert.ToInt32(cboPeriodo.SelectedValue.ToString()));
                }
                
                frmVisor.reportViewer1.LocalReport.DataSources.Clear();
                frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._5_Reportes_Gestion.Rep_CompensacionFaltante.rptCompensacionFaltante.rdlc";
                frmVisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsCompensacionFaltante", coleccion));
                
                ReportParameter[] paramsx = new ReportParameter[3];
                paramsx[0] = new ReportParameter("FechaImpresion", DateTime.Today.ToString());
                paramsx[1] = new ReportParameter("Usuario", GlobalesV1.Global_str_Nombre);
                paramsx[2] = new ReportParameter("Anio", anio);

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

        private void txtContribuyente_TextChanged(object sender, EventArgs e)
        {
            coleccion = repo_CompensacionFaltanteDataService.buscar(Convert.ToInt32(cboPeriodo.SelectedValue.ToString()), txtContribuyente.Text.Trim());
            dgCompensacionFaltante.DataSource = coleccion;
        }
    }
}
