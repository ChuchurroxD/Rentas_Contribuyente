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

namespace SGR.WinApp.Layout._1_Tablas_Maestras.Sectores
{
    public partial class Frm_sectores : DockContent
    {
       private  Pred_SectorDataService pred_sectordataservice = new Pred_SectorDataService();
        private List<Pred_Sector> Coleccion;
        private System.Windows.Forms.SortOrder Orden = new System.Windows.Forms.SortOrder();
        public Frm_sectores()
        {
            InitializeComponent();
        }

        private void toolnuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_sectores_detalle Frm_sectores_detalle = new Frm_sectores_detalle();
                Frm_sectores_detalle.StartPosition = FormStartPosition.CenterParent;
                Frm_sectores_detalle.ShowDialog();
                Pred_SectorDataService pred_SectorDataService = new Pred_SectorDataService();
                dataGridView1.DataSource = pred_SectorDataService.listarTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void tooleditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Frm_sectores_detalle Frm_sectores_detalle = new Frm_sectores_detalle(obtenerdatos());
                Frm_sectores_detalle.StartPosition = FormStartPosition.CenterParent;
                Frm_sectores_detalle.ShowDialog();

                if (txtbusqueda.Text.Trim().Length == 0)
                    dataGridView1.DataSource = pred_sectordataservice.listarTodos();
                else
                    dataGridView1.DataSource = pred_sectordataservice.Getcoleccion("s.Descripcion like '%" + txtbusqueda.Text + "%'", "s.Descripcion");
            }else
            {
                MessageBox.Show("Debe selecionar una fila", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private Pred_Sector obtenerdatos()
        {
            Pred_Sector pred_sector = new Pred_Sector();
            pred_sector.sector_id = (Int32)dataGridView1.SelectedRows[0].Cells["xsector_id"].Value;
            pred_sector.descripcion = (string)dataGridView1.SelectedRows[0].Cells["xdescripcion"].Value.ToString ().TrimEnd();
            pred_sector.tipo_Junta = (string)dataGridView1.SelectedRows[0].Cells["xTipo_Junta"].Value;
            pred_sector.barrido = (bool)dataGridView1.SelectedRows[0].Cells["xBarrido"].Value;
            pred_sector.recojo = (bool)dataGridView1.SelectedRows[0].Cells["xRecojo"].Value;
            pred_sector.jardin = (bool)dataGridView1.SelectedRows[0].Cells["xJardin"].Value;
            pred_sector.serenazgo = (bool)dataGridView1.SelectedRows[0].Cells["xSerenazgo"].Value;
            pred_sector.estado = (bool)dataGridView1.SelectedRows[0].Cells["xestado"].Value;
            pred_sector.sysFecha = (DateTime)dataGridView1.SelectedRows[0].Cells["xsysFecha"].Value;
            pred_sector.sysUser = (string)dataGridView1.SelectedRows[0].Cells["xusuario"].Value;

            return pred_sector;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            tooleditar.PerformClick();
        }

        private void Frm_sectores_Load(object sender, EventArgs e)
        {
            try
            {
                txtbusqueda.Focus();
                Coleccion = pred_sectordataservice.listarTodos();
                dataGridView1.DataSource = Coleccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
  
            //DgvFilterManager DgvFilterManager = new DgvFilterManager(dataGridView1);
        }

        //private void tooleliminar_Click(object sender, EventArgs e)
        //{
        //    if (MessageBox.Show("Desean Eliminar?", Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //    {
        //        pred_sectordataservice.deletebyprimarykey(obtenerId());
        //        dataGridView1.DataSource = pred_sectordataservice.listarTodos();
        //    }
        //}
        //private Int32 obtenerId()
        //{
        //    return (Int32)dataGridView1.SelectedRows[0].Cells["xSector_id"].Value;
        //}
        private void toolcancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtbusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {                                
                if (e.KeyChar==Convert.ToChar(Keys.Enter))
                {
                    dataGridView1.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button==System.Windows.Forms.MouseButtons.Left)
            {
                DataGridViewColumn ColumnaOrdenar = dataGridView1.Columns[e.ColumnIndex];

                if (dataGridView1.SortOrder== System.Windows.Forms.SortOrder.None)
                {

                    if (ColumnaOrdenar.Name == "xdescripcion")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.descripcion).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.descripcion).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "xDescripcionTipo")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.descripcionTIpo).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.descripcionTIpo).Reverse().ToList();
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
                Coleccion = pred_sectordataservice.listarTodos();
                frmVisor.reportViewer1.LocalReport.DataSources.Clear();
                frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._1_Tablas_Maestras.Sectores.rptSector.rdlc";
                frmVisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", Coleccion));
                ReportParameter[] param = new ReportParameter[2];
                param[0] = new ReportParameter("Empresa", Globales.NombreEmpresa);
                param[1] = new ReportParameter("Usuario", Globales.UsuarioPrueba);
                frmVisor.reportViewer1.LocalReport.SetParameters(param);
                frmVisor.reportViewer1.RefreshReport();
                frmVisor.StartPosition = FormStartPosition.CenterScreen;
                frmVisor.ShowDialog();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = pred_sectordataservice.Getcoleccion("s.Descripcion like '%" + txtbusqueda.Text + "%'", "s.Descripcion");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
