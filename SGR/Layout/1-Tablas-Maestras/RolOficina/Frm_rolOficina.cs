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

namespace SGR.WinApp.Layout._1_Tablas_Maestras.RolOficina
{
    public partial class Frm_rolOficina : DockContent
    {
        private Conf_RolOficinaDataService conf_RolOficinaDataService = new Conf_RolOficinaDataService();
        private List<Conf_RolOficina> coleccion = new List<Conf_RolOficina>();
        private System.Windows.Forms.SortOrder Orden = new System.Windows.Forms.SortOrder();

        public Frm_rolOficina()
        {
            InitializeComponent();
        }

        private void Frm_rolOficina_Load(object sender, EventArgs e)
        {
            try
            {
                txtBusqueda.Focus();
                coleccion = conf_RolOficinaDataService.listarTodosRolOficina();
                dgRolOficina.DataSource = coleccion;
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
                Frm_rolOficina_detalle frm_rolOficina_detalle = new Frm_rolOficina_detalle();
                frm_rolOficina_detalle.StartPosition = FormStartPosition.CenterParent;
                frm_rolOficina_detalle.ShowDialog();

                dgRolOficina.DataSource = conf_RolOficinaDataService.listarTodosRolOficina();
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
                if (dgRolOficina.CurrentRow == null)
                    throw new Exception("Debe seleccionar una fila.");

                Frm_rolOficina_detalle frm_rolOficina_detalle = new Frm_rolOficina_detalle(obtenerDatos());
                frm_rolOficina_detalle.StartPosition = FormStartPosition.CenterParent;
                frm_rolOficina_detalle.ShowDialog();

                if (txtBusqueda.Text.Trim().Length == 0)
                    dgRolOficina.DataSource = conf_RolOficinaDataService.listarTodosRolOficina();
                else
                    dgRolOficina.DataSource = conf_RolOficinaDataService.buscarRolOficina(txtBusqueda.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private Conf_RolOficina obtenerDatos()
        {
            Conf_RolOficina conf_RolOficina = new Conf_RolOficina();
            conf_RolOficina.rol_id = (Int64)(dgRolOficina.SelectedRows[0].Cells["rol_id"].Value);
            conf_RolOficina.rol_descripcion = (string)dgRolOficina.SelectedRows[0].Cells["rol_descripcion"].Value.ToString().TrimEnd();
            conf_RolOficina.oficina_id = (Int64)dgRolOficina.SelectedRows[0].Cells["oficina_id"].Value;
            conf_RolOficina.oficina_descripcion = (string)dgRolOficina.SelectedRows[0].Cells["oficina_descripcion"].Value.ToString().TrimEnd();
            conf_RolOficina.estado = (bool)dgRolOficina.SelectedRows[0].Cells["estado"].Value;
            return conf_RolOficina;
        }

        private void dgRolOficina_DoubleClick(object sender, EventArgs e)
        {
            toolEditar.PerformClick();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgRolOficina.DataSource = conf_RolOficinaDataService.buscarRolOficina(txtBusqueda.Text.Trim());
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
                    dgRolOficina.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgRolOficina_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                DataGridViewColumn ColumnaOrdenar = dgRolOficina.Columns[e.ColumnIndex];

                if (dgRolOficina.SortOrder == System.Windows.Forms.SortOrder.None)
                {
                    if (ColumnaOrdenar.Name == "rol_descripcion")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgRolOficina.DataSource = coleccion.OrderBy(p => p.rol_descripcion).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgRolOficina.DataSource = coleccion.OrderBy(p => p.rol_descripcion).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                    if (ColumnaOrdenar.Name == "tar_descripcion")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgRolOficina.DataSource = coleccion.OrderBy(p => p.oficina_descripcion).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgRolOficina.DataSource = coleccion.OrderBy(p => p.oficina_descripcion).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                }
            }
        }


    }
}
