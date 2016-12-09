using System;
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
    public partial class Frm_estadistico_3 : DockContent
    {
        Mant_PeriodoDataService mant_PeriodoDataService = new Mant_PeriodoDataService();
        private Core.Service.Combos.MesDataService mess = new MesDataService();
        private List<Entity.Model.Combos.Mes> mesese = new List<Mes>();
        Rep_EstadisticosDataService rep_EstadisticosDataService = new Rep_EstadisticosDataService();
        private List<Repo_estadistico2> coleccion;
        public Frm_estadistico_3()
        {
            InitializeComponent();
        }

        private void llenarcomboPeriodo()
        {
            try
            {
                cboPeriodo1.DisplayMember = "Peric_canio";
                cboPeriodo1.ValueMember = "Peric_canio";
                cboPeriodo1.DataSource = mant_PeriodoDataService.llenarPeriodo();

                cboPeriodo2.DisplayMember = "Peric_canio";
                cboPeriodo2.ValueMember = "Peric_canio";
                cboPeriodo2.DataSource = mant_PeriodoDataService.llenarPeriodo();               
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

        private void llenarcomboMes()
        {
            try
            {
                mesese = mess.listartodos();
                cboMes1.DisplayMember = "mes";
                cboMes1.ValueMember = "mes_ID";
                cboMes1.DataSource = mesese;

                mesese = mess.listartodos();
                cboMes2.DisplayMember = "mes";
                cboMes2.ValueMember = "mes_ID";
                cboMes2.DataSource = mesese;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void Frm_estadistico_3_Load(object sender, EventArgs e)
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

        private void btnComparativo_Click(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            Frm_Visor_Global frm_Visor_Global = new Frm_Visor_Global();
            try
            {
                coleccion = rep_EstadisticosDataService.ReportePagosMesComparado((Int32)cboPeriodo1.SelectedValue, Convert.ToInt32(cboMes1.SelectedValue.ToString()), (Int32)cboPeriodo2.SelectedValue, Convert.ToInt32(cboMes2.SelectedValue.ToString()));                
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._5_Reportes_Gestion.Rep_estadisticos.Reporte_de _Pagos_Comparativo.rdlc";
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", coleccion));

                ReportParameter[] paramsx = new ReportParameter[4];
                paramsx[0] = new ReportParameter("Anio", cboPeriodo1.Text);
                paramsx[1] = new ReportParameter("Anio2", cboPeriodo2.Text);
                //paramsx[1] = new ReportParameter("RucEmpresa", Globales.RucEmpresa);
                //paramsx[2] = new ReportParameter("NombreEmpresa", Globales.NombreEmpresa);
                paramsx[2] = new ReportParameter("Mes1", cboMes1.Text);
                paramsx[3] = new ReportParameter("Mes2", cboMes2.Text);
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
            Frm_Visor_Global frm_Visor_Global = new Frm_Visor_Global();
            try
            {
                coleccion = rep_EstadisticosDataService.ReportePagosMesComparado((Int32)cboPeriodo1.SelectedValue, Convert.ToInt32(cboMes1.SelectedValue.ToString()), (Int32)cboPeriodo2.SelectedValue, Convert.ToInt32(cboMes2.SelectedValue.ToString()));
                dgvPagosComparativo.DataSource = coleccion;
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
