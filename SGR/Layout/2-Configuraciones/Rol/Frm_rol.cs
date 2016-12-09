using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGR.Entity;
using SGR.Core.Service;
using WeifenLuo.WinFormsUI.Docking;
using SGR.WinApp.Layout._5_Reportes_Gestion;
using Microsoft.Reporting.WinForms;

namespace SGR.WinApp.Layout._2_Configuraciones.Rol
{
    public partial class Frm_rol : DockContent
    {
        private List<Conf_Rol> Coleccion;
        private System.Windows.Forms.SortOrder Orden = new System.Windows.Forms.SortOrder();
        Conf_RolDataService conf_RolDataService = new Conf_RolDataService();
        public Frm_rol()
        {
            InitializeComponent();
        }

        private void toolnuevo_Click(object sender, EventArgs e)
        {
            Frm_rol_detalle Frm_rol_detalle = new Frm_rol_detalle();
            Frm_rol_detalle.StartPosition = FormStartPosition.CenterParent;
            Frm_rol_detalle.ShowDialog();
            Conf_RolDataService conf_RolDataServicee = new Conf_RolDataService();
            dataGridView1.DataSource = conf_RolDataServicee.GetAllConf_Rol();
        }

        private void tooleditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    Frm_rol_detalle Frm_rol_detalle = new Frm_rol_detalle(obtenerdatos());
                    Frm_rol_detalle.StartPosition = FormStartPosition.CenterParent;
                    Frm_rol_detalle.ShowDialog();
                    Conf_RolDataService Conf_RolDataService = new Conf_RolDataService();
                    dataGridView1.DataSource = Conf_RolDataService.GetAllConf_Rol();
                }
                else
                    MessageBox.Show("Seleccione un elemento", Globales.Global_MessageBox);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
           
        }
        private Conf_Rol obtenerdatos()
        {
            Conf_Rol conf_Rol = new Conf_Rol();
            Conf_UnidadNegocio conf_UnNe = new Conf_UnidadNegocio();
            conf_Rol.Rolec_iCodigo = (Int64)dataGridView1.SelectedRows[0].Cells["xcodigo"].Value;
            conf_Rol.Rolec_vNombre = (string)dataGridView1.SelectedRows[0].Cells["xnombre"].Value;
            conf_Rol.Rolec_vDescripcion = (string)dataGridView1.SelectedRows[0].Cells["xDescripcion"].Value;
            conf_Rol.Rolec_bActivo = (bool)dataGridView1.SelectedRows[0].Cells["xestado"].Value;
            return conf_Rol;
        }


        private void tooleliminar_Click(object sender, EventArgs e)
        {
            if ((bool)dataGridView1.SelectedRows[0].Cells["xestado"].Value)
            {
                if (MessageBox.Show("En verdad desea eliminar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Conf_RolDataService Conf_RolDataService = new Conf_RolDataService();
                    Conf_RolDataService.DeleteByPrimaryKey((Int64)dataGridView1.SelectedRows[0].Cells["xcodigo"].Value);
                    dataGridView1.DataSource = Conf_RolDataService.GetAllConf_Rol();
                }
            }
            else
            {
                MessageBox.Show("No puede eliminar un elemento eliminado");
            }

        }

        private void Frm_rol_Load(object sender, EventArgs e)
        {
            try
            {
                txtbusqueda.Focus();
                Coleccion = conf_RolDataService.GetAllConf_Rol();
                dataGridView1.DataSource = Coleccion;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }
        
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            toolEditar.PerformClick();
        }

        private void txtbusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                dataGridView1.DataSource = conf_RolDataService.Getcoleccion("rol_nombre like '%" + txtbusqueda.Text + "%'", "rol_id");

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

                    if (ColumnaOrdenar.Name == "xnombre")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.Rolec_vNombre).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.Rolec_vNombre).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "xDescripcion")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.Rolec_vDescripcion).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.Rolec_vDescripcion).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }

                    }else if (ColumnaOrdenar.Name == "xcodigo")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.Rolec_iCodigo).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dataGridView1.DataSource = Coleccion.OrderBy(p => p.Rolec_iCodigo).Reverse().ToList();
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
                Coleccion = conf_RolDataService.GetAllConf_Rol();
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._2_Configuraciones.Rol.Reporte_Rol.rdlc";
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetRol", Coleccion));
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

        private void dataGridView1_DoubleClick_1(object sender, EventArgs e)
        {
            toolEditar.PerformClick();
        }
    }
}
