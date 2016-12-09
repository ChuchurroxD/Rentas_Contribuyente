using DgvFilterPopup;
using SGR.Core.Service;
using SGR.Entity.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.Linq;
using Microsoft.Reporting.WinForms;
using SGR.WinApp.Layout._5_Reportes_Gestion;
using SGR.Entity;

namespace SGR.WinApp.Layout._1_Tablas_Maestras.RolTarea
{
    public partial class Frm_rolTarea : DockContent
    {
        private Conf_RolTareaDataService conf_RolTareaDataService = new Conf_RolTareaDataService();
        private List<Conf_RolTarea> coleccion = new List<Conf_RolTarea>();
        private System.Windows.Forms.SortOrder Orden = new System.Windows.Forms.SortOrder();

        public Frm_rolTarea()
        {
            InitializeComponent();
        }

        private void Frm_rolTarea_Load(object sender, EventArgs e)
        {
            try
            {
                txtBusqueda.Focus();
                coleccion = conf_RolTareaDataService.listarTodosRolTarea();
                dgRolTareas.DataSource = coleccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void toolNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_rolTarea_detalle frm_rolTarea_detalle = new Frm_rolTarea_detalle();
                frm_rolTarea_detalle.StartPosition = FormStartPosition.CenterParent;
                frm_rolTarea_detalle.ShowDialog();
                
                dgRolTareas.DataSource = conf_RolTareaDataService.listarTodosRolTarea();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void toolEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgRolTareas.CurrentRow == null)
                    throw new Exception("Debe seleccionar una fila.");

                Frm_rolTarea_detalle frm_rolTarea_detalle = new Frm_rolTarea_detalle(obtenerDatos());
                frm_rolTarea_detalle.StartPosition = FormStartPosition.CenterParent;
                frm_rolTarea_detalle.ShowDialog();

                if (txtBusqueda.Text.Trim().Length == 0)
                    dgRolTareas.DataSource = conf_RolTareaDataService.listarTodosRolTarea();
                else
                    dgRolTareas.DataSource = conf_RolTareaDataService.buscarRolTarea(txtBusqueda.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private Conf_RolTarea obtenerDatos()
        {
            Conf_RolTarea Conf_RolTarea = new Conf_RolTarea();
            Conf_RolTarea.rol_id = (Int64)(dgRolTareas.SelectedRows[0].Cells["rol_id"].Value);
            Conf_RolTarea.rol_descripcion = (string)dgRolTareas.SelectedRows[0].Cells["rol_descripcion"].Value.ToString().TrimEnd();
            Conf_RolTarea.tarea_id = (Int64)dgRolTareas.SelectedRows[0].Cells["tarea_id"].Value;
            Conf_RolTarea.tar_descripcion = (string)dgRolTareas.SelectedRows[0].Cells["tar_descripcion"].Value.ToString().TrimEnd();
            Conf_RolTarea.estado = (bool)dgRolTareas.SelectedRows[0].Cells["estado"].Value;
            return Conf_RolTarea;
        }

        private void dgRolTareas_DoubleClick(object sender, EventArgs e)
        {
            toolEditar.PerformClick();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgRolTareas.DataSource = conf_RolTareaDataService.buscarRolTarea(txtBusqueda.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    dgRolTareas.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgRolTareas_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                DataGridViewColumn ColumnaOrdenar = dgRolTareas.Columns[e.ColumnIndex];

                if (dgRolTareas.SortOrder == System.Windows.Forms.SortOrder.None)
                {
                    if (ColumnaOrdenar.Name == "rol_descripcion")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgRolTareas.DataSource = coleccion.OrderBy(p => p.rol_descripcion).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgRolTareas.DataSource = coleccion.OrderBy(p => p.rol_descripcion).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                    if (ColumnaOrdenar.Name == "tar_descripcion")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgRolTareas.DataSource = coleccion.OrderBy(p => p.tar_descripcion).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgRolTareas.DataSource = coleccion.OrderBy(p => p.tar_descripcion).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                }

            }


        }

        private void toolImprimir_Click(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            Frm_Visor_Global frm_Visor_Global = new Frm_Visor_Global();

            try
            {
                coleccion = conf_RolTareaDataService.listarTodosRolTarea();
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._1_Tablas_Maestras.RolTarea.rptRolTarea.rdlc";
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsRolTarea", coleccion));
                ReportParameter[] paramsx = new ReportParameter[2];
                paramsx[0] = new ReportParameter("NombreEmpresa", Globales.NombreEmpresa);
                paramsx[1] = new ReportParameter("UsuarioPrueba", GlobalesV1.Global_str_Nombre);
                //GlobalesV1.Global_str_Nombre
                frm_Visor_Global.reportViewer1.LocalReport.SetParameters(paramsx);
                frm_Visor_Global.reportViewer1.RefreshReport();
                frm_Visor_Global.StartPosition = FormStartPosition.CenterScreen;
                frm_Visor_Global.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
