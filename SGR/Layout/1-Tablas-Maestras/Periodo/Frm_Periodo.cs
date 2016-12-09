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
using SGR.WinApp.Layout._5_Reportes_Gestion;
using Microsoft.Reporting.WinForms;

namespace SGR.WinApp.Layout._1_Tablas_Maestras.Periodo
{
    public partial class Frm_Periodo : DockContent
    {
        private List<Mant_Periodo> Coleccion;
        private System.Windows.Forms.SortOrder Orden = new System.Windows.Forms.SortOrder();
        private Mant_PeriodoDataService Mant_PeriodoDataService = new Mant_PeriodoDataService();
        public Frm_Periodo()
        {
            InitializeComponent();
        }

        private void toolnuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_Periodo_Detalle Frm_Periodo_Detalle = new Frm_Periodo_Detalle();
                Frm_Periodo_Detalle.StartPosition = FormStartPosition.CenterParent;
                Frm_Periodo_Detalle.ShowDialog();
                Coleccion = Mant_PeriodoDataService.GetAllMant_Periodo();
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
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    Frm_Periodo_Detalle Frm_Periodo_Detalle = new Frm_Periodo_Detalle(obtenerdatos());
                    Frm_Periodo_Detalle.StartPosition = FormStartPosition.CenterParent;
                    Frm_Periodo_Detalle.ShowDialog();
                    dataGridView1.DataSource = Mant_PeriodoDataService.GetAllMant_Periodo();
                    if (txtbusqueda.Text.Trim().Length == 0)
                    {
                        Coleccion = Mant_PeriodoDataService.GetAllMant_Periodo();
                        dataGridView1.DataSource = Coleccion;
                    }
                    else
                        dataGridView1.DataSource = Mant_PeriodoDataService.Getcoleccion("año like '%" + txtbusqueda.Text + "%'", "Descripcion");
                }
                else
                    MessageBox.Show("Seleccione un elemento", Globales.Global_MessageBox);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }

        }
        private Mant_Periodo obtenerdatos()
        {
            Mant_Periodo Mant_Periodo = new Mant_Periodo();
            Mant_Periodo.Peric_canio = (Int32)dataGridView1.SelectedRows[0].Cells["xcanio"].Value;
            Mant_Periodo.Peric_vdescripcion = (string)dataGridView1.SelectedRows[0].Cells["xDescripcion"].Value;
            Mant_Periodo.Peric_euit = (decimal)dataGridView1.SelectedRows[0].Cells["xUIT"].Value;
            Mant_Periodo.Peric_iuitAlcabala = (int)dataGridView1.SelectedRows[0].Cells["xUitAlcabala"].Value;
            Mant_Periodo.Peric_nmoraAlcaba = (decimal)dataGridView1.SelectedRows[0].Cells["xmoraAlcabala"].Value;
            Mant_Periodo.Peric_ntasaAlcabala = (decimal)dataGridView1.SelectedRows[0].Cells["xTasaAlcabala"].Value;
            Mant_Periodo.Interes = (decimal)dataGridView1.SelectedRows[0].Cells["Interes"].Value;
            Mant_Periodo.FactorOficilizacion = (decimal)dataGridView1.SelectedRows[0].Cells["FactorOficilizacion"].Value;
            Mant_Periodo.MinimoPredio = (decimal)dataGridView1.SelectedRows[0].Cells["MinimoPredio"].Value;
            Mant_Periodo.TopeUITPension = (decimal)dataGridView1.SelectedRows[0].Cells["TopeUITPension"].Value;
            Mant_Periodo.Formulario = (decimal)dataGridView1.SelectedRows[0].Cells["Formulario"].Value;
            Mant_Periodo.Peric_bactivo = (bool)dataGridView1.SelectedRows[0].Cells["xestado"].Value;
            return Mant_Periodo;
        }


        private void tooleliminar_Click(object sender, EventArgs e)
        {
            if ((bool)dataGridView1.SelectedRows[0].Cells["xestado"].Value)
            {
                if (MessageBox.Show("En verdad desea eliminar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string codigo = (string)dataGridView1.SelectedRows[0].Cells["xcanio"].Value;
                    Mant_PeriodoDataService.DeleteByPrimaryKey(codigo);
                    dataGridView1.DataSource = Mant_PeriodoDataService.GetAllMant_Periodo();
                }
            }
            else
            {
                MessageBox.Show("No puede eliminar un elemento eliminado");
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            tooleditar.PerformClick();

        }

        private void Frm_Periodo_Load(object sender, EventArgs e)
        {
            try
            {
                txtbusqueda.Focus();
                Coleccion = Mant_PeriodoDataService.GetAllMant_Periodo();
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

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                DataGridViewColumn ColumnaOrdenar = dataGridView1.Columns[e.ColumnIndex];

                if (dataGridView1.SortOrder == System.Windows.Forms.SortOrder.None)
                {

                    if (ColumnaOrdenar.Name == "xcanio")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.Peric_canio).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.Peric_canio).Reverse().ToList();
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
                Coleccion = Mant_PeriodoDataService.GetAllMant_Periodo();
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._1_Tablas_Maestras.Periodo.Reporte_Periodo.rdlc";
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetPeriodo", Coleccion));
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tooleditar.PerformClick();
        }
    }
}
