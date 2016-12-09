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
using SGR.WinApp.Layout._4_Procesos.Predio.PredioMasivo;
using SGR.WinApp.Layout._4_Procesos.Predio.Historial_PC;

namespace SGR.WinApp.Layout._4_Procesos.Predio.Otros
{
    public partial class Frm_Historial : DockContent
    {
        private Pred_PredioDataService predioDataService = new Pred_PredioDataService();

        private Pred_CalculoPorPersonaAniosDataService CalculoPorPersonaAniosDataService = new Pred_CalculoPorPersonaAniosDataService();
        private List<Mant_Periodo> periodos = new List<Mant_Periodo>();
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
        Pred_FiscalizacionCtaCteDataService FiscalizacionCtaCteDataService = new Pred_FiscalizacionCtaCteDataService();
        private int periodo;
        private List<Repo_HojaResumen> ColeccionPC;
        private List<Mant_Contribuyente> ColeccionMPC;
        private Pred_Certificado_AlcabalaDataService Certificado_AlcabalaDataService = new Pred_Certificado_AlcabalaDataService();
        private Proc_CuentaCorritenteDataService Proc_CuentaCorritenteDataService = new Proc_CuentaCorritenteDataService();
        private string registro_user = GlobalesV1.Global_str_Usuario;
        private List<Pred_UsoGeneral> coleccionGeneralPredial;
        private List<Pred_UsoGeneral> coleccionGeneral;
        private List<Pred_UsoGeneral> coleccionGeneralArb;
        private List<Proc_CuentaCorritente> coleccionCta1;
        private List<Proc_CuentaCorritente> coleccionCta2;
        public Frm_Historial()
        {
            InitializeComponent();
            periodo = PeriodoDataService.GetPeriodoActivo();
            cboPeriodo.DisplayMember = "Peric_canio";
            cboPeriodo.ValueMember = "Peric_canio";
            cboPeriodo.DataSource = PeriodoDataService.llenarPeriodo();
            cboPeriodo.SelectedValue = periodo;

        }
        
       

        private void txtCodContribuyente_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                string texto = txtCodContribuyente.Text.TrimEnd();
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {listarBuscado("", texto, "");
                }
                else
                {
                    texto = texto + e.KeyChar.ToString();
                   listarBuscado("", texto, "");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void listarBuscado(string doc, string cod, string name)
        {
            try
            {
                int tipo= 29;
                dgvContribuyenteBuscados.DataSource = mant_ContribuyenteDataService.listarSoloCOntribuyente(doc, cod, name, tipo);
                if (dgvContribuyenteBuscados.SelectedRows.Count != 0)
                {
                    String perso = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["persona_ID"].Value;
                    Coleccion = FiscalizacionDataService.listarpredios(perso, cboPeriodo.SelectedValue.ToString());
                    dgvPredio.DataSource = Coleccion;
                }
                else
                    dgvPredio.DataSource = new List<Pred_Predio>();
            }
            catch (Exception ex)
            {

            }
        }

        
        private string CambiarTexto(string txt)
        {
            if (txt.TrimEnd() == "")
                return "%";
            return txt.TrimEnd();
        }
        private void buscar()
        {
            try    ///////      //
            {
               dgvContribuyenteBuscados.DataSource = mant_ContribuyenteDataService.listarBuscados(txtCodContribuyente.Text.Trim(), 18, "persona_id", GlobalesV1.Global_int_idoficina);
                String perso = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["persona_ID"].Value;
                if (rbtActivos.Checked)
                {
                    Coleccion = FiscalizacionDataService.listarprediosUltiosHistoricos(perso, Convert.ToInt32(cboPeriodo.SelectedValue.ToString()) );
                    dgvPredio.DataSource = Coleccion;
                }else if (rbtTodos.Checked)
                {
                    Coleccion = FiscalizacionDataService.listarprediosAcitvoNoActivo(perso, cboPeriodo.SelectedValue.ToString());
                    dgvPredio.DataSource = Coleccion;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Globales.Global_MessageBox);
            }
        }

        private void cboPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            listarBuscado("", txtCodContribuyente.Text,"");
        }

        private void dgvContribuyenteBuscados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (dgvContribuyenteBuscados.Columns[e.ColumnIndex].Name == "Historial" && dgvContribuyenteBuscados.RowCount > 0)
                {
                    String perso = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["persona_ID"].Value;
                    Frm_HistorialPC frm_HistorialPC = new Frm_HistorialPC(perso, Convert.ToInt32(cboPeriodo.SelectedValue.ToString()), 1);
                    frm_HistorialPC.StartPosition = FormStartPosition.CenterParent;
                    frm_HistorialPC.ShowDialog();

                }
                if (dgvContribuyenteBuscados.Columns[e.ColumnIndex].Name == "Predio" && dgvContribuyenteBuscados.RowCount > 0)
                {
                    if (dgvContribuyenteBuscados.SelectedRows.Count != 0)
                    {
                        String perso = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["persona_ID"].Value;
                        Coleccion = FiscalizacionDataService.listarpredios(perso, cboPeriodo.SelectedValue.ToString());
                        dgvPredio.DataSource = Coleccion;
                    }
                    else
                        dgvPredio.DataSource = new List<Pred_Predio>();

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

        private void dgvPredio_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (dgvPredio.Columns[e.ColumnIndex].Name == "HistorialPredio" && dgvPredio.RowCount > 0)
                {
                     String predio = (String)dgvPredio.SelectedRows[0].Cells["predio_ID"].Value;
                    Frm_HistorialPC frm_HistorialPC = new Frm_HistorialPC(predio, Convert.ToInt32(cboPeriodo.SelectedValue.ToString()), 2);
                    frm_HistorialPC.StartPosition = FormStartPosition.CenterParent;
                    frm_HistorialPC.ShowDialog();
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

        private void dgvPredio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnReportar_Click(object sender, EventArgs e)
        {
            buscar();
        }
    }
}
