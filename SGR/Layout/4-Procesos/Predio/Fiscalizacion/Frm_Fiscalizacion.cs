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
namespace SGR.WinApp.Layout._4_Procesos.Predio.Fiscalizacion
{
    public partial class Frm_Fiscalizacion : DockContent
    {
        private Pred_PredioDataService predioDataService = new Pred_PredioDataService();
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
        private int periodo;
        private List<Repo_HojaResumen> ColeccionPC;
        private List<Mant_Contribuyente> ColeccionMPC;
        private Pred_Certificado_AlcabalaDataService Certificado_AlcabalaDataService = new Pred_Certificado_AlcabalaDataService();
        public Frm_Fiscalizacion()
        {
            try
            {
                InitializeComponent();
                ////Reporte Predio Rustico Datos de Prueba
                //persona_IDPR = "9170";
                //razon_socialPR = "GARCIA VERGARA VDA DE CASTELLANO LUZ CARMELA";
                //DescripcionDocumentoPR = "DNI";
                //documentoPR = "07205831";
                //-------------------------------
                periodo = PeriodoDataService.GetPeriodoActivo();
                cboPeriodo.DisplayMember = "Peric_canio";
                cboPeriodo.ValueMember = "Peric_canio";
                cboPeriodo.DataSource = PeriodoDataService.llenarPeriodo();
                cboPeriodo.SelectedValue = periodo;
                rbtSeleccionado("rbtNDoc");
                cboSectorB.DisplayMember = "descripcion";
                cboSectorB.ValueMember = "sector_id";

                cboCalleB.DisplayMember = "Descripcion";
                cboCalleB.ValueMember = "Via_id";
                cboSectorB.DataSource = pred_SectorDataService.listarSectorCbo(GlobalesV1.Global_int_idoficina);
                txtUrbano.BackColor = Color.Gold;
                txtRustico.BackColor = Color.Green;

                this.cboSectorB.AutoCompleteMode = AutoCompleteMode.Suggest;
                this.cboSectorB.AutoCompleteSource = AutoCompleteSource.CustomSource;

                cboCalleB.DataSource = pred_ViasDataService.listarViasPorSector(cboSectorB.SelectedValue.ToString(), GlobalesV1.Global_int_idoficina);

                this.cboCalleB.AutoCompleteMode = AutoCompleteMode.Suggest;
                this.cboCalleB.AutoCompleteSource = AutoCompleteSource.CustomSource;
                dgvPredio.MultiSelect = false;
                dgvContribuyenteBuscados.MultiSelect = false;
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
            txtCodPredio.Text = "";
            txtNomRazon.Text = "";
            //cboCalleB.Text = "";
            //cboSectorB.Text = "";
            txtViaB.Text = "";
            txtPisoB.Text = "";
            txtTiendaB.Text = "";
            txtInteriorB.Text = "";
            txtManzanaB.Text = "";
            txtEdificioB.Text = "";
            txtDptoB.Text = "";
            txtExpedienteB.Text = "";
            txtLoteB.Text = "";
        }
        private void rbtSeleccionado(string rbtselec)
        {
            try
            {
                limpiarParaBusqueda();
                switch (rbtselec)
                {
                    case "rbtNDoc":
                        txtNDocu.Enabled = true;
                        txtNDocu.Focus();
                        txtCodContribuyente.Enabled = false;
                        txtCodPredio.Enabled = false;
                        txtNomRazon.Enabled = false;
                        cboCalleB.Enabled = false;
                        cboSectorB.Enabled = false;
                        txtViaB.Enabled = false;
                        txtPisoB.Enabled = false;
                        txtTiendaB.Enabled = false;
                        txtInteriorB.Enabled = false;
                        txtManzanaB.Enabled = false;
                        txtEdificioB.Enabled = false;
                        txtDptoB.Enabled = false;
                        txtExpedienteB.Enabled = false;
                        txtLoteB.Enabled = false;
                        //cboDepBusqueda.Enabled = false;
                        //cboProvBusqueda.Enabled = false;
                        //cboDistBusque.Enabled = false;
                        break;
                    case "rbtCodContribuyente":
                        txtNDocu.Enabled = false;
                        txtCodContribuyente.Enabled = true;
                        txtCodContribuyente.Focus();
                        txtCodPredio.Enabled = false;
                        txtNomRazon.Enabled = false;
                        cboCalleB.Enabled = false;
                        cboSectorB.Enabled = false;
                        txtViaB.Enabled = false;
                        txtPisoB.Enabled = false;
                        txtTiendaB.Enabled = false;
                        txtInteriorB.Enabled = false;
                        txtManzanaB.Enabled = false;
                        txtEdificioB.Enabled = false;
                        txtDptoB.Enabled = false;
                        txtExpedienteB.Enabled = false;
                        txtLoteB.Enabled = false;
                        //cboDepBusqueda.Enabled = false;
                        //cboProvBusqueda.Enabled = false;
                        //cboDistBusque.Enabled = false;
                        break;
                    case "rbtNombre":
                        txtNDocu.Enabled = false;
                        txtCodContribuyente.Enabled = false;
                        txtCodPredio.Enabled = false;
                        txtNomRazon.Enabled = true;
                        txtNomRazon.Focus();
                        cboCalleB.Enabled = false;
                        cboSectorB.Enabled = false;
                        txtViaB.Enabled = false;
                        txtPisoB.Enabled = false;
                        txtTiendaB.Enabled = false;
                        txtInteriorB.Enabled = false;
                        txtManzanaB.Enabled = false;
                        txtEdificioB.Enabled = false;
                        txtDptoB.Enabled = false;
                        txtExpedienteB.Enabled = false;
                        txtLoteB.Enabled = false;
                        //cboDepBusqueda.Enabled = false;
                        //cboProvBusqueda.Enabled = false;
                        //cboDistBusque.Enabled = false;
                        break;
                    case "rbtDirección":
                        txtNDocu.Enabled = false;
                        txtCodContribuyente.Enabled = false;
                        txtCodPredio.Enabled = false;
                        txtNomRazon.Enabled = false;
                        cboCalleB.Enabled = true;
                        cboSectorB.Enabled = true;
                        txtViaB.Enabled = true;
                        txtViaB.Focus();
                        txtPisoB.Enabled = true;
                        txtTiendaB.Enabled = true;
                        txtInteriorB.Enabled = true;
                        txtManzanaB.Enabled = true;
                        txtEdificioB.Enabled = true;
                        txtDptoB.Enabled = true;
                        txtExpedienteB.Enabled = false;
                        txtLoteB.Enabled = true;
                        //cboDepBusqueda.Enabled = true;
                        //cboProvBusqueda.Enabled = true;
                        //cboDistBusque.Enabled = true;
                        break;
                    case "rbtCPredio":
                        txtNDocu.Enabled = false;
                        txtCodContribuyente.Enabled = false;
                        txtCodPredio.Enabled = true;
                        txtCodPredio.Focus();
                        txtNomRazon.Enabled = false;
                        cboCalleB.Enabled = false;
                        cboSectorB.Enabled = false;
                        txtViaB.Enabled = false;
                        txtPisoB.Enabled = false;
                        txtTiendaB.Enabled = false;
                        txtInteriorB.Enabled = false;
                        txtManzanaB.Enabled = false;
                        txtEdificioB.Enabled = false;
                        txtDptoB.Enabled = false;
                        txtExpedienteB.Enabled = false;
                        txtLoteB.Enabled = false;
                        //cboDepBusqueda.Enabled = false;
                        //cboProvBusqueda.Enabled = false;
                        //cboDistBusque.Enabled = false;
                        break;
                    case "rbtExpediente":
                        txtNDocu.Enabled = false;
                        txtCodContribuyente.Enabled = false;
                        txtCodPredio.Enabled = false;
                        txtNomRazon.Enabled = false;
                        cboCalleB.Enabled = false;
                        cboSectorB.Enabled = false;
                        txtViaB.Enabled = false;
                        txtPisoB.Enabled = false;
                        txtTiendaB.Enabled = false;
                        txtInteriorB.Enabled = false;
                        txtManzanaB.Enabled = false;
                        txtEdificioB.Enabled = false;
                        txtDptoB.Enabled = false;
                        txtExpedienteB.Enabled = true;
                        txtExpedienteB.Focus();
                        txtLoteB.Enabled = false;
                        //cboDepBusqueda.Enabled = false;
                        //cboProvBusqueda.Enabled = false;
                        //cboDistBusque.Enabled = false;
                        break;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Globales.Global_MessageBox);
            }

        }
        private string CambiarTexto(string txt)
        {
            if (txt.TrimEnd() == "")
                return "%";
            return txt.TrimEnd();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarContribuyente();
        }
        private void BuscarContribuyente()
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
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
                        else
                        {
                            if (rbtExpediente.Checked)
                            {
                                dgvContribuyenteBuscados.DataSource = mant_ContribuyenteDataService.listarBuscados(txtExpedienteB.Text.Trim(), 20, "expedientebusqueda", GlobalesV1.Global_int_idoficina);
                            }
                            else
                            {
                                if (rbtDirección.Checked)
                                {
                                    int junv = 0;
                                    if (cboCalleB.SelectedIndex == -1 || cboSectorB.SelectedIndex == -1)
                                    {
                                        MessageBox.Show("Seleccione la calle y sector", Globales.Global_MessageBox);
                                        return;
                                    }
                                    Mant_Contribuyente mant_Contribuyente1 = new Mant_Contribuyente();
                                    junv = mant_JuntaViaDataService.GetJuntaVia_id(int.Parse(cboSectorB.SelectedValue.ToString()), int.Parse(cboCalleB.SelectedValue.ToString()));
                                    //if es tipo 15 
                                    if (junv != 0)
                                        mant_Contribuyente1.ruc = junv.ToString();
                                    else
                                        mant_Contribuyente1.ruc = "%";
                                    //if cambio  a tipo 14 mant_Contribuyente1.Junta_via=junv
                                    mant_Contribuyente1.c_dpto = CambiarTexto(txtDptoB.Text.TrimEnd());
                                    mant_Contribuyente1.c_interior = CambiarTexto(txtInteriorB.Text.TrimEnd());
                                    mant_Contribuyente1.c_lote = CambiarTexto(txtLoteB.Text.TrimEnd());
                                    mant_Contribuyente1.c_mz = CambiarTexto(txtManzanaB.Text.TrimEnd());
                                    mant_Contribuyente1.c_num = CambiarTexto(txtViaB.Text.TrimEnd());
                                    mant_Contribuyente1.c_piso = CambiarTexto(txtPisoB.Text.TrimEnd());
                                    mant_Contribuyente1.c_edificio = CambiarTexto(txtEdificioB.Text.TrimEnd());
                                    mant_Contribuyente1.c_tienda = CambiarTexto(txtTiendaB.Text.TrimEnd());
                                    dgvContribuyenteBuscados.DataSource = mant_ContribuyenteDataService.listarBuscadosxDireccionDePredio(mant_Contribuyente1, GlobalesV1.Global_int_idoficina);
                                }
                                else
                                {
                                    //rbtCPredio.Checked
                                    dgvContribuyenteBuscados.DataSource = mant_ContribuyenteDataService.listarBuscadoxExpediente(txtCodPredio.Text.Trim(), 22, "codpredio", periodo);
                                }

                            }
                        }
                    }
                }
                if (dgvContribuyenteBuscados.SelectedRows.Count != 0)
                {
                    String perso = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["persona_ID"].Value;
                    Coleccion = FiscalizacionDataService.listarpredios(perso, cboPeriodo.SelectedValue.ToString());
                    dgvPredio.DataSource = Coleccion;
                    PintarColumnasCalculadas();
                    dgvPredio.ClearSelection();
                }
                else
                    dgvPredio.DataSource = new List<Pred_Predio>();
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


        private void PintarColumnasCalculadas()
        {
            for (int i = 0; i < dgvPredio.RowCount; i++)
            {
                DataGridViewRow row = dgvPredio.Rows[i];
                int tipo_inmueble = (Int32)row.Cells["tipo_inmueble"].Value;
                DataGridViewTextBoxCell cellSelecion = row.Cells["predio_ID"] as DataGridViewTextBoxCell;
                if (tipo_inmueble == 1)//urbano
                {
                    cellSelecion.Style.BackColor = Color.Gold;
                }
                else if (tipo_inmueble == 2)//rustico
                {
                    cellSelecion.Style.BackColor = Color.Green;
                }

                cellSelecion = row.Cells["Observacion"] as DataGridViewTextBoxCell;
                cellSelecion.Style.BackColor = Color.Red;
            }
        }
        private Pred_Predio obtenerdatos()
        {
            Pred_Predio Pred_Predio = new Pred_Predio();

            Pred_Predio.predio_ID = (string)dgvPredio.SelectedRows[0].Cells["predio_ID"].Value;
            Pred_Predio.Via_ID = (Int32)dgvPredio.SelectedRows[0].Cells["Via_ID"].Value;
            Pred_Predio.Junta_ID = (Int32)dgvPredio.SelectedRows[0].Cells["Junta_ID"].Value;
            Pred_Predio.junta_via_ID = (Int32)dgvPredio.SelectedRows[0].Cells["junta_via_ID"].Value;
            Pred_Predio.catastro = (string)dgvPredio.SelectedRows[0].Cells["catastro"].Value;
            Pred_Predio.interior = (string)dgvPredio.SelectedRows[0].Cells["interior"].Value;
            Pred_Predio.lote = (string)dgvPredio.SelectedRows[0].Cells["lote"].Value;
            Pred_Predio.edificio = (string)dgvPredio.SelectedRows[0].Cells["edificio"].Value;
            Pred_Predio.piso = (string)dgvPredio.SelectedRows[0].Cells["piso"].Value;
            Pred_Predio.dpto = (string)dgvPredio.SelectedRows[0].Cells["dpto"].Value;
            Pred_Predio.tienda = (string)dgvPredio.SelectedRows[0].Cells["tienda"].Value;
            Pred_Predio.cuadra = (Int32)dgvPredio.SelectedRows[0].Cells["cuadra"].Value;
            Pred_Predio.kilometro = (string)dgvPredio.SelectedRows[0].Cells["kilometro"].Value;
            Pred_Predio.direccion_completa = (string)dgvPredio.SelectedRows[0].Cells["direccion_completa"].Value;
            Pred_Predio.nombre_predio = (string)dgvPredio.SelectedRows[0].Cells["nombre_predio"].Value;
            Pred_Predio.lado = (Int32)dgvPredio.SelectedRows[0].Cells["lado"].Value;
            Pred_Predio.referencia = (string)dgvPredio.SelectedRows[0].Cells["referencia"].Value;
            Pred_Predio.frente_a = (Int32)dgvPredio.SelectedRows[0].Cells["frente_a"].Value;
            Pred_Predio.frente_metros = (decimal)dgvPredio.SelectedRows[0].Cells["frente_metros"].Value;
            Pred_Predio.num_personas = (Int32)dgvPredio.SelectedRows[0].Cells["num_personas"].Value;
            Pred_Predio.num_via = (string)dgvPredio.SelectedRows[0].Cells["num_viap"].Value;
            Pred_Predio.mz = (string)dgvPredio.SelectedRows[0].Cells["mzp"].Value;
            Pred_Predio.fecha_terreno = (DateTime)dgvPredio.SelectedRows[0].Cells["fecha_terreno"].Value;
            Pred_Predio.tipo_operacion = (Int32)dgvPredio.SelectedRows[0].Cells["tipo_operacion"].Value;
            Pred_Predio.area_terreno = (decimal)dgvPredio.SelectedRows[0].Cells["area_terreno"].Value;
            Pred_Predio.area_construida = (decimal)dgvPredio.SelectedRows[0].Cells["area_construida"].Value;
            Pred_Predio.anios_antiguedad = (Int32)dgvPredio.SelectedRows[0].Cells["anios_antiguedad"].Value;
            Pred_Predio.tipo_inmueble = (Int32)dgvPredio.SelectedRows[0].Cells["tipo_inmueble"].Value;
            Pred_Predio.tipo_predio = (Int32)dgvPredio.SelectedRows[0].Cells["tipo_predio"].Value;
            Pred_Predio.estado_predio = (Int32)dgvPredio.SelectedRows[0].Cells["estado_predio"].Value;
            Pred_Predio.uso_predio = (string)dgvPredio.SelectedRows[0].Cells["uso_predio"].Value;
            Pred_Predio.uso_codigo = (string)dgvPredio.SelectedRows[0].Cells["uso_codigo"].Value;
            Pred_Predio.num_ficha = (string)dgvPredio.SelectedRows[0].Cells["num_ficha"].Value;
            Pred_Predio.tipo_adquisicion = (Int32)dgvPredio.SelectedRows[0].Cells["tipo_adquisicion"].Value;
            Pred_Predio.clase_edificacion = (Int32)dgvPredio.SelectedRows[0].Cells["clase_edificacion"].Value;
            Pred_Predio.fecha_adquisicion = (DateTime)dgvPredio.SelectedRows[0].Cells["fecha_adquisicion"].Value;
            Pred_Predio.exo_predial = (Int32)dgvPredio.SelectedRows[0].Cells["exo_predial"].Value;
            Pred_Predio.exo_predial_porcentaje = (decimal)dgvPredio.SelectedRows[0].Cells["exo_predial_porcentaje"].Value;
            Pred_Predio.exo_anio = (Int16)dgvPredio.SelectedRows[0].Cells["exo_anio"].Value;
            Pred_Predio.motivo_exoneracion = (Int32)dgvPredio.SelectedRows[0].Cells["motivo_exoneracion"].Value;
            Pred_Predio.porcen_area_comun = (decimal)dgvPredio.SelectedRows[0].Cells["porcen_area_comun"].Value;
            //Pred_Predio.valor_referencial = (decimal)dgvPredio.SelectedRows[0].Cells[""].Value;
            //Pred_Predio.valor_terreno = (decimal)dgvPredio.SelectedRows[0].Cells[""].Value;
            //Pred_Predio.valor_construccion = (decimal)dgvPredio.SelectedRows[0].Cells[""].Value;
            //Pred_Predio.valor_otra_instalacion = (decimal)dgvPredio.SelectedRows[0].Cells[""].Value;
            //Pred_Predio.valor_area_comun = (decimal)dgvPredio.SelectedRows[0].Cells[""].Value;
            //Pred_Predio.total_autovaluo = (decimal)dgvPredio.SelectedRows[0].Cells[""].Value;
            //Pred_Predio.impuesto_predial = (decimal)dgvPredio.SelectedRows[0].Cells[""].Value;
            //Pred_Predio.alcabala = (decimal)dgvPredio.SelectedRows[0].Cells[""].Value;
            Pred_Predio.anio_adquisicion = (Int16)dgvPredio.SelectedRows[0].Cells["anio_adquisicion"].Value;
            Pred_Predio.fecha_inscripcion = (DateTime)dgvPredio.SelectedRows[0].Cells["fecha_inscripcion"].Value;
            //Pred_Predio.anio_inscripcion = (Int16)dgvPredio.SelectedRows[0].Cells[""].Value;
            Pred_Predio.clasificacion_rustico = (Int16)dgvPredio.SelectedRows[0].Cells["clasificacion_rustico"].Value;
            Pred_Predio.categoria_rustico = (Int16)dgvPredio.SelectedRows[0].Cells["categoria_rustico"].Value;
            Pred_Predio.tipo_rustico = (Int16)dgvPredio.SelectedRows[0].Cells["tipo_rustico"].Value;
            Pred_Predio.uso_rustico = (Int16)dgvPredio.SelectedRows[0].Cells["uso_rustico"].Value;
            Pred_Predio.hectareas = (decimal)dgvPredio.SelectedRows[0].Cells["hectareas"].Value;
            Pred_Predio.estado = (bool)dgvPredio.SelectedRows[0].Cells["estado"].Value;
            Pred_Predio.expediente = (string)dgvPredio.SelectedRows[0].Cells["expediente"].Value;
            Pred_Predio.lista_negra = (bool)dgvPredio.SelectedRows[0].Cells["lista_negra"].Value;
            //Pred_Predio.nuevo_uso = (string)dgvPredio.SelectedRows[0].Cells["nuevo_uso"].Value;
            Pred_Predio.sector = (int)dgvPredio.SelectedRows[0].Cells["sector"].Value;
            //Pred_Predio.nuevo_frente_a = (string)dgvPredio.SelectedRows[0].Cells["nuevo_frente_a"].Value;
            Pred_Predio.validado = (bool)dgvPredio.SelectedRows[0].Cells["validado"].Value;
            Pred_Predio.arancel = (decimal)dgvPredio.SelectedRows[0].Cells["arancel"].Value;
            Pred_Predio.Fiscalizado = (string)dgvPredio.SelectedRows[0].Cells["Fiscalizado"].Value;
            //Pred_Predio.id_alicuota = (string)dgvPredio.SelectedRows[0].Cells[""].Value;
            Pred_Predio.norte = (string)dgvPredio.SelectedRows[0].Cells["norte"].Value;
            Pred_Predio.sur = (string)dgvPredio.SelectedRows[0].Cells["sur"].Value;
            Pred_Predio.este = (string)dgvPredio.SelectedRows[0].Cells["este"].Value;
            Pred_Predio.oeste = (string)dgvPredio.SelectedRows[0].Cells["oeste"].Value;
            Pred_Predio.Condicion_Rustico = (Int16)dgvPredio.SelectedRows[0].Cells["Condicion_Rustico"].Value;
            Pred_Predio.Adquisicion_Rustico = (Int16)dgvPredio.SelectedRows[0].Cells["Adquisicion_Rustico"].Value;
            Pred_Predio.GrupoTierra_Rustico = (Int16)dgvPredio.SelectedRows[0].Cells["GrupoTierra_Rustico"].Value;
            Pred_Predio.porcentajecondominio = (decimal)dgvPredio.SelectedRows[0].Cells["porcentajecondominio"].Value;
            Pred_Predio.mapa = (string)dgvPredio.SelectedRows[0].Cells["mapa"].Value;
            Pred_Predio.casa = (string)dgvPredio.SelectedRows[0].Cells["casa"].Value;
            //Pred_Predio.unidad_idep = (string)dgvPredio.SelectedRows[0].Cells[""].Value;
            //Pred_Predio.num_uni_indep = (string)dgvPredio.SelectedRows[0].Cells[""].Value;
            Pred_Predio.alquiler = (bool)dgvPredio.SelectedRows[0].Cells["alquiler"].Value;
            Pred_Predio.terreno_sin_construir = (bool)dgvPredio.SelectedRows[0].Cells["terreno_sin_construir"].Value;
            Pred_Predio.condicionPropietario = (int)dgvPredio.SelectedRows[0].Cells["condicionPropietario"].Value;
            Pred_Predio.estado = (bool)dgvPredio.SelectedRows[0].Cells["estado"].Value;
            return Pred_Predio;
        }
        private void rbtNDoc_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtNDoc.Checked)
            {
                rbtSeleccionado("rbtNDoc");
            }
        }

        private void rbtCodContribuyente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtCodContribuyente.Checked)
            {
                rbtSeleccionado("rbtCodContribuyente");
            }
        }

        private void rbtNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtNombre.Checked)
            {
                rbtSeleccionado("rbtNombre");
            }
        }

        private void rbtDirección_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtDirección.Checked)
            {
                rbtSeleccionado("rbtDirección");
            }
        }

        private void rbtExpediente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtExpediente.Checked)
            {
                rbtSeleccionado("rbtExpediente");
            }
        }

        private void rbtCPredio_CheckedChanged(object sender, EventArgs e)
        {

            if (rbtCPredio.Checked)
            {
                rbtSeleccionado("rbtCPredio");
            }
        }

        private void dgvPredio_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (dgvPredio.Columns[e.ColumnIndex].Name == "Fiscalizar" && dgvPredio.RowCount > 0)
                {
                    if (dgvPredio.SelectedRows.Count > 0)
                    {
                        Pred_Predio Pred_Predio = new Pred_Predio();
                        String perso = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["persona_ID"].Value;
                        String paterno = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["paterno"].Value;
                        String materno = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["materno"].Value;
                        String nombres = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["nombres"].Value;
                        Pred_Predio = obtenerdatos();
                        Frm_Fiscalizacion_Detalle Frm_Fiscalizacion_Detalle = new Frm_Fiscalizacion_Detalle(Pred_Predio, perso, paterno + " " + materno + " " + nombres, cboPeriodo.SelectedValue.ToString());
                        Frm_Fiscalizacion_Detalle.StartPosition = FormStartPosition.CenterParent;
                        Frm_Fiscalizacion_Detalle.ShowDialog();
                        Coleccion = FiscalizacionDataService.listarpredios(perso, cboPeriodo.SelectedValue.ToString());
                        dgvPredio.DataSource = Coleccion;
                        PintarColumnasCalculadas();
                        seleccionarTipoTerreno();
                        dgvPredio.ClearSelection();

                    }
                    else MessageBox.Show("Seleccione un registro", Globales.Global_MessageBox);
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

        private void dgvPredio_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvPredio.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void dgvPredio_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                DataGridViewColumn ColumnaOrdenar = dgvPredio.Columns[e.ColumnIndex];

                if (dgvPredio.SortOrder == System.Windows.Forms.SortOrder.None)
                {

                    if (ColumnaOrdenar.Name == "nombre_predio")
                        if (Orden == System.Windows.Forms.SortOrder.Descending)
                        {
                            dgvPredio.DataSource = Coleccion.OrderBy(p => p.nombre_predio).ToList();
                            Orden = System.Windows.Forms.SortOrder.Ascending;
                        }
                        else
                        {
                            dgvPredio.DataSource = Coleccion.OrderBy(p => p.nombre_predio).Reverse().ToList();
                            Orden = System.Windows.Forms.SortOrder.Descending;
                        }
                }
                else if (ColumnaOrdenar.Name == "predio_ID")
                {
                    if (Orden == System.Windows.Forms.SortOrder.Descending)
                    {
                        dgvPredio.DataSource = Coleccion.OrderBy(p => p.predio_ID).ToList();
                        Orden = System.Windows.Forms.SortOrder.Ascending;
                    }
                    else
                    {
                        dgvPredio.DataSource = Coleccion.OrderBy(p => p.predio_ID).Reverse().ToList();
                        Orden = System.Windows.Forms.SortOrder.Descending;
                    }

                }
            }

        }

        private void toolnuevo_Click(object sender, EventArgs e)
        {
            try
            {
                String perso = "";
                if (dgvContribuyenteBuscados.RowCount > 0)
                {
                    perso = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["persona_ID"].Value;
                    String paterno = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["paterno"].Value;
                    String materno = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["materno"].Value;
                    String nombres = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["nombres"].Value;
                    Frm_Fiscalizacion_Nuevo Frm_Fiscalizacion_Nuevo = new Frm_Fiscalizacion_Nuevo(perso, paterno + " " + materno + " " + nombres);
                    Frm_Fiscalizacion_Nuevo.StartPosition = FormStartPosition.CenterParent;
                    Frm_Fiscalizacion_Nuevo.ShowDialog();
                    Coleccion = FiscalizacionDataService.listarpredios(perso, cboPeriodo.SelectedValue.ToString());
                    dgvPredio.DataSource = Coleccion;
                    PintarColumnasCalculadas();

                }
                else
                    MessageBox.Show("Seleccione un contribuyente", Globales.Global_MessageBox);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void cboPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarContribuyente();
        }

        private void txtNDocu_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    btnBuscar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtCodContribuyente_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    btnBuscar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtNomRazon_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    btnBuscar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtExpedienteB_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    btnBuscar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtCodPredio_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    btnBuscar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cboSectorB_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCalleB.DataSource = pred_ViasDataService.listarViasPorSector(cboSectorB.SelectedValue.ToString(), GlobalesV1.Global_int_idoficina);

            this.cboCalleB.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.cboCalleB.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void txtExpedienteB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRustico_TextChanged(object sender, EventArgs e)
        {

        }

        private void label56_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void label53_Click(object sender, EventArgs e)
        {

        }

        private void txtUrbano_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtManzanaB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTiendaB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_reporte_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvContribuyenteBuscados.SelectedRows.Count != 0)
            {
                String perso = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["persona_ID"].Value;
                String paterno = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["paterno"].Value;
                String materno = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["materno"].Value;
                String documento = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["documento"].Value;
                String direccCompleta = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["direccCompleta"].Value;
                String nombres = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["nombres"].Value;
                //Coleccion = FiscalizacionDataService.listarpredios(perso, cboPeriodo.SelectedValue.ToString());
                //dgvPredio.DataSource = Coleccion;
                //PintarColumnasCalculadas();

                if (dgvPredio.SelectedRows.Count != 0)
                {
                    if (Cursor.Current == Cursors.WaitCursor)
                        return;
                    Cursor.Current = Cursors.WaitCursor;
                    Frm_Visor_Global frm_Visor_Global = new Frm_Visor_Global();
                    try
                    {
                        Coleccion = FiscalizacionDataService.listarpredios(perso, cboPeriodo.SelectedValue.ToString());
                        frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                        frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._4_Procesos.Predio.Fiscalizacion.Rep_Fiscalizacion_Predio.rdlc";
                        frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", Coleccion));

                        ReportParameter[] paramsx = new ReportParameter[6];
                        paramsx[0] = new ReportParameter("Codigo", perso);
                        paramsx[1] = new ReportParameter("Nombres", nombres);
                        paramsx[2] = new ReportParameter("ApePaterno", paterno);
                        paramsx[3] = new ReportParameter("ApeMaterno", materno);
                        paramsx[4] = new ReportParameter("Direccion", direccCompleta);
                        paramsx[5] = new ReportParameter("Documento", documento);

                        frm_Visor_Global.reportViewer1.LocalReport.SetParameters(paramsx);

                        frm_Visor_Global.reportViewer1.RefreshReport();
                        frm_Visor_Global.StartPosition = FormStartPosition.CenterScreen;
                        frm_Visor_Global.ShowDialog();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        Cursor.Current = Cursors.Default;
                    }
                }
                else
                    MessageBox.Show("El contribuyente no tiene predio alguno.", Globales.Global_MessageBox);
            }
            else
                MessageBox.Show("Seleccione un Contribuyente", Globales.Global_MessageBox);
        }

        private void dgvPredio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarTipoTerreno();
        }
        private void seleccionarTipoTerreno()
        {

            try
            {
                System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStylen = new System.Windows.Forms.DataGridViewCellStyle();
                DataGridViewRow row = dgvPredio.SelectedRows[0];
                int tipo_inmueble = (Int32)row.Cells["tipo_inmueble"].Value;
                DataGridViewTextBoxCell cellSelecion = row.Cells["predio_ID"] as DataGridViewTextBoxCell;
                if (tipo_inmueble == 1)//urbano
                {
                    dataGridViewCellStylen.SelectionBackColor = Color.Gold;
                    dataGridViewCellStylen.SelectionForeColor = Color.Black;
                }
                else if (tipo_inmueble == 2)//rustico
                {

                    dataGridViewCellStylen.SelectionBackColor = Color.Green;
                    dataGridViewCellStylen.SelectionForeColor = Color.Black;
                }

                dgvPredio.DefaultCellStyle = dataGridViewCellStylen;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Globales.Global_MessageBox);
            }
        }

        private void dgvPredio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPredio.SelectedRows.Count > 0)
            {
                seleccionarTipoTerreno();
            }
        }

        private void dgvPredio_DoubleClick(object sender, EventArgs e)
        {
            if (dgvPredio.SelectedRows.Count > 0)
            {
                seleccionarTipoTerreno();
            }
        }

        private void dgvContribuyenteBuscados_DoubleClick(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                String perso = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["persona_ID"].Value;
                Coleccion = FiscalizacionDataService.listarpredios(perso, cboPeriodo.SelectedValue.ToString());
                dgvPredio.DataSource = Coleccion;
                PintarColumnasCalculadas();
                dgvPredio.ClearSelection();

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

        private void dgvContribuyenteBuscados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
