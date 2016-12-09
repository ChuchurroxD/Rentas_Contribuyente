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

namespace SGR.WinApp.Layout._2_Configuraciones
{
    
    public partial class Frm_tablas : DockContent
    {
        private List<Conf_Multitabla> Coleccion;
        Conf_MultitablaDataService conf_MultitablaDataService = new Conf_MultitablaDataService();
        private System.Windows.Forms.SortOrder Orden = new System.Windows.Forms.SortOrder();
        private Conf_Multitabla conf_Multitabla;
        public Frm_tablas()
        {
            InitializeComponent();
        }

        private void toolnuevo_Click(object sender, EventArgs e)
        {
            if (conf_Multitabla == null)
            {
                Frm_tablas_detalle Frm_tablas_detalle = new Frm_tablas_detalle(conf_Multitabla, 1);
                Frm_tablas_detalle.StartPosition = FormStartPosition.CenterParent;
                Frm_tablas_detalle.ShowDialog();
                Conf_MultitablaDataService Conf_MultitablaDataService = new Conf_MultitablaDataService();
                Coleccion = Conf_MultitablaDataService.GetAllConf_Multitabla("0");
                dataGridView1.DataSource= Coleccion;
            }
            else
            {
                Frm_tablas_detalle Frm_tablas_detalle = new Frm_tablas_detalle(conf_Multitabla, 2);
                Frm_tablas_detalle.StartPosition = FormStartPosition.CenterParent;
                Frm_tablas_detalle.ShowDialog();
                Conf_MultitablaDataService Conf_MultitablaDataService = new Conf_MultitablaDataService();
                Coleccion = Conf_MultitablaDataService.GetAllConf_Multitabla(conf_Multitabla.Multc_cValor);
                dataGridView1.DataSource = Coleccion;
            }
        }

        private void tooleliminar_Click(object sender, EventArgs e)
        {
            Int64 codigo;
            if ((bool)dataGridView1.SelectedRows[0].Cells["xestado"].Value)
            {
                if (MessageBox.Show("En verdad desea eliminar?", Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Conf_MultitablaDataService conf_MultitablaDataService = new Conf_MultitablaDataService();
                    codigo = (Int64)dataGridView1.SelectedRows[0].Cells["xcodigo"].Value;
                    conf_MultitablaDataService.DeleteByPrimaryKey(codigo);
                    if (conf_Multitabla == null)
                    {
                        Coleccion = conf_MultitablaDataService.GetAllConf_Multitabla("0");
                        dataGridView1.DataSource = Coleccion;
                    }
                    else
                    {
                        Coleccion = conf_MultitablaDataService.GetAllConf_Multitabla(conf_Multitabla.Multc_cValor);
                        dataGridView1.DataSource = Coleccion;
                    }

                }
            }
            else
            {
                MessageBox.Show("No puede eliminar un elemento eliminado");
            }
        }

        private void tooleditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    if (conf_Multitabla == null)
                    {
                        Frm_tablas_detalle Frm_tablas_detalle = new Frm_tablas_detalle(obtenerdatos(), 3);
                        Frm_tablas_detalle.StartPosition = FormStartPosition.CenterParent;
                        Frm_tablas_detalle.ShowDialog();
                        Conf_MultitablaDataService Conf_MultitablaDataService = new Conf_MultitablaDataService();
                        Coleccion = Conf_MultitablaDataService.GetAllConf_Multitabla("0");
                        dataGridView1.DataSource = Coleccion;
                    }
                    else
                    {
                        Frm_tablas_detalle Frm_tablas_detalle = new Frm_tablas_detalle(obtenerdatos(), 4);
                        Frm_tablas_detalle.StartPosition = FormStartPosition.CenterParent;
                        Frm_tablas_detalle.ShowDialog();
                        Conf_MultitablaDataService Conf_MultitablaDataService = new Conf_MultitablaDataService();
                        Coleccion = Conf_MultitablaDataService.GetAllConf_Multitabla(conf_Multitabla.Multc_cValor);
                        dataGridView1.DataSource = Coleccion;
                    }
                }
                else
                    MessageBox.Show("Seleccione un elemento", Globales.Global_MessageBox);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
           
        }

        private void Frm_tablas_Load(object sender, EventArgs e)
        {
            if (conf_Multitabla == null)
            {
                Conf_MultitablaDataService Conf_MultitablaDataService = new Conf_MultitablaDataService();
                Coleccion = Conf_MultitablaDataService.GetAllConf_Multitabla("0");
                dataGridView1.DataSource = Coleccion;
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (conf_Multitabla == null)
                cargarHijos();
        }
        public Frm_tablas(Conf_Multitabla conf_Multitabla)
        {
            InitializeComponent();
            this.conf_Multitabla = conf_Multitabla;
            Conf_MultitablaDataService Conf_MultitablaDataService = new Conf_MultitablaDataService();
            Coleccion = Conf_MultitablaDataService.GetAllConf_Multitabla(conf_Multitabla.Multc_cValor);
            dataGridView1.DataSource = Coleccion;
        }
        private void cargarHijos()
        {

            Frm_tablas frm_tablas = new Frm_tablas(obtenerdatos());
            frm_tablas.StartPosition = FormStartPosition.CenterParent;
            frm_tablas.ShowDialog();
            //Segu_UsuarioDataService Segu_UsuarioDataService = new Segu_UsuarioDataService();
            //dataGridView1.DataSource = Segu_UsuarioDataService.GetAllSegu_Usuarios();
        }
        private Conf_Multitabla obtenerdatos()
        {
            Conf_Multitabla conf_Multitabla = new Conf_Multitabla();
            conf_Multitabla.Multc_iCodigo = (Int64)dataGridView1.SelectedRows[0].Cells["xcodigo"].Value;
            conf_Multitabla.Multc_vDescripcion = (string)dataGridView1.SelectedRows[0].Cells["xdescripcion"].Value;
            conf_Multitabla.Multc_vAbreviatura = (string)dataGridView1.SelectedRows[0].Cells["xabreviatura"].Value;
            conf_Multitabla.Multc_bEstado = (bool)dataGridView1.SelectedRows[0].Cells["xestado"].Value;
            conf_Multitabla.Multc_cValor = (string)dataGridView1.SelectedRows[0].Cells["valor"].Value;
            conf_Multitabla.Multc_cDependencia = (string)dataGridView1.SelectedRows[0].Cells["Dependencia"].Value;
            //conf_Multitabla.Multc_cDependencia = "0";
            return conf_Multitabla;
        }

        private void txtbusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                dataGridView1.Focus();
            }
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try {
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    DataGridViewColumn ColumnaOrdenar = dataGridView1.Columns[e.ColumnIndex];

                    if (dataGridView1.SortOrder == System.Windows.Forms.SortOrder.None)
                    {

                        if (ColumnaOrdenar.Name == "Valor")
                        {
                            //    Conf_Multitabla conf_Multitabla = new Conf_Multitabla();
                            //    conf_Multitabla.Multc_iCodigo = (Int64)dataGridView1.SelectedRows[0].Cells["xcodigo"].Value;
                            //    conf_Multitabla.Multc_vDescripcion = (string)dataGridView1.SelectedRows[0].Cells["xdescripcion"].Value;
                            //    conf_Multitabla.Multc_vAbreviatura = (string)dataGridView1.SelectedRows[0].Cells["xabreviatura"].Value;
                            //    conf_Multitabla.Multc_bEstado = (bool)dataGridView1.SelectedRows[0].Cells["xestado"].Value;
                            //    conf_Multitabla.Multc_cValor = (string)dataGridView1.SelectedRows[0].Cells["valor"].Value;
                            //    conf_Multitabla.Multc_cDependencia = (string)dataGridView1.SelectedRows[0].Cells["Dependencia"].Value;
                            if (Orden == System.Windows.Forms.SortOrder.Descending)
                            {
                                dataGridView1.DataSource = Coleccion.OrderBy(p => p.Multc_cValor).ToList();
                                Orden = System.Windows.Forms.SortOrder.Ascending;
                            }
                            else
                            {
                                dataGridView1.DataSource = Coleccion.OrderBy(p => p.Multc_cValor).Reverse().ToList();
                                Orden = System.Windows.Forms.SortOrder.Descending;
                            }
                        }
                        else if (ColumnaOrdenar.Name == "xdescripcion")
                        {
                            if (Orden == System.Windows.Forms.SortOrder.Descending)
                            {
                                dataGridView1.DataSource = Coleccion.OrderBy(p => p.Multc_vDescripcion).ToList();
                                Orden = System.Windows.Forms.SortOrder.Ascending;
                            }
                            else
                            {
                                dataGridView1.DataSource = Coleccion.OrderBy(p => p.Multc_vDescripcion).Reverse().ToList();
                                Orden = System.Windows.Forms.SortOrder.Descending;
                            }
                        }
                    }

                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
           
        }

        private void toolStripBotonReporte_Click(object sender, EventArgs e)
        {
            string padre;
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            Frm_Visor_Global frm_Visor_Global = new Frm_Visor_Global();
            try
            {
                if (conf_Multitabla == null)
                {
                    padre = "Reporte de Padres";
                    Conf_MultitablaDataService conf_MultitablaDataService1 = new Conf_MultitablaDataService();
                    Coleccion = conf_MultitablaDataService1.GetAllConf_Multitabla(txtbusqueda.Text.ToString());
                }
                else
                {
                    padre = "Reporte de " + conf_Multitabla.Multc_vDescripcion.ToLower();
                    Coleccion = conf_MultitablaDataService.GetAllConf_Multitabla(conf_Multitabla.Multc_cValor);
                }
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._2_Configuraciones.Multitabla.Reporte_Multitabla.rdlc";
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetMultitabla", Coleccion));
                ReportParameter[] paramsx = new ReportParameter[3];
                paramsx[0] = new ReportParameter("NombreEmpresa", Globales.NombreEmpresa);
                paramsx[1] = new ReportParameter("UsuarioPrueba", GlobalesV1.Global_str_Usuario);
                paramsx[2] = new ReportParameter("Padre", padre);
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
                Conf_MultitablaDataService cconf_MultitablaDataService = new Conf_MultitablaDataService();
                if (conf_Multitabla == null)
                {
                    Coleccion = cconf_MultitablaDataService.Getcoleccion("Descripcion like '%" + txtbusqueda.Text + "%' and  dep_id is null ", "Descripcion");
                    dataGridView1.DataSource = Coleccion;
                }
                else
                {
                    Coleccion = cconf_MultitablaDataService.Getcoleccion("Descripcion like '%" + txtbusqueda.Text + "%' and  dep_id='" + conf_Multitabla.Multc_cValor + "' ", "Descripcion");
                    dataGridView1.DataSource = Coleccion;
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }
    }
    
}
