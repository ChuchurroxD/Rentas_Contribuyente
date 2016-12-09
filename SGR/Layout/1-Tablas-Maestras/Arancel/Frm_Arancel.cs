using SGR.Core.Service;
using SGR.Entity.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using Microsoft.Reporting.WinForms;
using SGR.WinApp.Layout._5_Reportes_Gestion;

namespace SGR.WinApp.Layout._1_Tablas_Maestras.Arancel
{
    public partial class Frm_Arancel : DockContent
    {

        Mant_ArancelDataService mant_ArancelDataService = new Mant_ArancelDataService();
        Mant_PeriodoDataService mant_PeriodoDataService = new Mant_PeriodoDataService();
        Pred_SectorDataService pred_SectorDataService = new Pred_SectorDataService();
        Pred_ViasDataService pred_ViasDataService = new Pred_ViasDataService();
        private List<Mant_Arancel> Coleccion;
        private System.Windows.Forms.SortOrder Orden = new System.Windows.Forms.SortOrder();
        string usser = "";
        public Frm_Arancel()
        {
            InitializeComponent();
            this.comboBusquedaSector.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.comboBusquedaSector.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.comboBusquedaCalle.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.comboBusquedaCalle.AutoCompleteSource = AutoCompleteSource.CustomSource;
            usser = GlobalesV1.Global_str_Usuario;

        }
        private void llenarcomboPeriodo()
        {
            try
            {
                comboBusquedaAnio.DisplayMember = "Peric_canio";
                comboBusquedaAnio.ValueMember = "Peric_canio";
                comboBusquedaAnio.DataSource = mant_PeriodoDataService.llenarPeriodo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void llenarcomboSector()
        {
            try
            {
                comboBusquedaSector.ValueMember = "sector_id";
                comboBusquedaSector.DisplayMember = "descripcion";
                comboBusquedaSector.DataSource = pred_SectorDataService.listarSectorCbo();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void llenarComboVia()
        {
            try
            {
                comboBusquedaCalle.ValueMember = "Via_Id";
                comboBusquedaCalle.DisplayMember = "Descripcion";
                comboBusquedaCalle.DataSource = pred_ViasDataService.listarViasPorSector(comboBusquedaSector.SelectedValue.ToString(), GlobalesV1.Global_int_idoficina);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_Arancel_Detalle frm_Arancel_Detalle = new Frm_Arancel_Detalle();
                frm_Arancel_Detalle.StartPosition = FormStartPosition.CenterParent;
                frm_Arancel_Detalle.ShowDialog();
                Coleccion = mant_ArancelDataService.listarTodosPorSectorAñoVia((Int32)comboBusquedaAnio.SelectedValue, (Int32)comboBusquedaSector.SelectedValue, comboBusquedaCalle.SelectedValue.ToString());
                dgvListarArancel.DataSource = Coleccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void toolEditar_Click(object sender, EventArgs e)
        {
            Frm_Arancel_Detalle frm_Arancel_Detalle = new Frm_Arancel_Detalle(obtenerdatos());
            frm_Arancel_Detalle.StartPosition = FormStartPosition.CenterParent;
            frm_Arancel_Detalle.ShowDialog();
            Coleccion = mant_ArancelDataService.listarTodosPorSectorAñoVia((Int32)comboBusquedaAnio.SelectedValue, (Int32)comboBusquedaSector.SelectedValue, comboBusquedaCalle.SelectedValue.ToString());
            dgvListarArancel.DataSource = Coleccion;
        }

        private Mant_Arancel obtenerdatos()
        {
            Mant_Arancel mant_Arancel = new Mant_Arancel();
            mant_Arancel.arancel_ID = (int)dgvListarArancel.SelectedRows[0].Cells["xarancel_ID"].Value;
            mant_Arancel.anio = (int)dgvListarArancel.SelectedRows[0].Cells["xanio"].Value;
            mant_Arancel.arancel_monto = (decimal)dgvListarArancel.SelectedRows[0].Cells["xarancel_monto"].Value;
            mant_Arancel.junta_via_ID = (int)dgvListarArancel.SelectedRows[0].Cells["xjunta_via_ID"].Value;
            mant_Arancel.cuadra = (int)dgvListarArancel.SelectedRows[0].Cells["xcuadra"].Value;
            mant_Arancel.lado = (int)dgvListarArancel.SelectedRows[0].Cells["xlado"].Value;
            mant_Arancel.Sector_id = (int)dgvListarArancel.SelectedRows[0].Cells["xSector_id"].Value;
            mant_Arancel.SectorDescripcion = (string)dgvListarArancel.SelectedRows[0].Cells["xSectorDescripcion"].Value;
            mant_Arancel.Via_id = (string)dgvListarArancel.SelectedRows[0].Cells["xVia_id"].Value;
            mant_Arancel.ViaDescripcion = (string)dgvListarArancel.SelectedRows[0].Cells["xViaDescripcion"].Value;
            mant_Arancel.activo = (bool)dgvListarArancel.SelectedRows[0].Cells["xactivo"].Value;
            return mant_Arancel;
        }

        private void toolEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desean Eliminar?", Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                mant_ArancelDataService.deletebyprimarykey(obtenerId());
                Coleccion = mant_ArancelDataService.listarTodos((Int32)comboBusquedaAnio.SelectedValue);
                dgvListarArancel.DataSource = Coleccion;
            }
        }

        private int obtenerId()
        {
            return (Int32)dgvListarArancel.SelectedRows[0].Cells["xarancel_ID"].Value;
        }

        private void toolSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Frm_Arancel_Load(object sender, EventArgs e)
        {
            try
            {
                llenarcomboPeriodo();
                llenarcomboSector();
                llenarComboVia();
                DateTime fechaHoy = DateTime.Now;
                comboBusquedaAnio.SelectedValue = Convert.ToInt32(fechaHoy.Year.ToString());
                Coleccion = mant_ArancelDataService.listarTodosPorSectorAñoVia((Int32)comboBusquedaAnio.SelectedValue, (Int32)comboBusquedaSector.SelectedValue, comboBusquedaCalle.SelectedValue.ToString());
                dgvListarArancel.DataSource = Coleccion;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
            
        }

        private void dgvListarArancel_DoubleClick_1(object sender, EventArgs e)
        {
            toolEditar.PerformClick();
        }

        private void comboBusquedaAnio_SelectedIndexChanged(object sender, EventArgs e)
        {
            botonListar.PerformClick();
        }

        private void comboBusquedaAnio_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton5_Click_1(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            Frm_Visor_Global frm_Visor_Global = new Frm_Visor_Global();
            try
            {
                Coleccion = mant_ArancelDataService.listarTodos((Int32)comboBusquedaAnio.SelectedValue);
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._1_Tablas_Maestras.Arancel.rptArancel.rdlc";
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetArancel", Coleccion));
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

        private void groupBusqueda_Enter(object sender, EventArgs e)
        {

        }

        private void dgvListarArancel_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dgvListarArancel_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                DataGridViewColumn ColumnaOrdenar = dgvListarArancel.Columns[e.ColumnIndex];

                if (dgvListarArancel.SortOrder == System.Windows.Forms.SortOrder.None)
                {

                    if (ColumnaOrdenar.Name == "xarancel_monto")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgvListarArancel.DataSource = Coleccion.OrderBy(p => p.arancel_monto).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgvListarArancel.DataSource = Coleccion.OrderBy(p => p.arancel_monto).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "xcuadra")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgvListarArancel.DataSource = Coleccion.OrderBy(p => p.cuadra).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgvListarArancel.DataSource = Coleccion.OrderBy(p => p.cuadra).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }

                    }
                    else if (ColumnaOrdenar.Name == "xlado")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgvListarArancel.DataSource = Coleccion.OrderBy(p => p.lado).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgvListarArancel.DataSource = Coleccion.OrderBy(p => p.lado).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }

                    }
                    else if (ColumnaOrdenar.Name == "xSectorDescripcion")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgvListarArancel.DataSource = Coleccion.OrderBy(p => p.SectorDescripcion).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgvListarArancel.DataSource = Coleccion.OrderBy(p => p.SectorDescripcion).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }

                    }
                    else if (ColumnaOrdenar.Name == "xViaDescripcion")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgvListarArancel.DataSource = Coleccion.OrderBy(p => p.ViaDescripcion).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgvListarArancel.DataSource = Coleccion.OrderBy(p => p.ViaDescripcion).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }

                    }
                }

            }
        }

        private void comboBusquedaSector_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarComboVia();
            botonListar.PerformClick();
            //Coleccion = mant_ArancelDataService.listarTodosPorSector((Int32)comboBusquedaSector.SelectedValue, (Int32)comboBusquedaAnio.SelectedValue);
            //dgvListarArancel.DataSource = Coleccion;
        }

        private void botonListar_Click(object sender, EventArgs e)
        {
            try
            {
                if(comboBusquedaAnio.SelectedIndex==-1 || comboBusquedaSector.SelectedIndex == -1 || comboBusquedaCalle.SelectedIndex == -1)
                {
                    return;
                }
                Coleccion = mant_ArancelDataService.listarTodosPorSectorAñoVia((Int32)comboBusquedaAnio.SelectedValue, (Int32)comboBusquedaSector.SelectedValue, comboBusquedaCalle.SelectedValue.ToString());
                dgvListarArancel.DataSource = Coleccion;
            }
            catch (Exception ex)
            {
            }
        }

        private void comboBusquedaCalle_SelectedIndexChanged(object sender, EventArgs e)
        {
            botonListar.PerformClick();
            //Coleccion = mant_ArancelDataService.listarTodosPorVia(comboBusquedaCalle.SelectedValue.ToString(), (Int32)comboBusquedaAnio.SelectedValue);
            //dgvListarArancel.DataSource = Coleccion;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            try
            {
                if (mant_ArancelDataService.ExisteElementosPeriodoAnterior(14) != 0)
                {
                    MessageBox.Show("Ya hay registros en este periodo", Globales.Global_MessageBox);
                    return;
                }

                if (mant_ArancelDataService.ExisteElementosPeriodoAnterior(15) == 0)
                {
                    MessageBox.Show("No hay registros para copiar", Globales.Global_MessageBox);
                }
                else
                {
                    if (MessageBox.Show("Desea Copiar datos de periodo anterior?", Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        mant_ArancelDataService.CopiarElementosPeriodoAnterior(usser);
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
