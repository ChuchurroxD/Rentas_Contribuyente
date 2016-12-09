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

namespace SGR.WinApp.Layout._4_Procesos.Predio.PredioMasivo
{
    public partial class Frm_ReAjusteMasivo : DockContent
    {

        private Mant_JuntaViaDataService Mant_JuntaViaDataService = new Mant_JuntaViaDataService();
        private List<Mant_Periodo> periodos = new List<Mant_Periodo>();
        private Mant_PeriodoDataService PeriodoDataService = new Mant_PeriodoDataService();
        Mant_ContribuyenteDataService mant_ContribuyenteDataService = new Mant_ContribuyenteDataService();

        private List<Pred_UsoGeneral> coleccionGeneralPredial;
        private List<Pred_UsoGeneral> coleccionGeneral;
        private List<Pred_UsoGeneral> coleccionGeneralArb;

        private List<Pred_UsoGeneral> coleccionGeneralPredial1 = new List<Pred_UsoGeneral>();
        private List<Pred_UsoGeneral> coleccionGeneral1 = new List<Pred_UsoGeneral>();
        private List<Pred_UsoGeneral> coleccionGeneralArb1 = new List<Pred_UsoGeneral>();
        private Pred_CalculoPorPersonaAniosDataService CalculoPorPersonaAniosDataService = new Pred_CalculoPorPersonaAniosDataService();
        private Proc_CuentaCorritenteDataService Proc_CuentaCorritenteDataService = new Proc_CuentaCorritenteDataService();
        public Frm_ReAjusteMasivo()
        {
            try
            {
                InitializeComponent();
                cboSector.DisplayMember = "descripcion";
                cboSector.ValueMember = "sector_id";
                cboSector.DataSource = Mant_JuntaViaDataService.llenarCombosector(GlobalesV1.Global_int_idoficina);

                periodos = PeriodoDataService.GetAllMant_Periodo();
                cboAnioIni.DisplayMember = "Peric_canio";
                cboAnioIni.ValueMember = "Peric_canio";
                cboAnioIni.DataSource = periodos;
                cboAnioFin.DisplayMember = "Peric_canio";
                cboAnioFin.ValueMember = "Peric_canio";
                cboAnioFin.DataSource = periodos;
            }
            catch (Exception ex) { }
        }


        private void cboSector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ckbTodos_CheckedChanged(object sender, EventArgs e)
        {
            cboSector.Enabled = !ckbTodos.Checked;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (ckbTodos.Checked)// todo 
                {
                    dgvContribuyenteBuscados.DataSource = mant_ContribuyenteDataService.listarBuscadosParaReajuste("0", GlobalesV1.Global_int_idoficina, 38);
                }
                else
                {
                    dgvContribuyenteBuscados.DataSource = mant_ContribuyenteDataService.listarBuscadosParaReajuste(cboSector.SelectedValue.ToString(), GlobalesV1.Global_int_idoficina, 37);
                }
                ckbTodosContribuyentes.Checked = false;
                ckbTodosContribuyentes.Checked = true;
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

        private void ckbTodosContribuyentes_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int cantidad;
                cantidad = dgvContribuyenteBuscados.RowCount;
                for (int i = 0; i < cantidad; i++)
                {
                    DataGridViewRow row1 = dgvContribuyenteBuscados.Rows[i];
                    DataGridViewCheckBoxCell cellSelecion1 = row1.Cells["OpC"] as DataGridViewCheckBoxCell;
                    cellSelecion1.Value = ckbTodosContribuyentes.Checked;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void dgvContribuyenteBuscados_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvContribuyenteBuscados.IsCurrentCellDirty)
            {
                dgvContribuyenteBuscados.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void validadPersona(string perso, int anioini, int aniofin)
        {
            //while (anioini <= aniofin)
            //{
            if (rbtAmbos.Checked)
            {
                coleccionGeneral = CalculoPorPersonaAniosDataService.VerificarParametros(anioini.ToString(), aniofin.ToString(), perso);
                //List<TextBox> strTextBox = HelperControles.GetControls<TextBox>(this);
                //List<ComboBox> strComboBox = HelperControles.GetControls<ComboBox>(this);

                //List<string> strControles = new List<string>();

                //strControles =
                coleccionGeneral1.Union(coleccionGeneral);
            }
            else if (rbtArbitrio.Checked)
            {
                coleccionGeneralArb = CalculoPorPersonaAniosDataService.VerificarParametrosArb(anioini.ToString(), aniofin.ToString(), perso);

                coleccionGeneralArb1.Union(coleccionGeneralArb);
            }
            else
            {
                coleccionGeneralPredial = CalculoPorPersonaAniosDataService.VerificarParametrosPredial(anioini.ToString(), aniofin.ToString(), perso);

                coleccionGeneralPredial1.Union(coleccionGeneralPredial);
            }

        }
        private void calculaPersona(string perso, int anioini, int aniofin)
        {
            if (rbtAmbos.Checked)
            {
                //n,nombre,tributo,año,mesmfehcavence,cargo,abono,estado
                CalculoPorPersonaAniosDataService.CalculoArbitrioPredial(cboAnioIni.SelectedValue.ToString(), cboAnioFin.SelectedValue.ToString(), perso, GlobalesV1.Global_str_Usuario);

            }
            else if (rbtArbitrio.Checked)
            {
                CalculoPorPersonaAniosDataService.CalculoArbitrio(cboAnioIni.SelectedValue.ToString(), cboAnioFin.SelectedValue.ToString(), perso, GlobalesV1.Global_str_Usuario);

            }
            else
            {
                CalculoPorPersonaAniosDataService.CalculoPredial(cboAnioIni.SelectedValue.ToString(), cboAnioFin.SelectedValue.ToString(), perso, GlobalesV1.Global_str_Usuario);

            }
        }

        private void btnGenerarCalculoMasivo_Click_1(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                int cantidad;
                cantidad = dgvContribuyenteBuscados.RowCount;
                int id;
                bool bandera;
                int anioini = Convert.ToInt32(cboAnioIni.SelectedValue);
                int aniofin = Convert.ToInt32(cboAnioFin.SelectedValue);
                String perso = "";
                for (int i = 0; i < cantidad; i++)
                {
                    DataGridViewRow row = dgvContribuyenteBuscados.Rows[i];
                    DataGridViewCheckBoxCell cellSelecion = row.Cells["OpC"] as DataGridViewCheckBoxCell;
                    bandera = Convert.ToBoolean(cellSelecion.Value);
                    if (bandera)
                    {
                        perso = (String)row.Cells["persona_ID"].Value;
                        calculaPersona(perso, anioini, aniofin);
                    }
                }

                MessageBox.Show("Se genero cta cte!:)", Globales.Global_MessageBox);
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

        private void btnVerificar_Click_1(object sender, EventArgs e)
        {

            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                int cantidad;
                cantidad = dgvContribuyenteBuscados.RowCount;
                int id;
                bool bandera;
                int anioini = Convert.ToInt32(cboAnioIni.SelectedValue);
                int aniofin = Convert.ToInt32(cboAnioFin.SelectedValue);
                String perso = "";

                for (int i = 0; i < cantidad; i++)
                {
                    DataGridViewRow row = dgvContribuyenteBuscados.Rows[i];
                    DataGridViewCheckBoxCell cellSelecion = row.Cells["OpC"] as DataGridViewCheckBoxCell;
                    bandera = Convert.ToBoolean(cellSelecion.Value);
                    if (bandera)
                    {
                        perso = (String)row.Cells["persona_ID"].Value;
                        validadPersona(perso, anioini, aniofin);
                    }
                }
                if (rbtAmbos.Checked)
                {
                    if (coleccionGeneral1.Count == 0)
                    {
                        btnGenerarCalculoMasivo.Enabled = true;
                        MessageBox.Show("Se verificó correctamente", Globales.Global_MessageBox);
                    }
                    else
                    {
                        MessageBox.Show("Faltan parámetros", Globales.Global_MessageBox);
                        btnGenerarCalculoMasivo.Enabled = false;
                        Frm_Errores frm_Errores = new Frm_Errores(coleccionGeneral);
                        frm_Errores.StartPosition = FormStartPosition.CenterParent;
                        frm_Errores.Show();
                    }
                }
                else if (rbtArbitrio.Checked)
                {

                    if (coleccionGeneralArb1.Count == 0)
                    {
                        btnGenerarCalculoMasivo.Enabled = true;
                        MessageBox.Show("Se verificó correctamente", Globales.Global_MessageBox);
                    }
                    else
                    {
                        MessageBox.Show("Faltan parámetros", Globales.Global_MessageBox);
                        btnGenerarCalculoMasivo.Enabled = false;
                        Frm_Errores frm_Errores = new Frm_Errores(coleccionGeneralArb);
                        frm_Errores.StartPosition = FormStartPosition.CenterParent;
                        frm_Errores.Show();
                    }
                }
                else
                {
                    if (coleccionGeneralPredial1.Count == 0)
                    {
                        btnGenerarCalculoMasivo.Enabled = true;
                        MessageBox.Show("Se verificó correctamente", Globales.Global_MessageBox);
                    }
                    else
                    {
                        MessageBox.Show("Faltan parámetros", Globales.Global_MessageBox);
                        btnGenerarCalculoMasivo.Enabled = false;
                        Frm_Errores frm_Errores = new Frm_Errores(coleccionGeneralPredial);
                        frm_Errores.StartPosition = FormStartPosition.CenterParent;
                        frm_Errores.Show();
                    }
                }
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
                btnGenerarCalculoMasivo.Enabled = false;
            }
            catch (Exception ex)
            {
            }
        }

        private void cboAnioFin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
