using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGR.Core.Service;
using SGR.Entity;
using WeifenLuo.WinFormsUI.Docking;
using SGR.WinApp.Layout._5_Reportes_Gestion;
using Microsoft.Reporting.WinForms;

namespace SGR.WinApp.Layout._2_Configuraciones.UnidadNegoci
{
    public partial class Frm_unidadNegocio : DockContent
    {
        private List<Conf_UnidadNegocio> Coleccion;
        Conf_UnidadNegocioDataService conf_UnidadNegocioDataService = new Conf_UnidadNegocioDataService();
        private System.Windows.Forms.SortOrder Orden = new System.Windows.Forms.SortOrder();
        public Frm_unidadNegocio()
        {
            InitializeComponent();
        }

        private void toolnuevo_Click(object sender, EventArgs e)
        {
            Frm_unidadNegocio_detalle Frm_unidadNegocio_detalle = new Frm_unidadNegocio_detalle();
            Frm_unidadNegocio_detalle.StartPosition = FormStartPosition.CenterParent;
            Frm_unidadNegocio_detalle.ShowDialog();
            Coleccion = conf_UnidadNegocioDataService.GetAllConf_UnidadNegocio();
            dataGridView1.DataSource = Coleccion;
        }

        private void tooleditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    Conf_UnidadNegocio cconf_UnidadNegocio = new Conf_UnidadNegocio();
                    cconf_UnidadNegocio = obtenerdatos();
                    Frm_unidadNegocio_detalle Frm_unidadNegocio_detalle = new Frm_unidadNegocio_detalle(cconf_UnidadNegocio);
                    Frm_unidadNegocio_detalle.StartPosition = FormStartPosition.CenterParent;
                    Frm_unidadNegocio_detalle.ShowDialog();
                    Coleccion = conf_UnidadNegocioDataService.GetAllConf_UnidadNegocio();
                    dataGridView1.DataSource = Coleccion;
                }
                else
                    MessageBox.Show("Seleccione un elemento", Globales.Global_MessageBox);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            } 
        }

        private Conf_UnidadNegocio obtenerdatos()
        {
            Conf_UnidadNegocio conf_UnidadNegocio = new Conf_UnidadNegocio();
            conf_UnidadNegocio.UnNec_iCodigo = (Int64)dataGridView1.SelectedRows[0].Cells["xcodigo"].Value;
            conf_UnidadNegocio.UnNec_vDescripcion = (string)dataGridView1.SelectedRows[0].Cells["xdescripcion"].Value;
            conf_UnidadNegocio.UnNegoc_bActivo = (bool)dataGridView1.SelectedRows[0].Cells["xestado"].Value;
            return conf_UnidadNegocio;
        }

        //private void tooleliminar_Click(object sender, EventArgs e)
        //{
        //    Int64 codigo;
        //    if ((bool)dataGridView1.SelectedRows[0].Cells["xestado"].Value)
        //    {
        //        if (MessageBox.Show("En verdad desea eliminar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //        {
                    
        //            codigo = (Int64)dataGridView1.SelectedRows[0].Cells["xcodigo"].Value;
        //            conf_UnidadNegocioDataService.DeleteByPrimaryKey(codigo);
        //            dataGridView1.DataSource = conf_UnidadNegocioDataService.GetAllConf_UnidadNegocio();
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("No puede eliminar un elemento eliminado");
        //    }
        //}

        private void Frm_unidadNegocio_Load(object sender, EventArgs e)
        {
            try
            {
                txtbusqueda.Focus();
                Coleccion = conf_UnidadNegocioDataService.GetAllConf_UnidadNegocio();
                dataGridView1.DataSource = Coleccion;

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

                    if (ColumnaOrdenar.Name == "xcodigo")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.UnNec_iCodigo).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.UnNec_iCodigo).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "xDescripcion")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.UnNec_vDescripcion).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.UnNec_vDescripcion).Reverse().ToList();
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
                Coleccion = conf_UnidadNegocioDataService.GetAllConf_UnidadNegocio();
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._2_Configuraciones.UnidadNegoci.Reporte_UnidadNegocio.rdlc";
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetUnidadNegocio", Coleccion));
                ReportParameter[] paramsx = new ReportParameter[2];
                paramsx[0] = new ReportParameter("NombreEmpresa",Globales.NombreEmpresa);
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
                dataGridView1.DataSource = conf_UnidadNegocioDataService.Getcoleccion("Descripcion like '%" + txtbusqueda.Text + "%'", "Descripcion");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void dataGridView1_DoubleClick_1(object sender, EventArgs e)
        {
            tooleditar.PerformClick();
        }        
    }    
}
