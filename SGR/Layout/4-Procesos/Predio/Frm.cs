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

namespace SGR.WinApp.Layout._4_Procesos.Predio
{
    public partial class Frm : Form
    {
        private Repo_PredioRusticoDataService repo_PredioRusticoDataService = new Repo_PredioRusticoDataService();
        private List<Repo_PredioRustico> Coleccion;
        private List<Repo_PredioRustico> ColeccionDI;
        string persona_ID;
        string razon_social;
        string documento;
        string DescripcionDocumento;
        public Frm()
        {
            InitializeComponent();
            persona_ID = "9170";
            razon_social= "GARCIA VERGARA VDA DE CASTELLANO LUZ CARMELA";
            DescripcionDocumento = "DNI";
            documento = "07205831";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fechaHoy = DateTime.Now;
            
            Cursor.Current = Cursors.WaitCursor;
            Frm_Visor_Global frm_Visor_Global = new Frm_Visor_Global();
            try
            {
                ///Coleccion = repo_PredioRusticoDataService.listarPredioRustico(persona_ID);
                //ColeccionDI = repo_PredioRusticoDataService.ListarImpuestoRustico(persona_ID);
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._5_Reportes_Gestion.Rep_Predio.Reporte_PredioRustico.rdlc";
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetRepoPredioRustico", Coleccion));
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetRepoDeterminacionImpuesto", ColeccionDI));
                ReportParameter[] paramsx = new ReportParameter[9];
                paramsx[0] = new ReportParameter("NombreEmpresa", "Municipalidad Distrital de Moche");
                paramsx[1] = new ReportParameter("UsuarioPrueba", "Usuario 01");
                paramsx[2] = new ReportParameter("Año", fechaHoy.Year.ToString());
                paramsx[3] = new ReportParameter("Dia", fechaHoy.Day.ToString());
                paramsx[4] = new ReportParameter("Mes", fechaHoy.Month.ToString());
                paramsx[5] = new ReportParameter("persona_ID", persona_ID);
                paramsx[6] = new ReportParameter("razon_social", razon_social);
                paramsx[7] = new ReportParameter("documento", documento);
                paramsx[8] = new ReportParameter("DescripcionDocumento", DescripcionDocumento);
                frm_Visor_Global.reportViewer1.LocalReport.SetParameters(paramsx);
                frm_Visor_Global.reportViewer1.RefreshReport();
                frm_Visor_Global.StartPosition = FormStartPosition.CenterScreen;
                frm_Visor_Global.ShowDialog();
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

        private void button3_Click(object sender, EventArgs e)
        {
            //Cursor.Current = Cursors.WaitCursor;
            //Frm_Visor_Global frm_Visor_Global = new Frm_Visor_Global();
            //try
            //{

            //    frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
            //frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._5_Reportes_Gestion.Rep_Alcabala.Alcabala.rdlc";
            //    frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetRepoPredioRustico", Coleccion));
            //    frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetRepoDeterminacionImpuesto", ColeccionDI));
            //    ReportParameter[] paramsx = new ReportParameter[9];
            //    paramsx[0] = new ReportParameter("NombreEmpresa", "Municipalidad Distrital de Moche");
            //    paramsx[1] = new ReportParameter("UsuarioPrueba", "Usuario 01");
            //    paramsx[2] = new ReportParameter("Año", fechaHoy.Year.ToString());
            //    paramsx[3] = new ReportParameter("Dia", fechaHoy.Day.ToString());
            //    paramsx[4] = new ReportParameter("Mes", fechaHoy.Month.ToString());
            //    paramsx[5] = new ReportParameter("persona_ID", persona_ID);
            //    paramsx[6] = new ReportParameter("razon_social", razon_social);
            //    paramsx[7] = new ReportParameter("documento", documento);
            //    paramsx[8] = new ReportParameter("DescripcionDocumento", DescripcionDocumento);
            //    frm_Visor_Global.reportViewer1.LocalReport.SetParameters(paramsx);
            //    frm_Visor_Global.reportViewer1.RefreshReport();
            //frm_Visor_Global.StartPosition = FormStartPosition.CenterScreen;
            //frm_Visor_Global.ShowDialog();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            //}
            //finally
            //{
            //    Cursor.Current = Cursors.Default;
            //}
        }

        private void Frm_Load(object sender, EventArgs e)
        {

        }
    }
}
