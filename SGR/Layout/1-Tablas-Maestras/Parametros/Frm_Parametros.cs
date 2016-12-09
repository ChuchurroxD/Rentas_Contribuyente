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
using SGR.WinApp.Layout._5_Reportes_Gestion;
using Microsoft.Reporting.WinForms;

namespace SGR.WinApp.Layout._1_Tablas_Maestras.Parametros
{
    public partial class Frm_Parametros : DockContent
    {
        Mant_ParametrosDataService Mant_ParametrosDataService = new Mant_ParametrosDataService();
        List<Mant_Parametros> coleccion = new List<Mant_Parametros>();
        private System.Windows.Forms.SortOrder Orden = new System.Windows.Forms.SortOrder();
        public Frm_Parametros()
        {
            InitializeComponent();
        }
        private Mant_Parametros obtenerObjeto()
        {
            try
            {
                Mant_Parametros Mant_Parametros = new Mant_Parametros();
                Mant_Parametros.parametros_ID = (Int32)dataGridView1.SelectedRows[0].Cells["parametros_ID"].Value;
                Mant_Parametros.codigo = (Int32)dataGridView1.SelectedRows[0].Cells["codigo"].Value;
                Mant_Parametros.anio = (Int32)dataGridView1.SelectedRows[0].Cells["anio"].Value;
                Mant_Parametros.descripcion = (string)dataGridView1.SelectedRows[0].Cells["descripcion"].Value;
                Mant_Parametros.valor = (decimal)dataGridView1.SelectedRows[0].Cells["valor"].Value;
                Mant_Parametros.valor1 = (Int32)dataGridView1.SelectedRows[0].Cells["valor1"].Value;
                Mant_Parametros.estado = (bool)dataGridView1.SelectedRows[0].Cells["estado"].Value;
                Mant_Parametros.registro_fecha_add = (DateTime)dataGridView1.SelectedRows[0].Cells["registro_fecha_add"].Value;
                Mant_Parametros.registro_pc_add = (string)dataGridView1.SelectedRows[0].Cells["registro_pc_add"].Value;
                Mant_Parametros.registro_user_add = (string)dataGridView1.SelectedRows[0].Cells["registro_user_add"].Value;
                Mant_Parametros.registro_fecha_update = (DateTime)dataGridView1.SelectedRows[0].Cells["registro_fecha_update"].Value;
                Mant_Parametros.registro_pc_update = (string)dataGridView1.SelectedRows[0].Cells["registro_pc_update"].Value;
                Mant_Parametros.registro_user_update = (string)dataGridView1.SelectedRows[0].Cells["registro_user_update"].Value;
                return Mant_Parametros;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }

        private void Frm_Parametros_Load(object sender, EventArgs e)
        {
            try
            {
                listarComboPeriodo();
                txtDescripcion.Focus();
                coleccion = Mant_ParametrosDataService.listartodos(Convert.ToInt32(cboPeriodo.SelectedValue));
                dataGridView1.DataSource = coleccion;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void listarComboPeriodo()
        {
            cboPeriodo.DisplayMember = "Peric_canio";
            cboPeriodo.ValueMember = "Peric_canio";
            cboPeriodo.DataSource = Mant_ParametrosDataService.llenarComboPeriodo();
        }
        private void toolNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_ParametroDetalle Frm_ParametroDetalle = new Frm_ParametroDetalle(Convert.ToInt32(cboPeriodo.SelectedValue));
                Frm_ParametroDetalle.StartPosition = FormStartPosition.CenterParent;
                Frm_ParametroDetalle.ShowDialog();
                coleccion = Mant_ParametrosDataService.listartodos(Convert.ToInt32(cboPeriodo.SelectedValue));
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
                    Frm_ParametroDetalle Frm_ParametrosDetalle = new Frm_ParametroDetalle(obtenerObjeto());
                    Frm_ParametrosDetalle.StartPosition = FormStartPosition.CenterParent;
                    Frm_ParametrosDetalle.ShowDialog();
                    coleccion = Mant_ParametrosDataService.listartodos(Convert.ToInt32(cboPeriodo.SelectedValue));
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

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            coleccion = Mant_ParametrosDataService.getColeccion("descripcion like '%" + txtDescripcion.Text + "%'", "",Convert.ToInt32(cboPeriodo.SelectedValue));
            dataGridView1.DataSource = coleccion;
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
                if (dataGridView1.SortOrder == System.Windows.Forms.SortOrder.None)
                {
                    if (ColumnaOrdenar.Name == "descripcion")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = coleccion.OrderBy(p => p.descripcion).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dataGridView1.DataSource = coleccion.OrderBy(p => p.descripcion).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "anio")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = coleccion.OrderBy(p => p.anio).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dataGridView1.DataSource = coleccion.OrderBy(p => p.anio).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                }
            }
        }

        private void cboPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            coleccion = Mant_ParametrosDataService.listartodos(Convert.ToInt32(cboPeriodo.SelectedValue));
            dataGridView1.DataSource = coleccion;
        }

        private void toolImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cursor.Current == Cursors.WaitCursor)
                    return;
                Cursor.Current = Cursors.WaitCursor;
                coleccion = Mant_ParametrosDataService.listartodos(Convert.ToInt32(cboPeriodo.SelectedValue));
                Frm_Visor_Global frmVisor = new Frm_Visor_Global();
                frmVisor.reportViewer1.LocalReport.DataSources.Clear();
                frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._1_Tablas_Maestras.Parametros.rptParametros.rdlc";
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
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }

        }
    }
}
