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
using SGR.WinApp.Layout._4_Procesos.Predio.Exoneracion;
using SGR.WinApp.Layout._4_Procesos.Predio.SubDivision;
using SGR.WinApp.Layout._4_Procesos.Predio.Adeudo;
using SGR.WinApp.Layout._1_Tablas_Maestras.Relacion_Contribuyente;
using SGR.WinApp.Layout._5_Reportes_Gestion;
using Microsoft.Reporting.WinForms;
using SGR.Entity.Model;
using SGR.WinApp.Layout._4_Procesos.Predio.PredioMasivo;
using SGR.WinApp.Layout._4_Procesos.Predio;
using SGR.WinApp.Layout._4_Procesos.Predio.Otros;
using System.IO;

namespace SGR.WinApp.Layout._1_Tablas_Maestras.Predio
{
    public partial class Frm_Predio : DockContent
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
        private int periodo;
        private List<Repo_HojaResumen> ColeccionPC;
        private List<Repo_HojaResumen> ColeccionMP;
        Repo_HojaResumenService repo_HojaResumenService = new Repo_HojaResumenService();
        private List<Mant_Contribuyente> ColeccionMPC;
        private Pred_Certificado_AlcabalaDataService Certificado_AlcabalaDataService = new Pred_Certificado_AlcabalaDataService();

        //Reporte Predio Rustico
        private Repo_PredioRusticoDataService repo_PredioRusticoDataService = new Repo_PredioRusticoDataService();
        private List<Repo_PredioRustico> ColeccionCR;   //DATOS CONTRIBUYENTE RUSTICO
        private List<Repo_PredioRustico> ColeccionPR;   //DATOS PREDIO RUSTICO
        private List<Repo_PredioRustico> ColeccionDIR;  //DATOS DETERMINACION IMPUESTO RUSTICO

        //Reporte Predio Urbano
        private Repo_PredioUrbanoDataService repo_PredioUrbanoDataService = new Repo_PredioUrbanoDataService();
        private List<Repo_PredioUrbano> ColeccionDC;    //DATOS CONTRIBUYENTE URBANO
        private List<Repo_PredioUrbano> ColeccionDP;    //DATOS PREDIO URBANO
        private List<Repo_PredioUrbano> ColeccionUDI;   //DATOS DETERMINACION IMPUESTO URBANO
        private string sectorDescripcion = "", calleDescripcion = "";


        public Frm_Predio()
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
                lblPeriodo.Text = periodo.ToString();
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
        private void toolnuevo_Click(object sender, EventArgs e)
        {
            try
            {
                String perso = "";
                if (dgvContribuyenteBuscados.RowCount > 0)
                    perso = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["persona_ID"].Value;
                //perso_name = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["persona_ID"].Value;
                Frm_Predio_Deta Frm_Predio_Deta = new Frm_Predio_Deta(perso);
                Frm_Predio_Deta.StartPosition = FormStartPosition.CenterParent;
                Frm_Predio_Deta.ShowDialog();
                cargarPredioBuscado();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }

        }

        private void tooleditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPredio.SelectedRows.Count > 0)
                {
                    Pred_Predio Pred_Predio = new Pred_Predio();
                    Pred_Predio = obtenerdatos();
                    Frm_Predio_Deta Frm_Predio_Deta = new Frm_Predio_Deta(Pred_Predio);
                    Frm_Predio_Deta.StartPosition = FormStartPosition.CenterParent;
                    Frm_Predio_Deta.ShowDialog();
                    cargarPredioBuscado();

                }
                else MessageBox.Show("Seleccione un registro", Globales.Global_MessageBox);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
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

        private void tooleliminar_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Predio_Load(object sender, EventArgs e)
        {

        }

        private void txtNomRazon_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private string CambiarTexto(string txt)
        {
            if (txt.TrimEnd() == "")
                return "%";
            return txt.TrimEnd();
        }
        private void dgvPredio_DoubleClick(object sender, EventArgs e)
        {
            tooleditar.PerformClick();

        }

        //private void cboDepBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    cboProvBusqueda.DataSource = conf_UbicacionDataService.GetProvincia(cboDepBusqueda.SelectedValue.ToString() + "%", 9);
        //}

        //private void cboProvBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    cboDistBusque.DataSource = conf_UbicacionDataService.GetProvincia(cboProvBusqueda.SelectedValue.ToString() + "%", 10);
        //}

        private void cboSectorB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cboCalleB.DataSource = pred_ViasDataService.listarViasPorSector(cboSectorB.SelectedValue.ToString(), GlobalesV1.Global_int_idoficina);

                this.cboCalleB.AutoCompleteMode = AutoCompleteMode.Suggest;
                this.cboCalleB.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString(), Globales.Global_MessageBox);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
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
                                    Mant_Contribuyente mant_Contribuyente1 = new Mant_Contribuyente();
                                    mant_Contribuyente1.c_dpto = CambiarTexto(txtDptoB.Text.TrimEnd());
                                    mant_Contribuyente1.c_interior = CambiarTexto(txtInteriorB.Text.TrimEnd());
                                    mant_Contribuyente1.c_lote = CambiarTexto(txtLoteB.Text.TrimEnd());
                                    mant_Contribuyente1.c_mz = CambiarTexto(txtManzanaB.Text.TrimEnd());
                                    mant_Contribuyente1.c_num = CambiarTexto(txtViaB.Text.TrimEnd());
                                    mant_Contribuyente1.c_piso = CambiarTexto(txtPisoB.Text.TrimEnd());
                                    mant_Contribuyente1.c_edificio = CambiarTexto(txtEdificioB.Text.TrimEnd());
                                    mant_Contribuyente1.c_tienda = CambiarTexto(txtTiendaB.Text.TrimEnd());
                                    mant_Contribuyente1.ruc = "%";
                                    if (cboCalleB.SelectedIndex != -1 && cboSectorB.SelectedIndex != -1)
                                    {
                                        junv = mant_JuntaViaDataService.GetJuntaVia_id(int.Parse(cboSectorB.SelectedValue.ToString()), int.Parse(cboCalleB.SelectedValue.ToString()));
                                        if (junv != 0)
                                            mant_Contribuyente1.ruc = junv.ToString();
                                        dgvContribuyenteBuscados.DataSource = mant_ContribuyenteDataService.listarBuscadosxDireccionDePredio(mant_Contribuyente1, GlobalesV1.Global_int_idoficina);

                                    }
                                    else
                                    {

                                        if (cboSectorB.SelectedIndex == -1)
                                        {
                                            mant_Contribuyente1.Contacto = "%" + sectorDescripcion + "%";
                                            mant_Contribuyente1.DireccRepresentante = "%" + calleDescripcion + "%";
                                            dgvContribuyenteBuscados.DataSource = mant_ContribuyenteDataService.listarBuscadosxDireccionDePredio2(mant_Contribuyente1, GlobalesV1.Global_int_idoficina, 35);

                                        }
                                        else
                                        {
                                            mant_Contribuyente1.Contacto = cboSectorB.SelectedValue.ToString();
                                            mant_Contribuyente1.DireccRepresentante = "%" + calleDescripcion + "%";
                                            dgvContribuyenteBuscados.DataSource = mant_ContribuyenteDataService.listarBuscadosxDireccionDePredio2(mant_Contribuyente1, GlobalesV1.Global_int_idoficina, 36);
                                        }

                                    }
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
                cargarPredioBuscado();
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

        public void cargarPredioBuscado()
        {
            if (dgvContribuyenteBuscados.RowCount > 0)
            {
                String perso = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["persona_ID"].Value;
                Coleccion = predioDataService.listarbuscados(perso, periodo);
                dgvPredio.DataSource = Coleccion;
                PintarColumnasCalculadas();
                //dgvPredio.ClearSelection();
            }
            else
                dgvPredio.DataSource = new List<Pred_Predio>();

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
                        //cboSectorB.SelectedIndex = 0;

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
        private void dgvPredio_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvPredio.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void dgvContribuyenteBuscados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                cargarPredioBuscado();
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
        //menu en grilla
        ToolStripMenuItem toolStripItem1 = new ToolStripMenuItem();

        //private void AddContextMenu()
        //{
        //    toolStripItem1.Text = "Redden";
        //    toolStripItem1.Click += new EventHandler(toolStripItem1_Click);
        //    ContextMenuStrip strip = new ContextMenuStrip();
        //    foreach (DataGridViewColumn column in dgvContribuyenteBuscados.Columns)
        //    {

        //        column.ContextMenuStrip = strip;
        //        column.ContextMenuStrip.Items.Add(toolStripItem1);
        //    }
        //}

        private DataGridViewCellEventArgs mouseLocation;

        //// Change the cell's color.
        //private void toolStripItem1_Click(object sender, EventArgs args)
        //{
        //    dgvContribuyenteBuscados.Rows[mouseLocation.RowIndex]
        //        .Cells[mouseLocation.ColumnIndex].Style.BackColor
        //        = Color.Red;
        //}

        private void dgvContribuyenteBuscados_CellMouseEnter(object sender, DataGridViewCellEventArgs location)
        {

            mouseLocation = location;
        }

        private void tsmSubdividir_Click(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (dgvPredio.SelectedCells.Count > 0)
                {
                    String pred_id = (String)dgvPredio.SelectedRows[0].Cells["predio_ID"].Value;
                    String perso_id = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["persona_ID"].Value;
                    String paterno = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["paterno"].Value;
                    String materno = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["materno"].Value;
                    String nombres = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["nombres"].Value;
                    Int32 tipoinm = (int)dgvPredio.SelectedRows[0].Cells["tipo_inmueble"].Value;
                    Decimal AreaTerreno = (decimal)dgvPredio.SelectedRows[0].Cells["area_terreno"].Value;//
                    Decimal total_autovaluo = (decimal)dgvPredio.SelectedRows[0].Cells["total_autovaluo"].Value;
                    if (predioDataService.ContarPredioContribuyente(pred_id) > 1)
                    {
                        if (Certificado_AlcabalaDataService.DeudaPendienteTotal(pred_id) != 0)
                        {
                            MessageBox.Show("Hay deuda pendiente de un condominio", Globales.Global_MessageBox);
                            return;
                        }
                        if (MessageBox.Show("Este Predio tiene más de un contribuyente,si subdivide se eliminarán los otros contribuyentes.Desea continuar?", Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Frm_Subdivision_ Frm_Subdivision = new Frm_Subdivision_(pred_id, perso_id, paterno + " " + materno + " " + nombres, AreaTerreno, tipoinm, total_autovaluo);//8832
                            Frm_Subdivision.StartPosition = FormStartPosition.CenterParent;
                            Frm_Subdivision.ShowDialog();
                        }
                    }
                    else
                    {
                        if (Certificado_AlcabalaDataService.DeudaPendiente(perso_id) != 0)
                        {
                            MessageBox.Show("Hay deuda pendiente", Globales.Global_MessageBox);
                            return;
                        }
                        Frm_Subdivision_ Frm_Subdivision = new Frm_Subdivision_(pred_id, perso_id, paterno + " " + materno + " " + nombres, AreaTerreno, tipoinm, total_autovaluo);//8832
                        Frm_Subdivision.StartPosition = FormStartPosition.CenterParent;
                        Frm_Subdivision.ShowDialog();
                    }
                }
                cargarPredioBuscado();
            }
            catch (Exception ex) { }

            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void ctmsMenuContrib_Opening(object sender, CancelEventArgs e)
        {

            //dgvContribuyenteBuscados.Rows[mouseLocation.RowIndex]
            //    .Cells[mouseLocation.ColumnIndex].Style.BackColor
            //    = Color.Red;
            //MessageBox.Show("aa");
        }

        private void Exonerar()
        {
            //verificar q sea unico el ocntribuyetne y q solo tenga un predio
            if (dgvContribuyenteBuscados.RowCount > 0)
            {
                String perso = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["persona_ID"].Value;
                String paterno = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["paterno"].Value;
                String materno = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["materno"].Value;
                String nombres = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["nombres"].Value;
                Frm_Exoneracion Frm_Exoneracion = new Frm_Exoneracion(perso, paterno + " " + materno + " " + nombres, periodo);//8832
                Frm_Exoneracion.StartPosition = FormStartPosition.CenterParent;
                Frm_Exoneracion.ShowDialog();
            }
        }

        private void HR_Reporte()
        {
            DateTime fechaHoy = DateTime.Now;
            DateTime diaHoy = DateTime.Now;

            int xpersona = int.Parse(dgvContribuyenteBuscados.SelectedRows[0].Cells["persona_ID"].Value.ToString());
            if (dgvContribuyenteBuscados.SelectedRows.Count == 0)
            {
                return;
            }


            Cursor.Current = Cursors.WaitCursor;
            Frm_Visor_Global frm_Visor_Global = new Frm_Visor_Global();
            try
            {
                Mant_ContribuyenteDataService mant_ContribuyenteDataService1 = new Mant_ContribuyenteDataService();
                ColeccionMPC = mant_ContribuyenteDataService1.listarIdContribuyente(xpersona);
                Coleccion = predioDataService.listarPrediosxPerContribuyente(xpersona.ToString());
                ColeccionPC = repo_HojaResumenService.listarDeterminacionImpuesto(xpersona.ToString(), Convert.ToInt32(lblPeriodo.Text));
                ColeccionMP = repo_HojaResumenService.listarMontosPagar(xpersona.ToString(), Convert.ToInt32(lblPeriodo.Text));
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._1_Tablas_Maestras.Contribuyente.Reporte_Contribuyente.rdlc";
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetContribuyente", ColeccionMPC));
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetRelacionPredios", Coleccion));
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetDeterminacionImpuesto", ColeccionPC));
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetMontosPagar", ColeccionMP));
                //INGRESAR LOGO EMPRESA - INICIO
                List<Frac_CuentaFraccionada> List_CuentaFraccionada = new List<Frac_CuentaFraccionada>();
                Frac_CuentaFraccionada frac_CuentaFraccionada = new Frac_CuentaFraccionada();
                String _path = Path.Combine(Application.StartupPath, @"LogoCabecera.jpg");
                frac_CuentaFraccionada.logoEmpresa = File.ReadAllBytes(_path);
                frac_CuentaFraccionada.convenio = "convenio";
                List_CuentaFraccionada.Add(frac_CuentaFraccionada);
                ReportDataSource reportDataSource = new ReportDataSource("DataSetLogoEmpresa", List_CuentaFraccionada);
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                //LOGO EMPRESA FIN
                ReportParameter[] paramsx = new ReportParameter[6];
                paramsx[0] = new ReportParameter("NombreEmpresa", Globales.NombreEmpresa);
                paramsx[1] = new ReportParameter("UsuarioPrueba", GlobalesV1.Global_str_Usuario);
                paramsx[2] = new ReportParameter("Año", fechaHoy.Year.ToString());
                paramsx[3] = new ReportParameter("Dia", fechaHoy.Day.ToString());
                paramsx[4] = new ReportParameter("Mes", fechaHoy.Month.ToString());
                paramsx[5] = new ReportParameter("RucEmpresa", Globales.RucEmpresa);
                frm_Visor_Global.reportViewer1.LocalReport.SetParameters(paramsx);
                frm_Visor_Global.reportViewer1.RefreshReport();
                frm_Visor_Global.StartPosition = FormStartPosition.CenterScreen;
                frm_Visor_Global.ShowDialog();
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

        private void dgvContribuyenteBuscados_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cargarPredioBuscado();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void hRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {

                HR_Reporte();
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

        private void exonerarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                Exonerar();
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

        private void relaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (dgvContribuyenteBuscados.RowCount > 0)
                {
                    String perso = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["persona_ID"].Value;
                    String paterno = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["paterno"].Value;
                    String materno = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["materno"].Value;
                    String nombres = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["nombres"].Value;
                    Frm_Relacion_Contribuyente frm_Relacion_Contribuyente = new Frm_Relacion_Contribuyente(perso, paterno + " " + materno + " " + nombres);//8832
                    frm_Relacion_Contribuyente.StartPosition = FormStartPosition.CenterParent;
                    frm_Relacion_Contribuyente.ShowDialog();
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

        private void generarImpuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvContribuyenteBuscados.SelectedRows.Count > 0)
                {
                    String perso = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["persona_ID"].Value;
                    String paterno = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["paterno"].Value;
                    String materno = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["materno"].Value;
                    String nombres = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["nombres"].Value;
                    Frm_CalculoIndividulPredio Frm_CalculoIndividulPredio = new Frm_CalculoIndividulPredio(perso, paterno + " " + materno + " " + nombres, periodo, "Predio", 1, "");//8832
                    Frm_CalculoIndividulPredio.StartPosition = FormStartPosition.CenterParent;
                    Frm_CalculoIndividulPredio.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void tsmRecalcularArbitrios_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvContribuyenteBuscados.SelectedRows.Count > 0 && dgvPredio.SelectedRows.Count > 0)
                {
                    String perso = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["persona_ID"].Value;
                    String paterno = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["paterno"].Value;
                    String materno = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["materno"].Value;
                    String nombres = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["nombres"].Value;
                    String predio_idd = (String)dgvPredio.SelectedRows[0].Cells["predio_ID"].Value;
                    Frm_CalculoIndividulPredio Frm_CalculoIndividulPredio = new Frm_CalculoIndividulPredio(perso, paterno + " " + materno + " " + nombres, periodo, "Arbitrio", 2, predio_idd);//8832
                    Frm_CalculoIndividulPredio.StartPosition = FormStartPosition.CenterParent;
                    Frm_CalculoIndividulPredio.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void tsmVender_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvContribuyenteBuscados.SelectedRows.Count > 0 && dgvPredio.SelectedRows.Count > 0)
                {
                    String perso = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["persona_ID"].Value;
                    String paterno = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["paterno"].Value;
                    String materno = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["materno"].Value;
                    String nombres = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["nombres"].Value;
                    String predio_idd = (String)dgvPredio.SelectedRows[0].Cells["predio_ID"].Value;
                    //int tipo_inmueble = (Int32)dgvPredio.SelectedRows[0].Cells["tipo_inmueble"].Value;
                    String direccion_completa = (String)dgvPredio.SelectedRows[0].Cells["direccion_completa"].Value;//
                    Decimal area_terreno = (Decimal)dgvPredio.SelectedRows[0].Cells["area_terreno"].Value;//
                    Decimal valor_terreno = (Decimal)dgvPredio.SelectedRows[0].Cells["valor_terreno"].Value;//
                    Decimal valor_construccion = (Decimal)dgvPredio.SelectedRows[0].Cells["valor_construccion"].Value;//
                    Decimal valor_otra_instalacion = (Decimal)dgvPredio.SelectedRows[0].Cells["valor_otra_instalacion"].Value;
                    Decimal total_autovaluo = (Decimal)dgvPredio.SelectedRows[0].Cells["total_autovaluo"].Value;//                    
                    Pred_PredioContribuyente pred_PredioContribuyente = new Pred_PredioContribuyente();
                    pred_PredioContribuyente = pred_PredioContribuyenteDataService.obtenerSITieneOtroDueño(predio_idd, perso, Convert.ToInt32(lblPeriodo.Text));
                    Frm_Alcabala Frm_Alcabala = new Frm_Alcabala(perso, direccion_completa, paterno + " " + materno + " " + nombres, predio_idd,
                        pred_PredioContribuyente.predio_contribuyente_id, pred_PredioContribuyente.Porcentaje_Condomino,
                        valor_terreno, valor_construccion, valor_otra_instalacion, total_autovaluo, area_terreno);
                    Frm_Alcabala.StartPosition = FormStartPosition.CenterParent;
                    Frm_Alcabala.ShowDialog();
                    cargarPredioBuscado();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void generarImpArbitriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvContribuyenteBuscados.SelectedRows.Count > 0)
                {
                    String perso = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["persona_ID"].Value;
                    String paterno = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["paterno"].Value;
                    String materno = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["materno"].Value;
                    String nombres = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["nombres"].Value;
                    Frm_CalculoIndividulPredio Frm_CalculoIndividulPredio = new Frm_CalculoIndividulPredio(perso, paterno + " " + materno + " " + nombres, periodo, "Arbitrio General", 2, "");//8832
                    Frm_CalculoIndividulPredio.StartPosition = FormStartPosition.CenterParent;
                    Frm_CalculoIndividulPredio.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime fechaHoy = DateTime.Now;

            Cursor.Current = Cursors.WaitCursor;
            Frm_Visor_Global frm_Visor_Global = new Frm_Visor_Global();
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private DataGridViewCellEventArgs mouseLocation1;

        private void dgvPredio_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            mouseLocation = mouseLocation1;
        }

        private void historialDeModifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvContribuyenteBuscados.SelectedRows.Count > 0 && dgvPredio.SelectedRows.Count > 0)
                {
                    String perso = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["persona_ID"].Value;
                    String paterno = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["paterno"].Value;
                    String materno = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["materno"].Value;
                    String nombres = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["nombres"].Value;
                    String predio_idd = (String)dgvPredio.SelectedRows[0].Cells["predio_ID"].Value;

                    _4_Procesos.Predio.Frm_Historial Frm_Historial = new _4_Procesos.Predio.Frm_Historial(predio_idd.Trim(), paterno + " " + materno + " " + nombres);
                    Frm_Historial.StartPosition = FormStartPosition.CenterParent;
                    Frm_Historial.ShowDialog();
                }
                else
                    MessageBox.Show("no hay predios seleccionados", Globales.Global_MessageBox);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }

        }

        private void pUPRToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DateTime fechaHoy = DateTime.Now;

            Cursor.Current = Cursors.WaitCursor;
            Frm_Visor_Global frm_Visor_Global = new Frm_Visor_Global();
            try
            {
                if (dgvContribuyenteBuscados.SelectedRows.Count > 0 && dgvPredio.SelectedRows.Count > 0)
                {
                    String perso = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["persona_ID"].Value;
                    String predio = (String)dgvPredio.SelectedRows[0].Cells["predio_ID"].Value;
                    int tipo_inmueble = (int)dgvPredio.SelectedRows[0].Cells["tipo_inmueble"].Value;
                    if (tipo_inmueble == 2)
                    {
                        ColeccionCR = repo_PredioRusticoDataService.listarContribuyenteRustico(perso);
                        ColeccionPR = repo_PredioRusticoDataService.listarPredioRustico(predio, Convert.ToInt32(lblPeriodo.Text));
                        ColeccionDIR = repo_PredioRusticoDataService.ListarImpuestoRustico(predio, Convert.ToInt32(lblPeriodo.Text));
                        frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                        frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._5_Reportes_Gestion.Rep_Predio.Reporte_PredioRustico.rdlc";
                        frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetContribuyente", ColeccionCR));
                        frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetPredio", ColeccionPR));
                        frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetDeterminacionImpuesto", ColeccionDIR));

                        //INGRESAR LOGO EMPRESA - INICIO
                        List<Frac_CuentaFraccionada> List_CuentaFraccionada = new List<Frac_CuentaFraccionada>();
                        Frac_CuentaFraccionada frac_CuentaFraccionada = new Frac_CuentaFraccionada();
                        String _path = Path.Combine(Application.StartupPath, @"LogoCabecera.jpg");
                        frac_CuentaFraccionada.logoEmpresa = File.ReadAllBytes(_path);
                        frac_CuentaFraccionada.convenio = "convenio";
                        List_CuentaFraccionada.Add(frac_CuentaFraccionada);
                        ReportDataSource reportDataSource = new ReportDataSource("DataSetLogoEmpresa", List_CuentaFraccionada);
                        frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                        //LOGO EMPRESA FIN

                        ReportParameter[] paramsx = new ReportParameter[6];
                        paramsx[0] = new ReportParameter("NombreEmpresa", Globales.RucEmpresa);
                        paramsx[1] = new ReportParameter("UsuarioPrueba", GlobalesV1.Global_str_Usuario);
                        paramsx[2] = new ReportParameter("Año", fechaHoy.Year.ToString());
                        paramsx[3] = new ReportParameter("Dia", fechaHoy.Day.ToString());
                        paramsx[4] = new ReportParameter("Mes", fechaHoy.Month.ToString());
                        paramsx[5] = new ReportParameter("RucEmpresa", Globales.RucEmpresa);
                        frm_Visor_Global.reportViewer1.LocalReport.SetParameters(paramsx);
                        frm_Visor_Global.reportViewer1.RefreshReport();
                        frm_Visor_Global.StartPosition = FormStartPosition.CenterScreen;
                        frm_Visor_Global.ShowDialog();
                    }
                    else if (tipo_inmueble == 1)
                    {
                        ColeccionDC = repo_PredioUrbanoDataService.ListarDatosContribuyente(perso);
                        ColeccionDP = repo_PredioUrbanoDataService.ListarDatosPredio(predio, Convert.ToInt32(lblPeriodo.Text));
                        ColeccionUDI = repo_PredioUrbanoDataService.ListarImpuestoUrbano(predio, Convert.ToInt32(lblPeriodo.Text));
                        frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                        frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._5_Reportes_Gestion.Rep_Predio.Reporte_PredioUrbano.rdlc";
                        frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetDatosContribuyente", ColeccionDC));
                        frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetDatosPredio", ColeccionDP));
                        frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetDeterminacionImpuesto", ColeccionUDI));

                        //INGRESAR LOGO EMPRESA - INICIO
                        List<Frac_CuentaFraccionada> List_CuentaFraccionada = new List<Frac_CuentaFraccionada>();
                        Frac_CuentaFraccionada frac_CuentaFraccionada = new Frac_CuentaFraccionada();
                        String _path = Path.Combine(Application.StartupPath, @"LogoCabecera.jpg");
                        frac_CuentaFraccionada.logoEmpresa = File.ReadAllBytes(_path);
                        frac_CuentaFraccionada.convenio = "convenio";
                        List_CuentaFraccionada.Add(frac_CuentaFraccionada);
                        ReportDataSource reportDataSource = new ReportDataSource("DataSetLogoEmpresa", List_CuentaFraccionada);
                        frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                        //LOGO EMPRESA FIN

                        ReportParameter[] paramsx = new ReportParameter[6];
                        paramsx[0] = new ReportParameter("NombreEmpresa", "MUNICIPALIDAD DISTRITAL DE MOCHE");
                        paramsx[1] = new ReportParameter("UsuarioPrueba", "Usuario 01");
                        paramsx[2] = new ReportParameter("Año", fechaHoy.Year.ToString());
                        paramsx[3] = new ReportParameter("Dia", fechaHoy.Day.ToString());
                        paramsx[4] = new ReportParameter("Mes", fechaHoy.Month.ToString());
                        paramsx[5] = new ReportParameter("RucEmpresa", "20167741208");
                        frm_Visor_Global.reportViewer1.LocalReport.SetParameters(paramsx);
                        frm_Visor_Global.reportViewer1.RefreshReport();
                        frm_Visor_Global.StartPosition = FormStartPosition.CenterScreen;
                        frm_Visor_Global.ShowDialog();
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

        private void constDeContribuyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvContribuyenteBuscados.SelectedRows.Count > 0 && dgvPredio.SelectedRows.Count > 0)
                {
                    String perso = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["persona_ID"].Value;
                    String direccCompleta = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["direccCompleta"].Value;
                    String paterno = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["paterno"].Value;
                    String materno = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["materno"].Value;
                    String nombres = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["nombres"].Value;
                    String predio_idd = (String)dgvPredio.SelectedRows[0].Cells["predio_ID"].Value;

                    Frm_CertificadoContribuyente Frm_CertificadoContribuyente = new Frm_CertificadoContribuyente(perso, paterno + " " + materno + " " + nombres,
                        direccCompleta, lblPeriodo.Text);
                    Frm_CertificadoContribuyente.StartPosition = FormStartPosition.CenterParent;
                    Frm_CertificadoContribuyente.ShowDialog();
                }
                else
                    MessageBox.Show("no hay predios seleccionados", Globales.Global_MessageBox);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
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
        private void ctmsMenuContribuyente_Opening(object sender, CancelEventArgs e)
        {

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
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
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
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void txtNomRazon_KeyPress_1(object sender, KeyPressEventArgs e)
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
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
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
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
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
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void cboSectorB_KeyPress(object sender, KeyPressEventArgs e)
        {

            string jj = cboSectorB.Text;
            string texto;
            if (e.KeyChar == Convert.ToChar(Keys.Enter) || (char.IsControl(e.KeyChar)) || (e.KeyChar == (char)Keys.Back))
            {
                texto = cboSectorB.Text;
            }
            else
                texto = cboSectorB.Text + e.KeyChar.ToString();
            sectorDescripcion = texto;
            if (texto.Trim().Length != 0)
            {
                cboCalleB.Text = "";
                btnBuscar.PerformClick();
            }
        }

        private void dgvPredio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarTipoTerreno();
        }

        private void cboCalleB_KeyPress(object sender, KeyPressEventArgs e)
        {
            string texto;
            if (e.KeyChar == Convert.ToChar(Keys.Enter) || (char.IsControl(e.KeyChar)) || (e.KeyChar == (char)Keys.Back))
            {
                texto = cboCalleB.Text;
            }
            else
                texto = cboCalleB.Text + e.KeyChar.ToString();
            calleDescripcion = texto;
            if (texto.Trim().Length != 0)
                btnBuscar.PerformClick();
        }

        private void dgvPredio_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarTipoTerreno();
        }

        private void dgvPredio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPredio.SelectedRows.Count > 0)
            {
                seleccionarTipoTerreno();
            }
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
    }
}
