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

namespace SGR.WinApp.Layout._1_Tablas_Maestras.FormatoCampos
{
    public partial class Frm_FormatoCampos : DockContent
    {
        private Pred_TributoDataService pred_TributoDataService = new Pred_TributoDataService();
        Trib_FormatoCamposDataService trib_FormaCamposDataService = new Trib_FormatoCamposDataService();
        private List<Trib_FormatoCampos> coleccion;
        private System.Windows.Forms.SortOrder Orden = new System.Windows.Forms.SortOrder();

        public Frm_FormatoCampos()
        {
            InitializeComponent();
        }

        private void Frm_TribFormatoCampos_Load(object sender, EventArgs e)
        {
            llenarPeriodo();
        }

        private void llenarPeriodo()
        {
            try
            {
                cboPeriodo.DisplayMember = "Peric_canio";
                cboPeriodo.ValueMember = "Peric_canio";
                cboPeriodo.DataSource = pred_TributoDataService.llenarPeriodo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cboPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            coleccion = trib_FormaCamposDataService.buscarByAnio((Int32)cboPeriodo.SelectedValue);
            dgFormatoCampos.DataSource = coleccion;
        }

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            coleccion = trib_FormaCamposDataService.buscarByAnioByColumna((Int32)cboPeriodo.SelectedValue, txtBusqueda.Text.Trim());
            dgFormatoCampos.DataSource = coleccion;
        }

        private void tooleditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgFormatoCampos.CurrentRow == null)
                    throw new Exception("Debe seleccionar una fila.");

                Frm_FormatoCamposDetalle frm_FormatoCamposDetalle = new Frm_FormatoCamposDetalle(obtenerDatos());
                frm_FormatoCamposDetalle.StartPosition = FormStartPosition.CenterParent;
                frm_FormatoCamposDetalle.ShowDialog();

                if (txtBusqueda.Text.Trim().Length == 0)
                    dgFormatoCampos.DataSource = trib_FormaCamposDataService.buscarByAnio(Convert.ToInt32(cboPeriodo.SelectedValue));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private Trib_FormatoCampos obtenerDatos()
        {
            Trib_FormatoCampos trib_FormatoCampos = new Trib_FormatoCampos();
            Conf_Grupo conf_grupo = new Conf_Grupo();
            try
            {
                trib_FormatoCampos.id = (Int32)dgFormatoCampos.SelectedRows[0].Cells["xFormColum_id"].Value;
                trib_FormatoCampos.tipo_formato_id = (string)dgFormatoCampos.SelectedRows[0].Cells["xTipoFormato_id"].Value.ToString().TrimEnd();
                trib_FormatoCampos.tipo_formato_descripcion = (string)dgFormatoCampos.SelectedRows[0].Cells["xTipoFormato_descripcion"].Value.ToString().TrimEnd();
                trib_FormatoCampos.anio = (Int32)dgFormatoCampos.SelectedRows[0].Cells["xFormColum_anio"].Value;
                trib_FormatoCampos.colum1 = (string)dgFormatoCampos.SelectedRows[0].Cells["xFormColum_Columna1"].Value.ToString().TrimEnd();
                trib_FormatoCampos.colum2 = (string)dgFormatoCampos.SelectedRows[0].Cells["xFormColum_Columna2"].Value.ToString().TrimEnd();
                trib_FormatoCampos.colum3 = (string)dgFormatoCampos.SelectedRows[0].Cells["xFormColum_Columna3"].Value.ToString().TrimEnd();
                trib_FormatoCampos.colum4 = (string)dgFormatoCampos.SelectedRows[0].Cells["xFormColum_Columna4"].Value.ToString().TrimEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
            return trib_FormatoCampos;
        }

        private void dgFormatoCampos_DoubleClick(object sender, EventArgs e)
        {
            toolEditar.PerformClick();
        }

        private void dgFormatoCampos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                DataGridViewColumn ColumnaOrdenar = dgFormatoCampos.Columns[e.ColumnIndex];

                if (dgFormatoCampos.SortOrder == System.Windows.Forms.SortOrder.None)
                {
                    if (ColumnaOrdenar.Name == "xTipoFormato_descripcion")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgFormatoCampos.DataSource = coleccion.OrderBy(p => p.tipo_formato_descripcion).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgFormatoCampos.DataSource = coleccion.OrderBy(p => p.tipo_formato_descripcion).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                }
            }
        }

        private void toolNuevo_Click(object sender, EventArgs e)
        {
            Frm_FormatoCamposDetalle frm_FormatoCamposDetalle = new Frm_FormatoCamposDetalle();
            frm_FormatoCamposDetalle.StartPosition = FormStartPosition.CenterScreen;
            frm_FormatoCamposDetalle.ShowDialog();
            coleccion = trib_FormaCamposDataService.buscarByAnio((Int32)cboPeriodo.SelectedValue);
            dgFormatoCampos.DataSource = coleccion;
        }

        private void Frm_FormatoCampos_Load(object sender, EventArgs e)
        {

        }
    }
}
