using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using SGR.Core.Service.Combos;
using SGR.Entity.Model.Combos;
using System.Windows.Forms;
using SGR.Core.Service;
using SGR.Entity.Model;

namespace SGR.WinApp.Layout._4_Procesos.Predio.PredioContribuyente
{
    public partial class Frm_PredioContribuyenteAnterior_Detalle : Form
    {
        private Pred_PredioContribuyenteDataService Pred_PredioContribuyenteDataService = new Pred_PredioContribuyenteDataService();
        private Conf_MultitablaDataService conf_MultitablaDataService = new Conf_MultitablaDataService();
        private Mant_PeriodoDataService mant_PeriodoDataService = new Mant_PeriodoDataService();
        Pago_PersonaDataService persona = new Pago_PersonaDataService();
        private Sistema.Globales.Validaciones obValidacion = new Sistema.Globales.Validaciones();
        Decimal porcen;
        private int periodoIni = 0, periodoFin = 0;
        private String usser = GlobalesV1.Global_str_Usuario;
        private string predio_id = "", persona_id;
        public Frm_PredioContribuyenteAnterior_Detalle()
        {
            InitializeComponent();
        }
        public Frm_PredioContribuyenteAnterior_Detalle(int periodoIni, int periodoFin, String persona_id, String predio_ii)
        {
            try
            {
                InitializeComponent();
                listarTipoSelector();
                //listarPersona();
                dtpFecha.MinDate = Convert.ToDateTime("01-01-" + (periodoIni - 1));
                dtpFecha.MaxDate = Convert.ToDateTime("31-12-" + (periodoIni - 1));
                this.persona_id = persona_id;
                this.periodoIni = periodoIni;
                this.periodoFin = periodoFin;
                this.predio_id = predio_ii;
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, Globales.Global_MessageBox);
            }
        }
        private void listarTipoSelector()
        {
            llenarCboMultitabla(cboTipoAdquisicion, "Multc_vDescripcion", "Multc_cValor", "4");
            llenarCboMultitabla(cboTipoPosesion, "Multc_vDescripcion", "Multc_cValor", "18");
            //llenarCboMultitabla(cboTipoContribuyente, "Multc_vDescripcion", "Multc_cValor", "75");
        }
        private void listarPersona(string busqueda)
        {
            cboPersona.DisplayMember = "persona_Desc";
            cboPersona.ValueMember = "persona_ID";
            cboPersona.DataSource = persona.listarcontribuyentes(busqueda);
            this.cboPersona.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.cboPersona.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void llenarCboMultitabla(ComboBox cbo, String display, String valor, String tipo)
        {
            cbo.DisplayMember = display;
            cbo.ValueMember = valor;
            cbo.DataSource = conf_MultitablaDataService.GetCboConf_Multitabla(tipo);
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (cboPersona.SelectedIndex < 0)
            {
                MessageBox.Show("Escoja una persona por favor", Globales.Global_MessageBox);
                return;
            }
            Pred_PredioContribuyente PredioContribuyente = new Pred_PredioContribuyente();
            decimal porcentaje;
            try
            {
                if (Convert.ToDecimal(txtPorcentajeContenido.Text) > 100)
                {
                    MessageBox.Show("Porcentaje se excedió del 100%", Globales.Global_MessageBox);
                    return;
                }
                if (txtExpediente.Text.Trim().Length > 0 && txtPorcentajeContenido.Text.Trim().Length > 0)
                {
                    if (obValidacion.validaNumeroDecimalValido(txtPorcentajeContenido.Text))
                    {
                        MessageBox.Show("Porcentaje de Condomino invalido", Globales.Global_MessageBox);
                        return;
                    }

                    if (MessageBox.Show("Desea Grabar?", Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Pred_PredioContribuyente Pred_PredioContribuyentee = new Pred_PredioContribuyente();
                        Pred_PredioContribuyentee.Fecha = dtpFecha.Value;
                        Pred_PredioContribuyentee.Porcentaje_Condomino = Convert.ToDecimal(txtPorcentajeContenido.Text.Trim());
                        Pred_PredioContribuyentee.ExonAutoValuo = false;//ckbExonerado.Checked;
                        //Pred_PredioContribuyentee.AnioCompra = Convert.ToInt32(txtAñoDeCompra.Text.Trim());
                        Pred_PredioContribuyentee.estado = ckbActivo.Checked;
                        Pred_PredioContribuyentee.tipo_adquisicion = Convert.ToInt32(cboTipoAdquisicion.SelectedValue);
                        Pred_PredioContribuyentee.tipo_posesion = Convert.ToInt32(cboTipoPosesion.SelectedValue);
                        Pred_PredioContribuyentee.expediente = txtExpediente.Text.Trim();
                        Pred_PredioContribuyentee.observaciones = txtObservacion.Text.Trim();
                        Pred_PredioContribuyentee.registro_user_add = usser;
                        //Pred_PredioContribuyentee.idPeriodo = Convert.ToInt16(cboPeriodo.SelectedValue.ToString());
                        Pred_PredioContribuyentee.Predio_id = predio_id;
                        Pred_PredioContribuyentee.persona_ID = cboPersona.SelectedValue.ToString();
                        Pred_PredioContribuyentee.idPeriodo = Convert.ToInt16(periodoIni);
                        if (txtPredioContribuyente.Text.Trim().Length == 0)//nuevo
                        {

                            Pred_PredioContribuyentee.predio_contribuyente_id = 0;
                            //porcentaje = Pred_PredioContribuyenteDataService.GetPorcentajexPredio(Pred_PredioContribuyentee.Predio_id) + Pred_PredioContribuyentee.Porcentaje_Condomino;
                            //if (porcentaje > 100)
                            //{
                            //    MessageBox.Show("Se paso de porcentaje de condominio", Globales.Global_MessageBox);
                            //}
                            //else
                            //{
                            Pred_PredioContribuyenteDataService.InsertVariosAños(Pred_PredioContribuyentee, periodoFin);
                            //Pred_PredioContribuyenteDataService.Insert(Pred_PredioContribuyentee);
                            MessageBox.Show("Se Grabó Correctamente", Globales.Global_MessageBox);
                            //}
                            this.Close();
                        }
                        else
                        {
                            Pred_PredioContribuyentee.predio_contribuyente_id = int.Parse(txtPredioContribuyente.Text.Trim());
                            //porcentaje = Pred_PredioContribuyenteDataService.GetPorcentajexPredio(Pred_PredioContribuyentee.Predio_id)+ Pred_PredioContribuyentee.Porcentaje_Condomino- porcen;
                            //if (porcentaje > 100)
                            //{
                            //    MessageBox.Show("Se paso de porcentaje de condominio", Globales.Global_MessageBox);
                            //}
                            //else
                            //{
                            Pred_PredioContribuyenteDataService.Update(Pred_PredioContribuyentee);
                            MessageBox.Show("Se Grabó Correctamente", Globales.Global_MessageBox);
                            //}
                            this.Close();
                        }
                    }
                }
                else MessageBox.Show("El expediente, año de compra y porcentaje de condominio es obligatorio", Globales.Global_MessageBox);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    BtnBuscar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBusqueda.Text.TrimEnd().Length != 0)
                {
                    cboPersona.Enabled = true;
                    listarPersona(txtBusqueda.Text.TrimEnd());
                    cboPersona.SelectedValue = persona_id;
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtPorcentajeContenido_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.ValidarNumeroDecimal(e, txtPorcentajeContenido.Text, Globales.Global_MessageBox);
        }
    }
}
