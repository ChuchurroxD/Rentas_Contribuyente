using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGR.Core.Service;
using SGR.Core;
using SGR.Entity;
using SGR.Entity.Model;
using SGR.WinApp.Layout._5_Reportes_Gestion;
using System.IO;
using Microsoft.Reporting.WinForms;

namespace SGR.WinApp.Layout._4_Procesos.Predio.Otros
{
    public partial class Frm_CertificadoContribuyente : Form
    {
        private Pred_PredioContribuyenteDataService Pred_PredioContribuyenteDataService = new Pred_PredioContribuyenteDataService();
        private string persona_id = "";
        private string persona_name = "";
        private string direccionpersona = "";
        private string periodo = "";
        private List<Mant_Banco> coleccion;
        public Frm_CertificadoContribuyente(string per_id, string name,string direccion,string periodo)
        {
            InitializeComponent();
            this.persona_id = per_id;
            this.persona_name = name;
            this.direccionpersona = direccion;
            this.periodo = periodo;
        }

        private void btnVerAlcabalaAl_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Frm_Visor_Global frm_Visor_Global = new Frm_Visor_Global();
            try
            {
                coleccion = Pred_PredioContribuyenteDataService.listarPr(periodo, persona_id);
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._5_Reportes_Gestion.Rep_Contribuyente.Certificado_COntribuyente.rdlc";
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", coleccion));


                List<Frac_CuentaFraccionada> origen2 = new List<Frac_CuentaFraccionada>();
                Frac_CuentaFraccionada elementoo = new Frac_CuentaFraccionada();
                string _path = Path.Combine(Application.StartupPath, @"LogoCabecera.jpg");
                elementoo.logoEmpresa = File.ReadAllBytes(_path);
                elementoo.convenio = "convenio";
                origen2.Add(elementoo);
                ReportDataSource dataSourceEmpresa = new ReportDataSource("DataSet2", origen2);
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(dataSourceEmpresa);
                ReportParameter[] paramsx = new ReportParameter[6];
                 paramsx[0] = new ReportParameter("Anio", periodo);
                paramsx[1] = new ReportParameter("Persona", persona_name);
                paramsx[2] = new ReportParameter("Domicilio", direccionpersona);
                paramsx[3] = new ReportParameter("Fecha", txtFecha.Text);
                paramsx[4] = new ReportParameter("Expediente", txtExpediente.Text);
                paramsx[5] = new ReportParameter("Recibo", txtRecibo.Text);
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
    }
}
