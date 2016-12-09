using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGR.Core.Service;
using WeifenLuo.WinFormsUI.Docking;
using SGR.Entity.Model;
using Microsoft.Reporting.WinForms;
using SGR.WinApp.Layout._5_Reportes_Gestion;

namespace SGR.WinApp.Layout._1_Tablas_Maestras.CajeroCajas
{
    public partial class Frm_CajeroCaja : DockContent
    {
        Pago_CajeroCajaDataService Pago_CajeroCajaDataService = new Pago_CajeroCajaDataService();
        List<Pago_CajeroCaja> coleccion;
        System.Windows.Forms.SortOrder Orden = new System.Windows.Forms.SortOrder();
        public Frm_CajeroCaja()
        {
            InitializeComponent();
        }

        private void Frm_CajeroCaja_Load(object sender, EventArgs e)
        {
            try
            {
                txtBusqueda.Focus();
                coleccion = Pago_CajeroCajaDataService.listartodos();
                dataGridView1.DataSource = coleccion;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private Pago_CajeroCaja obtenerObjeto()
        {
            try
            {
                Pago_CajeroCaja Pago_CajeroCaja = new Pago_CajeroCaja();
                Pago_CajeroCaja.CajeroCaja_id = (Int32)dataGridView1.SelectedRows[0].Cells["CajeroCaja_id"].Value;
                Pago_CajeroCaja.Caja_id = (Int32)dataGridView1.SelectedRows[0].Cells["Caja_id"].Value;
                Pago_CajeroCaja.Persona_id = (string)dataGridView1.SelectedRows[0].Cells["Persona_id"].Value;
                Pago_CajeroCaja.Estado = (bool)dataGridView1.SelectedRows[0].Cells["estado"].Value;
                Pago_CajeroCaja.registro_fecha_add = (DateTime)dataGridView1.SelectedRows[0].Cells["fecha_registro_add"].Value;
                Pago_CajeroCaja.registro_pc_add = (string)dataGridView1.SelectedRows[0].Cells["registro_pc_add"].Value;
                Pago_CajeroCaja.registro_user_add = (string)dataGridView1.SelectedRows[0].Cells["registro_user_add"].Value;
                Pago_CajeroCaja.registro_fecha_update = (DateTime)dataGridView1.SelectedRows[0].Cells["registro_fecha_update"].Value;
                Pago_CajeroCaja.registro_pc_update = (string)dataGridView1.SelectedRows[0].Cells["registro_pc_update"].Value;
                Pago_CajeroCaja.registro_user_update = (string)dataGridView1.SelectedRows[0].Cells["registro_user_update"].Value;
                return Pago_CajeroCaja;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }

        private void toolNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_CajeroCajaDetalle Frm_CajeroCajaDetalle = new Frm_CajeroCajaDetalle();
                Frm_CajeroCajaDetalle.StartPosition = FormStartPosition.CenterParent;
                Frm_CajeroCajaDetalle.ShowDialog();
                coleccion = Pago_CajeroCajaDataService.listartodos();
                dataGridView1.DataSource = coleccion;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    Frm_CajeroCajaDetalle Frm_CajeroCajaDetalle = new Frm_CajeroCajaDetalle(obtenerObjeto());
                    Frm_CajeroCajaDetalle.StartPosition = FormStartPosition.CenterParent;
                    Frm_CajeroCajaDetalle.ShowDialog();
                    coleccion = Pago_CajeroCajaDataService.listartodos();
                    dataGridView1.DataSource = coleccion;
                }else
                {
                    MessageBox.Show("Debe selecionar una fila", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            toolEditar.PerformClick();
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                coleccion = Pago_CajeroCajaDataService.getColeccion("nombrecompleto like '%" + txtBusqueda.Text + "%'","nombrecompleto");
                dataGridView1.DataSource = coleccion;
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    dataGridView1.Focus();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                DataGridViewColumn ColumnaOrdenar = dataGridView1.Columns[e.ColumnIndex];
                if(dataGridView1.SortOrder == System.Windows.Forms.SortOrder.None)
                {
                    if(ColumnaOrdenar.Name == "nombrecompleto")
                    {
                        if(Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = coleccion.OrderBy(p => p.nombrecompleto).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dataGridView1.DataSource = coleccion.OrderBy(p => p.nombrecompleto).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }else if(ColumnaOrdenar.Name == "caja_descripcion")
                    {
                        if(Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = coleccion.OrderBy(p => p.caja_descripcion).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }else
                        {
                            dataGridView1.DataSource = coleccion.OrderBy(p => p.caja_descripcion).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                }
            }
        }

        private void toolImprimir_Click(object sender, EventArgs e)
        {
            if(Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            Frm_Visor_Global frmvisor = new Frm_Visor_Global();
            try
            {
                coleccion = Pago_CajeroCajaDataService.listartodos();
                frmvisor.reportViewer1.LocalReport.DataSources.Clear();
                frmvisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._1_Tablas_Maestras.CajeroCajas.rptCajeroCaja.rdlc";
                frmvisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", coleccion));
                ReportParameter[] param = new ReportParameter[2];
                param[0] = new ReportParameter("Empresa", Globales.NombreEmpresa);
                param[1] = new ReportParameter("Usuario", Globales.UsuarioPrueba);
                frmvisor.reportViewer1.LocalReport.SetParameters(param);

                frmvisor.reportViewer1.RefreshReport();
                frmvisor.StartPosition = FormStartPosition.CenterScreen;
                frmvisor.ShowDialog();
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
