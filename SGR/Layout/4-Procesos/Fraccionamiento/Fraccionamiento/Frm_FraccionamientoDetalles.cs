using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGR.Core.Repository;
using SGR.Core.Service;
using SGR.Core.Service.Combos;
using SGR.Entity;
using SGR.Entity.Model;
using SGR.Entity.Model.Combos;
using SGR.WinApp.Layout._5_Reportes_Gestion;
using Microsoft.VisualBasic;
using Microsoft.Reporting.WinForms;
using System.IO;

namespace SGR.WinApp.Layout._4_Procesos.Fraccionamiento.Fraccionamiento
{
    public partial class Frm_FraccionamientoDetalles : Form
    {
        private Mant_PeriodoDataService periodos = new Mant_PeriodoDataService();
        private Trib_TipoFraccionamientoDataService trib_TipoFraccionamiento = new Trib_TipoFraccionamientoDataService();
        Frac_FraccionamientoDataService fracc = new Frac_FraccionamientoDataService();
        string nombres, documento, persona, direccCompleta, persona_cod;
        string anio;
        int mayor;
        private List<Mant_Periodo> periodo = new List<Mant_Periodo>();
        private MesDataService mess = new MesDataService();
        private List<Mes> mesese = new List<Mes>();
        private Sistema.Globales.Validaciones obValidacion = new Sistema.Globales.Validaciones();
        private int nroCuotas=0;
        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                Frac_FraccionamientoDetalle elem = new Frac_FraccionamientoDetalle();                
                if (dataGridView1.Columns[e.ColumnIndex].Name == "xvisualizar")
                {
                    int fraccionamiento_ID = (Int32)dataGridView1.Rows[e.RowIndex].Cells["xfraccionamiento_id"].Value;
                    elem = fracc.listarParam(fraccionamiento_ID);
                    string baseLegal= (string)dataGridView1.Rows[e.RowIndex].Cells["xbase_legal"].Value;
                    Frac_FraccionamientoDetalle elemento = new Frac_FraccionamientoDetalle();
                    Frm_Visor_Global frmvisor = new Frm_Visor_Global();
                    elemento = fracc.obtenerFraccionamiento(fraccionamiento_ID);
                    List<Frac_Cronograma> coleccion = new List<Frac_Cronograma>();
                    coleccion = fracc.listarCronograma(fraccionamiento_ID);
                    frmvisor.reportViewer1.LocalReport.DataSources.Clear();
                    frmvisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._4_Procesos.Fraccionamiento.Fraccionamiento.rptFraccionamiento.rdlc";
                    frmvisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", coleccion));


                    List<Frac_CuentaFraccionada> origen2 = new List<Frac_CuentaFraccionada>();
                    Frac_CuentaFraccionada elementoo = new Frac_CuentaFraccionada();
                    string _path = Path.Combine(Application.StartupPath, @"LogoCabecera.jpg");
                    elementoo.logoEmpresa= File.ReadAllBytes(_path);
                    elementoo.convenio = "convenio";
                    origen2.Add(elementoo);
                    ReportDataSource dataSourceEmpresa = new ReportDataSource("DataSet2", origen2);
                    frmvisor.reportViewer1.LocalReport.DataSources.Add(dataSourceEmpresa);


                    ReportParameter[] param = new ReportParameter[17];
                    param[0] = new ReportParameter("Empresa", Globales.NombreEmpresa);
                    //param[1] = new ReportParameter("Usuario", Globales.UsuarioPrueba);
                    param[1] = new ReportParameter("Anio", Convert.ToString(elem.idPeriodo));
                    param[2] = new ReportParameter("NombreRazonSocial", nombres);
                    param[3] = new ReportParameter("DNI", documento);
                    param[4] = new ReportParameter("Domicilio", direccCompleta);
                    param[5] = new ReportParameter("DeudaTotal", elemento.Deuda_Total.ToString());
                    param[6] = new ReportParameter("PagoInicial", elemento.Inicial.ToString());
                    param[7] = new ReportParameter("SaldoFraccionable", elemento.Saldo.ToString());
                    param[8] = new ReportParameter("DerechoFraccionamiento", Convert.ToString(elem.Deuda_Total));
                    param[9] = new ReportParameter("ImporteCuotaMensual", elemento.ValorCuota.ToString());
                    param[10] = new ReportParameter("TasaInteresMensual", elemento.Interes.ToString());
                    param[11] = new ReportParameter("InteresCompensantorio", Convert.ToString(elem.Interes));
                    param[12] = new ReportParameter("NroCuotas", elemento.Cuotas.ToString());
                    param[13] = new ReportParameter("FechaSuscripcion", elemento.Fecha_Acogida.ToString());
                    param[14] = new ReportParameter("PeriodoFraccionado", elemento.anio_inicio.ToString() + "-" + elemento.anio_fin.ToString());
                    param[15] = new ReportParameter("BaseLegal", baseLegal);
                    param[16] = new ReportParameter("numero", Convert.ToString(elem.fraccionamiento_id));


                    //ReportParameter paramImagen = new ReportParameter();
                    //paramImagen.Name = "rutaImagen";
                    //paramImagen.Values.Add(@"file:///C:\Users\Juan\AppData\Local\Temp\ImagenElegida.png");
                    //frmvisor.reportViewer1.LocalReport.SetParameters(paramImagen);


                    frmvisor.reportViewer1.LocalReport.SetParameters(param);
                    frmvisor.reportViewer1.RefreshReport();
                    frmvisor.StartPosition = FormStartPosition.CenterScreen;
                    frmvisor.ShowDialog();
                }
                else
                {
                    if (dataGridView1.Columns[e.ColumnIndex].Name == "xmostrar2")
                    {
                        int fraccionamiento_ID = (Int32)dataGridView1.Rows[e.RowIndex].Cells["xfraccionamiento_id"].Value;
                        elem = fracc.listarParam(fraccionamiento_ID);
                        Frac_FraccionamientoDetalle elemento = new Frac_FraccionamientoDetalle();
                        Frm_Visor_Global frmvisor = new Frm_Visor_Global();
                        elemento = fracc.obtenerFraccionamiento(fraccionamiento_ID);
                        
                        List<Frac_CronogramaDetalle> coleccion = new List<Frac_CronogramaDetalle>();
                        coleccion = fracc.listarFraccTributos(fraccionamiento_ID);
                        frmvisor.reportViewer1.LocalReport.DataSources.Clear();
                        frmvisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._4_Procesos.Fraccionamiento.Fraccionamiento.rptFraccionamientoOtro.rdlc";
                        frmvisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", coleccion));


                        List<Frac_CuentaFraccionada> origen2 = new List<Frac_CuentaFraccionada>();
                        Frac_CuentaFraccionada elementoo = new Frac_CuentaFraccionada();
                        string _path = Path.Combine(Application.StartupPath, @"LogoCabecera.jpg");
                        elementoo.logoEmpresa = File.ReadAllBytes(_path);
                        elementoo.convenio = "convenio";
                        origen2.Add(elementoo);
                        ReportDataSource dataSourceEmpresa = new ReportDataSource("DataSet2", origen2);
                        frmvisor.reportViewer1.LocalReport.DataSources.Add(dataSourceEmpresa);


                        ReportParameter[] param = new ReportParameter[12];
                        param[0] = new ReportParameter("Empresa", Globales.NombreEmpresa);
                        param[1] = new ReportParameter("Anio", Convert.ToString(elem.idPeriodo));
                        param[2] = new ReportParameter("NombreRazonSocial", nombres);
                        param[3] = new ReportParameter("DNI", documento);
                        param[4] = new ReportParameter("Domicilio", direccCompleta);
                        param[5] = new ReportParameter("TotalDeuda", elemento.Deuda_Total.ToString());
                        param[6] = new ReportParameter("Descuento", elemento.Descuento.ToString());
                        param[7] = new ReportParameter("SaldoFraccionable", elemento.Saldo.ToString());
                        param[8] = new ReportParameter("inicial", Convert.ToString(elem.Descuento));
                        param[9] = new ReportParameter("derecho", Convert.ToString(elem.Deuda_Total));
                        param[10] = new ReportParameter("cuotas", Convert.ToString(elem.Numero));
                        param[11] = new ReportParameter("numero", Convert.ToString(elem.fraccionamiento_id));
                        frmvisor.reportViewer1.LocalReport.SetParameters(param);
                        frmvisor.reportViewer1.RefreshReport();
                        frmvisor.StartPosition = FormStartPosition.CenterScreen;
                        frmvisor.ShowDialog();
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
        private void cboAnioIni_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cantidad;
            cantidad = periodo.Count;
            List<Mant_Periodo> periodo2 = new List<Mant_Periodo>();

            for (int i = 0; i < cantidad; i++)
            {
                if (Convert.ToInt32(periodo[i].Peric_canio) >= Convert.ToInt32(cboAnioIni.SelectedValue))
                {
                    Mant_Periodo peri = new Mant_Periodo();
                    peri.Peric_canio = periodo[i].Peric_canio;
                    periodo2.Add(peri);
                }
            }
            cboAnioFin.DisplayMember = "Peric_canio";
            cboAnioFin.ValueMember = "Peric_canio";
            cboAnioFin.DataSource = periodo2;
        }
        private void cboMesIni_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cantidad;
            cantidad = mesese.Count;
            List<Mes> mes2 = new List<Mes>();
            if (Convert.ToInt32(cboAnioIni.SelectedValue) == Convert.ToInt32(cboAnioFin.SelectedValue))
            {
                for (int i = 0; i < cantidad; i++)
                {
                    if (Convert.ToInt32(mesese[i].mes_ID) >= Convert.ToInt32(cboMesIni.SelectedValue))
                    {
                        Mes messssss = new Mes();
                        messssss.mes_ID = mesese[i].mes_ID;
                        messssss.mes = mesese[i].mes;
                        mes2.Add(messssss);
                    }
                }
            }
            else
            {
                for (int i = 0; i < cantidad; i++)
                {
                    Mes messssss = new Mes();
                    messssss.mes_ID = mesese[i].mes_ID;
                    messssss.mes = mesese[i].mes;
                    mes2.Add(messssss);
                }
            }
            cboMesFin.DisplayMember = "mes";
            cboMesFin.ValueMember = "mes_ID";
            cboMesFin.DataSource = mes2;
        }
        private void cboAnioFin_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cantidad;
            cantidad = mesese.Count;
            List<Mes> mes2 = new List<Mes>();
            if (Convert.ToInt32(cboAnioIni.SelectedValue) == Convert.ToInt32(cboAnioFin.SelectedValue))
            {
                for (int i = 0; i < cantidad; i++)
                {
                    if (Convert.ToInt32(mesese[i].mes_ID) >= Convert.ToInt32(cboMesIni.SelectedValue))
                    {
                        Mes messssss = new Mes();
                        messssss.mes_ID = mesese[i].mes_ID;
                        messssss.mes = mesese[i].mes;
                        mes2.Add(messssss);
                    }
                }
            }
            else
            {
                for (int i = 0; i < cantidad; i++)
                {
                    Mes messssss = new Mes();
                    messssss.mes_ID = mesese[i].mes_ID;
                    messssss.mes = mesese[i].mes;
                    mes2.Add(messssss);
                }
            }
            cboMesFin.DisplayMember = "mes";
            cboMesFin.ValueMember = "mes_ID";
            cboMesFin.DataSource = mes2;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try {
                decimal monto = 0;
                int cont = 0;
                int cantidad = dgvTributos.RowCount;
                for (int i = 0; i < cantidad; i++)
                {
                    DataGridViewRow row1 = dgvTributos.Rows[i];
                    DataGridViewCheckBoxCell cellSelecion1 = row1.Cells["Op"] as DataGridViewCheckBoxCell;
                    bool disponible = false;
                    disponible = Convert.ToBoolean(cellSelecion1.Value);
                    if (disponible)
                    {
                        string trib = (String)dgvTributos.Rows[i].Cells["xtributo_ID"].Value;
                        monto = monto + fracc.montoTributo(persona_cod, (Int32)cboAnioIni.SelectedValue, (Int32)cboAnioFin.SelectedValue,
                        Convert.ToInt32((string)cboMesIni.SelectedValue), Convert.ToInt32((string)cboMesFin.SelectedValue), trib);
                        cont++;
                    } 

                }
                if (cont == 0)
                {
                    throw new Exception("Seleccione un tributo a seleccionar.");
                }
                txtDeudaTot.Text = Convert.ToString(monto);
                txtDeudaFracc.Text = Convert.ToString(monto-Convert.ToDecimal(txtPagoIni.Text));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }
   
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            try {
                decimal cuota = Math.Round(Convert.ToDecimal(Financial.Pmt(Convert.ToDouble(txtIntComp.Text) / 100, Convert.ToInt32(txtNroCuota.Text),
                    -Convert.ToDouble(txtDeudaFracc.Text), 0, DueDate.EndOfPeriod)),2);
                if (cuota < Convert.ToDecimal(txtCuotaMin.Text))
                    lblMensaje.Text = "El número de cuotas debe ser menor";
                else
                {
                    if (nroCuotas >= Convert.ToInt32(txtNroCuota.Text))
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        lblMensaje.Text = "";
                        decimal montoFraccionar = Convert.ToDecimal(txtDeudaFracc.Text);
                        int numeroCuotas = Convert.ToInt32(txtNroCuota.Text);
                        decimal interesComp = Convert.ToDecimal(txtIntComp.Text);
                        string cadena = "Cuota: " + Convert.ToString(cuota) + "\n";
                        Frac_FraccionamientoDetalle elemento = new Frac_FraccionamientoDetalle();
                        elemento.anio_fin = (Int32)cboAnioFin.SelectedValue;
                        elemento.anio_inicio = (Int32)cboAnioIni.SelectedValue;
                        elemento.Cuotas = Convert.ToInt32(txtNroCuota.Text);
                        elemento.Descuento = Convert.ToDecimal(txtDesc.Text);
                        elemento.Deuda_Total = Convert.ToDecimal(txtDeudaTot.Text);
                        elemento.Estado = "P";
                        //elemento.
                        elemento.idPeriodoInicio = Convert.ToInt32((string)cboMesIni.SelectedValue);
                        elemento.idPeriodoFin = Convert.ToInt32((string)cboMesFin.SelectedValue);
                        elemento.Inicial = Convert.ToDecimal(txtPagoIni.Text);
                        elemento.Interes = Math.Round(Convert.ToDecimal(txtNroCuota.Text) * cuota - montoFraccionar, 2);
                        elemento.Numero = 1;
                        elemento.Persona_id = persona_cod;
                        elemento.Saldo = montoFraccionar;
                        elemento.tipo_fraccionamiento_ID = (Int32)cboTipoFraccionamiento.SelectedValue;
                        //elemento.tipo_fraccionamiento_ID = (Int32)cboTipoFraccionamiento.SelectedValue;
                        elemento.ValorCuota = cuota;
                        //int resultado=fracc.Insert(elemento);                    
                        List<Frac_Cronograma> arreglo1 = new List<Frac_Cronograma>();
                        List<Frac_Cronograma> arreglo1_1 = new List<Frac_Cronograma>();
                        DateTime localDate = DateTime.Now;
                        Frac_Cronograma crono = new Frac_Cronograma();
                        crono.FechaVence = localDate;
                        crono.saldo = montoFraccionar;
                        crono.cuota = Convert.ToDecimal(txtPagoIni.Text); ;
                        crono.ajuste = cuota - Math.Round(cuota, 1);
                        crono.amortizacion = Convert.ToDecimal(txtPagoIni.Text); ;
                        //crono.Fraccionamiento_id = resultado;                        
                        crono.interes = 0;
                        crono.NroCuota = 0;
                        crono.importe = Convert.ToDecimal(txtPagoIni.Text);
                        arreglo1.Add(crono);
                        for (int i = 0; i < numeroCuotas; i++)
                        {
                            crono = new Frac_Cronograma();
                            localDate = localDate.AddDays(i * 30);
                            crono.FechaVence = localDate;
                            crono.saldo = montoFraccionar;
                            crono.cuota = cuota;
                            crono.ajuste = cuota - Math.Round(cuota, 1);
                            crono.amortizacion = cuota - Math.Round(montoFraccionar * interesComp / 100, 2);
                            //crono.Fraccionamiento_id = resultado;                        
                            crono.interes = Math.Round(montoFraccionar * interesComp / 100, 2);
                            crono.NroCuota = i + 1;
                            montoFraccionar = montoFraccionar - (cuota - Math.Round(montoFraccionar * interesComp / 100, 2));
                            crono.importe = Math.Round(cuota, 1);
                            if (i == numeroCuotas - 1 && montoFraccionar != 0)
                            {
                                cuota = Math.Round(cuota + montoFraccionar, 2);
                                crono.importe = cuota;
                                montoFraccionar = 0;
                            }
                            arreglo1.Add(crono);
                            arreglo1_1.Add(crono);

                            //fracc.InsertDetalle(crono);
                        }
                        int cantidad = dgvTributos.RowCount;
                        List<Frac_FraccionamientoParametros> arreglo2 = new List<Frac_FraccionamientoParametros>();
                        for (int i = 0; i < cantidad; i++)
                        {
                            DataGridViewRow row1 = dgvTributos.Rows[i];
                            DataGridViewCheckBoxCell cellSelecion1 = row1.Cells["Op"] as DataGridViewCheckBoxCell;
                            bool disponible = false;
                            disponible = Convert.ToBoolean(cellSelecion1.Value);
                            if (disponible)
                            {
                                string trib = (String)dgvTributos.Rows[i].Cells["xtributo_ID"].Value;
                                Frac_FraccionamientoParametros elemento2 = new Frac_FraccionamientoParametros();
                                elemento2.anio_ini = (Int32)cboAnioIni.SelectedValue;
                                elemento2.persona_ID = persona_cod;
                                elemento2.anio_fin = (Int32)cboAnioFin.SelectedValue;
                                elemento2.mes_ini = Convert.ToInt32((string)cboMesIni.SelectedValue);
                                elemento2.mes_fin = Convert.ToInt32((string)cboMesFin.SelectedValue);
                                elemento2.tributo_ID = trib;
                                arreglo2.Add(elemento2);
                            }

                        }
                        Frm_FraccionamientoDetalleCronograma Frm_Trib = new Frm_FraccionamientoDetalleCronograma(nombres,
                            documento, persona, elemento, arreglo1, arreglo2,arreglo1_1);
                        Frm_Trib.StartPosition = FormStartPosition.CenterParent;
                        Frm_Trib.ShowDialog();
                        //MessageBox.Show("Fraccionamiento Correctamente Generado");
                    }
                    else
                    {
                        MessageBox.Show("El número de cuotas no debe exceder al máximo número de cuotas", Globales.Global_MessageBox);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,Globales.Global_MessageBox);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
                dataGridView1.DataSource = fracc.listarFraccionamientos(persona_cod);
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void cboTipoFraccionamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarTipoFracc();
        }

        private void txtNroCuota_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            obValidacion.validaNumeroEntero(e, Globales.Global_MessageBox);
        }

        private void dgvPredio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        Trib_TipoFraccionamiento elemento = new Trib_TipoFraccionamiento();
        public Frm_FraccionamientoDetalles(string nombres, string documento, string persona, string direccCompleta, string anio, Int32 mayor)
        {
            InitializeComponent();
            this.nombres = nombres;
            this.documento = documento;
            this.persona = persona;
            this.direccCompleta = direccCompleta;
            this.anio = anio;
            this.mayor = mayor;
            inicializar(nombres, documento, persona, direccCompleta, anio, mayor);            
        }
        public void inicializar(string nombres, string documento, string persona, string direccCompleta, string anio, Int32 mayor)
        {
            periodo = periodos.GetAllMant_Periodo();
            mesese = mess.listartodos();
            cboMesIni.DisplayMember = "mes";
            cboMesIni.ValueMember = "mes_ID";
            cboMesIni.DataSource = mesese;
            cboMesFin.DisplayMember = "mes";
            cboMesFin.ValueMember = "mes_ID";
            cboMesFin.DataSource = mesese;
            persona_cod = persona;
            lblCodigo.Text = persona;
            lblDireccion.Text = direccCompleta;
            lblDocumento.Text = documento;
            lblNombre.Text = nombres.TrimEnd();
            cboTipoFraccionamiento.DisplayMember = "TiFr_base_legal";
            cboTipoFraccionamiento.ValueMember = "TiFr_tipo_fraccionamiento_ID";
            cboTipoFraccionamiento.DataSource = fracc.listarFraccionamiento();
            dataGridView1.DataSource = fracc.listarFraccionamientos(persona_cod);
            cargarTipoFracc();
            
            //
        }

        public void cargarTipoFracc()
        {
            try {
                periodo = periodos.GetAllMant_Periodo();
                dgvTributos.DataSource = trib_TipoFraccionamiento.listarTributosFraccionamiento((Int32)cboTipoFraccionamiento.SelectedValue);
                int cantidadT = dgvTributos.RowCount;
                for (int i = 0; i < cantidadT; i++)
                {
                    DataGridViewRow row1 = dgvTributos.Rows[i];
                    DataGridViewCheckBoxCell cellSelecion1 = row1.Cells["Op"] as DataGridViewCheckBoxCell;
                    //cellSelecion1.Value = true;
                }

                elemento = trib_TipoFraccionamiento.GetByPrimaryKey((Int32)cboTipoFraccionamiento.SelectedValue);
                lblModalidad.Text = elemento.TiFr_modalidadDesc;
                lblAnioIni.Text = "Año Inicial: (" + Convert.ToString(elemento.TiFr_anio_inicio) + ")";
                lblAnioFin.Text = "Año Final: (" + Convert.ToString(elemento.TiFr_anio_fin) + ")";
                txtDeudaTot.Text = "0";
                txtDeudaFracc.Text = "0";
                txtNroCuota.Text = Convert.ToString(elemento.TiFr_max_cuotas);
                nroCuotas = elemento.TiFr_max_cuotas;
                lblNroCuotas.Text = "Nro Cuotas: ("+Convert.ToString(elemento.TiFr_max_cuotas)+")";
                txtCuotaMin.Text = Convert.ToString(elemento.TiFr_cuota_minima);
                txtDesc.Text = Convert.ToString(elemento.TiFr_descuento);
                txtIntComp.Text = Convert.ToString(elemento.TiFr_interes_compensa);
                if (elemento.TiFr_interes_moratorio)
                    txtIntMora.Text = "Si";
                else
                    txtIntMora.Text = "No";
                txtPagoDerecho.Text = Convert.ToString(elemento.TiFr_monto_derecho);
                txtPagoIni.Text = Convert.ToString(elemento.TiFr_cuota_inicial);
                txtNroCuota.Text = "0";                
                int cantidad;
                cantidad = periodo.Count;
                List<Mant_Periodo> periodo2 = new List<Mant_Periodo>();
                for (int i = 0; i < cantidad; i++)
                {
                    if (Convert.ToInt32(periodo[i].Peric_canio) >= elemento.TiFr_anio_inicio
                        && Convert.ToInt32(periodo[i].Peric_canio) <= elemento.TiFr_anio_fin)
                    {
                        Mant_Periodo peri = new Mant_Periodo();
                        peri.Peric_canio = periodo[i].Peric_canio;
                        periodo2.Add(peri);
                    }
                }
                periodo = periodo2;
                cboAnioIni.DisplayMember = "Peric_canio";
                cboAnioIni.ValueMember = "Peric_canio";
                //cboAnioIni.SelectedIndex = 2016;
                cboAnioIni.DataSource = periodo;
                cboAnioIni.SelectedValue = Convert.ToInt32(anio);

                periodo2 = new List<Mant_Periodo>();
                cantidad = periodo.Count;
                for (int i = 0; i < cantidad; i++)
                {
                    if (Convert.ToInt32(periodo[i].Peric_canio) >= Convert.ToInt32(cboAnioIni.SelectedValue))
                    {
                        Mant_Periodo peri = new Mant_Periodo();
                        peri.Peric_canio = periodo[i].Peric_canio;
                        periodo2.Add(peri);
                    }
                }
                cboAnioFin.DisplayMember = "Peric_canio";
                cboAnioFin.ValueMember = "Peric_canio";
                cboAnioFin.DataSource = periodo2;
                cboAnioFin.SelectedValue = Convert.ToInt32(mayor);
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se puede registrar fraccionamiento", Globales.Global_MessageBox);
            }
        }
    }
}

