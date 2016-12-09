using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using SGR.Entity.Model;
using SGR.Core.Service;
using SGR.WinApp.Layout._5_Reportes_Gestion;
using Microsoft.Reporting.WinForms;

namespace SGR.WinApp.Layout._1_Tablas_Maestras.Segmentacion
{
    public partial class Frm_Segmentacion : DockContent
    {

        Mant_PeriodoDataService mant_PeriodoDataService = new Mant_PeriodoDataService();
        Mant_SegmentacionDataService SegmentacionDataService = new Mant_SegmentacionDataService();
        private List<Mant_Segmentacion> Coleccion;
        private System.Windows.Forms.SortOrder Orden = new System.Windows.Forms.SortOrder();
        string usser = "nada";
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
            
            //Coleccion = SegmentacionDataService.listartodos();
            //dgvSegmentacion.DataSource = Coleccion;
        }

        private void cboPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Coleccion = SegmentacionDataService.listartodos(cboPeriodo.SelectedValue.ToString());
            dgvSegmentacion.DataSource = Coleccion;
        }

        private void toolnuevoOtrasInstalaciones_Click(object sender, EventArgs e)
        {
            Frm_SegmentacionDetalle Frm_SegmentacionDetalle = new Frm_SegmentacionDetalle(cboPeriodo.SelectedValue.ToString());
            Frm_SegmentacionDetalle.StartPosition = FormStartPosition.CenterParent;
            Frm_SegmentacionDetalle.ShowDialog();
            Coleccion = SegmentacionDataService.listartodos(cboPeriodo.SelectedValue.ToString());
            dgvSegmentacion.DataSource = Coleccion;

        }

        private void tooleditarOtrasInstalaciones_Click(object sender, EventArgs e)
        {
            if (dgvSegmentacion.SelectedRows.Count > 0)
            {
                Frm_SegmentacionDetalle Frm_SegmentacionDetalle = new Frm_SegmentacionDetalle(obtenerDatos());
                Frm_SegmentacionDetalle.StartPosition = FormStartPosition.CenterParent;
                Frm_SegmentacionDetalle.ShowDialog();
                Coleccion = SegmentacionDataService.listartodos(cboPeriodo.SelectedValue.ToString());
                dgvSegmentacion.DataSource = Coleccion;
            }else
                MessageBox.Show("Seleccione un registro", Globales.Global_MessageBox);
        }

        private void dgvSegmentacion_DoubleClick(object sender, EventArgs e)
        {
            tooleditarOtrasInstalaciones.PerformClick();
        }
        private Mant_Segmentacion obtenerDatos()
        {

            Mant_Segmentacion segme = new Mant_Segmentacion();
            try
            {
                segme.descripcion = (string)dgvSegmentacion.SelectedRows[0].Cells["descripcion"].Value;
                segme.estado = (Boolean)dgvSegmentacion.SelectedRows[0].Cells["estado"].Value;
                segme.monto_fin = (Decimal)dgvSegmentacion.SelectedRows[0].Cells["monto_fin"].Value;
                segme.monto_inicio = (Decimal)dgvSegmentacion.SelectedRows[0].Cells["monto_inicio"].Value;
                segme.periodo_id = (int)dgvSegmentacion.SelectedRows[0].Cells["periodo_id"].Value;
                segme.segmentacion_id = (int)dgvSegmentacion.SelectedRows[0].Cells["segmentacion_id"].Value;
                segme.tipo = (Int16)dgvSegmentacion.SelectedRows[0].Cells["tipo"].Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
            return segme;
        }
        private void dgvSegmentacion_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    DataGridViewColumn ColumnaOrdenar = dgvSegmentacion.Columns[e.ColumnIndex];

                    if (dgvSegmentacion.SortOrder == System.Windows.Forms.SortOrder.None)
                    {

                        if (ColumnaOrdenar.Name == "segmentacion_id")
                        {
                            if (Orden == System.Windows.Forms.SortOrder.Descending)
                            {
                                dgvSegmentacion.DataSource = Coleccion.OrderBy(p => p.segmentacion_id).ToList();
                                Orden = System.Windows.Forms.SortOrder.Ascending;
                            }
                            else
                            {
                                dgvSegmentacion.DataSource = Coleccion.OrderBy(p => p.segmentacion_id).Reverse().ToList();
                                Orden = System.Windows.Forms.SortOrder.Descending;
                            }
                        }
                        else if (ColumnaOrdenar.Name == "estado")
                        {
                            if (Orden == System.Windows.Forms.SortOrder.Descending)
                            {
                                dgvSegmentacion.DataSource = Coleccion.OrderBy(p => p.estado).ToList();
                                Orden = System.Windows.Forms.SortOrder.Ascending;
                            }
                            else
                            {
                                dgvSegmentacion.DataSource = Coleccion.OrderBy(p => p.estado).Reverse().ToList();
                                Orden = System.Windows.Forms.SortOrder.Descending;
                            }

                        }
                        else if (ColumnaOrdenar.Name == "tipo_descripcion")
                        {
                            if (Orden == System.Windows.Forms.SortOrder.Descending)
                            {
                                dgvSegmentacion.DataSource = Coleccion.OrderBy(p => p.tipo_descripcion).ToList();
                                Orden = System.Windows.Forms.SortOrder.Ascending;
                            }
                            else
                            {
                                dgvSegmentacion.DataSource = Coleccion.OrderBy(p => p.tipo_descripcion).Reverse().ToList();
                                Orden = System.Windows.Forms.SortOrder.Descending;
                            }

                        }
                    }

                }
            } catch (Exception ex) { }
           
        }

        private void toolCopiarPerodoAnterior_Click(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                if (SegmentacionDataService.ExisteElementosPeriodoAnterior(6) != 0)
                {
                    MessageBox.Show("Ya hay registros en este periodo", Globales.Global_MessageBox);
                    return;
                }

                if (SegmentacionDataService.ExisteElementosPeriodoAnterior(5) == 0)
                {
                    MessageBox.Show("No hay registros para copiar", Globales.Global_MessageBox);
                }
                else
                {
                    if (MessageBox.Show("Desea Copiar datos de periodo anterior?", Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        SegmentacionDataService.CopiarElementosPeriodoAnterior(usser);
                        MessageBox.Show("Se copió correctamente la segmentación del periodo anterior a este periodo", Globales.Global_MessageBox);
                    }
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

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            Frm_Visor_Global frm_Visor_Global = new Frm_Visor_Global();
            try
            {
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._5_Reportes_Gestion.Rep_Segmentacion.Mant_segmentacion.rdlc";
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", Coleccion));
                ReportParameter[] paramsx = new ReportParameter[2];
                paramsx[0] = new ReportParameter("Anio", cboPeriodo.SelectedValue.ToString());
                paramsx[1] = new ReportParameter("Usuario", GlobalesV1.Global_str_Nombre);
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
