using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGR.Entity.Model;
using SGR.Entity;
using WeifenLuo.WinFormsUI.Docking;
using SGR.Core.Service;
using Microsoft.Reporting.WinForms;
using SGR.WinApp.Layout._5_Reportes_Gestion;

namespace SGR.WinApp.Layout._1_Tablas_Maestras.Oficina
{
    public partial class Frm_Oficina : DockContent
    {
        private List<Pago_Oficina> Coleccion;
        Pago_OficinaDataService Pago_OficinaDataService = new Pago_OficinaDataService();
        private System.Windows.Forms.SortOrder Orden = new System.Windows.Forms.SortOrder();
        public Frm_Oficina()
        {
            InitializeComponent();
        }

        private void toolnuevo_Click(object sender, EventArgs e)
        {
            Frm_Oficina_Detalle Frm_Oficina_Detalle = new Frm_Oficina_Detalle();
            Frm_Oficina_Detalle.StartPosition = FormStartPosition.CenterParent;
            Frm_Oficina_Detalle.ShowDialog();
            Coleccion = Pago_OficinaDataService.listartodos();
            dataGridView1.DataSource = Coleccion;
        }

        private void tooleditar_Click(object sender, EventArgs e)
        {
            Frm_Oficina_Detalle Frm_Oficina_Detalle = new Frm_Oficina_Detalle(obtenerdatos());
            Frm_Oficina_Detalle.StartPosition = FormStartPosition.CenterParent;
            Frm_Oficina_Detalle.ShowDialog();
            Coleccion = Pago_OficinaDataService.listartodos();
            dataGridView1.DataSource = Coleccion;
        }
        private Pago_Oficina obtenerdatos()
        {
            Pago_Oficina Pago_Oficina = new Pago_Oficina();
            Pago_Oficina.oficina_id = (Int32)dataGridView1.SelectedRows[0].Cells["xcodigo"].Value;
            Pago_Oficina.Descripcion = (string)dataGridView1.SelectedRows[0].Cells["xDescripcion"].Value;
            Pago_Oficina.Estado = (bool)dataGridView1.SelectedRows[0].Cells["xestado"].Value;
            return Pago_Oficina;
        
    }

        private void tooleliminar_Click(object sender, EventArgs e)
        {
            Int32 codigo;
            if ((bool)dataGridView1.SelectedRows[0].Cells["xestado"].Value)
            {
                if (MessageBox.Show("En verdad desea eliminar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    codigo = (Int32)dataGridView1.SelectedRows[0].Cells["xcodigo"].Value;
                    Pago_OficinaDataService.DeleteByPrimaryKey(codigo);
                    dataGridView1.DataSource = Pago_OficinaDataService.listartodos();
                }
            }
            else
            {
                MessageBox.Show("No puede eliminar un elemento eliminado");
            }
        }

        private void Frm_Oficina_Load(object sender, EventArgs e)
        {
            try
            {
                txtbusqueda.Focus();
                Coleccion = Pago_OficinaDataService.listartodos();
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

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                DataGridViewColumn ColumnaOrdenar = dataGridView1.Columns[e.ColumnIndex];

                if (dataGridView1.SortOrder == System.Windows.Forms.SortOrder.None)
                {

                    if (ColumnaOrdenar.Name == "xcodigo")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.oficina_id).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.oficina_id).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "xDescripcion")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.Descripcion).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.Descripcion).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }

                    }
                }

            }
        }

        private void toolStripBotonReporte_Click(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            Frm_Visor_Global frm_Visor_Global = new Frm_Visor_Global();
            try
            {
                Coleccion = Pago_OficinaDataService.listartodos();
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._1_Tablas_Maestras.Oficina.Reporte_Oficina.rdlc";
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetOficina", Coleccion));
                ReportParameter[] paramsx = new ReportParameter[2];
                paramsx[0] = new ReportParameter("NombreEmpresa", Globales.NombreEmpresa);
                paramsx[1] = new ReportParameter("UsuarioPrueba", GlobalesV1.Global_str_Usuario);
                frm_Visor_Global.reportViewer1.LocalReport.SetParameters(paramsx);
                frm_Visor_Global.reportViewer1.RefreshReport();
                frm_Visor_Global.StartPosition = FormStartPosition.CenterScreen;
                frm_Visor_Global.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
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
                dataGridView1.DataSource = Pago_OficinaDataService.Getcoleccion("Descripcion like '%" + txtbusqueda.Text + "%'", "Descripcion");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }
    }
}
