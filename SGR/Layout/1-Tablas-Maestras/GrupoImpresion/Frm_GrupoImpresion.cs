using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGR.Entity.Model;
using SGR.Core.Service;
using WeifenLuo.WinFormsUI.Docking;
using SGR.WinApp.Layout._5_Reportes_Gestion;
using Microsoft.Reporting.WinForms;

namespace SGR.WinApp.Layout._1_Tablas_Maestras.GrupoImpresion
{
    public partial class Frm_GrupoImpresion : DockContent
    {
        private Mant_GrupoImpresionDataService Mant_GrupoImpresionDataService = new Mant_GrupoImpresionDataService();
        private List<Mant_GrupoImpresion> coleccion = new List<Mant_GrupoImpresion>();
        System.Windows.Forms.SortOrder Orden = new System.Windows.Forms.SortOrder();
        public Frm_GrupoImpresion()
        {
            InitializeComponent();
        }

        private void Frm_GrupoImpresion_Load(object sender, EventArgs e)
        {
            coleccion = Mant_GrupoImpresionDataService.listartodos();
            dataGridView1.DataSource = coleccion;
            txtbusqueda.Focus();
        }
        private Mant_GrupoImpresion obtenerObjeto()
        {
            try
            {
                Mant_GrupoImpresion Mant_GrupoImpresion = new Mant_GrupoImpresion();
                Mant_GrupoImpresion.grupoImpresion_ID = (Int32)dataGridView1.SelectedRows[0].Cells["grupoImpresion_ID"].Value;
                Mant_GrupoImpresion.tributo_ID = (string)dataGridView1.SelectedRows[0].Cells["tributo_ID"].Value;
                Mant_GrupoImpresion.grupoTipoImpresion = (string)dataGridView1.SelectedRows[0].Cells["grupoTipoImpresion"].Value.ToString().Trim();
                Mant_GrupoImpresion.estado = (bool)dataGridView1.SelectedRows[0].Cells["estado"].Value;
                Mant_GrupoImpresion.periodo_ID = (Int32)dataGridView1.SelectedRows[0].Cells["periodo_ID"].Value;
                Mant_GrupoImpresion.tipo_tributo = (string)dataGridView1.SelectedRows[0].Cells["tipo_tributo"].Value;
                Mant_GrupoImpresion.registro_fecha_add = (DateTime)dataGridView1.SelectedRows[0].Cells["registro_fecha_add"].Value;
                Mant_GrupoImpresion.registro_user_add = (string)dataGridView1.SelectedRows[0].Cells["registro_user_add"].Value;
                Mant_GrupoImpresion.registro_pc_add = (string)dataGridView1.SelectedRows[0].Cells["registro_pc_add"].Value;
                Mant_GrupoImpresion.registro_fecha_update = (DateTime)dataGridView1.SelectedRows[0].Cells["registro_fecha_update"].Value;
                Mant_GrupoImpresion.registro_user_update = (string)dataGridView1.SelectedRows[0].Cells["registro_user_update"].Value;
                Mant_GrupoImpresion.registro_pc_update = (string)dataGridView1.SelectedRows[0].Cells["registro_pc_update"].Value;
                return Mant_GrupoImpresion;
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
                Frm_GrupoImpresionDetalle Frm_GrupoImpresionDetalle = new Frm_GrupoImpresionDetalle();
                Frm_GrupoImpresionDetalle.StartPosition = FormStartPosition.CenterParent;
                Frm_GrupoImpresionDetalle.ShowDialog();
                coleccion = Mant_GrupoImpresionDataService.listartodos();
                dataGridView1.DataSource = coleccion;
            }catch(Exception ex)
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
                    Frm_GrupoImpresionDetalle Frm_GrupoImpresionDetalle = new Frm_GrupoImpresionDetalle(obtenerObjeto());
                    Frm_GrupoImpresionDetalle.StartPosition = FormStartPosition.CenterParent;
                    Frm_GrupoImpresionDetalle.ShowDialog();
                    coleccion = Mant_GrupoImpresionDataService.listartodos();
                    dataGridView1.DataSource = coleccion;
                }else
                {
                    MessageBox.Show("Debe selecionar una fila", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void toolCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            tooleditar.PerformClick();
        }

        private void txtbusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    dataGridView1.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                DataGridViewColumn ColumnaOrdenar = dataGridView1.Columns[e.ColumnIndex];
                if (dataGridView1.SortOrder == System.Windows.Forms.SortOrder.None)
                {
                    if (ColumnaOrdenar.Name == "grupoTipoImpresion_descripcion")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = coleccion.OrderBy(p => p.grupoTipoImpresion_descripcion).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dataGridView1.DataSource = coleccion.OrderBy(p => p.grupoTipoImpresion_descripcion).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "periodo_ID")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = coleccion.OrderBy(p => p.periodo_ID).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dataGridView1.DataSource = coleccion.OrderBy(p => p.periodo_ID).Reverse().ToList();
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
                coleccion = Mant_GrupoImpresionDataService.listartodos();
                Frm_Visor_Global frmVisor = new Frm_Visor_Global();
                frmVisor.reportViewer1.LocalReport.DataSources.Clear();
                frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._1_Tablas_Maestras.GrupoImpresion.rptGrupoImpresion.rdlc";
                frmVisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", coleccion));
                ReportParameter[] param = new ReportParameter[2];
                param[0] = new ReportParameter("Empresa", Globales.NombreEmpresa);
                param[1] = new ReportParameter("Usuario", Globales.UsuarioPrueba);
                frmVisor.reportViewer1.LocalReport.SetParameters(param);
                frmVisor.reportViewer1.RefreshReport();
                frmVisor.StartPosition = FormStartPosition.CenterParent;
                frmVisor.ShowDialog();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                coleccion = Mant_GrupoImpresionDataService.getColeccion("t.descripcion like '%" + txtbusqueda.Text + "%'", "t.descripcion");
                dataGridView1.DataSource = coleccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
