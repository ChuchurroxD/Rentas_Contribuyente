using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SGR.Core.Service;
using SGR.Entity;
using WeifenLuo.WinFormsUI.Docking;
using Microsoft.Reporting.WinForms;
using SGR.Entity.Model;
using System.IO;
using SGR.Entity;
namespace SGR.WinApp.Layout._5_Reportes_Gestion.Rep_HRPUPR
{
    public partial class Frm_PUPR : DockContent
    {
        private Pred_PredioDataService predioDataService = new Pred_PredioDataService();
        Mant_PeriodoDataService mant_PeriodoDataService = new Mant_PeriodoDataService();
        private Pred_CalculoPorPersonaAniosDataService CalculoPorPersonaAniosDataService = new Pred_CalculoPorPersonaAniosDataService();
        private List<Mant_Periodo> periodos = new List<Mant_Periodo>();
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
        Pred_FiscalizacionCtaCteDataService FiscalizacionCtaCteDataService = new Pred_FiscalizacionCtaCteDataService();
        private int periodo;
        private List<For_Masivo> ColeccionNumero;
        private List<For_Masivo> ColeccionNumeroPU;
        private List<For_Masivo> ColeccionNumeroPR;
        private Pred_Certificado_AlcabalaDataService Certificado_AlcabalaDataService = new Pred_Certificado_AlcabalaDataService();
        private Proc_CuentaCorritenteDataService Proc_CuentaCorritenteDataService = new Proc_CuentaCorritenteDataService();
        //private string registro_user = "nada";
        //private List<Pred_UsoGeneral> coleccionGeneralPredial;
        //private List<Pred_UsoGeneral> coleccionGeneral;
        //private List<Pred_UsoGeneral> coleccionGeneralArb;
        //private List<Proc_CuentaCorritente> coleccionCta1;
        //private List<Proc_CuentaCorritente> coleccionCta2;
        private Pred_DuplicadoFormularioDataService DuplicadoFormularioDataService = new Pred_DuplicadoFormularioDataService();
        private List<Repo_HojaResumen> ColeccionPC;
        private List<Repo_HojaResumen> ColeccionMP;
        Repo_HojaResumenService repo_HojaResumenService = new Repo_HojaResumenService();
        private List<Mant_Contribuyente> ColeccionMPC;
        private For_Masivo_DataService For_Masivo_DataService = new For_Masivo_DataService();

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
        public Frm_PUPR()
        {
            InitializeComponent();
            periodos = PeriodoDataService.GetAllMant_Periodo();
            comboBusquedaPeriodoInicial.DisplayMember = "Peric_canio";
            comboBusquedaPeriodoInicial.ValueMember = "Peric_canio";
            comboBusquedaPeriodoInicial.DataSource = periodos;
            comoBusquedaPeriodoFinal.DisplayMember = "Peric_canio";
            comoBusquedaPeriodoFinal.ValueMember = "Peric_canio";
            comoBusquedaPeriodoFinal.DataSource = periodos;
        }

        private void btnGenerarCalculoMasivo_Click(object sender, EventArgs e)
        {

        }

        private void rbtNDoc_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtNDoc.Checked)
            {
                string texto = txtNDocu.Text;
                if (texto.Length != 0)
                    listarBuscado(texto, "", "");
            }
        }

        private void rbtCodContribuyente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtCodContribuyente.Checked)
            {
                string texto = txtCodContribuyente.Text;
                if (texto.Length != 0)
                    listarBuscado("", texto, "");
            }
        }

        private void rbtNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtCodContribuyente.Checked)
            {
                string texto = txtCodContribuyente.Text;
                if (texto.Length != 0)
                    listarBuscado("", "", texto);
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (dgvContribuyenteBuscados.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Selecciones un contribuyente", Globales.Global_MessageBox);
                    return;
                }
                if (dgvPredio.RowCount < 1)
                {
                    MessageBox.Show("La persona no tiene predios.", Globales.Global_MessageBox);
                    return;
                }
                String perso = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["persona_ID"].Value;
                string msj = DuplicadoFormularioDataService.Verificar(perso, comboBusquedaPeriodoInicial.SelectedValue.ToString(), comoBusquedaPeriodoFinal.SelectedValue.ToString());
                if (msj.Trim().Length != 2)
                {
                    MessageBox.Show(msj, Globales.Global_MessageBox);
                }
                else
                {
                    imprimirPredios(Convert.ToInt32(comboBusquedaPeriodoInicial.SelectedValue), Convert.ToInt32(comoBusquedaPeriodoFinal.SelectedValue), perso);
                    MessageBox.Show("Se imprimio todo.", Globales.Global_MessageBox);
                }
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

        private void cboAnioIni_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int cantidad;
                cantidad = periodos.Count;
                List<Mant_Periodo> periodo2 = new List<Mant_Periodo>();

                for (int i = 0; i < cantidad; i++)
                {
                    if (Convert.ToInt32(periodos[i].Peric_canio) >= Convert.ToInt32(comboBusquedaPeriodoInicial.SelectedValue))
                    {
                        Mant_Periodo peri = new Mant_Periodo();
                        peri.Peric_canio = periodos[i].Peric_canio;
                        periodo2.Add(peri);
                    }
                }
                comoBusquedaPeriodoFinal.DisplayMember = "Peric_canio";
                comoBusquedaPeriodoFinal.ValueMember = "Peric_canio";
                comoBusquedaPeriodoFinal.DataSource = periodo2;
                dgvPredio.DataSource = new List<Pred_Predio>();

            }
            catch (Exception ex)
            {
            }
        }

        private void cboAnioFin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listarBuscado(string doc, string cod, string name)
        {
            try
            {
                int tipo;
                if (rbtNDoc.Checked)
                    tipo = 27;
                else if (rbtCodContribuyente.Checked)
                    tipo = 28;
                else
                    tipo = 29;
                dgvContribuyenteBuscados.DataSource = mant_ContribuyenteDataService.listarSoloCOntribuyente(doc, cod, name, tipo);
                if (dgvContribuyenteBuscados.SelectedRows.Count > 0)
                {
                    String perso = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["persona_ID"].Value;
                    Coleccion = FiscalizacionDataService.listarpredios(perso, comboBusquedaPeriodoInicial.SelectedValue.ToString());
                    dgvPredio.DataSource = Coleccion;
                    ckbPredio.Checked = false;
                    ckbPredio.Checked = true;
                    //PintarColumnasCalculadas();
                }
                else
                    dgvPredio.DataSource = new List<Pred_Predio>();

            }
            catch (Exception ex)
            {

            }
        }

        private void imprimirPredios(int ini, int fin, string cod_contribuyente)
        {
            int cantidad, tipo_inmueble;
            Frm_Visor_Global frm_Visor_Global = new Frm_Visor_Global();
            string predio_ID;
            bool bandera;
            while (ini <= fin)
            {
                cantidad = dgvPredio.RowCount;
                if (ckbHR.Checked)
                {
                    MessageBox.Show("Se imprimirá HR de "+ini.ToString(),Globales.Global_MessageBox);
                    if (rbtConFormato.Checked)
                        imprimirHR(Convert.ToInt32(cod_contribuyente), ini);
                    else
                        imprimirHRSinFormato(Convert.ToInt32(cod_contribuyente), ini);
                }
                for (int i = 0; i < cantidad; i++)
                {
                    DataGridViewRow row = dgvPredio.Rows[i];
                    DataGridViewCheckBoxCell cellSelecion = row.Cells["Op"] as DataGridViewCheckBoxCell;
                    bandera = Convert.ToBoolean(cellSelecion.Value);
                    if (bandera)
                    {
                        predio_ID = (string)row.Cells["predio_ID"].Value;
                        tipo_inmueble = (int)row.Cells["tipo_inmueble"].Value;
                        if(tipo_inmueble==1)
                            MessageBox.Show("Se imprimirá PU de " + ini.ToString(), Globales.Global_MessageBox);
                        else
                            MessageBox.Show("Se imprimirá PR de " + ini.ToString(), Globales.Global_MessageBox);
                        if (rbtConFormato.Checked)
                            imprimirPUPR(Convert.ToInt32(cod_contribuyente), predio_ID, tipo_inmueble, ini);
                        else
                            imprimirPUPRSinFormato(Convert.ToInt32(cod_contribuyente), predio_ID, tipo_inmueble, ini);
                    }
                }

                //for (int i = 0; i < cantidad; i++)
                //{
                //    predio_ID = (string)dgvPredio.Rows[i].Cells["predio_ID"].Value;
                //    tipo_inmueble = (int)dgvPredio.Rows[i].Cells["tipo_inmueble"].Value;
                //    imprimirPUPR(Convert.ToInt32(cod_contribuyente), predio_ID, tipo_inmueble, frm_Visor_Global, ini);
                //}
                ini++;
            }
        }

        private void imprimirHR(int xpersona, int periodo)
        {
            DateTime fechaHoy = DateTime.Now;
            DateTime diaHoy = DateTime.Now;
            try
            {

                Frm_Visor_Global frm_Visor_Global = new Frm_Visor_Global();
                Mant_ContribuyenteDataService mant_ContribuyenteDataService1 = new Mant_ContribuyenteDataService();
                For_Masivo_DataService.Insert();
                ColeccionNumero = For_Masivo_DataService.Numeracion();
                ColeccionMPC = mant_ContribuyenteDataService1.listarIdContribuyente(xpersona);
                Coleccion = repo_HojaResumenService.listarPrediosxPerContribuyenteConFormato(xpersona.ToString(), periodo);
                ColeccionPC = repo_HojaResumenService.listarDeterminacionImpuesto(xpersona.ToString(), periodo);
                ColeccionMP = repo_HojaResumenService.listarMontosPagarConFormato(xpersona.ToString(), periodo);
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
                ReportParameter[] paramsx = new ReportParameter[8];
                paramsx[0] = new ReportParameter("NombreEmpresa", Globales.NombreEmpresa);
                paramsx[1] = new ReportParameter("UsuarioPrueba", GlobalesV1.Global_str_Usuario);
                paramsx[2] = new ReportParameter("Año", fechaHoy.Year.ToString());
                paramsx[3] = new ReportParameter("Dia", fechaHoy.Day.ToString());
                paramsx[4] = new ReportParameter("Mes", fechaHoy.Month.ToString());
                paramsx[5] = new ReportParameter("RucEmpresa", Globales.RucEmpresa);

                paramsx[6] = new ReportParameter("Anio", periodo.ToString());
                paramsx[7] = new ReportParameter("numero", ColeccionNumero[0].numero.ToString());
                frm_Visor_Global.reportViewer1.LocalReport.SetParameters(paramsx);
                frm_Visor_Global.reportViewer1.RefreshReport();
                frm_Visor_Global.StartPosition = FormStartPosition.CenterScreen;
                frm_Visor_Global.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void imprimirPUPR(int xpersona, string predio_ID, int tipo_inmueble, int idPeriodo)
        {
            DateTime fechaHoy = DateTime.Now;
            try
            {

                Frm_Visor_Global frm_Visor_Global = new Frm_Visor_Global();
                Pred_Predio predio = repo_PredioUrbanoDataService.DataPredial(predio_ID, idPeriodo);
                if (tipo_inmueble == 2)
                {
                    For_Masivo_DataService.InsertPR();
                    ColeccionNumeroPR = For_Masivo_DataService.NumeracionPR();
                    ColeccionCR = repo_PredioRusticoDataService.listarContribuyenteRustico(xpersona.ToString());
                    ColeccionPR = repo_PredioRusticoDataService.listarPredioRustico(predio_ID, idPeriodo);
                    ColeccionDIR = repo_PredioRusticoDataService.ListarImpuestoRusticoConFormato(predio_ID, idPeriodo);
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

                    ReportParameter[] paramsx = new ReportParameter[14];
                    paramsx[0] = new ReportParameter("NombreEmpresa", Globales.NombreEmpresa);
                    paramsx[1] = new ReportParameter("UsuarioPrueba", GlobalesV1.Global_str_Usuario);
                    paramsx[2] = new ReportParameter("Año", fechaHoy.Year.ToString());
                    paramsx[3] = new ReportParameter("Dia", fechaHoy.Day.ToString());
                    paramsx[4] = new ReportParameter("Mes", fechaHoy.Month.ToString());
                    paramsx[5] = new ReportParameter("RucEmpresa", Globales.RucEmpresa);

                    paramsx[6] = new ReportParameter("area_terreno", predio.area_terreno.ToString());
                    paramsx[7] = new ReportParameter("arancel", predio.arancel.ToString());
                    paramsx[8] = new ReportParameter("valor_otra_instalacion", predio.valor_otra_instalacion.ToString());
                    paramsx[9] = new ReportParameter("valor_terreno", predio.valor_terreno.ToString());
                    paramsx[10] = new ReportParameter("valor_construccion", predio.valor_construccion.ToString());
                    paramsx[11] = new ReportParameter("total_autovaluo", predio.total_autovaluo.ToString());
                    paramsx[12] = new ReportParameter("Anio", idPeriodo.ToString());
                    paramsx[13] = new ReportParameter("numero", ColeccionNumeroPR[0].numero.ToString());
                    frm_Visor_Global.reportViewer1.LocalReport.SetParameters(paramsx);
                    frm_Visor_Global.reportViewer1.RefreshReport();
                    frm_Visor_Global.StartPosition = FormStartPosition.CenterScreen;
                    frm_Visor_Global.ShowDialog();
                }
                else if (tipo_inmueble == 1)
                {
                    For_Masivo_DataService.InsertPU();
                    ColeccionNumeroPU = For_Masivo_DataService.NumeracionPU();
                    ColeccionDC = repo_PredioUrbanoDataService.ListarDatosContribuyente(xpersona.ToString());
                    ColeccionDP = repo_PredioUrbanoDataService.ListarDatosPredio(predio_ID, idPeriodo);
                    ColeccionUDI = repo_PredioUrbanoDataService.ListarImpuestoUrbanoConFormato(predio_ID, idPeriodo);
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

                    ReportParameter[] paramsx = new ReportParameter[14];
                    paramsx[0] = new ReportParameter("NombreEmpresa", Globales.NombreEmpresa);
                    paramsx[1] = new ReportParameter("UsuarioPrueba", GlobalesV1.Global_str_Usuario);
                    paramsx[2] = new ReportParameter("Año", fechaHoy.Year.ToString());
                    paramsx[3] = new ReportParameter("Dia", fechaHoy.Day.ToString());
                    paramsx[4] = new ReportParameter("Mes", fechaHoy.Month.ToString());
                    paramsx[5] = new ReportParameter("RucEmpresa", Globales.RucEmpresa);
                    paramsx[6] = new ReportParameter("area_terreno", predio.area_terreno.ToString());
                    paramsx[7] = new ReportParameter("arancel", predio.arancel.ToString());
                    paramsx[8] = new ReportParameter("valor_otra_instalacion", predio.valor_otra_instalacion.ToString());
                    paramsx[9] = new ReportParameter("valor_terreno", predio.valor_terreno.ToString());
                    paramsx[10] = new ReportParameter("valor_construccion", predio.valor_construccion.ToString());
                    paramsx[11] = new ReportParameter("total_autovaluo", predio.total_autovaluo.ToString());
                    paramsx[12] = new ReportParameter("Anio", idPeriodo.ToString());
                    paramsx[13] = new ReportParameter("numero", ColeccionNumeroPU[0].numero.ToString());
                    frm_Visor_Global.reportViewer1.LocalReport.SetParameters(paramsx);
                    frm_Visor_Global.reportViewer1.RefreshReport();
                    frm_Visor_Global.StartPosition = FormStartPosition.CenterScreen;
                    frm_Visor_Global.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void imprimirHRSinFormato(int xpersona, int periodo)
        {
            DateTime fechaHoy = DateTime.Now;
            DateTime diaHoy = DateTime.Now;
            try
            {

                Frm_Visor_Global frm_Visor_Global = new Frm_Visor_Global();
                Mant_ContribuyenteDataService mant_ContribuyenteDataService1 = new Mant_ContribuyenteDataService();
                ColeccionMPC = mant_ContribuyenteDataService1.listarIdContribuyente(xpersona);
                Coleccion = repo_HojaResumenService.listarPrediosxPerContribuyente(xpersona.ToString(), periodo);
                ColeccionPC = repo_HojaResumenService.listarDeterminacionImpuesto(xpersona.ToString(), periodo);
                ColeccionMP = repo_HojaResumenService.listarMontosPagar(xpersona.ToString(), periodo);
                frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                //chuchuro modificas aqui el normbre dded tu repote sin formato
                frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._1_Tablas_Maestras.Contribuyente.Reporte_Contribuyente_SinFormato.rdlc";
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
                ReportParameter[] paramsx = new ReportParameter[7];
                paramsx[0] = new ReportParameter("NombreEmpresa", Globales.NombreEmpresa);
                paramsx[1] = new ReportParameter("UsuarioPrueba", GlobalesV1.Global_str_Usuario);
                paramsx[2] = new ReportParameter("Año", fechaHoy.Year.ToString());
                paramsx[3] = new ReportParameter("Dia", fechaHoy.Day.ToString());
                paramsx[4] = new ReportParameter("Mes", fechaHoy.Month.ToString());
                paramsx[5] = new ReportParameter("RucEmpresa", Globales.RucEmpresa);

                paramsx[6] = new ReportParameter("Anio", periodo.ToString());
                frm_Visor_Global.reportViewer1.LocalReport.SetParameters(paramsx);
                frm_Visor_Global.reportViewer1.RefreshReport();
                frm_Visor_Global.StartPosition = FormStartPosition.CenterScreen;
                frm_Visor_Global.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }
        private void imprimirPUPRSinFormato(int xpersona, string predio_ID, int tipo_inmueble, int idPeriodo)
        {
            DateTime fechaHoy = DateTime.Now;
            try
            {

                Frm_Visor_Global frm_Visor_Global = new Frm_Visor_Global();
                Pred_Predio predio = repo_PredioUrbanoDataService.DataPredial(predio_ID, idPeriodo);
                if (tipo_inmueble == 2)
                {
                    ColeccionCR = repo_PredioRusticoDataService.listarContribuyenteRustico(xpersona.ToString());
                    ColeccionPR = repo_PredioRusticoDataService.listarPredioRustico(predio_ID, idPeriodo);
                    ColeccionDIR = repo_PredioRusticoDataService.ListarImpuestoRustico(predio_ID, idPeriodo);
                    frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                    //chuchurro aqui modificasel pr sin formato
                    frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._5_Reportes_Gestion.Rep_Predio.Reporte_PR.rdlc";
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

                    ReportParameter[] paramsx = new ReportParameter[13];
                    paramsx[0] = new ReportParameter("NombreEmpresa", Globales.NombreEmpresa);
                    paramsx[1] = new ReportParameter("UsuarioPrueba", GlobalesV1.Global_str_Usuario);
                    paramsx[2] = new ReportParameter("Año", fechaHoy.Year.ToString());
                    paramsx[3] = new ReportParameter("Dia", fechaHoy.Day.ToString());
                    paramsx[4] = new ReportParameter("Mes", fechaHoy.Month.ToString());
                    paramsx[5] = new ReportParameter("RucEmpresa", Globales.RucEmpresa);

                    paramsx[6] = new ReportParameter("area_terreno", predio.area_terreno.ToString());
                    paramsx[7] = new ReportParameter("arancel", predio.arancel.ToString());
                    paramsx[8] = new ReportParameter("valor_otra_instalacion", predio.valor_otra_instalacion.ToString());
                    paramsx[9] = new ReportParameter("valor_terreno", predio.valor_terreno.ToString());
                    paramsx[10] = new ReportParameter("valor_construccion", predio.valor_construccion.ToString());
                    paramsx[11] = new ReportParameter("total_autovaluo", predio.total_autovaluo.ToString());
                    paramsx[12] = new ReportParameter("Anio", idPeriodo.ToString());
                    frm_Visor_Global.reportViewer1.LocalReport.SetParameters(paramsx);
                    frm_Visor_Global.reportViewer1.RefreshReport();
                    frm_Visor_Global.StartPosition = FormStartPosition.CenterScreen;
                    frm_Visor_Global.ShowDialog();
                }
                else if (tipo_inmueble == 1)
                {
                    ColeccionDC = repo_PredioUrbanoDataService.ListarDatosContribuyente(xpersona.ToString());
                    ColeccionDP = repo_PredioUrbanoDataService.ListarDatosPredio(predio_ID, idPeriodo);
                    ColeccionUDI = repo_PredioUrbanoDataService.ListarImpuestoUrbano(predio_ID, idPeriodo);
                    frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                    //chuchurro aqui modificas el pu sin formato
                    frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._5_Reportes_Gestion.Rep_Predio.Reporte_PU.rdlc";
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

                    ReportParameter[] paramsx = new ReportParameter[13];
                    paramsx[0] = new ReportParameter("NombreEmpresa", Globales.NombreEmpresa);
                    paramsx[1] = new ReportParameter("UsuarioPrueba", GlobalesV1.Global_str_Usuario);
                    paramsx[2] = new ReportParameter("Año", fechaHoy.Year.ToString());
                    paramsx[3] = new ReportParameter("Dia", fechaHoy.Day.ToString());
                    paramsx[4] = new ReportParameter("Mes", fechaHoy.Month.ToString());
                    paramsx[5] = new ReportParameter("RucEmpresa", Globales.RucEmpresa);
                    paramsx[6] = new ReportParameter("area_terreno", predio.area_terreno.ToString());
                    paramsx[7] = new ReportParameter("arancel", predio.arancel.ToString());
                    paramsx[8] = new ReportParameter("valor_otra_instalacion", predio.valor_otra_instalacion.ToString());
                    paramsx[9] = new ReportParameter("valor_terreno", predio.valor_terreno.ToString());
                    paramsx[10] = new ReportParameter("valor_construccion", predio.valor_construccion.ToString());
                    paramsx[11] = new ReportParameter("total_autovaluo", predio.total_autovaluo.ToString());
                    paramsx[12] = new ReportParameter("Anio", idPeriodo.ToString());
                    frm_Visor_Global.reportViewer1.LocalReport.SetParameters(paramsx);
                    frm_Visor_Global.reportViewer1.RefreshReport();
                    frm_Visor_Global.StartPosition = FormStartPosition.CenterScreen;
                    frm_Visor_Global.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }
        private void llenarcomboPeriodoFinal()
        {
            try
            {
                comoBusquedaPeriodoFinal.DisplayMember = "Peric_canio";
                comoBusquedaPeriodoFinal.ValueMember = "Peric_canio";
                comoBusquedaPeriodoFinal.DataSource = mant_PeriodoDataService.llenarPeriodo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void llenarcomboPeriodoInicial()
        {
            try
            {
                comboBusquedaPeriodoInicial.DisplayMember = "Peric_canio";
                comboBusquedaPeriodoInicial.ValueMember = "Peric_canio";
                comboBusquedaPeriodoInicial.DataSource = mant_PeriodoDataService.llenarPeriodo();
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
            txtNomRazon.Text = "";
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
                        txtNomRazon.Enabled = false;
                        break;
                    case "rbtCodContribuyente":
                        txtNDocu.Enabled = false;
                        txtCodContribuyente.Enabled = true;
                        txtCodContribuyente.Focus();
                        txtNomRazon.Enabled = false;
                        break;
                    case "rbtNombre":
                        txtNDocu.Enabled = false;
                        txtCodContribuyente.Enabled = false;
                        txtNomRazon.Enabled = true;
                        txtNomRazon.Focus();
                        break;
                    case "rbtDirección":
                        txtNDocu.Enabled = false;
                        txtCodContribuyente.Enabled = false;
                        txtNomRazon.Enabled = false;
                        break;
                    case "rbtCPredio":
                        txtNDocu.Enabled = false;
                        txtCodContribuyente.Enabled = false;
                        break;
                    case "rbtExpediente":
                        txtNDocu.Enabled = false;
                        txtCodContribuyente.Enabled = false;
                        break;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Globales.Global_MessageBox);
            }

        }
        private void Frm_PUPR_Load(object sender, EventArgs e)
        {
            //llenarcomboPeriodoInicial();
            //llenarcomboPeriodoFinal();
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {

            string texto;
            if (rbtCodContribuyente.Checked)
            {
                texto = txtCodContribuyente.Text.TrimEnd();
                    if (texto.Length != 0)
                        listarBuscado("", texto, "");
            }
               
            else if (rbtNDoc.Checked)
            {
                texto = txtNDocu.Text.TrimEnd();
                if (texto.Length != 0)
                    listarBuscado(texto, "", "");
            }
            else
            {
                texto = txtNomRazon.Text.TrimEnd();
                listarBuscado("", "", texto);
            }
               
        }

        private void dgvContribuyenteBuscados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if ( dgvContribuyenteBuscados.RowCount > 0)
                {
                    String perso = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["persona_ID"].Value;
                    Coleccion = FiscalizacionDataService.listarpredios(perso, comboBusquedaPeriodoInicial.SelectedValue.ToString());
                    dgvPredio.DataSource = Coleccion;
                    //PintarColumnasCalculadas();
                }else
                    dgvPredio.DataSource = new List<Pred_Predio>();
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


        private void txtNDocu_KeyPress(object sender, KeyPressEventArgs e)
        {
            string texto;
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                texto = txtNDocu.Text;
            }
            else
            {
                if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsControl(e.KeyChar)))
                {
                    MessageBox.Show("Solo se permiten números", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
                texto = txtNDocu.Text + e.KeyChar.ToString();
            }

            if (texto.Length != 0 && rbtNDoc.Checked)
                listarBuscado(texto, "", "");
        }

        //private void txtCodContribuyente_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    string texto;
        //    if (e.KeyChar == Convert.ToChar(Keys.Enter))
        //    {
        //        texto = txtCodContribuyente.Text;
        //    }
        //    else
        //    {
        //        if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsControl(e.KeyChar)))
        //        {
        //            MessageBox.Show("Solo se permiten números", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //            e.Handled = true;
        //            return;
        //        }
        //        texto = txtCodContribuyente.Text + e.KeyChar.ToString();
        //    }

        //    if (texto.Length != 0 && rbtCodContribuyente.Checked)
        //        listarBuscado("", texto, "");
        //}

        //private void txtNomRazon_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    string texto;
        //    if (e.KeyChar == Convert.ToChar(Keys.Enter))
        //    {
        //        texto = txtNomRazon.Text;
        //    }
        //    else
        //        texto = txtNomRazon.Text + e.KeyChar.ToString();

        //    if (texto.Length != 0 && rbtNombre.Checked)
        //        listarBuscado("", "", texto);
        //}

        private void dgvPredio_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvPredio.IsCurrentCellDirty)
            {
                dgvPredio.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void ckbPredio_CheckedChanged(object sender, EventArgs e)
        {
            int cantidad = dgvPredio.RowCount;
            decimal total = 0;
            decimal valor = 0;
            for (int i = 0; i < cantidad; i++)
            {
                DataGridViewRow row1 = dgvPredio.Rows[i];
                DataGridViewCheckBoxCell cellSelecion1 = row1.Cells["Op"] as DataGridViewCheckBoxCell;
                cellSelecion1.Value = ckbPredio.Checked;
            }
        }

        private void dgvPredio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    if (dgvPredio.Columns[e.ColumnIndex].Name == "Incluir")
            //    {
            //        decimal total = Convert.ToDecimal(txtAreaconstruida.Text);
            //        decimal mayor = 0;
            //        if (e.RowIndex == -1)
            //            return;
            //        int cantidad;
            //        cantidad = dgvPredio.RowCount;
            //        DataGridViewRow row = dgvPredio.Rows[e.RowIndex];
            //        DataGridViewCheckBoxCell cellSelecion = row.Cells["Op"] as DataGridViewCheckBoxCell;

            //    }//

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            //}
        }

        private void rbtConFormato_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtSinFormato_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
