using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGR.Core.Service;
using SGR.Entity.Model;
using SGR.Entity;
using SGR.Core.Service.Combos;
using SGR.WinApp.Layout._5_Reportes_Gestion;
using Microsoft.Reporting.WinForms;

namespace SGR.WinApp.Layout._4_Procesos.Plataforma.ConsultarPlataforma
{
    public partial class Frm_Liquidaciones : Form
    {
        private Mant_PeriodoDataService Mant_PeriodoDataService = new Mant_PeriodoDataService();
        private Liqu_LiquidacionDataService Liqu_LiquidacionDataService = new Liqu_LiquidacionDataService();
        private MesDataService MesDataService = new MesDataService();
        private Liqu_Liquidacion liquidacion = new Liqu_Liquidacion();
        private Mant_Cont mant_Cont;

        public Frm_Liquidaciones()
        {
            InitializeComponent();
        }

        public Frm_Liquidaciones(Mant_Cont mant_Cont)
        {
            this.mant_Cont = mant_Cont;
            InitializeComponent();
        }

        private void llenarPeriodo()
        {
            cboPeriodo.DisplayMember = "Peric_vdescripcion";
            cboPeriodo.ValueMember = "Peric_canio";
            cboPeriodo.DataSource = Mant_PeriodoDataService.listarCboPeriodov2();
        }
        private void llenarMes()
        {
            cboMes.DisplayMember = "mes";
            cboMes.ValueMember = "mes_ID";
            cboMes.DataSource = MesDataService.listarTodosv2().OrderBy(x => Convert.ToInt16(x.mes_ID)).ToList();
        }
        private void totales()
        {
            liquidacion = Liqu_LiquidacionDataService.listarTotalContribuyente(mant_Cont.persona_ID, Convert.ToInt16(cboMes.SelectedValue), Convert.ToInt16(cboPeriodo.SelectedValue));
            lblTotalImporte.Text = "S/. " + liquidacion.importe.ToString();
            lblTotalInteres.Text = "S/. " + liquidacion.Intereses.ToString();
            lblTotal.Text = "S/. " + liquidacion.total_final.ToString();
        }

        private void Frm_Liquidaciones_Load(object sender, EventArgs e)
        {
            if(mant_Cont != null)
            {
                llenarPeriodo();
                llenarMes();
                totales();
            }
            
        }

        private void cboPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMes.Items.Count > 0)
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = Liqu_LiquidacionDataService.listarLiquiContribuyente(mant_Cont.persona_ID, Convert.ToInt16(cboMes.SelectedValue), Convert.ToInt16(cboPeriodo.SelectedValue));
                totales();
            }
        }

        private void cboMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPeriodo.Items.Count > 0)
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = Liqu_LiquidacionDataService.listarLiquiContribuyente(mant_Cont.persona_ID, Convert.ToInt16(cboMes.SelectedValue), Convert.ToInt16(cboPeriodo.SelectedValue));
                totales();
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                int liquidacion_ID = (Int32)dataGridView1.SelectedRows[0].Cells["liquidacion_ID"].Value;
                if (dataGridView1.Columns[e.ColumnIndex].Name == "detalle")
                {
                    Frm_LiquidacionesDetalle frm_detalle = new Frm_LiquidacionesDetalle(liquidacion_ID);
                         if (ActiveMdiChild != null)
                            ActiveMdiChild.Close();
                    frm_detalle.MdiParent = this.MdiParent;
                    frm_detalle.Show();
                    this.Dispose();
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "print")
                {
                    var coleccion = Liqu_LiquidacionDataService.mostrarLiquidacionTodos(liquidacion_ID);
                    Frm_Visor_Global frmVisor = new Frm_Visor_Global();
                    frmVisor.reportViewer1.LocalReport.DataSources.Clear();
                    frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._4_Procesos.Liquidacion.rptLiquidacionDetalle.rdlc";
                    frmVisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", coleccion));
                    ReportParameter[] param = new ReportParameter[14];
                    param[0] = new ReportParameter("Empresa", Globales.NombreEmpresa);
                    param[1] = new ReportParameter("RucEmpresa", Globales.RucEmpresa);
                    param[2] = new ReportParameter("Codigo", mant_Cont.persona_ID);
                    param[3] = new ReportParameter("DNI", mant_Cont.documento);
                    param[4] = new ReportParameter("Nombres", mant_Cont.nombres);
                    param[5] = new ReportParameter("TipoEm", "PRED+ARBITR");
                    param[6] = new ReportParameter("Domicilio", mant_Cont.direccCompleta);
                    param[7] = new ReportParameter("Predio", "Todos");
                    param[8] = new ReportParameter("Ubicacion", " ");
                    param[9] = new ReportParameter("total", lblTotal.Text);
                    param[10] = new ReportParameter("TotalIntereses", lblTotalInteres.Text);
                    param[11] = new ReportParameter("TotalLiquidar", lblTotalImporte.Text);
                    param[12] = new ReportParameter("Usuario", Globales.UsuarioPrueba);
                    param[13] = new ReportParameter("liquidacion_ID", Convert.ToString(dataGridView1.SelectedRows[0].Cells["liquidacion_ID"].Value));

                    frmVisor.reportViewer1.LocalReport.SetParameters(param);
                    frmVisor.reportViewer1.RefreshReport();
                    frmVisor.StartPosition = FormStartPosition.CenterParent;
                    frmVisor.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
    }
}
