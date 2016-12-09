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

namespace SGR.WinApp.Layout._4_Procesos.Compensación
{
    public partial class Frm_Compensacion_Contribuyente : Form
    {
        private Mant_Per_Cont mant_Per_Cont;
        private Liqu_DeudaDataService Liqu_Deuda = new Liqu_DeudaDataService();
        private Liqu_CompensacionDataService liqu_CompensacionDataService = new Liqu_CompensacionDataService();
        private Mant_ContribuyenteDataService mant_Contribuyente = new Mant_ContribuyenteDataService();
        private Mant_Contribuyente contribuyente = new Mant_Contribuyente();
        private Liqu_LiquidacionDataService liquidacionService = new Liqu_LiquidacionDataService();
        private List<Liqu_Compensacion> coleccion = new List<Liqu_Compensacion>();

        public Frm_Compensacion_Contribuyente()
        {
            InitializeComponent();
        }

        public Frm_Compensacion_Contribuyente(Mant_Per_Cont mant_Per_Cont)
        {
            InitializeComponent();
            this.mant_Per_Cont = mant_Per_Cont;

            inicializar();
            if (dataGridView1.RowCount == 0)
            {
                //MessageBox.Show("El contribuyente seleccionado no tiene deuda pendiente", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw new Exception("El contribuyente seleccionado no tiene deuda pendiente.");
                //this.Close();
            }
        }

        public void inicializar()
        {
            lblNombre.Text = mant_Per_Cont.nombres;
            lblDireccion.Text = mant_Per_Cont.direccCompleta;
            lblCodigo.Text = mant_Per_Cont.persona_ID;
            lblDocumento.Text = mant_Per_Cont.documento;
            llenarGrillas();
        }

        public void llenarGrillas()
        {
            //dataGridView1.DataSource = Liqu_Deuda.listartodos(mant_Per_Cont.persona_ID);
            dataGridView1.DataSource = liqu_CompensacionDataService.listartodos(mant_Per_Cont.persona_ID);
            calcularTotales();

            dgCompensacion.DataSource = liqu_CompensacionDataService.listarCompensaciones(mant_Per_Cont.persona_ID);
        }

        public void calcularTotales()
        {
            int cantidad;
            decimal montoTotal = 0, montoTotalVencido = 0, interes = 0, montoTotalFinal = 0, m1, m2, m3, m4;
            cantidad = dataGridView1.RowCount;
            for (int i = 0; i < cantidad; i++)
            {
                m1 = (decimal)dataGridView1.Rows[i].Cells["xmonto"].Value;
                m2 = (decimal)dataGridView1.Rows[i].Cells["xinteres"].Value;
                m3 = (decimal)dataGridView1.Rows[i].Cells["xtotal"].Value;
                m4 = (decimal)dataGridView1.Rows[i].Cells["xdeudaVencida"].Value;
                montoTotal = montoTotal + m1;
                montoTotalVencido = montoTotalVencido + m4;
                interes = interes + m2;
                montoTotalFinal = montoTotalFinal + m3;
            }

            txtTotal.Text = Convert.ToString(montoTotal);
            txtInteres.Text = Convert.ToString(interes);
            txtTotalFinal.Text = Convert.ToString(montoTotalFinal);
            txtDeudaVencida.Text = Convert.ToString(montoTotalVencido);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "xdetalles")
            {
                try
                {
                    string persona, predio, grupo_trib;
                    Liqu_Liquidacion elemento = new Liqu_Liquidacion();
                    persona = (string)dataGridView1.Rows[e.RowIndex].Cells["xpersona"].Value;
                    predio = (string)dataGridView1.Rows[e.RowIndex].Cells["xpredio"].Value;
                    grupo_trib = (string)dataGridView1.Rows[e.RowIndex].Cells["xtributo"].Value;
                    Frm_Compensacion_Detalle frm_Compensacion_Detalle = new Frm_Compensacion_Detalle(persona, predio, grupo_trib,
                        mant_Per_Cont.nombres, mant_Per_Cont.documento, mant_Per_Cont.persona_ID, mant_Per_Cont.direccCompleta);
                    frm_Compensacion_Detalle.StartPosition = FormStartPosition.CenterParent;
                    frm_Compensacion_Detalle.ShowDialog();
                    //dataGridView1.DataSource = Liqu_Deuda.listartodos(mant_Per_Cont.persona_ID);
                    dataGridView1.DataSource = liqu_CompensacionDataService.listartodos(mant_Per_Cont.persona_ID);
                    calcularTotales();
                    dgCompensacion.DataSource = liqu_CompensacionDataService.listarCompensaciones(mant_Per_Cont.persona_ID);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dgCompensacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgCompensacion.Columns[e.ColumnIndex].Name == "detalles")
            {
                try
                {
                    string persona, grupo_trib;
                    int compensacion_id;
                    Liqu_Liquidacion elemento = new Liqu_Liquidacion();
                    persona = (string)dgCompensacion.Rows[e.RowIndex].Cells["nombrePersonaC"].Value;
                    grupo_trib = (string)dgCompensacion.Rows[e.RowIndex].Cells["tributos_descripC"].Value;
                    compensacion_id = Convert.ToInt32(dgCompensacion.Rows[e.RowIndex].Cells["compensacion_idC"].Value.ToString().Trim());
                    Frm_ReporteCompensacionDetalle frm_ReporteCompensacionDetalle = new Frm_ReporteCompensacionDetalle(persona, grupo_trib, compensacion_id, mant_Per_Cont.persona_ID, mant_Per_Cont.documento);
                    frm_ReporteCompensacionDetalle.StartPosition = FormStartPosition.CenterParent;
                    frm_ReporteCompensacionDetalle.ShowDialog();
                    //dataGridView1.DataSource = Liqu_Deuda.listartodos(mant_Per_Cont.persona_ID);
                    dgCompensacion.DataSource = liqu_CompensacionDataService.listarCompensaciones(mant_Per_Cont.persona_ID);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void botonGenerarReporte_Click(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                Frm_Visor_Global frmVisor = new Frm_Visor_Global();
                frmVisor.reportViewer1.LocalReport.DataSources.Clear();
                frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._4_Procesos.Compensación.rptCompensaciones.rdlc";

               
                coleccion = liqu_CompensacionDataService.listarCompensaciones(mant_Per_Cont.persona_ID);
                //dataGridView1.DataSource = coleccion;


                frmVisor.reportViewer1.LocalReport.DataSources.Add(
                    new Microsoft.Reporting.WinForms.ReportDataSource("dsCompensaciones", coleccion));

                ReportParameter[] paramsx = new ReportParameter[5];
                paramsx[0] = new ReportParameter("FechaImpresion", DateTime.Today.ToString());
                paramsx[1] = new ReportParameter("Usuario", GlobalesV1.Global_str_Nombre);
                paramsx[2] = new ReportParameter("RazonSocial", mant_Per_Cont.nombres);
                paramsx[3] = new ReportParameter("Direccion", mant_Per_Cont.direccCompleta);
                paramsx[4] = new ReportParameter("Codigo", mant_Per_Cont.persona_ID);

                frmVisor.reportViewer1.LocalReport.SetParameters(paramsx);

                frmVisor.reportViewer1.RefreshReport();
                frmVisor.StartPosition = FormStartPosition.CenterParent;
                frmVisor.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_Compensacion_Contribuyente_Load(object sender, EventArgs e)
        {

        }
    }
}
