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
using SGR.Entity;
using SGR.Entity.Model;
using SGR.Core.Service;
namespace SGR.WinApp.Layout._4_Procesos.Predio.Pisos
{
    public partial class Frm_Pisos_Detalle : Form
    {
        private Pred_PisosDataService PisosDataService = new Pred_PisosDataService();
        private Conf_MultitablaDataService conf_MultitablaDataService = new Conf_MultitablaDataService();
        private Pred_Predio Predio = new Pred_Predio();
        Pago_PersonaDataService persona = new Pago_PersonaDataService();
        private Sistema.Globales.Validaciones obValidacion = new Sistema.Globales.Validaciones();
        private String Predio_Idd = "";
        private Mant_PeriodoDataService PeriodoDataService = new Mant_PeriodoDataService();
        private Mant_PeriodoDataService mant_PeriodoDataService = new Mant_PeriodoDataService();
        private string usser = GlobalesV1.Global_str_Usuario;
        private int periodo = 0, periodofin = 0;
        public Frm_Pisos_Detalle()
        {
            InitializeComponent();
            listarTipoSelector("0");

            cargarAutoCBo();
            ckbActivo.Visible = false;
            this.Predio_Idd = "0";
            txtanio.MaxLength = 4;
        }
        public Frm_Pisos_Detalle(String idPredio, int periodoo)
        {
            InitializeComponent();
            this.periodo = periodoo;
            listarTipoSelector(idPredio);

            cargarAutoCBo();
            ckbActivo.Visible = false;
            this.Predio_Idd = idPredio;
            txtanio.MaxLength = 4;
            DateTime fechaHoy = DateTime.Now;
            dtpFConstruccion.Value = fechaHoy;
            dtpFConstruccion.MaxDate = fechaHoy;

        }

        public Frm_Pisos_Detalle(String idPredio, int periodoo, int periodofin)
        {
            InitializeComponent();
            this.periodo = periodoo;
            this.periodofin = periodofin;
            listarTipoSelector(idPredio);
            cargarAutoCBo();
            ckbActivo.Visible = false;
            this.Predio_Idd = idPredio;
            txtanio.MaxLength = 4;
            DateTime fechaHoy = DateTime.Now;
            dtpFConstruccion.Value = fechaHoy;
            dtpFConstruccion.MaxDate = fechaHoy;
        }
        public Frm_Pisos_Detalle(Pred_Pisos Pred_pisosss, int periodoo)
        {
            InitializeComponent();
            this.periodo = periodoo;
            listarTipoSelector(Pred_pisosss.predio_ID);
            cargarAutoCBo();
            cargarElementos(Pred_pisosss);
            ckbActivo.Visible = true;
            DateTime fechaHoy = DateTime.Now;
            dtpFConstruccion.MaxDate = fechaHoy;
        }
        private void cargarAutoCBo()
        {

            this.cboMuro.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.cboMuro.AutoCompleteSource = AutoCompleteSource.CustomSource;

            this.cboTecho.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.cboTecho.AutoCompleteSource = AutoCompleteSource.CustomSource;

            this.cboPiso.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.cboPiso.AutoCompleteSource = AutoCompleteSource.CustomSource;

            this.cboPuerta.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.cboPuerta.AutoCompleteSource = AutoCompleteSource.CustomSource;

            this.cboRevestimiento.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.cboRevestimiento.AutoCompleteSource = AutoCompleteSource.CustomSource;

            this.cboBaño.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.cboBaño.AutoCompleteSource = AutoCompleteSource.CustomSource;

            this.cboInstalaciones.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.cboInstalaciones.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }
        private void cargarElementos(Pred_Pisos Pred_pisosss)
        {
            cboBaño.SelectedValue = Pred_pisosss.banio;
            cboInstalaciones.SelectedValue = Pred_pisosss.instalaciones;
            cboMuro.SelectedValue = Pred_pisosss.muro;
            cboPiso.SelectedValue = Pred_pisosss.piso;
            cboPuerta.SelectedValue = Pred_pisosss.puerta;
            cboRevestimiento.SelectedValue = Pred_pisosss.revestimiento;
            cboTecho.SelectedValue = Pred_pisosss.techo;
            cboClasificacion.SelectedValue = Pred_pisosss.clasificacion_id.Trim();
            cboMaterial.SelectedValue = Pred_pisosss.material_id.Trim();
            cboEstadoPiso.SelectedValue = Pred_pisosss.estado_id.Trim();
            cboCondicion.SelectedValue = Pred_pisosss.condicion_id.Trim();
            txtAreaComun.Text = Pred_pisosss.area_comun.ToString();
            txtAreaConstruida.Text = Pred_pisosss.area_construida.ToString();
            txtMetrosAlquilados.Text = Pred_pisosss.metros_alquilados.ToString();
            cboPersona.SelectedValue = Pred_pisosss.persona_ID;
            txtPisoId.Text = Pred_pisosss.piso_ID.ToString();
            txtAntiguedad.Text = Pred_pisosss.antiguedad.ToString();
            //txtPorcentajeDepreciacion.Text = Pred_pisosss.porcent_depreci.ToString();
            //txtValorComun.Text = Pred_pisosss.valor_comun.ToString();
            //txtValorConstruido.Text = Pred_pisosss.valor_construido.ToString();
            //txtValorConstruidoTotal.Text = Pred_pisosss.valor_construido_total.ToString();
            //txtValorUnitario.Text = Pred_pisosss.valor_unitario.ToString();
            //txtValorUnitarioDepreciacion.Text = Pred_pisosss.valor_unit_depreciado.ToString();
            ckbActivo.Checked = Pred_pisosss.estado;
            //cboAntiguedad.SelectedValue = Pred_pisosss.antiguedad_id.Trim();
            txtSeccion.Text = Pred_pisosss.seccion;
            txtnumero.Text = Pred_pisosss.numero.ToString();
            txtIncremento.Text = Pred_pisosss.incremento.ToString();
            txtanio.Text = Pred_pisosss.anio.ToString();
            dtpFConstruccion.Value = Pred_pisosss.fecha_construc;
            this.Predio_Idd = Pred_pisosss.predio_ID;
            //if (cboAntiguedad.SelectedIndex == -1)
            //    cboAntiguedad.SelectedIndex = 0;
            if (cboBaño.SelectedIndex == -1)
                cboBaño.SelectedIndex = 0;
            if (cboClasificacion.SelectedIndex == -1)
                cboClasificacion.SelectedIndex = 0;
            if (cboCondicion.SelectedIndex == -1)
                cboCondicion.SelectedIndex = 0;
            if (cboEstadoPiso.SelectedIndex == -1)
                cboEstadoPiso.SelectedIndex = 0;
            if (cboInstalaciones.SelectedIndex == -1)
                cboInstalaciones.SelectedIndex = 0;
            if (cboMaterial.SelectedIndex == -1)
                cboMaterial.SelectedIndex = 0;
            if (cboMuro.SelectedIndex == -1)
                cboMuro.SelectedIndex = 0;
            if (cboPersona.SelectedIndex == -1)
                cboPersona.SelectedIndex = 0;
            if (cboPiso.SelectedIndex == -1)
                cboPiso.SelectedIndex = 0;
            if (cboPuerta.SelectedIndex == -1)
                cboPuerta.SelectedIndex = 0;
            if (cboRevestimiento.SelectedIndex == -1)
                cboRevestimiento.SelectedIndex = 0;
            if (cboTecho.SelectedIndex == -1)
                cboTecho.SelectedIndex = 0;

        }
        private void listarTipoSelector(String predio_id)
        {
            llenarCboMultitabla(cboBaño, "Multc_vDescripcion", "Multc_vDescripcion", "68");
            llenarCboMultitabla(cboInstalaciones, "Multc_vDescripcion", "Multc_vDescripcion", "68");
            llenarCboMultitabla(cboMuro, "Multc_vDescripcion", "Multc_vDescripcion", "68");
            llenarCboMultitabla(cboPiso, "Multc_vDescripcion", "Multc_vDescripcion", "68");
            llenarCboMultitabla(cboPuerta, "Multc_vDescripcion", "Multc_vDescripcion", "68");
            llenarCboMultitabla(cboRevestimiento, "Multc_vDescripcion", "Multc_vDescripcion", "68");
            llenarCboMultitabla(cboTecho, "Multc_vDescripcion", "Multc_vDescripcion", "68");
            llenarCboMultitabla(cboClasificacion, "Multc_vDescripcion", "Multc_cValor", "20");
            llenarCboMultitabla(cboMaterial, "Multc_vDescripcion", "Multc_cValor", "21");
            llenarCboMultitabla(cboEstadoPiso, "Multc_vDescripcion", "Multc_cValor", "22");
            llenarCboMultitabla(cboCondicion, "Multc_vDescripcion", "Multc_cValor", "34");
            //llenarCboMultitabla(cboAntiguedad, "Multc_vDescripcion", "Multc_cValor", "71");
            cboPersona.DisplayMember = "persona_Desc";
            cboPersona.ValueMember = "persona_ID";
            //cboPersona.DataSource = persona.listarpersonaxID(predio_id.Trim(), PeriodoDataService.GetPeriodoActivo()); periodo
            cboPersona.DataSource = persona.listarpersonaxID(predio_id.Trim(), periodo);

        }
        private void llenarCboMultitabla(ComboBox cbo, String display, String valor, String tipo)
        {
            cbo.DisplayMember = display;
            cbo.ValueMember = valor;
            cbo.DataSource = conf_MultitablaDataService.GetCboConf_Multitabla(tipo);
        }
        private void visibleElem(bool visi)
        {
            //txtId.Visible = false;
            //txtPredioId.Visible = false;
            //ckbEStado.Visible = visi;
        }
        private void Frm_Pisos_Detalle_Load(object sender, EventArgs e)
        {

        }
        private string Verificar(string dato)
        {
            //lblAntiguedad.ForeColor = System.Drawing.Color.Black;
            lblAreaComun.ForeColor = System.Drawing.Color.Black;
            lblAreaConstruida.ForeColor = System.Drawing.Color.Black;
            lblAño.ForeColor = System.Drawing.Color.Black;
            lblBaño.ForeColor = System.Drawing.Color.Black;
            lblClasificacion.ForeColor = System.Drawing.Color.Black;
            lblCondicion.ForeColor = System.Drawing.Color.Black;
            lblEstadoPiso.ForeColor = System.Drawing.Color.Black;
            lblIncremento.ForeColor = System.Drawing.Color.Black;
            lblInstalaciones.ForeColor = System.Drawing.Color.Black;
            lblMaterial.ForeColor = System.Drawing.Color.Black;
            lblMetrosAlquilados.ForeColor = System.Drawing.Color.Black;
            lblMuro.ForeColor = System.Drawing.Color.Black;
            lblNumero.ForeColor = System.Drawing.Color.Black;
            lblPiso.ForeColor = System.Drawing.Color.Black;
            lblPuerta.ForeColor = System.Drawing.Color.Black;
            lblRevestimiento.ForeColor = System.Drawing.Color.Black;
            lblSeccion.ForeColor = System.Drawing.Color.Black;
            lblTecho.ForeColor = System.Drawing.Color.Black;
            if (txtAreaComun.Text.Trim().Length == 0)
            {
                dato = dato + "Área común,";
                lblAreaComun.ForeColor = System.Drawing.Color.Red;
            }
            if (txtAreaConstruida.Text.Trim().Length == 0)
            {
                dato = dato + " Área construido,";
                lblAreaConstruida.ForeColor = System.Drawing.Color.Red;

            }
            if (txtMetrosAlquilados.Text.Trim().Length == 0)
            {
                dato = dato + " Metros Alquilados,";
                lblMetrosAlquilados.ForeColor = System.Drawing.Color.Red;
            }
            if (txtSeccion.Text.Trim().Length == 0)
            {
                dato = dato + " Sección,";
                lblSeccion.ForeColor = System.Drawing.Color.Red;
            }
            if (txtnumero.Text.Trim().Length == 0)
            {
                dato = dato + " Número,";
                lblNumero.ForeColor = System.Drawing.Color.Red;
            }
            if (txtIncremento.Text.Trim().Length == 0)
            {
                dato = dato + " Incremento,";
                lblIncremento.ForeColor = System.Drawing.Color.Red;
            }
            //if (txtanio.Text.Trim().Length == 0)
            //{
            //    dato = dato + " Año,";
            //    lblAño.ForeColor = System.Drawing.Color.Red;
            //}
            //if (cboAntiguedad.SelectedIndex == -1)
            //{
            //    dato = dato + " Antiguedad,";
            //    lblAntiguedad.ForeColor = System.Drawing.Color.Red;
            //}
            if (cboBaño.SelectedIndex == -1)
            {
                dato = dato + " Baño,";
                lblBaño.ForeColor = System.Drawing.Color.Red;
            }
            if (cboClasificacion.SelectedIndex == -1)
            {
                dato = dato + " Clasificación,";
                lblClasificacion.ForeColor = System.Drawing.Color.Red;
            }
            if (cboCondicion.SelectedIndex == -1)
            {
                dato = dato + " Condición,";
                lblCondicion.ForeColor = System.Drawing.Color.Red;
            }
            if (cboEstadoPiso.SelectedIndex == -1)
            {
                dato = dato + " Estado de Piso,";
                lblEstadoPiso.ForeColor = System.Drawing.Color.Red;
            }
            if (cboInstalaciones.SelectedIndex == -1)
            {
                dato = dato + " Instlaciones,";
                lblInstalaciones.ForeColor = System.Drawing.Color.Red;
            }
            if (cboMaterial.SelectedIndex == -1)
            {
                dato = dato + " Material,";
                lblMaterial.ForeColor = System.Drawing.Color.Red;
            }
            if (cboMuro.SelectedIndex == -1)
            {
                dato = dato + " Muro,";
                lblMuro.ForeColor = System.Drawing.Color.Red;
            }
            if (cboPiso.SelectedIndex == -1)
            {
                dato = dato + " Piso,";
                lblPiso.ForeColor = System.Drawing.Color.Red;
            }
            if (cboPuerta.SelectedIndex == -1)
            {
                dato = dato + " Puerta,";
                lblPuerta.ForeColor = System.Drawing.Color.Red;
            }
            if (cboRevestimiento.SelectedIndex == -1)
            {
                dato = dato + " Revestimiento,";
                lblRevestimiento.ForeColor = System.Drawing.Color.Red;
            }
            if (cboTecho.SelectedIndex == -1)
            {
                dato = dato + " Techo,";
                lblTecho.ForeColor = System.Drawing.Color.Red;
            }
            return dato;

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboPersona.SelectedIndex < 0)
                {
                    MessageBox.Show("Escoja una persona por favor", Globales.Global_MessageBox);
                    return;
                }
                String dato = Verificar("");
                if (dato.Trim().Length == 0)
                {
                    if (obValidacion.validaNumeroEnteroValido(txtnumero.Text) || obValidacion.validaNumeroEnteroValido(txtSeccion.Text))
                    {
                        MessageBox.Show("Número o sección no validos", Globales.Global_MessageBox);
                        return;
                    }
                    if (obValidacion.validaNumeroDecimalValido(txtAreaConstruida.Text))
                    {
                        MessageBox.Show("El Área construida debe ser diferente de 0", Globales.Global_MessageBox);
                        return;
                    }
                    //if (obValidacion.validaAnio(txtanio.Text))
                    //{
                    //    MessageBox.Show("Año invalido", Globales.Global_MessageBox);
                    //    return;
                    //}
                    if (MessageBox.Show("Desea Grabar?", Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Pred_Pisos piso = new Pred_Pisos();
                        piso.banio = cboBaño.SelectedValue.ToString();
                        piso.instalaciones = cboInstalaciones.SelectedValue.ToString();
                        piso.muro = cboMuro.SelectedValue.ToString();
                        piso.piso = cboPiso.SelectedValue.ToString();
                        piso.puerta = cboPuerta.SelectedValue.ToString();
                        piso.revestimiento = cboRevestimiento.SelectedValue.ToString();
                        piso.techo = cboTecho.SelectedValue.ToString();
                        piso.clasificacion_id = cboClasificacion.SelectedValue.ToString();
                        piso.material_id = cboMaterial.SelectedValue.ToString();
                        piso.estado_id = cboEstadoPiso.SelectedValue.ToString();
                        piso.condicion_id = cboCondicion.SelectedValue.ToString();
                        piso.area_comun = Convert.ToDecimal(txtAreaComun.Text.Trim());
                        piso.area_construida = Convert.ToDecimal(txtAreaConstruida.Text.Trim());
                        piso.metros_alquilados = Convert.ToDecimal(txtMetrosAlquilados.Text.Trim());
                        //piso.porcent_depreci = Convert.ToDecimal(txtPorcentajeDepreciacion.Text.Trim());
                        //piso.valor_comun = Convert.ToDecimal(txtValorComun.Text.Trim());
                        //piso.valor_construido = Convert.ToDecimal(txtValorConstruido.Text.Trim());
                        //piso.valor_construido_total = Convert.ToDecimal(txtValorConstruidoTotal.Text.Trim());
                        //piso.valor_unitario = Convert.ToDecimal(txtValorUnitario.Text.Trim());
                        //piso.valor_unit_depreciado = Convert.ToDecimal(txtValorUnitarioDepreciacion.Text.Trim());
                        //piso.antiguedad_id = cboAntiguedad.SelectedValue.ToString();
                        piso.antiguedad = Convert.ToInt32(txtAntiguedad.Text);
                        piso.seccion = txtSeccion.Text.Trim();
                        piso.numero = int.Parse(txtnumero.Text.Trim());
                        piso.incremento = Convert.ToDecimal(txtIncremento.Text.Trim());
                        piso.anio = Int16.Parse(txtanio.Text);
                        piso.fecha_construc = dtpFConstruccion.Value;
                        piso.registro_user_add = usser;
                        piso.predio_ID = Predio_Idd;
                        piso.persona_ID = cboPersona.SelectedValue.ToString();
                        if (txtPisoId.Text.Trim().Length == 0)//nuevo
                        {
                            piso.estado = true;
                            if (periodofin == 0)
                                PisosDataService.Insert(piso, periodo);
                            else
                                PisosDataService.InsertVariosAños(piso, periodo, periodofin);
                            MessageBox.Show("Se Grabó Correctamente", Globales.Global_MessageBox);
                            this.Close();
                        }
                        else//modificar
                        {
                            piso.piso_ID = int.Parse(txtPisoId.Text.Trim());
                            piso.estado = ckbActivo.Checked;
                            PisosDataService.Update(piso, periodo);
                            MessageBox.Show("Se Grabó Correctamente", Globales.Global_MessageBox);
                            this.Close();
                        }
                    }
                }
                else
                    MessageBox.Show("Falta llenar algún dato", Globales.Global_MessageBox);
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

        private void txtanio_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.validaNumeroEntero(e, Globales.Global_MessageBox);
        }

        private void txtnumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.validaNumeroEntero(e, Globales.Global_MessageBox);
        }

        private void txtSeccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.validaNumeroEntero(e, Globales.Global_MessageBox);
        }

        private void txtAreaConstruida_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.ValidarNumeroDecimal(e, txtAreaConstruida.Text, Globales.Global_MessageBox);
        }

        private void txtAreaComun_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.ValidarNumeroDecimal(e, txtAreaComun.Text, Globales.Global_MessageBox);
        }

        private void txtIncremento_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.ValidarNumeroDecimal(e, txtIncremento.Text, Globales.Global_MessageBox);
        }

        private void txtMetrosAlquilados_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.ValidarNumeroDecimal(e, txtMetrosAlquilados.Text, Globales.Global_MessageBox);
        }
    }
}
