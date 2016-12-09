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
using SGR.Entity.Model;
using SGR.WinApp.Layout._4_Procesos.Predio.Historial_PC;

namespace SGR.WinApp.Layout._4_Procesos.Predio.Fiscalizacion
{
    public partial class Frm_Fiscalizacion_Descarga : DockContent
    {
        private Pred_PredioDataService predioDataService = new Pred_PredioDataService();
        Conf_UbicacionDataService conf_UbicacionDataService = new Conf_UbicacionDataService();
        Pred_ViasDataService pred_ViasDataService = new Pred_ViasDataService();
        Pred_PredioContribuyenteDataService pred_PredioContribuyenteDataService = new Pred_PredioContribuyenteDataService();
        Mant_ContribuyenteDataService mant_ContribuyenteDataService = new Mant_ContribuyenteDataService();
        Mant_JuntaViaDataService mant_JuntaViaDataService = new Mant_JuntaViaDataService();
        private Sistema.Globales.Validaciones obValidacion = new Sistema.Globales.Validaciones();
        private List<Pred_Predio> Coleccion;
        private System.Windows.Forms.SortOrder Orden = new System.Windows.Forms.SortOrder();
        private Mant_PeriodoDataService PeriodoDataService = new Mant_PeriodoDataService();
        Pred_SectorDataService pred_SectorDataService = new Pred_SectorDataService();
        Pred_FiscalizacionDataService FiscalizacionDataService = new Pred_FiscalizacionDataService();
        Pred_Fiscalizacion Fiscalizacion = new Pred_Fiscalizacion();
        private int periodo;
        private List<Repo_HojaResumen> ColeccionPC;
        private List<Mant_Contribuyente> ColeccionMPC;
        private Pred_Certificado_AlcabalaDataService Certificado_AlcabalaDataService = new Pred_Certificado_AlcabalaDataService();
        public Frm_Fiscalizacion_Descarga()
        {
            try
            {

                InitializeComponent();
                periodo = PeriodoDataService.GetPeriodoActivo();
                cboPeriodo.DisplayMember = "Peric_canio";
                cboPeriodo.ValueMember = "Peric_canio";
                cboPeriodo.DataSource = PeriodoDataService.llenarPeriodo();
                cboPeriodo.SelectedValue = periodo;
                txtUrbano.BackColor = Color.Gold;
                txtRustico.BackColor = Color.Green;
                dgvPredio.MultiSelect = false;
                dgvContribuyenteBuscados.MultiSelect = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarContribuyente();
        }

        private void cboPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarContribuyente();
        }

        private void BuscarContribuyente()
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try    ///////      //
            {
                if (rbtCodContribuyente.Checked)
                {
                    dgvContribuyenteBuscados.DataSource = mant_ContribuyenteDataService.listarBuscados(txtCodContribuyente.Text.Trim(), 18, "persona_id", GlobalesV1.Global_int_idoficina);
                }
                else
                {
                    if (rbtNombre.Checked)
                    {
                        dgvContribuyenteBuscados.DataSource = mant_ContribuyenteDataService.listarBuscados(txtNomRazon.Text.TrimEnd(), 19, "razon_social", GlobalesV1.Global_int_idoficina);
                    }

                }
                if (dgvContribuyenteBuscados.SelectedRows.Count != 0)
                {
                    String perso = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["persona_ID"].Value;
                    Coleccion = FiscalizacionDataService.listarpredios(perso, cboPeriodo.SelectedValue.ToString());
                    dgvPredio.DataSource = Coleccion;
                    PintarColumnasCalculadas();
                }
                else
                    dgvPredio.DataSource = new List<Pred_Predio>();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Globales.Global_MessageBox);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void PintarColumnasCalculadas()
        {
            for (int i = 0; i < dgvPredio.RowCount; i++)
            {
                DataGridViewRow row = dgvPredio.Rows[i];
                int tipo_inmueble = (Int32)row.Cells["tipo_inmueble"].Value;
                DataGridViewTextBoxCell cellSelecion = row.Cells["predio_ID"] as DataGridViewTextBoxCell;
                if (tipo_inmueble == 1)//urbano
                {
                    cellSelecion.Style.BackColor = Color.Gold;
                }
                else if (tipo_inmueble == 2)//rustico
                {
                    cellSelecion.Style.BackColor = Color.Green;
                }

                cellSelecion = row.Cells["Observacion"] as DataGridViewTextBoxCell;
                cellSelecion.Style.BackColor = Color.Red;
            }
        }


        private void dgvPredio_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Esta seguro que desea descargar", Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    String perso = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["persona_ID"].Value;
                    String predio_id = (String)dgvPredio.SelectedRows[0].Cells["predio_ID"].Value;
                    String periodo = cboPeriodo.SelectedValue.ToString();
                    Frm_HistorialPC_detalle frm_HistorialPC_detalle = new Frm_HistorialPC_detalle();
                    frm_HistorialPC_detalle.StartPosition = FormStartPosition.CenterParent;
                    frm_HistorialPC_detalle.ShowDialog();
                    if (Globales.validado == 1)
                    {
                        pred_PredioContribuyenteDataService.DescargarPredio(predio_id, cboPeriodo.SelectedValue.ToString(),
                           perso, GlobalesV1.Global_str_Usuario);
                        MessageBox.Show("Se descargo correctamente", Globales.Global_MessageBox);
                    }
                    else
                        MessageBox.Show("No lleno Historial, no se descargo", Globales.Global_MessageBox);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void dgvPredio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarTipoTerreno();
        }

        private void seleccionarTipoTerreno()
        {

            try
            {
                System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStylen = new System.Windows.Forms.DataGridViewCellStyle();
                DataGridViewRow row = dgvPredio.SelectedRows[0];
                int tipo_inmueble = (Int32)row.Cells["tipo_inmueble"].Value;
                DataGridViewTextBoxCell cellSelecion = row.Cells["predio_ID"] as DataGridViewTextBoxCell;
                if (tipo_inmueble == 1)//urbano
                {
                    dataGridViewCellStylen.SelectionBackColor = Color.Gold;
                    dataGridViewCellStylen.SelectionForeColor = Color.Black;
                }
                else if (tipo_inmueble == 2)//rustico
                {

                    dataGridViewCellStylen.SelectionBackColor = Color.Green;
                    dataGridViewCellStylen.SelectionForeColor = Color.Black;
                }

                dgvPredio.DefaultCellStyle = dataGridViewCellStylen;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Globales.Global_MessageBox);
            }
        }

        private void dgvPredio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPredio.SelectedRows.Count > 0)
            {
                seleccionarTipoTerreno();
            }
        }

        private void dgvPredio_DoubleClick(object sender, EventArgs e)
        {
            if (dgvPredio.SelectedRows.Count > 0)
            {
                seleccionarTipoTerreno();
            }
        }

        private void dgvContribuyenteBuscados_DoubleClick(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (dgvContribuyenteBuscados.SelectedRows.Count > 0)
                {

                    String perso = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["persona_ID"].Value;
                    Coleccion = FiscalizacionDataService.listarpredios(perso, cboPeriodo.SelectedValue.ToString());
                    dgvPredio.DataSource = Coleccion;
                    PintarColumnasCalculadas();
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
    }
}
