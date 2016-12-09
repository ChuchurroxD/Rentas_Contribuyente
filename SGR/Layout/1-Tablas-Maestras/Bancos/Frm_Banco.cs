using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using SGR.Core.Service;
using SGR.Entity.Model;
using SGR.WinApp.Layout._5_Reportes_Gestion;
using Microsoft.Reporting.WinForms;

namespace SGR.WinApp.Layout._1_Tablas_Maestras.Bancos
{
    public partial class Frm_Banco : DockContent
    {
        private Mant_BancoDataService Mant_BancoDataService = new Mant_BancoDataService();
        private List<Mant_Banco> coleccion = new List<Mant_Banco>();
        private System.Windows.Forms.SortOrder Orden = new System.Windows.Forms.SortOrder();
        public Frm_Banco()
        {
            InitializeComponent();
        }
        private Mant_Banco obtenerObjeto()
        {
            try
            {
                Mant_Banco Mant_Banco = new Mant_Banco();
                    Mant_Banco.banco_ID = (Int32)dataGridView1.SelectedRows[0].Cells["banco_ID"].Value;
                    Mant_Banco.descripcion = (string)dataGridView1.SelectedRows[0].Cells["descripcion"].Value;
                    Mant_Banco.estado = (bool)dataGridView1.SelectedRows[0].Cells["estado"].Value;
                    Mant_Banco.registro_fecha_add = (DateTime)dataGridView1.SelectedRows[0].Cells["registro_fecha_add"].Value;
                    Mant_Banco.registro_pc_add = (string)dataGridView1.SelectedRows[0].Cells["registro_pc_add"].Value;
                    Mant_Banco.registro_user_add = (string)dataGridView1.SelectedRows[0].Cells["registro_user_add"].Value;
                    Mant_Banco.registro_fecha_update = (DateTime)dataGridView1.SelectedRows[0].Cells["registro_fecha_update"].Value;
                    Mant_Banco.registro_pc_update = (string)dataGridView1.SelectedRows[0].Cells["registro_pc_update"].Value;
                    Mant_Banco.registro_user_update = (string)dataGridView1.SelectedRows[0].Cells["registro_user_update"].Value;
                return Mant_Banco;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }
        }

        private void Frm_Banco_Load(object sender, EventArgs e)
        {
            try
            {
                txtBusqueda.Focus();
                coleccion = Mant_BancoDataService.listartodos();
                dataGridView1.DataSource = coleccion;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void toolNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_BancoDetalle frm_BancoDetalle = new Frm_BancoDetalle();
                frm_BancoDetalle.StartPosition = FormStartPosition.CenterParent;
                frm_BancoDetalle.ShowDialog();
                coleccion = Mant_BancoDataService.Getcoleccion("descripcion like '%" + txtBusqueda.Text + "%'", "descripcion");
                dataGridView1.DataSource = coleccion;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void toolEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    Frm_BancoDetalle Frm_BancoDetalle = new Frm_BancoDetalle(obtenerObjeto());
                    Frm_BancoDetalle.StartPosition = FormStartPosition.CenterParent;
                    Frm_BancoDetalle.ShowDialog();
                    coleccion = Mant_BancoDataService.Getcoleccion("descripcion like'%" + txtBusqueda.Text + "%'", "descripcion");
                    dataGridView1.DataSource = coleccion;
                }else
                {
                    MessageBox.Show("Debe selecionar una fila", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void toolCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            tooleditar.PerformClick();
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                dataGridView1.Focus();
            }
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                DataGridViewColumn ColumnaOrdenar = dataGridView1.Columns[e.ColumnIndex];
                if (dataGridView1.SortOrder == System.Windows.Forms.SortOrder.None)
                {
                    if (ColumnaOrdenar.Name == "descripcion")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dataGridView1.DataSource = coleccion.OrderBy(p => p.descripcion).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dataGridView1.DataSource = coleccion.OrderBy(p => p.descripcion).Reverse().ToList();
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
                coleccion = Mant_BancoDataService.listartodos();
                Frm_Visor_Global frmVisor = new Frm_Visor_Global();
                frmVisor.reportViewer1.LocalReport.DataSources.Clear();
                frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._1_Tablas_Maestras.Bancos.rptBanco.rdlc";
                frmVisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", coleccion));
                ReportParameter[] param = new ReportParameter[2];
                param[0] = new ReportParameter("Empresa", Globales.NombreEmpresa);
                param[1] = new ReportParameter("Usuario", Globales.UsuarioPrueba);
                frmVisor.reportViewer1.LocalReport.SetParameters(param);
                frmVisor.reportViewer1.RefreshReport();
                frmVisor.StartPosition = FormStartPosition.CenterParent;
                frmVisor.ShowDialog();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                coleccion = Mant_BancoDataService.Getcoleccion("Descripcion like '%" + txtBusqueda.Text + "%'", "Descripcion");
                dataGridView1.DataSource = coleccion;                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
