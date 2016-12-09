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
using Microsoft.Reporting.WinForms;
using SGR.WinApp.Layout._5_Reportes_Gestion;

namespace SGR.WinApp.Layout._1_Tablas_Maestras.Depreciaciones
{
    public partial class Frm_Depreciacion : DockContent
    {
        private Mant_DepreciacionDataService Mant_DepreciacionDataService = new Mant_DepreciacionDataService();
        private Conf_MultitablaDataService conf_MultitablaDataService = new Conf_MultitablaDataService();
        private List<Mant_Depreciacion> coleccion;
        private System.Windows.Forms.SortOrder Orden = new System.Windows.Forms.SortOrder();
        public Frm_Depreciacion()
        {
            InitializeComponent();
        }
        private Mant_Depreciacion obtenerObjeto()
        {
            try
            {
                Mant_Depreciacion Mant_Depreciacion = new Mant_Depreciacion();
                Mant_Depreciacion.depreciacion_ID = (Int32)dataGridView1.SelectedRows[0].Cells["xdepreciacion_ID"].Value;
                Mant_Depreciacion.anio = (Int16)dataGridView1.SelectedRows[0].Cells["xanio"].Value;
                Mant_Depreciacion.clasificacion = (Int16)dataGridView1.SelectedRows[0].Cells["xclasificacion_id"].Value;
                Mant_Depreciacion.antiguedad = (string)dataGridView1.SelectedRows[0].Cells["xantiguedad"].Value;
                Mant_Depreciacion.material = (Int16)dataGridView1.SelectedRows[0].Cells["xmaterial_id"].Value;
                Mant_Depreciacion.estado_piso = (Int16)dataGridView1.SelectedRows[0].Cells["xestadoPiso_id"].Value;
                Mant_Depreciacion.porcentaje = (decimal)dataGridView1.SelectedRows[0].Cells["xporcentaje"].Value;
                Mant_Depreciacion.estado = (bool)dataGridView1.SelectedRows[0].Cells["xestado"].Value;
                return Mant_Depreciacion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }
        //private int obtenerId()
        //{
        //    try
        //    {
        //        return (Int32)dataGridView1.SelectedRows[0].Cells["xdepreciacion_ID"].Value;
        //    }catch(Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, Globales.Global_MessageBox);
        //        return -1;
        //    }
        //}

        private void Frm_Depreciacion_Load(object sender, EventArgs e)
        {
            try
            {
                cboPeriodo.SelectedIndexChanged -= cboPeriodo_SelectedIndexChanged;
                cbo_clasificacion.SelectedIndexChanged -= cbo_clasificacion_SelectedIndexChanged;
                llenarComboPeriodo();
                llenarCboMultitabla(cbo_clasificacion, "Multc_vDescripcion", "Multc_cValor", "20");
                cboPeriodo.SelectedIndexChanged += cboPeriodo_SelectedIndexChanged;
                cbo_clasificacion.SelectedIndexChanged += cbo_clasificacion_SelectedIndexChanged;
                //coleccion = Mant_DepreciacionDataService.listartodo();
                coleccion = Mant_DepreciacionDataService.listarDepreciaciones(Convert.ToInt16(cboPeriodo.SelectedValue.ToString()), Convert.ToInt16(cbo_clasificacion.SelectedValue.ToString()));
                dataGridView1.DataSource = coleccion;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void llenarCboMultitabla(ComboBox cbo, String display, String valor, String tipo)
        {
            try
            {
                cbo.DisplayMember = display;
                cbo.ValueMember = valor;
                cbo.DataSource = conf_MultitablaDataService.GetCboConf_Multitabla(tipo);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void llenarComboPeriodo()
        {
            cboPeriodo.DisplayMember = "Peric_canio";
            cboPeriodo.ValueMember = "Peric_canio";
            cboPeriodo.DataSource = Mant_DepreciacionDataService.llenarPeriodo();
        }

     
        private void toolnuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_DepreciacionDetalle Frm_DepreciacionDetalle = new Frm_DepreciacionDetalle();
                Frm_DepreciacionDetalle.StartPosition = FormStartPosition.CenterParent;
                Frm_DepreciacionDetalle.ShowDialog();
                coleccion = Mant_DepreciacionDataService.listarDepreciaciones(Convert.ToInt16(cboPeriodo.SelectedValue.ToString()), Convert.ToInt16(cbo_clasificacion.SelectedValue.ToString()));
                dataGridView1.DataSource = coleccion; 
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
                    Frm_DepreciacionDetalle Frm_DepreciacionDetalle = new Frm_DepreciacionDetalle(obtenerObjeto());
                    Frm_DepreciacionDetalle.StartPosition = FormStartPosition.CenterParent;
                    Frm_DepreciacionDetalle.ShowDialog();
                    coleccion = Mant_DepreciacionDataService.listarDepreciaciones(Convert.ToInt16(cboPeriodo.SelectedValue.ToString()), Convert.ToInt16(cbo_clasificacion.SelectedValue.ToString()));
                    //coleccion = Mant_DepreciacionDataService.getColeccion("d.anio like '%" + cboPeriodo.SelectedValue.ToString() + "%'", "d.anio");
                    dataGridView1.DataSource = coleccion;
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
        //            Mant_DepreciacionDataService.deletebyid(obtenerId());
        //            coleccion = Mant_DepreciacionDataService.listartodo();
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

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                DataGridViewColumn ColumnaOrdenar = dataGridView1.Columns[e.ColumnIndex];
                if (dataGridView1.SortOrder == System.Windows.Forms.SortOrder.None)
                {
                    if (ColumnaOrdenar.Name == "xclasificacion")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = coleccion.OrderBy(p => p.clasificacion_descripcion).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dataGridView1.DataSource = coleccion.OrderBy(p => p.clasificacion_descripcion).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "xmaterial")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = coleccion.OrderBy(p => p.material_descripcion).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dataGridView1.DataSource = coleccion.OrderBy(p => p.material_descripcion).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }else if(ColumnaOrdenar.Name == "xestadoPiso")
                    {
                        if(Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = coleccion.OrderBy(p => p.estado_piso).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }else
                        {
                            dataGridView1.DataSource = coleccion.OrderBy(p => p.estado_piso).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                    else if(ColumnaOrdenar.Name == "xanio")
                    {
                        if(Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = coleccion.OrderBy(p => p.anio).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }else
                        {
                            dataGridView1.DataSource = coleccion.OrderBy(p => p.anio).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                    else if(ColumnaOrdenar.Name == "xantiguedad_descripcion")
                    {
                        if(Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = coleccion.OrderBy(p => p.antiguedad).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }else
                        {
                            dataGridView1.DataSource = coleccion.OrderBy(p => p.antiguedad).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                }
            }
        }

        private void txtbusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            coleccion = Mant_DepreciacionDataService.getColeccion("d.anio like '%" + cboPeriodo.SelectedValue.ToString() + "%'", "d.anio");
            dataGridView1.DataSource = coleccion;
            if (e.KeyValue == Convert.ToChar(Keys.Enter))
            {
                dataGridView1.Focus();
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
                coleccion = Mant_DepreciacionDataService.getColeccion("d.anio like '%" + cboPeriodo.SelectedValue.ToString() + "%'", "d.anio");
                frmVisor.reportViewer1.LocalReport.DataSources.Clear();
                frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._1_Tablas_Maestras.Depreciaciones.rptDepreciaciones.rdlc";
                frmVisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", coleccion));
                ReportParameter[] param = new ReportParameter[3];
                param[0] = new ReportParameter("Empresa", Globales.NombreEmpresa);
                param[1] = new ReportParameter("Usuario", Globales.UsuarioPrueba);
                param[2] = new ReportParameter("Anio", cboPeriodo.SelectedValue.ToString());
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

        private void cboPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkTodos.Checked)
                {
                    //coleccion = Mant_DepreciacionDataService.getColeccion("d.anio like '%" + cboPeriodo.SelectedValue.ToString() + "%'", "d.anio");
                    coleccion = Mant_DepreciacionDataService.listarTodasDepreciaciones(Convert.ToInt16(cboPeriodo.SelectedValue.ToString()));
                    dataGridView1.DataSource = coleccion;
                }
                else
                {
                    //coleccion = Mant_DepreciacionDataService.listartodoClasificacion((Int32)(cboPeriodo.SelectedValue), Convert.ToInt32(cbo_clasificacion.SelectedValue.ToString()));
                    coleccion = Mant_DepreciacionDataService.listarDepreciaciones(Convert.ToInt16(cboPeriodo.SelectedValue.ToString()), Convert.ToInt16(cbo_clasificacion.SelectedValue.ToString()));
                    dataGridView1.DataSource = coleccion;
                }

                //coleccion = Mant_DepreciacionDataService.listartodo();
                //dataGridView1.DataSource = coleccion;


            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbo_clasificacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkTodos.Checked)
                {
                    //coleccion = Mant_DepreciacionDataService.getColeccion("d.anio like '%" + cboPeriodo.SelectedValue.ToString() + "%'", "d.anio");
                    coleccion = Mant_DepreciacionDataService.listarTodasDepreciaciones(Convert.ToInt16(cboPeriodo.SelectedValue.ToString()));
                    dataGridView1.DataSource = coleccion;
                }
                else
                {
                    //int clas = Convert.ToInt32(cbo_clasificacion.SelectedValue.ToString());
                    //coleccion = Mant_DepreciacionDataService.listartodoClasificacion((Int32)(cboPeriodo.SelectedValue), clas);
                    Int16 clas = Convert.ToInt16(cbo_clasificacion.SelectedValue.ToString());
                    coleccion = Mant_DepreciacionDataService.listarDepreciaciones(Convert.ToInt16(cboPeriodo.SelectedValue.ToString()), clas);
                    dataGridView1.DataSource = coleccion;
                }

                //coleccion = Mant_DepreciacionDataService.listartodo();
                //dataGridView1.DataSource = coleccion;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                //coleccion = Mant_DepreciacionDataService.getColeccion("d.anio like '%" + cboPeriodo.SelectedValue.ToString() + "%'", "d.anio");
                coleccion = Mant_DepreciacionDataService.listarTodasDepreciaciones(Convert.ToInt16(cboPeriodo.SelectedValue.ToString()));
                dataGridView1.DataSource = coleccion;
            } else
            {
                //int clas = Convert.ToInt32(cbo_clasificacion.SelectedValue.ToString());
                //coleccion = Mant_DepreciacionDataService.listartodoClasificacion((Int32)(cboPeriodo.SelectedValue), clas);
                coleccion = Mant_DepreciacionDataService.listarDepreciaciones(Convert.ToInt16(cboPeriodo.SelectedValue.ToString()), Convert.ToInt16(cbo_clasificacion.SelectedValue.ToString()));
                dataGridView1.DataSource = coleccion;
            }
            
        }
    }
}
