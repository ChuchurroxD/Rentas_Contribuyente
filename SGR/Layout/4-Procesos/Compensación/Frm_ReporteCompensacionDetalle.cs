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
    public partial class Frm_ReporteCompensacionDetalle : Form
    {
        private string persona;
        private string tributo;
        private int compensacion_id;
        private string documento;
        private string persona_id;
        private Liqu_CompensacionDataService liqu_CompensacionDataService = new Liqu_CompensacionDataService();
        private List<Liqu_Compensacion> coleccion = new List<Liqu_Compensacion>();

        public Frm_ReporteCompensacionDetalle()
        {
            InitializeComponent();
        }

        public Frm_ReporteCompensacionDetalle(string persona, string tributo, int compensacion_id, string persona_id, string documento)
        {
            InitializeComponent();
            this.persona = persona;
            this.tributo = tributo;
            this.compensacion_id = compensacion_id;
            this.persona_id = persona_id;
            this.documento = documento;
        }
        
        private void Frm_ReporteCompensacionDetalle_Load(object sender, EventArgs e)
        {
            lblNombre.Text = persona;
            lblDocumento.Text = documento;
            lblCodigo.Text = persona_id;
            lblCompensacion_id.Text = compensacion_id.ToString();
            lblTributo.Text = tributo;
            dgCompensacionDetalle.DataSource = liqu_CompensacionDataService.listarCompensacionesDetalle(compensacion_id);
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
                frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._4_Procesos.Compensación.rptCompensacionesDetalle.rdlc";


                coleccion = liqu_CompensacionDataService.listarCompensacionesDetalle(compensacion_id);
                //dataGridView1.DataSource = coleccion;


                frmVisor.reportViewer1.LocalReport.DataSources.Add(
                    new Microsoft.Reporting.WinForms.ReportDataSource("dsCompensacionDetalle", coleccion));

                ReportParameter[] paramsx = new ReportParameter[7];
                paramsx[0] = new ReportParameter("FechaImpresion", DateTime.Today.ToString());
                paramsx[1] = new ReportParameter("Usuario", GlobalesV1.Global_str_Nombre);
                paramsx[2] = new ReportParameter("Tributo", tributo);
                paramsx[3] = new ReportParameter("Documento", documento);
                paramsx[4] = new ReportParameter("RazonSocial", persona);
                paramsx[5] = new ReportParameter("CodigoContribuyente", persona_id);
                paramsx[6] = new ReportParameter("CodigoCompensacion", compensacion_id.ToString());

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
    }
}
