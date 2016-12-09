using Microsoft.Reporting.WinForms;
using SGR.Core.Service;
using SGR.Entity.Model;
using SGR.WinApp.Layout._5_Reportes_Gestion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace SGR.WinApp.Layout._1_Tablas_Maestras.ArancelRustico
{
    public partial class Frm_Arancel_Rustico : DockContent
    {
        Mant_ArancelRusticoDataService mant_ArancelRusticoDataService = new Mant_ArancelRusticoDataService();
        Mant_ArancelDataService mant_ArancelDataService = new Mant_ArancelDataService();
        Mant_PeriodoDataService mant_PeriodoDataService = new Mant_PeriodoDataService();
        private List<Mant_ArancelRustico> Coleccion;
        private System.Windows.Forms.SortOrder Orden = new System.Windows.Forms.SortOrder();
        string usser = "";

        public Frm_Arancel_Rustico()
        {
            InitializeComponent();
            usser = GlobalesV1.Global_str_Usuario;
        }

        private void Frm_Arancel_Rustico_Load(object sender, EventArgs e)
        {
            try
            {
                
                DateTime fechaHoy = DateTime.Now;
                llenarcomboPeriodo();
                
                comboPeriodoBusqueda.SelectedValue = Convert.ToInt32(fechaHoy.Year.ToString());
                Coleccion = mant_ArancelRusticoDataService.listarTodos((Int32)comboPeriodoBusqueda.SelectedValue);
                dgvListarArancelRustico.DataSource = Coleccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_AranceRustico_Detalle frm_AranceRustico_Detalle = new Frm_AranceRustico_Detalle();
                frm_AranceRustico_Detalle.StartPosition = FormStartPosition.CenterParent;
                frm_AranceRustico_Detalle.ShowDialog();
                Coleccion = mant_ArancelRusticoDataService.listarTodos((Int32)comboPeriodoBusqueda.SelectedValue);
                dgvListarArancelRustico.DataSource = Coleccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void dgvListarArancelRustico_DoubleClick(object sender, EventArgs e)
        {
            toolStripBotonModificar.PerformClick();
        }

        private Mant_ArancelRustico obtenerdatos()
        {
            Mant_ArancelRustico mant_ArancelRustico = new Mant_ArancelRustico();
            mant_ArancelRustico.ArancelRustico_id = (int)dgvListarArancelRustico.SelectedRows[0].Cells["xarancelRustico_id"].Value;
            mant_ArancelRustico.idPeriodo = (int)dgvListarArancelRustico.SelectedRows[0].Cells["xidPeriodo"].Value;
            mant_ArancelRustico.ValorRustico = (decimal)dgvListarArancelRustico.SelectedRows[0].Cells["xValorRustico"].Value;
            mant_ArancelRustico.idGrupoRustico = (int)dgvListarArancelRustico.SelectedRows[0].Cells["xidGrupoRustico"].Value;
            mant_ArancelRustico.GrupoRusticoDescripcion = (string)dgvListarArancelRustico.SelectedRows[0].Cells["xGrupoRusticoDescripcion"].Value;
            mant_ArancelRustico.Categoria_Rustico= (int)dgvListarArancelRustico.SelectedRows[0].Cells["xCategoria_Rustico"].Value;
            mant_ArancelRustico.Categoria_RusticoDescripcion = (string)dgvListarArancelRustico.SelectedRows[0].Cells["xCategoria_RusticoDescripcion"].Value;
            mant_ArancelRustico.activo = (bool)dgvListarArancelRustico.SelectedRows[0].Cells["xactivo"].Value;
            return mant_ArancelRustico;
        }
        private int obtenerId()
        {
            return (Int32)dgvListarArancelRustico.SelectedRows[0].Cells["arancelRusticoid"].Value;
        }
        private void llenarcomboPeriodo()
        {
            try
            {
                comboPeriodoBusqueda.DisplayMember = "Peric_canio";
                comboPeriodoBusqueda.ValueMember = "Peric_canio";
                comboPeriodoBusqueda.DataSource = mant_PeriodoDataService.llenarPeriodo();
                comboPeriodoBusqueda.SelectedValue = 2016;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void toolStripBotonModificar_Click(object sender, EventArgs e)
        {
            Frm_AranceRustico_Detalle frm_AranceRustico_Detalle = new Frm_AranceRustico_Detalle(obtenerdatos());
            frm_AranceRustico_Detalle.StartPosition = FormStartPosition.CenterParent;
            frm_AranceRustico_Detalle.ShowDialog();
            Coleccion = mant_ArancelRusticoDataService.listarTodos((Int32)comboPeriodoBusqueda.SelectedValue);
            dgvListarArancelRustico.DataSource = Coleccion;
        }

        private void comboPeriodoBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            Coleccion = mant_ArancelRusticoDataService.listarTodos((Int32)comboPeriodoBusqueda.SelectedValue);
            dgvListarArancelRustico.DataSource = Coleccion;
        }

        private void toolStripBotonReporte_Click(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            Frm_Visor_Global frm_Visor_Global = new Frm_Visor_Global();
            try
            {
                Coleccion = mant_ArancelRusticoDataService.listarTodos((Int32)comboPeriodoBusqueda.SelectedValue);
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._1_Tablas_Maestras.ArancelRustico.Reporte_ArancelRustico.rdlc";
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetArancelRustico", Coleccion));
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

        private void dgvListarArancelRustico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvListarArancelRustico_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                DataGridViewColumn ColumnaOrdenar = dgvListarArancelRustico.Columns[e.ColumnIndex];

                if (dgvListarArancelRustico.SortOrder == System.Windows.Forms.SortOrder.None)
                {

                    if (ColumnaOrdenar.Name == "xCategoria_RusticoDescripcion")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgvListarArancelRustico.DataSource = Coleccion.OrderBy(p => p.Categoria_RusticoDescripcion).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgvListarArancelRustico.DataSource = Coleccion.OrderBy(p => p.Categoria_RusticoDescripcion).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "xValorRustico")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgvListarArancelRustico.DataSource = Coleccion.OrderBy(p => p.ValorRustico).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgvListarArancelRustico.DataSource = Coleccion.OrderBy(p => p.ValorRustico).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }

                    }
                    else if (ColumnaOrdenar.Name == "xGrupoRusticoDescripcion")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgvListarArancelRustico.DataSource = Coleccion.OrderBy(p => p.GrupoRusticoDescripcion).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgvListarArancelRustico.DataSource = Coleccion.OrderBy(p => p.GrupoRusticoDescripcion).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }

                    }
                }

            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (mant_ArancelRusticoDataService.ExisteElementosPeriodoAnterior(14) != 0)
                {
                    MessageBox.Show("Ya hay registros en este periodo", Globales.Global_MessageBox);
                    return;
                }

                if (mant_ArancelRusticoDataService.ExisteElementosPeriodoAnterior(15) == 0)
                {
                    MessageBox.Show("No hay registros para copiar", Globales.Global_MessageBox);
                }
                else
                {
                    if (MessageBox.Show("Desea Copiar datos de periodo anterior?", Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        mant_ArancelRusticoDataService.CopiarElementosPeriodoAnterior(usser);
                        MessageBox.Show("Se copió correctamente los aranceles del periodo anterior a este periodo", Globales.Global_MessageBox);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }
    }
}
