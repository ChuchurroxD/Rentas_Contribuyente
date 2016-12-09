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

namespace SGR.WinApp.Layout._1_Tablas_Maestras.Grupo
{
    public partial class Frm_grupos : DockContent
    {
        private Conf_GrupoDataService conf_GrupoDataService = new Conf_GrupoDataService();
        private List<Conf_Grupo> coleccion;
        private System.Windows.Forms.SortOrder Orden = new System.Windows.Forms.SortOrder();

        public Frm_grupos()
        {
            InitializeComponent();
        }

        private void toolNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_grupos_detalle frm_grupos_detalle = new Frm_grupos_detalle();
                frm_grupos_detalle.StartPosition = FormStartPosition.CenterParent;
                frm_grupos_detalle.ShowDialog();
                Conf_GrupoDataService conf_GrupoDataService = new Conf_GrupoDataService();
                dgGrupos.DataSource = conf_GrupoDataService.GetAllConf_Grupo();
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
                if (dgGrupos.CurrentRow == null)
                    throw new Exception("Debe seleccionar una fila.");

                Frm_grupos_detalle frm_grupos_detalle = new Frm_grupos_detalle(obtenerDatos());
                frm_grupos_detalle.StartPosition = FormStartPosition.CenterParent;
                frm_grupos_detalle.ShowDialog();

                if (txtBusqueda.Text.Trim().Length == 0)
                    dgGrupos.DataSource = conf_GrupoDataService.listarGruposActivosInactivos();
                else
                    dgGrupos.DataSource = conf_GrupoDataService.listarBusqueda(txtBusqueda.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private Conf_Grupo obtenerDatos()
        {
            Conf_Grupo conf_Grupo = new Conf_Grupo();
            conf_Grupo.Grupc_iCodigo = (Int64)(dgGrupos.SelectedRows[0].Cells["xGrupo_id"].Value);
            conf_Grupo.Grupc_vNombre = (string)dgGrupos.SelectedRows[0].Cells["xGrupo_nombre"].Value.ToString().TrimEnd();
            conf_Grupo.Grupc_vDescripcion = (string)dgGrupos.SelectedRows[0].Cells["xGrupo_descripcion"].Value.ToString().TrimEnd();
            conf_Grupo.Grupc_bActivo = (bool)dgGrupos.SelectedRows[0].Cells["xGrupo_activo"].Value;
            return conf_Grupo;
        }

        private void dgGrupos_DoubleClick(object sender, EventArgs e)
        {
            toolEditar.PerformClick();
        }

        private void Frm_grupos_Load(object sender, EventArgs e)
        {
            try
            {
                txtBusqueda.Focus();
                coleccion = conf_GrupoDataService.GetAllConf_Grupo();
                dgGrupos.DataSource = coleccion;
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
                    dgGrupos.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgGrupos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                DataGridViewColumn ColumnaOrdenar = dgGrupos.Columns[e.ColumnIndex];

                if (dgGrupos.SortOrder == System.Windows.Forms.SortOrder.None)
                {
                    if (ColumnaOrdenar.Name == "xGrupo_nombre")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgGrupos.DataSource = coleccion.OrderBy(p => p.Grupc_vNombre).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgGrupos.DataSource = coleccion.OrderBy(p => p.Grupc_vNombre).Reverse().ToList();
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
                coleccion = conf_GrupoDataService.GetAllConf_Grupo();
                frmVisor.reportViewer1.LocalReport.DataSources.Clear();
                frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._1_Tablas_Maestras.Grupo.rptGrupo.rdlc";
                frmVisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", coleccion));
                ReportParameter[] param = new ReportParameter[2];
                param[0] = new ReportParameter("NombreEmpresa", Globales.NombreEmpresa);
                param[1] = new ReportParameter("UsuarioPrueba", GlobalesV1.Global_str_Nombre);
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

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgGrupos.DataSource = conf_GrupoDataService.listarBusqueda(txtBusqueda.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
