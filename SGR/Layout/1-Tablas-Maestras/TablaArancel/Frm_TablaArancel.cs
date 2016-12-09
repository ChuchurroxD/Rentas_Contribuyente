using Microsoft.Reporting.WinForms;
using SGR.Core.Service;
using SGR.Entity.Model;
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

namespace SGR.WinApp.Layout._1_Tablas_Maestras.TablaArancel
{
    public partial class Frm_TablaArancel : DockContent
    {
        Mant_TablaArancelDataService mant_TablaArancelDataService = new Mant_TablaArancelDataService();
        private List<Mant_TablaArancel> Coleccion;
        private System.Windows.Forms.SortOrder Orden = new System.Windows.Forms.SortOrder();
        public Frm_TablaArancel()
        {
            InitializeComponent();
        }
        
        private void Frm_TablaArancel_Load(object sender, EventArgs e)
        {
            try
            {
                txtBusqueda.Focus();
                Coleccion = mant_TablaArancelDataService.listartodos();
                dgvListarTablaArancel.DataSource = Coleccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        #region Metodos y Funciones
        private Mant_TablaArancel obtenerdatos()
        {
            Mant_TablaArancel mant_TablaArancel = new Mant_TablaArancel();
            mant_TablaArancel.idTablaArancel = (int)dgvListarTablaArancel.SelectedRows[0].Cells["xidTablaArancel"].Value;
            mant_TablaArancel.Descripcion = (string)dgvListarTablaArancel.SelectedRows[0].Cells["xDescripcion"].Value.ToString().TrimEnd();
            mant_TablaArancel.Estado = (bool)dgvListarTablaArancel.SelectedRows[0].Cells["xEstado"].Value;
            return mant_TablaArancel;
        }

        private string obtenerId()
        {
            return (string)dgvListarTablaArancel.SelectedRows[0].Cells["xidTablaArancel"].Value;
        }

        #endregion

        private void dgvListarTablaArancel_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                DataGridViewColumn ColumnaOrdenar = dgvListarTablaArancel.Columns[e.ColumnIndex];

                if (dgvListarTablaArancel.SortOrder == System.Windows.Forms.SortOrder.None)
                {

                    if (ColumnaOrdenar.Name == "xDescripcion")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgvListarTablaArancel.DataSource = Coleccion.OrderBy(p => p.Descripcion).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgvListarTablaArancel.DataSource = Coleccion.OrderBy(p => p.Descripcion).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                }
            }
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {                
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    dgvListarTablaArancel.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void dgvListarTablaArancel_DoubleClick(object sender, EventArgs e)
        {
            toolStripBotonModificar.PerformClick();
        }

        private void toolStripBotonNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_TablaArancel_Detalle frm_TablaArancel_Detalle = new Frm_TablaArancel_Detalle();
                frm_TablaArancel_Detalle.StartPosition = FormStartPosition.CenterParent;
                frm_TablaArancel_Detalle.ShowDialog();
                Coleccion = mant_TablaArancelDataService.listartodos();
                dgvListarTablaArancel.DataSource = Coleccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void toolStripBotonModificar_Click(object sender, EventArgs e)
        {
            Frm_TablaArancel_Detalle frm_TablaArancel_Detalle = new Frm_TablaArancel_Detalle(obtenerdatos());
            frm_TablaArancel_Detalle.StartPosition = FormStartPosition.CenterParent;
            frm_TablaArancel_Detalle.ShowDialog();

            if (txtBusqueda.Text.Trim().Length == 0)
            {
                Coleccion = mant_TablaArancelDataService.listartodos();
                dgvListarTablaArancel.DataSource = Coleccion;
            }
            else
            {
                Coleccion = mant_TablaArancelDataService.Getcoleccion("Descripcion like '%" + txtBusqueda.Text + "%'", "Descripcion");
                dgvListarTablaArancel.DataSource = Coleccion;
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
                Coleccion = mant_TablaArancelDataService.listartodos();
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._1_Tablas_Maestras.TablaArancel.Reporte_TablaArancel.rdlc";
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetTablaArancel", Coleccion));
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

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvListarTablaArancel.DataSource = mant_TablaArancelDataService.Getcoleccion("Descripcion like '%" + txtBusqueda.Text + "%'", "Descripcion");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }
    }
}
