using DgvFilterPopup;
using SGR.Core;
using SGR.Core.Service;
using SGR.Entity;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using SGR.WinApp.Layout._5_Reportes_Gestion;
using Microsoft.Reporting.WinForms;

namespace SGR.WinApp.Layout._1_Tablas_Maestras.CuadroValores
{
    public partial class Frm_CuadroValores : DockContent
    {
        private Mant_CuadroValoresDataService mant_cuadrovalroes = new Mant_CuadroValoresDataService();
        private Mant_PeriodoDataService periodos = new Mant_PeriodoDataService();

        private System.Windows.Forms.SortOrder Orden = new System.Windows.Forms.SortOrder();
        private List<Mant_CuadroValores> Coleccion;
        string usser = "";
        public Frm_CuadroValores()
        {
            InitializeComponent();
            //dataGridView1.DataSource = trib_TipoFraccionamiento.Getcoleccion("base_legal like '%" + txtbusqueda.Text + "%'", "base_legal");
            cboPeriodo.DisplayMember = "Peric_canio";
            cboPeriodo.ValueMember = "Peric_canio";
            cboPeriodo.DataSource = periodos.GetAllMant_Periodo();
            Coleccion= mant_cuadrovalroes.Getcoleccion(" anio=" + Convert.ToString(cboPeriodo.SelectedValue), null);
            dataGridView1.DataSource = Coleccion;
            usser = GlobalesV1.Global_str_Usuario;
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
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.codigoDesc).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.codigoDesc).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "xserie")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.serie).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.serie).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }

                    }
                    else if (ColumnaOrdenar.Name == "xdescripcion")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.descripcion).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.descripcion).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "xmonto")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.monto).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.monto).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "xanio")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.anio).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.anio).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                }

            }
        }

        private void cboPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Coleccion= mant_cuadrovalroes.Getcoleccion(" anio=" + Convert.ToString(cboPeriodo.SelectedValue), null);
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
                Coleccion= mant_cuadrovalroes.Getcoleccion(" anio=" + Convert.ToString(cboPeriodo.SelectedValue) +
                    " and cv.descripcion like '%" + txtbusqueda.Text + "%'", null);
                dataGridView1.DataSource = Coleccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void toolnuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_CuadroValoresDetalle frm_cuadrovaloresdetalle = new Frm_CuadroValoresDetalle();
                frm_cuadrovaloresdetalle.StartPosition = FormStartPosition.CenterParent;
                frm_cuadrovaloresdetalle.ShowDialog();
                Coleccion= mant_cuadrovalroes.Getcoleccion(" anio=" + Convert.ToString(cboPeriodo.SelectedValue) +
                    " and cv.descripcion like '%" + txtbusqueda.Text + "%'", null);
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
                int codigo = (Int32)dataGridView1.SelectedRows[0].Cells["xcuadrovalores"].Value;
                Frm_CuadroValoresDetalle frm_cuadrovaloredetalle = new Frm_CuadroValoresDetalle(mant_cuadrovalroes.GetByPrimaryKey(codigo));
                frm_cuadrovaloredetalle.StartPosition = FormStartPosition.CenterParent;
                frm_cuadrovaloredetalle.ShowDialog();
                Coleccion= mant_cuadrovalroes.Getcoleccion(" anio=" + Convert.ToString(cboPeriodo.SelectedValue) +
                        " and cv.descripcion like '%" + txtbusqueda.Text + "%'", null);
                dataGridView1.DataSource = Coleccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar el registro", Globales.Global_MessageBox);
            }
        }

        private void tooleliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = (Int32)dataGridView1.SelectedRows[0].Cells["xcuadrovalores"].Value;
                mant_cuadrovalroes.DeleteByPrimaryKey(codigo);
                MessageBox.Show("Registro correctamente anulado", Globales.Global_MessageBox);
                Coleccion= mant_cuadrovalroes.Getcoleccion(" anio=" + Convert.ToString(cboPeriodo.SelectedValue) +
                    " and cv.descripcion like '%" + txtbusqueda.Text + "%'", null);
                dataGridView1.DataSource = Coleccion;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al anular el registro", Globales.Global_MessageBox);
            }
        }
        private void CambiarPosicion(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["xestado"].Value) > 0)
                    tooleliminar.Enabled = true;
                else
                    tooleliminar.Enabled = false;
            }
            catch (Exception ex)
            {

            }
        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            tooleditar.PerformClick();
        }

        private void toolImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cursor.Current == Cursors.WaitCursor)
                    return;
                Cursor.Current = Cursors.WaitCursor;
                Frm_Visor_Global frmVisor = new Frm_Visor_Global();
                Coleccion = mant_cuadrovalroes.Getcoleccion(" anio=" + Convert.ToString(cboPeriodo.SelectedValue), null);
                frmVisor.reportViewer1.LocalReport.DataSources.Clear();
                frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._1_Tablas_Maestras.CuadroValores.rptCuadroValores.rdlc";
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (mant_cuadrovalroes.ExisteElementosPeriodoAnterior(10) != 0)
                {
                    MessageBox.Show("Ya hay registros en este periodo", Globales.Global_MessageBox);
                    return;
                }

                if (mant_cuadrovalroes.ExisteElementosPeriodoAnterior(11) == 0)
                {
                    MessageBox.Show("No hay registros para copiar", Globales.Global_MessageBox);
                }
                else
                {
                    if (MessageBox.Show("Desea Copiar datos de periodo anterior?", Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        mant_cuadrovalroes.CopiarElementosPeriodoAnterior(usser);
                        MessageBox.Show("Se copió correctamente los valores de unitarios del periodo anterior a este periodo", Globales.Global_MessageBox);
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
