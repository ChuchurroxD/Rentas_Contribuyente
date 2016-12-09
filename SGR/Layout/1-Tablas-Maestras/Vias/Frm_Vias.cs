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

namespace SGR.WinApp.Layout._1_Tablas_Maestras.Vias
{
    public partial class Frm_Vias : DockContent
    {
        private Pred_ViasDataService pred_ViasDataService = new Pred_ViasDataService();
        private List<Pred_Vias> Coleccion;
        private System.Windows.Forms.SortOrder Orden = new System.Windows.Forms.SortOrder();
        public Frm_Vias()
        {
            InitializeComponent();
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                dgvListarVias.Focus();
            }
        }

        private void toolNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_Vias_Detalle frm_Vias_Detalle = new Frm_Vias_Detalle();
                frm_Vias_Detalle.StartPosition = FormStartPosition.CenterParent;
                frm_Vias_Detalle.ShowDialog();
                Pred_ViasDataService pred_ViasDataService = new Pred_ViasDataService();
                Coleccion = pred_ViasDataService.listarTodos();
                dgvListarVias.DataSource = Coleccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void toolEditar_Click(object sender, EventArgs e)
        {
            Frm_Vias_Detalle frm_Vias_Detalle = new Frm_Vias_Detalle(obtenerdatos());
            frm_Vias_Detalle.StartPosition = FormStartPosition.CenterParent;
            frm_Vias_Detalle.ShowDialog();

            if (txtBusqueda.Text.Trim().Length == 0) { 
                Coleccion = pred_ViasDataService.listarTodos();
                  dgvListarVias.DataSource = Coleccion;
            }
            else { 
            Coleccion = pred_ViasDataService.Getcoleccion("Descripcion like '%" + txtBusqueda.Text + "%'", "Descripcion");
            dgvListarVias.DataSource = Coleccion;
            }
        }

        private void toolEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desean Eliminar?", Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                pred_ViasDataService.deletebyprimarykey(obtenerId());
                Coleccion = pred_ViasDataService.listarTodos();
                dgvListarVias.DataSource = Coleccion;
            }
        }

        private void toolCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        #region Metodos y Funciones
        private Pred_Vias obtenerdatos()
        {
            Pred_Vias pred_Vias = new Pred_Vias();
            pred_Vias.Via_id = (string)dgvListarVias.SelectedRows[0].Cells["viaidDataGridViewTextBoxColumn"].Value;
            pred_Vias.Descripcion = (string)dgvListarVias.SelectedRows[0].Cells["descripcionDataGridViewTextBoxColumn"].Value.ToString().TrimEnd();
            pred_Vias.TipoVia = (string)dgvListarVias.SelectedRows[0].Cells["tipoViaDataGridViewTextBoxColumn"].Value;
            pred_Vias.Estado = (bool)dgvListarVias.SelectedRows[0].Cells["estadoDataGridViewCheckBoxColumn"].Value;
            pred_Vias.CodigoAntiguo = (string)dgvListarVias.SelectedRows[0].Cells["codigoAntiguoDataGridViewTextBoxColumn"].Value;
            return pred_Vias;
        }

        private string obtenerId()
        {
            return (string)dgvListarVias.SelectedRows[0].Cells["viaidDataGridViewTextBoxColumn"].Value;
        }

        #endregion

        private void Frm_Vias_Load(object sender, EventArgs e)
        {
            try
            {
                txtBusqueda.Focus();
                Coleccion = pred_ViasDataService.listarTodos();
                dgvListarVias.DataSource = Coleccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void dgvListarVias_DoubleClick(object sender, EventArgs e)
        {
            toolEditar.PerformClick();
        }

        private void dgvListarVias_DoubleClick_1(object sender, EventArgs e)
        {
            toolEditar.PerformClick();
        }

        private void toolReporte_Click(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            Frm_Visor_Global frm_Visor_Global = new Frm_Visor_Global();
            try
            {
                Pred_ViasDataService pred_ViasDataService = new Pred_ViasDataService();
                Coleccion = pred_ViasDataService.listarTodos();
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._1_Tablas_Maestras.Vias.ReporteVia.rdlc";
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetVia", Coleccion));
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

        private void dgvListarVias_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                DataGridViewColumn ColumnaOrdenar = dgvListarVias.Columns[e.ColumnIndex];

                if (dgvListarVias.SortOrder == System.Windows.Forms.SortOrder.None)
                {

                    if (ColumnaOrdenar.Name == "descripcionDataGridViewTextBoxColumn")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgvListarVias.DataSource = Coleccion.OrderBy(p => p.Descripcion).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgvListarVias.DataSource = Coleccion.OrderBy(p => p.Descripcion).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "descripcionTipoViaDataGridViewTextBoxColumn")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgvListarVias.DataSource = Coleccion.OrderBy(p => p.descripcionTipoVia).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgvListarVias.DataSource = Coleccion.OrderBy(p => p.descripcionTipoVia).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }

                    }
                    else if (ColumnaOrdenar.Name == "viaidDataGridViewTextBoxColumn")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgvListarVias.DataSource = Coleccion.OrderBy(p => p.Via_id).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgvListarVias.DataSource = Coleccion.OrderBy(p => p.Via_id).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }

                    }
                }

            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvListarVias.DataSource = pred_ViasDataService.Getcoleccion("v.Descripcion like '%" + txtBusqueda.Text + "%'", "Descripcion");                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }
    }
}
