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
using SGR.WinApp.Layout._5_Reportes_Gestion;
using SGR.Core.Service.Combos;
using SGR.Entity.Model.Combos;
using Microsoft.Reporting.WinForms;

namespace SGR.WinApp.Layout._4_Procesos.Predio.Adeudo
{
    public partial class Frm_Alcabala : Form
    {
        Pago_PersonaDataService persona = new Pago_PersonaDataService();
        private Mant_PeriodoDataService PeriodoDataService = new Mant_PeriodoDataService();
        private Conf_MultitablaDataService conf_MultitablaDataService = new Conf_MultitablaDataService();
        private List<Mant_Periodo> periodos = new List<Mant_Periodo>();
        private Pred_Certificado_AlcabalaDataService Certificado_AlcabalaDataService = new Pred_Certificado_AlcabalaDataService();
        private Sistema.Globales.Validaciones obValidacion = new Sistema.Globales.Validaciones();
        private string usser = GlobalesV1.Global_str_Usuario;
        private string persona_id_global="0";
        private string predio_id_global = "0";
        private string predio_direccion_global = "0";
        private string persona_name_global = "";
        private int alcabala_id_certificado = 0;
        private int cantidadOtrosContribuyente=0;
        private decimal porcentajeCondominioMaximo=0;
        private decimal area_terreno;
        public Frm_Alcabala(Pred_Certificado_Alcabala Certificado_Alcabala)
        {
            try
            {
                InitializeComponent();
                mostrarTab(3);
                alcabala_id_certificado = Certificado_Alcabala.certalcabala_id;
                txtEAlcabala.Text = Certificado_Alcabala.alcabala.ToString();
                txtEAñoGenrraicon.Text = Certificado_Alcabala.anioGeneracion.ToString();
                txtECondomino.Text = Certificado_Alcabala.condomino.ToString();
                txtENUevoPropietario.Text = Certificado_Alcabala.vendedor_name;
                txtEPredio.Text = Certificado_Alcabala.predio_id + " - " + Certificado_Alcabala.direccion_completa;
                txtETasa.Text = Certificado_Alcabala.tasaAlcabala.ToString();
                txtETipoAdquisicion.Text = Certificado_Alcabala.adquisicion_descripcion;
                txtETipoPosesion.Text = Certificado_Alcabala.posesion_descripcion;
                txtEUitAlcabala.Text = Certificado_Alcabala.uits.ToString();
                txtEValorAfecto.Text = Certificado_Alcabala.valor_afecto.ToString();
                txtEValorVenta.Text = Certificado_Alcabala.valor_venta.ToString();
                txtEVendedor.Text = Certificado_Alcabala.vendedor_name;
                ckbEEstado.Checked = Certificado_Alcabala.estado;
                lblPersona.Visible = false;
                lblDireccion.Visible = false;
                rbtAlcabala.Visible = false;
                rbtPasaAlcabala.Visible = false;
                rbtAlcabalaPasado.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }
        public Frm_Alcabala()
        {
            try
            {
                InitializeComponent();
                mostrarTab(1);
                cagarTipoSelector();
                this.persona_id_global = "00";
                this.predio_id_global = "00";
                this.predio_direccion_global = "husares de junin";
                lblPersona.Text = "yaja";
                lblDireccion.Text = predio_direccion_global;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }
        public Frm_Alcabala(String persona_id,String predio_direccion,String persona_name,String predio_id,int cantidadOtrosContribuyente,decimal porcentajeCondominioMaximo,
                            Decimal  valor_terreno, Decimal valor_construccion, Decimal valor_otra_instalacion, Decimal total_autovaluo,Decimal area_terreno)
        {
            try
            {
                InitializeComponent();
                mostrarTab(1);
                cagarTipoSelector();
                this.persona_id_global = persona_id;
                this.predio_id_global = predio_id;
                this.predio_direccion_global = predio_direccion;
                this.cantidadOtrosContribuyente = cantidadOtrosContribuyente;
                this.porcentajeCondominioMaximo = porcentajeCondominioMaximo;
                lblPersona.Text = persona_name;
                lblDireccion.Text = predio_direccion;
                lblTodo.Text="Puede vender como máximo "+ porcentajeCondominioMaximo.ToString();
                lblValorConstruccion.Text = valor_construccion.ToString();
                lblValorTerreno.Text = valor_terreno.ToString();
                lblValorOtrasInstalaciones.Text = valor_otra_instalacion.ToString();
                lblValuo.Text = total_autovaluo.ToString();
                this.area_terreno = area_terreno;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }
        private void rbtAlcabala_CheckedChanged(object sender, EventArgs e)
        {
            mostrarTab(1);
        }

        private void rbtPasaAlcabala_CheckedChanged(object sender, EventArgs e)
        {
            mostrarTab(2);
        }
        private void mostrarTab(int tipo)
        {
            try {
                LimpiarTodo();
                this.tabGeneral.Controls.Clear();
                if (tipo == 1)
                    this.tabGeneral.Controls.Add(this.tbpAlcabala);
                else if (tipo == 2)
                    this.tabGeneral.Controls.Add(this.tbpPasarPropiedad);
                else if (tipo == 3)
                    this.tabGeneral.Controls.Add(this.tbpDatos);
                else if (tipo == 4)
                    this.tabGeneral.Controls.Add(this.tbpAlcabalaPasada);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
            
        }
        private void cagarTipoSelector()
        {
            //cboContribuyente.DisplayMember = "persona_Desc";
            //cboContribuyente.ValueMember = "persona_ID";
            //cboContribuyente.DataSource = persona.listarcontribuyentes();//persona.listarcontribuyentesPN(Predio_ID_Global, PeriodoDataService.GetPeriodoActivo()); ;
            //persona.listarpersonaxID(Predio_ID_Global, PeriodoDataService.GetPeriodoActivo());//persona.listarcontribuyentes(); ;
            this.cboContribuyente.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.cboContribuyente.AutoCompleteSource = AutoCompleteSource.CustomSource;
            llenarCboMultitabla(cboTipoTerreno, "Multc_vDescripcion", "Multc_cValor", "5");//verificar si es asi
            llenarCboMultitabla(cboTipoAdquisicion, "Multc_vDescripcion", "Multc_cValor", "4");
            llenarCboMultitabla(cboTipoPosesion, "Multc_vDescripcion", "Multc_cValor", "18");
            periodos = PeriodoDataService.GetAllMant_Periodo();
            cboAnioAdquisiscion.DisplayMember = "Peric_canio";
            cboAnioAdquisiscion.ValueMember = "Peric_canio";
            cboAnioAdquisiscion.DataSource = periodos;
            llenarCboMultitabla(cboUso, "Multc_vDescripcion", "Multc_cValor", "30");//verificar si es asi
            llenarCboMultitabla(cboTipoAdquisicionAl, "Multc_vDescripcion", "Multc_cValor", "4");
            llenarCboMultitabla(cboTipoPosesionAl, "Multc_vDescripcion", "Multc_cValor", "18");
            periodos = PeriodoDataService.GetAllMant_Periodo();
            cboAnioGeneracionAl.DisplayMember = "Peric_canio";
            cboAnioGeneracionAl.ValueMember = "Peric_canio";
            cboAnioGeneracionAl.DataSource = periodos;
            cboPersonaAl.DisplayMember = "persona_Desc";
            cboPersonaAl.ValueMember = "persona_ID";

            cboAnioGeneraciPasado.DisplayMember = "Peric_canio";
            cboAnioGeneraciPasado.ValueMember = "Peric_canio";
            cboAnioGeneraciPasado.DataSource = periodos;
            llenarCboMultitabla(cboTipoAdquisicionPasado, "Multc_vDescripcion", "Multc_cValor", "4");
            llenarCboMultitabla(cboTipoPosesionPasado, "Multc_vDescripcion", "Multc_cValor", "18");
            llenarCboMultitabla(cboTipoTerrenoPasado, "Multc_vDescripcion", "Multc_cValor", "5");
            llenarCboMultitabla(cboUsoPredioPAsado, "Multc_vDescripcion", "Multc_cValor", "30");
            //cboPersonaAl.DataSource = persona.listarcontribuyentes();
            //this.cboPersonaAl.AutoCompleteMode = AutoCompleteMode.Suggest;
            //this.cboPersonaAl.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void llenarCboMultitabla(ComboBox cbo, String display, String valor, String tipo)
        {
            cbo.DisplayMember = display;
            cbo.ValueMember = valor;
            cbo.DataSource = conf_MultitablaDataService.GetCboConf_Multitabla(tipo);
        }
        private String verificarDatoAlcabala(String dato)
        {
            lblCondominio.ForeColor = System.Drawing.Color.Black;
            lblNuevoPropietario.ForeColor = System.Drawing.Color.Black;
            lblValorMinuta.ForeColor = System.Drawing.Color.Black;
            lblTipoAdquisicion.ForeColor = System.Drawing.Color.Black;
            lblTipoPosesion.ForeColor = System.Drawing.Color.Black;
            lblAnioGeneracion.ForeColor = System.Drawing.Color.Black;
            if (txtCondominoaL.Text.Trim().Length == 0)
            {
                dato = dato + "Condominio, ";
                lblCondominio.ForeColor = System.Drawing.Color.Red;
            }
            if (cboPersonaAl.SelectedIndex==-1 )
            {
                dato = dato + "Persona, ";
                lblNuevoPropietario.ForeColor = System.Drawing.Color.Red;

            }
            if (txtValorMinuta.Text.Trim().Length == 0)
            {
                dato = dato + "Valor de Venta, ";
                lblValorMinuta.ForeColor = System.Drawing.Color.Red;
            }
            if (cboTipoAdquisicionAl.SelectedIndex == -1)
            {
                dato = dato + "Tipo de Adquisición, ";
                lblTipoAdquisicion.ForeColor = System.Drawing.Color.Red;
            }
            if (cboTipoPosesionAl.SelectedIndex == -1)
            {
                dato = dato + "Tipo de Posesión, ";
                lblTipoPosesion.ForeColor = System.Drawing.Color.Red;
            }
            if (cboAnioGeneracionAl.SelectedIndex == -1)
            {
                dato = dato + "Año de Generación";
                lblAnioGeneracion.ForeColor = System.Drawing.Color.Red;
            }
            return dato;
        }
        private String verificarDatoPasarPropiedad(String dato)
        {
            lbllAnioAlcabala.ForeColor = System.Drawing.Color.Black;
            lbllCondominio.ForeColor = System.Drawing.Color.Black;
            lbllNExpediente.ForeColor = System.Drawing.Color.Black;
            //lbllFicha.ForeColor = System.Drawing.Color.Black;
            lbllNroRecibo.ForeColor = System.Drawing.Color.Black;
            lbllNuevoPropietario.ForeColor = System.Drawing.Color.Black;
            lbllObservaciones.ForeColor = System.Drawing.Color.Black;
            lbllTipoAdquisicion.ForeColor = System.Drawing.Color.Black;
            lbllTipoPosesion.ForeColor = System.Drawing.Color.Black;
           if (txtCondomino.Text.Trim().Length == 0)
            {
                dato = dato + "Condominio, ";
                lbllCondominio.ForeColor = System.Drawing.Color.Red;
            }
            if (cboContribuyente.SelectedIndex == -1)
            {
                dato = dato + "Persona, ";
                lbllNuevoPropietario.ForeColor = System.Drawing.Color.Red;

            }
            //if (txtFicha.Text.Trim().Length == 0)
            //{
            //    dato = dato + "Ficha, ";
            //    lbllFicha.ForeColor = System.Drawing.Color.Red;
            //}
            if (Convert.ToDecimal(lblImpuesto.Text) != 0)
            {
                if (txtNRecibo.Text.Trim().Length == 0)
                {
                    dato = dato + "NºRecibo, ";
                    lbllNroRecibo.ForeColor = System.Drawing.Color.Red;
                }
            }
                
            if (txtExpediente.Text.Trim().Length == 0)
            {
                dato = dato + "Expediente, ";
                lbllNExpediente.ForeColor = System.Drawing.Color.Red;
            }
            if (cboTipoAdquisicion.SelectedIndex == -1)
            {
                dato = dato + "Tipo de Adquisición, ";
                lbllTipoAdquisicion.ForeColor = System.Drawing.Color.Red;
            }
            if (cboTipoPosesion.SelectedIndex == -1)
            {
                dato = dato + "Tipo de Posesión, ";
                lbllTipoPosesion.ForeColor = System.Drawing.Color.Red;
            }
            if (cboAnioAdquisiscion.SelectedIndex == -1)
            {
                dato = dato + "Año";
                lblAnioGeneracion.ForeColor = System.Drawing.Color.Red;
            }
            return dato;
        }
        private void btnVerAlcabalaAl_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Frm_Visor_Global frm_Visor_Global = new Frm_Visor_Global();
            try
            {
                decimal montoCalculado = 0;
                if (alcabala_id_certificado > 0)
                {
                    Pred_Certificado_Alcabala Certificado_Alcabala = new Pred_Certificado_Alcabala();
                    Certificado_Alcabala = Certificado_AlcabalaDataService.GetByPrimaryKey(alcabala_id_certificado);
                    if(Certificado_Alcabala.caso==1)//no paga paga nada
                    {
                        montoCalculado = 0;
                    }
                    else if (Certificado_Alcabala.caso == 2)//primera venta
                    {
                        montoCalculado = Certificado_Alcabala.valorTerreno;
                    }
                    else if (Certificado_Alcabala.caso == 3)
                    {
                        if (Certificado_Alcabala.valor_venta > Certificado_Alcabala.valuo)
                            montoCalculado = Certificado_Alcabala.valor_venta;
                        else
                            montoCalculado = Certificado_Alcabala.valuo;
                     }

                        frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                    frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._5_Reportes_Gestion.Rep_Alcabala.Reporte_Alcabala.rdlc";
                    ReportParameter[] paramsx = new ReportParameter[15];
                    paramsx[0] = new ReportParameter("NombreEmpresa", "Municipalidad Distrital de Moche");
                    paramsx[1] = new ReportParameter("UsuarioPrueba", "Usuario 01");
                    paramsx[2] = new ReportParameter("Periodo", Certificado_Alcabala.anio.ToString());
                    paramsx[3] = new ReportParameter("CodigoContribuyente", Certificado_Alcabala.comprador.ToString());
                    paramsx[4] = new ReportParameter("NombreContribuyente", Certificado_Alcabala.comprador_name.ToString());
                    paramsx[5] = new ReportParameter("CodigoPredio", Certificado_Alcabala.predio_id.ToString());
                    paramsx[6] = new ReportParameter("Direccion", predio_direccion_global);
                    paramsx[7] = new ReportParameter("Valuo", Certificado_Alcabala.valuo.ToString());
                    paramsx[8] = new ReportParameter("PrecioVenta", Certificado_Alcabala.valor_venta.ToString());
                    paramsx[9] = new ReportParameter("MontoCalculado", montoCalculado.ToString());
                    paramsx[10] = new ReportParameter("UIT", Certificado_Alcabala.uits.ToString());
                    paramsx[11] = new ReportParameter("TasaArancelaria", Certificado_Alcabala.tasaAlcabala.ToString());
                    paramsx[12] = new ReportParameter("BaseAfectada", Certificado_Alcabala.valor_afecto.ToString());
                    paramsx[13] = new ReportParameter("ResultadoArancelario", Certificado_Alcabala.alcabala.ToString());
                    paramsx[14] = new ReportParameter("ValorTerreno", Certificado_Alcabala.valorTerreno.ToString());
                   
                    frm_Visor_Global.reportViewer1.LocalReport.SetParameters(paramsx);
                    frm_Visor_Global.reportViewer1.RefreshReport();
                    frm_Visor_Global.StartPosition = FormStartPosition.CenterScreen;
                    frm_Visor_Global.ShowDialog();

                    //Pred_Certificado_Alcabala Certificado_Alcabala = new Pred_Certificado_Alcabala();
                    //Certificado_Alcabala = Certificado_AlcabalaDataService.GetByPrimaryKey(alcabala_id_certificado);
                    //frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                    //frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._5_Reportes_Gestion.Rep_Alcabala.Alcabala.rdlc";
                    //ReportParameter[] paramsx = new ReportParameter[15];
                    //paramsx[0] = new ReportParameter("Nombre", Certificado_Alcabala.comprador_name);
                    //paramsx[1] = new ReportParameter("Documento", Certificado_Alcabala.documento);
                    //paramsx[2] = new ReportParameter("DireccionFiscal", Certificado_Alcabala.OtraDireccion);
                    //paramsx[3] = new ReportParameter("Valuo", Certificado_Alcabala.valuo.ToString());
                    //paramsx[4] = new ReportParameter("CompraVenta", Certificado_Alcabala.valor_venta.ToString());
                    //paramsx[5] = new ReportParameter("Terreno", Certificado_Alcabala.valorTerreno.ToString());
                    //paramsx[6] = new ReportParameter("UITAlcabala", Certificado_Alcabala.uits.ToString());
                    //paramsx[7] = new ReportParameter("Saldo", Certificado_Alcabala.valor_afecto.ToString());
                    //paramsx[8] = new ReportParameter("Impuesto", Certificado_Alcabala.alcabala.ToString());
                    //paramsx[9] = new ReportParameter("NroConstancia", alcabala_id_certificado.ToString());
                    //paramsx[10] = new ReportParameter("CodigoPredial", predio_id_global);
                    //paramsx[11] = new ReportParameter("DireccionPredio", predio_direccion_global);
                    //paramsx[12] = new ReportParameter("AreaTotal", area_terreno.ToString());
                    //paramsx[13] = new ReportParameter("FechaMinuta",dtpFechaAlcabalaAl.Value.ToString()); 
                    //paramsx[14] = new ReportParameter("Usuario", "Rodriguez Pereda Juan"); 

                    //frm_Visor_Global.reportViewer1.LocalReport.SetParameters(paramsx);
                    //frm_Visor_Global.reportViewer1.RefreshReport();
                    //frm_Visor_Global.StartPosition = FormStartPosition.CenterScreen;
                    //frm_Visor_Global.ShowDialog();
                }
                else
                    MessageBox.Show("No hay alcabala generada", Globales.Global_MessageBox);
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

        private void btnGenerarAlcabalaAl_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                String dato = verificarDatoAlcabala("");
                String msj = "Desea Grabar?";
                if (dato.Trim().Length != 0)
                {
                    MessageBox.Show("Falta llenar "+dato, Globales.Global_MessageBox);
                    return;
                }
                Pred_Certificado_Alcabala Certificado_Alcabala = new Pred_Certificado_Alcabala();
                if (porcentajeCondominioMaximo != 100)
                {
                    if (ckbTodo.Checked)
                    {
                        msj = "Vendera toda la propiedad, Desea Grabar?";
                        Certificado_Alcabala.condomino = 100;
                    }
                    else
                    {
                        if (porcentajeCondominioMaximo < Convert.ToDecimal(txtCondominoaL.Text))
                        {
                            MessageBox.Show("Excede del porcentaje que puede vender", Globales.Global_MessageBox);
                            return;
                        }
                        Certificado_Alcabala.condomino = Convert.ToDecimal(txtCondominoaL.Text);
                    }
                }
                else
                {
                    if (100 < Convert.ToDecimal(txtCondominoaL.Text))
                    {
                        MessageBox.Show("Excede del 100%", Globales.Global_MessageBox);
                        return;
                    }
                    Certificado_Alcabala.condomino = Convert.ToDecimal(txtCondominoaL.Text);
                }
                DateTime fechaAlcabala = dtpFechaAlcabalaAl.Value;
                int mes = fechaAlcabala.Month;
                dato = Certificado_AlcabalaDataService.ErrorExistencia(predio_id_global, Convert.ToString(cboPersonaAl.SelectedValue),
                    Convert.ToInt32(cboAnioGeneracionAl.SelectedValue),mes);//parametro mes
                if (dato.Trim().Length != 0)
                {
                    MessageBox.Show(dato.TrimEnd(), Globales.Global_MessageBox);
                    return;
                }
                if (MessageBox.Show(msj, Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        
                        Certificado_Alcabala.persona_id = persona_id_global;
                        Certificado_Alcabala.comprador = Convert.ToString(cboPersonaAl.SelectedValue);
                        Certificado_Alcabala.predio_id = predio_id_global;
                        Certificado_Alcabala.tipo_alcabala = "1";//preguntar
                        Certificado_Alcabala.tipo_adquisicion = Convert.ToString(cboTipoAdquisicionAl.SelectedValue);
                    Certificado_Alcabala.fecha_alcabala = dtpFechaAlcabalaAl.Value;
                    Certificado_Alcabala.tipo_posesion = Convert.ToString(cboTipoPosesionAl.SelectedValue);
                        Certificado_Alcabala.valor_venta = Convert.ToDecimal(txtValorMinuta.Text);
                        Certificado_Alcabala.valuo = Convert.ToDecimal(lblValuo.Text);
                        Certificado_Alcabala.base_imponible = Certificado_Alcabala.valor_venta;
                        Certificado_Alcabala.registro_user_add = usser;
                        Certificado_Alcabala.estado = true;
                        Certificado_Alcabala.area = area_terreno;
                        Certificado_Alcabala.anioGeneracion = Convert.ToInt32(cboAnioGeneracionAl.SelectedValue);
                    Certificado_Alcabala.valorTerreno = Convert.ToDecimal(lblValorTerreno.Text);
                    Certificado_Alcabala.usopredio = Convert.ToInt32(cboUso.SelectedValue);
                    Certificado_Alcabala.tipo_inmueble = Convert.ToInt32(cboTipoTerreno.SelectedValue);
                    alcabala_id_certificado = Certificado_AlcabalaDataService.Insert(Certificado_Alcabala);
                    if (alcabala_id_certificado == 0)
                        MessageBox.Show("Ya existe alcabala", Globales.Global_MessageBox);
                    else {

                        MessageBox.Show("Se Grabó Correctamente", Globales.Global_MessageBox);
                        btnGenerarAlcabalaAl.Enabled = false;
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

        private void btnGenerarPasoPropiedad_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                String dato = verificarDatoPasarPropiedad("");
                string msj = "";
                if (dato.Trim().Length != 0)
                {
                    MessageBox.Show("Falta llenar datos", Globales.Global_MessageBox);
                    return;
                }
                if (Convert.ToDecimal(txtCondomino.Text)>100)
                {
                    MessageBox.Show("Exceso de condomino", Globales.Global_MessageBox);
                    return;
                }
                if (Convert.ToDecimal(txtCondomino.Text)<=porcentajeCondominioMaximo)//si vendera menos de lo q tiene
                {
                    if (Certificado_AlcabalaDataService.DeudaPendiente(persona_id_global) != 0)
                    {
                        msj = msj + "Hay deuda pendiente por el anterior propietario. ";
                        //MessageBox.Show("Hay deuda pendiente por el anterior comprador",Globales.Global_MessageBox);
                        //return;
                    }
                }
                else 
                {
                    if (Certificado_AlcabalaDataService.DeudaPendienteTotal(predio_id_global)!= 0)//si hay deuda pendiente de todos los dueños
                    {

                        msj = msj + "Hay deuda pendiente por el anterior propietario. ";
                        //MessageBox.Show("Hay deuda pendiente por el anterior propietario", Globales.Global_MessageBox);
                        //return;
                    }
                }
                msj = msj + "Desea Grabar?";
                if (Convert.ToDecimal(lblImpuesto.Text) != 0 )
                {
                    if (Certificado_AlcabalaDataService.ExisteRecibo(predio_id_global, cboContribuyente.SelectedValue.ToString(), cboAnioAdquisiscion.SelectedValue.ToString()) == 0)
                        //if (Certificado_AlcabalaDataService.ExisteRecibo(txtNRecibo.Text, cboContribuyente.SelectedValue.ToString(), cboAnioAdquisiscion.SelectedValue.ToString()) == 0)
                    {
                        MessageBox.Show("No pagó su tributo de alcabala", Globales.Global_MessageBox);
                        //MessageBox.Show("Nro de Recibo válido", Globales.Global_MessageBox);
                        return;
                    }
                }
                if (MessageBox.Show(msj, Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                    //Pred_Predio Predio=new Pred_Predio();
                    //Predio.tipo_adquisicion = Convert.ToInt32(cboTipoAdquisicion.SelectedValue);
                    //string persona = cboContribuyente.SelectedValue.ToString();
                    //Predio.fecha_inscripcion = dtpFechaInscripcion.Value;
                    //Predio.fecha_adquisicion = dtpDuenioDesde.Value;
                    //String nroRecibo = txtNRecibo.Text;
                    //Predio.condicionPropietario = Convert.ToInt32(cboTipoPosesion.SelectedValue);
                    //Decimal condomino = Convert.ToDecimal(txtCondomino.Text);
                    //Predio.anio_inscripcion= Convert.ToInt16(cboAnioAdquisiscion.SelectedValue);
                    //Predio.num_ficha = txtFicha.Text;
                    //Predio.expediente = txtExpediente.Text;
                    ////pasardeuda
                    //String observacion= txtObservacion.Text;
                    Certificado_AlcabalaDataService.TraspasoDePropiedad(dtpDuenioDesde.Value, Convert.ToInt32(cboTipoAdquisicion.SelectedValue), 
                        Convert.ToInt32(cboTipoPosesion.SelectedValue), txtObservacion.Text, Convert.ToInt16(cboAnioAdquisiscion.SelectedValue), txtExpediente.Text,
                        predio_id_global, persona_id_global,Convert.ToDecimal(txtCondomino.Text), usser,Convert.ToString(cboContribuyente.SelectedValue),
                        txtNRecibo.Text.Trim(),porcentajeCondominioMaximo,lblImpuesto.Text,lblUso.Text,lblTIpoInmueble.Text);
                        MessageBox.Show("Se generó traspaso ", Globales.Global_MessageBox);
                    this.Dispose();
                    //alcabala_id_certificado = Certificado_AlcabalaDataService.Insert(Certificado_Alcabala);
                    //if (alcabala_id_certificado == 0)
                    //    MessageBox.Show("No se grabó", Globales.Global_MessageBox);
                    //else
                    //    MessageBox.Show("Se Grabó Correctamente", Globales.Global_MessageBox);
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

        private void txtValorVentaAl_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.ValidarNumeroDecimal(e, txtValorMinuta.Text, Globales.Global_MessageBox);
        }

        private void txtCondominoaL_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.ValidarNumeroDecimal(e, txtCondominoaL.Text, Globales.Global_MessageBox);
        }

        private void txtNRecibo_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.validaNumeroEntero(e, Globales.Global_MessageBox);
        }


        //private void txtExpediente_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    obValidacion.validaNumeroEntero(e,Globales.Global_MessageBox);
        //}

        private void txtCondomino_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.ValidarNumeroDecimal(e, txtCondomino.Text, Globales.Global_MessageBox);
        }

        private void ckbTodo_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbTodo.Checked)
            {

                txtCondominoaL.Text = "100";
                txtCondominoaL.Enabled = false;
                lblTodo.Text = "Puede vender como máximo 100%";
            }
            else
            {
                txtCondominoaL.Text = "";
                txtCondominoaL.Enabled = true;
                lblTodo.Text = "Puede vender como máximo " + porcentajeCondominioMaximo.ToString();
            }
                
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cboAnioAdquisiscion.SelectedIndex != -1 && cboContribuyente.SelectedIndex != -1)
            {
                Pred_Certificado_Alcabala Certificado_Alcabala = new Pred_Certificado_Alcabala();
                Certificado_Alcabala=Certificado_AlcabalaDataService.GetByPrimaryPeComAnoPredio(predio_id_global,persona_id_global,Convert.ToString(cboContribuyente.SelectedValue), Convert.ToInt32(cboAnioAdquisiscion.SelectedValue));
                if (Certificado_Alcabala != null)
                {
                    txtCondomino.Text = Certificado_Alcabala.condomino.ToString();
                    dtpFechaInscripcion.Value = Certificado_Alcabala.fecha_tramite;
                    cboTipoAdquisicion.SelectedValue = (Certificado_Alcabala.tipo_adquisicion.ToString()).Trim();
                    cboTipoPosesion.SelectedValue = Certificado_Alcabala.tipo_posesion.ToString();
                    lblUso.Text = Certificado_Alcabala.usopredio.ToString();
                    lblImpuesto.Text = Certificado_Alcabala.alcabala.ToString();
                    lblTIpoInmueble.Text = Certificado_Alcabala.tipo_inmueble.ToString();
                    MessageBox.Show("Se cargo correctamente", Globales.Global_MessageBox);
                }
                else
                    MessageBox.Show("No hay alcabala",Globales.Global_MessageBox);

            }
            else
                MessageBox.Show("Esocjea el año y el comprador", Globales.Global_MessageBox);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCondomino.Text = "0";
            cboContribuyente.SelectedIndex = -1;
        }
        private void LimpiarTodo()
        {
            txtCondomino.Text = "0";
            cboPersonaAl.SelectedIndex = -1;
            cboContribuyente.SelectedIndex = -1;
            txtCondomino.Text = "0";
            txtCondominoaL.Text = "0";
            txtExpediente.Text = "";
            txtFicha.Text = "";
            txtNRecibo.Text = "";
            txtObservacion.Text = "";
            txtValorMinuta.Text = "";
            
        }

        private void cboTipoTerreno_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (String.Compare(cboTipoTerreno.SelectedValue.ToString(), "1") == 0)//URBANO
                {

                    llenarCboMultitabla(cboUso, "Multc_vDescripcion", "Multc_cValor", "8");

                }
                else
                {
                    llenarCboMultitabla(cboUso, "Multc_vDescripcion", "Multc_cValor", "30");//verificar si es asi
              
                }
            }
            catch (Exception ex) { }
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    btnBuscar1.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBuscar1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBusqueda.Text.TrimEnd().Length != 0)
                {
                    cboPersonaAl.Enabled = true;
                    cboPersonaAl.DisplayMember = "persona_Desc";
                    cboPersonaAl.ValueMember = "persona_ID";
                    cboPersonaAl.DataSource = persona.listarcontribuyentes(txtBusqueda.Text);
                    this.cboPersonaAl.AutoCompleteMode = AutoCompleteMode.Suggest;
                    this.cboPersonaAl.AutoCompleteSource = AutoCompleteSource.CustomSource;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtBusquedaPasar_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    btnBuscar3.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBuscar3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBusquedaPasar.Text.TrimEnd().Length!=0)
                {

                    cboContribuyente.Enabled = true;
                    cboContribuyente.DisplayMember = "persona_Desc";
                    cboContribuyente.ValueMember = "persona_ID";
                    cboContribuyente.DataSource = persona.listarcontribuyentes(txtBusquedaPasar.Text.TrimEnd());
                    this.cboPersonaAl.AutoCompleteMode = AutoCompleteMode.Suggest;
                    this.cboPersonaAl.AutoCompleteSource = AutoCompleteSource.CustomSource;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private String verificarDatoAlcabalaPasada(String dato)
        {
            //lblCondominio.ForeColor = System.Drawing.Color.Black;
            //lblNuevoPropietario.ForeColor = System.Drawing.Color.Black;
            //lblValorMinuta.ForeColor = System.Drawing.Color.Black;
            //lblTipoAdquisicion.ForeColor = System.Drawing.Color.Black;
            //lblTipoPosesion.ForeColor = System.Drawing.Color.Black;
            //lblAnioGeneracion.ForeColor = System.Drawing.Color.Black;
            if (txtCondominoaL.Text.Trim().Length == 0)
            {
                dato = dato + "Condominio, ";
            }
            if (cboContribuPasado.SelectedIndex == -1)
            {
                dato = dato + "Persona, ";

            }
            if (txtMinutaPasada.Text.Trim().Length == 0)
            {
                dato = dato + "Valor de Venta, ";
            }
            if (cboTipoAdquisicionPasado.SelectedIndex == -1)
            {
                dato = dato + "Tipo de Adquisición, ";
                //lblTipoAdquisicion.ForeColor = System.Drawing.Color.Red;
            }
            if (cboTipoPosesionPasado.SelectedIndex == -1)
            {
                dato = dato + "Tipo de Posesión, ";
                //lblTipoPosesion.ForeColor = System.Drawing.Color.Red;
            }
            if (cboAnioGeneraciPasado.SelectedIndex == -1)
            {
                dato = dato + "Año de Generación";
                //lblAnioGeneracion.ForeColor = System.Drawing.Color.Red;
            }
            return dato;
        }
        private void btnGenerarAlcabalaPasado_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                String dato = verificarDatoAlcabalaPasada("");
                String msj = "Desea Grabar?";
                if (dato.Trim().Length != 0)
                {
                    MessageBox.Show("Falta llenar " + dato, Globales.Global_MessageBox);
                    return;
                }
                Pred_Certificado_Alcabala Certificado_Alcabala = new Pred_Certificado_Alcabala();
                if (porcentajeCondominioMaximo != 100)
                {
                    if (ckbTodoPasada.Checked)
                    {
                        msj = "Vendera toda la propiedad, Desea Grabar?";
                        Certificado_Alcabala.condomino = 100;
                    }
                    else
                    {
                        if (porcentajeCondominioMaximo < Convert.ToDecimal(txtCondominoPasada.Text))
                        {
                            MessageBox.Show("Excede del porcentaje que puede vender", Globales.Global_MessageBox);
                            return;
                        }
                        Certificado_Alcabala.condomino = Convert.ToDecimal(txtCondominoPasada.Text);
                    }
                }
                else
                {
                    if (100 < Convert.ToDecimal(txtCondominoPasada.Text))
                    {
                        MessageBox.Show("Excede del 100%", Globales.Global_MessageBox);
                        return;
                    }
                    Certificado_Alcabala.condomino = Convert.ToDecimal(txtCondominoPasada.Text);
                }

                DateTime fechaAlcabala = dtpFechaAlcabalaAl.Value;
                int mes = fechaAlcabala.Month;
                dato = Certificado_AlcabalaDataService.ErrorExistencia(predio_id_global, Convert.ToString(cboContribuPasado.SelectedValue),
                    Convert.ToInt32(cboAnioGeneraciPasado.SelectedValue), mes);
                if (dato.Trim().Length != 0)
                {
                    MessageBox.Show(dato.TrimEnd(), Globales.Global_MessageBox);
                    return;
                }
                if (MessageBox.Show(msj, Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    Certificado_Alcabala.persona_id = persona_id_global;
                    Certificado_Alcabala.comprador = Convert.ToString(cboContribuPasado.SelectedValue);
                    Certificado_Alcabala.predio_id = predio_id_global;
                    Certificado_Alcabala.tipo_alcabala = "2";//preguntar
                    Certificado_Alcabala.tipo_adquisicion = Convert.ToString(cboTipoAdquisicionPasado.SelectedValue);
                    Certificado_Alcabala.fecha_alcabala = dtpAlcablaPasada.Value;
                    Certificado_Alcabala.tipo_posesion = Convert.ToString(cboTipoPosesionPasado.SelectedValue);
                    Certificado_Alcabala.valor_venta = Convert.ToDecimal(txtMinutaPasada.Text);
                    Certificado_Alcabala.valuo = Convert.ToDecimal(lblValuo.Text);
                    Certificado_Alcabala.base_imponible = Certificado_Alcabala.valor_venta;
                    Certificado_Alcabala.registro_user_add = usser;
                    Certificado_Alcabala.estado = true;
                    Certificado_Alcabala.area = area_terreno;
                    Certificado_Alcabala.anioGeneracion = Convert.ToInt32(cboAnioGeneraciPasado.SelectedValue);
                    Certificado_Alcabala.valorTerreno = Convert.ToDecimal(lblValorTerreno.Text);
                    Certificado_Alcabala.usopredio = Convert.ToInt32(cboUsoPredioPAsado.SelectedValue);
                    Certificado_Alcabala.tipo_inmueble = Convert.ToInt32(cboTipoTerrenoPasado.SelectedValue);
                    alcabala_id_certificado = Certificado_AlcabalaDataService.InsertAlcabalaPasado(Certificado_Alcabala);
                    if (alcabala_id_certificado == 0)
                        MessageBox.Show("Ya existe alcabala", Globales.Global_MessageBox);
                    else
                    {
                        MessageBox.Show("Se Grabó Correctamente", Globales.Global_MessageBox);
                        btnGenerarAlcabalaPasado.Enabled = false;
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

        private void rbtAlcabalaPasado_CheckedChanged(object sender, EventArgs e)
        {

            mostrarTab(4);
        }

        private void cboTipoTerrenoPasado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (String.Compare(cboTipoTerrenoPasado.SelectedValue.ToString(), "1") == 0)//URBANO
                {

                    llenarCboMultitabla(cboUsoPredioPAsado, "Multc_vDescripcion", "Multc_cValor", "8");

                }
                else
                {
                    llenarCboMultitabla(cboUsoPredioPAsado, "Multc_vDescripcion", "Multc_cValor", "30");//verificar si es asi

                }
            }
            catch (Exception ex) { }
        }

        private void btnBuscarAlcabalaPasada_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNamePasado.Text.TrimEnd().Length != 0)
                {

                    cboContribuPasado.Enabled = true;
                    cboContribuPasado.DisplayMember = "persona_Desc";
                    cboContribuPasado.ValueMember = "persona_ID";
                    cboContribuPasado.DataSource = persona.listarcontribuyentes(txtNamePasado.Text.TrimEnd());
                    this.cboContribuPasado.AutoCompleteMode = AutoCompleteMode.Suggest;
                    this.cboContribuPasado.AutoCompleteSource = AutoCompleteSource.CustomSource;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Frm_Visor_Global frm_Visor_Global = new Frm_Visor_Global();
            try
            {
                decimal montoCalculado = 0;
                if (alcabala_id_certificado > 0)
                {
                    Pred_Certificado_Alcabala Certificado_Alcabala = new Pred_Certificado_Alcabala();
                    Certificado_Alcabala = Certificado_AlcabalaDataService.GetByPrimaryKey(alcabala_id_certificado);
                    if (Certificado_Alcabala.caso == 1)//no paga paga nada
                    {
                        montoCalculado = 0;
                    }
                    else if (Certificado_Alcabala.caso == 2)//primera venta
                    {
                        montoCalculado = Certificado_Alcabala.valorTerreno;
                    }
                    else if (Certificado_Alcabala.caso == 3)
                    {
                        if (Certificado_Alcabala.valor_venta > Certificado_Alcabala.valuo)
                            montoCalculado = Certificado_Alcabala.valor_venta;
                        else
                            montoCalculado = Certificado_Alcabala.valuo;
                    }

                    frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                    frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._5_Reportes_Gestion.Rep_Alcabala.Reporte_Alcabala.rdlc";
                    ReportParameter[] paramsx = new ReportParameter[15];
                    paramsx[0] = new ReportParameter("NombreEmpresa", "Municipalidad Distrital de Moche");
                    paramsx[1] = new ReportParameter("UsuarioPrueba", "Usuario 01");
                    paramsx[2] = new ReportParameter("Periodo", Certificado_Alcabala.anio.ToString());
                    paramsx[3] = new ReportParameter("CodigoContribuyente", Certificado_Alcabala.comprador.ToString());
                    paramsx[4] = new ReportParameter("NombreContribuyente", Certificado_Alcabala.comprador_name.ToString());
                    paramsx[5] = new ReportParameter("CodigoPredio", Certificado_Alcabala.predio_id.ToString());
                    paramsx[6] = new ReportParameter("Direccion", predio_direccion_global);
                    paramsx[7] = new ReportParameter("Valuo", Certificado_Alcabala.valuo.ToString());
                    paramsx[8] = new ReportParameter("PrecioVenta", Certificado_Alcabala.valor_venta.ToString());
                    paramsx[9] = new ReportParameter("MontoCalculado", montoCalculado.ToString());
                    paramsx[10] = new ReportParameter("UIT", Certificado_Alcabala.uits.ToString());
                    paramsx[11] = new ReportParameter("TasaArancelaria", Certificado_Alcabala.tasaAlcabala.ToString());
                    paramsx[12] = new ReportParameter("BaseAfectada", Certificado_Alcabala.valor_afecto.ToString());
                    paramsx[13] = new ReportParameter("ResultadoArancelario", Certificado_Alcabala.alcabala.ToString());
                    paramsx[14] = new ReportParameter("ValorTerreno", Certificado_Alcabala.valorTerreno.ToString());

                    frm_Visor_Global.reportViewer1.LocalReport.SetParameters(paramsx);
                    frm_Visor_Global.reportViewer1.RefreshReport();
                    frm_Visor_Global.StartPosition = FormStartPosition.CenterScreen;
                    frm_Visor_Global.ShowDialog();
                }
                else
                    MessageBox.Show("No hay alcabala generada", Globales.Global_MessageBox);
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

        private void tbpAlcabala_Click(object sender, EventArgs e)
        {

        }
    }
}

