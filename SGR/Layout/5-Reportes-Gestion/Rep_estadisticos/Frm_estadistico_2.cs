﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SGR.Core.Service;
using SGR.Entity;
using WeifenLuo.WinFormsUI.Docking;
using Microsoft.Reporting.WinForms;
using SGR.Entity.Model;
using System.IO;
using SGR.Entity;
using SGR.Core.Service.Combos;
using SGR.Entity.Model.Combos;

namespace SGR.WinApp.Layout._5_Reportes_Gestion.Rep_estadisticos
{
    public partial class Frm_estadistico_2 : DockContent
    {
        Mant_PeriodoDataService mant_PeriodoDataService = new Mant_PeriodoDataService();
        Rep_Estadistico1 rep_Estadistico1 = new Rep_Estadistico1();
        private List<Rep_Estadistico1> coleccion;
        private List<Rep_Estadistico1> coleccion2;
        private Core.Service.Combos.MesDataService mess = new MesDataService();
        private List<Entity.Model.Combos.Mes> mesese = new List<Mes>();
        SGR.Core.Service.Rep_EstadisticosDataService rep_EstadisticosDataService = new SGR.Core.Service.Rep_EstadisticosDataService();
        public Frm_estadistico_2()
        {
            InitializeComponent();
        }
        private void llenarcomboPeriodo()
        {
            try
            {
                cboPeriodo.DisplayMember = "Peric_canio";
                cboPeriodo.ValueMember = "Peric_canio";
                cboPeriodo.DataSource = mant_PeriodoDataService.llenarPeriodo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void llenarcomboMes()
        {
            try
            {
                mesese = mess.listartodos();
                cboMesInicio.DisplayMember = "mes";
                cboMesInicio.ValueMember = "mes_ID";
                cboMesInicio.DataSource = mesese;

                mesese = mess.listartodos();
                cboMesFinal.DisplayMember = "mes";
                cboMesFinal.ValueMember = "mes_ID";
                cboMesFinal.DataSource = mesese;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private string MesName(int mes, string name)
        {
            switch (mes)
            {
                case 1:
                    name = "Ene ";
                    break;
                case 2:
                    name = "Feb ";
                    break;
                case 3:
                    name = "Mar ";
                    break;
                case 4:
                    name = "Abr ";
                    break;
                case 5:
                    name = "May ";
                    break;
                case 6:
                    name = "Jun ";
                    break;
                case 7:
                    name = "Jul ";
                    break;
                case 8:
                    name = "Ago ";
                    break;
                case 9:
                    name = "Set ";
                    break;
                case 10:
                    name = "Oct ";
                    break;
                case 11:
                    name = "Nov ";
                    break;
                case 12:
                    name = "Dic ";
                    break;
            }
            return name;
        }

        private void Frm_estadistico_2_Load(object sender, EventArgs e)
        {
            try
            {
                llenarcomboPeriodo();
                llenarcomboMes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            Frm_Visor_Global frm_Visor_Global = new Frm_Visor_Global();
            try
            {
                coleccion = rep_EstadisticosDataService.ReporteCuentaCorrienteMeses((Int32)cboPeriodo.SelectedValue, Convert.ToInt32(cboMesInicio.SelectedValue.ToString()), Convert.ToInt32(cboMesFinal.SelectedValue.ToString()));
                coleccion2 = rep_EstadisticosDataService.ReporteCuentaCorrienteMesesTotal((Int32)cboPeriodo.SelectedValue, Convert.ToInt32(cboMesInicio.SelectedValue.ToString()), Convert.ToInt32(cboMesFinal.SelectedValue.ToString()));
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._5_Reportes_Gestion.Rep_estadisticos.Rep_estadistico2.rdlc";
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", coleccion));
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", coleccion2));

                ReportParameter[] paramsx = new ReportParameter[5];
                paramsx[0] = new ReportParameter("Anio", cboPeriodo.Text);
                paramsx[1] = new ReportParameter("RucEmpresa", Globales.RucEmpresa);
                paramsx[2] = new ReportParameter("NombreEmpresa", Globales.NombreEmpresa);
                paramsx[3] = new ReportParameter("MesInicio", cboMesInicio.Text);
                paramsx[4] = new ReportParameter("MesFinal", cboMesFinal.Text);
                //paramsx[4] = new ReportParameter("MesFin", comboBusquedaMesHasta.Text);
                //paramsx[5] = new ReportParameter("Oficina", comboBusquedaOficina.Text);
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                coleccion = rep_EstadisticosDataService.ReporteCuentaCorrienteMeses((Int32)cboPeriodo.SelectedValue, Convert.ToInt32(cboMesInicio.SelectedValue.ToString()), Convert.ToInt32(cboMesFinal.SelectedValue.ToString()));
                dgvReporte1.DataSource = coleccion;
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
