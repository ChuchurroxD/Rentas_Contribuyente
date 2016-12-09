using Microsoft.Reporting.WinForms;
using SGR.Core.Service;
using SGR.Entity.Model;
using SGR.WinApp.Layout._5_Reportes_Gestion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace SGR.WinApp.Layout._1_Tablas_Maestras.ValoresArbitrios
{
    public partial class Frm_ValoresArbitrios : DockContent
    {
        Mant_PeriodoDataService mant_PeriodoDataService = new Mant_PeriodoDataService();
        Mant_ValoresArbitriosDataService mant_ValoresArbitriosDataService = new Mant_ValoresArbitriosDataService();
        private List<Mant_ValoresArbitrios> Coleccion;
        private System.Windows.Forms.SortOrder Orden = new System.Windows.Forms.SortOrder();
        string usser = "";
        public Frm_ValoresArbitrios()
        {
            InitializeComponent();
            usser = GlobalesV1.Global_str_Usuario;
        }
        private void llenarPeriodo()
        {
            try
            {
                comboBusquedaPeriodo.DisplayMember = "Peric_canio";
                comboBusquedaPeriodo.ValueMember = "Peric_canio";
                comboBusquedaPeriodo.DataSource = mant_PeriodoDataService.llenarPeriodo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private Mant_ValoresArbitrios obtenerdatos()
        {
            Mant_ValoresArbitrios mant_ValoresArbitrios = new Mant_ValoresArbitrios();
            mant_ValoresArbitrios.idValoresArbitrio = (int)dgvListarValoresArbitrio.SelectedRows[0].Cells["xidValoresArbitrio"].Value;
            mant_ValoresArbitrios.idTablaArancel = (int)dgvListarValoresArbitrio.SelectedRows[0].Cells["xidTablaArancel"].Value;
            mant_ValoresArbitrios.descripcionTablaArancel = (string)dgvListarValoresArbitrio.SelectedRows[0].Cells["xdescripcionTablaArancel"].Value;
            mant_ValoresArbitrios.idPeriodo = (int)dgvListarValoresArbitrio.SelectedRows[0].Cells["xidPeriodo"].Value;
            mant_ValoresArbitrios.Costo = (decimal)dgvListarValoresArbitrio.SelectedRows[0].Cells["xCosto"].Value;
            mant_ValoresArbitrios.idCodificador = (string)dgvListarValoresArbitrio.SelectedRows[0].Cells["xidCodificador"].Value;
            mant_ValoresArbitrios.Rubro = (string)dgvListarValoresArbitrio.SelectedRows[0].Cells["xRubro"].Value;
            mant_ValoresArbitrios.Recurso = (string)dgvListarValoresArbitrio.SelectedRows[0].Cells["xRecurso"].Value;
            mant_ValoresArbitrios.Estado = (bool)dgvListarValoresArbitrio.SelectedRows[0].Cells["xEstado"].Value;
            return mant_ValoresArbitrios;
        }
        private void Frm_ValoresArbitrios_Load(object sender, EventArgs e)
        {
            try
            {
                llenarPeriodo();
                DateTime fechaHoy = DateTime.Now;
                comboBusquedaPeriodo.SelectedValue = Convert.ToInt32(fechaHoy.Year.ToString());
                Coleccion = mant_ValoresArbitriosDataService.listarTodos((Int32)comboBusquedaPeriodo.SelectedValue);
                dgvListarValoresArbitrio.DataSource = Coleccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void toolStripBotonNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_ValoresArbitrios_Detalle frm_ValoresArbitrios_Detalle = new Frm_ValoresArbitrios_Detalle();
                frm_ValoresArbitrios_Detalle.StartPosition = FormStartPosition.CenterParent;
                frm_ValoresArbitrios_Detalle.ShowDialog();
                Coleccion = mant_ValoresArbitriosDataService.listarTodos((Int32)comboBusquedaPeriodo.SelectedValue);
                dgvListarValoresArbitrio.DataSource = Coleccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void toolStripBotonModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_ValoresArbitrios_Detalle frm_ValoresArbitrios_Detalle = new Frm_ValoresArbitrios_Detalle(obtenerdatos());
                frm_ValoresArbitrios_Detalle.StartPosition = FormStartPosition.CenterParent;
                frm_ValoresArbitrios_Detalle.ShowDialog();
                Coleccion = mant_ValoresArbitriosDataService.listarTodos((Int32)comboBusquedaPeriodo.SelectedValue);
                dgvListarValoresArbitrio.DataSource = Coleccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
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
                Coleccion = mant_ValoresArbitriosDataService.listarTodos((Int32)comboBusquedaPeriodo.SelectedValue);
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._1_Tablas_Maestras.ValoresArbitrios.Reporte_ValoresArbitrios.rdlc";
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetValoresArbitrios", Coleccion));

                //INGRESAR LOGO EMPRESA - INICIO
                List<Frac_CuentaFraccionada> List_CuentaFraccionada = new List<Frac_CuentaFraccionada>();
                Frac_CuentaFraccionada frac_CuentaFraccionada = new Frac_CuentaFraccionada();
                String _path = Path.Combine(Application.StartupPath, @"LogoCabecera.jpg");
                frac_CuentaFraccionada.logoEmpresa = File.ReadAllBytes(_path);
                frac_CuentaFraccionada.convenio = "convenio";
                List_CuentaFraccionada.Add(frac_CuentaFraccionada);
                ReportDataSource reportDataSource = new ReportDataSource("DataSetLogoEmpresa", List_CuentaFraccionada);
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                //LOGO EMPRESA FIN

                ReportParameter[] paramsx = new ReportParameter[2];
                paramsx[0] = new ReportParameter("NombreEmpresa", Globales.NombreEmpresa);
                paramsx[1] = new ReportParameter("RucEmpresa",Globales.RucEmpresa);
                paramsx[2] = new ReportParameter("UsuarioPrueba",GlobalesV1.Global_str_Usuario);
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

        private void dgvListarValoresArbitrio_DoubleClick(object sender, EventArgs e)
        {
            toolStripBotonModificar.PerformClick();
        }

        private void comboBusquedaPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Coleccion = mant_ValoresArbitriosDataService.listarTodos((Int32)comboBusquedaPeriodo.SelectedValue);
            dgvListarValoresArbitrio.DataSource = Coleccion;
        }

        private void dgvListarValoresArbitrio_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                DataGridViewColumn ColumnaOrdenar = dgvListarValoresArbitrio.Columns[e.ColumnIndex];

                if (dgvListarValoresArbitrio.SortOrder == System.Windows.Forms.SortOrder.None)
                {

                    if (ColumnaOrdenar.Name == "xdescripcionTablaArancel")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgvListarValoresArbitrio.DataSource = Coleccion.OrderBy(p => p.descripcionTablaArancel).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgvListarValoresArbitrio.DataSource = Coleccion.OrderBy(p => p.descripcionTablaArancel).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "xCosto")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgvListarValoresArbitrio.DataSource = Coleccion.OrderBy(p => p.Costo).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgvListarValoresArbitrio.DataSource = Coleccion.OrderBy(p => p.Costo).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (mant_ValoresArbitriosDataService.ExisteElementosPeriodoAnterior(8) != 0)
                {
                    MessageBox.Show("Ya hay registros en este periodo", Globales.Global_MessageBox);
                    return;
                }

                if (mant_ValoresArbitriosDataService.ExisteElementosPeriodoAnterior(9) == 0)
                {
                    MessageBox.Show("No hay registros para copiar", Globales.Global_MessageBox);
                }
                else
                {
                    if (MessageBox.Show("Desea Copiar datos de periodo anterior?", Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        mant_ValoresArbitriosDataService.CopiarElementosPeriodoAnterior(usser);
                        MessageBox.Show("Se copió correctamente los valores de arbitrios del periodo anterior a este periodo", Globales.Global_MessageBox);
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
