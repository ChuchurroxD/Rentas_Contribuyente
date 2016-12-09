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
using SGR.Entity;
using WeifenLuo.WinFormsUI.Docking;
using SGR.WinApp.Layout._5_Reportes_Gestion;
using Microsoft.Reporting.WinForms;
using System.IO;

namespace SGR.WinApp.Layout._4_Procesos.Multa
{
    public partial class Frm_MultasAdministrativasListado : DockContent
    {
        Mant_PeriodoDataService mant_PeriodoDataService = new Mant_PeriodoDataService();
        Mult_MultasDataService mult_MultasDataService = new Mult_MultasDataService();
        private List<Mult_Multas> Coleccion;
        public Frm_MultasAdministrativasListado()
        {
            InitializeComponent();
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

        private void Frm_MultasAdministrativasListado_Load(object sender, EventArgs e)
        {
            try
            {
                llenarcomboPeriodo();
                Coleccion = mult_MultasDataService.listartodos();
                dgvListarArancel.DataSource = Coleccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void comboBusquedaAnio_SelectedIndexChanged(object sender, EventArgs e)
        {
            botonListar.PerformClick();
        }

        private void botonListar_Click(object sender, EventArgs e)
        {
            try
            {
                int TIPOMULTA = 0;
                if (comboBusquedaAnio.SelectedIndex == -1)
                {
                    return;
                }
                if (rbtMultasAdministraticvas.Checked)
                    TIPOMULTA = 1;
                else
                    TIPOMULTA = 2;
                if (rbtTodos.Checked)
                    Coleccion = mult_MultasDataService.listarTodosPorAnio((Int32)comboBusquedaAnio.SelectedValue, TIPOMULTA);
                else if (rbtAnulado.Checked)
                    Coleccion = mult_MultasDataService.listarTodosPorAnio2((Int32)comboBusquedaAnio.SelectedValue, "A", TIPOMULTA);
                else if (rbtCoactoivi.Checked)
                    Coleccion = mult_MultasDataService.listarTodosPorAnio2((Int32)comboBusquedaAnio.SelectedValue, "C", TIPOMULTA);
                else if (rbtGenerado.Checked)
                    Coleccion = mult_MultasDataService.listarTodosPorAnio2((Int32)comboBusquedaAnio.SelectedValue, "G", TIPOMULTA);
                else if (rbtMayor21.Checked)
                    Coleccion = mult_MultasDataService.listarTodosPorAnio2((Int32)comboBusquedaAnio.SelectedValue, "M", TIPOMULTA);

                dgvListarArancel.DataSource = Coleccion;
            }
            catch (Exception ex)
            {
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Coleccion = mult_MultasDataService.Getcoleccion("P.NombreCompleto like '%" + txtNombre.Text + "%'", "P.NombreCompleto");
                dgvListarArancel.DataSource = Coleccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void toolNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_MultasAdministrativas frm_MultasAdministrativas = new Frm_MultasAdministrativas();
                frm_MultasAdministrativas.StartPosition = FormStartPosition.CenterParent;
                frm_MultasAdministrativas.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void toolEditar_Click(object sender, EventArgs e)
        {
            Frm_MultasAdministrativas frm_MultasAdministrativas = new Frm_MultasAdministrativas(obtenerdatos());
            frm_MultasAdministrativas.StartPosition = FormStartPosition.CenterParent;
            frm_MultasAdministrativas.ShowDialog();
        }

        private Mult_Multas obtenerdatos()
        {
            Mult_Multas mult_Multas = new Mult_Multas();
            mult_Multas.mult_id = (int)dgvListarArancel.SelectedRows[0].Cells["mult_id"].Value;
            mult_Multas.mult_direccion = (string)dgvListarArancel.SelectedRows[0].Cells["mult_direccion"].Value;
            mult_Multas.persona_id = (string)dgvListarArancel.SelectedRows[0].Cells["persona_id"].Value;
            mult_Multas.mult_direccion = (string)dgvListarArancel.SelectedRows[0].Cells["mult_direccion"].Value;
            mult_Multas.TipoMulta_id = (int)dgvListarArancel.SelectedRows[0].Cells["TipoMulta_id"].Value;
            mult_Multas.mult_monto = (decimal)dgvListarArancel.SelectedRows[0].Cells["mult_monto"].Value;
            mult_Multas.mult_nro_resolucion = (string)dgvListarArancel.SelectedRows[0].Cells["mult_nro_resolucion"].Value;
            mult_Multas.mult_anio_resolucion = (string)dgvListarArancel.SelectedRows[0].Cells["mult_anio_resolucion"].Value;
            mult_Multas.mult_fecha_resol = (DateTime)dgvListarArancel.SelectedRows[0].Cells["mult_fecha_resol"].Value;
            mult_Multas.mult_archivo = (string)dgvListarArancel.SelectedRows[0].Cells["mult_archivo"].Value;
            mult_Multas.mult_observacion = (string)dgvListarArancel.SelectedRows[0].Cells["mult_observacion"].Value;
            mult_Multas.fecha_genera = (DateTime)dgvListarArancel.SelectedRows[0].Cells["fecha_genera"].Value;
            mult_Multas.fecha_notifica = (DateTime)dgvListarArancel.SelectedRows[0].Cells["fecha_notifica"].Value;
            mult_Multas.fecha_vence = (DateTime)dgvListarArancel.SelectedRows[0].Cells["fecha_vence"].Value;
            mult_Multas.registro_user = (string)dgvListarArancel.SelectedRows[0].Cells["registro_user"].Value;
            mult_Multas.fecha_elimina = (DateTime)dgvListarArancel.SelectedRows[0].Cells["fecha_elimina"].Value;
            mult_Multas.mult_estado = (string)dgvListarArancel.SelectedRows[0].Cells["mult_estado"].Value;
            mult_Multas.tp_recurso = (int)dgvListarArancel.SelectedRows[0].Cells["tp_recurso"].Value;
            mult_Multas.resol_resuelve = (string)dgvListarArancel.SelectedRows[0].Cells["resol_resuelve"].Value;
            mult_Multas.fech_recurso = (DateTime)dgvListarArancel.SelectedRows[0].Cells["fech_recurso"].Value;
            mult_Multas.tp_declaro = (int)dgvListarArancel.SelectedRows[0].Cells["tp_declaro"].Value;
            mult_Multas.persona = (string)dgvListarArancel.SelectedRows[0].Cells["persona"].Value;
            mult_Multas.recursod = (string)dgvListarArancel.SelectedRows[0].Cells["recursod"].Value;
            mult_Multas.declarod = (string)dgvListarArancel.SelectedRows[0].Cells["declarod"].Value;
            mult_Multas.tipomultad = (string)dgvListarArancel.SelectedRows[0].Cells["tipomultad"].Value;
            return mult_Multas;
        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            Frm_Visor_Global frm_Visor_Global = new Frm_Visor_Global();
            try
            {
                
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._4_Procesos.Multa.Rep_multas.rdlc";
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", Coleccion));
                ReportParameter[] param = new ReportParameter[2];
                param[0] = new ReportParameter("Usuario", Globales.UsuarioPrueba);
                param[1] = new ReportParameter("Anio", comboBusquedaAnio.SelectedValue.ToString());
                frm_Visor_Global.reportViewer1.LocalReport.SetParameters(param);
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

        private void toolEnviarCoactivo_Click(object sender, EventArgs e)
        {
            try
            {
                string Estado = (string)dgvListarArancel.SelectedRows[0].Cells["mult_estado"].Value;
                if (Estado.Trim() == "C")
                {
                    MessageBox.Show("Ya esta en coactivo", Globales.Global_MessageBox);
                    return;
                }
                if (MessageBox.Show("Esta seguro que desea enviar a coactivo?", Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int mult_id = (int)dgvListarArancel.SelectedRows[0].Cells["mult_id"].Value;
                    string persona_id = (string)dgvListarArancel.SelectedRows[0].Cells["persona_id"].Value;
                    mult_MultasDataService.EnviarCoactivo(mult_id, GlobalesV1.Global_str_Usuario, persona_id);
                    MessageBox.Show("Se enviò a coactivo", Globales.Global_MessageBox);
                    botonListar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void rbtTodos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgvListarArancel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }


}
