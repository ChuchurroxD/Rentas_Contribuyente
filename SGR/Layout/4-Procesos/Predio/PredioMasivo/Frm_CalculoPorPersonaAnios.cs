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
namespace SGR.WinApp.Layout._4_Procesos.Predio.PredioMasivo
{
    public partial class Frm_CalculoPorPersonaAnios : DockContent
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
        public Frm_CalculoPorPersonaAnios()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }

        }
        private void limpiarParaBusqueda()
        {
            txtNDocu.Text = "";
            txtCodContribuyente.Text = "";
            txtNomRazon.Text = "";
        }
        private string CambiarTexto(string txt)
        {
            if (txt.TrimEnd() == "")
                return "%";
            return txt.TrimEnd();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();

        }
        private void buscar()
        {
            try    ///////      //
            {
                if (rbtNDoc.Checked)
                {
                    //listarBuscados
                    dgvContribuyenteBuscados.DataSource = mant_ContribuyenteDataService.listarBuscados('%' + txtNDocu.Text.Trim() + '%', 17, "ruc", GlobalesV1.Global_int_idoficina);
                }
                else
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
                }
                //dgvPredio.DataSource = new List<Pred_Predio>();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Globales.Global_MessageBox);
            }
        }
        private void dgvContribuyenteBuscados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (Cursor.Current == Cursors.WaitCursor)
            //    return;
            //Cursor.Current = Cursors.WaitCursor;
            //try
            //{
            //    if (dgvContribuyenteBuscados.Columns[e.ColumnIndex].Name == "xpredio" && dgvContribuyenteBuscados.RowCount > 0)
            //    {
            //        //String perso = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["persona_ID"].Value;
            //        //Coleccion = FiscalizacionDataService.listarprediosUltiosHistoricos(perso, Convert.ToInt32(cboPeriodo.SelectedValue));
            //        //dgvPredio.DataSource = Coleccion;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            //}
            //finally
            //{
            //    Cursor.Current = Cursors.Default;
            //}
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
            try
            {
                string texto = txtNDocu.Text.TrimEnd();
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    if (texto.Length != 0 && rbtNDoc.Checked)
                        listarBuscado(texto, "", "");
                }
                else
                {
                    texto = texto + e.KeyChar.ToString();
                    if (texto.Length != 0 && rbtNDoc.Checked)
                        listarBuscado(texto, "", "");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void txtCodContribuyente_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                string texto = txtCodContribuyente.Text.TrimEnd();
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    if (texto.Length != 0 && rbtCodContribuyente.Checked)
                        listarBuscado("", texto, "");
                }
                else
                {
                    texto = texto + e.KeyChar.ToString();
                    if (texto.Length != 0 && rbtCodContribuyente.Checked)
                        listarBuscado("", texto, "");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void txtNomRazon_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space) && !(char.IsControl(e.KeyChar)))
                {
                    MessageBox.Show("Solo se permiten letras", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
                string texto = txtNomRazon.Text.TrimEnd();
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    if (texto.Length != 0 && rbtNombre.Checked)
                        listarBuscado("", "", texto);
                }
                else
                {
                    texto = texto + e.KeyChar.ToString();
                    if (texto.Length != 0 && rbtNombre.Checked)
                        listarBuscado("", "", texto);
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
                int tipo;
                if (rbtNDoc.Checked)
                    tipo = 27;
                else if (rbtCodContribuyente.Checked)
                    tipo = 28;
                else
                    tipo = 29;
                dgvContribuyenteBuscados.DataSource = mant_ContribuyenteDataService.listarSoloCOntribuyente(doc, cod, name, tipo);
            }
            catch (Exception ex)
            {

            }
        }
        private void btnGenerarCalculoMasivo_Click(object sender, EventArgs e)
        {

            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (dgvContribuyenteBuscados.SelectedRows.Count > 0)
                {

                    String perso = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["persona_ID"].Value;
                    int anioini = Convert.ToInt32(cboAnioIni.SelectedValue);
                    int aniofin = Convert.ToInt32(cboAnioFin.SelectedValue);
                    //while (anioini <= aniofin)
                    //{
                    if (rbtAmbos.Checked)
                    {
                        //n,nombre,tributo,año,mesmfehcavence,cargo,abono,estado
                        CalculoPorPersonaAniosDataService.CalculoArbitrioPredial(cboAnioIni.SelectedValue.ToString(), cboAnioFin.SelectedValue.ToString(), perso, registro_user);
                        if (dgvCtaCorriente.RowCount > 0)
                            dgvCtaCorriente.Rows.Clear();
                        coleccionCta1 = Proc_CuentaCorritenteDataService.listarPredialArbxPersona(perso, "0043");
                        coleccionCta2 = Proc_CuentaCorritenteDataService.listarPredialArbIndiv(perso, "0008", 2, "");
                        for (int i = 0; i < coleccionCta1.Count; i++)
                        {
                            dgvCtaCorriente.Rows.Add(coleccionCta1[i].cuenta_corriente_ID, coleccionCta1[i].nombre, coleccionCta1[i].tributo, coleccionCta1[i].anio,
                                coleccionCta1[i].mes, coleccionCta1[i].fecha_vence, coleccionCta1[i].cargo, coleccionCta1[i].abono, coleccionCta1[i].estado,
                                coleccionCta1[i].predioId);
                        }
                        for (int i = 0; i < coleccionCta2.Count; i++)
                        {
                            dgvCtaCorriente.Rows.Add(coleccionCta2[i].cuenta_corriente_ID, coleccionCta2[i].nombre, coleccionCta2[i].tributo, coleccionCta2[i].anio,
                                coleccionCta2[i].mes, coleccionCta2[i].fecha_vence, coleccionCta2[i].cargo, coleccionCta2[i].abono, coleccionCta2[i].estado,
                                coleccionCta2[i].predioId);
                        }
                    }
                    else if (rbtArbitrio.Checked)
                    {
                        CalculoPorPersonaAniosDataService.CalculoArbitrio(cboAnioIni.SelectedValue.ToString(), cboAnioFin.SelectedValue.ToString(), perso, registro_user);
                        coleccionCta1 = Proc_CuentaCorritenteDataService.listarPredialArbxPersona(perso, "0043");
                        if (dgvCtaCorriente.RowCount > 0)
                            dgvCtaCorriente.Rows.Clear();
                        for (int i = 0; i < coleccionCta1.Count; i++)
                        {
                            dgvCtaCorriente.Rows.Add(coleccionCta1[i].cuenta_corriente_ID, coleccionCta1[i].nombre, coleccionCta1[i].tributo, coleccionCta1[i].anio,
                                coleccionCta1[i].mes, coleccionCta1[i].fecha_vence, coleccionCta1[i].cargo, coleccionCta1[i].abono, coleccionCta1[i].estado,
                                coleccionCta1[i].predioId);
                        }
                    }
                    else
                    {
                        CalculoPorPersonaAniosDataService.CalculoPredial(cboAnioIni.SelectedValue.ToString(), cboAnioFin.SelectedValue.ToString(), perso, registro_user);
                        coleccionCta2 = Proc_CuentaCorritenteDataService.listarPredialArbIndiv(perso, "0008", 2, "");
                        if (dgvCtaCorriente.RowCount > 0)
                            dgvCtaCorriente.Rows.Clear();
                        for (int i = 0; i < coleccionCta2.Count; i++)
                        {
                            dgvCtaCorriente.Rows.Add(coleccionCta2[i].cuenta_corriente_ID, coleccionCta2[i].nombre, coleccionCta2[i].tributo, coleccionCta2[i].anio,
                                coleccionCta2[i].mes, coleccionCta2[i].fecha_vence, coleccionCta2[i].cargo, coleccionCta2[i].abono, coleccionCta2[i].estado,
                                coleccionCta2[i].predioId);
                        }
                    }
                    MessageBox.Show("Se gnero cta cte!:)", Globales.Global_MessageBox);
                }
                else
                    MessageBox.Show("Seleccione un contribuyente", Globales.Global_MessageBox);
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
                if (dgvCtaCorriente.RowCount > 0)
                    dgvCtaCorriente.Rows.Clear();
            }
            catch (Exception ex)
            {
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {

            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (dgvContribuyenteBuscados.SelectedRows.Count > 0)
                {

                    String perso = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["persona_ID"].Value;
                    int anioini = Convert.ToInt32(cboAnioIni.SelectedValue);
                    int aniofin = Convert.ToInt32(cboAnioFin.SelectedValue);
                    //while (anioini <= aniofin)
                    //{
                    if (rbtAmbos.Checked)
                    {
                        coleccionGeneral = CalculoPorPersonaAniosDataService.VerificarParametros(cboAnioIni.SelectedValue.ToString(), cboAnioFin.SelectedValue.ToString(), perso);
                    }
                    else if (rbtArbitrio.Checked)
                    {
                        coleccionGeneralArb = CalculoPorPersonaAniosDataService.VerificarParametrosArb(cboAnioIni.SelectedValue.ToString(), cboAnioFin.SelectedValue.ToString(), perso);
                    }
                    else
                    {
                        coleccionGeneralPredial = CalculoPorPersonaAniosDataService.VerificarParametrosPredial(cboAnioIni.SelectedValue.ToString(), cboAnioFin.SelectedValue.ToString(), perso);
                    }
                    //    anioini++;
                    //}
                    if (rbtAmbos.Checked)
                    {
                        if (coleccionGeneral.Count == 0)
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

                        if (coleccionGeneralArb.Count == 0)
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
                        if (coleccionGeneralPredial.Count == 0)
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
                else
                    MessageBox.Show("No se selecciono un contribuyente", Globales.Global_MessageBox);
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

        private void rbtPredio_CheckedChanged(object sender, EventArgs e)
        {
            btnGenerarCalculoMasivo.Enabled = false;
            if (dgvCtaCorriente.RowCount > 0)
                dgvCtaCorriente.Rows.Clear();
        }

        private void rbtArbitrio_CheckedChanged(object sender, EventArgs e)
        {
            btnGenerarCalculoMasivo.Enabled = false;
            if (dgvCtaCorriente.RowCount > 0)
                dgvCtaCorriente.Rows.Clear();
        }

        private void rbtAmbos_CheckedChanged(object sender, EventArgs e)
        {
            btnGenerarCalculoMasivo.Enabled = false;
            if (dgvCtaCorriente.RowCount > 0)
                dgvCtaCorriente.Rows.Clear();
        }

        private void cboAnioFin_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGenerarCalculoMasivo.Enabled = false;
            if (dgvCtaCorriente.RowCount > 0)
                dgvCtaCorriente.Rows.Clear();
        }
    }
}
