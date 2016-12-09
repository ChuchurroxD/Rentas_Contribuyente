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
    public partial class Frm_PredioContribuyente_Detalle : Form
    {
        private Pred_PredioContribuyenteDataService Pred_PredioContribuyenteDataService = new Pred_PredioContribuyenteDataService();
        private Conf_MultitablaDataService conf_MultitablaDataService = new Conf_MultitablaDataService();
        private Mant_PeriodoDataService mant_PeriodoDataService = new Mant_PeriodoDataService();
        Pago_PersonaDataService persona = new Pago_PersonaDataService();
        private Sistema.Globales.Validaciones obValidacion = new Sistema.Globales.Validaciones();
        Decimal porcen;
        private String Predio_Idd = "";
        private int periodo = 0, caso = 0;
        private String usser = GlobalesV1.Global_str_Usuario, persona_id;
        public Frm_PredioContribuyente_Detalle()
        {
            InitializeComponent();
            listarTipoSelector();
            listarPersona();
            this.Predio_Idd = "0";
            txtAñoDeCompra.MaxLength = 4;
        }
        public Frm_PredioContribuyente_Detalle(String predioId, String periodos, String p_id)
        {
            try
            {
                InitializeComponent();
                this.Predio_Idd = predioId;
                periodo = Convert.ToInt32(periodos);
                listarTipoSelector();
                caso = 1;
                cboPeriodo.SelectedValue = Convert.ToInt32(periodos);
                cboPeriodo.Enabled = false;
                txtAñoDeCompra.MaxLength = 4;
                //cboPersona.SelectedValue = p_id;
                this.persona_id = p_id;
                DateTime fechaHoy = DateTime.Now;
                dtpFecha.MaxDate = fechaHoy;
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, Globales.Global_MessageBox);
            }
        }
        public Frm_PredioContribuyente_Detalle(String predioId, String periodos)
        {
            try
            {
                InitializeComponent();
                periodo = Convert.ToInt32(periodos);
                listarTipoSelector();
                caso = 2;
                this.Predio_Idd = predioId;
                cboPeriodo.SelectedValue = Convert.ToInt32(periodos);
                cboPeriodo.Enabled = false;
                txtAñoDeCompra.MaxLength = 4;
                DateTime fechaHoy = DateTime.Now;
                dtpFecha.MaxDate = fechaHoy;
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, Globales.Global_MessageBox);
            }

        }
        public Frm_PredioContribuyente_Detalle(Pred_PredioContribuyente Pred_PredioContribuyente)
        {
            try
            {
                InitializeComponent();
                listarTipoSelector();
                caso = 3;
                cargarDatos(Pred_PredioContribuyente);
                cboPeriodo.Enabled = false;
                this.persona_id = Pred_PredioContribuyente.persona_ID;
                //listarPersonaM(Predio_Idd, persona_id, txtBusqueda.Text.TrimEnd());
                //cboPersona.SelectedValue = persona_id.Trim();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, Globales.Global_MessageBox);
            }

        }
        private void listarTipoSelector()
        {
            cboPeriodo.DisplayMember = "Peric_canio";
            cboPeriodo.ValueMember = "Peric_canio";
            cboPeriodo.DataSource = mant_PeriodoDataService.llenarPeriodo();
            llenarCboMultitabla(cboTipoAdquisicion, "Multc_vDescripcion", "Multc_cValor", "4");
            llenarCboMultitabla(cboTipoPosesion, "Multc_vDescripcion", "Multc_cValor", "18");
            //llenarCboMultitabla(cboTipoContribuyente, "Multc_vDescripcion", "Multc_cValor", "75");
        }
        private void listarPersona()
        {
            cboPersona.DisplayMember = "persona_Desc";
            cboPersona.ValueMember = "persona_ID";
            cboPersona.DataSource = persona.listarcontribuyentes("");
            this.cboPersona.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.cboPersona.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void listarPersonaN(String predio_id, string busqueda)
        {
            cboPersona.DisplayMember = "persona_Desc";
            cboPersona.ValueMember = "persona_ID";
            cboPersona.DataSource = persona.listarcontribuyentesPN(predio_id, periodo, busqueda); ;
            this.cboPersona.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.cboPersona.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void listarPersonaM(String predio_id, String per_id, string busqueda)
        {
            cboPersona.DisplayMember = "persona_Desc";
            cboPersona.ValueMember = "persona_ID";
            cboPersona.DataSource = persona.listarcontribuyentesPM(predio_id, periodo, per_id, busqueda);
            this.cboPersona.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.cboPersona.AutoCompleteSource = AutoCompleteSource.CustomSource;
            if (per_id.Trim().Length > 0)
                cboPersona.SelectedValue = per_id.Trim();
        }
        private void llenarCboMultitabla(ComboBox cbo, String display, String valor, String tipo)
        {
            cbo.DisplayMember = display;
            cbo.ValueMember = valor;
            cbo.DataSource = conf_MultitablaDataService.GetCboConf_Multitabla(tipo);
        }
        private void cargarDatos(Pred_PredioContribuyente Pred_PredioContribuyente)
        {
            txtBusqueda.Text = Pred_PredioContribuyente.razon_social;
            txtAñoDeCompra.Text = Pred_PredioContribuyente.AnioCompra.ToString();
            txtExpediente.Text = Pred_PredioContribuyente.expediente;
            txtObservacion.Text = Pred_PredioContribuyente.observaciones;
            //cboPersona.SelectedValue = Pred_PredioContribuyente.persona_ID;
            txtPorcentajeContenido.Text = Pred_PredioContribuyente.Porcentaje_Condomino.ToString();
            txtPredioContribuyente.Text = Pred_PredioContribuyente.predio_contribuyente_id.ToString();
            this.Predio_Idd = Pred_PredioContribuyente.Predio_id.ToString();
            ckbActivo.Checked = Pred_PredioContribuyente.estado;
            //ckbExonerado.Checked = Pred_PredioContribuyente.ExonAutoValuo;
            dtpFecha.Value = Pred_PredioContribuyente.Fecha;
            cboTipoAdquisicion.SelectedValue = Pred_PredioContribuyente.tipo_adquisicion.ToString();
            cboTipoPosesion.SelectedValue = Pred_PredioContribuyente.tipo_posesion.ToString();
            cboPeriodo.SelectedValue = Convert.ToInt32(Pred_PredioContribuyente.idPeriodo);
            porcen = Pred_PredioContribuyente.Porcentaje_Condomino;
            cboPersona.Enabled = true;
            listarPersonaM(Predio_Idd, Pred_PredioContribuyente.persona_ID, Pred_PredioContribuyente.razon_social.TrimEnd());
            cboPersona.SelectedValue = Pred_PredioContribuyente.persona_ID.Trim();

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
                if (txtAñoDeCompra.Text.Trim().Length > 0 && txtExpediente.Text.Trim().Length > 0 && txtPorcentajeContenido.Text.Trim().Length > 0)
                {
                    //if (obValidacion.validaAnio(txtAñoDeCompra.Text))
                    //{
                    //    MessageBox.Show("Año de Compra invalido", Globales.Global_MessageBox);
                    //    return;
                    //}
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
                        Pred_PredioContribuyentee.AnioCompra = Convert.ToInt32(txtAñoDeCompra.Text.Trim());
                        Pred_PredioContribuyentee.estado = ckbActivo.Checked;
                        Pred_PredioContribuyentee.tipo_adquisicion = Convert.ToInt32(cboTipoAdquisicion.SelectedValue);
                        Pred_PredioContribuyentee.tipo_posesion = Convert.ToInt32(cboTipoPosesion.SelectedValue);
                        Pred_PredioContribuyentee.expediente = txtExpediente.Text.Trim();
                        Pred_PredioContribuyentee.observaciones = txtObservacion.Text.Trim();
                        Pred_PredioContribuyentee.registro_user_add = usser;
                        Pred_PredioContribuyentee.idPeriodo = Convert.ToInt16(cboPeriodo.SelectedValue.ToString());
                        Pred_PredioContribuyentee.Predio_id = Predio_Idd;
                        Pred_PredioContribuyentee.persona_ID = cboPersona.SelectedValue.ToString();
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
                            Pred_PredioContribuyenteDataService.Insert(Pred_PredioContribuyentee);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtPorcentajeContenido_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.ValidarNumeroDecimal(e, txtPorcentajeContenido.Text, Globales.Global_MessageBox);
        }

        private void txtAñoDeCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.validaNumeroEntero(e, Globales.Global_MessageBox);
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

        private void cboPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cboPersona.SelectedValue.ToString()+"__");
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            txtAñoDeCompra.Text = dtpFecha.Value.Year.ToString();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBusqueda.Text.TrimEnd().Length != 0)
                {

                    cboPersona.Enabled = true;
                    if (caso == 1)
                    {
                        listarPersonaN(Predio_Idd, txtBusqueda.Text.TrimEnd());
                        cboPersona.SelectedValue = persona_id;
                    }
                    else if (caso == 2)
                    {
                        listarPersonaN(Predio_Idd, txtBusqueda.Text.TrimEnd());
                    }
                    else if
                        (caso == 3)
                    {
                        listarPersonaM(Predio_Idd, persona_id, txtBusqueda.Text.TrimEnd());
                        cboPersona.SelectedValue = persona_id;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
    }
}
