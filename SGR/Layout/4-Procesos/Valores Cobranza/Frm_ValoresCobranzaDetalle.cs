using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGR.Entity.Model;
using SGR.WinApp.Layout._5_Reportes_Gestion;
using Microsoft.Reporting.WinForms;
using SGR.Core.Service;
using System.IO;

namespace SGR.WinApp.Layout._4_Procesos.Valores_Cobranza
{
    public partial class Frm_ValoresCobranzaDetalle : Form
    {
        public Valo_ValoresCobranzaDataService valores = new Valo_ValoresCobranzaDataService();
        public Frm_ValoresCobranzaDetalle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var coleccion = new List<Valo_OrdenPago>();
                coleccion = valores.generarReporte(2016,"","3");
                Frm_Visor_Global frmVisor = new Frm_Visor_Global();
                frmVisor.reportViewer1.LocalReport.DataSources.Clear();
                frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._4_Procesos.Valores_Cobranza.rptValoresCobranza.rdlc";
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
    }
}
