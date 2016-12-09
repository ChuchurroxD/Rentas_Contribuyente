using Microsoft.Reporting.WinForms;
using SGR.Core.Service;
using SGR.Entity;
using SGR.WinApp.Layout._5_Reportes_Gestion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace SGR.WinApp.Layout._1_Tablas_Maestras.ParametroMes
{
    public partial class Frm_ParametroMes : DockContent
    {
        Mant_PeriodoDataService mant_PeriodoDataService = new Mant_PeriodoDataService();
        private System.Windows.Forms.SortOrder Orden = new System.Windows.Forms.SortOrder();
        Mant_ParametroMesDataService mant_ParametroMesDataService = new Mant_ParametroMesDataService();
        private List<Mant_ParametroMes> Coleccion;
        public Frm_ParametroMes()
        {
            InitializeComponent();
        }
        private void llenarcomboPeriodo()
        {
            try
            {
                comboBusquedaPeriodo.DisplayMember = "Peric_canio";
                comboBusquedaPeriodo.ValueMember = "Peric_canio";
                comboBusquedaPeriodo.DataSource = mant_PeriodoDataService.llenarPeriodo();
                comboBusquedaPeriodo.SelectedValue = 2016;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void Frm_ParametroMes_Load(object sender, EventArgs e)
        {
            try
            {

                DateTime fechaHoy = DateTime.Now;
                llenarcomboPeriodo();
                comboBusquedaPeriodo.SelectedValue = Convert.ToInt32(fechaHoy.Year.ToString());
                Coleccion = mant_ParametroMesDataService.listartodos((Int32)comboBusquedaPeriodo.SelectedValue);
                dgvListarParametroMes.DataSource = Coleccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void toolStripBotonNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_ParametroMes_Detalle frm_ParametroMes_Detalle = new Frm_ParametroMes_Detalle();
                frm_ParametroMes_Detalle.StartPosition = FormStartPosition.CenterParent;
                frm_ParametroMes_Detalle.ShowDialog();
                Coleccion = mant_ParametroMesDataService.listartodos((Int32)comboBusquedaPeriodo.SelectedValue);
                dgvListarParametroMes.DataSource = Coleccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }
        private int obtenerId()
        {
            return (Int32)dgvListarParametroMes.SelectedRows[0].Cells["xparametro_mes_ID"].Value;
        }
        private void toolStripBotonEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_ParametroMes_Detalle frm_ParametroMes_Detalle = new Frm_ParametroMes_Detalle(obtenerdatos());
                frm_ParametroMes_Detalle.StartPosition = FormStartPosition.CenterParent;
                frm_ParametroMes_Detalle.ShowDialog();
                Coleccion = mant_ParametroMesDataService.listartodos((Int32)comboBusquedaPeriodo.SelectedValue);
                dgvListarParametroMes.DataSource = Coleccion;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
           
        }
        private Mant_ParametroMes obtenerdatos()
        {
            Mant_ParametroMes mant_ParametroMes = new Mant_ParametroMes();
            mant_ParametroMes.parametro_mes_ID = (int)dgvListarParametroMes.SelectedRows[0].Cells["xparametro_mes_ID"].Value;
            mant_ParametroMes.periodo_id = (short)dgvListarParametroMes.SelectedRows[0].Cells["xperiodo_id"].Value;
            mant_ParametroMes.tipo = (int)dgvListarParametroMes.SelectedRows[0].Cells["xtipo"].Value;
            mant_ParametroMes.mes = (short)dgvListarParametroMes.SelectedRows[0].Cells["xmes"].Value;
            mant_ParametroMes.tipoDescripcion = (string)dgvListarParametroMes.SelectedRows[0].Cells["xtipoDescripcion"].Value;
            mant_ParametroMes.fecha_emision = (DateTime)dgvListarParametroMes.SelectedRows[0].Cells["xfecha_emision"].Value;
            mant_ParametroMes.fecha_vence = (DateTime)dgvListarParametroMes.SelectedRows[0].Cells["xfecha_vence"].Value;
            mant_ParametroMes.estado = (bool)dgvListarParametroMes.SelectedRows[0].Cells["xestado"].Value;
            return mant_ParametroMes;
        }

        private void dgvListarParametroMes_DoubleClick(object sender, EventArgs e)
        {
            toolStripBotonEditar.PerformClick();
        }

        private void comboBusquedaPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Coleccion = mant_ParametroMesDataService.listartodos((Int32)comboBusquedaPeriodo.SelectedValue);
            dgvListarParametroMes.DataSource = Coleccion;
        }

        private void dgvListarParametroMes_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                DataGridViewColumn ColumnaOrdenar = dgvListarParametroMes.Columns[e.ColumnIndex];

                if (dgvListarParametroMes.SortOrder == System.Windows.Forms.SortOrder.None)
                {

                    if (ColumnaOrdenar.Name == "xmes")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgvListarParametroMes.DataSource = Coleccion.OrderBy(p => p.mes).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgvListarParametroMes.DataSource = Coleccion.OrderBy(p => p.mes).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "xtipoDescripcion")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgvListarParametroMes.DataSource = Coleccion.OrderBy(p => p.tipoDescripcion).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgvListarParametroMes.DataSource = Coleccion.OrderBy(p => p.tipoDescripcion).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }

                    }
                    else if (ColumnaOrdenar.Name == "xfecha_vence")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgvListarParametroMes.DataSource = Coleccion.OrderBy(p => p.fecha_vence).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgvListarParametroMes.DataSource = Coleccion.OrderBy(p => p.fecha_vence).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }

                    }
                    else if (ColumnaOrdenar.Name == "xfecha_emision")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgvListarParametroMes.DataSource = Coleccion.OrderBy(p => p.fecha_emision).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgvListarParametroMes.DataSource = Coleccion.OrderBy(p => p.fecha_emision).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }

                    }
                }

            }
        }

        private void toolStripBotonReporte_Click(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            Frm_Visor_Global frm_Visor_Global = new Frm_Visor_Global();
            try
            {
                Pred_ViasDataService pred_ViasDataService = new Pred_ViasDataService();
                Coleccion = mant_ParametroMesDataService.listartodos((Int32)comboBusquedaPeriodo.SelectedValue);
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._1_Tablas_Maestras.ParametroMes.Reporte_ParametroMes.rdlc";
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetParametroMes", Coleccion));
                ReportParameter[] paramsx = new ReportParameter[2];
                paramsx[0] = new ReportParameter("NombreEmpresa", Globales.NombreEmpresa);
                paramsx[1] = new ReportParameter("UsuarioPrueba", GlobalesV1.Global_str_Usuario);
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
