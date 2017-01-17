using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGR.Entity.Model;
using SGR.Core.Service;
using WeifenLuo.WinFormsUI.Docking;
using SGR.WinApp.Layout._5_Reportes_Gestion;
using Microsoft.Reporting.WinForms;

namespace SGR.WinApp.Layout._4_Procesos.Predio.Adeudo
{
    public partial class Frm_Alcabala_Listado : Form
    {
        private Pred_Certificado_AlcabalaDataService Certificado_AlcabalaDataService = new Pred_Certificado_AlcabalaDataService();
        Mant_PeriodoDataService mant_PeriodoDataService = new Mant_PeriodoDataService();
        private List<Pred_Certificado_Alcabala> Coleccion;
        private System.Windows.Forms.SortOrder Orden = new System.Windows.Forms.SortOrder();
        public Frm_Alcabala_Listado()
        {
            try
            {
                InitializeComponent();
                comboBusquedaAnio.DisplayMember = "Peric_canio";
                comboBusquedaAnio.ValueMember = "Peric_canio";
                comboBusquedaAnio.DataSource = mant_PeriodoDataService.llenarPeriodo();
                DateTime fechaHoy = DateTime.Now;
                comboBusquedaAnio.SelectedValue = Convert.ToInt32(fechaHoy.Year.ToString());
                Coleccion = Certificado_AlcabalaDataService.listartodos((Int32)comboBusquedaAnio.SelectedValue, "", "","T");
                dgvAlcabalListado.DataSource = Coleccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }

        }

        private void comboBusquedaAnio_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                btnBuscar.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void dgvAlcabalListado_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                DataGridViewColumn ColumnaOrdenar = dgvAlcabalListado.Columns[e.ColumnIndex];

                if (dgvAlcabalListado.SortOrder == System.Windows.Forms.SortOrder.None)
                {

                    if (ColumnaOrdenar.Name == "adquisicion_descripcion")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgvAlcabalListado.DataSource = Coleccion.OrderBy(p => p.adquisicion_descripcion).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgvAlcabalListado.DataSource = Coleccion.OrderBy(p => p.adquisicion_descripcion).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "comprador_name")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgvAlcabalListado.DataSource = Coleccion.OrderBy(p => p.comprador_name).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgvAlcabalListado.DataSource = Coleccion.OrderBy(p => p.comprador_name).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }

                    }
                    else if (ColumnaOrdenar.Name == "direccion_completa")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgvAlcabalListado.DataSource = Coleccion.OrderBy(p => p.direccion_completa).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgvAlcabalListado.DataSource = Coleccion.OrderBy(p => p.direccion_completa).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }

                    }
                    else if (ColumnaOrdenar.Name == "fecha_tramite")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgvAlcabalListado.DataSource = Coleccion.OrderBy(p => p.fecha_tramite).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgvAlcabalListado.DataSource = Coleccion.OrderBy(p => p.fecha_tramite).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }

                    }
                    else if (ColumnaOrdenar.Name == "posesion_descripcion")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgvAlcabalListado.DataSource = Coleccion.OrderBy(p => p.posesion_descripcion).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgvAlcabalListado.DataSource = Coleccion.OrderBy(p => p.posesion_descripcion).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }

                    }
                    else if (ColumnaOrdenar.Name == "predio_id")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgvAlcabalListado.DataSource = Coleccion.OrderBy(p => p.predio_id).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgvAlcabalListado.DataSource = Coleccion.OrderBy(p => p.predio_id).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }

                    }
                    else if (ColumnaOrdenar.Name == "vendedor_name")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgvAlcabalListado.DataSource = Coleccion.OrderBy(p => p.vendedor_name).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgvAlcabalListado.DataSource = Coleccion.OrderBy(p => p.vendedor_name).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }

                    }
                    else if (ColumnaOrdenar.Name == "vendedor_name")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgvAlcabalListado.DataSource = Coleccion.OrderBy(p => p.vendedor_name).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgvAlcabalListado.DataSource = Coleccion.OrderBy(p => p.vendedor_name).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }

                    }
                    else if (ColumnaOrdenar.Name == "certalcabala_id")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgvAlcabalListado.DataSource = Coleccion.OrderBy(p => p.certalcabala_id).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgvAlcabalListado.DataSource = Coleccion.OrderBy(p => p.certalcabala_id).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }

                    }
                    //
                }

            }
        }

        private Pred_Certificado_Alcabala obtenerdatos()
        {
            Pred_Certificado_Alcabala Certificado_Alcabala = new Pred_Certificado_Alcabala();
            //Certificado_Alcabala.base_imponible = (int)dgvAlcabalListado.SelectedRows[0].Cells["base_imponible"].Value;
            Certificado_Alcabala.certalcabala_id = (int)dgvAlcabalListado.SelectedRows[0].Cells["certalcabala_id"].Value;
            Certificado_Alcabala.alcabala = (decimal)dgvAlcabalListado.SelectedRows[0].Cells["alcabala"].Value;
            Certificado_Alcabala.valor_afecto = (decimal)dgvAlcabalListado.SelectedRows[0].Cells["valor_afecto"].Value;
            Certificado_Alcabala.valuo = (decimal)dgvAlcabalListado.SelectedRows[0].Cells["valuo"].Value;
            Certificado_Alcabala.tasaAlcabala = (decimal)dgvAlcabalListado.SelectedRows[0].Cells["tasaAlcabala"].Value;
            Certificado_Alcabala.uits = (decimal)dgvAlcabalListado.SelectedRows[0].Cells["uits"].Value;
            Certificado_Alcabala.direccion_completa = (string)dgvAlcabalListado.SelectedRows[0].Cells["direccion_completa"].Value;
            Certificado_Alcabala.predio_id = (string)dgvAlcabalListado.SelectedRows[0].Cells["predio_id"].Value;
            Certificado_Alcabala.condomino = (decimal)dgvAlcabalListado.SelectedRows[0].Cells["condomino"].Value;
            Certificado_Alcabala.fecha_tramite = (DateTime)dgvAlcabalListado.SelectedRows[0].Cells["fecha_tramite"].Value;
            Certificado_Alcabala.adquisicion_descripcion = (string)dgvAlcabalListado.SelectedRows[0].Cells["adquisicion_descripcion"].Value;
            Certificado_Alcabala.posesion_descripcion = (string)dgvAlcabalListado.SelectedRows[0].Cells["posesion_descripcion"].Value;
            Certificado_Alcabala.valor_venta = (decimal)dgvAlcabalListado.SelectedRows[0].Cells["valor_venta"].Value;
            Certificado_Alcabala.anioGeneracion = (int)dgvAlcabalListado.SelectedRows[0].Cells["anioGeneracion"].Value;
            Certificado_Alcabala.vendedor_name = (string)dgvAlcabalListado.SelectedRows[0].Cells["vendedor_name"].Value;
            Certificado_Alcabala.comprador_name = (string)dgvAlcabalListado.SelectedRows[0].Cells["comprador_name"].Value;
            Certificado_Alcabala.estado = (bool)dgvAlcabalListado.SelectedRows[0].Cells["estado"].Value;
            return Certificado_Alcabala;
        }

        private void dgvAlcabalListado_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Frm_Alcabala frm_Alcabala = new Frm_Alcabala(obtenerdatos());
                frm_Alcabala.StartPosition = FormStartPosition.CenterParent;
                frm_Alcabala.ShowDialog();
            }
            catch (Exception ex)
            {

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                String FILTRO = "";
                    if (rbtTodos.Checked)
                    FILTRO = "T";
                if (rbtAnulados.Checked)
                    FILTRO = "A";
                if (rbtCancelados.Checked)
                    FILTRO = "C";
                if (rbtPendiente.Checked)
                    FILTRO = "P";
                if (comboBusquedaAnio.SelectedIndex != -1)
                {
                    Coleccion = Certificado_AlcabalaDataService.listartodos((Int32)comboBusquedaAnio.SelectedValue, txtVendedor.Text.TrimEnd(), txtComprador.Text.TrimEnd(),FILTRO);
                    dgvAlcabalListado.DataSource = Coleccion;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void txtComprador_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    btnBuscar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void txtVendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    btnBuscar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void toolDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgvAlcabalListado.SelectedRows.Count<0)
                {
                    MessageBox.Show("No seleccionó alcabala", Globales.Global_MessageBox);
                    return;
                }
                bool estado = (bool)dgvAlcabalListado.SelectedRows[0].Cells["estado"].Value;
                if(!estado)
                {
                    MessageBox.Show("Ya esta eliminado", Globales.Global_MessageBox);
                    return;
                }
                if (MessageBox.Show("Desea Eliminar?", Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idAlcabala = (int)dgvAlcabalListado.SelectedRows[0].Cells["certalcabala_id"].Value;
                   string msj= Certificado_AlcabalaDataService.Eliminar(idAlcabala);
                    MessageBox.Show(msj, Globales.Global_MessageBox);
                    btnBuscar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            Frm_Visor_Global frm_Visor_Global = new Frm_Visor_Global();
            try
            {
                string tipoAl = "";
                if (rbtAnulados.Checked)
                    tipoAl = "Anulados";
                else if (rbtCancelados.Checked)
                    tipoAl = "Cancelados";
                else if (rbtPendiente.Checked)
                    tipoAl = "Pendientes de Pago";
                else tipoAl = "Todos";
                
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._5_Reportes_Gestion.Rep_Alcabala.AlcabalaCobCanc.rdlc";
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", Coleccion));
                ReportParameter[] paramsx = new ReportParameter[5];
                paramsx[0] = new ReportParameter("Anio",comboBusquedaAnio.SelectedValue.ToString());
                paramsx[1] = new ReportParameter("TipoAlcabala", tipoAl);
                paramsx[2] = new ReportParameter("Comprador", txtComprador.Text.TrimEnd());
                paramsx[3] = new ReportParameter("Vendedor", txtVendedor.Text.TrimEnd());
                paramsx[4] = new ReportParameter("Usuario", GlobalesV1.Global_str_Nombre);
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

        private void dgvAlcabalListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
