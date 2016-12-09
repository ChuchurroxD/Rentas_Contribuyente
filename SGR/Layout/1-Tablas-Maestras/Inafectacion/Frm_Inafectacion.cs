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
using WeifenLuo.WinFormsUI.Docking;

namespace SGR.WinApp.Layout._1_Tablas_Maestras.Inafectacion
{
    public partial class Frm_Inafectacion : DockContent
    {
        Mant_InafectacionDataService mant_InafectacionDataService = new Mant_InafectacionDataService();
        private List<Mant_Inafectacion> coleccion;
        private System.Windows.Forms.SortOrder Orden = new System.Windows.Forms.SortOrder();

        public Frm_Inafectacion()
        {
            InitializeComponent();
        }

        private void toolNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_Inafectacion_detalle frm_Inafectacion_detalle = new Frm_Inafectacion_detalle();
                frm_Inafectacion_detalle.StartPosition = FormStartPosition.CenterParent;
                frm_Inafectacion_detalle.ShowDialog();
                //Conf_GrupoDataService conf_GrupoDataService = new Conf_GrupoDataService();
                //dgGrupos.DataSource = conf_GrupoDataService.GetAllConf_Grupo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private Mant_Inafectacion obtenerDatos()
        {
            Mant_Inafectacion mant_Inafectacion = new Mant_Inafectacion();
            mant_Inafectacion.inafectado_id = (Int32)(dgInafectacion.SelectedRows[0].Cells["inafectado_id"].Value);
            mant_Inafectacion.persona_id = (string)dgInafectacion.SelectedRows[0].Cells["persona_id"].Value.ToString().TrimEnd();
            mant_Inafectacion.nombre = (string)dgInafectacion.SelectedRows[0].Cells["nombre"].Value.ToString().TrimEnd();
            mant_Inafectacion.exp_descripcion = (string)dgInafectacion.SelectedRows[0].Cells["exp_descripcion"].Value.ToString().TrimEnd();
            mant_Inafectacion.exp_anio = (Int32)(dgInafectacion.SelectedRows[0].Cells["exp_anio"].Value);
            mant_Inafectacion.resolucion = (string)dgInafectacion.SelectedRows[0].Cells["resolucion"].Value.ToString().TrimEnd();
            mant_Inafectacion.observacion = (string)dgInafectacion.SelectedRows[0].Cells["observacion"].Value.ToString().TrimEnd();
            mant_Inafectacion.registro_user_add = (string)dgInafectacion.SelectedRows[0].Cells["registro_user_add"].Value.ToString().TrimEnd();
            mant_Inafectacion.registro_user_update = (string)dgInafectacion.SelectedRows[0].Cells["registro_user_update"].Value.ToString().TrimEnd();
            mant_Inafectacion.registro_pc_add = (string)dgInafectacion.SelectedRows[0].Cells["registro_pc_add"].Value.ToString().TrimEnd();
            mant_Inafectacion.registro_pc_update = (string)dgInafectacion.SelectedRows[0].Cells["registro_pc_update"].Value.ToString().TrimEnd();
            mant_Inafectacion.registro_fecha_add = (DateTime)dgInafectacion.SelectedRows[0].Cells["registro_fecha_add"].Value;
            mant_Inafectacion.registro_fecha_update = (DateTime)dgInafectacion.SelectedRows[0].Cells["registro_fecha_update"].Value;
            mant_Inafectacion.estado = (bool)dgInafectacion.SelectedRows[0].Cells["estado"].Value;
            return mant_Inafectacion;
        }

        private void Frm_Inafectacion_Load(object sender, EventArgs e)
        {
            try
            {
                txtBusqueda.Focus();
                dgInafectacion.DataSource = mant_InafectacionDataService.listartodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgInafectacion.DataSource = mant_InafectacionDataService.buscar(txtBusqueda.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgInafectacion_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                DataGridViewColumn ColumnaOrdenar = dgInafectacion.Columns[e.ColumnIndex];

                if (dgInafectacion.SortOrder == System.Windows.Forms.SortOrder.None)
                {
                    if (ColumnaOrdenar.Name == "nombre")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgInafectacion.DataSource = coleccion.OrderBy(p => p.nombre).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgInafectacion.DataSource = coleccion.OrderBy(p => p.nombre).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                }
            }
        }

        private void toolEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgInafectacion.CurrentRow == null)
                    throw new Exception("Debe seleccionar una fila.");

                Frm_Inafectacion_detalle frm_Inafectacion_detalle = new Frm_Inafectacion_detalle(obtenerDatos());
                frm_Inafectacion_detalle.StartPosition = FormStartPosition.CenterParent;
                frm_Inafectacion_detalle.ShowDialog();

                if (txtBusqueda.Text.Trim().Length == 0)
                    dgInafectacion.DataSource = mant_InafectacionDataService.listartodos();
                else
                    dgInafectacion.DataSource = mant_InafectacionDataService.buscar(txtBusqueda.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgInafectacion_DoubleClick(object sender, EventArgs e)
        {
            toolEditar.PerformClick();
        }
    }
}
