using DgvFilterPopup;
using SGR.Core.Service;
using SGR.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.Linq;
using SGR.WinApp.Layout._5_Reportes_Gestion;
using Microsoft.Reporting.WinForms;

namespace SGR.WinApp.Layout._1_Tablas_Maestras.Cajero
{
    public partial class Frm_Cajero : DockContent
    {
        private Pago_CajeroDataService pago_Cajero = new Pago_CajeroDataService();
        private System.Windows.Forms.SortOrder Orden = new System.Windows.Forms.SortOrder();
        private List<Pago_Cajero> Coleccion;
        public Frm_Cajero()
        {
            InitializeComponent();
            Coleccion = pago_Cajero.listartodos();
            dataGridView1.DataSource = Coleccion;
        }
        private void txtbusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                dataGridView1.Focus();
            }
        }
        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Coleccion = pago_Cajero.Getcoleccion(" p.NombreCompleto like '%" + txtbusqueda.Text + "%'", null);
                dataGridView1.DataSource = Coleccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }
        private void toolnuevo_Click_1(object sender, EventArgs e)
        {
            try
            {
                Frm_CajeroDetalle frm_cajero_detalle = new Frm_CajeroDetalle();
                frm_cajero_detalle.StartPosition = FormStartPosition.CenterParent;
                frm_cajero_detalle.ShowDialog();
                Coleccion = pago_Cajero.Getcoleccion(" p.NombreCompleto like '%" + txtbusqueda.Text + "%'", null);
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
                string codigo = (string)dataGridView1.SelectedRows[0].Cells["xpersona"].Value;
                Frm_CajeroDetalle frm_CajeroDet = new Frm_CajeroDetalle(pago_Cajero.GetByPrimaryKey(codigo));
                frm_CajeroDet.StartPosition = FormStartPosition.CenterParent;
                frm_CajeroDet.ShowDialog();
                Coleccion = pago_Cajero.Getcoleccion(" p.NombreCompleto like '%" + txtbusqueda.Text + "%'", null); ;
                dataGridView1.DataSource = Coleccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar el registro");
            }
        }
        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                DataGridViewColumn ColumnaOrdenar = dataGridView1.Columns[e.ColumnIndex];

                if (dataGridView1.SortOrder == System.Windows.Forms.SortOrder.None)
                {

                    if (ColumnaOrdenar.Name == "Column6")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.persona_desc).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.persona_desc).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "xcodigo")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.FechaInicio).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.FechaInicio).Reverse().ToList();
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
                Coleccion = pago_Cajero.listartodos();
                frmVisor.reportViewer1.LocalReport.DataSources.Clear();
                frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._1_Tablas_Maestras.Cajero.rptCajero.rdlc";
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

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            tooleditar.PerformClick();
        }
    }
}
