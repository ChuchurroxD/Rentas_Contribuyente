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
using SGR.Entity.Model;
using SGR.WinApp.Layout._4_Procesos.Predio.Pisos;
using SGR.WinApp.Layout._4_Procesos.Predio.OtrasInstalaciones;
using SGR.WinApp.Layout._4_Procesos.Predio.PredioContribuyente;
using SGR.WinApp.Layout._4_Procesos.Predio;

namespace SGR.WinApp.Layout._1_Tablas_Maestras.Predio
{
    public partial class Frm_Predio_Deta : Form
    {
        private Pred_PrredioArbitrioDataService pred_PrredioArbitrioDataService = new Pred_PrredioArbitrioDataService();
        private Mant_TablaArancelDataService mant_TablaArancelDataService = new Mant_TablaArancelDataService();
        private Conf_MultitablaDataService conf_MultitablaDataService = new Conf_MultitablaDataService();
        private Pred_PredioDataService Pred_PredioDataService = new Pred_PredioDataService();
        private Pred_FiscalizacionDataService Pred_FiscalizacionDataService = new Pred_FiscalizacionDataService();
        private Mant_JuntaViaDataService mant_JuntaViaDataService = new Mant_JuntaViaDataService();
        private Pred_ViasDataService pred_ViasDataService = new Pred_ViasDataService();
        private Mant_ArancelDataService mant_ArancelDataService = new Mant_ArancelDataService();
        private Mant_ArancelRusticoDataService mant_ArancelRusticoDataService = new Mant_ArancelRusticoDataService();
        private List<Pred_OtrasInstalaciones> ColeccionOtrasInstalaciones;
        private SortOrder Orden = new SortOrder();
        private Pred_OtrasIntalacionesDataService Pred_OtrasInstalacionesDataService = new Pred_OtrasIntalacionesDataService();
        private Pred_Predio predioGlobal = new Pred_Predio();
        private List<Pred_Pisos> ColeccionPisos;
        private SortOrder OrdenPisos = new SortOrder();
        private Pred_PisosDataService PisosDataService = new Pred_PisosDataService();
        private List<Pred_PredioContribuyente> ColeccionPredioContribuyente;
        private SortOrder OrdenPredioContribuyente = new SortOrder();
        Pred_PredioContribuyenteDataService PredContribuyenteDataService = new Pred_PredioContribuyenteDataService();

        private Mant_HistorialDataService mant_HistoriaDataService = new Mant_HistorialDataService();
        private string casa = "", mapa = "";
        private Mant_PeriodoDataService PeriodoDataService = new Mant_PeriodoDataService();
        private int periodo;
        private Sistema.Globales.Validaciones obValidacion = new Sistema.Globales.Validaciones();
        private String persona_id_seleccionadanueva;
        private bool cerro = false;
        string usser = GlobalesV1.Global_str_Usuario;
        private bool verificar = false;
        public Frm_Predio_Deta(String p_id)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                periodo = PeriodoDataService.GetPeriodoActivo();
                InitializeComponent();
                llenarTipoSelector();
                lblPeriodo.Text = periodo.ToString();
                llenarCboSector();//ver xq no da
                ckbEstado.Visible = false;
                DateTime fechaHoy = DateTime.Now;
                this.persona_id_seleccionadanueva = p_id;
                dgvTablaArancelArb.DataSource = mant_TablaArancelDataService.listarActivosConCosto("0", periodo.ToString());
                dgvArbitriosAsignados.DataSource = pred_PrredioArbitrioDataService.listartodos("0", periodo.ToString());
                ActualizarTotalArbitrio();
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
        public Frm_Predio_Deta(Pred_Predio pre)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                periodo = PeriodoDataService.GetPeriodoActivo();
                InitializeComponent();
                llenarTipoSelector();
                this.predioGlobal = pre;
                lblPeriodo.Text = periodo.ToString();

                CargarDatos(predioGlobal);
                ckbEstado.Visible = true;
                ColeccionOtrasInstalaciones = Pred_OtrasInstalacionesDataService.listarByPredioId(predioGlobal.predio_ID.Trim());
                dgvOtrasInstalaciones.DataSource = ColeccionOtrasInstalaciones;
                ColeccionPisos = PisosDataService.listarByPredioID(predioGlobal.predio_ID.Trim());
                dgvPisos.DataSource = ColeccionPisos;
                ColeccionPredioContribuyente = PredContribuyenteDataService.listarByPredioID(predioGlobal.predio_ID.Trim(), Convert.ToInt16(periodo));
                dgvContribuyentePredio.DataSource = ColeccionPredioContribuyente;
                decimal total = ActualizarTotalPorcentajeContribuyente();
                PintarLblPorcentaje(total);
                ActualizarAreaConstruida();
                PintarColumnasCalculadas();
                dgvTablaArancelArb.DataSource = mant_TablaArancelDataService.listarActivosConCosto(pre.predio_ID, periodo.ToString());
                dgvArbitriosAsignados.DataSource = pred_PrredioArbitrioDataService.listartodos(pre.predio_ID, periodo.ToString());
                ActualizarTotalArbitrio();
                ActualizarTotalOtrasInstalaciones();
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
        private void Frm_Predio_Deta_Load(object sender, EventArgs e)
        {
        }

        public void CargarDatos(Pred_Predio predio)
        {
            try
            {
                txtPredioIDD.Text = predio.predio_ID.Trim();//inicializar primero xq sino se va a buscar arancel
                cboTipoTerreno.SelectedValue = predio.tipo_inmueble.ToString();
                predio.junta_via_ID = 0;//mant_JuntaViaDataService.GetJuntaVia_id(int.Parse(cboSector.SelectedValue.ToString()), int.Parse(cboCalle.SelectedValue.ToString()));
                txtVia.Text = predio.num_via;
                txtInterior.Text = predio.interior;
                txtMz.Text = predio.mz;
                txtLote.Text = predio.lote;
                txtEdificio.Text = predio.edificio;
                txtPiso.Text = predio.piso;
                txtDpto.Text = predio.dpto;
                txtKm.Text = predio.kilometro;
                txtTienda.Text = predio.tienda;
                txtCuadra.Text = predio.cuadra.ToString();
                txtLado.Text = predio.lado.ToString();
                txtNombrePredio.Text = predio.nombre_predio.Trim();
                txtReferencia.Text = predio.referencia.Trim();
                cboFrenteA.SelectedValue = predio.frente_a.ToString();
                txtMetrosFrente.Text = predio.frente_metros.ToString();
                txtPersonas.Text = predio.num_personas.ToString();//Convert.ToInt32();
                dtpFechaAdquisicion.Value = predio.fecha_terreno;
                cboTipoOperacion.SelectedValue = predio.tipo_operacion.ToString();
                txtAreaTotal.Text = predio.area_terreno.ToString();
                txtAreaConstruida.Text = predio.area_construida.ToString();
                //cboAntiguedad.SelectedValue = predio.anios_antiguedad.ToString();
                cboTipoPredio.SelectedValue = predio.tipo_predio.ToString();
                cboEstadoTerreno.SelectedValue = predio.estado_predio.ToString();
                cboTipoUso.SelectedValue = predio.uso_predio.Trim().ToString();
                //cboTipoUso.SelectedValue = predio.uso_codigo.ToString();
                txtFicha.Text = predio.num_ficha;
                cboTipoAdquisicionNormal.SelectedValue = predio.tipo_adquisicion.ToString();
                //cboClasificacionRustico.SelectedValue = predio.clase_edificacion.ToString();
                dtpFechaAdquisicion.Value = predio.fecha_adquisicion;
                //ckbExoneracion.Checked = (predio.exo_predial == 0) ? false : true;
                //txtPorcentajeExoneracion.Text = predio.exo_predial_porcentaje.ToString();
                //cboMotivoExoneracion.SelectedValue = predio.motivo_exoneracion.ToString();
                predio.porcen_area_comun = 0;
                txtCatastro.Text = predio.catastro.Trim();
                // =predio.valor_referencial
                // =predio.valor_terreno
                // =predio.valor_construccion
                // =predio.valor_otra_instalacion
                // =predio.valor_area_comun
                // =predio.total_autovaluo
                // =predio.impuesto_predial
                // =predio.alcabala
                //txtPeriodo.Text = predio.anio_inscripcion.ToString();
                //cboClasificacionRustico.SelectedValue = predio.clasificacion_rustico.ToString();
                cboCategoriaRustico.SelectedValue = predio.categoria_rustico.ToString();
                cboTipoRustico.SelectedValue = predio.tipo_rustico.ToString();
                //cboUsoPredioRustico.SelectedValue = predio.uso_rustico.ToString();
                ckbEstado.Checked = predio.estado;
                //txtExpediente.Text = predio.expediente;
                ckbListaNegra.Checked = predio.lista_negra;
                llenarCboSector();
                cboSector.SelectedValue = predio.Junta_ID;
                cboCalle.ValueMember = "Via_Id";
                cboCalle.DisplayMember = "Descripcion";
                cboCalle.DataSource = pred_ViasDataService.listarViasPorSector(cboSector.SelectedValue.ToString(), GlobalesV1.Global_int_idoficina);
                cboCalle.SelectedValue = predio.Via_ID.ToString();
                // =predio.nuevo_frente_a=
                // =predio.nuevo_uso
                lblArancel.Text = predio.arancel.ToString();
                ckbFiscalizado.Checked = (String.Compare(predio.Fiscalizado, "0") == 0) ? false : true;
                // =predio.id_alicuota
                txtNorte.Text = predio.norte;
                txtSur.Text = predio.sur;
                txtEste.Text = predio.este;
                txtOeste.Text = predio.oeste;
                cboCondicionRustico.SelectedValue = predio.Condicion_Rustico.ToString();
                predio.tipo_adquisicion = predio.Adquisicion_Rustico;
                cboClasificacionRustico.SelectedValue = predio.GrupoTierra_Rustico.ToString();
                mapa = predio.mapa;
                casa = predio.casa;
                cboTipoPosesion.SelectedValue = predio.condicionPropietario.ToString();
                txtPOrcentajeAreaComun.Text = predio.porcen_area_comun.ToString();
                if (System.IO.File.Exists(mapa))
                    ptbMapa.Image = Image.FromFile(mapa);
                if (System.IO.File.Exists(casa))
                    ptbCasa.Image = Image.FromFile(casa);
                ckbEstado.Checked = predio.estado;
                if (cboCalle.SelectedIndex == -1)
                    cboCalle.SelectedIndex = 0;
                if (cboCategoriaRustico.SelectedIndex == -1)
                    cboCategoriaRustico.SelectedIndex = 0;
                if (cboClasificacionRustico.SelectedIndex == -1)
                    cboClasificacionRustico.SelectedIndex = 0;
                if (cboCondicionRustico.SelectedIndex == -1)
                    cboCondicionRustico.SelectedIndex = 0;
                if (cboEstadoTerreno.SelectedIndex == -1)
                    cboEstadoTerreno.SelectedIndex = 0;
                if (cboFrenteA.SelectedIndex == -1)
                    cboFrenteA.SelectedIndex = 0;
                if (cboSector.SelectedIndex == -1)
                    cboSector.SelectedIndex = 0;
                //if (cboTipoOperacion.SelectedIndex == -1)
                //    cboTipoOperacion.SelectedIndex = 0;
                if (cboTipoPosesion.SelectedIndex == -1)
                    cboTipoPosesion.SelectedIndex = 0;
                if (cboTipoPredio.SelectedIndex == -1)
                    cboTipoPredio.SelectedIndex = 0;
                if (cboTipoRustico.SelectedIndex == -1)
                    cboTipoRustico.SelectedIndex = 0;
                if (cboTipoTerreno.SelectedIndex == -1)
                    cboTipoTerreno.SelectedIndex = 0;
                if (cboTipoUso.SelectedIndex == -1)
                    cboTipoUso.SelectedIndex = 0;
                //if (cboUsoPredioRustico.SelectedIndex == -1)
                //    cboUsoPredioRustico.SelectedIndex = 0;
                if (cboTipoAdquisicionNormal.SelectedIndex == -1)
                    cboTipoAdquisicionNormal.SelectedIndex = 0;

                txtCuadra.Text = predio.cuadra.ToString();
                txtLado.Text = predio.lado.ToString();
                ////if (!ckbExoneracion.Checked)
                ////{
                ////    groupBox1.Enabled = false;
                ////    txtPorcentajeExoneracion.Text = "0";
                ////}
                ////else
                ////{
                ////    groupBox1.Enabled = true;
                ////}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }
        private string Verificar(string dato)
        {
            //lblNombrePredio.ForeColor = System.Drawing.Color.Black;
            lblExpediente.ForeColor = System.Drawing.Color.Black;
            //lblFicha.ForeColor = System.Drawing.Color.Black;
            Personas.ForeColor = System.Drawing.Color.Black;
            lblPredioId.ForeColor = System.Drawing.Color.Black;
            lblAreaTotal.ForeColor = System.Drawing.Color.Black;
            lblAreaConstruida.ForeColor = System.Drawing.Color.Black;
            lblMetrosFrente.ForeColor = System.Drawing.Color.Black;
            lblVia.ForeColor = System.Drawing.Color.Black;
            lblInterior.ForeColor = System.Drawing.Color.Black;
            lblKm.ForeColor = System.Drawing.Color.Black;
            lblLote.ForeColor = System.Drawing.Color.Black;
            lblMz.ForeColor = System.Drawing.Color.Black;
            lblEdificio.ForeColor = System.Drawing.Color.Black;
            lblDep.ForeColor = System.Drawing.Color.Black;
            lblPiso.ForeColor = System.Drawing.Color.Black;
            lblTienda.ForeColor = System.Drawing.Color.Black;
            lblLado.ForeColor = System.Drawing.Color.Black;
            lblCuadra.ForeColor = System.Drawing.Color.Black;
            lblDescripcionHistorial.ForeColor = System.Drawing.Color.Black;
            lblTipoOperacion.ForeColor = System.Drawing.Color.Black;
            //if (txtNombrePredio.Text.Trim().Length == 0)
            //{
            //    dato = dato + " Nombre de Predio,";
            //    lblNombrePredio.ForeColor = System.Drawing.Color.Red;
            //}
            //if (txtExpediente.Text.Trim().Length == 0)
            //{
            //    dato = dato + " Expediente,";
            //    lblExpediente.ForeColor = System.Drawing.Color.Red;

            //}
            //if (txtFicha.Text.Trim().Length == 0)
            //{
            //    dato = dato + " Ficha,";
            //    lblFicha.ForeColor = System.Drawing.Color.Red;
            //}
            if (txtPersonas.Text.Trim().Length == 0)
            {
                dato = dato + " Nº Personas,";
                Personas.ForeColor = System.Drawing.Color.Red;
            }
            if (txtAreaTotal.Text.Trim().Length == 0)
            {
                dato = dato + " Área total,";
                lblAreaTotal.ForeColor = System.Drawing.Color.Red;
            }
            if (txtAreaConstruida.Text.Trim().Length == 0)
            {
                dato = dato + " Área construida,";
                lblAreaConstruida.ForeColor = System.Drawing.Color.Red;
            }
            if (txtMetrosFrente.Text.Trim().Length == 0)
            {
                dato = dato + " Metros de frente,";
                lblMetrosFrente.ForeColor = System.Drawing.Color.Red;
            }
            if (String.Compare(cboTipoTerreno.SelectedValue.ToString(), "1") == 0)//URBANO
            {
                if (txtLado.Text.Trim().Length == 0)
                {
                    dato = dato + " Lado,";
                    lblLado.ForeColor = System.Drawing.Color.Red;
                }
                if (txtCuadra.Text.Trim().Length == 0)
                {
                    dato = dato + " Cuadra,";
                    lblCuadra.ForeColor = System.Drawing.Color.Red;
                }
                //if (txtVia.Text.Trim().Length == 0 && txtInterior.Text.Trim().Length == 0 && txtKm.Text.Trim().Length == 0 && txtLote.Text.Trim().Length == 0 &&
                //txtMz.Text.Trim().Length == 0 && txtEdificio.Text.Trim().Length == 0 && txtDpto.Text.Trim().Length == 0 && txtPiso.Text.Trim().Length == 0 &&
                //txtTienda.Text.Trim().Length == 0)
                //{
                //    dato = dato + " Tiene q colocar por lo menos un dato de dirección(via,o interior, o km, o lote, o manzana, o edificio, o dpto, o  piso,o tienda)";
                //    lblVia.ForeColor = System.Drawing.Color.Red;
                //    lblInterior.ForeColor = System.Drawing.Color.Red;
                //    lblKm.ForeColor = System.Drawing.Color.Red;
                //    lblLote.ForeColor = System.Drawing.Color.Red;
                //    lblMz.ForeColor = System.Drawing.Color.Red;
                //    lblEdificio.ForeColor = System.Drawing.Color.Red;
                //    lblDep.ForeColor = System.Drawing.Color.Red;
                //    lblPiso.ForeColor = System.Drawing.Color.Red;
                //    lblTienda.ForeColor = System.Drawing.Color.Red;
                //}
            }
            //if (txtDescripcionHistorial.Text.Trim().Length == 0)
            //{
            //    dato = dato + " Descripción para historial,";
            //    lblDescripcionHistorial.ForeColor = System.Drawing.Color.Red;
            //}
            //if (cboTipoOperacion.SelectedIndex == -1)
            //{
            //    dato = dato + " Tipo de Operación";
            //    lblTipoOperacion.ForeColor = System.Drawing.Color.Red;
            //}
            return dato;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            String dato = Verificar("");
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                decimal total = ActualizarTotalPorcentajeContribuyente();
                String msj = "";
                if (cboSector.SelectedIndex == -1 || cboCalle.SelectedIndex == -1)
                {
                    MessageBox.Show("Falta Sector y Calle", Globales.Global_MessageBox);
                    return;
                }
                if (total != Convert.ToDecimal("100"))
                {
                    msj = msj + "EL porcentaje es diferente al 100%. ";
                }
                //if (casa.Trim().Length == 0)
                //{
                //    msj = msj + "No subió el archivo de casa. ";
                //}
                //if (mapa.Trim().Length == 0)
                //{
                //    msj = msj + "No subió el archivo de mapa. ";
                //}
                if (dgvArbitriosAsignados.RowCount == 0)
                {
                    msj = msj + "No Hay Arbitrios Asignados.";
                }
                if (txtDescripcionHistorial.Text.Trim().Length == 0 || cboTipoOperacion.SelectedIndex == -1 || txtExpediente.Text.Trim().Length == 0)
                {
                    msj = msj + " Historial.";
                   
                }
                if (String.Compare(dato, "") != 0)
                {
                    MessageBox.Show("Falta llenar " + dato, Globales.Global_MessageBox);
                    return;
                }
                if (String.Compare(lblArancel.Text, "") == 0 || String.Compare(lblArancel.Text, "0.0") == 0 || String.Compare(lblArancel.Text, "0") == 0)
                {
                    MessageBox.Show("Debe elegir un arancel valido", Globales.Global_MessageBox);
                    return;
                }
                if (predioGlobal == null && !Pred_PredioDataService.GetExisteId(txtPredioIDD.Text.Trim()))
                {
                    MessageBox.Show("El código de Predio ya existe", Globales.Global_MessageBox);
                    return;
                }
                if (Convert.ToDecimal(txtAreaTotal.Text) < 0)
                {
                    MessageBox.Show("El Área del terreno debe ser mayor al Área costruida", Globales.Global_MessageBox);
                    return;
                }
                if (!TotalenGrilla(dgvContribuyentePredio))
                {
                    MessageBox.Show("Llene por lo menos un contribuyente en el Predio", Globales.Global_MessageBox);
                    return;
                }
                Pred_Predio predio = new Pred_Predio();
                predio.predio_ID = txtPredioIDD.Text.Trim();
                //cargar datos 
                predio.junta_via_ID = mant_JuntaViaDataService.GetJuntaVia_id(int.Parse(cboSector.SelectedValue.ToString()), int.Parse(cboCalle.SelectedValue.ToString()));
                predio.num_via = txtVia.Text.Trim().ToString();
                predio.interior = txtInterior.Text.Trim().ToString();
                predio.mz = txtMz.Text.Trim().ToString();
                predio.lote = txtLote.Text.Trim().ToString();
                predio.edificio = txtEdificio.Text.Trim().ToString();
                predio.piso = txtPiso.Text.Trim().ToString();
                predio.dpto = txtDpto.Text.Trim().ToString();
                predio.kilometro = txtKm.Text.Trim();
                predio.tienda = txtTienda.Text.Trim().ToString();
                if (predioGlobal.predio_ID == null)//nuevo
                {
                    if (!verificar)//si es falso inserto
                    {
                        if (Pred_PredioDataService.existeDireccion(predio.junta_via_ID, predio.num_via, predio.interior,
                         predio.mz, predio.lote, predio.edificio, predio.piso, predio.dpto, predio.tienda,
                         txtCuadra.Text, predio.kilometro) > 0)
                        {
                            if (MessageBox.Show("Ya existe predio en dirección, Desea Continuar?", Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                Frm_Validacion Frm_Validacion = new Frm_Validacion();
                                Frm_Validacion.StartPosition = FormStartPosition.CenterParent;
                                Frm_Validacion.ShowDialog();
                                if (Globales.validado==0)
                                {
                                    return;
                                }else
                                MessageBox.Show("Grabará predio con dirección repetida", Globales.Global_MessageBox);
                              
                            }else
                            {
                                return;
                            }
                        }
                    }
                }
                else
                {
                    if (Pred_PredioDataService.existeDireccionModificar(predioGlobal.predio_ID, predio.junta_via_ID, predio.num_via, predio.interior,
                      predio.mz, predio.lote, predio.edificio, predio.piso, predio.dpto, predio.tienda,
                      txtCuadra.Text, predio.kilometro) > 0)
                    {
                        if (MessageBox.Show("Ya existe predio en dirección, Desea Continuar?", Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Frm_Validacion Frm_Validacion = new Frm_Validacion();
                            Frm_Validacion.StartPosition = FormStartPosition.CenterParent;
                            Frm_Validacion.ShowDialog();
                            if (Globales.validado == 0)
                            {
                                return;
                            }
                            else
                                MessageBox.Show("Grabará predio con dirección repetida", Globales.Global_MessageBox);
                        }
                        else
                        {
                            return;
                        }

                       
                    }
                }

                msj = msj + "Desea Grabar?";
                if (MessageBox.Show(msj, Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    predio.tipo_inmueble = Convert.ToInt32(cboTipoTerreno.SelectedValue.ToString());
                    predio.nombre_predio = txtNombrePredio.Text.Trim().ToString();
                    predio.referencia = txtReferencia.Text.Trim().ToString();
                    predio.frente_a = Convert.ToInt32(cboFrenteA.SelectedValue.ToString());
                    predio.frente_metros = Convert.ToDecimal(txtMetrosFrente.Text.Trim().ToString());
                    predio.num_personas = Convert.ToInt32(txtPersonas.Text);
                    predio.fecha_terreno = dtpFechaAdquisicion.Value;
                    predio.tipo_operacion = Convert.ToInt32(cboTipoOperacion.SelectedValue.ToString());
                    predio.area_terreno = Convert.ToDecimal(txtAreaTotal.Text.Trim().ToString());
                    predio.area_construida = Convert.ToDecimal(txtAreaConstruida.Text.Trim().ToString());
                    predio.anios_antiguedad = 0;
                    predio.tipo_predio = Convert.ToInt32(cboTipoPredio.SelectedValue.ToString());
                    predio.estado_predio = Convert.ToInt32(cboEstadoTerreno.SelectedValue.ToString());
                    predio.uso_predio = cboTipoUso.SelectedValue.ToString();
                    predio.uso_codigo = cboTipoUso.SelectedValue.ToString();
                    predio.num_ficha = txtFicha.Text.Trim().ToString();
                    predio.tipo_adquisicion = Convert.ToInt32(cboTipoAdquisicionNormal.SelectedValue.ToString());
                    predio.clase_edificacion = Convert.ToInt32(cboClasificacionRustico.SelectedValue.ToString());
                    predio.fecha_adquisicion = dtpFechaAdquisicion.Value;
                    DateTime fechaHoy = DateTime.Now;
                    predio.porcen_area_comun = 0;
                    predio.anio_adquisicion = Convert.ToInt16((predio.fecha_adquisicion).Year.ToString());
                    //predio.fecha_inscripcion=getDate()
                    //predio.anio_inscripcion = Convert.ToInt16(txtPeriodo.Text.Trim().ToString());
                    predio.clasificacion_rustico = Convert.ToInt16(cboClasificacionRustico.SelectedValue.ToString());
                    predio.categoria_rustico = Convert.ToInt16(cboCategoriaRustico.SelectedValue.ToString());
                    predio.tipo_rustico = Convert.ToInt16(cboTipoRustico.SelectedValue.ToString());
                    predio.uso_rustico = Convert.ToInt16(cboTipoUso.SelectedValue.ToString());
                    predio.hectareas = Convert.ToDecimal(txtAreaTotal.Text);
                    predio.estado = true;
                    predio.expediente = txtExpediente.Text.Trim();
                    predio.lista_negra = false;
                    predio.sector = Convert.ToInt16(cboSector.SelectedValue.ToString());
                    //predio.nuevo_frente_a=
                    //predio.nuevo_uso
                    predio.arancel = Convert.ToDecimal(lblArancel.Text.Trim());
                    predio.Fiscalizado = "0";
                    //predio.id_alicuota
                    predio.norte = txtNorte.Text.Trim().ToString();
                    predio.sur = txtSur.Text.Trim().ToString();
                    predio.este = txtEste.Text.Trim().ToString();
                    predio.oeste = txtOeste.Text.Trim().ToString();
                    predio.Condicion_Rustico = Convert.ToInt16(cboCondicionRustico.SelectedValue.ToString());
                    predio.Adquisicion_Rustico = Convert.ToInt16(predio.tipo_adquisicion);
                    predio.GrupoTierra_Rustico = Convert.ToInt16(cboClasificacionRustico.SelectedValue.ToString());
                    predio.mapa = mapa;
                    predio.casa = casa;
                    predio.registro_user_add = usser;
                    if (predio.tipo_inmueble == 1)//urbano
                    {
                        predio.clasificacion_rustico = 1;
                        predio.categoria_rustico = 1;
                        predio.tipo_rustico = 1;
                        predio.uso_rustico = 1;
                        predio.norte = "";
                        predio.sur = "";
                        predio.este = "";
                        predio.oeste = "";
                    }
                    predio.alquiler = (String.Compare(cboTipoAdquisicionNormal.SelectedValue.ToString().Trim(), "4") == 0) ? true : false;
                    predio.terreno_sin_construir = (String.Compare(cboTipoAdquisicionNormal.SelectedValue.ToString().Trim(), "1") == 0) ? true : false;
                    predio.nombre_predio = txtNombrePredio.Text.Trim();
                    predio.lado = Convert.ToInt32(txtLado.Text);
                    predio.cuadra = Convert.ToInt32(txtCuadra.Text);
                    predio.catastro = txtCatastro.Text.Trim();
                    //agregar
                    predio.condicionPropietario = Convert.ToInt32(cboTipoPosesion.SelectedValue.ToString());
                    predio.porcen_area_comun = Convert.ToDecimal(txtPOrcentajeAreaComun.Text);
                    predio.DescripcionHistorial = txtDescripcionHistorial.Text.TrimEnd();
                    if (predioGlobal.predio_ID == null)//nuevo
                    {
                        if (!verificar)//si es falso inserto
                        {
                            Pred_PredioDataService.InsertTemporal(predio, periodo);
                        }
                        //verificoparametros
                        if (CargarGrillaErrores(Pred_FiscalizacionDataService.verificarParametroParaPredioNuevo(periodo.ToString(), "0")))
                        {
                            predio.predio_ID = Pred_PredioDataService.Insert(predio, periodo);//no hay errores e inserto todo bien
                            if (TotalenGrilla(dgvOtrasInstalaciones))
                                Pred_OtrasInstalacionesDataService.GuardarOtrasInstalacionEnPredio(predio.predio_ID, usser);
                            if (TotalenGrilla(dgvPisos))
                                PisosDataService.GuardarPisosEnPredio(predio.predio_ID, usser);
                            if (TotalenGrilla(dgvContribuyentePredio))
                                PredContribuyenteDataService.GuardarPredioContribuyenteEnPredio(predio.predio_ID, usser, periodo);
                            if (TotalenGrilla(dgvArbitriosAsignados))
                                pred_PrredioArbitrioDataService.GuardarArbitriosEnPredio(predio.predio_ID, usser);
                            //Pred_FiscalizacionDataService.GenerarCtaCorrienteIniacial(periodo.ToString(), predio.predio_ID);


                            Mant_Historial mant_Historial1 = new Mant_Historial();
                            msj = "";
                            if (txtDescripcionHistorial.Text.Trim().Length != 0 && txtExpediente.Text.Trim().Length != 0)
                            {
                                mant_Historial1.idPredio = predio.predio_ID;
                                mant_Historial1.tipo = 2;
                                mant_Historial1.Descripcion = txtDescripcionHistorial.Text.TrimEnd();
                                mant_Historial1.Expediente = txtExpediente.Text;
                                mant_Historial1.TipoOperacion = Convert.ToInt32(cboTipoOperacion.SelectedValue.ToString());
                                mant_Historial1.tipoDocumento = "1";
                                //DateTime fechaHoy = DateTime.Now;
                                mant_Historial1.fecha = fechaHoy;
                                mant_Historial1.registro_user_add = GlobalesV1.Global_str_Usuario;
                                mant_Historial1.estado = true;
                                mant_HistoriaDataService.Insert(mant_Historial1);
                                msj = msj + "Se Grabó Correctamente con Historial";
                            }
                            else msj = msj + "Se Grabó Correctamente sin historial";

                            MessageBox.Show(msj, Globales.Global_MessageBox);
                            cerro = true;
                            this.Close();
                        }
                        else
                        {
                            verificar = true;
                        }
                    }
                    else
                    {
                        predio.estado = ckbEstado.Checked;
                        predio.Fiscalizado = (ckbFiscalizado.Checked) ? "1" : "0";
                        predio.lista_negra = ckbListaNegra.Checked;
                        //cantidad = Pred_PredioDataService.GetExisteDescripcionModificar(predio.nombre_predio, predio.predio_ID);
                        //if (cantidad > 0)
                        //{
                        //    MessageBox.Show("Existe Descripción", Globales.Global_MessageBox);
                        //    return;
                        //}
                        
                        Pred_PredioDataService.Update(predio, periodo);
                        Mant_Historial mant_Historial1 = new Mant_Historial();
                        msj = "";
                        if (txtDescripcionHistorial.Text.Trim().Length != 0 && txtExpediente.Text.Trim().Length != 0)
                        {
                            mant_Historial1.idPredio = predio.predio_ID;
                            mant_Historial1.tipo = 2;
                            mant_Historial1.Descripcion = txtDescripcionHistorial.Text.TrimEnd();
                            mant_Historial1.Expediente = txtExpediente.Text;
                            mant_Historial1.TipoOperacion = Convert.ToInt32(cboTipoOperacion.SelectedValue.ToString());
                            mant_Historial1.tipoDocumento = "1";
                            //DateTime fechaHoy = DateTime.Now;
                            mant_Historial1.fecha = fechaHoy;
                            mant_Historial1.registro_user_add = GlobalesV1.Global_str_Usuario;
                            mant_Historial1.estado = true;
                            mant_HistoriaDataService.Insert(mant_Historial1);
                            msj = msj + "Se Grabó Correctamente con Historial";
                        }
                        else msj = msj + "Se Grabó Correctamente sin historial";
                        MessageBox.Show(msj, Globales.Global_MessageBox);
                        cerro = true;
                        this.Close();
                    }
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
        private bool CargarGrillaErrores(List<Mant_Depreciacion> listaObserva)
        {
            //List<string> lista = new List<string>();
            // for (int i = 0; i < listaObserva.Count; i++)
            //    {
            //        lista.Add(listaObserva[i].clasificacion_descripcion);
            //    }
            if (listaObserva.Count > 0)
            {
                MessageBox.Show("Hay Errores , falta parámetros para años anteriores", Globales.Global_MessageBox);
                Frm_Errores frm_Errores = new Frm_Errores(listaObserva);
                frm_Errores.StartPosition = FormStartPosition.CenterParent;
                frm_Errores.Show();
                return false;
            }
            return true;
        }

        private void llenarTipoSelector()
        {
            llenarCboMultitabla(cboTipoTerreno, "Multc_vDescripcion", "Multc_cValor", "5");
            llenarCboMultitabla(cboFrenteA, "Multc_vDescripcion", "Multc_cValor", "14");
            llenarCboMultitabla(cboTipoUso, "Multc_vDescripcion", "Multc_cValor", "30");
            llenarCboMultitabla(cboEstadoTerreno, "Multc_vDescripcion", "Multc_cValor", "7");
            llenarCboMultitabla(cboTipoPredio, "Multc_vDescripcion", "Multc_cValor", "11");
            llenarCboMultitabla(cboTipoAdquisicionNormal, "Multc_vDescripcion", "Multc_cValor", "4");
            llenarCboMultitabla(cboTipoOperacion, "Multc_vDescripcion", "Multc_cValor", "12");
            llenarCboMultitabla(cboTipoPosesion, "Multc_vDescripcion", "Multc_cValor", "18");
            //rústico
            llenarCboMultitabla(cboTipoRustico, "Multc_vDescripcion", "Multc_cValor", "29");
            //llenarCboMultitabla(cboUsoPredioRustico, "Multc_vDescripcion", "Multc_cValor", "30");
            llenarCboMultitabla(cboClasificacionRustico, "Multc_vDescripcion", "Multc_cValor", "28");
            llenarCboMultitabla(cboCategoriaRustico, "Multc_vDescripcion", "Multc_cValor", "35");
            llenarCboMultitabla(cboCondicionRustico, "Multc_vDescripcion", "Multc_cValor", "127");
            //llenarCboMultitabla(cboGrupoTierraR, "Multc_vDescripcion", "Multc_cValor", "28");
            //exoneración
            //llenarCboMultitabla(cboMotivoExoneracion, "Multc_vDescripcion", "Multc_cValor", "10");
            //llenarCboMultitabla(cboAntiguedad, "Multc_vDescripcion", "Multc_cValor", "71");
        }
        private void llenarCboMultitabla(ComboBox cbo, String display, String valor, String tipo)
        {
            try
            {
                cbo.DisplayMember = display;
                cbo.ValueMember = valor;
                cbo.DataSource = conf_MultitablaDataService.GetCboConf_Multitabla(tipo);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }
        private void llenarCboSector()
        {
            try
            {
                cboSector.ValueMember = "sector_id";
                cboSector.DisplayMember = "descripcion";
                cboSector.DataSource = mant_ArancelDataService.llenarSector(GlobalesV1.Global_int_idoficina);
                this.cboSector.AutoCompleteMode = AutoCompleteMode.Suggest;
                this.cboSector.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }
        private void cboCategoriaRustico_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarArancel();
        }
        private void cboTipoTerreno_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (String.Compare(cboTipoTerreno.SelectedValue.ToString(), "1") == 0)//URBANO
                {
                    llenarCboMultitabla(cboTipoUso, "Multc_vDescripcion", "Multc_cValor", "8");
                    gpbPredioRustico.Enabled = false;
                    gpbArancelarioRustico.Enabled = false;
                    //gpbPredioUrbano.Enabled = true;
                    //verificar estos2
                    txtAreaTotal.Text = "0";
                    //txtAreaConstruida.Text = "0";
                    ActualizarAreaConstruida();
                    //txtCuadra.Enabled = true;
                    //txtLado.Enabled = true;
                }
                else
                {
                    llenarCboMultitabla(cboTipoUso, "Multc_vDescripcion", "Multc_cValor", "30");//verificar si es asi
                    gpbPredioRustico.Enabled = true;
                    gpbArancelarioRustico.Enabled = true;
                    //txtCuadra.Enabled = false;
                    //txtLado.Enabled = false;
                    //gpbPredioUrbano.Enabled = false;
                }
            }
            catch (Exception ex) { }

            cargarArancel();
        }

        private void cboSector_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cboCalle.ValueMember = "Via_Id";
                cboCalle.DisplayMember = "Descripcion";
                cboCalle.DataSource = pred_ViasDataService.listarViasPorSector(cboSector.SelectedValue.ToString(), GlobalesV1.Global_int_idoficina);
                this.cboCalle.AutoCompleteMode = AutoCompleteMode.Suggest;
                this.cboCalle.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
            cargarArancel();
        }

        private void cboCalle_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarArancel();
        }
        private void cargarArancel()
        {
            try
            {
                decimal valor = 0;
                //int a = String.Compare(cboTipoTerreno.SelectedValue.ToString(), "1");
                //int b = String.Compare(cboCalle.SelectedValue.ToString().Trim(), "");
                //int c = String.Compare(cboSector.SelectedValue.ToString().Trim(), "");

                if (String.Compare(cboTipoTerreno.SelectedValue.ToString(), "1") == 0 &&
                    cboCalle.SelectedIndex != -1 &&
                   cboSector.SelectedIndex != -1)//URBANO
                {
                    int jv = mant_JuntaViaDataService.GetJuntaVia_id(int.Parse(cboSector.SelectedValue.ToString()), int.Parse(cboCalle.SelectedValue.ToString()));
                    valor = mant_ArancelDataService.GetMonto(jv, periodo, Convert.ToInt32(txtLado.Text), Convert.ToInt32(txtCuadra.Text));
                    lblArancel.Text = valor.ToString();
                }
                else if (String.Compare(cboTipoTerreno.SelectedValue.ToString(), "2") == 0 &&
                    String.Compare(cboClasificacionRustico.SelectedValue.ToString().Trim(), "") != 0 &&//grupo de tierra
                    String.Compare(cboCategoriaRustico.SelectedValue.ToString().Trim(), "") != 0)//rustico
                {
                    valor = mant_ArancelRusticoDataService.GetMontoRustico(cboClasificacionRustico.SelectedValue.ToString().Trim(), periodo, cboCategoriaRustico.SelectedValue.ToString().Trim());
                    lblArancel.Text = valor.ToString();
                }
                else
                    lblArancel.Text = "0";

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }

        }
        private void ckbExoneracion_CheckedChanged(object sender, EventArgs e)
        {
            //groupBox1.Enabled = (ckbExoneracion.Checked);
            //txtPorcentajeExoneracion.Text = "0";

        }
        private void cboEstadoTerreno_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DESACTIVAR BTONONES
        }

        private void ofdMapa_FileOk(object sender, CancelEventArgs e)
        {//pictureBox1.Image = Image.FromFile(@"F:\Progra\Crs\dado1.bmp")
            try
            {
                mapa = subirImagen(ofdMapa.FileName, ofdMapa.SafeFileName);
                if (String.Compare(mapa, "") != 0)
                    ptbMapa.Image = Image.FromFile(mapa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }

        }
        private void ofdCasa_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                casa = subirImagen(ofdCasa.FileName, ofdCasa.SafeFileName);
                if (String.Compare(casa, "") != 0)
                    ptbCasa.Image = Image.FromFile(casa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }

        }
        private void txtPersonas_Validated(object sender, EventArgs e)
        {
            if (IsTxtLleno(txtPersonas))
            {
                // Clear the error, if any, in the error provider.

                erpTextos.SetError(this.txtPersonas, String.Empty);
            }
            else
            {
                // Set the error if the name is not valid.
                erpTextos.SetError(this.txtPersonas, "Es Necesario");
            }
        }

        private string subirImagen(string origen, string nombreArchivo)
        {
            try
            {
                DateTime fechaHoy = DateTime.Now;
                string destino = System.IO.Directory.GetCurrentDirectory() + "\\casamapa";
                //string destino = Globales.DireccionMapaCasa;// "D:\\sgr_11_05_2016\\SGR\\SGR\\Resources\\casamapa";
                string cadena = fechaHoy.Year.ToString() + fechaHoy.Month.ToString() + fechaHoy.Day.ToString() +
                               fechaHoy.Hour.ToString() + fechaHoy.Minute.ToString() + fechaHoy.Second.ToString();
                if (!System.IO.Directory.Exists(destino))
                {
                    System.IO.Directory.CreateDirectory(destino);
                }
                System.IO.File.Copy(origen, destino + "\\" + cadena + nombreArchivo, true);
                return destino + "\\" + cadena + nombreArchivo;
            }
            catch (Exception ed)
            {
                MessageBox.Show(ed.ToString(), Globales.Global_MessageBox);
            }
            return "";
        }
        private void btnCasa_Click_1(object sender, EventArgs e)
        {
            ofdCasa.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|Png Image|*.png";
            ofdCasa.Title = "Seleccione una imagen";
            ofdCasa.ShowDialog();
        }
        private void btnMapa_Click_1(object sender, EventArgs e)
        {
            ofdMapa.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|Png Image|*.png";
            ofdMapa.Title = "Seleccione una imagen";
            ofdMapa.ShowDialog();
        }
        private bool IsTxtLleno(TextBox txt)
        {
            // Determine whether the text box contains a zero-length string.
            return (txt.Text.Length > 0);
        }
        private void txtPersonas_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.validaNumeroEntero(e, Globales.Global_MessageBox);
        }
        private void txtAreaTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.ValidarNumeroDecimal(e, txtAreaTotal.Text, Globales.Global_MessageBox);
        }
        private void txtAreaConstruida_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.ValidarNumeroDecimal(e, txtAreaConstruida.Text, Globales.Global_MessageBox);
        }
        private void txtMetrosFrente_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.ValidarNumeroDecimal(e, txtMetrosFrente.Text, Globales.Global_MessageBox);
        }
        private void txtCuadra_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.validaNumeroEntero(e, Globales.Global_MessageBox);
        }
        private void txtLado_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.validaNumeroEntero(e, Globales.Global_MessageBox);
        }
        //I---------------------------------------------------------------------------------------------
        //I---------------------------------------------------------------------------------------------
        //INICIO OTRAS INSTALACIONES
        //I---------------------------------------------------------------------------------------------
        //I---------------------------------------------------------------------------------------------
        private void toolnuevoOtrasInstalaciones_Click(object sender, EventArgs e)
        {
            Frm_OtrasIntalaciones_Detalle Frm_OtrasIntalaciones_Detalle;
            if (predioGlobal.predio_ID != null)//voy a editar predio pero voy a agregar
                Frm_OtrasIntalaciones_Detalle = new Frm_OtrasIntalaciones_Detalle(predioGlobal.predio_ID.Trim(), periodo);
            else
                Frm_OtrasIntalaciones_Detalle = new Frm_OtrasIntalaciones_Detalle("0", periodo);
            Frm_OtrasIntalaciones_Detalle.StartPosition = FormStartPosition.CenterParent;
            Frm_OtrasIntalaciones_Detalle.ShowDialog();
            OtrasInstalacioneslistarByPredio();
        }
        private void tooleditarOtrasInstalaciones_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvOtrasInstalaciones.SelectedRows.Count > 0)
                {
                    Frm_OtrasIntalaciones_Detalle Frm_OtrasIntalaciones_Detalle = new Frm_OtrasIntalaciones_Detalle(obtenerdatosInstalaciones(), periodo);
                    Frm_OtrasIntalaciones_Detalle.StartPosition = FormStartPosition.CenterParent;
                    Frm_OtrasIntalaciones_Detalle.ShowDialog();

                    if (txtbusquedaOtrasInstalaciones.Text.Trim().Length == 0)
                        OtrasInstalacioneslistarByPredio();
                    else
                        OtrasInstalacioneslistarByPredioColeccion();
                }
                else
                    MessageBox.Show("Seleccione un elemento", Globales.Global_MessageBox);
            }
            catch (Exception ex)
            {

            }

        }


        private void ActualizarTotalOtrasInstalaciones()
        {
            int cantidad;
            decimal ValorOtras = 0, total = 0;
            decimal CantidadValor = 0;
            bool estado;
            cantidad = dgvOtrasInstalaciones.RowCount;
            for (int i = 0; i < cantidad; i++)
            {
                estado = (bool)dgvOtrasInstalaciones.Rows[i].Cells["Estado"].Value;
                if (estado)
                {
                    ValorOtras = ValorOtras + (decimal)dgvOtrasInstalaciones.Rows[i].Cells["ValorOtras"].Value;
                    CantidadValor = CantidadValor + (decimal)dgvOtrasInstalaciones.Rows[i].Cells["CantidadValor"].Value;

                }
            }
            total = ValorOtras + CantidadValor;
            lblTotalOtrasInstalaciones.Text = "Total= " + total.ToString();
        }
        private void OtrasInstalacioneslistarByPredio()
        {
            if (predioGlobal.predio_ID != null)
                dgvOtrasInstalaciones.DataSource = Pred_OtrasInstalacionesDataService.listarByPredioId(predioGlobal.predio_ID.Trim());
            else
                dgvOtrasInstalaciones.DataSource = Pred_OtrasInstalacionesDataService.listarByPredioId("0");
            ActualizarTotalOtrasInstalaciones();
        }
        private void OtrasInstalacioneslistarByPredioColeccion()
        {
            if (predioGlobal.predio_ID != null)
                dgvOtrasInstalaciones.DataSource = Pred_OtrasInstalacionesDataService.GetcoleccionByPredioID("observacion like '%" + txtbusquedaOtrasInstalaciones.Text + "%'", "PrediosOtras_id", predioGlobal.predio_ID.Trim());
            else
                dgvOtrasInstalaciones.DataSource = Pred_OtrasInstalacionesDataService.GetcoleccionByPredioID("observacion like '%" + txtbusquedaOtrasInstalaciones.Text + "%'", "PrediosOtras_id", "0");
        }
        private Pred_OtrasInstalaciones obtenerdatosInstalaciones()
        {
            Pred_OtrasInstalaciones Pred_OtrasInstalaciones = new Pred_OtrasInstalaciones();
            Pred_OtrasInstalaciones.PrediosOtras_id = (Int32)dgvOtrasInstalaciones.SelectedRows[0].Cells["PrediosOtras_id"].Value;
            Pred_OtrasInstalaciones.Predio_id = (string)dgvOtrasInstalaciones.SelectedRows[0].Cells["Predio_id"].Value;
            Pred_OtrasInstalaciones.Estado = (bool)dgvOtrasInstalaciones.SelectedRows[0].Cells["Estado"].Value;
            Pred_OtrasInstalaciones.OtrasValor_descripcion = (string)dgvOtrasInstalaciones.SelectedRows[0].Cells["OtrasValor_descripcion"].Value;
            Pred_OtrasInstalaciones.Observacion = (string)dgvOtrasInstalaciones.SelectedRows[0].Cells["Observacion"].Value;
            Pred_OtrasInstalaciones.CantidadValor = (decimal)dgvOtrasInstalaciones.SelectedRows[0].Cells["CantidadValor"].Value;
            Pred_OtrasInstalaciones.ValorOtras = (decimal)dgvOtrasInstalaciones.SelectedRows[0].Cells["ValorOtras"].Value;
            Pred_OtrasInstalaciones.OtrasValor_id = (Int32)dgvOtrasInstalaciones.SelectedRows[0].Cells["OtrasValor_id"].Value;
            return Pred_OtrasInstalaciones;
        }
        private void dgvOtrasInstalaciones_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                DataGridViewColumn ColumnaOrdenar = dgvOtrasInstalaciones.Columns[e.ColumnIndex];

                if (dgvOtrasInstalaciones.SortOrder == SortOrder.None)
                {

                    if (ColumnaOrdenar.Name == "Observacion")
                    {
                        if (Orden == SortOrder.Descending)
                        {
                            dgvOtrasInstalaciones.DataSource = ColeccionOtrasInstalaciones.OrderBy(p => p.Observacion).ToList();
                            Orden = SortOrder.Ascending;
                        }
                        else
                        {
                            dgvOtrasInstalaciones.DataSource = ColeccionOtrasInstalaciones.OrderBy(p => p.Observacion).Reverse().ToList();
                            Orden = SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "PrediosOtras_id")
                    {
                        if (Orden == SortOrder.Descending)
                        {
                            dgvOtrasInstalaciones.DataSource = ColeccionOtrasInstalaciones.OrderBy(p => p.PrediosOtras_id).ToList();
                            Orden = SortOrder.Ascending;
                        }
                        else
                        {
                            dgvOtrasInstalaciones.DataSource = ColeccionOtrasInstalaciones.OrderBy(p => p.PrediosOtras_id).Reverse().ToList();
                            Orden = SortOrder.Descending;
                        }

                    }
                    else if (ColumnaOrdenar.Name == "OtrasValor_id")
                    {
                        if (Orden == SortOrder.Descending)
                        {
                            dgvOtrasInstalaciones.DataSource = ColeccionOtrasInstalaciones.OrderBy(p => p.OtrasValor_id).ToList();
                            Orden = SortOrder.Ascending;
                        }
                        else
                        {
                            dgvOtrasInstalaciones.DataSource = ColeccionOtrasInstalaciones.OrderBy(p => p.OtrasValor_id).Reverse().ToList();
                            Orden = SortOrder.Descending;
                        }

                    }
                }

            }
        }
        private void txtbusquedaOtrasInstalaciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                OtrasInstalacioneslistarByPredioColeccion();
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    dgvOtrasInstalaciones.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }
        private void dgvOtrasInstalaciones_DoubleClick(object sender, EventArgs e)
        {
            tooleditarOtrasInstalaciones.PerformClick();
        }
        //I---------------------------------------------------------------------------------------------
        //I---------------------------------------------------------------------------------------------
        //FIN OTRAS INSTALACIONES
        //I---------------------------------------------------------------------------------------------
        //I---------------------------------------------------------------------------------------------







        //I---------------------------------------------------------------------------------------------
        //I---------------------------------------------------------------------------------------------
        //INICIO DE PISOS
        //I---------------------------------------------------------------------------------------------
        //I---------------------------------------------------------------------------------------------

        private void toolnuevoPisos_Click(object sender, EventArgs e)
        {
            Frm_Pisos_Detalle Frm_Pisos_Detalle;
            if (predioGlobal.predio_ID != null)//voy a editar predio pero voy a agregar
                Frm_Pisos_Detalle = new Frm_Pisos_Detalle(predioGlobal.predio_ID.Trim(), periodo);
            else
                Frm_Pisos_Detalle = new Frm_Pisos_Detalle("0", periodo);

            //Frm_Pisos_Detalle Frm_Pisos_Detalle = new Frm_Pisos_Detalle();
            Frm_Pisos_Detalle.StartPosition = FormStartPosition.CenterParent;
            Frm_Pisos_Detalle.ShowDialog();
            PisoslistarByPredio();
        }
        private void tooleditarPisos_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvPisos.SelectedRows.Count > 0)
                {
                    Frm_Pisos_Detalle Frm_Pisos_Detalle = new Frm_Pisos_Detalle(obtenerdatosPiso(), periodo);
                    Frm_Pisos_Detalle.StartPosition = FormStartPosition.CenterParent;
                    Frm_Pisos_Detalle.ShowDialog();
                    PisoslistarByPredio();
                }
                else
                    MessageBox.Show("Seleccione un elemento", Globales.Global_MessageBox);
            }
            catch (Exception ex)
            {

            }

        }
        private Pred_Pisos obtenerdatosPiso()
        {
            Pred_Pisos Pred_Pisos = new Pred_Pisos();
            Pred_Pisos.anio = (Int16)dgvPisos.SelectedRows[0].Cells["anio"].Value;
            Pred_Pisos.antiguedad = (int)dgvPisos.SelectedRows[0].Cells["antiguedad"].Value;
            Pred_Pisos.antiguedad_id = (string)dgvPisos.SelectedRows[0].Cells["antiguedad_id"].Value;
            Pred_Pisos.estado = (bool)dgvPisos.SelectedRows[0].Cells["pestado"].Value;
            Pred_Pisos.area_comun = (decimal)dgvPisos.SelectedRows[0].Cells["area_comun"].Value;
            Pred_Pisos.area_construida = (decimal)dgvPisos.SelectedRows[0].Cells["area_construida"].Value;
            Pred_Pisos.banio = (string)dgvPisos.SelectedRows[0].Cells["banio"].Value;
            Pred_Pisos.clasificacion_id = (string)dgvPisos.SelectedRows[0].Cells["clasificacion_id"].Value;
            Pred_Pisos.condicion_id = (string)dgvPisos.SelectedRows[0].Cells["condicion_id"].Value;
            Pred_Pisos.estado_id = (string)dgvPisos.SelectedRows[0].Cells["estado_id"].Value;
            Pred_Pisos.fecha_construc = (DateTime)dgvPisos.SelectedRows[0].Cells["fecha_construc"].Value;
            Pred_Pisos.incremento = (decimal)dgvPisos.SelectedRows[0].Cells["incremento"].Value;
            Pred_Pisos.instalaciones = (string)dgvPisos.SelectedRows[0].Cells["instalaciones"].Value;
            Pred_Pisos.material_id = (string)dgvPisos.SelectedRows[0].Cells["material_id"].Value;
            Pred_Pisos.metros_alquilados = (decimal)dgvPisos.SelectedRows[0].Cells["metros_alquilados"].Value;
            Pred_Pisos.muro = (string)dgvPisos.SelectedRows[0].Cells["muro"].Value;
            Pred_Pisos.numero = (int)dgvPisos.SelectedRows[0].Cells["numero"].Value;
            Pred_Pisos.persona_ID = (string)dgvPisos.SelectedRows[0].Cells["persona_ID"].Value;
            Pred_Pisos.piso = (string)dgvPisos.SelectedRows[0].Cells["piso"].Value;
            Pred_Pisos.piso_ID = (int)dgvPisos.SelectedRows[0].Cells["piso_ID"].Value;
            Pred_Pisos.porcent_depreci = (decimal)dgvPisos.SelectedRows[0].Cells["porcent_depreci"].Value;
            Pred_Pisos.predio_ID = (string)dgvPisos.SelectedRows[0].Cells["ppredio_ID"].Value;
            Pred_Pisos.puerta = (string)dgvPisos.SelectedRows[0].Cells["puerta"].Value;
            Pred_Pisos.revestimiento = (string)dgvPisos.SelectedRows[0].Cells["revestimiento"].Value;
            Pred_Pisos.seccion = (string)dgvPisos.SelectedRows[0].Cells["seccion"].Value;
            Pred_Pisos.techo = (string)dgvPisos.SelectedRows[0].Cells["techo"].Value;
            Pred_Pisos.valor_comun = (decimal)dgvPisos.SelectedRows[0].Cells["valor_comun"].Value;
            Pred_Pisos.valor_construido = (decimal)dgvPisos.SelectedRows[0].Cells["valor_construido"].Value;
            Pred_Pisos.valor_construido_total = (decimal)dgvPisos.SelectedRows[0].Cells["valor_construido_total"].Value;
            Pred_Pisos.valor_unitario = (decimal)dgvPisos.SelectedRows[0].Cells["valor_unitario"].Value;
            Pred_Pisos.valor_unit_depreciado = (decimal)dgvPisos.SelectedRows[0].Cells["valor_unit_depreciado"].Value;
            return Pred_Pisos;
        }
        private void PisoslistarByPredio()
        {
            if (predioGlobal.predio_ID != null)
                ColeccionPisos = PisosDataService.listarByPredioID(predioGlobal.predio_ID.Trim());
            else
                ColeccionPisos = PisosDataService.listarByPredioID("0");

            dgvPisos.DataSource=ColeccionPisos;
            ActualizarAreaConstruida();
            PintarColumnasCalculadas();
        }
        private void dgvPisos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                DataGridViewColumn ColumnaOrdenar = dgvPisos.Columns[e.ColumnIndex];

                if (dgvPisos.SortOrder == SortOrder.None)
                {

                    if (ColumnaOrdenar.Name == "piso_ID")
                    {
                        if (OrdenPisos == SortOrder.Descending)
                        {
                            dgvPisos.DataSource = ColeccionPisos.OrderBy(p => p.piso_ID).ToList();
                            OrdenPisos = SortOrder.Ascending;
                        }
                        else
                        {
                            dgvPisos.DataSource = ColeccionPisos.OrderBy(p => p.piso_ID).Reverse().ToList();
                            OrdenPisos = SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "numero")
                    {
                        if (OrdenPisos == SortOrder.Descending)
                        {
                            dgvPisos.DataSource = ColeccionPisos.OrderBy(p => p.numero).ToList();
                            OrdenPisos = SortOrder.Ascending;
                        }
                        else
                        {
                            dgvPisos.DataSource = ColeccionPisos.OrderBy(p => p.numero).Reverse().ToList();
                            OrdenPisos = SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "seccion")
                    {
                        if (OrdenPisos == SortOrder.Descending)
                        {
                            dgvPisos.DataSource = ColeccionPisos.OrderBy(p => p.seccion).ToList();
                            OrdenPisos = SortOrder.Ascending;
                        }
                        else
                        {
                            dgvPisos.DataSource = ColeccionPisos.OrderBy(p => p.seccion).Reverse().ToList();
                            OrdenPisos = SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "antiguedad")
                    {
                        if (OrdenPisos == SortOrder.Descending)
                        {
                            dgvPisos.DataSource = ColeccionPisos.OrderBy(p => p.antiguedad).ToList();
                            OrdenPisos = SortOrder.Ascending;
                        }
                        else
                        {
                            dgvPisos.DataSource = ColeccionPisos.OrderBy(p => p.antiguedad).Reverse().ToList();
                            OrdenPisos = SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "techo")
                    {
                        if (OrdenPisos == SortOrder.Descending)
                        {
                            dgvPisos.DataSource = ColeccionPisos.OrderBy(p => p.techo).ToList();
                            OrdenPisos = SortOrder.Ascending;
                        }
                        else
                        {
                            dgvPisos.DataSource = ColeccionPisos.OrderBy(p => p.techo).Reverse().ToList();
                            OrdenPisos = SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "piso")
                    {
                        if (OrdenPisos == SortOrder.Descending)
                        {
                            dgvPisos.DataSource = ColeccionPisos.OrderBy(p => p.piso).ToList();
                            OrdenPisos = SortOrder.Ascending;
                        }
                        else
                        {
                            dgvPisos.DataSource = ColeccionPisos.OrderBy(p => p.piso).Reverse().ToList();
                            OrdenPisos = SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "puerta")
                    {
                        if (OrdenPisos == SortOrder.Descending)
                        {
                            dgvPisos.DataSource = ColeccionPisos.OrderBy(p => p.puerta).ToList();
                            OrdenPisos = SortOrder.Ascending;
                        }
                        else
                        {
                            dgvPisos.DataSource = ColeccionPisos.OrderBy(p => p.puerta).Reverse().ToList();
                            OrdenPisos = SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "revestimiento")
                    {
                        if (OrdenPisos == SortOrder.Descending)
                        {
                            dgvPisos.DataSource = ColeccionPisos.OrderBy(p => p.revestimiento).ToList();
                            OrdenPisos = SortOrder.Ascending;
                        }
                        else
                        {
                            dgvPisos.DataSource = ColeccionPisos.OrderBy(p => p.revestimiento).Reverse().ToList();
                            OrdenPisos = SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "banio")
                    {
                        if (OrdenPisos == SortOrder.Descending)
                        {
                            dgvPisos.DataSource = ColeccionPisos.OrderBy(p => p.banio).ToList();
                            OrdenPisos = SortOrder.Ascending;
                        }
                        else
                        {
                            dgvPisos.DataSource = ColeccionPisos.OrderBy(p => p.banio).Reverse().ToList();
                            OrdenPisos = SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "instalaciones")
                    {
                        if (OrdenPisos == SortOrder.Descending)
                        {
                            dgvPisos.DataSource = ColeccionPisos.OrderBy(p => p.instalaciones).ToList();
                            OrdenPisos = SortOrder.Ascending;
                        }
                        else
                        {
                            dgvPisos.DataSource = ColeccionPisos.OrderBy(p => p.instalaciones).Reverse().ToList();
                            OrdenPisos = SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "incremento")
                    {
                        if (OrdenPisos == SortOrder.Descending)
                        {
                            dgvPisos.DataSource = ColeccionPisos.OrderBy(p => p.incremento).ToList();
                            OrdenPisos = SortOrder.Ascending;
                        }
                        else
                        {
                            dgvPisos.DataSource = ColeccionPisos.OrderBy(p => p.incremento).Reverse().ToList();
                            OrdenPisos = SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "valor_unitario")
                    {
                        if (OrdenPisos == SortOrder.Descending)
                        {
                            dgvPisos.DataSource = ColeccionPisos.OrderBy(p => p.valor_unitario).ToList();
                            OrdenPisos = SortOrder.Ascending;
                        }
                        else
                        {
                            dgvPisos.DataSource = ColeccionPisos.OrderBy(p => p.valor_unitario).Reverse().ToList();
                            OrdenPisos = SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "porcent_depreci")
                    {
                        if (OrdenPisos == SortOrder.Descending)
                        {
                            dgvPisos.DataSource = ColeccionPisos.OrderBy(p => p.porcent_depreci).ToList();
                            OrdenPisos = SortOrder.Ascending;
                        }
                        else
                        {
                            dgvPisos.DataSource = ColeccionPisos.OrderBy(p => p.porcent_depreci).Reverse().ToList();
                            OrdenPisos = SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "valor_unit_depreciado")
                    {
                        if (OrdenPisos == SortOrder.Descending)
                        {
                            dgvPisos.DataSource = ColeccionPisos.OrderBy(p => p.valor_unit_depreciado).ToList();
                            OrdenPisos = SortOrder.Ascending;
                        }
                        else
                        {
                            dgvPisos.DataSource = ColeccionPisos.OrderBy(p => p.valor_unit_depreciado).Reverse().ToList();
                            OrdenPisos = SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "area_construida")
                    {
                        if (OrdenPisos == SortOrder.Descending)
                        {
                            dgvPisos.DataSource = ColeccionPisos.OrderBy(p => p.area_construida).ToList();
                            OrdenPisos = SortOrder.Ascending;
                        }
                        else
                        {
                            dgvPisos.DataSource = ColeccionPisos.OrderBy(p => p.area_construida).Reverse().ToList();
                            OrdenPisos = SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "valor_construido")
                    {
                        if (OrdenPisos == SortOrder.Descending)
                        {
                            dgvPisos.DataSource = ColeccionPisos.OrderBy(p => p.valor_construido).ToList();
                            OrdenPisos = SortOrder.Ascending;
                        }
                        else
                        {
                            dgvPisos.DataSource = ColeccionPisos.OrderBy(p => p.valor_construido).Reverse().ToList();
                            OrdenPisos = SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "area_comun")
                    {
                        if (OrdenPisos == SortOrder.Descending)
                        {
                            dgvPisos.DataSource = ColeccionPisos.OrderBy(p => p.area_comun).ToList();
                            OrdenPisos = SortOrder.Ascending;
                        }
                        else
                        {
                            dgvPisos.DataSource = ColeccionPisos.OrderBy(p => p.area_comun).Reverse().ToList();
                            OrdenPisos = SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "valor_comun")
                    {
                        if (OrdenPisos == SortOrder.Descending)
                        {
                            dgvPisos.DataSource = ColeccionPisos.OrderBy(p => p.valor_comun).ToList();
                            OrdenPisos = SortOrder.Ascending;
                        }
                        else
                        {
                            dgvPisos.DataSource = ColeccionPisos.OrderBy(p => p.valor_comun).Reverse().ToList();
                            OrdenPisos = SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "valor_construido_total")
                    {
                        if (OrdenPisos == SortOrder.Descending)
                        {
                            dgvPisos.DataSource = ColeccionPisos.OrderBy(p => p.valor_construido_total).ToList();
                            OrdenPisos = SortOrder.Ascending;
                        }
                        else
                        {
                            dgvPisos.DataSource = ColeccionPisos.OrderBy(p => p.valor_construido_total).Reverse().ToList();
                            OrdenPisos = SortOrder.Descending;
                        }
                    }
                   
                }

            }
        }
        private void dgvPisos_DoubleClick(object sender, EventArgs e)
        {
            tooleditarPisos.PerformClick();
        }
        private void ActualizarAreaConstruida()
        {
            int cantidad;
            decimal total = 0;
            decimal areacomun = 0;
            bool estado;
            cantidad = dgvPisos.RowCount;
            for (int i = 0; i < cantidad; i++)
            {
                estado = (bool)dgvPisos.Rows[i].Cells["pestado"].Value;
                if (estado)
                {
                    total = total + (decimal)dgvPisos.Rows[i].Cells["area_construida"].Value;
                    areacomun = areacomun + (decimal)dgvPisos.Rows[i].Cells["area_comun"].Value;

                }
            }
            txtAreaConstruida.Text = total.ToString();
            txtPOrcentajeAreaComun.Text = areacomun.ToString();
        }
        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvPisos.IsCurrentCellDirty)
            {
                dgvPisos.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void PintarColumnasCalculadas()
        {
            for (int i = 0; i < dgvPisos.RowCount; i++)
            {
                DataGridViewRow row = dgvPisos.Rows[i];
                DataGridViewTextBoxCell cellSelecion = row.Cells["porcent_depreci"] as DataGridViewTextBoxCell;
                cellSelecion.Style.BackColor = Color.Green;
                cellSelecion = row.Cells["valor_unit_depreciado"] as DataGridViewTextBoxCell;
                cellSelecion.Style.BackColor = Color.Green;
                cellSelecion = row.Cells["valor_construido"] as DataGridViewTextBoxCell;
                cellSelecion.Style.BackColor = Color.Green;
                cellSelecion = row.Cells["valor_comun"] as DataGridViewTextBoxCell;
                cellSelecion.Style.BackColor = Color.Green;
                cellSelecion = row.Cells["valor_construido_total"] as DataGridViewTextBoxCell;
                cellSelecion.Style.BackColor = Color.Green;
                cellSelecion = row.Cells["area_comun"] as DataGridViewTextBoxCell;
                cellSelecion.Style.BackColor = Color.GreenYellow;
                cellSelecion = row.Cells["area_construida"] as DataGridViewTextBoxCell;
                cellSelecion.Style.BackColor = Color.GreenYellow;
            }
        }
        //area_construida
        //I---------------------------------------------------------------------------------------------
        //I---------------------------------------------------------------------------------------------
        //FIN DE PISO
        //I---------------------------------------------------------------------------------------------
        //I---------------------------------------------------------------------------------------------





        //I---------------------------------------------------------------------------------------------
        //I---------------------------------------------------------------------------------------------
        //INICIO DE PREDIO-CONTRIBUYENTE
        //I---------------------------------------------------------------------------------------------
        //I---------------------------------------------------------------------------------------------
        private void toolnuevoContribuyentePredio_Click(object sender, EventArgs e)
        {
            Frm_PredioContribuyente_Detalle Frm_PredioContribuyente_Detalle;
            if (predioGlobal.predio_ID != null)//voy a editar predio pero voy a agregar
                Frm_PredioContribuyente_Detalle = new Frm_PredioContribuyente_Detalle(predioGlobal.predio_ID.Trim(), lblPeriodo.Text);
            else
            {
                if (TotalenGrilla(dgvContribuyentePredio) || persona_id_seleccionadanueva.Trim().Length == 0)//si no hay registros y voy a a gregar x primera vez q apresca x defecto el contribuyente seleccionado
                    Frm_PredioContribuyente_Detalle = new Frm_PredioContribuyente_Detalle("0", lblPeriodo.Text);
                else
                    Frm_PredioContribuyente_Detalle = new Frm_PredioContribuyente_Detalle("0", lblPeriodo.Text, persona_id_seleccionadanueva);
            }

            Frm_PredioContribuyente_Detalle.StartPosition = FormStartPosition.CenterParent;
            Frm_PredioContribuyente_Detalle.ShowDialog();
            ContribuyentePrediolistarByPredio();

            //this.persona_id_seleccionadanueva = p_id;
            //if (p_id.Trim().Length > 0)//selecciono una columna de contribuyente
            //{
            //    Frm_PredioContribuyente_Detalle frm_PredioContribuyente_Detalle = new Frm_PredioContribuyente_Detalle("0", lblPeriodo.Text, p_id);
            //    frm_PredioContribuyente_Detalle.StartPosition = FormStartPosition.CenterParent;
            //    frm_PredioContribuyente_Detalle.ShowDialog();
            //    tabControl1.TabIndex = 4;
            //}
        }
        private void tooleditarContribuyentePredio_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvContribuyentePredio.SelectedRows.Count > 0)
                {
                    Frm_PredioContribuyente_Detalle Frm_PredioContribuyente_Detalle = new Frm_PredioContribuyente_Detalle(obtenerdatosContPred());
                    Frm_PredioContribuyente_Detalle.StartPosition = FormStartPosition.CenterParent;
                    Frm_PredioContribuyente_Detalle.ShowDialog();
                    ContribuyentePrediolistarByPredio();
                }
                else
                    MessageBox.Show("Seleccione un elemento", Globales.Global_MessageBox);
            }
            catch (Exception ex)
            {

            }

        }
        private void ContribuyentePrediolistarByPredio()
        {
            if (predioGlobal.predio_ID != null)
                dgvContribuyentePredio.DataSource = PredContribuyenteDataService.listarByPredioID(predioGlobal.predio_ID.Trim(), Convert.ToInt16(periodo));
            else
                dgvContribuyentePredio.DataSource = PredContribuyenteDataService.listarByPredioID("0", Convert.ToInt16(periodo));
            if (dgvContribuyentePredio.RowCount > 0)
            {
                decimal total = ActualizarTotalPorcentajeContribuyente();
                PintarLblPorcentaje(total);
            }

        }
        private Pred_PredioContribuyente obtenerdatosContPred()
        {
            Pred_PredioContribuyente PredContribuyente = new Pred_PredioContribuyente();
            PredContribuyente.predio_contribuyente_id = (Int32)dgvContribuyentePredio.SelectedRows[0].Cells["predio_contribuyente_id"].Value;
            PredContribuyente.idPeriodo = (Int16)dgvContribuyentePredio.SelectedRows[0].Cells["idPeriodo"].Value;
            PredContribuyente.Fecha = (DateTime)dgvContribuyentePredio.SelectedRows[0].Cells["Fecha"].Value;
            PredContribuyente.Porcentaje_Condomino = (decimal)dgvContribuyentePredio.SelectedRows[0].Cells["Porcentaje_Condomino"].Value;
            PredContribuyente.ExonAutoValuo = (bool)dgvContribuyentePredio.SelectedRows[0].Cells["ExonAutoValuo"].Value;
            PredContribuyente.AnioCompra = (Int32)dgvContribuyentePredio.SelectedRows[0].Cells["AnioCompra"].Value;
            PredContribuyente.Predio_id = (string)dgvContribuyentePredio.SelectedRows[0].Cells["cPredio_id"].Value;
            PredContribuyente.persona_ID = (string)dgvContribuyentePredio.SelectedRows[0].Cells["cpersona_ID"].Value;
            PredContribuyente.tipo_adquisicion = (Int32)dgvContribuyentePredio.SelectedRows[0].Cells["tipo_adquisicion"].Value;
            PredContribuyente.tipo_posesion = (Int32)dgvContribuyentePredio.SelectedRows[0].Cells["tipo_posesion"].Value;
            PredContribuyente.expediente = (string)dgvContribuyentePredio.SelectedRows[0].Cells["expediente"].Value;
            PredContribuyente.observaciones = (string)dgvContribuyentePredio.SelectedRows[0].Cells["observaciones"].Value;
            PredContribuyente.estado = (bool)dgvContribuyentePredio.SelectedRows[0].Cells["cEstado"].Value;
            PredContribuyente.razon_social = (string)dgvContribuyentePredio.SelectedRows[0].Cells["razon_social"].Value;
            return PredContribuyente;
        }
        private void dgvContribuyentePredio_DoubleClick(object sender, EventArgs e)
        {
            tooleditarContribuyentePredio.PerformClick();
        }
        private void dgvContribuyentePredio_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                DataGridViewColumn ColumnaOrdenar = dgvContribuyentePredio.Columns[e.ColumnIndex];

                if (dgvContribuyentePredio.SortOrder == SortOrder.None)
                {

                    if (ColumnaOrdenar.Name == "predio_contribuyente_id")
                    {
                        if (OrdenPredioContribuyente == SortOrder.Descending)
                        {
                            dgvContribuyentePredio.DataSource = ColeccionPredioContribuyente.OrderBy(p => p.predio_contribuyente_id).ToList();
                            OrdenPredioContribuyente = SortOrder.Ascending;
                        }
                        else
                        {
                            dgvContribuyentePredio.DataSource = ColeccionPredioContribuyente.OrderBy(p => p.predio_contribuyente_id).Reverse().ToList();
                            OrdenPredioContribuyente = SortOrder.Descending;
                        }
                    }

                }

            }
        }
        private decimal ActualizarTotalPorcentajeContribuyente()
        {
            try {
                int cantidad;
                decimal total = 0;
                cantidad = dgvContribuyentePredio.RowCount;
                if (cantidad == 0)
                    return 0;
                for (int i = 0; i < cantidad; i++)
                {
                    DataGridViewRow row = dgvContribuyentePredio.Rows[i];
                    DataGridViewCheckBoxCell cellSelecion = row.Cells["cEstado"] as DataGridViewCheckBoxCell;
                    if (Convert.ToBoolean(cellSelecion.Value))
                    {
                        total = total + (decimal)row.Cells["Porcentaje_Condomino"].Value;
                    }
                }

                return total;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),Globales.Global_MessageBox);
                return 0;
            }
            

            
        }
        private void PintarLblPorcentaje(Decimal total)
        {
            try {
                int a = 0;
                decimal b;
                if (total < 100)
                {
                    lblPorcentaje.ForeColor = System.Drawing.Color.Red;
                    lblPorcentaje.Text = "Porcentaje Incompleto,falta (" + (100 - total).ToString() + "%)";
                }
                else if (total > 100 && Convert.ToInt32(total) % 100 == 0)
                {
                    b = total / 100;
                    a = Convert.ToInt32(b);
                    lblPorcentaje.ForeColor = System.Drawing.Color.Red;
                    lblPorcentaje.Text = "Hay " + a.ToString() + " que pagaran igual el 100%";
                }
                else if (total > 100 && Convert.ToInt32(total) % 100 != 0)
                {
                    lblPorcentaje.ForeColor = System.Drawing.Color.Red;
                    lblPorcentaje.Text = "Porcentaje con Exceso,sobra (" + (total - 100).ToString() + "%)";
                }
                else
                {
                    lblPorcentaje.ForeColor = System.Drawing.Color.Navy;
                    lblPorcentaje.Text = "Porcentaje completo (" + total.ToString() + "%)";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Globales.Global_MessageBox);
            }
           
        }







        //I---------------------------------------------------------------------------------------------
        //I---------------------------------------------------------------------------------------------
        //FIN DE PREDIO CONTRIBUYENTE
        //I---------------------------------------------------------------------------------------------
        //I---------------------------------------------------------------------------------------------
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {

                if (predioGlobal.predio_ID == null)//nuevo
                {
                    if (MessageBox.Show("Esta seguro que desea cancelar?, se perderan TODOS LOS DATOS", Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (TotalenGrilla(dgvOtrasInstalaciones))
                            Pred_OtrasInstalacionesDataService.CancelarOtrasInstalacionEnPredio(usser);
                        if (TotalenGrilla(dgvPisos))
                            PisosDataService.CancelarPisosEnPredio(usser);
                        if (TotalenGrilla(dgvContribuyentePredio))
                            PredContribuyenteDataService.CancelarPredioContribuyenteEnPredio(usser, periodo);
                        if (TotalenGrilla(dgvArbitriosAsignados))
                            pred_PrredioArbitrioDataService.CancelarArbitriosEnPredio(usser);
                        cerro = true;
                        this.Close();
                    }

                }
                else
                {
                    if (MessageBox.Show("Esta seguro que desea cancelar?, se perderan los 'Datos Generales','Datos Terreno','Datos de Imàgenes' no  guardados", Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cerro = true;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }

        }

        private void Frm_Predio_Deta_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!cerro)
                btnCancelar.PerformClick();
        }

        private void ckbSeleccionarTodos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int cantidad;
                cantidad = dgvTablaArancelArb.RowCount;
                decimal total = 0;
                decimal valor = 0;
                for (int i = 0; i < cantidad; i++)
                {
                    DataGridViewRow row1 = dgvTablaArancelArb.Rows[i];
                    DataGridViewCheckBoxCell cellSelecion1 = row1.Cells["ArbitroxActivar"] as DataGridViewCheckBoxCell;
                    cellSelecion1.Value = ckbSeleccionarTodos.Checked;
                    valor = (decimal)row1.Cells["Costo"].Value;
                    total = total + valor;

                }
                if (ckbSeleccionarTodos.Checked)
                {
                    txtTotalArbitrio.Text = total.ToString();
                }
                else
                {
                    txtTotalArbitrio.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void dgvTablaArancelArb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvTablaArancelArb.Columns[e.ColumnIndex].Name == "ArbitroxActivar")
                {
                    decimal total = Convert.ToDecimal(txtTotalArbitrio.Text);
                    if (e.RowIndex == -1)
                        return;
                    int cantidad;
                    cantidad = dgvTablaArancelArb.RowCount;
                    DataGridViewRow row = dgvTablaArancelArb.Rows[e.RowIndex];
                    DataGridViewCheckBoxCell cellSelecion = row.Cells["ArbitroxActivar"] as DataGridViewCheckBoxCell;
                    decimal valor = (decimal)row.Cells["Costo"].Value;
                    if (Convert.ToBoolean(cellSelecion.Value))
                        total = total + valor;
                    else
                        total = total - valor;

                    txtTotalArbitrio.Text = total.ToString();
                }//

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void dgvTablaArancelArb_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvTablaArancelArb.IsCurrentCellDirty)
            {
                dgvTablaArancelArb.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void toolAgregarArbitrio_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidad;
                cantidad = dgvTablaArancelArb.RowCount;
                int id;
                bool bandera;
                Pred_PrredioArbitrio pred_PrredioArbitrio = new Pred_PrredioArbitrio();
                pred_PrredioArbitrio.idPeriodo = periodo.ToString();
                if (predioGlobal.predio_ID != null)//voy a editar predio pero voy a agregar
                    pred_PrredioArbitrio.Predio_id = predioGlobal.predio_ID.Trim();
                else
                    pred_PrredioArbitrio.Predio_id = "0";
                for (int i = 0; i < cantidad; i++)
                {
                    DataGridViewRow row = dgvTablaArancelArb.Rows[i];
                    DataGridViewCheckBoxCell cellSelecion = row.Cells["ArbitroxActivar"] as DataGridViewCheckBoxCell;
                    bandera = Convert.ToBoolean(cellSelecion.Value);
                    if (bandera)
                    {
                        pred_PrredioArbitrio.idTablaArancel = (int)row.Cells["idTablaArancel"].Value;
                        pred_PrredioArbitrio.registro_user_add = usser;


                        pred_PrredioArbitrioDataService.Insert(pred_PrredioArbitrio);
                    }
                }

                dgvTablaArancelArb.DataSource = mant_TablaArancelDataService.listarActivosConCosto(pred_PrredioArbitrio.Predio_id, periodo.ToString());
                dgvArbitriosAsignados.DataSource = pred_PrredioArbitrioDataService.listartodos(pred_PrredioArbitrio.Predio_id, periodo.ToString());
                ActualizarTotalArbitrio();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Globales.Global_MessageBox);
            }
        }

        private void toolDesactivarArbitro_Click(object sender, EventArgs e)
        {

            modificarEstadoArbitriosAsignados(false);
        }

        private void toolActivarArbitrio_Click(object sender, EventArgs e)
        {
            modificarEstadoArbitriosAsignados(true);
        }
        private void modificarEstadoArbitriosAsignados(bool bande)
        {
            try
            {
                if (dgvArbitriosAsignados.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("No se puede realizar esta petición", Globales.Global_MessageBox);
                    return;
                }
                if ((bool)dgvArbitriosAsignados.SelectedRows[0].Cells["EstadoAsig"].Value == bande)
                {
                    MessageBox.Show("No se puede realizar esta petición", Globales.Global_MessageBox);
                    return;
                }
                Pred_PrredioArbitrio pred_PrredioArbitrio = new Pred_PrredioArbitrio();
                decimal nuevototal = 0;
                decimal nuevo = (decimal)dgvArbitriosAsignados.SelectedRows[0].Cells["costoAsig"].Value;
                if (dgvArbitriosAsignados.SelectedRows.Count > 0)
                {
                    pred_PrredioArbitrio.Estado = bande;
                    pred_PrredioArbitrio.registro_user_update = usser;
                    pred_PrredioArbitrio.idPredioArbitrio = (int)dgvArbitriosAsignados.SelectedRows[0].Cells["idPredioArbitrio"].Value;
                    pred_PrredioArbitrioDataService.Update(pred_PrredioArbitrio);
                    if (predioGlobal.predio_ID != null)//voy a editar predio pero voy a agregar
                        pred_PrredioArbitrio.Predio_id = predioGlobal.predio_ID.Trim();
                    else
                        pred_PrredioArbitrio.Predio_id = "0";
                    dgvTablaArancelArb.DataSource = mant_TablaArancelDataService.listarActivosConCosto(pred_PrredioArbitrio.Predio_id, periodo.ToString());
                    dgvArbitriosAsignados.DataSource = pred_PrredioArbitrioDataService.listartodos(pred_PrredioArbitrio.Predio_id, periodo.ToString());
                    if (bande)
                        nuevototal = Convert.ToDecimal(txtTotalArbitrioAsignado.Text) + nuevo;
                    else
                        nuevototal = Convert.ToDecimal(txtTotalArbitrioAsignado.Text) - nuevo;
                    txtTotalArbitrioAsignado.Text = nuevototal.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Globales.Global_MessageBox);
            }

        }
        private void dgvArbitriosAsignados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bool stado = (bool)dgvArbitriosAsignados.SelectedRows[0].Cells["EstadoAsig"].Value;
            toolActivarArbitrio.Enabled = !stado;
            toolDesactivarArbitro.Enabled = stado;
        }
        private void ActualizarTotalArbitrio()
        {
            decimal TotalenGrilla = 0;
            for (int i = 0; i < dgvArbitriosAsignados.RowCount; i++)
            {
                DataGridViewRow row = dgvArbitriosAsignados.Rows[i];
                DataGridViewCheckBoxCell cellSelecion = row.Cells["EstadoAsig"] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(cellSelecion.Value))
                {
                    TotalenGrilla = TotalenGrilla + (decimal)row.Cells["costoAsig"].Value;
                }
            }
            txtTotalArbitrioAsignado.Text = TotalenGrilla.ToString();
            txtTotalArbitrio.Text = "0";
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            int index = this.tabControl1.SelectedIndex;
            int selec = index - 1;
            if (selec > -1)
                this.tabControl1.SelectedIndex = selec;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            int index = this.tabControl1.SelectedIndex;
            int total = this.tabControl1.TabCount;
            int selec = index + 1;
            if (selec < total)
                this.tabControl1.SelectedIndex = selec;
        }

        private void cboClasificacionRustico_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarArancel();
        }

        private void txtCuadra_TextChanged(object sender, EventArgs e)
        {

            if (txtCuadra.Text.Trim().Length != 0)
                cargarArancel();
        }

        private void txtLado_TextChanged(object sender, EventArgs e)
        {
            if (txtLado.Text.Trim().Length != 0)
                cargarArancel();
        }

        private void txtCatastro_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.validaNumeroEntero(e, Globales.Global_MessageBox);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private bool TotalenGrilla(DataGridView dgv)
        {
            if (dgv.RowCount > 0)
                return true;
            return false;
        }
    }
}
