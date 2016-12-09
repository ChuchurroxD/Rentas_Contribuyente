using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using SGR.Core.Service;
using SGR.Entity.Model;
using SGR.WinApp.Layout._5_Reportes_Gestion;
using Microsoft.Reporting.WinForms;

namespace SGR.WinApp.Layout._4_Procesos.Predio.Segmentacion
{
    public partial class Frm_Segmentacion : DockContent
    {

        Mant_PeriodoDataService mant_PeriodoDataService = new Mant_PeriodoDataService();
        Pred_Segmentacion_ContribuyenteDataService Segmentacion_ContribuyenteDataService = new Pred_Segmentacion_ContribuyenteDataService();
        private System.Windows.Forms.SortOrder Orden = new System.Windows.Forms.SortOrder();
        private List<Pred_Segmentacion_Contribuyente> Coleccion;
        public Frm_Segmentacion()
        {
            try
            {
                InitializeComponent();
                cboPeriodo.DisplayMember = "Peric_canio";
                cboPeriodo.ValueMember = "Peric_canio";
                cboPeriodo.DataSource = mant_PeriodoDataService.llenarPeriodo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void toolnuevoContribuyentePredio_Click(object sender, EventArgs e)
        {
            //Frm_Segmentacion_Detalle frm_Segmentacion_Detalle = new Frm_Segmentacion_Detalle();
            //frm_Segmentacion_Detalle.StartPosition = FormStartPosition.CenterParent;
            //frm_Segmentacion_Detalle.ShowDialog();
            //Coleccion = Segmentacion_ContribuyenteDataService.listartodos();
            //dgvContribuyentePredio.DataSource = Coleccion;
        }

        private void tooleditarContribuyentePredio_Click(object sender, EventArgs e)
        {
            //Frm_Segmentacion_Detalle frm_Segmentacion_Detalle = new Frm_Segmentacion_Detalle(obtenerDato());
            //frm_Segmentacion_Detalle.StartPosition = FormStartPosition.CenterParent;
            //frm_Segmentacion_Detalle.ShowDialog();
            //Coleccion = Segmentacion_ContribuyenteDataService.listartodos();
            //dgvContribuyentePredio.DataSource = Coleccion;
        }

        private void dgvContribuyentePredio_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tooleditarContribuyentePredio.PerformClick();
        }

        private void dgvContribuyentePredio_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                DataGridViewColumn ColumnaOrdenar = dgvContribuyentePredio.Columns[e.ColumnIndex];

                if (dgvContribuyentePredio.SortOrder == System.Windows.Forms.SortOrder.None)
                {

                    if (ColumnaOrdenar.Name == "nombrecompleto")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgvContribuyentePredio.DataSource = Coleccion.OrderBy(p => p.nombrecompleto).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgvContribuyentePredio.DataSource = Coleccion.OrderBy(p => p.nombrecompleto).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                    if (ColumnaOrdenar.Name == "nombrecompleto")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgvContribuyentePredio.DataSource = Coleccion.OrderBy(p => p.nombrecompleto).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgvContribuyentePredio.DataSource = Coleccion.OrderBy(p => p.nombrecompleto).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                    if (ColumnaOrdenar.Name == "seg_descripcion")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgvContribuyentePredio.DataSource = Coleccion.OrderBy(p => p.seg_descripcion).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgvContribuyentePredio.DataSource = Coleccion.OrderBy(p => p.seg_descripcion).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                    if (ColumnaOrdenar.Name == "estado")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgvContribuyentePredio.DataSource = Coleccion.OrderBy(p => p.estado).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgvContribuyentePredio.DataSource = Coleccion.OrderBy(p => p.estado).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                }

            }
        }
        private Pred_Segmentacion_Contribuyente obtenerDato()
        {
            Pred_Segmentacion_Contribuyente Segmentacion_Contribuyente = new Pred_Segmentacion_Contribuyente();
            //Segmentacion_Contribuyente.nombrecompleto = (string)dgvContribuyentePredio.SelectedRows[0].Cells["nombrecompleto"].Value;
            Segmentacion_Contribuyente.persona_id =(string) dgvContribuyentePredio.SelectedRows[0].Cells["persona_id"].Value;
            Segmentacion_Contribuyente.estado = (bool)dgvContribuyentePredio.SelectedRows[0].Cells["cEstado"].Value;
            Segmentacion_Contribuyente.segmentacion_contribuyente_id =(int) dgvContribuyentePredio.SelectedRows[0].Cells["segmentacion_contribuyente_id"].Value;
            Segmentacion_Contribuyente.segmentacion_id =(int)dgvContribuyentePredio.SelectedRows[0].Cells["segmentacion_id"].Value;
            //Segmentacion_Contribuyente.seg_descripcion = (string)dgvContribuyentePredio.SelectedRows[0].Cells["seg_descripcion"].Value;

            return Segmentacion_Contribuyente;
        }

        private void toolSegmentar_Click(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            
            try
            {
                string msj = "Desea generar segmentación?";
                if (dgvContribuyentePredio.RowCount > 0)
                    msj = "Desea generar nuevamente la segmentación";
                if (MessageBox.Show(msj, Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string tipo;
                    if (rbtAbono.Checked)
                        tipo = "1";
                    else if (rbtCargo.Checked)
                        tipo = "2";

                    else tipo = "3";
                    Segmentacion_ContribuyenteDataService.Segmentar(cboPeriodo.SelectedValue.ToString(), tipo,GlobalesV1.Global_str_Usuario);
                    LoadFiltros("", cboPeriodo.SelectedValue.ToString());
                    MessageBox.Show("Se generó la segmentación correctamente", Globales.Global_MessageBox);
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Globales.Global_MessageBox);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void cboPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFiltros("", cboPeriodo.SelectedValue.ToString());
        }

        private void rbtCargo_CheckedChanged(object sender, EventArgs e)
        {
            LoadFiltros("", cboPeriodo.SelectedValue.ToString());
        }

        private void rbtAbono_CheckedChanged(object sender, EventArgs e)
        {
            LoadFiltros("", cboPeriodo.SelectedValue.ToString());
        }
        private void LoadFiltros(string tipo,string perio)
        {
            try {

                if (rbtAbono.Checked)
                    tipo = "1";
                else if (rbtCargo.Checked)
                    tipo = "2";
                else tipo = "3";
                Coleccion = Segmentacion_ContribuyenteDataService.listartodos(tipo, perio);
                dgvContribuyentePredio.DataSource = Coleccion;
            } catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),Globales.Global_MessageBox);
            }

        }


        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            Frm_Visor_Global frm_Visor_Global = new Frm_Visor_Global();
            try
            {
                string tipoAl = "";
                if (rbtAbono.Checked)
                    tipoAl = "Abono";
                else if (rbtCargo.Checked)
                    tipoAl = "Cargo";
                else  tipoAl = "Saldo";

                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._5_Reportes_Gestion.Rep_Segmentacion.Segmentacion_Proceso.rdlc";
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", Coleccion));
                ReportParameter[] paramsx = new ReportParameter[3];
                paramsx[0] = new ReportParameter("Anio", cboPeriodo.SelectedValue.ToString());
                paramsx[1] = new ReportParameter("Tipo", tipoAl);
                paramsx[2] = new ReportParameter("Usuario", GlobalesV1.Global_str_Nombre);
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
    }
}
