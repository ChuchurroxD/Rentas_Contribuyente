using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using SGR.Entity.Model;
using SGR.WinApp.Layout._5_Reportes_Gestion;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using SGR.Core.Service;

namespace SGR.WinApp.Layout._4_Procesos.Recibo
{
    public partial class Frm_ReciboDetalle : Form
    {
        private Liqu_LiquidacionDataService Liqui_LiquidacionDataService = new Liqu_LiquidacionDataService();
        private Reci_ReciboDataService recibos = new Reci_ReciboDataService();
        private List<Reci_ReciboDetalleReporte> coleccion;
        public Frm_ReciboDetalle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            Frm_Visor_Global frm_Visor_Global = new Frm_Visor_Global();
            try {
                coleccion = recibos.cargarRecibo(2016, 40394, 1, "10994");
                Frm_Visor_Global frmVisor = new Frm_Visor_Global();
                frmVisor.reportViewer1.LocalReport.DataSources.Clear();
                frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._4_Procesos.Recibo.rptEmisionRecibo.rdlc";
                frmVisor.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("recibo", coleccion));
                ReportParameter[] param = new ReportParameter[3];
                param[0] = new ReportParameter("Empresa", Globales.NombreEmpresa);
                param[1] = new ReportParameter("RucEmpresa", Globales.RucEmpresa);
                param[2] = new ReportParameter("persona", "1509");
                frmVisor.reportViewer1.LocalReport.SetParameters(param);
                frmVisor.reportViewer1.RefreshReport();
                frmVisor.StartPosition = FormStartPosition.CenterParent;
                frmVisor.ShowDialog();
            }catch(Exception ex)
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
