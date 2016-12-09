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
using SGR.Core;
namespace SGR.WinApp.Layout._4_Procesos.Predio
{
    public partial class Frm_Historial : Form
    {
        private Pred_PredioDataService predioDataService = new Pred_PredioDataService();
        private Mant_PeriodoDataService PeriodoDataService = new Mant_PeriodoDataService();
        private Conf_MultitablaDataService conf_MultitablaDataService = new Conf_MultitablaDataService();
        private String predio_id = "163508671001";
        private int periodo = 0;

        public Frm_Historial()
        {
            try
            {
                InitializeComponent();
                periodo = PeriodoDataService.GetPeriodoActivo();
                cboAño.DisplayMember = "Peric_canio";
                cboAño.ValueMember = "Peric_canio";
                cboAño.DataSource = PeriodoDataService.llenarPeriodo();
                cboAño.SelectedValue = periodo;
                dgvPredioHistorial.DataSource = predioDataService.listarHistorialDeUnPRedio(predio_id, periodo);
                //llenarCboMultitabla(cboTipoOperacion, "Multc_vDescripcion", "Multc_cValor", "12");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }
        public Frm_Historial(String predio_ii, String name)
        {
            try
            {
                InitializeComponent();
                this.predio_id = predio_ii;
                lblDatos.Text = predio_id + " - " + name;
                periodo = PeriodoDataService.GetPeriodoActivo();
                cboAño.DisplayMember = "Peric_canio";
                cboAño.ValueMember = "Peric_canio";
                cboAño.DataSource = PeriodoDataService.llenarPeriodo();
                cboAño.SelectedValue = periodo;
                dgvPredioHistorial.DataSource = predioDataService.listarHistorialDeUnPRedio(predio_id, periodo);
                cboTipoOperacion.DisplayMember = "Multc_vDescripcion";
                cboTipoOperacion.ValueMember = "Multc_cValor";
                cboTipoOperacion.DataSource = conf_MultitablaDataService.GetCboConf_Multitabla("12");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }
        private void dgvPredioHistorial_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvPredioHistorial.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void cboAño_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgvPredioHistorial.DataSource = predioDataService.listarHistorialDeUnPRedio(predio_id, Convert.ToInt32(cboAño.SelectedValue));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void dgvPredioHistorial_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtExpediente.Text = (string)dgvPredioHistorial.SelectedRows[0].Cells["expediente"].Value;
            cboTipoOperacion.SelectedValue = (Int32)dgvPredioHistorial.SelectedRows[0].Cells["tipo_operacion"].Value;
            txtDescripcionHistorial.Text = (string)dgvPredioHistorial.SelectedRows[0].Cells["DescripcionHistorial"].Value;
        }
    }
}
