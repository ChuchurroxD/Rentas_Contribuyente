using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGR.Core.Service;
using SGR.Core.Service.Combos;
using SGR.Entity.Model;
using SGR.Entity;
using SGR.Entity.Model.Combos;
using SGR.WinApp.Layout._4_Procesos.Predio.Pisos;
using SGR.WinApp.Layout._4_Procesos.Predio.OtrasInstalaciones;
using SGR.WinApp.Layout._4_Procesos.Predio.PredioContribuyente;
using SGR.WinApp.Layout._4_Procesos.Predio.PredioMasivo;

namespace SGR.WinApp.Layout._4_Procesos.Predio.Fiscalizacion
{
    public partial class Frm_Fiscalizacion_Nuevo : Form
    {
        private List<Mant_Periodo> periodos = new List<Mant_Periodo>();
        private Pred_PrredioArbitrioDataService pred_PrredioArbitrioDataService = new Pred_PrredioArbitrioDataService();
        private Mant_PeriodoDataService PeriodoDataService = new Mant_PeriodoDataService();
        private Pred_FiscalizacionDataService FiscalizacionDataService = new Pred_FiscalizacionDataService();
        private Mant_TablaArancelDataService mant_TablaArancelDataService = new Mant_TablaArancelDataService();
        private Conf_MultitablaDataService conf_MultitablaDataService = new Conf_MultitablaDataService();
        private Pred_PredioDataService Pred_PredioDataService = new Pred_PredioDataService();
        private Mant_JuntaViaDataService mant_JuntaViaDataService = new Mant_JuntaViaDataService();
        private Pred_ViasDataService pred_ViasDataService = new Pred_ViasDataService();
        private Mant_ArancelDataService mant_ArancelDataService = new Mant_ArancelDataService();
        private Mant_HistorialDataService mant_HistoriaDataService = new Mant_HistorialDataService();
        private Mant_ArancelRusticoDataService mant_ArancelRusticoDataService = new Mant_ArancelRusticoDataService();
        private List<Pred_OtrasInstalaciones> ColeccionOtrasInstalaciones;
        private SortOrder Orden = new SortOrder();
        private Pred_OtrasIntalacionesDataService Pred_OtrasInstalacionesDataService = new Pred_OtrasIntalacionesDataService();
        private List<Pred_Pisos> ColeccionPisos;
        private SortOrder OrdenPisos = new SortOrder();
        private Pred_PisosDataService PisosDataService = new Pred_PisosDataService();
        private List<Pred_PredioContribuyente> ColeccionPredioContribuyente;
        private SortOrder OrdenPredioContribuyente = new SortOrder();
        Pred_PredioContribuyenteDataService PredContribuyenteDataService = new Pred_PredioContribuyenteDataService();
        private string casa = "", mapa = "";
        private Sistema.Globales.Validaciones obValidacion = new Sistema.Globales.Validaciones();
        private String persona_id_seleccionadanueva;
        private bool cerro = false;
        string usser = GlobalesV1.Global_str_Usuario;
        private string predio_id_general = "";
        public Frm_Fiscalizacion_Nuevo(String persona_id, String persona_name)
        {
            try
            {
                DateTime fechaHoy = DateTime.Now;
                string cadena = fechaHoy.Year.ToString() + fechaHoy.Month.ToString() + fechaHoy.Day.ToString() +
                                  fechaHoy.Hour.ToString() + fechaHoy.Minute.ToString() + fechaHoy.Second.ToString() + fechaHoy.Millisecond.ToString() + "00000000000";

                string caracteres = cadena.Substring(1, 11);
                predio_id_general = "a" + caracteres;
                //txtPredioIDD.Text = predio_id_general;
                InitializeComponent();
                cargartipoSelector();
                llenarCboSector();
                lblContribuyente.Text = persona_name;
                this.persona_id_seleccionadanueva = persona_id;
                periodos = PeriodoDataService.GetAllMant_Periodo();
                cboAnioIni.DisplayMember = "Peric_canio";
                cboAnioIni.ValueMember = "Peric_canio";
                cboAnioIni.DataSource = periodos;
                cboAnioFin.DisplayMember = "Peric_canio";
                cboAnioFin.ValueMember = "Peric_canio";
                cboAnioFin.DataSource = periodos;
                dgvTablaArancelArb.DataSource = mant_TablaArancelDataService.listarActivosConCosto(predio_id_general, cboAnioIni.SelectedValue.ToString());
                dgvArbitriosAsignados.DataSource = pred_PrredioArbitrioDataService.listartodos(predio_id_general, cboAnioIni.SelectedValue.ToString());
                ActualizarTotalArbitrio();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }
        private decimal ActualizarTotalPorcentajeContribuyente()
        {
            try
            {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Globales.Global_MessageBox);
                return 0;
            }

        }
        private void PintarLblPorcentaje(Decimal total)
        {
            try
            {
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
        private void llenarCboSector()
        {
            cboSector.ValueMember = "sector_id";
            cboSector.DisplayMember = "descripcion";
            cboSector.DataSource = mant_ArancelDataService.llenarSector(GlobalesV1.Global_int_idoficina);
            this.cboSector.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.cboSector.AutoCompleteSource = AutoCompleteSource.CustomSource;
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
            lblTipoOperacion.ForeColor = System.Drawing.Color.Black;
            lblDescripcionHistorial.ForeColor = System.Drawing.Color.Black;
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
            //if (txtVia.Text.Trim().Length == 0 && txtInterior.Text.Trim().Length == 0 && txtKm.Text.Trim().Length == 0 && txtLote.Text.Trim().Length == 0 &&
            //    txtMz.Text.Trim().Length == 0 && txtEdificio.Text.Trim().Length == 0 && txtDpto.Text.Trim().Length == 0 && txtPiso.Text.Trim().Length == 0 &&
            //    txtTienda.Text.Trim().Length == 0)
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
                    msj = msj + "Falta Historial.";

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
                if (Convert.ToDecimal(txtAreaTotal.Text) < 0)
                {
                    MessageBox.Show("El Área del terreno debe ser mayor que 0", Globales.Global_MessageBox);
                    return;
                }
                if (!TotalenGrilla(dgvContribuyentePredio))
                {
                    MessageBox.Show("Llene por lo menos un contribuyente en el Predio", Globales.Global_MessageBox);
                    return;
                }
                Pred_Predio predio = new Pred_Predio();
                predio.predio_ID = predio_id_general;
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
                if (Pred_PredioDataService.existeDireccion(predio.junta_via_ID, predio.num_via, predio.interior,
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
                    //MessageBox.Show("Ya existe predio en dirección", Globales.Global_MessageBox);
                    //return;
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
                    //predio.num_ficha = txtFicha.Text.Trim().ToString();
                    predio.tipo_adquisicion = Convert.ToInt32(cboTipoAdquisicionNormal.SelectedValue.ToString());
                    predio.clase_edificacion = Convert.ToInt32(cboClasificacionRustico.SelectedValue.ToString());
                    predio.fecha_adquisicion = dtpFechaAdquisicion.Value;
                    DateTime fechaHoy = DateTime.Now;
                    predio.porcen_area_comun = 0;
                    predio.anio_adquisicion = Convert.ToInt16((predio.fecha_adquisicion).Year.ToString());
                    predio.clasificacion_rustico = Convert.ToInt16(cboClasificacionRustico.SelectedValue.ToString());
                    predio.categoria_rustico = Convert.ToInt16(cboCategoriaRustico.SelectedValue.ToString());
                    predio.tipo_rustico = Convert.ToInt16(cboTipoRustico.SelectedValue.ToString());
                    predio.uso_rustico = Convert.ToInt16(cboUsoPredioRustico.SelectedValue.ToString());
                    predio.hectareas = Convert.ToDecimal(txtAreaTotal.Text);
                    predio.estado = true;
                    predio.expediente = txtExpediente.Text.Trim();
                    predio.lista_negra = false;
                    predio.sector = Convert.ToInt16(cboSector.SelectedValue.ToString());
                    predio.arancel = Convert.ToDecimal(lblArancel.Text.Trim());
                    predio.Fiscalizado = "0";
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
                    predio.estado = ckbEstado.Checked;
                    predio.Fiscalizado = (ckbFiscalizado.Checked) ? "1" : "0";
                    predio.lista_negra = ckbListaNegra.Checked;
                    predio_id_general = Pred_PredioDataService.InsertVariosAños(predio, Convert.ToInt32(cboAnioIni.SelectedValue), Convert.ToInt32(cboAnioFin.SelectedValue));
                    Mant_Historial mant_Historial1 = new Mant_Historial();
                    msj = "";
                    if (txtDescripcionHistorial.Text.Trim().Length!=0 && txtExpediente.Text.Trim().Length != 0) {
                        mant_Historial1.idPredio = predio_id_general;
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
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    //this.Close();
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
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            if (MessageBox.Show("Esta seguro que desea cancelar?, se perderan TODOS LOS DATOS", Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Pred_PredioDataService.CancelTemporal(predio_id_general);
                cerro = true;
                this.Close();
            }

        }
        private bool TotalenGrilla(DataGridView dgv)
        {
            if (dgv.RowCount > 0)
                return true;
            return false;
        }
        private void cargartipoSelector()
        {
            llenarCboMultitabla(cboTipoTerreno, "Multc_vDescripcion", "Multc_cValor", "5");
            llenarCboMultitabla(cboFrenteA, "Multc_vDescripcion", "Multc_cValor", "14");
            llenarCboMultitabla(cboTipoUso, "Multc_vDescripcion", "Multc_cValor", "8");
            llenarCboMultitabla(cboEstadoTerreno, "Multc_vDescripcion", "Multc_cValor", "7");
            llenarCboMultitabla(cboTipoPredio, "Multc_vDescripcion", "Multc_cValor", "11");
            llenarCboMultitabla(cboTipoAdquisicionNormal, "Multc_vDescripcion", "Multc_cValor", "4");
            llenarCboMultitabla(cboTipoOperacion, "Multc_vDescripcion", "Multc_cValor", "12");
            llenarCboMultitabla(cboTipoPosesion, "Multc_vDescripcion", "Multc_cValor", "18");
            //rústico
            llenarCboMultitabla(cboTipoRustico, "Multc_vDescripcion", "Multc_cValor", "29");
            llenarCboMultitabla(cboUsoPredioRustico, "Multc_vDescripcion", "Multc_cValor", "30");
            llenarCboMultitabla(cboClasificacionRustico, "Multc_vDescripcion", "Multc_cValor", "28");
            llenarCboMultitabla(cboCategoriaRustico, "Multc_vDescripcion", "Multc_cValor", "35");
            llenarCboMultitabla(cboCondicionRustico, "Multc_vDescripcion", "Multc_cValor", "29");
            //llenarCboMultitabla(cboGrupoTierraR, "Multc_vDescripcion", "Multc_cValor", "28");
            llenarCboMultitabla(cboAntiguedad, "Multc_vDescripcion", "Multc_cValor", "71");
        }
        private void llenarCboMultitabla(ComboBox cbo, String display, String valor, String tipo)
        {
            cbo.DisplayMember = display;
            cbo.ValueMember = valor;
            cbo.DataSource = conf_MultitablaDataService.GetCboConf_Multitabla(tipo);
        }

        private void btnCasa_Click(object sender, EventArgs e)
        {
            ofdCasa.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|Png Image|*.png";
            ofdCasa.Title = "Seleccione una imagen";
            ofdCasa.ShowDialog();
        }

        private void btnMapa_Click(object sender, EventArgs e)
        {
            ofdMapa.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|Png Image|*.png";
            ofdMapa.Title = "Seleccione una imagen";
            ofdMapa.ShowDialog();
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

        private void ofdMapa_FileOk(object sender, CancelEventArgs e)
        {
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
        private string subirImagen(string origen, string nombreArchivo)
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

        private void toolnuevoOtrasInstalaciones_Click(object sender, EventArgs e)
        {
            Frm_OtrasIntalaciones_Detalle Frm_OtrasIntalaciones_Detalle;
            Frm_OtrasIntalaciones_Detalle = new Frm_OtrasIntalaciones_Detalle(predio_id_general, Convert.ToInt32(cboAnioIni.SelectedValue), Convert.ToInt32(cboAnioFin.SelectedValue));
            Frm_OtrasIntalaciones_Detalle.StartPosition = FormStartPosition.CenterParent;
            Frm_OtrasIntalaciones_Detalle.ShowDialog();
            dgvOtrasInstalaciones.DataSource = Pred_OtrasInstalacionesDataService.listarByPredioId(predio_id_general);
        }
        private void toolnuevoContribuyentePredio_Click(object sender, EventArgs e)
        {
            try
            {

                Frm_PredioContribuyenteAnterior_Detalle Frm_PredioContribuyenteAnterior_Detalle =
                    new Frm_PredioContribuyenteAnterior_Detalle(Convert.ToInt32(cboAnioIni.SelectedValue), Convert.ToInt32(cboAnioFin.SelectedValue), persona_id_seleccionadanueva, predio_id_general);
                Frm_PredioContribuyenteAnterior_Detalle.StartPosition = FormStartPosition.CenterParent;
                Frm_PredioContribuyenteAnterior_Detalle.ShowDialog();
                dgvContribuyentePredio.DataSource = PredContribuyenteDataService.listarByPredioID(predio_id_general, Convert.ToInt16(cboAnioIni.SelectedValue));
                decimal total = ActualizarTotalPorcentajeContribuyente();
                PintarLblPorcentaje(total);
            }
            catch (Exception ex)
            {

            }

        }

        private void toolnuevoPisos_Click(object sender, EventArgs e)
        {
            Frm_Pisos_Detalle Frm_Pisos_Detalle = new Frm_Pisos_Detalle(predio_id_general, Convert.ToInt32(cboAnioIni.SelectedValue), Convert.ToInt32(cboAnioFin.SelectedValue));
            Frm_Pisos_Detalle.StartPosition = FormStartPosition.CenterParent;
            Frm_Pisos_Detalle.ShowDialog();
            dgvPisos.DataSource = PisosDataService.listarByPredioID(predio_id_general);
            ActualizarAreaConstruida();
        }

        private void cboAnioFin_SelectedIndexChanged(object sender, EventArgs e)
        {
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

        private void txtCuadra_TextChanged(object sender, EventArgs e)
        {
            cargarArancel();
        }

        private void txtLado_TextChanged(object sender, EventArgs e)
        {
            cargarArancel();
        }

        private void cboCategoriaRustico_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarArancel();
        }

        private void cboClasificacionRustico_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarArancel();
        }
        private void cargarArancel()
        {
            try
            {
                decimal valor = 0;
                int a = String.Compare(cboTipoTerreno.SelectedValue.ToString(), "1");
                int b = String.Compare(cboCalle.SelectedValue.ToString().Trim(), "");
                int c = String.Compare(cboSector.SelectedValue.ToString().Trim(), "");

                if (String.Compare(cboTipoTerreno.SelectedValue.ToString(), "1") == 0 &&
                    String.Compare(cboCalle.SelectedValue.ToString().Trim(), "") != 0 &&
                    String.Compare(cboSector.SelectedValue.ToString().Trim(), "") != 0)//URBANO
                {
                    int jv = mant_JuntaViaDataService.GetJuntaVia_id(int.Parse(cboSector.SelectedValue.ToString()), int.Parse(cboCalle.SelectedValue.ToString()));
                    valor = mant_ArancelDataService.GetMonto(jv, Convert.ToInt32(cboAnioIni.SelectedValue), Convert.ToInt32(txtLado.Text), Convert.ToInt32(txtCuadra.Text));
                    lblArancel.Text = valor.ToString();
                }
                else if (String.Compare(cboTipoTerreno.SelectedValue.ToString(), "2") == 0 &&
                    String.Compare(cboClasificacionRustico.SelectedValue.ToString().Trim(), "") != 0 &&//grupo de tierra
                    String.Compare(cboCategoriaRustico.SelectedValue.ToString().Trim(), "") != 0)//rustico
                {
                    valor = mant_ArancelRusticoDataService.GetMontoRustico(cboClasificacionRustico.SelectedValue.ToString().Trim(), Convert.ToInt32(cboAnioIni.SelectedValue), cboCategoriaRustico.SelectedValue.ToString().Trim());
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
                }
                else
                {
                    llenarCboMultitabla(cboTipoUso, "Multc_vDescripcion", "Multc_cValor", "30");//verificar si es asi
                    gpbPredioRustico.Enabled = true;
                    gpbArancelarioRustico.Enabled = true;
                    //gpbPredioUrbano.Enabled = false;
                }
            }
            catch (Exception ex) { }

            cargarArancel();
        }

        private void txtPersonas_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.validaNumeroEntero(e, Globales.Global_MessageBox);
        }
        private void txtExpediente_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.validaNumeroEntero(e, Globales.Global_MessageBox);
        }
        private void txtAreaTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.ValidarNumeroDecimal(e, txtAreaTotal.Text, Globales.Global_MessageBox);
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

        private void Frm_Fiscalizacion_Nuevo_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!cerro)
                btnCancelar.PerformClick();
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
                pred_PrredioArbitrio.Predio_id = predio_id_general;
                pred_PrredioArbitrio.idPeriodo = cboAnioIni.SelectedValue.ToString();


                for (int i = 0; i < cantidad; i++)
                {
                    DataGridViewRow row = dgvTablaArancelArb.Rows[i];
                    DataGridViewCheckBoxCell cellSelecion = row.Cells["ArbitroxActivar"] as DataGridViewCheckBoxCell;
                    bandera = Convert.ToBoolean(cellSelecion.Value);
                    if (bandera)
                    {
                        pred_PrredioArbitrio.idTablaArancel = (int)row.Cells["idTablaArancel"].Value;
                        pred_PrredioArbitrio.registro_user_add = usser;


                        pred_PrredioArbitrioDataService.InsertVariosAños(pred_PrredioArbitrio, cboAnioFin.SelectedValue.ToString());
                    }
                }

                dgvTablaArancelArb.DataSource = mant_TablaArancelDataService.listarActivosConCosto(predio_id_general, cboAnioIni.SelectedValue.ToString());
                dgvArbitriosAsignados.DataSource = pred_PrredioArbitrioDataService.listartodos(predio_id_general, cboAnioIni.SelectedValue.ToString());
                ActualizarTotalArbitrio();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Globales.Global_MessageBox);
            }
        }
        private void dgvArbitriosAsignados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        //private void btnCalcular_Click(object sender, EventArgs e)
        //{
        //    try {
        //        Frm_CalculoIndividualPorAños Frm_CalculoIndividualPorAños = new Frm_CalculoIndividualPorAños(cboAnioIni.SelectedValue.ToString(), cboAnioFin.SelectedValue.ToString(), predio_id_general);
        //        Frm_CalculoIndividualPorAños.StartPosition = FormStartPosition.CenterParent;
        //        Frm_CalculoIndividualPorAños.ShowDialog();
        //    } catch(Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString(), Globales.Global_MessageBox);
        //    }
        //}

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
            }
        }

    }
}
