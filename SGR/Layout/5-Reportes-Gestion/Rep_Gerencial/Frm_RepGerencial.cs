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

namespace SGR.WinApp.Layout._5_Reportes_Gestion.Rep_Gerencial
{
    public partial class Frm_RepGerencial : DockContent
    {
        Mant_PeriodoDataService mant_PeriodoDataService = new Mant_PeriodoDataService();
        Repo_GerencialDataService repo_GerencialDataService = new Repo_GerencialDataService();
        List<Repo_Gerencial> coleccion = new List<Repo_Gerencial>();

        public Frm_RepGerencial()
        {
            InitializeComponent();
        }

        private void Frm_RepGerencial_Load(object sender, EventArgs e)
        {
            llenarcomboPeriodo();
            //crearReportes();
        }

        private void llenarcomboPeriodo()
        {
            try
            {
                List<Mant_Periodo> coleccion1 = new List<Mant_Periodo>();
                coleccion1 = mant_PeriodoDataService.llenarPeriodo();

                //cboPeriodo1.SelectedIndexChanged -= new EventHandler(cboPeriodo1_SelectedIndexChanged);
                //cboPeriodo2.SelectedIndexChanged -= new EventHandler(cboPeriodo2_SelectedIndexChanged);
                //cboPeriodo3.SelectedIndexChanged -= new EventHandler(cboPeriodo3_SelectedIndexChanged);
                //cboPeriodo4.SelectedIndexChanged -= new EventHandler(cboPeriodo4_SelectedIndexChanged);

                cboPeriodo1.DisplayMember = "Peric_canio";
                cboPeriodo1.ValueMember = "Peric_canio";
                cboPeriodo1.DataSource = coleccion1;
                cboPeriodo1.SelectedValue = DateTime.Now.Year;

                cboPeriodo2.DisplayMember = "Peric_canio";
                cboPeriodo2.ValueMember = "Peric_canio";
                cboPeriodo2.DataSource = coleccion1;
                cboPeriodo2.SelectedValue = DateTime.Now.Year;

                cboPeriodo3.DisplayMember = "Peric_canio";
                cboPeriodo3.ValueMember = "Peric_canio";
                cboPeriodo3.DataSource = coleccion1;
                cboPeriodo3.SelectedValue = DateTime.Now.Year;

                cboPeriodo4.DisplayMember = "Peric_canio";
                cboPeriodo4.ValueMember = "Peric_canio";
                cboPeriodo4.DataSource = coleccion1;
                cboPeriodo4.SelectedValue = DateTime.Now.Year;

                //cboPeriodo1.SelectedIndexChanged += new EventHandler(cboPeriodo1_SelectedIndexChanged);
                //cboPeriodo2.SelectedIndexChanged += new EventHandler(cboPeriodo2_SelectedIndexChanged);
                //cboPeriodo3.SelectedIndexChanged += new EventHandler(cboPeriodo3_SelectedIndexChanged);
                //cboPeriodo4.SelectedIndexChanged += new EventHandler(cboPeriodo4_SelectedIndexChanged);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void crearReportes()
        {
            coleccion = repo_GerencialDataService.ingresoMes(Convert.ToInt32(cboPeriodo1.SelectedValue.ToString().Trim()));
            this.reportViewer1.RefreshReport();
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._5_Reportes_Gestion.Rep_Gerencial.rpt_IngresosMes.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsRepoGerencial", coleccion));
            reportViewer1.RefreshReport();

            coleccion = repo_GerencialDataService.porTipoPago(Convert.ToInt32(cboPeriodo1.SelectedValue.ToString().Trim()));
            this.reportViewer2.RefreshReport();
            reportViewer2.LocalReport.DataSources.Clear();
            reportViewer2.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._5_Reportes_Gestion.Rep_Gerencial.rpt_TipoPago.rdlc";
            reportViewer2.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsRepoGerencial", coleccion));
            reportViewer2.RefreshReport();

            coleccion = repo_GerencialDataService.fraccionamientoMes(Convert.ToInt32(cboPeriodo1.SelectedValue.ToString().Trim()));
            this.reportViewer3.RefreshReport();
            reportViewer3.LocalReport.DataSources.Clear();
            reportViewer3.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._5_Reportes_Gestion.Rep_Gerencial.rpt_Fraccionamiento.rdlc";
            reportViewer3.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsRepoGerencial", coleccion));
            reportViewer3.RefreshReport();

            coleccion = repo_GerencialDataService.emisionTributo(Convert.ToInt32(cboPeriodo1.SelectedValue.ToString().Trim()));
            this.reportViewer4.RefreshReport();
            reportViewer4.LocalReport.DataSources.Clear();
            reportViewer4.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._5_Reportes_Gestion.Rep_Gerencial.rpt_Emision.rdlc";
            reportViewer4.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsRepoGerencial", coleccion));
            reportViewer4.RefreshReport();
        }

        private void cboPeriodo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            coleccion = repo_GerencialDataService.ingresoMes(Convert.ToInt32(cboPeriodo1.SelectedValue.ToString().Trim()));
            this.reportViewer1.RefreshReport();
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._5_Reportes_Gestion.Rep_Gerencial.rpt_IngresosMes.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsRepoGerencial", coleccion));

            ReportParameter[] paramsx = new ReportParameter[1];
            paramsx[0] = new ReportParameter("Anio", cboPeriodo1.Text);
            reportViewer1.LocalReport.SetParameters(paramsx);

            reportViewer1.RefreshReport();
        }

        private void cboPeriodo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            coleccion = repo_GerencialDataService.porTipoPago(Convert.ToInt32(cboPeriodo2.SelectedValue.ToString().Trim()));
            this.reportViewer2.RefreshReport();
            reportViewer2.LocalReport.DataSources.Clear();
            reportViewer2.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._5_Reportes_Gestion.Rep_Gerencial.rpt_TipoPago.rdlc";
            reportViewer2.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsRepoGerencial", coleccion));

            ReportParameter[] paramsx = new ReportParameter[1];
            paramsx[0] = new ReportParameter("Anio", cboPeriodo2.Text);
            reportViewer2.LocalReport.SetParameters(paramsx);

            reportViewer2.RefreshReport();
        }

        private void cboPeriodo3_SelectedIndexChanged(object sender, EventArgs e)
        {
            coleccion = repo_GerencialDataService.fraccionamientoMes(Convert.ToInt32(cboPeriodo3.SelectedValue.ToString().Trim()));
            this.reportViewer3.RefreshReport();
            reportViewer3.LocalReport.DataSources.Clear();
            reportViewer3.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._5_Reportes_Gestion.Rep_Gerencial.rpt_Fraccionamiento.rdlc";
            reportViewer3.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsRepoGerencial", coleccion));

            ReportParameter[] paramsx = new ReportParameter[1];
            paramsx[0] = new ReportParameter("Anio", cboPeriodo3.Text);
            reportViewer3.LocalReport.SetParameters(paramsx);

            reportViewer3.RefreshReport();
        }

        private void cboPeriodo4_SelectedIndexChanged(object sender, EventArgs e)
        {
            coleccion = repo_GerencialDataService.emisionTributo(Convert.ToInt32(cboPeriodo4.SelectedValue.ToString().Trim()));
            this.reportViewer4.RefreshReport();
            reportViewer4.LocalReport.DataSources.Clear();
            reportViewer4.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._5_Reportes_Gestion.Rep_Gerencial.rpt_Emision.rdlc";
            reportViewer4.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsRepoGerencial", coleccion));

            ReportParameter[] paramsx = new ReportParameter[1];
            paramsx[0] = new ReportParameter("Anio", cboPeriodo4.Text);
            reportViewer4.LocalReport.SetParameters(paramsx);

            reportViewer4.RefreshReport();
        }                
    }
}
