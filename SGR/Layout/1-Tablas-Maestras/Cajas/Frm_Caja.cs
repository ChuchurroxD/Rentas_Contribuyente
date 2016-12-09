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

namespace SGR.WinApp.Layout._1_Tablas_Maestras.Cajas
{
    public partial class Frm_Caja : DockContent
    {
        private Pago_CajaDataService Pago_CajaDataService = new Pago_CajaDataService();
        private List<Pago_Caja> Coleccion;
        private System.Windows.Forms.SortOrder Orden = new System.Windows.Forms.SortOrder();
        public Frm_Caja()
        {
            InitializeComponent();
        }

        private void Frm_Caja_Load(object sender, EventArgs e)
        {
            try
            {
                txtbusqueda.Focus();
                Coleccion = Pago_CajaDataService.getColeccion("c.descripcion like '%" + txtbusqueda.Text + "%'", "c.descripcion");
                dataGridView1.DataSource = Coleccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private Pago_Caja obtenerObjeto()
        {
            Pago_Caja Pago_Caja = new Pago_Caja();
            Pago_Caja.Caja_id = (Int32)dataGridView1.SelectedRows[0].Cells["xCaja_id"].Value;
            Pago_Caja.Descripcion = (string)dataGridView1.SelectedRows[0].Cells["xdescripcion"].Value;
            Pago_Caja.idOficina = (Int32)dataGridView1.SelectedRows[0].Cells["xidOficina"].Value;
            Pago_Caja.Estado = (bool)dataGridView1.SelectedRows[0].Cells["xestado"].Value;
            Pago_Caja.registro_fecha_add = (DateTime)dataGridView1.SelectedRows[0].Cells["xregistro_fecha_add"].Value;
            Pago_Caja.registro_user_add = (string)dataGridView1.SelectedRows[0].Cells["xregistro_user_add"].Value;
            Pago_Caja.registro_pc_add = (string)dataGridView1.SelectedRows[0].Cells["xregistro_pc_add"].Value;
            Pago_Caja.registro_fecha_update = (DateTime)dataGridView1.SelectedRows[0].Cells["xregistro_fecha_update"].Value;
            Pago_Caja.registro_user_update = (string)dataGridView1.SelectedRows[0].Cells["xregistro_user_update"].Value;
            Pago_Caja.registro_pc_update = (string)dataGridView1.SelectedRows[0].Cells["xregistro_pc_update"].Value;
            return Pago_Caja;
        }
        //private int obtenerId()
        //{
        //    int codigo = (Int32)dataGridView1.SelectedRows[0].Cells["xCaja_id"].Value;
        //    return codigo;
        //}

        private void toolnuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_Caja_Detalle Frm_Caja_Detalle = new Frm_Caja_Detalle();
                Frm_Caja_Detalle.StartPosition = FormStartPosition.CenterParent;
                Frm_Caja_Detalle.ShowDialog();

                Coleccion = Pago_CajaDataService.getColeccion("c.descripcion like '%" + txtbusqueda.Text + "%'", "c.descripcion");
                dataGridView1.DataSource = Coleccion;
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tooleditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    Frm_Caja_Detalle Frm_Caja_Detalle = new Frm_Caja_Detalle(obtenerObjeto());
                    Frm_Caja_Detalle.StartPosition = FormStartPosition.CenterParent;
                    Frm_Caja_Detalle.ShowDialog();
                    Coleccion = Pago_CajaDataService.getColeccion("c.descripcion like '%" + txtbusqueda.Text + "%'", "c.descripcion");
                    dataGridView1.DataSource = Coleccion;
                }else
                {
                    MessageBox.Show("Debe selecionar una fila", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //private void tooleliminar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (MessageBox.Show("Desean Eliminar?", Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //        {
        //            Pago_CajaDataService.deletebycodigo(obtenerId());
        //            Coleccion = Pago_CajaDataService.getColeccion("c.descripcion like '%" + txtbusqueda.Text + "%'", "c.descripcion");
        //            dataGridView1.DataSource = Coleccion;
        //        }
        //    }
        //    catch(Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, Globales.Global_MessageBox);
        //    }
        //}

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            tooleditar.PerformClick();
        }

        private void txtbusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                dataGridView1.Focus();
            }
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                DataGridViewColumn ColumnaOrdenar = dataGridView1.Columns[e.ColumnIndex];
                if(dataGridView1.SortOrder == System.Windows.Forms.SortOrder.None)
                {
                    if(ColumnaOrdenar.Name == "xdescripcion")
                    {
                        if(Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.Descripcion).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.Descripcion).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }else if(ColumnaOrdenar.Name == "xtipo")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.tipo).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.tipo).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                }
            }
        }
        private void toolcancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void toolImprimir_Click(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            Frm_Visor_Global frmvisor = new Frm_Visor_Global();
            try
            {
                Coleccion = Pago_CajaDataService.getColeccion("c.descripcion like'%%'", "c.descripcion");
                frmvisor.reportViewer1.LocalReport.DataSources.Clear();
                frmvisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._1_Tablas_Maestras.Cajas.rptCaja.rdlc";
                frmvisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", Coleccion));
                ReportParameter[] param = new ReportParameter[2];
                param[0] = new ReportParameter("Empresa",Globales.NombreEmpresa);
                param[1] = new ReportParameter("Usuario",Globales.UsuarioPrueba);
                frmvisor.reportViewer1.LocalReport.SetParameters(param);

                frmvisor.reportViewer1.RefreshReport();
                frmvisor.StartPosition = FormStartPosition.CenterScreen;
                frmvisor.ShowDialog();
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
                Coleccion = Pago_CajaDataService.getColeccion("c.Descripcion like '%" + txtbusqueda.Text + "%'", "c.Descripcion");
                dataGridView1.DataSource = Coleccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}