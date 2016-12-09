using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using SGR.Core.Service;
using SGR.Core.Service.Combos;
using SGR.Entity.Model;
using SGR.Entity.Model.Combos;
using SGR.Entity;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using SGR.WinApp.Layout._5_Reportes_Gestion;
using Microsoft.Reporting.WinForms;
using System.IO;
using System.Drawing.Printing;
using System.Drawing.Imaging;

namespace SGR.WinApp.Layout._4_Procesos.Recibo
{
    public partial class Frm_Recibo : DockContent
    {

        private int m_currentPageIndex;
        private IList<Stream> m_streams;


        private Mant_PeriodoDataService periodos = new Mant_PeriodoDataService();
        private Reci_ReciboDataService reciboDS = new Reci_ReciboDataService();
        private MesDataService mess = new MesDataService();        
        private List<Mant_Periodo> periodo = new List<Mant_Periodo>();
        private Conf_MultitablaDataService tablas = new Conf_MultitablaDataService();
        private List<Mes> mesese = new List<Mes>();
        Pred_SectorDataService pred_SectorDataService = new Pred_SectorDataService();
        List<Pred_Sector> listaSec = new List<Pred_Sector>();
        public Frm_Recibo()
        {
            InitializeComponent();
            iniciarElementos();
        }
        public void iniciarElementos()
        {

            periodo = periodos.GetAllMant_Periodo();
            cboPeriodo.DisplayMember = "Peric_canio";
            cboPeriodo.ValueMember = "Peric_canio";
            cboPeriodo.DataSource = periodo;

            mesese = mess.listartodos();
            cboMesIni.DisplayMember = "mes";
            cboMesIni.ValueMember = "mes_ID";
            cboMesIni.DataSource = mesese;

            cboMesFin.DisplayMember = "mes";
            cboMesFin.ValueMember = "mes_ID";
            cboMesFin.DataSource = mesese;
            
            cboAnioC.DisplayMember = "Peric_canio";
            cboAnioC.ValueMember = "Peric_canio";
            cboAnioC.DataSource = periodo;
            
            cboMesIniC.DisplayMember = "mes";
            cboMesIniC.ValueMember = "mes_ID";
            cboMesIniC.DataSource = mesese;

            cboMesFinC.DisplayMember = "mes";
            cboMesFinC.ValueMember = "mes_ID";
            cboMesFinC.DataSource = mesese;

            cboGrupoEmision.DisplayMember = "Multc_vDescripcion";
            cboGrupoEmision.ValueMember = "Multc_cValor";
            cboGrupoEmision.DataSource = tablas.GetCboConf_Multitabla("77");
            
            listaSec.AddRange( pred_SectorDataService.listarSectorCboValidos());

            cboSector.DisplayMember = "descripcion";
            cboSector.ValueMember = "sector_id";
            cboSector.DataSource = listaSec;

            this.tabControl2.Controls.Clear();
            this.tabControl2.Controls.Add(this.tabListaSector);
        }
        private void cboMesIni_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cantidad;
            cantidad = mesese.Count;
            List<Mes> mes2 = new List<Mes>();
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
            cboMesFin.DisplayMember = "mes";
            cboMesFin.ValueMember = "mes_ID";
            cboMesFin.DataSource = mes2;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tabControl2.Controls.Clear();
            switch (Convert.ToString(tabControl1.SelectedTab.Name))
            {
                case "tp1":
                    this.tabControl2.Controls.Add(this.tabListaSector);
                    break;
                case "tp2":
                    this.tabControl2.Controls.Add(this.tabListaContr);
                    break;
                //case "tp3":
                //    this.tabControl2.Controls.Add(this.tabListaAvanzado);
                //    break;
                //case "tp4":
                //    this.tabControl2.Controls.Add(this.tabListaMensajes);
                //    break;
            }
            
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try {
                dataGridView2.DataSource = reciboDS.listarTodos((Convert.ToString((Int32)cboSector.SelectedValue)),
                    (Int32)cboPeriodo.SelectedValue, Convert.ToInt32((string)cboMesIni.SelectedValue),
                    Convert.ToInt32((string)cboMesFin.SelectedValue),(string)cboGrupoEmision.SelectedValue);

                int cantidad;
                int total = 0,emitidos=0,pendientes=0, m1,m2,m3;
                cantidad = dataGridView2.RowCount;
                for (int i = 0; i < cantidad; i++)
                {
                    m1 = (int)dataGridView2.Rows[i].Cells["xtotal"].Value;                    
                    m2 = (int)dataGridView2.Rows[i].Cells["xemitidos"].Value;
                    m3 = (int)dataGridView2.Rows[i].Cells["xpendientes"].Value;
                    total = total + m1;
                    emitidos = emitidos + m2;
                    pendientes = pendientes + m3;
                }
                lblTotal.Text = Convert.ToString(total);
                lblEmitido.Text = Convert.ToString(emitidos);
                lblPendiente.Text = Convert.ToString(pendientes);
                if (emitidos > 0)
                    chkAnular.Visible = true;
                else chkAnular.Visible = false;
            }
            catch(Exception ex)
            {

            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                int valor=0;
                if (chkAnular.Visible && chkAnular.Checked) valor = 1;
                reciboDS.generarRecibosTotal((Convert.ToString((Int32)cboSector.SelectedValue)),
                    (Int32)cboPeriodo.SelectedValue, Convert.ToInt32((string)cboMesIni.SelectedValue),
                    Convert.ToInt32((string)cboMesFin.SelectedValue),valor);
                MessageBox.Show("Generación Correcta",Globales.Global_MessageBox );
                                
                    dataGridView2.DataSource = reciboDS.listarTodos((Convert.ToString((Int32)cboSector.SelectedValue)),
                        (Int32)cboPeriodo.SelectedValue, Convert.ToInt32((string)cboMesIni.SelectedValue),
                        Convert.ToInt32((string)cboMesFin.SelectedValue), (string)cboGrupoEmision.SelectedValue);

                    int cantidad;
                    int total = 0, emitidos = 0, pendientes = 0, m1, m2, m3;
                    cantidad = dataGridView2.RowCount;
                    for (int i = 0; i < cantidad; i++)
                    {
                        m1 = (int)dataGridView2.Rows[i].Cells["xtotal"].Value;
                        m2 = (int)dataGridView2.Rows[i].Cells["xemitidos"].Value;
                        m3 = (int)dataGridView2.Rows[i].Cells["xpendientes"].Value;
                        total = total + m1;
                        emitidos = emitidos + m2;
                        pendientes = pendientes + m3;
                    }
                    lblTotal.Text = Convert.ToString(total);
                    lblEmitido.Text = Convert.ToString(emitidos);
                    lblPendiente.Text = Convert.ToString(pendientes);
                    if (emitidos > 0)
                        chkAnular.Visible = true;
                    else chkAnular.Visible = false;
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar los recibos", Globales.Global_MessageBox);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                List<string> respuesta= reciboDS.descripcionContribuyente(txtContribuyente.Text,
                     (Int32)cboPeriodo.SelectedValue, Convert.ToInt32((string)cboMesIni.SelectedValue),
                    Convert.ToInt32((string)cboMesFin.SelectedValue));
                if (respuesta.Count > 0)
                {
                    lblContribuyente.Text = respuesta[0];
                    if (respuesta[1].Equals('0'))
                    {
                        lblDeuda.Visible = true;
                        lblDeuda.Text = "No existe deuda para el contribuyente indicado";
                        lblListar.Enabled = false;
                        lblContribuyente.Text = "";
                    }
                    else
                    {
                        lblDeuda.Visible = false;
                        lblDeuda.Text = "";
                        lblListar.Enabled = true;
                    }
                }
                else
                {
                    lblDeuda.Visible = true;
                    lblDeuda.Text = "No existe deuda para el contribuyente indicado";
                    lblListar.Enabled = false;
                    lblContribuyente.Text = "";
                }
            }
        }

        private void cboMesFin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboMesIniC_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cantidad;
            cantidad = mesese.Count;
            List<Mes> mes2 = new List<Mes>();
            for (int i = 0; i < cantidad; i++)
            {
                if (Convert.ToInt32(mesese[i].mes_ID) >= Convert.ToInt32(cboMesIniC.SelectedValue))
                {
                    Mes messssss = new Mes();
                    messssss.mes_ID = mesese[i].mes_ID;
                    messssss.mes = mesese[i].mes;
                    mes2.Add(messssss);
                }
            }
            cboMesFinC.DisplayMember = "mes";
            cboMesFinC.ValueMember = "mes_ID";
            cboMesFinC.DataSource = mes2;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                dataGridView1.DataSource = reciboDS.listarTodosDetalle(txtContribuyente.Text,
                    (Int32)cboPeriodo.SelectedValue, Convert.ToInt32((string)cboMesIniC.SelectedValue),
                    Convert.ToInt32((string)cboMesFinC.SelectedValue));
                if (dataGridView1.RowCount > 0)
                    chkAnularC.Visible = true;
                else chkAnularC.Visible = false;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_ReciboDetalle frmReciboDetalle = new Frm_ReciboDetalle();
            frmReciboDetalle.StartPosition = FormStartPosition.CenterParent;
            frmReciboDetalle.ShowDialog();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                int valor = 0;
                if (chkAnular.Visible && chkAnular.Checked) valor = 1;
                 reciboDS.generarRecibosDetalle(txtContribuyente.Text,
                     (Int32)cboPeriodo.SelectedValue, Convert.ToInt32((string)cboMesIniC.SelectedValue),
                     Convert.ToInt32((string)cboMesFinC.SelectedValue),valor);
                MessageBox.Show("Generación Correcta", Globales.Global_MessageBox);
                    dataGridView1.DataSource = reciboDS.listarTodosDetalle(txtContribuyente.Text,
                        (Int32)cboAnioC.SelectedValue, Convert.ToInt32((string)cboMesIniC.SelectedValue),
                        Convert.ToInt32((string)cboMesFinC.SelectedValue));
                    if (dataGridView1.RowCount > 0)
                        chkAnularC.Visible = true;
                    else chkAnularC.Visible = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar los recibos", Globales.Global_MessageBox);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void cboMesFinC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tp2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {

                if (dataGridView2.Columns[e.ColumnIndex].Name == "ximprimir")
                {
                    if (MessageBox.Show("Confirma Impresión de Recibos?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        List<Reci_ReciboDetalle> datos = new List<Reci_ReciboDetalle>();
                        string junta = Convert.ToString((Int32)dataGridView2.Rows[e.RowIndex].Cells["xSector_id"].Value);
                        int nroMes = (Int32)dataGridView2.Rows[e.RowIndex].Cells["xnromes"].Value;                        
                        datos = reciboDS.listarRecibosImpresion((Int32)cboPeriodo.SelectedValue, nroMes,
                    nroMes, junta,(string)cboGrupoEmision.SelectedValue);
                        for (int i = 0; i < datos.Count; i++)

                        {
                            var coleccion = new List<Reci_ReciboDetalleReporte>();
                            coleccion = reciboDS.cargarRecibo(datos[i].anio, datos[i].codigo,Convert.ToInt32(datos[i].mes), datos[i].persona);
                            Frm_Visor_Global frmVisor = new Frm_Visor_Global();
                            frmVisor.reportViewer1.LocalReport.DataSources.Clear();
                            frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._4_Procesos.Recibo.rptEmisionRecibo.rdlc";
                            frmVisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("recibo", coleccion));
                            ReportParameter[] param = new ReportParameter[3];
                            param[0] = new ReportParameter("Empresa", Globales.NombreEmpresa);
                            param[1] = new ReportParameter("RucEmpresa", Globales.RucEmpresa);
                            param[2] = new ReportParameter("persona", datos[i].persona);
                            frmVisor.reportViewer1.LocalReport.SetParameters(param);

                            

                            frmVisor.reportViewer1.RefreshReport();
                            frmVisor.StartPosition = FormStartPosition.CenterParent;
                            frmVisor.ShowDialog();
                        }
                        //var coleccion = new List<Liqu_Deuda>();
                        //coleccion = Liqui_LiquidacionDataService.verificarLiquidacio("1");
                        //Frm_Visor_Global frmVisor = new Frm_Visor_Global();
                        //frmVisor.reportViewer1.LocalReport.DataSources.Clear();
                        //frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._4_Procesos.Recibo.rptEmisionRecibo.rdlc";
                        //frmVisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", coleccion));
                        //ReportParameter[] param = new ReportParameter[11];
                        //param[0] = new ReportParameter("Empresa", Globales.NombreEmpresa);
                        //param[1] = new ReportParameter("NoPago", " ");
                        //param[2] = new ReportParameter("Codigo", " ");
                        //param[3] = new ReportParameter("Periodo", "2016");
                        //param[4] = new ReportParameter("Nombre", "o");
                        //param[5] = new ReportParameter("Domicilio", "o");
                        //param[6] = new ReportParameter("Lugar", " ");
                        //param[7] = new ReportParameter("FVencimiento", "21/07/2016");
                        //param[8] = new ReportParameter("DireccionEmpresa", " ");
                        //param[9] = new ReportParameter("Telefono", " ");
                        //param[10] = new ReportParameter("Horario", " ");
                        //frmVisor.reportViewer1.LocalReport.SetParameters(param);
                        //frmVisor.reportViewer1.RefreshReport();
                        //frmVisor.StartPosition = FormStartPosition.CenterParent;
                        //frmVisor.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
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

        private void Frm_Recibo_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {

                if (dataGridView1.Columns[e.ColumnIndex].Name == "ximprimir1")
                    
                {
                    if (MessageBox.Show("Confirma Impresión de Recibo?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        List<Reci_ReciboDetalle> datos = new List<Reci_ReciboDetalle>();
                        int nroMes = (Int32)dataGridView1.Rows[e.RowIndex].Cells["nromes"].Value; 
                        int anio = (Int32)dataGridView1.Rows[e.RowIndex].Cells["xanioc"].Value; 
                        int recibo = (Int32)dataGridView1.Rows[e.RowIndex].Cells["xcodigo"].Value;
                        string persona_ID = txtContribuyente.Text;                     
                            var coleccion = new List<Reci_ReciboDetalleReporte>();
                            coleccion = reciboDS.cargarRecibo(anio, recibo, nroMes,persona_ID);
                            Frm_Visor_Global frmVisor = new Frm_Visor_Global();
                            frmVisor.reportViewer1.LocalReport.DataSources.Clear();
                            frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._4_Procesos.Recibo.rptEmisionRecibo.rdlc";
                            frmVisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("recibo", coleccion));
                            ReportParameter[] param = new ReportParameter[3];
                            param[0] = new ReportParameter("Empresa", Globales.NombreEmpresa);
                            param[1] = new ReportParameter("RucEmpresa", Globales.RucEmpresa);
                            param[2] = new ReportParameter("persona", persona_ID);
                            frmVisor.reportViewer1.LocalReport.SetParameters(param);



                            frmVisor.reportViewer1.RefreshReport();
                            frmVisor.StartPosition = FormStartPosition.CenterParent;
                            frmVisor.ShowDialog();
                        //var coleccion = new List<Liqu_Deuda>();
                        //coleccion = Liqui_LiquidacionDataService.verificarLiquidacio("1");
                        //Frm_Visor_Global frmVisor = new Frm_Visor_Global();
                        //frmVisor.reportViewer1.LocalReport.DataSources.Clear();
                        //frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._4_Procesos.Recibo.rptEmisionRecibo.rdlc";
                        //frmVisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", coleccion));
                        //ReportParameter[] param = new ReportParameter[11];
                        //param[0] = new ReportParameter("Empresa", Globales.NombreEmpresa);
                        //param[1] = new ReportParameter("NoPago", " ");
                        //param[2] = new ReportParameter("Codigo", " ");
                        //param[3] = new ReportParameter("Periodo", "2016");
                        //param[4] = new ReportParameter("Nombre", "o");
                        //param[5] = new ReportParameter("Domicilio", "o");
                        //param[6] = new ReportParameter("Lugar", " ");
                        //param[7] = new ReportParameter("FVencimiento", "21/07/2016");
                        //param[8] = new ReportParameter("DireccionEmpresa", " ");
                        //param[9] = new ReportParameter("Telefono", " ");
                        //param[10] = new ReportParameter("Horario", " ");
                        //frmVisor.reportViewer1.LocalReport.SetParameters(param);
                        //frmVisor.reportViewer1.RefreshReport();
                        //frmVisor.StartPosition = FormStartPosition.CenterParent;
                        //frmVisor.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
    }
}
