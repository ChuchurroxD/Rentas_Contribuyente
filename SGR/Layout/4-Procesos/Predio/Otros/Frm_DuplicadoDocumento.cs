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

namespace SGR.WinApp.Layout._4_Procesos.Predio.Otros
{
    public partial class Frm_DuplicadoDocumento : DockContent
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
        private Pred_DuplicadoFormularioDataService DuplicadoFormularioDataService = new Pred_DuplicadoFormularioDataService();
        public Frm_DuplicadoDocumento()
        {
            InitializeComponent();
            periodos = PeriodoDataService.GetAllMant_Periodo();
            cboAnioIni.DisplayMember = "Peric_canio";
            cboAnioIni.ValueMember = "Peric_canio";
            cboAnioIni.DataSource = periodos;
            cboAnioFin.DisplayMember = "Peric_canio";
            cboAnioFin.ValueMember = "Peric_canio";
            cboAnioFin.DataSource = periodos;
        }

        private void rbtNDoc_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtNDoc.Checked)
            {
                string texto = txtNDocu.Text;
                if (texto.Length != 0)
                    listarBuscado(texto, "", "");
            }
        }

        private void rbtCodContribuyente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtCodContribuyente.Checked)
            {
                string texto = txtCodContribuyente.Text;
                if (texto.Length != 0)
                    listarBuscado("", texto, "");
            }
        }

        private void rbtNombre_CheckedChanged(object sender, EventArgs e)
        {

            if (rbtNombre.Checked)
            {

                string texto = txtNomRazon.Text;
                if (texto.Length != 0)
                    listarBuscado("", "", texto);
            }
        }

        private void txtNDocu_KeyPress(object sender, KeyPressEventArgs e)
        {
            string texto;
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                texto = txtNDocu.Text;
            }
            else
            {
                if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsControl(e.KeyChar)))
                {
                    MessageBox.Show("Solo se permiten números", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
                texto = txtNDocu.Text + e.KeyChar.ToString();
            }

            if (texto.Length != 0 && rbtNDoc.Checked)
                listarBuscado(texto, "", "");
        }

        private void txtCodContribuyente_KeyPress(object sender, KeyPressEventArgs e)
        {
            string texto;
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                texto = txtCodContribuyente.Text;
            }
            else
            {
                if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsControl(e.KeyChar)))
                {
                    MessageBox.Show("Solo se permiten números", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
                texto = txtCodContribuyente.Text + e.KeyChar.ToString();
            }

            if (texto.Length != 0 && rbtCodContribuyente.Checked)
                listarBuscado("", texto, "");
        }

        private void txtNomRazon_KeyPress(object sender, KeyPressEventArgs e)
        {
            string texto;
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                texto = txtNomRazon.Text;
            }
            else
                texto = txtNomRazon.Text + e.KeyChar.ToString();

            if (texto.Length != 0 && rbtNombre.Checked)
                listarBuscado("", "", texto);
        }
        private void listarBuscado(string doc, string cod, string name)
        {
            try
            {
                int tipo;
                if (rbtNDoc.Checked)
                    tipo = 27;
                else if (rbtCodContribuyente.Checked)
                    tipo = 28;
                else
                    tipo = 29;
                dgvContribuyenteBuscados.DataSource = mant_ContribuyenteDataService.listarSoloCOntribuyente(doc, cod, name, tipo);
                if (dgvContribuyenteBuscados.SelectedRows.Count > 0)
                {
                    String perso = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["persona_ID"].Value;
                    Coleccion = FiscalizacionDataService.listarpredios(perso, cboAnioIni.SelectedValue.ToString());
                    dgvPredio.DataSource = Coleccion;
                    ckbPRPU.Checked = false;
                    ckbPRPU.Checked = true;
                    //PintarColumnasCalculadas();
                }
                else
                    dgvPredio.DataSource = new List<Pred_Predio>();
            }
            catch (Exception ex)
            {

            }
        }
        private void cboAnioIni_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                int cantidad;
                cantidad = periodos.Count;
                List<Mant_Periodo> periodo2 = new List<Mant_Periodo>();

                for (int i = 0; i < cantidad; i++)
                {
                    if (Convert.ToInt32(periodos[i].Peric_canio) >= Convert.ToInt32(cboAnioIni.SelectedValue))
                    {
                        Mant_Periodo peri = new Mant_Periodo();
                        peri.Peric_canio = periodos[i].Peric_canio;
                        periodo2.Add(peri);
                    }
                }
                cboAnioFin.DisplayMember = "Peric_canio";
                cboAnioFin.ValueMember = "Peric_canio";
                cboAnioFin.DataSource = periodo2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Globales.Global_MessageBox);
            }
        }

        private void btnDuplicado_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvContribuyenteBuscados.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Selecciones un registro", Globales.Global_MessageBox);
                    return;
                }
                if (!ckbPRPU.Checked && !ckbHR.Checked)
                {
                    MessageBox.Show("Elija que duplicará", Globales.Global_MessageBox);
                    return;
                }
                int tipo = 0;

                if (ckbHR.Checked && ckbPRPU.Checked)
                {
                    tipo = 3;
                }
                else
                {
                    if (ckbHR.Checked)
                    {
                        tipo = 1;
                    }
                    if (ckbPRPU.Checked)
                    {
                        tipo = 2;
                    }
                }
                int cantidad = dgvPredio.RowCount;
                int valor = 0;
                for (int i = 0; i < cantidad; i++)
                {
                    DataGridViewRow row = dgvPredio.Rows[i];
                    DataGridViewCheckBoxCell cellSelecion = row.Cells["Op"] as DataGridViewCheckBoxCell;

                    bool bandera = Convert.ToBoolean(cellSelecion.Value);
                    if (bandera)
                    {
                        valor = valor + 1;
                    }
                }

                String perso = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["persona_ID"].Value;
                string msj = DuplicadoFormularioDataService.Verificar(perso, cboAnioIni.SelectedValue.ToString(), cboAnioFin.SelectedValue.ToString());
                if (msj.Trim().Length != 2)
                {
                    //MessageBox.Show(msj, Globales.Global_MessageBox);
                    msj = msj + ". Desea Grabar?";
                }
                else
                    msj = "Desea Grabar?";
                //else
                //{

                if (MessageBox.Show(msj, Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DuplicadoFormularioDataService.Generar(perso, cboAnioIni.SelectedValue.ToString(), cboAnioFin.SelectedValue.ToString(), registro_user, tipo, valor);

                    MessageBox.Show("Se generó duplicado", Globales.Global_MessageBox);
                }

                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Globales.Global_MessageBox);
            }

        }

        private void ckbPRPU_CheckedChanged(object sender, EventArgs e)
        {
            int cantidad = dgvPredio.RowCount;
            decimal total = 0;
            decimal valor = 0;
            for (int i = 0; i < cantidad; i++)
            {
                DataGridViewRow row1 = dgvPredio.Rows[i];
                DataGridViewCheckBoxCell cellSelecion1 = row1.Cells["Op"] as DataGridViewCheckBoxCell;
                cellSelecion1.Value = ckbPRPU.Checked;
            }
        }

        private void dgvPredio_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvPredio.IsCurrentCellDirty)
            {
                dgvPredio.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvContribuyenteBuscados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (dgvContribuyenteBuscados.Columns[e.ColumnIndex].Name == "xpredio" && dgvContribuyenteBuscados.RowCount > 0)
                {
                    String perso = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["persona_ID"].Value;
                    Coleccion = FiscalizacionDataService.listarpredios(perso, cboAnioIni.SelectedValue.ToString());
                    dgvPredio.DataSource = Coleccion;
                    //PintarColumnasCalculadas();
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
