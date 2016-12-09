using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGR.Core.Service;
using SGR.Core.Service.Combos;
using SGR.Entity.Model;
using SGR.WinApp.Layout._5_Reportes_Gestion;
using Microsoft.Reporting.WinForms;

namespace SGR.WinApp.Layout._4_Procesos.Plataforma.ConsultarPlataforma
{
    public partial class Frm_Recibos : Form
    {
        private string persona_ID;
        private Mant_PeriodoDataService Mant_PeriodoDataService = new Mant_PeriodoDataService();
        private MesDataService MesDataService = new MesDataService();
        private Reci_ReciboDataService Reci_ReciboDataService = new Reci_ReciboDataService();
        private Liqu_LiquidacionDataService Liqui_LiquidacionDataService = new Liqu_LiquidacionDataService();
        private Reci_ReciboDataService reciboDS = new Reci_ReciboDataService();

        public Frm_Recibos()
        {
            InitializeComponent();
        }

        public Frm_Recibos(string persona_ID)
        {
            this.persona_ID = persona_ID;
            InitializeComponent();
        }

        private void Frm_Recibos_Load(object sender, EventArgs e)
        {
            try
            {
                if(persona_ID != null)
                {
                    llenarPeriodo();
                    cboPeriodo.SelectedValue = Mant_PeriodoDataService.GetPeriodoActivo();
                    llenarMeses();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void llenarPeriodo()
        {
            cboPeriodo.DisplayMember = "Peric_canio";
            cboPeriodo.ValueMember = "Peric_canio";
            cboPeriodo.DataSource = Mant_PeriodoDataService.llenarPeriodo();
        }
        private void llenarMeses()
        { 
            cboMesInicial.DisplayMember = "mes";
            cboMesInicial.ValueMember = "mes_ID";
            cboMesInicial.DataSource = MesDataService.listartodos(); 

            cboMesFinal.DisplayMember = "mes";
            cboMesFinal.ValueMember = "mes_ID";
            cboMesFinal.DataSource = MesDataService.listartodos(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = Reci_ReciboDataService.listarRecibosporContribuyente(persona_ID, Convert.ToInt16(cboMesInicial.SelectedValue), Convert.ToInt16(cboMesFinal.SelectedValue), Convert.ToInt16(cboPeriodo.SelectedValue));
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "imprimir")
                {


                    var coleccion = new List<Reci_ReciboDetalleReporte>();
                    Int32 anio = (Int32)dataGridView1.SelectedRows[0].Cells["anio"].Value;
                    Int32 codigo = (Int32)dataGridView1.SelectedRows[0].Cells["codigo"].Value;
                    Int32 nromes = (Int32)dataGridView1.SelectedRows[0].Cells["nromes"].Value;
                    coleccion = reciboDS.cargarRecibo(anio, codigo,nromes, persona_ID);
                    Frm_Visor_Global frmVisor = new Frm_Visor_Global();
                    frmVisor.reportViewer1.LocalReport.DataSources.Clear();
                    frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._4_Procesos.Recibo.rptEmisionRecibo.rdlc";
                    frmVisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("recibo", coleccion));
                    ReportParameter[] param = new ReportParameter[3];
                    param[0] = new ReportParameter("Empresa", Globales.NombreEmpresa);
                    param[1] = new ReportParameter("RucEmpresa", Globales.RucEmpresa);
                    param[2] = new ReportParameter("persona", persona_ID);
                    frmVisor.reportViewer1.LocalReport.SetParameters(param);

                    frmVisor.reportViewer1.RefreshReport();
                    frmVisor.StartPosition = FormStartPosition.CenterParent;
                    frmVisor.ShowDialog();
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name  == "copia")
                {
                    //reporte
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
