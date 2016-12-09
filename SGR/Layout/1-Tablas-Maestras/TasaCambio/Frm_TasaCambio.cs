using Microsoft.Reporting.WinForms;
using SGR.Core.Service;
using SGR.Entity.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using SGR.WinApp.Layout._5_Reportes_Gestion;

namespace SGR.WinApp.Layout._1_Tablas_Maestras.TasaCambio
{
    public partial class Frm_TasaCambio : DockContent
    {
        Mant_TasaCambioDataService mant_TasaCambioDataService = new Mant_TasaCambioDataService();
        private List<Mant_TasaCambio> Coleccion;

        private System.Windows.Forms.SortOrder Orden = new System.Windows.Forms.SortOrder();
        public Frm_TasaCambio()
        {
            InitializeComponent();
        }

        private void Frm_TasaCambio_Load(object sender, EventArgs e)
        {
            try
            {
                Coleccion = mant_TasaCambioDataService.listarTodos();
                dgvListarTasaCambio.DataSource = Coleccion;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #region Metodos y Funciones
        private Mant_TasaCambio obtenerdatos()
        {
            Mant_TasaCambio mant_TasaCambio = new Mant_TasaCambio();
            mant_TasaCambio.idTasaCambio = (int)dgvListarTasaCambio.SelectedRows[0].Cells["xidTasaCambio"].Value;
            mant_TasaCambio.fecha = (DateTime)dgvListarTasaCambio.SelectedRows[0].Cells["xfecha"].Value;
            mant_TasaCambio.precioVenta = (decimal)dgvListarTasaCambio.SelectedRows[0].Cells["xprecioVenta"].Value;
            mant_TasaCambio.precioCompra = (decimal)dgvListarTasaCambio.SelectedRows[0].Cells["xprecioCompra"].Value;
            mant_TasaCambio.estado = (bool)dgvListarTasaCambio.SelectedRows[0].Cells["xestado"].Value;
            return mant_TasaCambio;
        }
        #endregion

        private void toolStripBotonNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_TasaCambio_Detalle frm_TasaCambio_Detalle = new Frm_TasaCambio_Detalle();
                frm_TasaCambio_Detalle.StartPosition = FormStartPosition.CenterParent;
                frm_TasaCambio_Detalle.ShowDialog();
                Coleccion = mant_TasaCambioDataService.listarTodos();
                dgvListarTasaCambio.DataSource = Coleccion;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void toolStripBotonModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_TasaCambio_Detalle frm_TasaCambio_Detalle = new Frm_TasaCambio_Detalle(obtenerdatos());
                frm_TasaCambio_Detalle.StartPosition = FormStartPosition.CenterParent;
                frm_TasaCambio_Detalle.ShowDialog();
                Coleccion = mant_TasaCambioDataService.listarTodos();
                dgvListarTasaCambio.DataSource = Coleccion;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void dgvListarTasaCambio_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                toolStripBotonModificar.PerformClick();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
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
                Coleccion = mant_TasaCambioDataService.listarTodos();
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._1_Tablas_Maestras.TasaCambio.Reporte_TasaCambio.rdlc";
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetTasaCambio", Coleccion));
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

        private void dgvListarTasaCambio_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                DataGridViewColumn ColumnaOrdenar = dgvListarTasaCambio.Columns[e.ColumnIndex];

                if (dgvListarTasaCambio.SortOrder == System.Windows.Forms.SortOrder.None)
                {

                    if (ColumnaOrdenar.Name == "xprecioVenta")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgvListarTasaCambio.DataSource = Coleccion.OrderBy(p => p.precioVenta).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgvListarTasaCambio.DataSource = Coleccion.OrderBy(p => p.precioVenta).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "xprecioCompra")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgvListarTasaCambio.DataSource = Coleccion.OrderBy(p => p.precioCompra).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgvListarTasaCambio.DataSource = Coleccion.OrderBy(p => p.precioCompra).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }

                    }
                    else if (ColumnaOrdenar.Name == "xfecha")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgvListarTasaCambio.DataSource = Coleccion.OrderBy(p => p.fecha).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgvListarTasaCambio.DataSource = Coleccion.OrderBy(p => p.fecha).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }

                    }
                }

            }
        }        

        private void dtFecha_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Coleccion = mant_TasaCambioDataService.buscarByDate(dtFecha.Value.ToShortDateString().Trim());
                dgvListarTasaCambio.DataSource = Coleccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
