using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGR.Core.Service;
using SGR.Entity.Model;
using WeifenLuo.WinFormsUI.Docking;
using Microsoft.Reporting.WinForms;
using SGR.WinApp.Layout._5_Reportes_Gestion;

namespace SGR.WinApp.Layout._1_Tablas_Maestras.Tributos
{
    public partial class Frm_tributos : DockContent
    {
        private Pred_TributoDataService Pred_TributoDataService = new Pred_TributoDataService();
        private List<Pred_Tributo> Coleccion;
        private System.Windows.Forms.SortOrder Orden = new System.Windows.Forms.SortOrder();
        public Frm_tributos()
        {
            InitializeComponent();
        }

        private void Frm_tributos_Load(object sender, EventArgs e)
        {
            try
            {
                llenarPeriodo();
                cboPeriodo.SelectedValue = 2013;
                txtbusqueda.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void llenarPeriodo()
        {
            try
            {
                cboPeriodo.DisplayMember = "Peric_canio";
                cboPeriodo.ValueMember = "Peric_canio";
                cboPeriodo.DataSource = Pred_TributoDataService.llenarPeriodo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private Pred_Tributo obtenerObjeto()
        {
            Pred_Tributo Pred_tributo = new Pred_Tributo();
            Pred_tributo.tributos_ID = (string)dataGridView1.SelectedRows[0].Cells["xtributo_ID"].Value;
            Pred_tributo.descripcion = (string)dataGridView1.SelectedRows[0].Cells["xdescripcion"].Value.ToString().TrimEnd();
            Pred_tributo.importe = (decimal)dataGridView1.SelectedRows[0].Cells["ximporte"].Value;
            Pred_tributo.activo = (bool)dataGridView1.SelectedRows[0].Cells["xactivo"].Value;
            Pred_tributo.abrev = (string)dataGridView1.SelectedRows[0].Cells["xabreviatura"].Value;
            Pred_tributo.tipo_tributo = (string)dataGridView1.SelectedRows[0].Cells["xtipo_tributo"].Value;
            Pred_tributo.porce_uit = (decimal)dataGridView1.SelectedRows[0].Cells["xporcentaje_UIT"].Value;
            Pred_tributo.clai_codigo = (string)dataGridView1.SelectedRows[0].Cells["xclasificacion_ingresos"].Value;
            Pred_tributo.cod_contable = (string)dataGridView1.SelectedRows[0].Cells["xcod_contable"].Value;
            Pred_tributo.are_codigo = (string)dataGridView1.SelectedRows[0].Cells["xarea_codigo"].Value;
            Pred_tributo.porce_area = (decimal)dataGridView1.SelectedRows[0].Cells["xporcentaje_area"].Value;
            Pred_tributo.fuente = (string)dataGridView1.SelectedRows[0].Cells["xfuente"].Value;
            Pred_tributo.cobro_interes = (Byte)dataGridView1.SelectedRows[0].Cells["xcobro_interes"].Value;
            return Pred_tributo;

        }
        private string obtenerID()
        {
            return (string)dataGridView1.SelectedRows[0].Cells["xtributo_ID"].Value;
        }
        private void toolnuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_tributos_detalle Frm_tributos_detalle = new Frm_tributos_detalle();
                Frm_tributos_detalle.StartPosition = FormStartPosition.CenterParent;
                Frm_tributos_detalle.ShowDialog();
                dataGridView1.DataSource = Pred_TributoDataService.listarTodos((Int32)cboPeriodo.SelectedValue);

            }catch(Exception ex)
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
                    Frm_tributos_detalle Frm_tributos_detalle = new Frm_tributos_detalle(obtenerObjeto(), (Int32)cboPeriodo.SelectedValue);
                    Frm_tributos_detalle.StartPosition = FormStartPosition.CenterParent;
                    Frm_tributos_detalle.ShowDialog();
                    if (txtbusqueda.Text.Trim().Length == 0)
                        dataGridView1.DataSource = Pred_TributoDataService.listarTodos((Int32)cboPeriodo.SelectedValue);
                    else
                        dataGridView1.DataSource = Pred_TributoDataService.getColeccion("Descripcion like '%" + txtbusqueda.Text + "%'", "Descripcion", cboPeriodo.SelectedValue.ToString());
                }
                else
                {
                    MessageBox.Show("Debe selecionar una fila", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //private void tooleliminar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (MessageBox.Show("Desean Eliminar?", Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //        {
        //            Pred_TributoDataService.deleteByPrimary(obtenerID());
        //            dataGridView1.DataSource = Coleccion;
        //        }
        //    }catch(Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, Globales.Global_MessageBox);
        //    }
        //}

        private void toolcancelar_Click(object sender, EventArgs e)
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
                dataGridView1.DataSource = Pred_TributoDataService.getColeccion("t.Descripcion like '%"+txtbusqueda.Text+"%'", "t.Descripcion",cboPeriodo.SelectedValue.ToString());
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    dataGridView1.Focus();
                }
                if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
                {
                    MessageBox.Show("Solo se permiten letras", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cboPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Coleccion = Pred_TributoDataService.listarTodos((Int32)cboPeriodo.SelectedValue);
            dataGridView1.DataSource = Coleccion;
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                DataGridViewColumn ColumnaOrdenar = dataGridView1.Columns[e.ColumnIndex];
                if(dataGridView1.SortOrder == System.Windows.Forms.SortOrder.None)
                {
                    if(ColumnaOrdenar.Name == "xdescripcion")
                    {
                        if(Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.descripcion).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.descripcion).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }else if (ColumnaOrdenar.Name == "xtipoDescripcion")
                    {
                        if(Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.tipo).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.tipo).Reverse().ToList();
                        }
                    }else if(ColumnaOrdenar.Name == "xporcentaje_UIT")
                    {
                        if(Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.porce_uit).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }else
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.porce_uit).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }else if(ColumnaOrdenar.Name == "xtipocl")
                    {
                        if(Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.tipocl).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }else
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.tipocl).Reverse().ToList();
                        }
                    }else if(ColumnaOrdenar.Name == "xporcentaje_area")
                    {
                        if(Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.porce_area).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }else
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.porce_area).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }else if(ColumnaOrdenar.Name == "areaTributo")
                    {
                        if(Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.area).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }else
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.area).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                    else if(ColumnaOrdenar.Name == "xcobro_intereses")
                    {
                        if(Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.cobro_interes).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }else
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.cobro_interes).Reverse().ToList();
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
                Coleccion = Pred_TributoDataService.listarTodos((Int32)cboPeriodo.SelectedValue);
                frmVisor.reportViewer1.LocalReport.DataSources.Clear();
                frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource= "SGR.WinApp.Layout._1_Tablas_Maestras.Tributos.rptTributo.rdlc";
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
    }
}