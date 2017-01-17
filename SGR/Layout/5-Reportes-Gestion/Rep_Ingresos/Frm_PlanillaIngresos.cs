using Microsoft.Reporting.WinForms;
using SGR.Core.Service;
using SGR.Core.Service.Combos;
using SGR.Entity.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace SGR.WinApp.Layout._5_Reportes_Gestion.Rep_Ingresos
{
    public partial class Frm_PlanillaIngresos : DockContent
    {
        Pago_OficinaDataService pago_OficinaDataService = new Pago_OficinaDataService();
        Repo_PlanillaIngresos repo_PlanillaIngresos = new Repo_PlanillaIngresos();
        private List<Repo_PlanillaIngresos> coleccion;
        Repo_PlanillaIngresosDataService repo_PlanillaIngresosDataService = new Repo_PlanillaIngresosDataService();
        Pago_PersonaDataService persona = new Pago_PersonaDataService();
        public Frm_PlanillaIngresos()
        {
            InitializeComponent();
        }
        public void llenarComboOficina()
        {
            comboBusquedaOficina.DisplayMember = "Descripcion";
            comboBusquedaOficina.ValueMember = "oficina_id";
            comboBusquedaOficina.DataSource = pago_OficinaDataService.listarComboOficinaCajero(GlobalesV1.Global_int_idoficina);
        }
        private void Frm_PlanillaIngresos_Load(object sender, EventArgs e)
        {
            try
            {
                llenarComboOficina();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void botonListar_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked == false)
                {
                    coleccion = repo_PlanillaIngresosDataService.listarPorFechaDesdeHasta(dtpFechaDesde.Value.ToShortDateString().Trim(),
                        dtpFechaHasta.Value.ToShortDateString().Trim(), (Int32)comboBusquedaOficina.SelectedValue);
                    dgvListadoPlanillaIngresos.DataSource = coleccion;
                } else
                {
                    coleccion = repo_PlanillaIngresosDataService.listarPorFechaDesdeHastaContribuyente(dtpFechaDesde.Value.ToShortDateString().Trim(),
                        dtpFechaHasta.Value.ToShortDateString().Trim(), (Int32)comboBusquedaOficina.SelectedValue, (String)cboContribuyente.SelectedValue);
                    dgvListadoPlanillaIngresos.DataSource = coleccion;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listarPersonaN(String predio_id, string busqueda)
        {
            cboContribuyente.DisplayMember = "persona_Desc";
            cboContribuyente.ValueMember = "persona_ID";
            cboContribuyente.DataSource = persona.listarcontribuyentesPN(predio_id, 0, busqueda); ;
            this.cboContribuyente.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.cboContribuyente.AutoCompleteSource = AutoCompleteSource.CustomSource;            
        }

        private void botonReporte_Click(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            Frm_Visor_Global frm_Visor_Global = new Frm_Visor_Global();
            try
            {
                if (checkBox1.Checked == false)
                {
                    coleccion = repo_PlanillaIngresosDataService.listarPorFechaDesdeHasta(dtpFechaDesde.Value.ToShortDateString().Trim(),
                    dtpFechaHasta.Value.ToShortDateString().Trim(), (Int32)comboBusquedaOficina.SelectedValue);
                    frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                    frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._5_Reportes_Gestion.Rep_Ingresos.Reporte_PlanillaIngresos.rdlc";
                    frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetPlanillaIngresos", coleccion));

                    //INGRESAR LOGO EMPRESA - INICIO
                    List<Frac_CuentaFraccionada> List_CuentaFraccionada = new List<Frac_CuentaFraccionada>();
                    Frac_CuentaFraccionada frac_CuentaFraccionada = new Frac_CuentaFraccionada();
                    String _path = Path.Combine(Application.StartupPath, @"LogoCabecera.jpg");
                    frac_CuentaFraccionada.logoEmpresa = File.ReadAllBytes(_path);
                    frac_CuentaFraccionada.convenio = "convenio";
                    List_CuentaFraccionada.Add(frac_CuentaFraccionada);
                    Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new Microsoft.Reporting.WinForms.ReportDataSource("DataSetLogoEmpresa", List_CuentaFraccionada);
                    frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                    //LOGO EMPRESA FIN

                    ReportParameter[] paramsx = new ReportParameter[5];
                    paramsx[0] = new ReportParameter("UsuarioPrueba", GlobalesV1.Global_str_Usuario);
                    paramsx[1] = new ReportParameter("NombreEmpresa", Globales.NombreEmpresa);
                    paramsx[2] = new ReportParameter("FechaDesde", dtpFechaDesde.Text);
                    paramsx[3] = new ReportParameter("FechaHasta", dtpFechaHasta.Text);
                    paramsx[4] = new ReportParameter("Oficina", comboBusquedaOficina.Text);
                    frm_Visor_Global.reportViewer1.LocalReport.SetParameters(paramsx);
                    frm_Visor_Global.reportViewer1.RefreshReport();
                    frm_Visor_Global.StartPosition = FormStartPosition.CenterScreen;
                    frm_Visor_Global.ShowDialog();
                }
                else
                {
                    coleccion = repo_PlanillaIngresosDataService.listarPorFechaDesdeHastaContribuyente(dtpFechaDesde.Value.ToShortDateString().Trim(),
                        dtpFechaHasta.Value.ToShortDateString().Trim(), (Int32)comboBusquedaOficina.SelectedValue, (String)cboContribuyente.SelectedValue);
                    frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                    frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._5_Reportes_Gestion.Rep_Ingresos.Reporte_PlanillaIngresos.rdlc";
                    frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetPlanillaIngresos", coleccion));

                    //INGRESAR LOGO EMPRESA - INICIO
                    List<Frac_CuentaFraccionada> List_CuentaFraccionada = new List<Frac_CuentaFraccionada>();
                    Frac_CuentaFraccionada frac_CuentaFraccionada = new Frac_CuentaFraccionada();
                    String _path = Path.Combine(Application.StartupPath, @"LogoCabecera.jpg");
                    frac_CuentaFraccionada.logoEmpresa = File.ReadAllBytes(_path);
                    frac_CuentaFraccionada.convenio = "convenio";
                    List_CuentaFraccionada.Add(frac_CuentaFraccionada);
                    Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new Microsoft.Reporting.WinForms.ReportDataSource("DataSetLogoEmpresa", List_CuentaFraccionada);
                    frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                    //LOGO EMPRESA FIN

                    ReportParameter[] paramsx = new ReportParameter[5];
                    paramsx[0] = new ReportParameter("UsuarioPrueba", GlobalesV1.Global_str_Usuario);
                    paramsx[1] = new ReportParameter("NombreEmpresa", Globales.NombreEmpresa);
                    paramsx[2] = new ReportParameter("FechaDesde", dtpFechaDesde.Text);
                    paramsx[3] = new ReportParameter("FechaHasta", dtpFechaHasta.Text);
                    paramsx[4] = new ReportParameter("Oficina", comboBusquedaOficina.Text);
                    frm_Visor_Global.reportViewer1.LocalReport.SetParameters(paramsx);
                    frm_Visor_Global.reportViewer1.RefreshReport();
                    frm_Visor_Global.StartPosition = FormStartPosition.CenterScreen;
                    frm_Visor_Global.ShowDialog();
                }


                
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

        private void comboBusquedaOficina_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                coleccion = repo_PlanillaIngresosDataService.listarPorFechaDesdeHasta(dtpFechaDesde.Value.ToShortDateString().Trim(),
                    dtpFechaHasta.Value.ToShortDateString().Trim(), (Int32)comboBusquedaOficina.SelectedValue);
                dgvListadoPlanillaIngresos.DataSource = coleccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void botonResumen_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_PlanillaIngresosResumen frm_PlanillaIngresosResumen = new Frm_PlanillaIngresosResumen(dtpFechaDesde.Value, dtpFechaHasta.Value);
                frm_PlanillaIngresosResumen.StartPosition = FormStartPosition.CenterParent;
                frm_PlanillaIngresosResumen.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt_pagante.Focus();
                txt_pagante.Enabled = true;
                btnBusqueda.Enabled = true;
            } else {
                txt_pagante.Enabled = false;
                btnBusqueda.Enabled = false;
                txt_pagante.Clear();
                cboContribuyente.DataSource = null;
                cboContribuyente.Items.Clear();
                cboContribuyente.Enabled = false;
                coleccion = repo_PlanillaIngresosDataService.listarPorFechaDesdeHasta(dtpFechaDesde.Value.ToShortDateString().Trim(),
                dtpFechaHasta.Value.ToShortDateString().Trim(), (Int32)comboBusquedaOficina.SelectedValue);
                dgvListadoPlanillaIngresos.DataSource = coleccion;
            }                   
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_pagante.Text.TrimEnd().Length != 0)
                {
                    cboContribuyente.Enabled = true;
                    listarPersonaN("", txt_pagante.Text.TrimEnd());
                    //cboPersona.SelectedValue = persona_id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
