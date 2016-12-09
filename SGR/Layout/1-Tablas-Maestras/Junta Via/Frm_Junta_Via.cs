using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGR.Core.Service;
using SGR.Entity;
using SGR.WinApp.Layout._5_Reportes_Gestion;
using WeifenLuo.WinFormsUI.Docking;
using Microsoft.Reporting.WinForms;

namespace SGR.WinApp.Layout._1_Tablas_Maestras.Junta_Via
{
    public partial class Frm_Junta_Via : DockContent
    {
        Mant_JuntaViaDataService Mant_JuntaViaDataService = new Mant_JuntaViaDataService();
        List<Mant_Junta_Via> coleccion = new List<Mant_Junta_Via>();
        System.Windows.Forms.SortOrder Orden = new System.Windows.Forms.SortOrder();
        public Frm_Junta_Via()
        {
            InitializeComponent();
        }

        private void Frm_Junta_Via_Load(object sender, EventArgs e)
        {
            try
            {
                txtDescripcionSector.Focus();
                coleccion = Mant_JuntaViaDataService.listartodos();
                dataGridView1.DataSource = coleccion;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private Mant_Junta_Via obtenerObjeto()
        {
            try
            {
                Mant_Junta_Via mant_Junta_Via = new Mant_Junta_Via();
                mant_Junta_Via.junta_via_ID = (Int32)dataGridView1.SelectedRows[0].Cells["junta_via_ID"].Value;
                mant_Junta_Via.junta_ID = (string)dataGridView1.SelectedRows[0].Cells["junta_ID"].Value;
                mant_Junta_Via.via_ID = (string)dataGridView1.SelectedRows[0].Cells["via_id"].Value;
                mant_Junta_Via.estado = (bool)dataGridView1.SelectedRows[0].Cells["estado"].Value;
                mant_Junta_Via.registro_fecha_add = (DateTime)dataGridView1.SelectedRows[0].Cells["registro_fecha_add"].Value;
                mant_Junta_Via.registro_pc_add = (string)dataGridView1.SelectedRows[0].Cells["registro_pc_add"].Value;
                mant_Junta_Via.registro_user_add = (string)dataGridView1.SelectedRows[0].Cells["registro_user_add"].Value;
                mant_Junta_Via.registro_fecha_update = (DateTime)dataGridView1.SelectedRows[0].Cells["registro_fecha_update"].Value;
                mant_Junta_Via.registro_pc_update = (string)dataGridView1.SelectedRows[0].Cells["registro_pc_update"].Value;
                mant_Junta_Via.registro_user_update = (string)dataGridView1.SelectedRows[0].Cells["registro_user_update"].Value;
                return mant_Junta_Via;

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }
        }

        private void toolnuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_Junta_ViaDetalle frmJuntaDetalle = new Frm_Junta_ViaDetalle();
                frmJuntaDetalle.StartPosition = FormStartPosition.CenterParent;
                frmJuntaDetalle.ShowDialog();
                coleccion = Mant_JuntaViaDataService.getColeccion("s.Descripcion like '%" + txtDescripcionSector.Text + "%'", "descripcion_sector");
                dataGridView1.DataSource = coleccion;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tooleditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    Frm_Junta_ViaDetalle frmJuntaViaDetalle = new Frm_Junta_ViaDetalle(obtenerObjeto());
                    frmJuntaViaDetalle.StartPosition = FormStartPosition.CenterParent;
                    frmJuntaViaDetalle.ShowDialog();
                    coleccion = Mant_JuntaViaDataService.getColeccion("s.Descripcion like '%" + txtDescripcionSector.Text + "%'", "descripcion_sector");
                    dataGridView1.DataSource = coleccion;
                }else
                {
                    MessageBox.Show("Debe selecionar una fila", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void toolCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void toolImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cursor.Current == Cursors.WaitCursor)
                    return;
                Cursor.Current = Cursors.WaitCursor;
                coleccion = Mant_JuntaViaDataService.listartodos();
                Frm_Visor_Global frmVisor = new Frm_Visor_Global();
                frmVisor.reportViewer1.LocalReport.DataSources.Clear();
                frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._1_Tablas_Maestras.Junta_Via.rptJuntaVia.rdlc";
                frmVisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", coleccion));
                ReportParameter[] param = new ReportParameter[2];
                param[0] = new ReportParameter("Empresa", Globales.NombreEmpresa);
                param[1] = new ReportParameter("Usuario", Globales.UsuarioPrueba);
                frmVisor.reportViewer1.LocalReport.SetParameters(param);
                frmVisor.reportViewer1.RefreshReport();
                frmVisor.StartPosition = FormStartPosition.CenterParent;
                frmVisor.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void txtDescripcionSector_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                dataGridView1.Focus();
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
                    if (ColumnaOrdenar.Name == "descripcion_sector")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = coleccion.OrderBy(p => p.descripcion_sector).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dataGridView1.DataSource = coleccion.OrderBy(p => p.descripcion_sector).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "via_descripcion")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = coleccion.OrderBy(p => p.via_descripcion).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dataGridView1.DataSource = coleccion.OrderBy(p => p.via_descripcion).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                }
            }
        }

        private void txtDescripcionSector_TextChanged(object sender, EventArgs e)
        {
            try
            {
                coleccion = Mant_JuntaViaDataService.getColeccion("s.Descripcion like '%" + txtDescripcionSector.Text + "%'", "descripcion_sector");
                dataGridView1.DataSource = coleccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
