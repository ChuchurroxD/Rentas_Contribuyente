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

using SGR.Core.Service.Combos;
using SGR.Entity.Model.Combos;
namespace SGR.WinApp.Layout._4_Procesos.Predio.SubDivision
{
    public partial class Frm_Subdivision_ : Form
    {
        private String Predio_ID_Global = "";
        private String Contribuyente_ID_Global = "";
        private String Contribuyente_Name_Global = "";
        private Decimal AreaTerrenoOriginal = 0;
        private Pred_OtrasIntalacionesDataService Pred_OtrasInstalacionesDataService = new Pred_OtrasIntalacionesDataService();
        private Pred_PisosDataService PisosDataService = new Pred_PisosDataService();
        private Conf_MultitablaDataService conf_MultitablaDataService = new Conf_MultitablaDataService();
        private Pred_PredioDataService pred_PredioDataService = new Pred_PredioDataService();
        Pago_PersonaDataService persona = new Pago_PersonaDataService();
        private Pred_PredioContribuyenteDataService pred_PredioContribuyenteDataService = new Pred_PredioContribuyenteDataService();
        private Sistema.Globales.Validaciones obValidacion = new Sistema.Globales.Validaciones();
        private Mant_PeriodoDataService PeriodoDataService = new Mant_PeriodoDataService();
        private Pred_PrredioArbitrioDataService PrredioArbitrioDataService = new Pred_PrredioArbitrioDataService();
        private string user;
        private int tipoInmueble=0;
        private bool cerro = false;
        public Frm_Subdivision_()
        {
            try
            {
                InitializeComponent();
                Predio_ID_Global = "201661410383       ";//2016615153512
                Contribuyente_ID_Global = "9564";
                Contribuyente_Name_Global = "JJ";
                tipoInmueble = 1;
                AreaTerrenoOriginal = 482;
                CargarPisoYotrasInstalciones();
                cagarTipoSelector();
                user = "nada";
                txtPredio.Text = Predio_ID_Global;
                txtAreaTerrenoOriginal.Text = AreaTerrenoOriginal.ToString();
                txtContribuyete.Text = Contribuyente_Name_Global;
                lblFaltaRepartir.Text = AreaTerrenoOriginal.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
            
        }
        public Frm_Subdivision_(String IdPredio,String IdContribuyente,String NameContribuyente,Decimal AreaTerreno,
            int tipoInm,Decimal total_autovaluo)
        {
            try
            {
                InitializeComponent();
                Predio_ID_Global = IdPredio;//2016615153512
                Contribuyente_ID_Global = IdContribuyente;
                Contribuyente_Name_Global = NameContribuyente;
                tipoInmueble = tipoInm;
                AreaTerrenoOriginal = AreaTerreno;
                CargarPisoYotrasInstalciones();
                cagarTipoSelector();
                txtPredio.Text = Predio_ID_Global;
                txtAreaTerrenoOriginal.Text = AreaTerrenoOriginal.ToString();
                txtContribuyete.Text = Contribuyente_Name_Global;
                lblFaltaRepartir.Text = AreaTerrenoOriginal.ToString();
                txtValuo.Text = total_autovaluo.ToString();
                DateTime fechaHoy = DateTime.Now;
                dtpFechaAdquision.MaxDate = fechaHoy;
                dtpFechaInscripcion.MaxDate = fechaHoy;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }
        private void CargarPisoYotrasInstalciones()
        {
            dgvOtrasInstalaciones.DataSource = Pred_OtrasInstalacionesDataService.listarByPredioIDActivos(Predio_ID_Global,true);
            dgvPisos.DataSource = PisosDataService.listarByPredioIDActivos(Predio_ID_Global,true);
        }
        private void cagarTipoSelector()
        {
            this.cboContribuyente.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.cboContribuyente.AutoCompleteSource = AutoCompleteSource.CustomSource;
            if(tipoInmueble==1)
                llenarCboMultitabla(cboUso, "Multc_vDescripcion", "Multc_cValor", "8");
            else
                llenarCboMultitabla(cboUso, "Multc_vDescripcion", "Multc_cValor", "30");
            llenarCboMultitabla(cboAdquisicion, "Multc_vDescripcion", "Multc_cValor", "4");
            llenarCboMultitabla(cboPosesion, "Multc_vDescripcion", "Multc_cValor", "18");
            llenarCboMultitabla(cboTipoOperacion, "Multc_vDescripcion", "Multc_cValor", "12");
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
        private String verificarTextos(String dato)
        {
            lblSubdivision.ForeColor = System.Drawing.Color.Black;
            //lblFicha.ForeColor = System.Drawing.Color.Black;
            lblAreaTerreno.ForeColor = System.Drawing.Color.Black;
            lblAreaConstruirme.ForeColor = System.Drawing.Color.Black;
            lblAreaFrrente.ForeColor = System.Drawing.Color.Black;
            lblAreaTerreno.ForeColor = System.Drawing.Color.Black;
            lblValorReferencia.ForeColor = System.Drawing.Color.Black;
            lblExpediente.ForeColor = System.Drawing.Color.Black;
            lblVia.ForeColor = System.Drawing.Color.Black;
            lblnombrePredio.ForeColor = System.Drawing.Color.Black;
            lblNumPersonas.ForeColor = System.Drawing.Color.Black;
            lblDescripcionHistorial.ForeColor = System.Drawing.Color.Black;
            lblTipoOperacion.ForeColor = System.Drawing.Color.Black;
            if (txtNSubdivisiones.Text.Trim().Length == 0)
            {
                dato = dato + "Nº de Subdivisiones, ";
                lblSubdivision.ForeColor = System.Drawing.Color.Red;
            } 
            //if (txtFicha.Text.Trim().Length == 0)
            //{
            //    dato = dato + "Ficha, ";
            //    lblFicha.ForeColor = System.Drawing.Color.Red;
            //}
            if (txtAreaComun.Text.Trim().Length ==0)
            {
                dato = dato + "Área común, ";
                lblAreaTerreno.ForeColor = System.Drawing.Color.Red;
            }
            if (txtAreaconstruida.Text.Trim().Length == 0)
            {
                dato = dato + "Área construida, ";
                lblAreaConstruirme.ForeColor = System.Drawing.Color.Red;
            }
            if (txtAreaFrrente.Text.Trim().Length == 0)
            {
                dato = dato + "Área frente, ";
                lblAreaFrrente.ForeColor = System.Drawing.Color.Red;
            }
            if (txtareaterreno.Text.Trim().Length == 0)
            {
                dato = dato + "Área de terreno, ";
                lblAreaTerreno.ForeColor = System.Drawing.Color.Red;
            }
            if (txtValorReferncial.Text.Trim().Length == 0)
            {
                dato = dato + "Valor Referencial, ";
                lblValorReferencia.ForeColor = System.Drawing.Color.Red;
            }
            //if (txtExpediente.Text.Trim().Length == 0)
            //{
            //    dato = dato + "Expediente, ";
            //    lblExpediente.ForeColor = System.Drawing.Color.Red;
            //}
            //if (txtVia.Text.Trim().Length == 0)
            //{
            //    dato = dato + "Num de vía, ";
            //    lblVia.ForeColor = System.Drawing.Color.Red;
            //}
            if (txtNombrePredio.Text.Trim().Length == 0)
            {
                dato = dato + "Nombre de Predio, ";
                lblnombrePredio.ForeColor = System.Drawing.Color.Red;
            }
            if (txtNPersonas.Text.Trim().Length == 0)
            {
                dato = dato + "Nº de Personas";
                lblNumPersonas.ForeColor = System.Drawing.Color.Red;
            }
            //if (txtDescripcionHistorial.Text.Trim().Length == 0)
            //{
            //    dato = dato + " Descripción para historial,";
            //    lblDescripcionHistorial.ForeColor = System.Drawing.Color.Red;
            //}
            if (cboTipoOperacion.SelectedIndex == -1)
            {
                dato = dato + " Tipo de Operación";
                lblTipoOperacion.ForeColor = System.Drawing.Color.Red;
            }
            return dato;
        }
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                String dato = verificarTextos("");
                if (dato.Length!=0)
                {
                    MessageBox.Show("Falta llenar "+dato, Globales.Global_MessageBox);
                    return;
                }
                if (Convert.ToDecimal(txtareaterreno.Text)<=0)
                {
                    MessageBox.Show("El àrea de terreno tiene que ser mayor que 0", Globales.Global_MessageBox);
                    return;
                }
                lblContribuyente.ForeColor = System.Drawing.Color.Black;
                if (cboContribuyente.SelectedIndex < 0)
                {
                    lblContribuyente.ForeColor = System.Drawing.Color.Red;
                    MessageBox.Show("Escoja una persona por favor", Globales.Global_MessageBox);
                    return;
                }
                Decimal arancel = pred_PredioDataService.GetArancelSubdividido(Predio_ID_Global);
                if (arancel == 0)
                {
                    MessageBox.Show("No existe Arancel en este periodo", Globales.Global_MessageBox);
                    return;
                }
                if (pred_PredioDataService.existeDireccionSubdividido(Predio_ID_Global, txtVia.Text, txtInterior.Text,
                   txtMz.Text, txtLote.Text, txtEdificio.Text, txtPiso.Text, txtDpto.Text, txtienda.Text,txtKm.Text.TrimEnd()) > 0)
                {
                    //MessageBox.Show("Ya existe predio en dirección", Globales.Global_MessageBox);
                    //return;
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

                decimal terrenoFaltante = Convert.ToDecimal(lblFaltaRepartir.Text) - Convert.ToDecimal(txtareaterreno.Text);
                //if (terrenoFaltante < 0)
                //{
                //    MessageBox.Show("El área de terreno que desea guardar sobre pasa al área de terreno del predio", Globales.Global_MessageBox);
                //    return;
                //}
                if (MessageBox.Show("Desea Guardar la subdivisión?", Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DateTime fechaHoy = DateTime.Now;
                    //string Predio_id_sub = fechaHoy.Year.ToString() + fechaHoy.Month.ToString() + fechaHoy.Day.ToString() +
                    //           fechaHoy.Hour.ToString() + fechaHoy.Minute.ToString() + fechaHoy.Second.ToString();
                    Pred_Predio pred_Predio = new Pred_Predio();
                    Pred_PredioContribuyente pred_PredioContribuyente = new Pred_PredioContribuyente();
                    pred_Predio.kilometro = txtKm.Text.Trim();
                    pred_Predio.arancel = arancel;
                    pred_Predio.nombre_predio = txtNombrePredio.Text.TrimEnd();
                    pred_Predio.num_ficha = txtFicha.Text;
                    pred_Predio.fecha_adquisicion = dtpFechaAdquision.Value;
                    pred_Predio.fecha_inscripcion = dtpFechaInscripcion.Value;
                    pred_Predio.num_personas = Convert.ToInt32(txtNPersonas.Text);
                    pred_Predio.num_via = txtVia.Text.Trim();
                    pred_Predio.mz = txtMz.Text.Trim();
                    pred_Predio.lote = txtLote.Text.Trim();
                    pred_Predio.edificio = txtEdificio.Text.Trim();
                    pred_Predio.dpto = txtDpto.Text.Trim();
                    pred_Predio.tienda = txtienda.Text.Trim();
                    pred_Predio.interior = txtInterior.Text.Trim();
                    pred_Predio.piso = txtPiso.Text.Trim();
                    pred_Predio.valor_referencial = Convert.ToDecimal(txtValorReferncial.Text);
                    pred_Predio.area_terreno = Convert.ToDecimal(txtareaterreno.Text);
                    pred_Predio.expediente = txtExpediente.Text.Trim();
                    pred_Predio.area_construida = Convert.ToDecimal(txtAreaconstruida.Text);
                    //pred_Predio.predio_ID = Predio_id_sub;
                    pred_Predio.tipo_adquisicion = Convert.ToInt32(cboAdquisicion.SelectedValue.ToString());
                    pred_Predio.condicionPropietario = Convert.ToInt32(cboPosesion.SelectedValue.ToString());
                    pred_Predio.uso_predio = cboUso.SelectedValue.ToString();
                    pred_Predio.tipo_operacion = Convert.ToInt32(cboTipoOperacion.SelectedValue.ToString());
                    pred_Predio.DescripcionHistorial = txtDescripcionHistorial.Text.TrimEnd();
                    string Predio_id_sub = pred_PredioDataService.InsertPredioSUbdividido(pred_Predio, Predio_ID_Global);
                    //pred_Predio.area_comun
                    //PREDIO
                    if (Predio_id_sub.Trim().Length == 0)
                    {
                        MessageBox.Show("Ocurrio un error al agregar subdivisión", Globales.Global_MessageBox);
                        return;
                    }
                    else
                    {
                        //INSERT PREDIO CONTRIBUYENTE
                        pred_PredioContribuyente.persona_ID = cboContribuyente.SelectedValue.ToString();
                        pred_PredioContribuyente.tipo_adquisicion = Convert.ToInt32(cboAdquisicion.SelectedValue.ToString());
                        pred_PredioContribuyente.tipo_posesion = Convert.ToInt32(cboPosesion.SelectedValue.ToString());
                        pred_PredioContribuyente.Porcentaje_Condomino = Convert.ToDecimal(txtPorcentjecondominio.Text);
                        pred_PredioContribuyente.expediente = txtExpediente.Text;
                        pred_PredioContribuyente.Fecha = dtpFechaAdquision.Value;
                        pred_PredioContribuyente.registro_user_add = user;
                        pred_PredioContribuyente.Predio_id = Predio_id_sub;
                        pred_PredioContribuyenteDataService.InsertParaSubdivision(pred_PredioContribuyente);
                        //PISOS
                        InsertarPisoseInstalciones(dgvPisos, Predio_id_sub, "Incluir", "piso_ID", 1, cboContribuyente.SelectedValue.ToString());
                        //OTRASiNSTALACIONES
                        InsertarPisoseInstalciones(dgvOtrasInstalaciones, Predio_id_sub, "IncluirOtras", "PrediosOtras_id", 2, "");
                        //actualizacion de grilla
                        dgvOtrasInstalaciones.DataSource = Pred_OtrasInstalacionesDataService.listarByPredioIDActivos(Predio_ID_Global, true);
                        dgvPisos.DataSource = PisosDataService.listarByPredioIDActivos(Predio_ID_Global, true);
                        dgvPredio.DataSource = pred_PredioDataService.listarPredioSubdividos(Predio_ID_Global);
                        LimpiarTextos();
                        lblFaltaRepartir.Text = terrenoFaltante.ToString();
                         MessageBox.Show("Se Grabó correctamente", Globales.Global_MessageBox);
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
        private void InsertarPisoseInstalciones(DataGridView dgv,String Predio_i,String check,String idObj,int tipo, String persona_id)
        {
            int cantidad;
            cantidad = dgv.RowCount;
            int id;
            bool bandera;
            for (int i = 0; i < cantidad; i++)
            {
                DataGridViewRow row = dgv.Rows[i];
                DataGridViewCheckBoxCell cellSelecion = row.Cells[check] as DataGridViewCheckBoxCell;
                bandera = Convert.ToBoolean(cellSelecion.Value);
                if (bandera)
                {
                    if (tipo == 1)//insertar pisos
                    {
                        PisosDataService.InsertPisoSubdivision(obtenerdatosPiso(i, Predio_i, persona_id));
                        //PisosDataService.CopiarPisoIndividual(id, Predio_i, areaComun, persona_id, user);
                    }
                    else if (tipo == 2)//insertar otras instalaciones
                    {
                        Pred_OtrasInstalacionesDataService.InsertOtrasInstalcionesSubdivision(obtenerdatosOtrasInstalaciones(i, Predio_i));
                        //Pred_OtrasInstalacionesDataService.CopiarInstalacionesIndividual(id, Predio_i, user);
                    }
                }
            }
        }
        private Pred_Pisos obtenerdatosPiso(int i,String Predio_i,String persona_id)
        {
            Pred_Pisos Pred_Pisos = new Pred_Pisos();
            Pred_Pisos.anio = (Int16)dgvPisos.Rows[i].Cells["anio"].Value;
            //Pred_Pisos.antiguedad_id = (string)dgvPisos.Rows[i].Cells["antiguedad_id"].Value;
            Pred_Pisos.antiguedad = (int)dgvPisos.Rows[i].Cells["antiguedad"].Value;
            Pred_Pisos.estado = (bool)dgvPisos.Rows[i].Cells["pestado"].Value;
            Pred_Pisos.area_comun = (decimal)dgvPisos.Rows[i].Cells["area_comun"].Value;
            Pred_Pisos.area_construida = (decimal)dgvPisos.Rows[i].Cells["area_construida"].Value;
            Pred_Pisos.banio = (string)dgvPisos.Rows[i].Cells["banio"].Value;
            Pred_Pisos.clase= (string)dgvPisos.Rows[i].Cells["clase"].Value;
            Pred_Pisos.clasificacion_id = (string)dgvPisos.Rows[i].Cells["clasificacion_id"].Value;
            Pred_Pisos.condicion_id = (string)dgvPisos.Rows[i].Cells["condicion_id"].Value;
            Pred_Pisos.estado_id = (string)dgvPisos.Rows[i].Cells["estado_id"].Value;
            Pred_Pisos.fecha_construc = (DateTime)dgvPisos.Rows[i].Cells["fecha_construc"].Value;
            Pred_Pisos.incremento = (decimal)dgvPisos.Rows[i].Cells["incremento"].Value;
            Pred_Pisos.instalaciones = (string)dgvPisos.Rows[i].Cells["instalaciones"].Value;
            Pred_Pisos.material_id = (string)dgvPisos.Rows[i].Cells["material_id"].Value;
            Pred_Pisos.metros_alquilados = (decimal)dgvPisos.Rows[i].Cells["metros_alquilados"].Value;
            Pred_Pisos.muro = (string)dgvPisos.Rows[i].Cells["muro"].Value;
            Pred_Pisos.numero = (int)dgvPisos.Rows[i].Cells["numero"].Value;
            Pred_Pisos.persona_ID = persona_id;//(string)dgvPisos.Rows[i].Cells["persona_ID"].Value;
            Pred_Pisos.piso = (string)dgvPisos.Rows[i].Cells["piso"].Value;
            Pred_Pisos.piso_ID = (int)dgvPisos.Rows[i].Cells["piso_ID"].Value;
            Pred_Pisos.porcent_depreci = (decimal)dgvPisos.Rows[i].Cells["porcent_depreci"].Value;
            Pred_Pisos.predio_ID = Predio_i;//(string)dgvPisos.Rows[i].Cells["predio_ID"].Value;
            Pred_Pisos.puerta = (string)dgvPisos.Rows[i].Cells["puerta"].Value;
            Pred_Pisos.revestimiento = (string)dgvPisos.Rows[i].Cells["revestimiento"].Value;
            Pred_Pisos.seccion = (string)dgvPisos.Rows[i].Cells["seccion"].Value;
            Pred_Pisos.techo = (string)dgvPisos.Rows[i].Cells["techo"].Value;
            Pred_Pisos.registro_user_add = user;
            return Pred_Pisos;
        }
        private Pred_OtrasInstalaciones obtenerdatosOtrasInstalaciones(int i,String Predio_i)
        {
            Pred_OtrasInstalaciones Pred_OtrasInstalaciones = new Pred_OtrasInstalaciones();
            Pred_OtrasInstalaciones.PrediosOtras_id = (Int32)dgvOtrasInstalaciones.Rows[i].Cells["PrediosOtras_id"].Value;
            Pred_OtrasInstalaciones.Predio_id = Predio_i; //(string)dgvOtrasInstalaciones.Rows[i].Cells["Predio_id"].Value;
            Pred_OtrasInstalaciones.Estado = (bool)dgvOtrasInstalaciones.Rows[i].Cells["Estado"].Value;
            Pred_OtrasInstalaciones.OtrasValor_descripcion = (string)dgvOtrasInstalaciones.Rows[i].Cells["OtrasValor_descripcion"].Value;
            Pred_OtrasInstalaciones.Observacion = (string)dgvOtrasInstalaciones.Rows[i].Cells["Observacion"].Value;
            Pred_OtrasInstalaciones.CantidadValor = (decimal)dgvOtrasInstalaciones.Rows[i].Cells["CantidadValor"].Value;
            Pred_OtrasInstalaciones.ValorOtras = (decimal)dgvOtrasInstalaciones.Rows[i].Cells["ValorOtras"].Value;
            Pred_OtrasInstalaciones.OtrasValor_id = (Int32)dgvOtrasInstalaciones.Rows[i].Cells["OtrasValor_id"].Value;
            Pred_OtrasInstalaciones.registro_user_add = user;
            return Pred_OtrasInstalaciones;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarGrilla(dgvPisos, "Incluir");
                LimpiarGrilla(dgvOtrasInstalaciones, "IncluirOtras");
                LimpiarTextos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }
        private void LimpiarTextos()
        {
            txtAreaComun.Text = "0"; txtAreaconstruida.Text = "0"; txtAreaFrrente.Text = "0"; txtEdificio.Text = ""; txtPiso.Text = "";
            txtNPersonas.Text = "0"; txtFicha.Text = ""; txtVia.Text = ""; txtValorReferncial.Text = ""; txtLote.Text = "";
            txtMz.Text = ""; txtInterior.Text = ""; txtPorcentjecondominio.Text = "100"; txtienda.Text = ""; txtareaterreno.Text = "0";
            txtExpediente.Text = "";txtNombrePredio.Text = "";
            cboContribuyente.SelectedIndex = -1;
            ckbTodosOtrasInstalaciones.Checked = false;
            ckbTodosPisos.Checked = false;
        }
        private void LimpiarGrilla(DataGridView dgv,String NameStado)
        {
            try {
                int cantidad;
                cantidad = dgv.RowCount;
                for (int i = 0; i < cantidad; i++)
                {
                    DataGridViewRow row1 = dgv.Rows[i];
                    DataGridViewCheckBoxCell cellSelecion1 = row1.Cells[NameStado] as DataGridViewCheckBoxCell;
                    cellSelecion1.Value = false;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }
        private void btnGrabarTodo_Click(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try {
                if (Convert.ToInt32(txtNSubdivisiones.Text) != dgvPredio.RowCount)
                {
                    MessageBox.Show("El Nº de subdivisiones no es igual a la cantidad de Predio", Globales.Global_MessageBox);
                    return;
                }
                if (dgvPisos.RowCount > 0)
                {
                    MessageBox.Show("Falta Agregar Pisos", Globales.Global_MessageBox);
                    return;
                }
                if (dgvOtrasInstalaciones.RowCount > 0)
                {
                    MessageBox.Show("Falta Agregar Otras Instalaciones", Globales.Global_MessageBox);
                    return;
                }
                //if (Convert.ToDecimal(lblFaltaRepartir.Text)!=0)
                //    //if (VerficarTerrenoSubdividido() != Convert.ToDecimal(txtAreaTerrenoOriginal.Text))
                //    {
                //    MessageBox.Show("Falta completar Área de terreno", Globales.Global_MessageBox);
                //    return;
                //}
                if (MessageBox.Show("Desea Guardar Todas las subdivisiones?", Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                        int cantidad;
                        cantidad = dgvPredio.RowCount;
                        String hijo;
                        for (int i = 0; i < cantidad; i++)
                        {
                            DataGridViewRow row1 = dgvPredio.Rows[i];
                            hijo = (String)row1.Cells["predio_ID_Subdividido"].Value;
                            PrredioArbitrioDataService.copiarArbitriosDePadreaHijo(hijo,Predio_ID_Global, user);
                        }
                    //PrredioArbitrioDataService
                    if (!pred_PredioDataService.DeleteByPrimaryKey(Predio_ID_Global))//elimino el predio global, y creo  de verdd los predios subdivididos
                    {
                        MessageBox.Show("Ocurrio Un Error, vuelva a Grabar más tarde", Globales.Global_MessageBox);
                        return;
                    }
                    MessageBox.Show("Se grabó Correctamente", Globales.Global_MessageBox);
                    btnCancelar.Enabled = false;
                    btnGrabar.Enabled = false;
                    btnGrabarTodo.Enabled = false;
                    btnCancelarTodo.Enabled = false;
                    cerro = true;
                        //this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error,"+ex.ToString()+" vuelva a Grabar", Globales.Global_MessageBox);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private decimal VerficarTerrenoSubdividido()
        {
            int cantidad = dgvPredio.RowCount;
            decimal TerrenoxGrilla = 0;
            for (int i = 0; i < cantidad; i++)
            {
                TerrenoxGrilla = TerrenoxGrilla+(decimal)dgvPredio.Rows[i].Cells["area_terreno"].Value;
            }
            return TerrenoxGrilla;
        }
        private void btnCancelarTodo_Click(object sender, EventArgs e)
        {
            try {
                if (dgvPredio.RowCount > 0)
                {
                    if (MessageBox.Show("Está seguro que desea cerrar, se perderán todos los datos?", Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        pred_PredioDataService.EliminarPredioSUbdividido(Predio_ID_Global, 19);
                    }
                }
                cerro = true;
                this.Dispose();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
           
        }

        private void Frm_Subdivision__FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!cerro)
                btnCancelarTodo.PerformClick();
        }
        private void dataGridView2_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvPisos.IsCurrentCellDirty)
            {
                dgvPisos.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvPisos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {//cunado finlaiza recien se actualiza el estado
            try
            {
                if (dgvPisos.Columns[e.ColumnIndex].Name == "Incluir")
                {
                    decimal total = Convert.ToDecimal(txtAreaconstruida.Text);
                    decimal mayor = 0;
                    if (e.RowIndex == -1)
                        return;
                    int cantidad;
                    cantidad = dgvPisos.RowCount;
                    DataGridViewRow row = dgvPisos.Rows[e.RowIndex];
                    DataGridViewCheckBoxCell cellSelecion = row.Cells["Incluir"] as DataGridViewCheckBoxCell;
                    decimal valor = (decimal)row.Cells["area_construida"].Value;
                    if (Convert.ToBoolean(cellSelecion.Value))
                        total = total + valor;
                    else
                        total = total - valor;

                    txtAreaconstruida.Text = total.ToString();
                   
                    //txtareaterreno.Text = total.ToString();
                }//
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void dgvPredio_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (dgvPredio.Columns[e.ColumnIndex].Name == "xAnular")
                {
                    if (MessageBox.Show("Desea Eliminar?", Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        String idSubdividido = (String)dgvPredio.SelectedRows[0].Cells["predio_ID_Subdividido"].Value;
                        pred_PredioDataService.EliminarPredioSUbdividido(idSubdividido, 18);
                        dgvOtrasInstalaciones.DataSource = Pred_OtrasInstalacionesDataService.listarByPredioIDActivos(Predio_ID_Global, true);
                        dgvPisos.DataSource = PisosDataService.listarByPredioIDActivos(Predio_ID_Global, true);
                        dgvPredio.DataSource = pred_PredioDataService.listarPredioSubdividos(Predio_ID_Global);
                        decimal terrenofaltante = AreaTerrenoOriginal - VerficarTerrenoSubdividido();
                        lblFaltaRepartir.Text = terrenofaltante.ToString();
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
        private void ckbTodosPisos_CheckedChanged(object sender, EventArgs e)
        {
            habilitarPisosInstalaciones(dgvPisos, "Incluir", ckbTodosPisos.Checked,1);
        }

        private void ckbTodosOtrasInstalaciones_CheckedChanged(object sender, EventArgs e)
        {
            habilitarPisosInstalaciones(dgvOtrasInstalaciones, "IncluirOtras", ckbTodosOtrasInstalaciones.Checked,2);
        }
        public void habilitarPisosInstalaciones(DataGridView  dgv,String checkname,bool estado,int tipo)
        {
            try {
                int cantidad;
                cantidad = dgv.RowCount;
                decimal total = 0;
                decimal valor = 0;
                for (int i = 0; i < cantidad; i++)
                {
                    DataGridViewRow row1 = dgv.Rows[i];
                    DataGridViewCheckBoxCell cellSelecion1 = row1.Cells[checkname] as DataGridViewCheckBoxCell;
                    cellSelecion1.Value = estado;
                    if (tipo == 1 && estado)
                    {
                        valor = (decimal)row1.Cells["area_construida"].Value;
                        total = total + valor;
                    }
                }
                if (tipo == 1 && estado)
                {
                    txtAreaconstruida.Text = total.ToString();
                    //txtareaterreno.Text = total.ToString();
                }
                else if (tipo == 1 && !estado)
                {
                    txtAreaconstruida.Text = "0";
                    //txtareaterreno.Text = "0";
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
            
        }
        #region validaTextos
        private void txtNPersonas_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.validaNumeroEntero(e, Globales.Global_MessageBox);
        }

        private void txtareaterreno_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.ValidarNumeroDecimal(e,txtareaterreno.Text, Globales.Global_MessageBox);
        }

        private void txtAreaComun_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.ValidarNumeroDecimal(e, txtAreaComun.Text, Globales.Global_MessageBox);
        }

        private void txtPorcentjecondominio_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.ValidarNumeroDecimal(e, txtPorcentjecondominio.Text, Globales.Global_MessageBox);
        }

        private void txtAreaFrrente_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.ValidarNumeroDecimal(e, txtAreaFrrente.Text, Globales.Global_MessageBox);
        }

        private void txtValorReferncial_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.ValidarNumeroDecimal(e, txtValorReferncial.Text, Globales.Global_MessageBox);
        }

        private void txtVia_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.validaNumeroEntero(e, Globales.Global_MessageBox);
        }
        private void txtNSubdivisiones_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.validaNumeroEntero(e, Globales.Global_MessageBox);
            string Comprobar = txtNSubdivisiones.Text + e.KeyChar.ToString();
            int co = int.Parse(Comprobar);
            if (co <= 1)
            {
                MessageBox.Show("Número de subdivisiones invalido", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        #endregion

        private void dgvPredio_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvPredio.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void dgvPredio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtKm_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.validaNumeroEntero(e, Globales.Global_MessageBox);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBusqueda.Text.TrimEnd().Length != 0)
                {
                    cboContribuyente.Enabled = true;
                    cboContribuyente.DisplayMember = "persona_Desc";
                    cboContribuyente.ValueMember = "persona_ID";
                    cboContribuyente.DataSource = persona.listarcontribuyentes(txtBusqueda.Text.TrimEnd());
                    this.cboContribuyente.AutoCompleteMode = AutoCompleteMode.Suggest;
                    this.cboContribuyente.AutoCompleteSource = AutoCompleteSource.CustomSource;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void cboTipoOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
