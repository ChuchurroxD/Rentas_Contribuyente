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

namespace SGR.WinApp.Layout._1_Tablas_Maestras.Persona
{
    public partial class Frm_Persona : DockContent
    {
        Conf_MultitablaDataService conf_MultitablaDataService = new Conf_MultitablaDataService();
        Conf_UbicacionDataService conf_UbicacionDataService = new Conf_UbicacionDataService();
        Pred_SectorDataService pred_SectorDataService = new Pred_SectorDataService();
        Pred_ViasDataService pred_ViasDataService = new Pred_ViasDataService();
        Mant_PersonaDataService mant_PersonaDataService = new Mant_PersonaDataService();
        Mant_Persona mant_Persona = new Mant_Persona();
        private List<Mant_Persona> Coleccion;
        private System.Windows.Forms.SortOrder Orden = new System.Windows.Forms.SortOrder();
        public Frm_Persona()
        {
            InitializeComponent();
        }


        private void toolnuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_Persona_Detalle ffrm_Persona_Detalle = new Frm_Persona_Detalle();
                ffrm_Persona_Detalle.StartPosition = FormStartPosition.CenterParent;
                ffrm_Persona_Detalle.ShowDialog();
                Pred_SectorDataService pred_SectorDataService = new Pred_SectorDataService();
                Coleccion = mant_PersonaDataService.listartodos();
                dgvPersonas.DataSource = Coleccion;
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
                if (dgvPersonas.SelectedRows.Count > 0)
                {
                    Frm_Persona_Detalle ffrm_Persona_Detalle = new Frm_Persona_Detalle(obtenerdatos());
                    ffrm_Persona_Detalle.StartPosition = FormStartPosition.CenterParent;
                    ffrm_Persona_Detalle.ShowDialog();

                    if (txtNomRazon.Text.Trim().Length == 0)
                    {
                        Coleccion = mant_PersonaDataService.listartodos();
                        dgvPersonas.DataSource = Coleccion;
                    }
                    else
                    {// dgvPersonas.DataSource = pred_sectordataservice.Getcoleccion("Descripcion like '%" + txtbusqueda.Text + "%'", "Descripcion");
                        dgvPersonas.DataSource = mant_PersonaDataService.listarbuscados(txtNomRazon.Text.TrimEnd());

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
        private Mant_Persona obtenerdatos()
        {
            Mant_Persona maant_Persona = new Mant_Persona();
            maant_Persona.persona_ID = (string)dgvPersonas.SelectedRows[0].Cells["persona_ID"].Value;
            maant_Persona.tipo_persona = (Int16)dgvPersonas.SelectedRows[0].Cells["tipo_persona"].Value;
            maant_Persona.Ubi_codigo = (string)dgvPersonas.SelectedRows[0].Cells["Ubi_codigo"].Value;
            maant_Persona.celular = (string)dgvPersonas.SelectedRows[0].Cells["celular"].Value;
            maant_Persona.tienda = (string)dgvPersonas.SelectedRows[0].Cells["tienda"].Value;
            maant_Persona.piso = (string)dgvPersonas.SelectedRows[0].Cells["piso"].Value;
            maant_Persona.edificio = (string)dgvPersonas.SelectedRows[0].Cells["edificio"].Value;
            maant_Persona.fechaNacimiento = (DateTime)dgvPersonas.SelectedRows[0].Cells["fechaNacimiento"].Value;
            maant_Persona.sexo = (string)dgvPersonas.SelectedRows[0].Cells["sexo"].Value;
            maant_Persona.expediente = (string)dgvPersonas.SelectedRows[0].Cells["expediente"].Value;
            maant_Persona.OtraDireccion = (string)dgvPersonas.SelectedRows[0].Cells["OtraDireccion"].Value;
            maant_Persona.prov = (string)dgvPersonas.SelectedRows[0].Cells["prov"].Value;
            maant_Persona.dep = (string)dgvPersonas.SelectedRows[0].Cells["dep"].Value;
            maant_Persona.via_ID = (string)dgvPersonas.SelectedRows[0].Cells["via_ID"].Value;
            maant_Persona.junta_ID = (string)dgvPersonas.SelectedRows[0].Cells["junta_ID"].Value;
            maant_Persona.ESTADO = (bool)dgvPersonas.SelectedRows[0].Cells["ESTADO"].Value;
            maant_Persona.email = (string)dgvPersonas.SelectedRows[0].Cells["email"].Value;
            maant_Persona.fono_oficina = (string)dgvPersonas.SelectedRows[0].Cells["fono_oficina"].Value;
            maant_Persona.Fono_Domicilio = (string)dgvPersonas.SelectedRows[0].Cells["Fono_Domicilio"].Value;
            maant_Persona.Lote = (string)dgvPersonas.SelectedRows[0].Cells["Lote"].Value;
            maant_Persona.mz = (string)dgvPersonas.SelectedRows[0].Cells["mz"].Value;
            maant_Persona.Dpto = (string)dgvPersonas.SelectedRows[0].Cells["Dpto"].Value;
            maant_Persona.interior = (string)dgvPersonas.SelectedRows[0].Cells["interior"].Value;
            maant_Persona.num_via = (string)dgvPersonas.SelectedRows[0].Cells["num_via"].Value;
            maant_Persona.nombres = (string)dgvPersonas.SelectedRows[0].Cells["nombres"].Value;
            maant_Persona.materno = (string)dgvPersonas.SelectedRows[0].Cells["materno"].Value;
            maant_Persona.paterno = (string)dgvPersonas.SelectedRows[0].Cells["paterno"].Value;
            maant_Persona.documento = (string)dgvPersonas.SelectedRows[0].Cells["documento"].Value;
            maant_Persona.tipo_documento = (Int16)dgvPersonas.SelectedRows[0].Cells["tipo_documento"].Value;
            return maant_Persona;
        }
        private void dgvPersonas_DoubleClick(object sender, EventArgs e)
        {
            tooleditar.PerformClick();
        }

        private void Frm_Persona_Load(object sender, EventArgs e)
        {
            try
            {
                txtNomRazon.Focus();
                Coleccion = mant_PersonaDataService.listartodos();
                dgvPersonas.DataSource = Coleccion; 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }



        }

        private void tooleliminar_Click(object sender, EventArgs e)
        {
            if ((bool)dgvPersonas.SelectedRows[0].Cells["ESTADO"].Value)
            {
                if (MessageBox.Show("En verdad desea eliminar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string codigo = (string)dgvPersonas.SelectedRows[0].Cells["persona_ID"].Value;
                    mant_PersonaDataService.DeleteByPrimaryKey(codigo);
                    dgvPersonas.DataSource = mant_PersonaDataService.listartodos();
                }
            }
            else
            {
                MessageBox.Show("No puede eliminar un elemento eliminado");
            }
        }

        //private void dgvPersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}

        private void dgvPersonas_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                DataGridViewColumn ColumnaOrdenar = dgvPersonas.Columns[e.ColumnIndex];

                if (dgvPersonas.SortOrder == System.Windows.Forms.SortOrder.None)
                {

                    if (ColumnaOrdenar.Name == "persona_ID")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgvPersonas.DataSource = Coleccion.OrderBy(p => p.persona_ID).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgvPersonas.DataSource = Coleccion.OrderBy(p => p.persona_ID).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "paterno")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgvPersonas.DataSource = Coleccion.OrderBy(p => p.paterno).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgvPersonas.DataSource = Coleccion.OrderBy(p => p.paterno).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }

                    }
                    else if (ColumnaOrdenar.Name == "materno")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgvPersonas.DataSource = Coleccion.OrderBy(p => p.materno).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgvPersonas.DataSource = Coleccion.OrderBy(p => p.materno).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }

                    }
                    else if (ColumnaOrdenar.Name == "nombres")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgvPersonas.DataSource = Coleccion.OrderBy(p => p.nombres).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgvPersonas.DataSource = Coleccion.OrderBy(p => p.nombres).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }

                    }
                    else if (ColumnaOrdenar.Name == "documento")
                    {
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgvPersonas.DataSource = Coleccion.OrderBy(p => p.documento).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgvPersonas.DataSource = Coleccion.OrderBy(p => p.documento).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }

                    }
                }

            }
        }

        private void txtNomRazon_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //dataGridView1.DataSource = pred_sectordataservice.Getcoleccion("Descripcion like '%" + txtbusqueda.Text + "%'", "Descripcion");
                //dgvPersonas.DataSource = mant_PersonaDataService.listarbuscados(txtNomRazon.Text.TrimEnd());
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    dgvPersonas.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
           // dgvPersonas.DataSource = mant_PersonaDataService.listarbuscados(txtNomRazon.Text.TrimEnd());
        }

        private void dgvPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvPersonas.SelectedRows.Count == 0)
            {

                return;
            }
            int xpersona =int.Parse ( dgvPersonas.SelectedRows[0].Cells["persona_ID"].Value.ToString ());



            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (dgvPersonas.Columns[e.ColumnIndex].Name == "ImgImprimir")
                {
                    Cursor.Current = Cursors.WaitCursor;
                    Frm_Visor_Global frm_Visor_Global = new Frm_Visor_Global();
                    Mant_Persona persona = new Mant_Persona();
                    Coleccion = mant_PersonaDataService.listarxIdPersona(xpersona);
                    frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                    frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._1_Tablas_Maestras.Persona.Reporte_Persona.rdlc";
                    frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetPersona", Coleccion));
                    ReportParameter[] paramsx = new ReportParameter[2];
                    paramsx[0] = new ReportParameter("NombreEmpresa", "Municipalidad Distrital de Moche");
                    paramsx[1] = new ReportParameter("UsuarioPrueba", "Usuario 01");
                    frm_Visor_Global.reportViewer1.LocalReport.SetParameters(paramsx);
                    frm_Visor_Global.reportViewer1.RefreshReport();
                    frm_Visor_Global.StartPosition = FormStartPosition.CenterScreen;
                    frm_Visor_Global.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
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
                Coleccion = mant_PersonaDataService.listartodos();
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._1_Tablas_Maestras.Persona.ReporteDetalle_Persona.rdlc";
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetPersonaDetalle", Coleccion));
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

        private void txtNomRazon_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //dataGridView1.DataSource = pred_sectordataservice.Getcoleccion("Descripcion like '%" + txtbusqueda.Text + "%'", "Descripcion");
                dgvPersonas.DataSource = mant_PersonaDataService.listarbuscados(txtNomRazon.Text.TrimEnd());                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
            // dgvPersonas.DataSource = mant_PersonaDataService.listarbuscados(txtNomRazon.Text.TrimEnd());
        }

        private void dgvPersonas_DoubleClick_1(object sender, EventArgs e)
        {
            tooleditar.PerformClick();
        }
    }
}
