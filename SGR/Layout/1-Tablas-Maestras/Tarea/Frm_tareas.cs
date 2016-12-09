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
using SGR.Entity;
using SGR.WinApp.Layout._5_Reportes_Gestion;
using Microsoft.Reporting.WinForms;

namespace SGR.WinApp.Layout._1_Tablas_Maestras.Tarea
{
    public partial class Frm_tareas : DockContent
    {
        Conf_GrupoDataService conf_GrupoDataService = new Conf_GrupoDataService();
        Conf_TareaDataService conf_TareaDataService = new Conf_TareaDataService();
        private List<Conf_Tarea> coleccion;
        private System.Windows.Forms.SortOrder Orden = new System.Windows.Forms.SortOrder();

        public Frm_tareas()
        {
            InitializeComponent();
        }

        private void Frm_tareas_Load(object sender, EventArgs e)
        {
            llenarComboGrupos();
            //cboGrupo.SelectedValue = 1;
            //coleccion = conf_TareaDataService.GetAllConf_Tarea((Int64)cboGrupo.SelectedValue);
            //dgTareas.DataSource = coleccion;
        }

        private void llenarComboGrupos()
        {
            cboGrupo.DisplayMember = "Grupc_vDescripcion";
            cboGrupo.ValueMember = "Grupc_iCodigo";
            cboGrupo.DataSource = conf_GrupoDataService.GetActivosConf_Grupo();
        }

        private void cboGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            coleccion = conf_TareaDataService.listarTareasActivasInactivas((Int64)cboGrupo.SelectedValue);
            dgTareas.DataSource = coleccion;
        }

        private void toolNuevo_Click(object sender, EventArgs e)
        {
            Frm_tareas_detalle frm_tareas_detalle = new Frm_tareas_detalle();
            frm_tareas_detalle.StartPosition = FormStartPosition.CenterScreen;
            frm_tareas_detalle.ShowDialog();
            coleccion = conf_TareaDataService.listarTareasActivasInactivas((Int64)cboGrupo.SelectedValue);
            dgTareas.DataSource = coleccion;
        }

        private void toolEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgTareas.CurrentRow == null)
                    throw new Exception("Debe seleccionar una fila.");

                Frm_tareas_detalle frm_tareas_detalle = new Frm_tareas_detalle(obtenerDatos());
                frm_tareas_detalle.StartPosition = FormStartPosition.CenterParent;
                frm_tareas_detalle.ShowDialog();

                if (txtBusqueda.Text.Trim().Length == 0)
                    dgTareas.DataSource = conf_TareaDataService.listarTareasActivasInactivas(Convert.ToInt64(cboGrupo.SelectedValue));
                // else
                //   dgTareas.DataSource =  conf_GrupoDataService.listarBusqueda(txtBusqueda.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgTareas_DoubleClick(object sender, EventArgs e)
        {
            toolEditar.PerformClick();
        }

        private Conf_Tarea obtenerDatos()
        {
            Conf_Tarea conf_Tarea = new Conf_Tarea();
            Conf_Grupo conf_grupo = new Conf_Grupo();
            try
            {
                conf_Tarea.Tarec_iCodigo = (Int64)dgTareas.SelectedRows[0].Cells["xTarea_id"].Value;
                conf_Tarea.Grupo_id = (Int64)dgTareas.SelectedRows[0].Cells["xGrupo_id"].Value;
                conf_Tarea.Tarec_vNombre = (string)dgTareas.SelectedRows[0].Cells["xTarea_nombre"].Value.ToString().TrimEnd();
                conf_Tarea.Tarec_vDescripcion = (string)dgTareas.SelectedRows[0].Cells["xTarea_descripcion"].Value.ToString().TrimEnd();
                conf_Tarea.Tarec_vUrl = (string)dgTareas.SelectedRows[0].Cells["xTarea_url"].Value.ToString().TrimEnd();
                conf_Tarea.Tarec_bActivo = (bool)dgTareas.SelectedRows[0].Cells["xTarea_activo"].Value;
                conf_Tarea.Tarec_Padre = (Int64)dgTareas.SelectedRows[0].Cells["xTarea_padre"].Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
            return conf_Tarea;
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgTareas.DataSource = conf_TareaDataService.listarBusquedaByGrupo(txtBusqueda.Text.Trim(), (Int64)cboGrupo.SelectedValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgTareas_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                DataGridViewColumn ColumnaOrdenar = dgTareas.Columns[e.ColumnIndex];

                if (dgTareas.SortOrder == System.Windows.Forms.SortOrder.None)
                {
                    if (ColumnaOrdenar.Name == "xTarea_nombre")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgTareas.DataSource = coleccion.OrderBy(p => p.Tarec_vNombre).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgTareas.DataSource = coleccion.OrderBy(p => p.Tarec_vNombre).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                    if (ColumnaOrdenar.Name == "xTarea_descripcion")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgTareas.DataSource = coleccion.OrderBy(p => p.Tarec_vDescripcion).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgTareas.DataSource = coleccion.OrderBy(p => p.Tarec_vDescripcion).Reverse().ToList();
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
            Frm_Visor_Global frmVisor = new Frm_Visor_Global();

            try
            {
                coleccion = conf_TareaDataService.listarTareasActivasInactivas((Int64)cboGrupo.SelectedValue);
                frmVisor.reportViewer1.LocalReport.DataSources.Clear();
                frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._1_Tablas_Maestras.Tarea.rptTarea.rdlc";
                frmVisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsTarea", coleccion));
                ReportParameter[] param = new ReportParameter[3];
                param[0] = new ReportParameter("NombreEmpresa", Globales.NombreEmpresa);
                param[1] = new ReportParameter("UsuarioPrueba", GlobalesV1.Global_str_Nombre);
                param[2] = new ReportParameter("Grupo", cboGrupo.Text.ToString().Trim());
                frmVisor.reportViewer1.LocalReport.SetParameters(param);
                frmVisor.reportViewer1.RefreshReport();
                frmVisor.StartPosition = FormStartPosition.CenterScreen;
                frmVisor.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
    }
}
