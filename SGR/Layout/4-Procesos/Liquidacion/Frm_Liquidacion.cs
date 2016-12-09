using DgvFilterPopup;
using SGR.Core.Service;
using SGR.Core;
using SGR.Entity;
using System;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using SGR.WinApp.Layout._5_Reportes_Gestion;
using SGR.Entity.Model;
using System.Collections.Generic;
using Microsoft.Reporting.WinForms;
using System.Drawing.Printing;
using System.Drawing.Imaging;
using System.IO;
using System.Drawing;
using System.Text;

namespace SGR.WinApp.Layout._4_Procesos.Liquidacion
{
    public partial class Frm_Liquidacion : Form
    {

        private int m_currentPageIndex;
        private IList<Stream> m_streams;

        private Liqu_DeudaDataService Liqu_Deuda = new Liqu_DeudaDataService();
        private Mant_ContribuyenteDataService mant_Contribuyente = new Mant_ContribuyenteDataService();
        private Mant_Contribuyente contribuyente = new Mant_Contribuyente();
        private Liqu_LiquidacionDataService liquidacionService = new Liqu_LiquidacionDataService();
        private string persona_cod;
        string nombres, documento, persona, direccCompleta;
        public Frm_Liquidacion()
        {
            InitializeComponent();
        }
        public Frm_Liquidacion(string nombres, string documento, string persona, string direccCompleta)
        {
            InitializeComponent();
            this.nombres = nombres;
            this.documento = documento;
            this.persona = persona;
            this.direccCompleta = direccCompleta;
            inicializar(nombres, documento, persona, direccCompleta);
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("El contribuyente seleccionado no tiene deuda pendiente", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        public void inicializar(string nombres, string documento, string persona, string direccCompleta)
        {
            persona_cod = persona;
            lblCodigo.Text = persona;
            lblDireccion.Text = direccCompleta;
            lblDocumento.Text = documento;
            lblNombre.Text = nombres.TrimEnd();
            llenarGrillas();
        }
        public void llenarGrillas()
        {
            dataGridView1.DataSource = Liqu_Deuda.listartodos(persona_cod);
            dataGridView2.DataSource = liquidacionService.listartodos(persona_cod);
            calcularTotales();
        }
        private void Frm_Liquidacion_Load(object sender, EventArgs e)
        {

        }
        public void calcularTotales()
        {
            int cantidad;
            decimal montoTotal = 0,montoTotalVencido=0, interes = 0, montoTotalFinal = 0, m1, m2, m3,m4;
            cantidad = dataGridView1.RowCount;
            for (int i = 0; i < cantidad; i++)
            {
                m1 = (decimal)dataGridView1.Rows[i].Cells["xmonto"].Value;
                m2 = (decimal)dataGridView1.Rows[i].Cells["xinteres"].Value;
                m3 = (decimal)dataGridView1.Rows[i].Cells["xtotal"].Value;
                m4 = (decimal)dataGridView1.Rows[i].Cells["xdeudaVencida"].Value;
                montoTotal = montoTotal + m1;
                montoTotalVencido = montoTotalVencido + m4;
                interes = interes + m2;
                montoTotalFinal = montoTotalFinal + m3;
            }
            txtTotal.Text = Convert.ToString(montoTotal);
            txtInteres.Text = Convert.ToString(interes);
            txtTotalFinal.Text = Convert.ToString(montoTotalFinal);
            txtDeudaVencida.Text= Convert.ToString(montoTotalVencido);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "xverificar")
            {
                //MessageBox.Show("Verificar");
                if (Cursor.Current == Cursors.WaitCursor)
                    return;
                Cursor.Current = Cursors.WaitCursor;
                var coleccion = new List<Liqu_Deuda>();
                string persona, predio, grupo_trib;
                Liqu_Liquidacion elemento = new Liqu_Liquidacion();
                predio = (string)dataGridView1.Rows[e.RowIndex].Cells["xpredio"].Value;
                coleccion = liquidacionService.verificarLiquidacio2(lblCodigo.Text, predio);
                decimal deudaConsultada = 0;
                for(int i = 0; i < coleccion.Count; i++)
                {
                    deudaConsultada = deudaConsultada + coleccion[i].total;
                }
                grupo_trib = (string)dataGridView1.Rows[e.RowIndex].Cells["xtributo"].Value;
                Frm_Visor_Global frmVisor = new Frm_Visor_Global();
                frmVisor.reportViewer1.LocalReport.DataSources.Clear();
                frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._4_Procesos.Liquidacion.rptLiquidacionVerificacion.rdlc";
                frmVisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", coleccion));
                ReportParameter[] param = new ReportParameter[13];
                param[0] = new ReportParameter("Empresa", Globales.NombreEmpresa);
                param[1] = new ReportParameter("RucEmpresa", Globales.RucEmpresa);
                param[2] = new ReportParameter("Codigo", lblCodigo.Text);
                param[3] = new ReportParameter("DNI", lblDocumento.Text);
                param[4] = new ReportParameter("Nombres", lblNombre.Text);
                param[5] = new ReportParameter("Domicilio", lblDireccion.Text);
                param[6] = new ReportParameter("TipoEm", grupo_trib);
                param[7] = new ReportParameter("Predio", predio);
                param[8] = new ReportParameter("Ubicacion", " ");
                param[9] = new ReportParameter("TotalDeudaAnual", txtTotalFinal.Text);
                param[10] = new ReportParameter("DeudaVencida", txtDeudaVencida.Text);
                param[11] = new ReportParameter("DeudaConsultada", Convert.ToString(deudaConsultada));
                param[12] = new ReportParameter("Usuario", Globales.UsuarioPrueba);
                frmVisor.reportViewer1.LocalReport.SetParameters(param);
                frmVisor.reportViewer1.RefreshReport();
                frmVisor.StartPosition = FormStartPosition.CenterParent;
                frmVisor.ShowDialog();
            }
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "xdetalles")
            {
                try
                {
                    string persona, predio, grupo_trib;
                    Liqu_Liquidacion elemento = new Liqu_Liquidacion();
                    persona = (string)dataGridView1.Rows[e.RowIndex].Cells["xpersona"].Value;
                    predio = (string)dataGridView1.Rows[e.RowIndex].Cells["xpredio"].Value;
                    grupo_trib = (string)dataGridView1.Rows[e.RowIndex].Cells["xtributo"].Value;
                    Frm_LiquidacionDetalle Frm_LiquidDetalle = new Frm_LiquidacionDetalle(persona, predio, grupo_trib,
                        nombres, documento, persona, direccCompleta);
                    Frm_LiquidDetalle.StartPosition = FormStartPosition.CenterParent;
                    Frm_LiquidDetalle.ShowDialog();
                    dataGridView1.DataSource = Liqu_Deuda.listartodos(persona_cod);
                    dataGridView2.DataSource = liquidacionService.listartodos(persona_cod);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,  Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            var coleccion = new List<Liqu_Deuda>();
            coleccion = liquidacionService.verificarLiquidacio(lblCodigo.Text);
            Frm_Visor_Global frmVisor = new Frm_Visor_Global();
            frmVisor.reportViewer1.LocalReport.DataSources.Clear();
            frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._4_Procesos.Liquidacion.rptLiquidacionVerificacion.rdlc";
            frmVisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1",coleccion));
            ReportParameter[] param = new ReportParameter[13];
            param[0] = new ReportParameter("Empresa", Globales.NombreEmpresa);
            param[1] = new ReportParameter("RucEmpresa", Globales.RucEmpresa);
            param[2] = new ReportParameter("Codigo", lblCodigo.Text);
            param[3] = new ReportParameter("DNI", lblDocumento.Text);
            param[4] = new ReportParameter("Nombres", lblNombre.Text);
            param[5] = new ReportParameter("Domicilio", lblDireccion.Text);
            param[6] = new ReportParameter("TipoEm", "PRED+ARBITR");
            param[7] = new ReportParameter("Predio", "Todos");
            param[8] = new ReportParameter("Ubicacion", " ");
            param[9] = new ReportParameter("TotalDeudaAnual", txtTotalFinal.Text);
            param[10] = new ReportParameter("DeudaVencida", txtDeudaVencida.Text);
            param[11] = new ReportParameter("DeudaConsultada", txtTotal.Text);
            param[12] = new ReportParameter("Usuario", GlobalesV1.Global_str_Nombre);
            frmVisor.reportViewer1.LocalReport.SetParameters(param);
            
            
            frmVisor.reportViewer1.RefreshReport();
            frmVisor.StartPosition = FormStartPosition.CenterParent;
            frmVisor.ShowDialog();
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
                <PageWidth>8.5in</PageWidth>
                <PageHeight>11in</PageHeight>
                <MarginTop>0.25in</MarginTop>
                <MarginLeft>0.25in</MarginLeft>
                <MarginRight>0.25in</MarginRight>
                <MarginBottom>0.25in</MarginBottom>
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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (MessageBox.Show("Confirmar Liquidación de Deuda?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) { 
            
                    Liqu_Liquidacion elemento = new Liqu_Liquidacion();
                    elemento.estado = "P";
                    elemento.tipo = "1";
                    elemento.Intereses = Convert.ToDecimal(txtInteres.Text);
                    elemento.importe = Convert.ToDecimal(txtTotal.Text);
                    elemento.Persona_id = persona_cod;
                    elemento.registro_user_add = GlobalesV1.Global_str_Usuario;
                    int resultado = liquidacionService.Insert(elemento);
                    if (resultado != 0)
                        liquidacionService.InsertarDetalles(resultado, persona_cod);
                    liquidacionService.modificarEstadoFinal(resultado);
                    llenarGrillas();
                    MessageBox.Show("Liquidación Generada Correctamente", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al realizar Liquidación", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
}

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                Frm_LiquidacionTotalDetalle Frm_LiquidDetalle = new Frm_LiquidacionTotalDetalle(persona_cod, documento, 
                    nombres, direccCompleta, Convert.ToDecimal(txtTotalFinal.Text), Convert.ToDecimal(txtDeudaVencida.Text));
                Frm_LiquidDetalle.StartPosition = FormStartPosition.CenterParent;
                Frm_LiquidDetalle.ShowDialog();
                llenarGrillas();
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (dataGridView2.Columns[e.ColumnIndex].Name == "xanular")
            {
                if (MessageBox.Show("Desea Anular el registro?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    
                        int liquidacion_ID = (Int32)dataGridView2.Rows[e.RowIndex].Cells["xliquidacion"].Value;
                        if (liquidacionService.eliminarLiquidacion(liquidacion_ID))
                            MessageBox.Show("Se Anulo Correctamente", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Error al Anular", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView2.DataSource = liquidacionService.listartodos(persona_cod);
                    }
                    
                }
                if (dataGridView2.Columns[e.ColumnIndex].Name == "ximprimir")
                {
                    //if (Cursor.Current == Cursors.WaitCursor)
                    //    return;
                    //Cursor.Current = Cursors.WaitCursor;
                    var coleccion = new List<Liqu_Deuda>();
                    int liquidacion_ID = (Int32)dataGridView2.Rows[e.RowIndex].Cells["xliquidacion"].Value;
                    coleccion = liquidacionService.mostrarLiquidacion(liquidacion_ID);
                    decimal total = 0, interes = 0;
                    for(int i = 0; i < coleccion.Count; i++)
                    {
                        total = total + coleccion[i].monto;
                        interes = interes + coleccion[i].interes;
                    }
                    Frm_Visor_Global frmVisor = new Frm_Visor_Global();
                    frmVisor.reportViewer1.LocalReport.DataSources.Clear();
                    frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._4_Procesos.Liquidacion.rptLiquidacionDetalle.rdlc";
                    frmVisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", coleccion));
                    ReportParameter[] param = new ReportParameter[14];
                    param[0] = new ReportParameter("Empresa", Globales.NombreEmpresa);
                    param[1] = new ReportParameter("RucEmpresa", Globales.RucEmpresa);
                    param[2] = new ReportParameter("Codigo", lblCodigo.Text);
                    param[3] = new ReportParameter("DNI", lblDocumento.Text);
                    param[4] = new ReportParameter("Nombres", lblNombre.Text);                    
                    param[5] = new ReportParameter("TipoEm", "PRED+ARBITR");
                    param[6] = new ReportParameter("Domicilio", lblDireccion.Text);
                    param[7] = new ReportParameter("Predio", "Todos");
                    param[8] = new ReportParameter("Ubicacion", " ");
                    param[9] = new ReportParameter("total", Convert.ToString(total));
                    param[10] = new ReportParameter("TotalIntereses", Convert.ToString(interes));
                    param[11] = new ReportParameter("TotalLiquidar", Convert.ToString(interes+total));
                    param[12] = new ReportParameter("Usuario", GlobalesV1.Global_str_Nombre);
                    param[13] = new ReportParameter("liquidacion_ID",Convert.ToString(liquidacion_ID));
                    
                    frmVisor.reportViewer1.LocalReport.SetParameters(param);
                    frmVisor.reportViewer1.RefreshReport();
                    frmVisor.StartPosition = FormStartPosition.CenterParent;
                    frmVisor.ShowDialog();
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
