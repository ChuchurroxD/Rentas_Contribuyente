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
using SGR.WinApp.Layout._5_Reportes_Gestion;
using WeifenLuo.WinFormsUI.Docking;
using Microsoft.Reporting.WinForms;
using System.IO;

namespace SGR.WinApp.Layout._4_Procesos.Plataforma.ConsultarPlataforma
{
    public partial class Frm_Pagos : Form
    {
        private Conf_MultitablaDataService Conf_MultitablaDataService = new Conf_MultitablaDataService();
        private Pago_CajaDataService Pago_CajaDataService = new Pago_CajaDataService();
        private Pago_CajeroDataService Pago_CajeroDataService = new Pago_CajeroDataService();
        private Pago_PagoDataService Pago_PagoDataService = new Pago_PagoDataService();
        private string persona_ID;


        public Frm_Pagos()
        {
            InitializeComponent();
        }

        public Frm_Pagos(string persona_ID)
        {
            this.persona_ID = persona_ID;
            InitializeComponent();
        }

        private void llenarTipoPago()
        {
            cboTipoPago.DisplayMember = "Multc_vDescripcion";
            cboTipoPago.ValueMember = "Multc_cValor";
            cboTipoPago.DataSource = Conf_MultitablaDataService.listarCombov2("45");
        }
        private void llenarCajas()
        {
            cboCaja.DisplayMember = "Descripcion";
            cboCaja.ValueMember = "Caja_id";
            cboCaja.DataSource = Pago_CajaDataService.llenarcomboCajav2();
        }
        private void llenarCajero()
        {
            cboCajro.DisplayMember = "persona_desc";
            cboCajro.ValueMember = "Persona_id";
            cboCajro.DataSource = Pago_CajeroDataService.llenarcomboCajerov2();
        }

        private void Frm_Pagos_Load(object sender, EventArgs e)
        {
            try
            {
                llenarCajas();
                llenarCajero();
                llenarTipoPago();
                cboCajro.Visible = false;
                cboCaja.Visible = false;
                label2.Visible = false;
                label4.Visible = false;
                if (persona_ID != null)
                {
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataSource = Pago_PagoDataService.listarPagoporContribuyenteTipoCajeroCaja(persona_ID, cboCajro.SelectedValue.ToString(), cboTipoPago.SelectedValue.ToString(), Convert.ToInt32(cboCaja.SelectedValue),dtpFechaInicial.Value.AddDays(-1),dtpFechaFinal.Value);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //datagrid.AutoGenerateColumns = false;
            dataGridView1.DataSource = Pago_PagoDataService.listarPagoporContribuyenteTipoCajeroCaja(persona_ID, cboCajro.SelectedValue.ToString(), cboTipoPago.SelectedValue.ToString(), Convert.ToInt32(cboCaja.SelectedValue), dtpFechaInicial.Value.AddDays(-1), dtpFechaFinal.Value);
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "detalle")
                {
                    Frm_PagosDetalle frm_detalle = new Frm_PagosDetalle((Int32)dataGridView1.SelectedRows[0].Cells["pago_ID"].Value);
                    if (ActiveMdiChild != null)
                        ActiveMdiChild.Close();
                    frm_detalle.MdiParent = this.MdiParent;
                    frm_detalle.Show();
                    this.Dispose();
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "imprimir")
                {
                    int codigo = (Int32)dataGridView1.SelectedRows[0].Cells["pago_ID"].Value;                   
                    generarDetalle(codigo);
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

        public void generarDetalle(int codigo)
        {
            try
            {
                List<Pago_PagoDetalleTributo> coleccion = new List<Pago_PagoDetalleTributo>();
                Frm_Visor_Global frm_Visor_Global = new Frm_Visor_Global();

                coleccion = Pago_PagoDataService.listarDetalleTributov2(codigo);
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._4_Procesos.Plataforma.ConsultarPlataforma.Rep_detallePago.rdlc";
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", coleccion));
                
                ReportParameter[] paramsx = new ReportParameter[4];
                paramsx[0] = new ReportParameter("NombreEmpresa", Globales.NombreEmpresa);
                paramsx[1] = new ReportParameter("RucEmpresa", Globales.RucEmpresa);
                paramsx[2] = new ReportParameter("Fechadesde", dtpFechaInicial.Text);
                paramsx[3] = new ReportParameter("Fechahasta", dtpFechaFinal.Text);               
                frm_Visor_Global.reportViewer1.LocalReport.SetParameters(paramsx);
                frm_Visor_Global.reportViewer1.RefreshReport();
                frm_Visor_Global.StartPosition = FormStartPosition.CenterScreen;
                frm_Visor_Global.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        private void btn_reporte_Click(object sender, EventArgs e)
        {
            try
            {
                List<Pago_Pago> coleccion = new List<Pago_Pago>();
                Frm_Visor_Global frm_Visor_Global = new Frm_Visor_Global();

                coleccion = Pago_PagoDataService.listarPagoporContribuyenteTipoCajeroCaja(persona_ID, cboCajro.SelectedValue.ToString(), cboTipoPago.SelectedValue.ToString(), Convert.ToInt32(cboCaja.SelectedValue), dtpFechaInicial.Value.AddDays(-1), dtpFechaFinal.Value);
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._4_Procesos.Plataforma.ConsultarPlataforma.Rep_pagos.rdlc";
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", coleccion));

                ReportParameter[] paramsx = new ReportParameter[4];
                paramsx[0] = new ReportParameter("NombreEmpresa", Globales.NombreEmpresa);
                paramsx[1] = new ReportParameter("RucEmpresa", Globales.RucEmpresa);
                paramsx[2] = new ReportParameter("Fechadesde", dtpFechaInicial.Text);
                paramsx[3] = new ReportParameter("Fechahasta", dtpFechaFinal.Text);
                frm_Visor_Global.reportViewer1.LocalReport.SetParameters(paramsx);

                frm_Visor_Global.reportViewer1.RefreshReport();
                frm_Visor_Global.StartPosition = FormStartPosition.CenterScreen;
                frm_Visor_Global.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
