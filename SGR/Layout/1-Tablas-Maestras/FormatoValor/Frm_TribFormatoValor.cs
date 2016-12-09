using DgvFilterPopup;
using SGR.Core;
using SGR.Core.Service;
using System.Collections.Generic;
using System.Linq;
using SGR.Entity;
using System;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using SGR.WinApp.Layout._5_Reportes_Gestion;
using Microsoft.Reporting.WinForms;

namespace SGR.WinApp.Layout._1_Tablas_Maestras.FormatoValor
{
    public partial class Frm_TribFormatoValor : DockContent
    {
        private System.Windows.Forms.SortOrder Orden = new System.Windows.Forms.SortOrder();
        private List<Trib_FormatoValor> Coleccion;
        private  Trib_FormatoValorDataService  trib_FormatoValorDS= new Trib_FormatoValorDataService();
        public Frm_TribFormatoValor()
        {
            InitializeComponent();
        }
        private void Frm_TribFormatoValor_Load(object sender, EventArgs e)
        {
            try
            {
                txtbusqueda.Focus();
                Coleccion = trib_FormatoValorDS.listartodos();
                dataGridView1.DataSource = Coleccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }
        private void txtbusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Coleccion = trib_FormatoValorDS.Getcoleccion("fv.descripcion like '%" + txtbusqueda.Text + "%'", "descripcion");
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
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            tooleditar.PerformClick();
        }
        private void toolnuevo_Click(object sender, EventArgs e)
        {

            try
            {
                Trib_FormatoValorDetalle FrmFormatoDetalle = new Trib_FormatoValorDetalle();
                FrmFormatoDetalle.StartPosition = FormStartPosition.CenterParent;
                FrmFormatoDetalle.ShowDialog();
                Trib_FormatoValorDataService TribFormatoValor = new Trib_FormatoValorDataService();
                Coleccion = TribFormatoValor.listartodos();
                dataGridView1.DataSource = Coleccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void tooleditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null)
                    throw new Exception("Debe seleccionar una fila.");

                int codigo = (Int32)dataGridView1.SelectedRows[0].Cells["xcodigo"].Value;
                Trib_FormatoValorDetalle frm_FraccionamientoDetalle = new Trib_FormatoValorDetalle(trib_FormatoValorDS.GetByPrimaryKey(codigo));
                frm_FraccionamientoDetalle.StartPosition = FormStartPosition.CenterParent;
                frm_FraccionamientoDetalle.ShowDialog();
                Coleccion = trib_FormatoValorDS.listartodos();
                dataGridView1.DataSource = Coleccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                DataGridViewColumn ColumnaOrdenar = dataGridView1.Columns[e.ColumnIndex];

                if (dataGridView1.SortOrder == System.Windows.Forms.SortOrder.None)
                {

                    if (ColumnaOrdenar.Name == "xsysFecha")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.Valoc_vdescripcion).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.Valoc_vdescripcion).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "xusuario")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.Valoc_ianio).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.Valoc_ianio).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }

                    }
                    else if (ColumnaOrdenar.Name == "Column2")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.Valoc_vtipodocDec).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.Valoc_vtipodocDec).Reverse().ToList();
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
                Frm_Visor_Global frmVisor = new Frm_Visor_Global();
                Coleccion = trib_FormatoValorDS.listartodos();
                frmVisor.reportViewer1.LocalReport.DataSources.Clear();
                frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._1_Tablas_Maestras.FormatoValor.rptFormatoValores.rdlc";
                frmVisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", Coleccion));
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
        }

        private void dataGridView1_DoubleClick_1(object sender, EventArgs e)
        {
            tooleditar.PerformClick();
        }
    }
}
