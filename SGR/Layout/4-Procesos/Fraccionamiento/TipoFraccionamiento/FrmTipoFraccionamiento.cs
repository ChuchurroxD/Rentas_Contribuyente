using DgvFilterPopup;
using SGR.Core.Service;
using SGR.Entity.Model;
using System;
using System.Windows.Forms;
using SGR.WinApp.Layout._5_Reportes_Gestion;
using WeifenLuo.WinFormsUI.Docking;

using System.Collections.Generic;
using System.Linq;
using Microsoft.Reporting.WinForms;

namespace SGR.WinApp.Layout._4_Procesos.Fraccionamiento
{
    public partial class FrmTipoFraccionamiento : DockContent
    {
        private Trib_TipoFraccionamientoDataService trib_TipoFraccionamiento = new Trib_TipoFraccionamientoDataService();
        private System.Windows.Forms.SortOrder Orden = new System.Windows.Forms.SortOrder();
        private List<Trib_TipoFraccionamiento> Coleccion;
        public FrmTipoFraccionamiento()
        {
            InitializeComponent();
            Coleccion= trib_TipoFraccionamiento.listartodos();
            dataGridView1.DataSource = Coleccion;
        }

        private void FrmFraccionamiento_Load(object sender, EventArgs e)
        {
          
        }
        private void txtbusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Coleccion= trib_TipoFraccionamiento.Getcoleccion("base_legal like '%" + txtbusqueda.Text + "%'", "base_legal");
                dataGridView1.DataSource = Coleccion;

                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    dataGridView1.Focus();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }
        private void toolnuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_FraccionamientoDetalle Frm_FraccionamientoDetalle = new Frm_FraccionamientoDetalle();
                Frm_FraccionamientoDetalle.StartPosition = FormStartPosition.CenterParent;
                Frm_FraccionamientoDetalle.ShowDialog();
                Coleccion= trib_TipoFraccionamiento.listartodos();
                dataGridView1.DataSource = Coleccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void tooleditar_Click(object sender, EventArgs e)
        {
            //            MessageBox.Show(Convert.ToString((Int32)dataGridView1.SelectedRows[0].Cells["xTipoFracc"].Value));
            int codigo = (Int32)dataGridView1.SelectedRows[0].Cells["xTipoFracc"].Value;
            Frm_FraccionamientoDetalle frm_FraccionamientoDetalle = new Frm_FraccionamientoDetalle(trib_TipoFraccionamiento.GetByPrimaryKey(codigo),codigo);
            frm_FraccionamientoDetalle.StartPosition = FormStartPosition.CenterParent;
            frm_FraccionamientoDetalle.ShowDialog();
            Coleccion= trib_TipoFraccionamiento.Getcoleccion("base_legal like '%" + txtbusqueda.Text + "%'", "base_legal");
            dataGridView1.DataSource = Coleccion;

            //if (txtbusqueda.Text.Trim().Length == 0)
            //    dataGridView1.DataSource = pred_sectordataservice.listarTodos();
            //else
            //    dataGridView1.DataSource = pred_sectordataservice.Getcoleccion("Descripcion like '%" + txtbusqueda.Text + "%'", "Descripcion");

        }
        private Trib_TipoFraccionamiento obtenerdatos()
        {
            Trib_TipoFraccionamiento pred_sector = new Trib_TipoFraccionamiento();
            return pred_sector;
        }

        private void CambiarPosicion(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                bool estado= (bool)dataGridView1.SelectedRows[0].Cells["xestado"].Value;
                if (estado)
                    tooleliminar.Enabled = true;
                else
                    tooleliminar.Enabled = false;

            }
            catch (Exception ex)
            {

            }
        }

        private void tooleliminar_Click(object sender, EventArgs e)
        {
            try { 
                int codigo = (Int32)dataGridView1.SelectedRows[0].Cells["xTipoFracc"].Value;
                trib_TipoFraccionamiento.DeleteByPrimaryKey(codigo);
                Coleccion= trib_TipoFraccionamiento.listartodos();
                dataGridView1.DataSource = Coleccion;
            }
            catch(Exception ex)
            {

            }
        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            tooleditar.PerformClick();
        }
        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                DataGridViewColumn ColumnaOrdenar = dataGridView1.Columns[e.ColumnIndex];

                if (dataGridView1.SortOrder == System.Windows.Forms.SortOrder.None)
                {

                    if (ColumnaOrdenar.Name == "TiFr_base_legal")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.TiFr_base_legal).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.TiFr_base_legal).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "xdescripcion")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.TiFr_fecha_inicio).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.TiFr_fecha_inicio).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }

                    }
                    else if (ColumnaOrdenar.Name == "xTipo_Junta")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.TiFr_fecha_fin).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.TiFr_fecha_fin).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "xusuario")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.TiFr_modalidadDesc).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.TiFr_modalidadDesc).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                }

            }
        }

        private void toolImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cursor.Current == Cursors.WaitCursor)
                    return;
                Cursor.Current = Cursors.WaitCursor;
                Coleccion = trib_TipoFraccionamiento.listartodos();
                Frm_Visor_Global frmVisor = new Frm_Visor_Global();
                frmVisor.reportViewer1.LocalReport.DataSources.Clear();
                frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._4_Procesos.Fraccionamiento.TipoFraccionamiento.rptTipoFraccionamiento.rdlc";
                frmVisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", Coleccion));
                ReportParameter[] param = new ReportParameter[2];
                param[0] = new ReportParameter("Empresa", Globales.NombreEmpresa);
                param[1] = new ReportParameter("Usuario", Globales.UsuarioPrueba);
                frmVisor.reportViewer1.LocalReport.SetParameters(param);
                frmVisor.reportViewer1.RefreshReport();
                frmVisor.StartPosition = FormStartPosition.CenterParent;
                frmVisor.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
