using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using SGR.Entity.Model;
using SGR.Core.Service;
using SGR.Core.Service.Combos;
using SGR.Entity;
using SGR.WinApp.Layout._5_Reportes_Gestion;
using Microsoft.Reporting.WinForms;
using System.IO;
using System.Drawing.Printing;
using System.Drawing.Imaging;
using SGR.Entity.Model.Combos;

namespace SGR.WinApp.Layout._4_Procesos.Emision
{
    public partial class Emi_EmisionMasiva : DockContent
    {

        private int m_currentPageIndex;
        private IList<Stream> m_streams;

        public Valo_ValoresCobranzaDataService valores = new Valo_ValoresCobranzaDataService();
        private Emi_MasivoDataService emiMasivo = new Emi_MasivoDataService();
        private List<Emi_Masivo> coleccion;
        private List<Emi_Masivo> coleccion2;
        private Mant_PeriodoDataService periodos = new Mant_PeriodoDataService();
        private Reci_ReciboDataService reciboDS = new Reci_ReciboDataService();
        private MesDataService mess = new MesDataService();
        private List<Mant_Periodo> periodo = new List<Mant_Periodo>();
        private Conf_MultitablaDataService tablas = new Conf_MultitablaDataService();
        private List<Mes> mesese = new List<Mes>();
        private For_Masivo_DataService For_Masivo_DataService = new For_Masivo_DataService();

        Pred_SectorDataService pred_SectorDataService = new Pred_SectorDataService();
        List<Pred_Sector> listaSec = new List<Pred_Sector>();

        private Pred_PredioDataService predioDataService = new Pred_PredioDataService();
        private List<Mant_Contribuyente> ColeccionMPC;
        private List<Repo_HojaResumen> ColeccionPC;
        private List<Repo_HojaResumen> ColeccionMP;
        private List<Pred_Predio> ColeccionP;
        private List<For_Masivo> ColeccionNumero; 
        private List<For_Masivo> ColeccionNumeroPU;
        private List<For_Masivo> ColeccionNumeroPR;
        Repo_HojaResumenService repo_HojaResumenService = new Repo_HojaResumenService();

        Pred_FiscalizacionDataService FiscalizacionDataService = new Pred_FiscalizacionDataService();
        private List<Pred_Predio> ColeccionPRE;
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

        public Emi_EmisionMasiva()
        {
            InitializeComponent();
            iniciarElementos();
        }

        public void iniciarElementos()
        {
            listaSec.AddRange(pred_SectorDataService.listarSectorCboValidos());
            cboSector.DisplayMember = "descripcion";
            cboSector.ValueMember = "sector_id";
            cboSector.DataSource = listaSec;

        }
        private void Emi_EmisionMasiva_Load(object sender, EventArgs e)
        {
            cboAnio.Visible = true;
            cboMes.Visible = false;
            lblAnio.Visible = false;
            lblMes.Visible = false;
            llenarCombos();
        }

        public void llenarCombos()
        {
            MesDataService mesDataService = new MesDataService();
            Mant_PeriodoDataService periodos = new Mant_PeriodoDataService();            

            cboMes.ValueMember = "mes_ID";
            cboMes.DisplayMember = "mes";
            cboMes.DataSource = mesDataService.listartodos();

            cboAnio.DisplayMember = "Peric_canio";
            cboAnio.ValueMember = "Peric_canio";
            cboAnio.DataSource = periodos.GetAllMant_Periodo();
        }

       

        private Stream CreateStream(string name,
        string fileNameExtension, Encoding encoding,
        string mimeType, bool willSeek)
        {
            Stream stream = new MemoryStream();
            m_streams.Add(stream);
            return stream;
        }
        // Export the given report as an EMF (Enhanced Metafile) file.
        private void Export(LocalReport report)
        {
            string deviceInfo =
              @"<DeviceInfo>
                <OutputFormat>EMF</OutputFormat>
               <PageHeight>22cm</PageHeight>
                <PageWidth>29cm</PageWidth>
                <LeftMargin>1.5cm</LeftMargin>
                <RightMargin>1.5cm</RightMargin>
                <TopMargin>1.5cm</TopMargin>
                <BottomMargin>1.5cm</BottomMargin>
                <ColumnSpacing>0.13cm</ColumnSpacing>
            </DeviceInfo>";
            Warning[] warnings;
            m_streams = new List<Stream>();
            report.Render("Image", deviceInfo, CreateStream,
               out warnings);
            foreach (Stream stream in m_streams)
                stream.Position = 0;
        }
        // Handler for PrintPageEvents
        private void PrintPage(object sender, PrintPageEventArgs ev)
        {
            Metafile pageImage = new
            Metafile(m_streams[m_currentPageIndex]);

            // Adjust rectangular area with printer margins.
            Rectangle adjustedRect = new Rectangle(
                ev.PageBounds.Left - (int)ev.PageSettings.HardMarginX,
                ev.PageBounds.Top - (int)ev.PageSettings.HardMarginY,
                ev.PageBounds.Width,
                ev.PageBounds.Height);

            // Draw a white background for the report
            ev.Graphics.FillRectangle(Brushes.White, adjustedRect);

            // Draw the report content
            ev.Graphics.DrawImage(pageImage, adjustedRect);

            // Prepare for the next page. Make sure we haven't hit the end.
            m_currentPageIndex++;
            ev.HasMorePages = (m_currentPageIndex < m_streams.Count);
        }

        private void Print()
        {
            if (m_streams == null || m_streams.Count == 0)
                throw new Exception("Error: no stream to print.");
            PrintDocument printDoc = new PrintDocument();
            if (!printDoc.PrinterSettings.IsValid)
            {
                throw new Exception("Error: cannot find the default printer.");
            }
            else
            {
                printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
                m_currentPageIndex = 0;
                printDoc.Print();
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fechaHoy = DateTime.Now;
            Frm_Visor_Global frm_Visor_Global = new Frm_Visor_Global();
            if (dgvContribuyentes.Rows.Count > 0) {
                if (btn_conFormato.Checked == true)
                {
                    if (chkHR.Checked == false && chkPUPR.Checked == false)
                    {
                        MessageBox.Show("Selecciones formato a imprimir", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    if (chkHR.Checked == true)
                    {
                        //MessageBox.Show("Imprimir HR", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HR_Reporte();
                    }
                    if (chkPUPR.Checked == true)
                    {
                        for (int i = 0; i < coleccion.Count; i++)
                        {
                            ColeccionPRE = FiscalizacionDataService.listarpredios(coleccion[i].persona_ID, cboAnio.SelectedValue.ToString());
                            for (int j = 0; j < ColeccionPRE.Count; j++)
                            {

                                if (ColeccionPRE[j].tipo_inmueble == 1)
                                {
                                    Cursor.Current = Cursors.WaitCursor;
                                    For_Masivo_DataService.InsertPU();
                                    ColeccionNumeroPU = For_Masivo_DataService.NumeracionPU();
                                    ColeccionDC = repo_PredioUrbanoDataService.ListarDatosContribuyente(coleccion[i].persona_ID);
                                    ColeccionDP = repo_PredioUrbanoDataService.ListarDatosPredio(ColeccionPRE[j].predio_ID, Convert.ToInt32(cboAnio.Text));
                                    ColeccionUDI = repo_PredioUrbanoDataService.ListarImpuestoUrbano(ColeccionPRE[j].predio_ID, Convert.ToInt32(cboAnio.Text));
                                    frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                                    frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._5_Reportes_Gestion.Rep_Predio.Reporte_PredioUrbano.rdlc";
                                    frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetDatosContribuyente", ColeccionDC));
                                    frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetDatosPredio", ColeccionDP));
                                    frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetDeterminacionImpuesto", ColeccionUDI));
                                    ReportParameter[] paramsx = new ReportParameter[14];
                                    paramsx[0] = new ReportParameter("NombreEmpresa", "MUNICIPALIDAD DISTRITAL DE MOCHE");
                                    paramsx[1] = new ReportParameter("UsuarioPrueba", "Usuario 01");
                                    paramsx[2] = new ReportParameter("Año", fechaHoy.Year.ToString());
                                    paramsx[3] = new ReportParameter("Dia", fechaHoy.Day.ToString());
                                    paramsx[4] = new ReportParameter("Mes", fechaHoy.Month.ToString());
                                    paramsx[5] = new ReportParameter("RucEmpresa", "20167741208");


                                    paramsx[6] = new ReportParameter("area_terreno", ColeccionPRE[j].area_terreno.ToString());
                                    paramsx[7] = new ReportParameter("arancel", ColeccionPRE[j].arancel.ToString());
                                    paramsx[8] = new ReportParameter("valor_otra_instalacion", ColeccionPRE[j].valor_otra_instalacion.ToString());
                                    paramsx[9] = new ReportParameter("valor_terreno", ColeccionPRE[j].valor_terreno.ToString());
                                    paramsx[10] = new ReportParameter("valor_construccion", ColeccionPRE[j].valor_construccion.ToString());
                                    paramsx[11] = new ReportParameter("total_autovaluo", ColeccionPRE[j].total_autovaluo.ToString());
                                    paramsx[12] = new ReportParameter("Anio", cboAnio.Text);
                                    paramsx[13] = new ReportParameter("numero", ColeccionNumeroPU[0].numero.ToString());
                                    frm_Visor_Global.reportViewer1.LocalReport.SetParameters(paramsx);
                                    frm_Visor_Global.reportViewer1.RefreshReport();
                                    frm_Visor_Global.StartPosition = FormStartPosition.CenterScreen;
                                    //frm_Visor_Global.ShowDialog();
                                    Export(frm_Visor_Global.reportViewer1.LocalReport);
                                    Print();

                                }
                                else
                                {
                                    Cursor.Current = Cursors.WaitCursor;
                                    For_Masivo_DataService.InsertPR();
                                    ColeccionNumeroPR = For_Masivo_DataService.NumeracionPR();
                                    ColeccionCR = repo_PredioRusticoDataService.listarContribuyenteRustico(coleccion[i].persona_ID);
                                    ColeccionPR = repo_PredioRusticoDataService.listarPredioRustico(ColeccionPRE[j].predio_ID, Convert.ToInt32(cboAnio.Text));
                                    ColeccionDIR = repo_PredioRusticoDataService.ListarImpuestoRustico(ColeccionPRE[j].predio_ID, Convert.ToInt32(cboAnio.Text));
                                    frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();



                                    frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._5_Reportes_Gestion.Rep_Predio.Reporte_PredioRustico.rdlc";
                                    frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetContribuyente", ColeccionCR));
                                    frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetPredio", ColeccionPR));
                                    frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetDeterminacionImpuesto", ColeccionDIR));
                                    ReportParameter[] paramsx = new ReportParameter[14];
                                    paramsx[0] = new ReportParameter("NombreEmpresa", "MUNICIPALIDAD DISTRITAL DE MOCHE");
                                    paramsx[1] = new ReportParameter("UsuarioPrueba", "Usuario 01");
                                    paramsx[2] = new ReportParameter("Año", fechaHoy.Year.ToString());
                                    paramsx[3] = new ReportParameter("Dia", fechaHoy.Day.ToString());
                                    paramsx[4] = new ReportParameter("Mes", fechaHoy.Month.ToString());
                                    paramsx[5] = new ReportParameter("RucEmpresa", "20167741208");


                                    paramsx[6] = new ReportParameter("area_terreno", ColeccionPRE[j].area_terreno.ToString());
                                    paramsx[7] = new ReportParameter("arancel", ColeccionPRE[j].arancel.ToString());
                                    paramsx[8] = new ReportParameter("valor_otra_instalacion", ColeccionPRE[j].valor_otra_instalacion.ToString());
                                    paramsx[9] = new ReportParameter("valor_terreno", ColeccionPRE[j].valor_terreno.ToString());
                                    paramsx[10] = new ReportParameter("valor_construccion", ColeccionPRE[j].valor_construccion.ToString());
                                    paramsx[11] = new ReportParameter("total_autovaluo", ColeccionPRE[j].total_autovaluo.ToString());
                                    paramsx[12] = new ReportParameter("Anio", cboAnio.Text);
                                    paramsx[13] = new ReportParameter("numero", ColeccionNumeroPR[0].numero.ToString());
                                    frm_Visor_Global.reportViewer1.LocalReport.SetParameters(paramsx);
                                    frm_Visor_Global.reportViewer1.RefreshReport();
                                    frm_Visor_Global.StartPosition = FormStartPosition.CenterScreen;
                                    //frm_Visor_Global.ShowDialog();
                                    Export(frm_Visor_Global.reportViewer1.LocalReport);
                                    Print();
                                }
                            }

                        }
                        MessageBox.Show("Se Imprimio todos los formatos.", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (btn_sinFormato.Checked == true)
                    {
                        if (chkHR.Checked == false && chkPUPR.Checked == false)
                        {
                            MessageBox.Show("Selecciones formato a imprimir", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        if (chkHR.Checked == true)
                        {
                            //MessageBox.Show("Imprimir HR", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            HR_Reporte3();
                        }
                        if (chkPUPR.Checked == true)
                        {
                            for (int i = 0; i < coleccion.Count; i++)
                            {
                                ColeccionPRE = FiscalizacionDataService.listarpredios(coleccion[i].persona_ID, cboAnio.SelectedValue.ToString());
                                for (int j = 0; j < ColeccionPRE.Count; j++)
                                {

                                    if (ColeccionPRE[j].tipo_inmueble == 1)
                                    {
                                        ColeccionDC = repo_PredioUrbanoDataService.ListarDatosContribuyente(coleccion[i].persona_ID);
                                        ColeccionDP = repo_PredioUrbanoDataService.ListarDatosPredio(ColeccionPRE[j].predio_ID, Convert.ToInt32(cboAnio.Text));
                                        ColeccionUDI = repo_PredioUrbanoDataService.ListarImpuestoUrbano(ColeccionPRE[j].predio_ID, Convert.ToInt32(cboAnio.Text));
                                        frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                                        frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._5_Reportes_Gestion.Rep_Predio.Reporte_PU.rdlc";
                                        frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetDatosContribuyente", ColeccionDC));
                                        frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetDatosPredio", ColeccionDP));
                                        frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetDeterminacionImpuesto", ColeccionUDI));
                                        ReportParameter[] paramsx = new ReportParameter[13];
                                        paramsx[0] = new ReportParameter("NombreEmpresa", "MUNICIPALIDAD DISTRITAL DE MOCHE");
                                        paramsx[1] = new ReportParameter("UsuarioPrueba", "Usuario 01");
                                        paramsx[2] = new ReportParameter("Año", fechaHoy.Year.ToString());
                                        paramsx[3] = new ReportParameter("Dia", fechaHoy.Day.ToString());
                                        paramsx[4] = new ReportParameter("Mes", fechaHoy.Month.ToString());
                                        paramsx[5] = new ReportParameter("RucEmpresa", "20167741208");


                                        paramsx[6] = new ReportParameter("area_terreno", ColeccionPRE[j].area_terreno.ToString());
                                        paramsx[7] = new ReportParameter("arancel", ColeccionPRE[j].arancel.ToString());
                                        paramsx[8] = new ReportParameter("valor_otra_instalacion", ColeccionPRE[j].valor_otra_instalacion.ToString());
                                        paramsx[9] = new ReportParameter("valor_terreno", ColeccionPRE[j].valor_terreno.ToString());
                                        paramsx[10] = new ReportParameter("valor_construccion", ColeccionPRE[j].valor_construccion.ToString());
                                        paramsx[11] = new ReportParameter("total_autovaluo", ColeccionPRE[j].total_autovaluo.ToString());
                                        paramsx[12] = new ReportParameter("Anio", cboAnio.Text);
                                        frm_Visor_Global.reportViewer1.LocalReport.SetParameters(paramsx);
                                        frm_Visor_Global.reportViewer1.RefreshReport();
                                        frm_Visor_Global.StartPosition = FormStartPosition.CenterScreen;
                                        //frm_Visor_Global.ShowDialog();
                                        Export(frm_Visor_Global.reportViewer1.LocalReport);
                                        Print();

                                    }
                                    else
                                    {
                                        ColeccionCR = repo_PredioRusticoDataService.listarContribuyenteRustico(coleccion[i].persona_ID);
                                        ColeccionPR = repo_PredioRusticoDataService.listarPredioRustico(ColeccionPRE[j].predio_ID, Convert.ToInt32(cboAnio.Text));
                                        ColeccionDIR = repo_PredioRusticoDataService.ListarImpuestoRustico(ColeccionPRE[j].predio_ID, Convert.ToInt32(cboAnio.Text));
                                        frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();



                                        frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._5_Reportes_Gestion.Rep_Predio.Reporte_PR.rdlc";
                                        frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetContribuyente", ColeccionCR));
                                        frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetPredio", ColeccionPR));
                                        frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetDeterminacionImpuesto", ColeccionDIR));
                                        ReportParameter[] paramsx = new ReportParameter[13];
                                        paramsx[0] = new ReportParameter("NombreEmpresa", "MUNICIPALIDAD DISTRITAL DE MOCHE");
                                        paramsx[1] = new ReportParameter("UsuarioPrueba", "Usuario 01");
                                        paramsx[2] = new ReportParameter("Año", fechaHoy.Year.ToString());
                                        paramsx[3] = new ReportParameter("Dia", fechaHoy.Day.ToString());
                                        paramsx[4] = new ReportParameter("Mes", fechaHoy.Month.ToString());
                                        paramsx[5] = new ReportParameter("RucEmpresa", "20167741208");


                                        paramsx[6] = new ReportParameter("area_terreno", ColeccionPRE[j].area_terreno.ToString());
                                        paramsx[7] = new ReportParameter("arancel", ColeccionPRE[j].arancel.ToString());
                                        paramsx[8] = new ReportParameter("valor_otra_instalacion", ColeccionPRE[j].valor_otra_instalacion.ToString());
                                        paramsx[9] = new ReportParameter("valor_terreno", ColeccionPRE[j].valor_terreno.ToString());
                                        paramsx[10] = new ReportParameter("valor_construccion", ColeccionPRE[j].valor_construccion.ToString());
                                        paramsx[11] = new ReportParameter("total_autovaluo", ColeccionPRE[j].total_autovaluo.ToString());
                                        paramsx[12] = new ReportParameter("Anio", cboAnio.Text);
                                        frm_Visor_Global.reportViewer1.LocalReport.SetParameters(paramsx);
                                        frm_Visor_Global.reportViewer1.RefreshReport();
                                        frm_Visor_Global.StartPosition = FormStartPosition.CenterScreen;
                                        //frm_Visor_Global.ShowDialog();
                                        Export(frm_Visor_Global.reportViewer1.LocalReport);
                                        Print();
                                    }
                                }

                            }
                            MessageBox.Show("Se Imprimio todos los formatos.", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

            } else
            {
                MessageBox.Show("Seleccione un sector y verifique los contribuyentes.", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }           
        }

        private void HR_Reporte()
        {
            DateTime fechaHoy = DateTime.Now;
            DateTime diaHoy = DateTime.Now;

            Cursor.Current = Cursors.WaitCursor;
            Frm_Visor_Global frm_Visor_Global = new Frm_Visor_Global();
            try
            {
                for (int i = 0; i < coleccion.Count; i++)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    Mant_ContribuyenteDataService mant_ContribuyenteDataService1 = new Mant_ContribuyenteDataService();
                    For_Masivo_DataService.Insert();
                    ColeccionNumero = For_Masivo_DataService.Numeracion();
                    ColeccionMPC = mant_ContribuyenteDataService1.listarIdContribuyente(Convert.ToInt32(coleccion[i].persona_ID));
                    ColeccionP = predioDataService.listarPrediosxPerContribuyente(coleccion[i].persona_ID.ToString());
                    ColeccionPC = repo_HojaResumenService.listarDeterminacionImpuesto(coleccion[i].persona_ID.ToString(), Convert.ToInt32(cboAnio.Text));
                    ColeccionMP = repo_HojaResumenService.listarMontosPagar(coleccion[i].persona_ID.ToString(), Convert.ToInt32(cboAnio.Text));
                    frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                    frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._1_Tablas_Maestras.Contribuyente.Reporte_Contribuyente.rdlc";
                    frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetContribuyente", ColeccionMPC));
                    frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetRelacionPredios", ColeccionP));
                    frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetDeterminacionImpuesto", ColeccionPC));
                    frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetMontosPagar", ColeccionMP));
                    ReportParameter[] paramsx = new ReportParameter[7];
                    paramsx[0] = new ReportParameter("NombreEmpresa", "Municipalidad Distrital de Moche");
                    paramsx[1] = new ReportParameter("UsuarioPrueba", "Usuario 01");
                    paramsx[2] = new ReportParameter("Año", fechaHoy.Year.ToString());
                    paramsx[3] = new ReportParameter("Dia", fechaHoy.Day.ToString());
                    paramsx[4] = new ReportParameter("Mes", fechaHoy.Month.ToString());
                    paramsx[5] = new ReportParameter("RucEmpresa", "201667741208");
                    paramsx[6] = new ReportParameter("numero", ColeccionNumero[0].numero.ToString());
                    frm_Visor_Global.reportViewer1.LocalReport.SetParameters(paramsx);
                    frm_Visor_Global.reportViewer1.RefreshReport();
                    frm_Visor_Global.StartPosition = FormStartPosition.CenterScreen;
                    //frm_Visor_Global.ShowDialog();                    
                    Export(frm_Visor_Global.reportViewer1.LocalReport);
                    Print();
                }
                MessageBox.Show("Se imprimio todo los HR.", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void HR_Reporte2()
        {
            DateTime fechaHoy = DateTime.Now;
            DateTime diaHoy = DateTime.Now;

            Cursor.Current = Cursors.WaitCursor;
            Frm_Visor_Global frm_Visor_Global = new Frm_Visor_Global();
            try
            {
                for (int i = 0; i < coleccion2.Count; i++)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    Mant_ContribuyenteDataService mant_ContribuyenteDataService1 = new Mant_ContribuyenteDataService();
                    For_Masivo_DataService.Insert();
                    ColeccionNumero = For_Masivo_DataService.Numeracion();
                    ColeccionMPC = mant_ContribuyenteDataService1.listarIdContribuyente(Convert.ToInt32(coleccion2[i].persona_ID));                    
                    ColeccionP = predioDataService.listarPrediosxPerContribuyente(coleccion2[i].persona_ID.ToString());
                    ColeccionPC = repo_HojaResumenService.listarDeterminacionImpuesto(coleccion2[i].persona_ID.ToString(), Convert.ToInt32(cboAnio.Text));
                    ColeccionMP = repo_HojaResumenService.listarMontosPagar(coleccion2[i].persona_ID.ToString(), Convert.ToInt32(cboAnio.Text));
                    frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();  
                    frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._1_Tablas_Maestras.Contribuyente.Reporte_Contribuyente.rdlc";
                    frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetContribuyente", ColeccionMPC));
                    frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetRelacionPredios", ColeccionP));
                    frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetDeterminacionImpuesto", ColeccionPC));
                    frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetMontosPagar", ColeccionMP));
                    ReportParameter[] paramsx = new ReportParameter[7];
                    paramsx[0] = new ReportParameter("NombreEmpresa", "Municipalidad Distrital de Moche");
                    paramsx[1] = new ReportParameter("UsuarioPrueba", "Usuario 01");
                    paramsx[2] = new ReportParameter("Año", fechaHoy.Year.ToString());
                    paramsx[3] = new ReportParameter("Dia", fechaHoy.Day.ToString());
                    paramsx[4] = new ReportParameter("Mes", fechaHoy.Month.ToString());
                    paramsx[5] = new ReportParameter("RucEmpresa", "201667741208");
                    paramsx[6] = new ReportParameter("numero", ColeccionNumero[0].numero.ToString());
                    frm_Visor_Global.reportViewer1.LocalReport.SetParameters(paramsx);
                    frm_Visor_Global.reportViewer1.RefreshReport();
                    frm_Visor_Global.StartPosition = FormStartPosition.CenterScreen;
                    //frm_Visor_Global.ShowDialog();                    
                    Export(frm_Visor_Global.reportViewer1.LocalReport);
                    Print();                    
                }
                MessageBox.Show("Se imprimio todo los HR.", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void HR_Reporte3()
        {
            DateTime fechaHoy = DateTime.Now;
            DateTime diaHoy = DateTime.Now;

            Cursor.Current = Cursors.WaitCursor;
            Frm_Visor_Global frm_Visor_Global = new Frm_Visor_Global();
            try
            {
                for (int i = 0; i < coleccion.Count; i++)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    Mant_ContribuyenteDataService mant_ContribuyenteDataService1 = new Mant_ContribuyenteDataService();
                    ColeccionMPC = mant_ContribuyenteDataService1.listarIdContribuyente(Convert.ToInt32(coleccion[i].persona_ID));
                    ColeccionP = predioDataService.listarPrediosxPerContribuyente(coleccion[i].persona_ID.ToString());
                    ColeccionPC = repo_HojaResumenService.listarDeterminacionImpuesto(coleccion[i].persona_ID.ToString(), Convert.ToInt32(cboAnio.Text));
                    ColeccionMP = repo_HojaResumenService.listarMontosPagar(coleccion[i].persona_ID.ToString(), Convert.ToInt32(cboAnio.Text));
                    frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                    frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._1_Tablas_Maestras.Contribuyente.Reporte_Contribuyente_SinFormato.rdlc";
                    frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetContribuyente", ColeccionMPC));
                    frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetRelacionPredios", ColeccionP));
                    frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetDeterminacionImpuesto", ColeccionPC));
                    frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetMontosPagar", ColeccionMP));
                    ReportParameter[] paramsx = new ReportParameter[6];
                    paramsx[0] = new ReportParameter("NombreEmpresa", "Municipalidad Distrital de Moche");
                    paramsx[1] = new ReportParameter("UsuarioPrueba", "Usuario 01");
                    paramsx[2] = new ReportParameter("Año", fechaHoy.Year.ToString());
                    paramsx[3] = new ReportParameter("Dia", fechaHoy.Day.ToString());
                    paramsx[4] = new ReportParameter("Mes", fechaHoy.Month.ToString());
                    paramsx[5] = new ReportParameter("RucEmpresa", "201667741208");
                    frm_Visor_Global.reportViewer1.LocalReport.SetParameters(paramsx);
                    frm_Visor_Global.reportViewer1.RefreshReport();
                    frm_Visor_Global.StartPosition = FormStartPosition.CenterScreen;
                    //frm_Visor_Global.ShowDialog();                    
                    Export(frm_Visor_Global.reportViewer1.LocalReport);
                    Print();
                }
                MessageBox.Show("Se imprimio todo los HR.", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void HR_Reporte4()
        {
            DateTime fechaHoy = DateTime.Now;
            DateTime diaHoy = DateTime.Now;

            Cursor.Current = Cursors.WaitCursor;
            Frm_Visor_Global frm_Visor_Global = new Frm_Visor_Global();
            try
            {
                for (int i = 0; i < coleccion2.Count; i++)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    Mant_ContribuyenteDataService mant_ContribuyenteDataService1 = new Mant_ContribuyenteDataService();
                    ColeccionMPC = mant_ContribuyenteDataService1.listarIdContribuyente(Convert.ToInt32(coleccion2[i].persona_ID));
                    ColeccionP = predioDataService.listarPrediosxPerContribuyente(coleccion2[i].persona_ID.ToString());
                    ColeccionPC = repo_HojaResumenService.listarDeterminacionImpuesto(coleccion2[i].persona_ID.ToString(), Convert.ToInt32(cboAnio.Text));
                    ColeccionMP = repo_HojaResumenService.listarMontosPagar(coleccion2[i].persona_ID.ToString(), Convert.ToInt32(cboAnio.Text));
                    frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                    frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._1_Tablas_Maestras.Contribuyente.Reporte_Contribuyente_SinFormato.rdlc";
                    frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetContribuyente", ColeccionMPC));
                    frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetRelacionPredios", ColeccionP));
                    frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetDeterminacionImpuesto", ColeccionPC));
                    frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetMontosPagar", ColeccionMP));
                    ReportParameter[] paramsx = new ReportParameter[6];
                    paramsx[0] = new ReportParameter("NombreEmpresa", "Municipalidad Distrital de Moche");
                    paramsx[1] = new ReportParameter("UsuarioPrueba", "Usuario 01");
                    paramsx[2] = new ReportParameter("Año", fechaHoy.Year.ToString());
                    paramsx[3] = new ReportParameter("Dia", fechaHoy.Day.ToString());
                    paramsx[4] = new ReportParameter("Mes", fechaHoy.Month.ToString());
                    paramsx[5] = new ReportParameter("RucEmpresa", "201667741208");
                    frm_Visor_Global.reportViewer1.LocalReport.SetParameters(paramsx);
                    frm_Visor_Global.reportViewer1.RefreshReport();
                    frm_Visor_Global.StartPosition = FormStartPosition.CenterScreen;
                    //frm_Visor_Global.ShowDialog();                    
                    Export(frm_Visor_Global.reportViewer1.LocalReport);
                    Print();
                }
                MessageBox.Show("Se imprimio todo los HR.", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
               coleccion = emiMasivo.listartodos((Convert.ToInt32(cboSector.SelectedValue)));
               dgvContribuyentes.DataSource = coleccion;
               //MessageBox.Show(coleccion[0].persona_ID, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void cboAnio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvContribuyentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Frm_Visor_Global frm_Visor_Global = new Frm_Visor_Global();
            String persona = (String)dgvContribuyentes.SelectedRows[0].Cells["nombres"].Value;
            String cod_persona = (String)dgvContribuyentes.SelectedRows[0].Cells["codigo"].Value;
            if (MessageBox.Show("¿Desea imprimir desde "+persona+" hacia adelante?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;
                coleccion2 = emiMasivo.listarNuevaImpresion(persona, (Convert.ToInt32(cboSector.SelectedValue)));
                DateTime fechaHoy = DateTime.Now;
                
                if (dgvContribuyentes.Rows.Count > 0)
                {
                    if (btn_conFormato.Checked==true)
                    {
                        if (chkHR.Checked == false && chkPUPR.Checked == false)
                        {
                            MessageBox.Show("Selecciones formato a imprimir", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        if (chkHR.Checked == true)
                        {
                            //MessageBox.Show("Imprimir HR", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            HR_Reporte2();
                        }
                        if (chkPUPR.Checked == true)
                        {
                            for (int i = 0; i < coleccion2.Count; i++)
                            {
                                ColeccionPRE = FiscalizacionDataService.listarpredios(coleccion2[i].persona_ID, cboAnio.SelectedValue.ToString());
                                for (int j = 0; j < ColeccionPRE.Count; j++)
                                {

                                    if (ColeccionPRE[j].tipo_inmueble == 1)
                                    {
                                        Cursor.Current = Cursors.WaitCursor;
                                        For_Masivo_DataService.InsertPU();
                                        ColeccionNumeroPU = For_Masivo_DataService.NumeracionPU();
                                        ColeccionDC = repo_PredioUrbanoDataService.ListarDatosContribuyente(coleccion2[i].persona_ID);
                                        ColeccionDP = repo_PredioUrbanoDataService.ListarDatosPredio(ColeccionPRE[j].predio_ID, Convert.ToInt32(cboAnio.Text));
                                        ColeccionUDI = repo_PredioUrbanoDataService.ListarImpuestoUrbano(ColeccionPRE[j].predio_ID, Convert.ToInt32(cboAnio.Text));
                                        frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                                        frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._5_Reportes_Gestion.Rep_Predio.Reporte_PredioUrbano.rdlc";
                                        frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetDatosContribuyente", ColeccionDC));
                                        frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetDatosPredio", ColeccionDP));
                                        frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetDeterminacionImpuesto", ColeccionUDI));
                                        ReportParameter[] paramsx = new ReportParameter[14];
                                        paramsx[0] = new ReportParameter("NombreEmpresa", "MUNICIPALIDAD DISTRITAL DE MOCHE");
                                        paramsx[1] = new ReportParameter("UsuarioPrueba", "Usuario 01");
                                        paramsx[2] = new ReportParameter("Año", fechaHoy.Year.ToString());
                                        paramsx[3] = new ReportParameter("Dia", fechaHoy.Day.ToString());
                                        paramsx[4] = new ReportParameter("Mes", fechaHoy.Month.ToString());
                                        paramsx[5] = new ReportParameter("RucEmpresa", "20167741208");


                                        paramsx[6] = new ReportParameter("area_terreno", ColeccionPRE[j].area_terreno.ToString());
                                        paramsx[7] = new ReportParameter("arancel", ColeccionPRE[j].arancel.ToString());
                                        paramsx[8] = new ReportParameter("valor_otra_instalacion", ColeccionPRE[j].valor_otra_instalacion.ToString());
                                        paramsx[9] = new ReportParameter("valor_terreno", ColeccionPRE[j].valor_terreno.ToString());
                                        paramsx[10] = new ReportParameter("valor_construccion", ColeccionPRE[j].valor_construccion.ToString());
                                        paramsx[11] = new ReportParameter("total_autovaluo", ColeccionPRE[j].total_autovaluo.ToString());
                                        paramsx[12] = new ReportParameter("Anio", cboAnio.Text);
                                        paramsx[13] = new ReportParameter("numero", ColeccionNumeroPU[0].numero.ToString());


                                        frm_Visor_Global.reportViewer1.LocalReport.SetParameters(paramsx);
                                        frm_Visor_Global.reportViewer1.RefreshReport();
                                        frm_Visor_Global.StartPosition = FormStartPosition.CenterScreen;
                                        //frm_Visor_Global.ShowDialog();
                                        Export(frm_Visor_Global.reportViewer1.LocalReport);
                                        Print();

                                    }
                                    else
                                    {
                                        Cursor.Current = Cursors.WaitCursor;
                                        For_Masivo_DataService.InsertPR();
                                        ColeccionNumeroPR = For_Masivo_DataService.NumeracionPR();
                                        ColeccionCR = repo_PredioRusticoDataService.listarContribuyenteRustico(coleccion2[i].persona_ID);
                                        ColeccionPR = repo_PredioRusticoDataService.listarPredioRustico(ColeccionPRE[j].predio_ID, Convert.ToInt32(cboAnio.Text));
                                        ColeccionDIR = repo_PredioRusticoDataService.ListarImpuestoRustico(ColeccionPRE[j].predio_ID, Convert.ToInt32(cboAnio.Text));
                                        frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                                        frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._5_Reportes_Gestion.Rep_Predio.Reporte_PredioRustico.rdlc";
                                        frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetContribuyente", ColeccionCR));
                                        frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetPredio", ColeccionPR));
                                        frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetDeterminacionImpuesto", ColeccionDIR));
                                        ReportParameter[] paramsx = new ReportParameter[14];
                                        paramsx[0] = new ReportParameter("NombreEmpresa", "MUNICIPALIDAD DISTRITAL DE MOCHE");
                                        paramsx[1] = new ReportParameter("UsuarioPrueba", "Usuario 01");
                                        paramsx[2] = new ReportParameter("Año", fechaHoy.Year.ToString());
                                        paramsx[3] = new ReportParameter("Dia", fechaHoy.Day.ToString());
                                        paramsx[4] = new ReportParameter("Mes", fechaHoy.Month.ToString());
                                        paramsx[5] = new ReportParameter("RucEmpresa", "20167741208");

                                        paramsx[6] = new ReportParameter("area_terreno", ColeccionPRE[j].area_terreno.ToString());
                                        paramsx[7] = new ReportParameter("arancel", ColeccionPRE[j].arancel.ToString());
                                        paramsx[8] = new ReportParameter("valor_otra_instalacion", ColeccionPRE[j].valor_otra_instalacion.ToString());
                                        paramsx[9] = new ReportParameter("valor_terreno", ColeccionPRE[j].valor_terreno.ToString());
                                        paramsx[10] = new ReportParameter("valor_construccion", ColeccionPRE[j].valor_construccion.ToString());
                                        paramsx[11] = new ReportParameter("total_autovaluo", ColeccionPRE[j].total_autovaluo.ToString());
                                        paramsx[12] = new ReportParameter("Anio", cboAnio.Text);
                                        paramsx[13] = new ReportParameter("numero", ColeccionNumeroPR[0].numero.ToString());

                                        frm_Visor_Global.reportViewer1.LocalReport.SetParameters(paramsx);
                                        frm_Visor_Global.reportViewer1.RefreshReport();
                                        frm_Visor_Global.StartPosition = FormStartPosition.CenterScreen;
                                        //frm_Visor_Global.ShowDialog();
                                        Export(frm_Visor_Global.reportViewer1.LocalReport);
                                        Print();
                                    }
                                }

                            }
                            MessageBox.Show("Se Imprimio todos los formatos.", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    } else
                    {
                        if (btn_sinFormato.Checked == true)
                        {
                            if (chkHR.Checked == false && chkPUPR.Checked == false)
                            {
                                MessageBox.Show("Selecciones formato a imprimir", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            if (chkHR.Checked == true)
                            {
                                //MessageBox.Show("Imprimir HR", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                HR_Reporte4();
                            }
                            if (chkPUPR.Checked == true)
                            {
                                for (int i = 0; i < coleccion2.Count; i++)
                                {
                                    ColeccionPRE = FiscalizacionDataService.listarpredios(coleccion2[i].persona_ID, cboAnio.SelectedValue.ToString());
                                    for (int j = 0; j < ColeccionPRE.Count; j++)
                                    {

                                        if (ColeccionPRE[j].tipo_inmueble == 1)
                                        {
                                            Cursor.Current = Cursors.WaitCursor;
                                            ColeccionDC = repo_PredioUrbanoDataService.ListarDatosContribuyente(coleccion2[i].persona_ID);
                                            ColeccionDP = repo_PredioUrbanoDataService.ListarDatosPredio(ColeccionPRE[j].predio_ID, Convert.ToInt32(cboAnio.Text));
                                            ColeccionUDI = repo_PredioUrbanoDataService.ListarImpuestoUrbano(ColeccionPRE[j].predio_ID, Convert.ToInt32(cboAnio.Text));
                                            frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                                            frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._5_Reportes_Gestion.Rep_Predio.Reporte_PU.rdlc";
                                            frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetDatosContribuyente", ColeccionDC));
                                            frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetDatosPredio", ColeccionDP));
                                            frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetDeterminacionImpuesto", ColeccionUDI));
                                            ReportParameter[] paramsx = new ReportParameter[13];
                                            paramsx[0] = new ReportParameter("NombreEmpresa", "MUNICIPALIDAD DISTRITAL DE MOCHE");
                                            paramsx[1] = new ReportParameter("UsuarioPrueba", "Usuario 01");
                                            paramsx[2] = new ReportParameter("Año", fechaHoy.Year.ToString());
                                            paramsx[3] = new ReportParameter("Dia", fechaHoy.Day.ToString());
                                            paramsx[4] = new ReportParameter("Mes", fechaHoy.Month.ToString());
                                            paramsx[5] = new ReportParameter("RucEmpresa", "20167741208");


                                            paramsx[6] = new ReportParameter("area_terreno", ColeccionPRE[j].area_terreno.ToString());
                                            paramsx[7] = new ReportParameter("arancel", ColeccionPRE[j].arancel.ToString());
                                            paramsx[8] = new ReportParameter("valor_otra_instalacion", ColeccionPRE[j].valor_otra_instalacion.ToString());
                                            paramsx[9] = new ReportParameter("valor_terreno", ColeccionPRE[j].valor_terreno.ToString());
                                            paramsx[10] = new ReportParameter("valor_construccion", ColeccionPRE[j].valor_construccion.ToString());
                                            paramsx[11] = new ReportParameter("total_autovaluo", ColeccionPRE[j].total_autovaluo.ToString());
                                            paramsx[12] = new ReportParameter("Anio", cboAnio.Text);



                                            frm_Visor_Global.reportViewer1.LocalReport.SetParameters(paramsx);
                                            frm_Visor_Global.reportViewer1.RefreshReport();
                                            frm_Visor_Global.StartPosition = FormStartPosition.CenterScreen;
                                            //frm_Visor_Global.ShowDialog();
                                            Export(frm_Visor_Global.reportViewer1.LocalReport);
                                            Print();

                                        }
                                        else
                                        {
                                            Cursor.Current = Cursors.WaitCursor;
                                            ColeccionCR = repo_PredioRusticoDataService.listarContribuyenteRustico(coleccion2[i].persona_ID);
                                            ColeccionPR = repo_PredioRusticoDataService.listarPredioRustico(ColeccionPRE[j].predio_ID, Convert.ToInt32(cboAnio.Text));
                                            ColeccionDIR = repo_PredioRusticoDataService.ListarImpuestoRustico(ColeccionPRE[j].predio_ID, Convert.ToInt32(cboAnio.Text));
                                            frm_Visor_Global.reportViewer1.LocalReport.DataSources.Clear();
                                            frm_Visor_Global.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._5_Reportes_Gestion.Rep_Predio.Reporte_PR.rdlc";
                                            frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetContribuyente", ColeccionCR));
                                            frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetPredio", ColeccionPR));
                                            frm_Visor_Global.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetDeterminacionImpuesto", ColeccionDIR));
                                            ReportParameter[] paramsx = new ReportParameter[13];
                                            paramsx[0] = new ReportParameter("NombreEmpresa", "MUNICIPALIDAD DISTRITAL DE MOCHE");
                                            paramsx[1] = new ReportParameter("UsuarioPrueba", "Usuario 01");
                                            paramsx[2] = new ReportParameter("Año", fechaHoy.Year.ToString());
                                            paramsx[3] = new ReportParameter("Dia", fechaHoy.Day.ToString());
                                            paramsx[4] = new ReportParameter("Mes", fechaHoy.Month.ToString());
                                            paramsx[5] = new ReportParameter("RucEmpresa", "20167741208");

                                            paramsx[6] = new ReportParameter("area_terreno", ColeccionPRE[j].area_terreno.ToString());
                                            paramsx[7] = new ReportParameter("arancel", ColeccionPRE[j].arancel.ToString());
                                            paramsx[8] = new ReportParameter("valor_otra_instalacion", ColeccionPRE[j].valor_otra_instalacion.ToString());
                                            paramsx[9] = new ReportParameter("valor_terreno", ColeccionPRE[j].valor_terreno.ToString());
                                            paramsx[10] = new ReportParameter("valor_construccion", ColeccionPRE[j].valor_construccion.ToString());
                                            paramsx[11] = new ReportParameter("total_autovaluo", ColeccionPRE[j].total_autovaluo.ToString());
                                            paramsx[12] = new ReportParameter("Anio", cboAnio.Text);


                                            frm_Visor_Global.reportViewer1.LocalReport.SetParameters(paramsx);
                                            frm_Visor_Global.reportViewer1.RefreshReport();
                                            frm_Visor_Global.StartPosition = FormStartPosition.CenterScreen;
                                            //frm_Visor_Global.ShowDialog();
                                            Export(frm_Visor_Global.reportViewer1.LocalReport);
                                            Print();
                                        }
                                    }

                                }
                                MessageBox.Show("Se Imprimio todos los formatos.", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Seleccione un sector y verifique los contribuyentes.", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            } else
            {
                MessageBox.Show("Se Cancelo la impresión.", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
