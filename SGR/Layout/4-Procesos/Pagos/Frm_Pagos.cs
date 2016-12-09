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
using SGR.Entity;
using WeifenLuo.WinFormsUI.Docking;
using SGR.Core.Service.Combos;
using SGR.Entity.Model.Combos;
using SGR.WinApp.Layout._5_Reportes_Gestion;
using Microsoft.Reporting.WinForms;

namespace SGR.WinApp.Layout._4_Procesos.Pagos
{
    public partial class Frm_Pagos : DockContent
    {

        AutoCompleteStringCollection source = new AutoCompleteStringCollection();
        int indice = 0;
        
        decimal montoAgrupado = 0;
        List<Pago_OtrosPagos> coleccionOtros = new List<Pago_OtrosPagos>();
        private Mant_BancoDataService Mant_BancoDataService = new Mant_BancoDataService();
        Liqu_LiquidacionDataService liquidacion = new Liqu_LiquidacionDataService();
        Frac_FraccionamientoDataService fraccionamiento = new Frac_FraccionamientoDataService();
        Reci_ReciboDataService recibos = new Reci_ReciboDataService();
        Liqu_Liquidacion elemento = new Liqu_Liquidacion();
        Frac_Fraccionamiento elemento2 = new Frac_Fraccionamiento();
        Conf_MultitablaDataService tablas = new Conf_MultitablaDataService();
        Pago_PagosDataService pagos = new Pago_PagosDataService();
        Pago_PersonaDataService persona = new Pago_PersonaDataService();
        private Sistema.Globales.Validaciones obValidacion = new Sistema.Globales.Validaciones();
        Mant_PeriodoDataService periodos = new Mant_PeriodoDataService();
        string solesE, dolaresE, solesT, dolaresT, solesC;
        decimal valorCuota = 0;
        int cod_fracc = 0;
        int nroCuota = 0;
        int cod_recibo = 0;

        public Frm_Pagos()
        {
            InitializeComponent();
            source.AddRange(new string[]
                        {
                        "January",
                        "February",
                        "March",
                        "April",
                        "May",
                        "June",
                        "July",
                        "August",
                        "September",
                        "October",
                        "November",
                        "December"
                        });
            textBox17.AutoCompleteCustomSource = source;
            textBox17.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox17.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cargarCombos();
        }

        public void cargarCombos()
        {
            try
            {
                cboTipoPago.DisplayMember = "Multc_vDescripcion";
                cboTipoPago.ValueMember = "Multc_cValor";
                cboTipoPago.DataSource = tablas.GetCboConf_Multitabla("45");

                cboConcepto.DisplayMember = "Multc_vDescripcion";
                cboConcepto.ValueMember = "Multc_cValor";
                cboConcepto.DataSource = pagos.listarConceptos();


                cboBanco.DisplayMember = "descripcion";
                cboBanco.ValueMember = "banco_ID";
                cboBanco.DataSource = Mant_BancoDataService.listaActivos();
                List<Pago_Persona> coleccion = new List<Pago_Persona>();
                coleccion = persona.listartodos("");

                cboPersona.DisplayMember = "persona_Desc";
                cboPersona.ValueMember = "persona_ID";
                cboPersona.DataSource = coleccion;

                cboPersona2.DisplayMember = "persona_Desc";
                cboPersona2.ValueMember = "persona_ID";
                cboPersona2.DataSource = coleccion;

                cboPersonaRecibo.DisplayMember = "persona_Desc";
                cboPersonaRecibo.ValueMember = "persona_ID";
                cboPersonaRecibo.DataSource = coleccion;

                cboContribuyente.DisplayMember = "persona_Desc";
                cboContribuyente.ValueMember = "persona_ID";
                cboContribuyente.DataSource = coleccion;

                cboPeriodoRegistros.DisplayMember = "Peric_canio";
                cboPeriodoRegistros.ValueMember = "Peric_canio";
                cboPeriodoRegistros.DataSource = periodos.GetAllMant_Periodo();

                cboTarjeta.DisplayMember = "Multc_vDescripcion";
                cboTarjeta.ValueMember = "Multc_cValor";
                cboTarjeta.DataSource = tablas.GetCboConf_Multitabla("31");
                Pago_Parametros elemento = new Pago_Parametros();
                elemento = pagos.obtenerParametros();
                txtFecha.Value = elemento.fecha;
                txtTasa.Text = Convert.ToString(elemento.precioVenta);


                cboAnioFraccionamiento.DisplayMember = "Peric_canio";
                cboAnioFraccionamiento.ValueMember = "Peric_canio";
                cboAnioFraccionamiento.DataSource = periodos.GetAllMant_Periodo();


                cboConceptoAgrupado.DisplayMember = "Multc_vDescripcion";
                cboConceptoAgrupado.ValueMember = "Multc_cValor";
                cboConceptoAgrupado.DataSource = pagos.listarConceptos();
                //cboConceptoAgrupado.DisplayMember = "Multc_vDescripcion";
                //cboConceptoAgrupado.ValueMember = "Multc_cValor";
                //cboConceptoAgrupado.DataSource = tablas.GetCboConf_Multitabla("132");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor registre la tasa de cambio para el día de hoy", Globales.Global_MessageBox);
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            int resultado;
            try
            {
                if (Convert.ToDecimal(txtSaldo.Text) == Convert.ToDecimal("0"))
                {
                    if (!txtTasa.Text.Equals(""))
                    {
                        if (Convert.ToDecimal(txtTotalP.Text) != 0)
                        {
                            switch (Convert.ToInt32((string)cboTipoPago.SelectedValue))
                            {
                                case 1:
                                    List<int> listaPagos = new List<int>();
                                    decimal totalPago = Convert.ToDecimal(txtTotalP.Text);
                                    decimal dolaresE2, solesE2, dolaresT2, solesT2, solesC2, tasaaa;
                                    tasaaa = Convert.ToDecimal(txtTasa.Text);
                                    dolaresE2 = Convert.ToDecimal(txtDolaresE.Text);
                                    solesE2 = Convert.ToDecimal(txtSolesE.Text);
                                    dolaresT2 = Convert.ToDecimal(txtDolaresT.Text);
                                    solesT2 = Convert.ToDecimal(txtSolesT.Text);
                                    solesC2 = Convert.ToDecimal(txtTotalC.Text);
                                    List<Liqu_LiquidacionTributos> listado = new List<Liqu_LiquidacionTributos>();
                                    listado = pagos.cargarTributosPago(Convert.ToInt32(txtCodigo.Text));
                                    decimal montoAcumulado = 0;
                                    int cantidad = listado.Count;
                                    int iteraciones = cantidad / 10;
                                    if (cantidad % 10 > 0)
                                        iteraciones++;
                                    for (int i = 0; i < iteraciones; i++)
                                    {
                                        montoAcumulado = 0;
                                        resultado = pagos.registrarPagoLiquidacion(Convert.ToInt32(txtCodigo.Text), txtContribuyente.Text,
                                        0, "1", Convert.ToDecimal(txtTasa.Text), 0, 1, txtPersona_ID.Text, true);
                                        for (int o = 10 * i; o < (i + 1) * 10 && o != cantidad; o++)
                                        {
                                            if (resultado != 0)
                                            {
                                                pagos.registrarPagoLiquidacionDetalleTributoNuevo(resultado, listado[o].detalleLiquidacion);
                                                montoAcumulado = montoAcumulado + listado[o].montoPago;
                                            }
                                            else
                                                MessageBox.Show("Error al registrar pago", Globales.Global_MessageBox);
                                        }
                                        listaPagos.Add(resultado);
                                        if (solesE2 >= montoAcumulado)
                                        {
                                            pagos.registrarPagoLiquidacionDetalle(resultado, 1, montoAcumulado, 0, "");
                                            solesE2 = solesE2 - montoAcumulado;
                                        }
                                        else
                                        {
                                            if (solesE2 + (dolaresE2 * tasaaa) >= montoAcumulado)
                                            {
                                                pagos.registrarPagoLiquidacionDetalle(resultado, 1, solesE2, (montoAcumulado - solesE2) / tasaaa, "");
                                                solesE2 = 0;
                                                dolaresE2 = dolaresE2 - (montoAcumulado - solesE2) / tasaaa;
                                            }
                                            else
                                            {
                                                if (solesE2 + (dolaresE2 * tasaaa) + solesT2 >= montoAcumulado)
                                                {
                                                    if (solesE2 + dolaresE2 > 0)
                                                    {
                                                        pagos.registrarPagoLiquidacionDetalle(resultado, 1, solesE2, dolaresE2, "");
                                                        solesE2 = 0; dolaresE2 = 0;
                                                    }
                                                    pagos.registrarPagoLiquidacionDetalle(resultado, 2, montoAcumulado - solesE2 - (dolaresE2 * tasaaa), 0, cboTarjeta.Text);
                                                    solesT2 = solesT2 - (montoAcumulado - solesE2 - (dolaresE2 * tasaaa));
                                                }
                                                else
                                                {
                                                    if (solesE2 + (dolaresE2 * tasaaa) + solesT2 + (dolaresT2 * tasaaa) >= montoAcumulado)
                                                    {
                                                        if (solesE2 + dolaresE2 > 0)
                                                        {
                                                            pagos.registrarPagoLiquidacionDetalle(resultado, 1, solesE2, dolaresE2, "");
                                                            solesE2 = 0; dolaresE2 = 0;
                                                        }
                                                        pagos.registrarPagoLiquidacionDetalle(resultado, 2, montoAcumulado - solesE2 - (dolaresE2 * tasaaa), (montoAcumulado - solesT2 - solesE2) / tasaaa - dolaresE2, cboTarjeta.Text);
                                                        solesT2 = 0;
                                                        dolaresT2 = dolaresT2 - ((montoAcumulado - solesE2 - solesT2) / tasaaa - dolaresE2);
                                                    }
                                                    else
                                                    {
                                                        if (solesE2 + dolaresE2 > 0)
                                                        {
                                                            pagos.registrarPagoLiquidacionDetalle(resultado, 1, solesE2, dolaresE2, "");
                                                            solesE2 = 0; dolaresE2 = 0;
                                                        }
                                                        if (solesT2 + dolaresT2 > 0)
                                                        {
                                                            pagos.registrarPagoLiquidacionDetalle(resultado, 2, solesT2, dolaresT2, cboTarjeta.Text);
                                                            solesT2 = 0; dolaresT2 = 0;
                                                        }
                                                        pagos.registrarPagoLiquidacionDetalle(resultado, 3, solesC2, 0, Convert.ToString((Int32)cboBanco.SelectedValue) + "-" + txtCheque.Text);
                                                        solesC2 = 0;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    pagos.actualizarCuentaCorriente(Convert.ToInt32(txtCodigo.Text));
                                    MessageBox.Show("Pago realizado correctamente");
                                    for (int num = 0; num < iteraciones; num++)
                                        generarRecibo(listaPagos[num], Convert.ToInt32((string)cboTipoPago.SelectedValue));
                                    limpiarNuevo();
                                    //      resultado = pagos.registrarPagoLiquidacion(Convert.ToInt32(txtCodigo.Text), txtContribuyente.Text,
                                    //Convert.ToDecimal(txtTotalP.Text), "1", Convert.ToDecimal(txtTasa.Text), 0, 1, txtPersona_ID.Text, true);

                                    //decimal solesE, dolaresE, solesT, dolaresT, solesC;
                                    //solesE = Convert.ToDecimal(txtSolesE.Text);
                                    //solesT = Convert.ToDecimal(txtSolesT.Text);
                                    //solesC = Convert.ToDecimal(txtTotalC.Text);
                                    //dolaresE = Convert.ToDecimal(txtDolaresE.Text);
                                    //dolaresT = Convert.ToDecimal(txtDolaresT.Text);
                                    //if (solesE + dolaresE != Convert.ToDecimal(0))
                                    //{
                                    //    if (pagos.registrarPagoLiquidacionDetalle(resultado, 1, solesE, dolaresE, "") == 0)
                                    //        MessageBox.Show("Error al registrar Pago", Globales.Global_MessageBox);
                                    //}
                                    //if (solesT + dolaresT != Convert.ToDecimal(0))
                                    //{
                                    //    if (pagos.registrarPagoLiquidacionDetalle(resultado, 2, solesT, dolaresT, cboTarjeta.Text) == 0)
                                    //        MessageBox.Show("Error al registrar Pago", Globales.Global_MessageBox);
                                    //}
                                    //if (solesC != Convert.ToDecimal(0))
                                    //{
                                    //    if (pagos.registrarPagoLiquidacionDetalle(resultado, 3, solesC, 0, Convert.ToString((Int32)cboBanco.SelectedValue) + "-" + txtCheque.Text) == 0)
                                    //        MessageBox.Show("Error al registrar Pago", Globales.Global_MessageBox);
                                    //}
                                    break;
                                case 2:

                                    resultado = pagos.registrarPagoFraccionamiento(cod_fracc, cboContribuyente.Text,
                                    Convert.ToDecimal(txtTotalP.Text), "2", Convert.ToDecimal(txtTasa.Text), 0, 1, true);
                                    if (resultado != 0)
                                    {
                                        decimal solesE, dolaresE, solesT, dolaresT, solesC;
                                        solesE = Convert.ToDecimal(txtSolesE.Text);
                                        solesT = Convert.ToDecimal(txtSolesT.Text);
                                        solesC = Convert.ToDecimal(txtTotalC.Text);
                                        dolaresE = Convert.ToDecimal(txtDolaresE.Text);
                                        dolaresT = Convert.ToDecimal(txtDolaresT.Text);
                                        if (solesE + dolaresE != Convert.ToDecimal(0))
                                        {
                                            if (pagos.registrarPagoLiquidacionDetalle(resultado, 1, solesE, dolaresE, "") == 0)
                                                MessageBox.Show("Error al registrar Pago", Globales.Global_MessageBox);
                                        }
                                        if (solesT + dolaresT != Convert.ToDecimal(0))
                                        {
                                            if (pagos.registrarPagoLiquidacionDetalle(resultado, 2, solesT, dolaresT, cboTarjeta.Text) == 0)
                                                MessageBox.Show("Error al registrar Pago", Globales.Global_MessageBox);
                                        }
                                        pagos.actualizarCuentaCorrienteFracc(cod_fracc, nroCuota, resultado);
                                        MessageBox.Show("Pago realizado correctamente");
                                        generarRecibo(resultado, Convert.ToInt32((string)cboTipoPago.SelectedValue));
                                        limpiarNuevo();
                                        dgvCuotas.DataSource = new List<Frac_DeudaFraccionadaDetallada>();
                                    }
                                    else
                                        MessageBox.Show("Error al registrar pago", Globales.Global_MessageBox);
                                    //resultado = pagos.registrarPagoFraccionamiento(cod_fracc, txtContFracc.Text,
                                    //Convert.ToDecimal(txtTotalP.Text), "1", Convert.ToDecimal(txtTasa.Text), 0, 1,  true);
                                    //if (resultado != 0)
                                    //{
                                    //    decimal solesE, dolaresE, solesT, dolaresT, solesC;
                                    //    solesE = Convert.ToDecimal(txtSolesE.Text);
                                    //    solesT = Convert.ToDecimal(txtSolesT.Text);
                                    //    solesC = Convert.ToDecimal(txtTotalC.Text);
                                    //    dolaresE = Convert.ToDecimal(txtDolaresE.Text);
                                    //    dolaresT = Convert.ToDecimal(txtDolaresT.Text);
                                    //    if (solesE + dolaresE != Convert.ToDecimal(0))
                                    //    {
                                    //        if (pagos.registrarPagoLiquidacionDetalle(resultado, 1, solesE, dolaresE, "") == 0)
                                    //            MessageBox.Show("Error al registrar Pago", Globales.Global_MessageBox);
                                    //    }
                                    //    if (solesT + dolaresT != Convert.ToDecimal(0))
                                    //    {
                                    //        if (pagos.registrarPagoLiquidacionDetalle(resultado, 2, solesT, dolaresT, cboTarjeta.Text) == 0)
                                    //            MessageBox.Show("Error al registrar Pago", Globales.Global_MessageBox);
                                    //    }
                                    //    pagos.actualizarCuentaCorrienteFracc(cod_fracc, Convert.ToInt32(txtNroCuota.Text), resultado);
                                    //    MessageBox.Show("Pago realizado correctamente");
                                    //    limpiarNuevo();
                                    //}
                                    //else
                                    //    MessageBox.Show("Error al registrar pago", Globales.Global_MessageBox);
                                    break;
                                case 3:
                                    resultado = pagos.registrarPagoRecibo(cod_recibo, cboPersonaRecibo.SelectedText,
                            Convert.ToDecimal(txtTotalP.Text), "3", Convert.ToDecimal(txtTasa.Text), 0, 1, true);
                                    if (resultado != 0)
                                    {
                                        decimal solesE, dolaresE, solesT, dolaresT, solesC;
                                        solesE = Convert.ToDecimal(txtSolesE.Text);
                                        solesT = Convert.ToDecimal(txtSolesT.Text);
                                        solesC = Convert.ToDecimal(txtTotalC.Text);
                                        dolaresE = Convert.ToDecimal(txtDolaresE.Text);
                                        dolaresT = Convert.ToDecimal(txtDolaresT.Text);
                                        if (solesE + dolaresE != Convert.ToDecimal(0))
                                        {
                                            if (pagos.registrarPagoLiquidacionDetalle(resultado, 1, solesE, dolaresE, "") == 0)
                                                MessageBox.Show("Error al registrar Pago", Globales.Global_MessageBox);
                                        }
                                        if (solesT + dolaresT != Convert.ToDecimal(0))
                                        {
                                            if (pagos.registrarPagoLiquidacionDetalle(resultado, 2, solesT, dolaresT, cboTarjeta.Text) == 0)
                                                MessageBox.Show("Error al registrar Pago", Globales.Global_MessageBox);
                                        }
                                        pagos.actualizarCuentaCorrienteRec(cod_recibo, resultado);
                                        MessageBox.Show("Pago realizado correctamente");
                                        generarRecibo(resultado, Convert.ToInt32((string)cboTipoPago.SelectedValue));
                                        limpiarNuevo();
                                        cboAnioR.DisplayMember = "Peric_canio";
                                        cboAnioR.ValueMember = "Peric_canio";
                                        cboAnioR.DataSource = new List<Mant_Periodo>();
                                        cboAnioR.DataSource = recibos.listarPeriodosRecibos((string)cboPersonaRecibo.SelectedValue);
                                        if (cboAnioR.Items.Count == 0)
                                        {
                                            cboAnioR.Enabled = false;
                                            cboRecibos.Enabled = false;
                                        }
                                        else
                                            cboAnioR.Enabled = true;
                                    }
                                    else
                                        MessageBox.Show("Error al registrar pago", Globales.Global_MessageBox);
                                    break;
                                case 4:
                                    if (cboPersona.SelectedIndex == -1)
                                    {
                                        MessageBox.Show("Seleccione una persona.", Globales.Global_MessageBox);
                                        return;
                                    }
                                    resultado = pagos.registrarPagosOtros(cboPersona.Text,
                            Convert.ToDecimal(txtTotalP.Text), "4", Convert.ToDecimal(txtTasa.Text), 0, 1, (string)cboPersona.SelectedValue, true);
                                    if (resultado != 0)
                                    {
                                        decimal solesE, dolaresE, solesT, dolaresT, solesC;
                                        solesE = Convert.ToDecimal(txtSolesE.Text);
                                        solesT = Convert.ToDecimal(txtSolesT.Text);
                                        solesC = Convert.ToDecimal(txtTotalC.Text);
                                        dolaresE = Convert.ToDecimal(txtDolaresE.Text);
                                        dolaresT = Convert.ToDecimal(txtDolaresT.Text);
                                        if (solesE + dolaresE != Convert.ToDecimal(0))
                                        {
                                            if (pagos.registrarPagoLiquidacionDetalle(resultado, 1, solesE, dolaresE, "") == 0)
                                                MessageBox.Show("Error al registrar Pago", Globales.Global_MessageBox);
                                        }
                                        if (solesT + dolaresT != Convert.ToDecimal(0))
                                        {
                                            if (pagos.registrarPagoLiquidacionDetalle(resultado, 2, solesT, dolaresT, cboTarjeta.Text) == 0)
                                                MessageBox.Show("Error al registrar Pago", Globales.Global_MessageBox);
                                        }
                                        pagos.actualizarCuentaCorrientePagosOtros((string)cboConcepto.SelectedValue, resultado, txtDescripcion.Text,
                                            Convert.ToDecimal(txtTotalP.Text), Convert.ToInt32(txtCantOt.Text));
                                        MessageBox.Show("Pago realizado correctamente");
                                        generarRecibo(resultado, Convert.ToInt32((string)cboTipoPago.SelectedValue));
                                        limpiarNuevo();

                                    }
                                    else
                                        MessageBox.Show("Error al registrar pago", Globales.Global_MessageBox);
                                    break;
                                case 5:
                                    break;
                                case 6:
                                    break;
                                case 7:
                                    break;
                                case 8:
                                    break;
                                case 11:
                                    if(cboPersona2.SelectedIndex==-1)
                                    {
                                         MessageBox.Show("Seleccione una persona", Globales.Global_MessageBox);
                                            return;
                                    }
                                    resultado = pagos.registrarPagosOtros(cboPersona2.Text,
                            Convert.ToDecimal(txtTotalP.Text), "11", Convert.ToDecimal(txtTasa.Text), 0, 1, (string)cboPersona2.SelectedValue, true);
                                    if (resultado != 0)
                                    {
                                        decimal solesE, dolaresE, solesT, dolaresT, solesC;
                                        solesE = Convert.ToDecimal(txtSolesE.Text);
                                        solesT = Convert.ToDecimal(txtSolesT.Text);
                                        solesC = Convert.ToDecimal(txtTotalC.Text);
                                        dolaresE = Convert.ToDecimal(txtDolaresE.Text);
                                        dolaresT = Convert.ToDecimal(txtDolaresT.Text);
                                        if (solesE + dolaresE != Convert.ToDecimal(0))
                                        {
                                            if (pagos.registrarPagoLiquidacionDetalle(resultado, 1, solesE, dolaresE, "") == 0)
                                                MessageBox.Show("Error al registrar Pago", Globales.Global_MessageBox);
                                        }
                                        if (solesT + dolaresT != Convert.ToDecimal(0))
                                        {
                                            if (pagos.registrarPagoLiquidacionDetalle(resultado, 2, solesT, dolaresT, cboTarjeta.Text) == 0)
                                                MessageBox.Show("Error al registrar Pago", Globales.Global_MessageBox);
                                        }
                                        int numAgrupados = coleccionOtros.Count();
                                        for (int i = 0; i < numAgrupados; i++)
                                        {
                                            //pagos.actualizarCuentaCorrientePagosOtros((string)cboConcepto.SelectedValue, resultado, txtDescripcion.Text, Convert.ToDecimal(txtMontoConcepto.Text));
                                            pagos.actualizarCuentaCorrientePagosOtros(coleccionOtros[i].codigo, resultado, coleccionOtros[i].descripcion, coleccionOtros[i].total, coleccionOtros[i].cantidad);
                                        }

                                        MessageBox.Show("Pago realizado correctamente");
                                        generarRecibo(resultado, Convert.ToInt32((string)cboTipoPago.SelectedValue));
                                        limpiarNuevo();
                                    }
                                    else
                                        MessageBox.Show("Error al registrar pago", Globales.Global_MessageBox);
                                    break;
                                case 12:
                                    resultado = pagos.registrarPagoAlcabala(lblPersonaAlca.Text,
                            Convert.ToDecimal(txtTotalP.Text), "12", Convert.ToDecimal(txtTasa.Text), 0, 1, txtPersonaAlca.Text, true);
                                    if (resultado != 0)
                                    {
                                        decimal solesE, dolaresE, solesT, dolaresT, solesC;
                                        solesE = Convert.ToDecimal(txtSolesE.Text);
                                        solesT = Convert.ToDecimal(txtSolesT.Text);
                                        solesC = Convert.ToDecimal(txtTotalC.Text);
                                        dolaresE = Convert.ToDecimal(txtDolaresE.Text);
                                        dolaresT = Convert.ToDecimal(txtDolaresT.Text);
                                        if (solesE + dolaresE != Convert.ToDecimal(0))
                                        {
                                            if (pagos.registrarPagoLiquidacionDetalle(resultado, 1, solesE, dolaresE, "") == 0)
                                                MessageBox.Show("Error al registrar Pago", Globales.Global_MessageBox);
                                        }
                                        if (solesT + dolaresT != Convert.ToDecimal(0))
                                        {
                                            if (pagos.registrarPagoLiquidacionDetalle(resultado, 2, solesT, dolaresT, cboTarjeta.Text) == 0)
                                                MessageBox.Show("Error al registrar Pago", Globales.Global_MessageBox);
                                        }
                                        pagos.actualizarCuentaCorrienteAlcabala((string)cboPredioAlcabala.SelectedValue, txtPersonaAlca.Text, (Int32)cboAnioAlcabala.SelectedValue, resultado);
                                        MessageBox.Show("Pago realizado correctamente");
                                        generarRecibo(resultado, Convert.ToInt32((string)cboTipoPago.SelectedValue));
                                        limpiarNuevo();
                                    }
                                    else
                                        MessageBox.Show("Error al registrar pago", Globales.Global_MessageBox);
                                    break;
                                case 13:
                                    resultado = pagos.registrarPagosOtrosReg(lblResultadoReg.Text,
                            Convert.ToDecimal(txtTotalP.Text), "13", Convert.ToDecimal(txtTasa.Text), 0, 1, "0", true);
                                    if (resultado != 0)
                                    {
                                        decimal solesE, dolaresE, solesT, dolaresT, solesC;
                                        solesE = Convert.ToDecimal(txtSolesE.Text);
                                        solesT = Convert.ToDecimal(txtSolesT.Text);
                                        solesC = Convert.ToDecimal(txtTotalC.Text);
                                        dolaresE = Convert.ToDecimal(txtDolaresE.Text);
                                        dolaresT = Convert.ToDecimal(txtDolaresT.Text);
                                        if (solesE + dolaresE != Convert.ToDecimal(0))
                                        {
                                            if (pagos.registrarPagoLiquidacionDetalle(resultado, 1, solesE, dolaresE, "") == 0)
                                                MessageBox.Show("Error al registrar Pago", Globales.Global_MessageBox);
                                        }
                                        if (solesT + dolaresT != Convert.ToDecimal(0))
                                        {
                                            if (pagos.registrarPagoLiquidacionDetalle(resultado, 2, solesT, dolaresT, cboTarjeta.Text) == 0)
                                                MessageBox.Show("Error al registrar Pago", Globales.Global_MessageBox);
                                        }
                                        pagos.actualizarCuentaCorrientePagosRegistro(Convert.ToDecimal(txtTotalP.Text), resultado,
                                            Convert.ToInt32(txtCodigoRegistros.Text), (Int32)cboPeriodoRegistros.SelectedValue);
                                        MessageBox.Show("Pago realizado correctamente");
                                        generarRecibo(resultado, Convert.ToInt32((string)cboTipoPago.SelectedValue));
                                        limpiarNuevo();
                                    }
                                    else
                                        MessageBox.Show("Error al registrar pago", Globales.Global_MessageBox);
                                    break;
                            }
                        }
                        else
                            MessageBox.Show("Debe existir deuda para poder pagar", Globales.Global_MessageBox);
                    }
                    else
                        MessageBox.Show("Por favor registre la tasa de cambio", Globales.Global_MessageBox);
                }
                else
                    MessageBox.Show("El saldo debe ser 0 por favor revise los montos", Globales.Global_MessageBox);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al registrar el pago", Globales.Global_MessageBox);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        public void generarRecibo(int pago_id, int opcion)
        {
            try
            {
                List<Pago_ReciboPago> coleccion = new List<Pago_ReciboPago>();
                Frm_Visor_Global frmVisor = new Frm_Visor_Global();
                if (opcion == 4 || opcion == 11 || opcion == 13)
                    coleccion = pagos.listarReciboOtrosPagos(pago_id);
                else
                    coleccion = pagos.listarRecibo(pago_id);
                frmVisor.reportViewer1.LocalReport.DataSources.Clear();
                frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._4_Procesos.Pagos.rptPagos.rdlc";
                frmVisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", coleccion));
                ReportParameter[] param = new ReportParameter[3];
                param[0] = new ReportParameter("Fecha", DateTime.Now.ToShortDateString().Trim());
                param[1] = new ReportParameter("Ruc", Globales.RucEmpresa);
                param[2] = new ReportParameter("N", GlobalesV1.Global_str_Usuario);
                frmVisor.reportViewer1.LocalReport.SetParameters(param);
                frmVisor.reportViewer1.RefreshReport();
                frmVisor.StartPosition = FormStartPosition.CenterParent;
                frmVisor.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiarNuevo()
        {
            txtSolesE.Text = "0";
            txtDolaresE.Text = "0";
            txtDolaresT.Text = "0";
            txtSolesT.Text = "0";
            txtTotalC.Text = "0";
            txtTotalE.Text = "0";
            txtTotalP.Text = "0";
            txtSaldo.Text = "0";
            txtTotalP.Text = "0";
            txtCodigo.Text = "";
            txtContribuyente.Text = "";
            txtInteres.Text = "";
            txtMonto.Text = "";
            txtMontoPagar.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                elemento = liquidacion.listarPorCodigo(Convert.ToInt32(txtCodigo.Text));
                txtContribuyente.Text = elemento.razon_social;
                txtPersona_ID.Text = elemento.Persona_id;
                txtInteres.Text = Convert.ToString(elemento.Intereses);
                txtMonto.Text = Convert.ToString(elemento.importe);
                txtMontoPagar.Text = Convert.ToString(elemento.total_final);
                if (elemento.total_final > 0)
                {
                    chkEfectivo.Checked = true;
                    txtTotalP.Text = Convert.ToString(elemento.total_final);
                    txtSolesE.Text = Convert.ToString(elemento.total_final);
                    txtTotalE.Text = Convert.ToString(elemento.total_final);
                    txtSolesT.Text = "0";
                    txtDolaresT.Text = "0";
                    txtDolaresE.Text = "0";
                    txtTotalC.Text = "0";
                    txtTotalT.Text = "0";
                    txtSaldo.Text = "0";
                    solesE = Convert.ToString(elemento.total_final);
                }
                else
                    reiniciar();
            }
            catch (Exception ex)
            {

            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.groupTab.Controls.Add(this.tabLiquidacion);
        }
        private void cboTipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvFraccionamientos.DataSource = new List<Frac_FraccionamientoListado2>();
            dgvCuotas.DataSource = new List<Frac_DeudaFraccionadaDetallada>();
            this.groupTab.Controls.Clear();
            string valor = Convert.ToString(cboTipoPago.SelectedValue);
            limpiarNuevo();
            switch (valor)
            {
                case "1":
                    this.groupTab.Controls.Add(this.tabLiquidacion);
                    break;
                case "2":
                    this.groupTab.Controls.Add(this.tabFraccionamientos);
                    break;
                case "3":
                    this.groupTab.Controls.Add(this.tabRecibo);
                    break;
                case "4":
                    this.groupTab.Controls.Add(this.tabOtrosPagos);
                    try
                    {
                        decimal montoInicial = 0;
                        montoInicial = pagos.valor((string)cboConcepto.SelectedValue);
                        txtMontoConcepto.Text = Convert.ToString(montoInicial);
                        txtMontoConcepto.Text = Convert.ToString(montoInicial);

                        chkEfectivo.Checked = true;
                        txtTotalP.Text = Convert.ToString(montoInicial);
                        txtSolesE.Text = Convert.ToString(montoInicial);
                        txtTotalE.Text = Convert.ToString(montoInicial);
                        txtSolesT.Text = "0";
                        txtDolaresT.Text = "0";
                        txtDolaresE.Text = "0";
                        txtTotalC.Text = "0";
                        txtTotalT.Text = "0";
                        txtSaldo.Text = "0";
                        solesE = Convert.ToString(montoInicial);
                    }
                    catch (Exception ex)
                    {

                    }
                    break;
                case "5":
                    break;
                case "6":
                    break;
                case "7":
                    break;
                case "8":
                    break;
                case "9":
                    break;
                case "10":
                    Frm_ContribuyentePagos frm = new Frm_ContribuyentePagos();
                    frm.StartPosition = FormStartPosition.CenterParent;
                    frm.ShowDialog();
                    break;
                case "11":
                    dataGridView1.DataSource = new List<Pago_OtrosPagos>();
                    montoAgrupado = 0;
                    coleccionOtros = new List<Pago_OtrosPagos>();
                    this.groupTab.Controls.Add(this.tabPagoConjuntos);
                    break;
                case "12":
                    this.groupTab.Controls.Add(this.tabPagoAlcabala);
                    break;
                case "13":
                    this.groupTab.Controls.Add(this.tabRegistrosCiviles);
                    break;
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtSolesE.Enabled = chkEfectivo.Checked;
            txtDolaresE.Enabled = chkEfectivo.Checked;
            if (!chkEfectivo.Checked)
            {
                txtTotalE.Text = "0";
                txtSolesE.Text = "0";
                txtDolaresE.Text = "0";
                txtSaldo.Text = Convert.ToString(Convert.ToDecimal(txtTotalP.Text) -
                        (Convert.ToDecimal(txtTotalE.Text) + Convert.ToDecimal(txtTotalT.Text) + Convert.ToDecimal(txtTotalC.Text)));
            }
        }
        private void chkTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            cboTarjeta.Enabled = chkTarjeta.Checked;
            txtSolesT.Enabled = chkTarjeta.Checked;
            txtDolaresT.Enabled = chkTarjeta.Checked;
            if (!chkTarjeta.Checked)
            {
                txtTotalT.Text = "0";
                txtSolesT.Text = "0";
                txtDolaresT.Text = "0";
                txtSaldo.Text = Convert.ToString(Convert.ToDecimal(txtTotalP.Text) -
                        (Convert.ToDecimal(txtTotalE.Text) + Convert.ToDecimal(txtTotalT.Text) + Convert.ToDecimal(txtTotalC.Text)));
            }
        }
        private void txtDolaresE_KeyUp(object sender, KeyEventArgs e)
        {
            string variable = txtDolaresE.Text;
            decimal soles;
            if (variable.Length != 0)
            {
                try
                {
                    soles = Convert.ToDecimal(txtDolaresE.Text);
                    dolaresE = txtDolaresE.Text;
                    txtTotalE.Text = Convert.ToString(Convert.ToDecimal(txtSolesE.Text) +
                        Convert.ToDecimal(txtTasa.Text) * Convert.ToDecimal(txtDolaresE.Text));
                    txtSaldo.Text = Convert.ToString(Convert.ToDecimal(txtTotalP.Text) -
                        (Convert.ToDecimal(txtTotalE.Text) + Convert.ToDecimal(txtTotalT.Text) + Convert.ToDecimal(txtTotalC.Text)));
                }
                catch (Exception ex)
                {
                    soles = Convert.ToDecimal(dolaresE);
                    txtDolaresE.Text = dolaresE;
                    txtDolaresE.Select(txtDolaresE.Text.Length, 0);
                }
            }
        }
        private void txtSolesT_KeyUp(object sender, KeyEventArgs e)
        {
            string variable = txtSolesT.Text;
            decimal soles;
            if (variable.Length != 0)
            {
                try
                {
                    soles = Convert.ToDecimal(txtSolesT.Text);
                    solesT = txtSolesT.Text;
                    txtTotalT.Text = Convert.ToString(Convert.ToDecimal(txtSolesT.Text) + Convert.ToDecimal(txtTasa.Text) * Convert.ToDecimal(txtDolaresT.Text));
                    txtSaldo.Text = Convert.ToString(Convert.ToDecimal(txtTotalP.Text) -
                        (Convert.ToDecimal(txtTotalE.Text) + Convert.ToDecimal(txtTotalT.Text) + Convert.ToDecimal(txtTotalC.Text)));
                }
                catch (Exception ex)
                {
                    txtSolesT.Text = solesT;
                    txtSolesT.Select(txtSolesT.Text.Length, 0);
                }
            }
        }
        private void txtDolaresT_KeyUp(object sender, KeyEventArgs e)
        {
            string variable = txtDolaresT.Text;
            decimal soles;
            if (variable.Length != 0)
            {
                try
                {
                    soles = Convert.ToDecimal(txtDolaresT.Text);
                    dolaresT = txtDolaresT.Text;
                    txtTotalT.Text = Convert.ToString(Convert.ToDecimal(txtSolesT.Text) + Convert.ToDecimal(txtTasa.Text) * Convert.ToDecimal(txtDolaresT.Text));
                    txtSaldo.Text = Convert.ToString(Convert.ToDecimal(txtTotalP.Text) -
                        (Convert.ToDecimal(txtTotalE.Text) + Convert.ToDecimal(txtTotalT.Text) + Convert.ToDecimal(txtTotalC.Text)));
                }
                catch (Exception ex)
                {
                    soles = Convert.ToDecimal(dolaresT);
                    txtDolaresT.Text = dolaresT;
                    txtDolaresT.Select(txtDolaresT.Text.Length, 0);
                }
            }
        }
        private void txtTotalC_KeyUp(object sender, KeyEventArgs e)
        {
            string variable = txtTotalC.Text;
            decimal soles;
            if (variable.Length != 0)
            {
                try
                {
                    soles = Convert.ToDecimal(txtTotalC.Text);
                    solesC = txtTotalC.Text;
                    txtSaldo.Text = Convert.ToString(Convert.ToDecimal(txtTotalP.Text) -
                        (Convert.ToDecimal(txtTotalE.Text) + Convert.ToDecimal(txtTotalT.Text) + Convert.ToDecimal(txtTotalC.Text)));
                }
                catch (Exception ex)
                {
                    txtTotalC.Text = solesC;
                    txtTotalC.Select(txtTotalC.Text.Length, 0);
                }
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                switch (pagos.validarPagoCuota((Int32)cboAnioFraccionamiento.SelectedValue,
                    Convert.ToInt32(txtNroFraccionamiento.Text), Convert.ToInt32(txtNroCuota.Text)))
                {
                    case -1:
                        Frac_Fraccionamiento elemen = fraccionamiento.listarPorCodigo((Int32)cboAnioFraccionamiento.SelectedValue,
                        Convert.ToInt32(txtNroFraccionamiento.Text), Convert.ToInt32(txtNroCuota.Text));
                        lblResultadoFrac.Text = "Cuota ya Pagada";
                        txtContFracc.Text = elemen.persona_ID;
                        txtTotalP.Text = "0";
                        break;
                    case 0:
                        lblResultadoFrac.Text = "Cuota no disponible";
                        txtContFracc.Text = "";
                        txtTotalP.Text = "0";
                        break;
                    case 1:
                        elemen = fraccionamiento.listarPorCodigo((Int32)cboAnioFraccionamiento.SelectedValue,
                        Convert.ToInt32(txtNroFraccionamiento.Text), Convert.ToInt32(txtNroCuota.Text));
                        lblResultadoFrac.Text = "";
                        txtContFracc.Text = elemen.persona_ID;

                        chkEfectivo.Checked = true;
                        txtTotalP.Text = Convert.ToString(elemen.total);
                        txtSolesE.Text = Convert.ToString(elemen.total);
                        txtTotalE.Text = Convert.ToString(elemen.total);
                        txtSolesT.Text = "0";
                        txtDolaresT.Text = "0";
                        txtDolaresE.Text = "0";
                        txtTotalC.Text = "0";
                        txtTotalT.Text = "0";
                        txtSaldo.Text = "0";
                        solesE = Convert.ToString(elemen.total);
                        cod_fracc = elemen.anio;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cboRecibos.Enabled)
                {
                    Reci_ReciboDetalle elemen = recibos.listarPorCodigo(
                        (Int32)cboAnioR.SelectedValue, (Int32)(cboRecibos.SelectedValue));
                    lblResultadoFrac.Text = "";
                    txtContribuyenteR.Text = elemen.persona;

                    chkEfectivo.Checked = true;
                    txtTotalP.Text = Convert.ToString(elemen.monto);
                    txtSolesE.Text = Convert.ToString(elemen.monto);
                    txtTotalE.Text = Convert.ToString(elemen.monto);
                    txtSolesT.Text = "0";
                    txtDolaresT.Text = "0";
                    txtDolaresE.Text = "0";
                    txtTotalC.Text = "0";
                    txtTotalT.Text = "0";
                    txtSaldo.Text = "0";
                    solesE = Convert.ToString(elemen.monto);
                    cod_recibo = elemen.codigo;
                    txtResultadoRecibos.Text = "";
                    txtResultadoRecibos.Visible = false;
                }
                else
                {
                    txtResultadoRecibos.Text = "No Tiene recibos pendientes de pago";
                    txtResultadoRecibos.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void cboConcepto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                decimal montoInicial = 0;
                montoInicial = pagos.valor((string)cboConcepto.SelectedValue);
                txtMontoConcepto.Text = Convert.ToString(montoInicial);
                txtDescripcion.Text = cboConcepto.Text;
                chkEfectivo.Checked = true;
                txtTotalP.Text = Convert.ToString(montoInicial);
                txtSolesE.Text = Convert.ToString(montoInicial);
                txtTotalE.Text = Convert.ToString(montoInicial);
                txtSolesT.Text = "0";
                txtDolaresT.Text = "0";
                txtDolaresE.Text = "0";
                txtTotalC.Text = "0";
                txtTotalT.Text = "0";
                txtSaldo.Text = "0";
                solesE = Convert.ToString(montoInicial);
            }
            catch (Exception ex)
            {

            }
        }

        private void txtContFracc_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtNombres.Text = "";
            txtPaterno.Text = "";
            txtMaterno.Text = "";
            txtDocumento.Text = "";
            gBoxPersona.Visible = true;
        }
        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvCuotas.IsCurrentCellDirty)
            {
                dgvCuotas.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (MessageBox.Show("Desea Grabar?", Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int op = 0;
                    op = pagos.validarPersona(txtNombres.Text, txtPaterno.Text, txtMaterno.Text, txtDocumento.Text);
                    if (op == 1)
                    {
                        MessageBox.Show("La persona ya se encuentra registrada", Globales.Global_MessageBox);
                    }
                    //else
                    //    if (op == 2)
                    //{
                    //    MessageBox.Show("El documento ya está registrado", Globales.Global_MessageBox);
                    //}
                    else
                    {
                        string codigo;
                        codigo = Convert.ToString(pagos.registrarPersona(txtDocumento.Text, txtPaterno.Text, txtMaterno.Text,
                            txtNombres.Text, GlobalesV1.Global_str_Usuario));
                        cboPersona.DisplayMember = "persona_Desc";
                        cboPersona.ValueMember = "persona_ID";
                        cboPersona.DataSource = persona.listartodos("");
                        cboPersona.SelectedValue = codigo;

                        cboPersona2.DisplayMember = "persona_Desc";
                        cboPersona2.ValueMember = "persona_ID";
                        cboPersona2.DataSource = persona.listartodos("");
                        cboPersona2.SelectedValue = codigo;
                        MessageBox.Show("Grabación Exitosa", Globales.Global_MessageBox);
                        txtNombres.Text = "";
                        txtPaterno.Text = "";
                        txtMaterno.Text = "";
                        txtDocumento.Text = "";
                        gBoxPersona.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void dgvDTributo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex == -1)
            //    return;
            //if (dgvCuotas.Columns[e.ColumnIndex].Name == "xestadot")
            //    calcularDeuda();
        }


        private void cboContribuyente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgvFraccionamientos.DataSource = pagos.listadoFraccionamientos((string)cboContribuyente.SelectedValue);
                dgvCuotas.DataSource = new List<Frac_DeudaFraccionadaDetallada>();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvFraccionamientos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int codigo = obtenerPago();
                cod_fracc = codigo;
                dgvCuotas.DataSource = pagos.obtenerCuotas(codigo);
                if (dgvCuotas.RowCount > 0)
                {
                    nroCuota = (int)dgvCuotas.Rows[0].Cells["xnumeroCuota"].Value;
                    valorCuota = (decimal)dgvCuotas.Rows[0].Cells["xvalorCuota"].Value;
                    DataGridViewRow row1 = dgvCuotas.Rows[0];
                    DataGridViewCheckBoxCell cellSelecion1 = row1.Cells["xcuotaPagar"] as DataGridViewCheckBoxCell;
                    cellSelecion1.Value = true;

                    chkEfectivo.Checked = true;
                    txtTotalP.Text = Convert.ToString(valorCuota);
                    txtSolesE.Text = Convert.ToString(valorCuota);
                    txtTotalE.Text = Convert.ToString(valorCuota);
                    txtSolesT.Text = "0";
                    txtDolaresT.Text = "0";
                    txtDolaresE.Text = "0";
                    txtTotalC.Text = "0";
                    txtTotalT.Text = "0";
                    txtSaldo.Text = "0";
                    solesE = Convert.ToString(valorCuota);
                }
            }
            catch (Exception ex)
            {

            }
        }
        private int obtenerPago()
        {
            return (int)dgvFraccionamientos.SelectedRows[0].Cells["xfraccionamiento_id"].Value;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtNombres.Text = "";
            txtPaterno.Text = "";
            txtMaterno.Text = "";
            txtDocumento.Text = "";
            gBoxPersona.Visible = false;
        }

        private void chkCheque_CheckedChanged(object sender, EventArgs e)
        {
            cboBanco.Enabled = chkCheque.Checked;
            txtCheque.Enabled = chkCheque.Checked;
            txtTotalC.Enabled = chkCheque.Checked;
            if (!chkCheque.Checked)
            {
                txtTotalC.Text = "0";
                txtSaldo.Text = Convert.ToString(Convert.ToDecimal(txtTotalP.Text) -
                        (Convert.ToDecimal(txtTotalE.Text) + Convert.ToDecimal(txtTotalT.Text) + Convert.ToDecimal(txtTotalC.Text)));
            }
        }
        public void reiniciar()
        {
            chkEfectivo.Checked = true;
            chkTarjeta.Enabled = false;
            chkTarjeta.Checked = false;
            chkCheque.Enabled = false;
            chkCheque.Checked = false;
            cboBanco.Enabled = false;
            txtCheque.Enabled = false;
            cboTarjeta.Enabled = false;
        }

        private void cboAnioR_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                cboRecibos.DisplayMember = "total";
                cboRecibos.ValueMember = "anio";
                cboRecibos.DataSource = new List<Reci_Recibo>();
                cboRecibos.DataSource = recibos.listarRecibos((string)cboPersonaRecibo.SelectedValue, (Int32)cboAnioR.SelectedValue);
                if (cboRecibos.Items.Count > 0)
                    cboRecibos.Enabled = true;
                else
                    cboRecibos.Enabled = false;
            }
            catch (Exception ex)
            {
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cursor.Current == Cursors.WaitCursor)
                    return;
                Cursor.Current = Cursors.WaitCursor;

                List<Pago_ReciboPago> coleccion = new List<Pago_ReciboPago>();
                Frm_Visor_Global frmVisor = new Frm_Visor_Global();
                coleccion = pagos.listarRecibo(189441);
                frmVisor.reportViewer1.LocalReport.DataSources.Clear();
                frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._4_Procesos.Pagos.rptPagos.rdlc";
                frmVisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", coleccion));
                ReportParameter[] param = new ReportParameter[3];
                param[0] = new ReportParameter("Fecha", DateTime.Now.ToShortDateString().Trim());
                param[1] = new ReportParameter("Ruc", Globales.RucEmpresa);
                param[2] = new ReportParameter("N", Globales.UsuarioPrueba);
                frmVisor.reportViewer1.LocalReport.SetParameters(param);
                frmVisor.reportViewer1.RefreshReport();
                frmVisor.StartPosition = FormStartPosition.CenterParent;
                frmVisor.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMontoConcepto_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                chkEfectivo.Checked = true;
                decimal total = 0;
                total = Convert.ToDecimal(txtMontoConcepto.Text) * Convert.ToDecimal(txtCantOt.Text);
                txtTotalP.Text = Convert.ToString(total);
                txtSolesE.Text = Convert.ToString(total);
                txtTotalE.Text = Convert.ToString(total);
                txtSolesT.Text = "0";
                txtDolaresT.Text = "0";
                txtDolaresE.Text = "0";
                txtTotalC.Text = "0";
                txtTotalT.Text = "0";
                txtSaldo.Text = "0";
                solesE = Convert.ToString(total);
            }
            catch (Exception ex)
            {
            }
        }

        private void cboConceptoAgrupado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                decimal montoInicial = 0;
                montoInicial = pagos.valor2((string)cboConceptoAgrupado.SelectedValue);
                txtMontoConcAgrup.Text = Convert.ToString(montoInicial);
                txtDescripcionAgrupado.Text = cboConceptoAgrupado.Text;
                chkEfectivo.Checked = true;

            }
            catch (Exception ex)
            {

            }
        }

        private void cboPersona2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMontoConcAgrup_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    chkEfectivo.Checked = true;
                    txtTotalP.Text = txtMontoConcAgrup.Text;
                    txtSolesE.Text = txtMontoConcAgrup.Text;
                    txtTotalE.Text = txtMontoConcAgrup.Text;
                    txtSolesT.Text = "0";
                    txtDolaresT.Text = "0";
                    txtDolaresE.Text = "0";
                    txtTotalC.Text = "0";
                    txtTotalT.Text = "0";
                    txtSaldo.Text = "0";
                    solesE = Convert.ToString(Convert.ToDecimal(txtMontoConcAgrup.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void cboPersona_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    List<Mant_Periodo> coleccion = new List<Mant_Periodo>();
                    string persona = pagos.cargarContribuyente(txtPersonaAlca.Text);
                    if (!persona.Equals("_1234567890"))
                    {
                        lblPersonaAlca.Text = persona;
                        coleccion = pagos.listarPeriodosAlcabala(txtPersonaAlca.Text);
                        cboAnioAlcabala.DisplayMember = "Peric_canio";
                        cboAnioAlcabala.ValueMember = "Peric_canio";
                        cboAnioAlcabala.DataSource = coleccion;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cboAnioAlcabala_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int anio = (Int32)cboAnioAlcabala.SelectedValue;
                string persona = txtPersonaAlca.Text;
                cboPredioAlcabala.DisplayMember = "Peric_vdescripcion";
                cboPredioAlcabala.ValueMember = "Peric_vdescripcion";
                cboPredioAlcabala.DataSource = pagos.listarPrediosAlcabala(persona, anio);
            }
            catch (Exception ex)
            {

            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                decimal monto = pagos.cargarMontoAlcabala(txtPersonaAlca.Text, (Int32)cboAnioAlcabala.SelectedValue, (string)cboPredioAlcabala.SelectedValue);
                txtMontoAlcabala.Text = Convert.ToString(monto);

                chkEfectivo.Checked = true;
                txtTotalP.Text = txtMontoAlcabala.Text;
                txtSolesE.Text = txtMontoAlcabala.Text;
                txtTotalE.Text = txtMontoAlcabala.Text;
                txtSolesT.Text = "0";
                txtDolaresT.Text = "0";
                txtDolaresE.Text = "0";
                txtTotalC.Text = "0";
                txtTotalT.Text = "0";
                txtSaldo.Text = "0";
                solesE = Convert.ToString(monto);
            }
            catch (Exception ex)
            {
            }
        }

        private void txtCodigoRegistros_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    string persona = pagos.cargarPaganteR((Int32)cboPeriodoRegistros.SelectedValue, Convert.ToInt32(txtCodigoRegistros.Text));
                    if (!persona.Equals("_1234567890"))
                    {
                        lblResultadoReg.Text = persona;
                        decimal monto = pagos.cargarMontoR((Int32)cboPeriodoRegistros.SelectedValue, Convert.ToInt32(txtCodigoRegistros.Text));
                        txtMontoReg.Text = Convert.ToString(monto);

                        chkEfectivo.Checked = true;
                        txtTotalP.Text = txtMontoReg.Text;
                        txtSolesE.Text = txtMontoReg.Text;
                        txtTotalE.Text = txtMontoReg.Text;
                        txtSolesT.Text = "0";
                        txtDolaresT.Text = "0";
                        txtDolaresE.Text = "0";
                        txtTotalC.Text = "0";
                        txtTotalT.Text = "0";
                        txtSaldo.Text = "0";
                        solesE = Convert.ToString(monto);
                    }
                    else
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtNombCon.Text = "";
            txtPatCon.Text = "";
            txtMatCon.Text = "";
            txtDocCon.Text = "";
            gbPersona2.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (MessageBox.Show("Desea Grabar?", Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int op = 0;
                    op = pagos.validarPersona(txtNombCon.Text, txtPatCon.Text, txtMatCon.Text, txtDocCon.Text);
                    if (op == 1)
                    {
                        MessageBox.Show("La persona ya se encuentra registrada", Globales.Global_MessageBox);
                    }
                    else
                        if (op == 2)
                    {
                        MessageBox.Show("El documento ya está registrado", Globales.Global_MessageBox);
                    }
                    else
                    {
                        string codigo;
                        codigo = Convert.ToString(pagos.registrarPersona(txtDocCon.Text, txtPatCon.Text, txtMatCon.Text, txtNombCon.Text, GlobalesV1.Global_str_Usuario));
                        cboPersona2.DisplayMember = "persona_Desc";
                        cboPersona2.ValueMember = "persona_ID";
                        cboPersona2.DataSource = persona.listartodos("");
                        cboPersona2.SelectedValue = codigo;
                        MessageBox.Show("Grabación Exitosa", Globales.Global_MessageBox);
                        txtNombCon.Text = "";
                        txtPatCon.Text = "";
                        txtMatCon.Text = "";
                        txtDocCon.Text = "";
                        gbPersona2.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtNombCon.Text = "";
            txtPatCon.Text = "";
            txtMatCon.Text = "";
            txtDocCon.Text = "";
            gbPersona2.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Frm_Pagos_Load(object sender, EventArgs e)
        {
            
        }

        private void cboPeriodoRegistros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void habilitar()
        {
            chkCheque.Enabled = true;
            chkTarjeta.Enabled = true;
        }
        private void txtSolesE_KeyUp(object sender, KeyEventArgs e)
        {
            string variable = txtSolesE.Text;
            decimal soles;
            if (variable.Length != 0)
            {
                try
                {
                    soles = Convert.ToDecimal(txtSolesE.Text);
                    solesE = txtSolesE.Text;
                    txtTotalE.Text = Convert.ToString(Convert.ToDecimal(txtSolesE.Text) + Convert.ToDecimal(txtTasa.Text) * Convert.ToDecimal(txtDolaresE.Text));
                    txtSaldo.Text = Convert.ToString(Convert.ToDecimal(txtTotalP.Text) -
                        (Convert.ToDecimal(txtTotalE.Text) + Convert.ToDecimal(txtTotalT.Text) + Convert.ToDecimal(txtTotalC.Text)));
                }
                catch (Exception ex)
                {
                    soles = Convert.ToDecimal(solesE);
                    txtSolesE.Text = solesE;
                    txtSolesE.Select(txtSolesE.Text.Length, 0);
                }
            }
        }

        private void cboPersonaRecibo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cboAnioR.DisplayMember = "Peric_canio";
                cboAnioR.ValueMember = "Peric_canio";
                cboAnioR.DataSource = new List<Mant_Periodo>();
                cboAnioR.DataSource = recibos.listarPeriodosRecibos((string)cboPersonaRecibo.SelectedValue);
                if (cboAnioR.Items.Count == 0)
                {
                    cboAnioR.Enabled = false;
                    cboRecibos.Enabled = false;
                }
                else
                    cboAnioR.Enabled = true;
            }
            catch (Exception ex)
            {

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            generarRecibo(174895, 4);
            
        }

        
        private void cboAnioR_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cboRecibos.DisplayMember = "total";
                cboRecibos.ValueMember = "anio";
                cboRecibos.DataSource = new List<Reci_Recibo>();
                cboRecibos.DataSource = recibos.listarRecibos((string)cboPersonaRecibo.SelectedValue, (Int32)cboAnioR.SelectedValue);
                if (cboRecibos.Items.Count > 0)
                    cboRecibos.Enabled = true;
                else
                    cboRecibos.Enabled = false;
            }
            catch (Exception ex)
            {
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                Pago_OtrosPagos elemento = new Pago_OtrosPagos();
                indice = coleccionOtros.Count;
                elemento.codigo = (string)cboConceptoAgrupado.SelectedValue;
                elemento.cantidad = Convert.ToInt32(txtCantidadOtros.Text);
                elemento.descripcion = txtDescripcionAgrupado.Text;
                elemento.monto = Convert.ToDecimal(txtMontoConcAgrup.Text);
                elemento.total = elemento.cantidad * elemento.monto;
                elemento.indice = indice;
                coleccionOtros.Add(elemento);
                dataGridView1.DataSource = new List<Pago_OtrosPagos>();
                dataGridView1.DataSource = coleccionOtros;

                montoAgrupado = montoAgrupado + elemento.total;

                txtTotalP.Text = Convert.ToString(montoAgrupado);
                txtSolesE.Text = Convert.ToString(montoAgrupado);
                txtTotalE.Text = Convert.ToString(montoAgrupado);
                txtSolesT.Text = "0";
                txtDolaresT.Text = "0";
                txtDolaresE.Text = "0";
                txtTotalC.Text = "0";
                txtTotalT.Text = "0";
                txtSaldo.Text = "0";
                solesE = Convert.ToString(montoAgrupado);
            }
            catch (Exception ex)
            {
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                if (this.dataGridView1.Columns[e.ColumnIndex].Name == "xAnular")
                {
                    int indicador = (Int32)dataGridView1.Rows[e.RowIndex].Cells["numeral"].Value;
                    int encontrado = 0;
                    List<Pago_OtrosPagos> coleccion2 = new List<Pago_OtrosPagos>();
                    for (int i = 0; i < coleccionOtros.Count; i++)
                    {
                        if (coleccionOtros[i].indice != indicador)
                        {
                            Pago_OtrosPagos agregar = new Pago_OtrosPagos();
                            agregar.cantidad = coleccionOtros[i].cantidad;
                            agregar.codigo = coleccionOtros[i].codigo;
                            agregar.descripcion = coleccionOtros[i].descripcion;
                            agregar.monto = coleccionOtros[i].monto;
                            agregar.total = coleccionOtros[i].total;
                            agregar.indice = i - encontrado;
                            coleccion2.Add(agregar);
                        }
                        else
                        {
                            encontrado++;
                            montoAgrupado = montoAgrupado - coleccionOtros[i].total;


                            txtTotalP.Text = Convert.ToString(montoAgrupado);
                            txtSolesE.Text = Convert.ToString(montoAgrupado);
                            txtTotalE.Text = Convert.ToString(montoAgrupado);
                            txtSolesT.Text = "0";
                            txtDolaresT.Text = "0";
                            txtDolaresE.Text = "0";
                            txtTotalC.Text = "0";
                            txtTotalT.Text = "0";
                            txtSaldo.Text = "0";
                            solesE = Convert.ToString(montoAgrupado);
                        }
                    }

                    coleccionOtros = coleccion2;
                    dataGridView1.DataSource = coleccionOtros;
                }
            } catch(Exception ex)
            {

            }
        }

        private void txtCantOt_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                chkEfectivo.Checked = true;
                decimal total = 0;
                total = Convert.ToDecimal(txtMontoConcepto.Text) * Convert.ToDecimal(txtCantOt.Text);
                txtTotalP.Text = Convert.ToString(total);
                txtSolesE.Text = Convert.ToString(total);
                txtTotalE.Text = Convert.ToString(total);
                txtSolesT.Text = "0";
                txtDolaresT.Text = "0";
                txtDolaresE.Text = "0";
                txtTotalC.Text = "0";
                txtTotalT.Text = "0";
                txtSaldo.Text = "0";
                solesE = Convert.ToString(total);
            }
            catch (Exception ex)
            {
            }
        }
    }
}
