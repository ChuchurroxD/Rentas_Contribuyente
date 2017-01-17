using DgvFilterPopup;
using SGR.Core.Service;
using System.Collections.Generic;
using SGR.Core;
using SGR.Entity;
using System;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using SGR.Entity.Model;
using SGR.WinApp.Layout._5_Reportes_Gestion;
using Microsoft.Reporting.WinForms;

namespace SGR.WinApp.Layout._4_Procesos.Fraccionamiento.Fraccionamiento
{
    public partial class Frm_Fraccionamiento : Form
    {
        private Liqu_DeudaDataService Liqu_Deuda = new Liqu_DeudaDataService();
        private Mant_ContribuyenteDataService mant_Contribuyente = new Mant_ContribuyenteDataService();
        private Mant_Contribuyente contribuyente = new Mant_Contribuyente();
        private Frac_FraccionamientoDataService fraccionamiento = new Frac_FraccionamientoDataService();
        private string persona_cod;
        string nombres, documento, persona, direccCompleta;
        int mayor = 0;
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            String anio = dataGridView1.SelectedRows[0].Cells["xanio"].Value.ToString();                        
            Frm_FraccionamientoDetalles Frm_Liqui = new Frm_FraccionamientoDetalles(nombres, documento, persona, direccCompleta, anio, mayor);
            Frm_Liqui.StartPosition = FormStartPosition.CenterParent;
            Frm_Liqui.ShowDialog();
            dataGridView2.DataSource = fraccionamiento.listarFraccionamientos(persona_cod);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            Frac_FraccionamientoDetalle elemento = new Frac_FraccionamientoDetalle();
            Frm_Visor_Global frmvisor = new Frm_Visor_Global();
            try
            {
                elemento = fraccionamiento.obtenerFraccionamiento(4);
                List<Frac_Cronograma> coleccion = new List<Frac_Cronograma>();
                coleccion = fraccionamiento.listarCronograma(4); 
                frmvisor.reportViewer1.LocalReport.DataSources.Clear();
                frmvisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._4_Procesos.Fraccionamiento.Fraccionamiento.rptFraccionamiento.rdlc";
                frmvisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", coleccion));
                ReportParameter[] param = new ReportParameter[15];
                param[0] = new ReportParameter("Empresa", Globales.NombreEmpresa);
                //param[1] = new ReportParameter("Usuario", Globales.UsuarioPrueba);
                param[1] = new ReportParameter("Anio", "2015");
                param[2] = new ReportParameter("NombreRazonSocial", nombres);
                param[3] = new ReportParameter("DNI", documento);
                param[4] = new ReportParameter("Domicilio", direccCompleta);
                param[5] = new ReportParameter("DeudaTotal", elemento.Deuda_Total.ToString());
                param[6] = new ReportParameter("PagoInicial", elemento.Inicial.ToString());
                param[7] = new ReportParameter("SaldoFraccionable", elemento.Saldo.ToString());
                param[8] = new ReportParameter("DerechoFraccionamiento", "0");
                param[9] = new ReportParameter("ImporteCuotaMensual", elemento.ValorCuota.ToString());
                param[10] = new ReportParameter("TasaInteresMensual", elemento.Interes.ToString());
                param[11] = new ReportParameter("InteresCompensantorio", "0");
                param[12] = new ReportParameter("NroCuotas", elemento.Cuotas.ToString());
                param[13] = new ReportParameter("FechaSuscripcion", elemento.Fecha_Acogida.ToString());
                param[14] = new ReportParameter("PeriodoFraccionado", elemento.anio_inicio.ToString() + "-" + elemento.anio_fin.ToString());
                
                frmvisor.reportViewer1.LocalReport.SetParameters(param);

                frmvisor.reportViewer1.RefreshReport();
                frmvisor.StartPosition = FormStartPosition.CenterScreen;
                frmvisor.ShowDialog();
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

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (dataGridView2.Columns[e.ColumnIndex].Name == "xvisualizar")
                {
                    int fraccionamiento_ID = (Int32)dataGridView2.Rows[e.RowIndex].Cells["xfraccionamiento_id"].Value;
                    Frac_FraccionamientoDetalle elemento = new Frac_FraccionamientoDetalle();
                    Frm_Visor_Global frmvisor = new Frm_Visor_Global();                   
                    elemento = fraccionamiento.obtenerFraccionamiento(fraccionamiento_ID);
                    List<Frac_Cronograma> coleccion = new List<Frac_Cronograma>();
                    coleccion = fraccionamiento.listarCronograma(fraccionamiento_ID);
                    frmvisor.reportViewer1.LocalReport.DataSources.Clear();
                    frmvisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._4_Procesos.Fraccionamiento.Fraccionamiento.rptFraccionamiento.rdlc";
                    frmvisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", coleccion));
                    ReportParameter[] param = new ReportParameter[15];
                    param[0] = new ReportParameter("Empresa", Globales.NombreEmpresa);
                    //param[1] = new ReportParameter("Usuario", Globales.UsuarioPrueba);
                    param[1] = new ReportParameter("Anio", "2015");
                    param[2] = new ReportParameter("NombreRazonSocial", nombres);
                    param[3] = new ReportParameter("DNI", documento);
                    param[4] = new ReportParameter("Domicilio", direccCompleta);
                    param[5] = new ReportParameter("DeudaTotal", elemento.Deuda_Total.ToString());
                    param[6] = new ReportParameter("PagoInicial", elemento.Inicial.ToString());
                    param[7] = new ReportParameter("SaldoFraccionable", elemento.Saldo.ToString());
                    param[8] = new ReportParameter("DerechoFraccionamiento", "0");
                    param[9] = new ReportParameter("ImporteCuotaMensual", elemento.ValorCuota.ToString());
                    param[10] = new ReportParameter("TasaInteresMensual", elemento.Interes.ToString());
                    param[11] = new ReportParameter("InteresCompensantorio", "0");
                    param[12] = new ReportParameter("NroCuotas", elemento.Cuotas.ToString());
                    param[13] = new ReportParameter("FechaSuscripcion", elemento.Fecha_Acogida.ToString());
                    param[14] = new ReportParameter("PeriodoFraccionado", elemento.anio_inicio.ToString() + "-" + elemento.anio_fin.ToString());
                    frmvisor.reportViewer1.LocalReport.SetParameters(param);
                    frmvisor.reportViewer1.RefreshReport();
                    frmvisor.StartPosition = FormStartPosition.CenterScreen;
                    frmvisor.ShowDialog();
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        public Frm_Fraccionamiento(string nombres, string documento, string persona, string direccCompleta)
        {
            InitializeComponent();
            this.nombres = nombres;
            this.documento = documento;
            this.persona = persona;
            this.direccCompleta = direccCompleta;
            inicializar(nombres, documento, persona, direccCompleta);
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("El contribuyente seleccionado no tiene deuda pendiente");
                this.Close();
            }
            //this.xpersona_ID.Visible = true;
            //if (dataGridView1.RowCount == 0)
            //{
            //    MessageBox.Show("El contribuyente seleccionado no tiene algún predio asociado");
            //    this.Close();
            //}
        }
        public void inicializar(string nombres, string documento, string persona, string direccCompleta)
        {
            persona_cod = persona;
            lblCodigo.Text = persona;
            lblDireccion.Text = direccCompleta;
            lblDocumento.Text = documento;
            lblNombre.Text = nombres.TrimEnd();
            List<Frac_Fraccionamiento> coleccion = new List<Frac_Fraccionamiento>();
            coleccion = fraccionamiento.listartodos(persona_cod);
            for (int i=0;i<coleccion.Count; i++)
            {
                if(coleccion[i].predial>0)
                    this.xpredial.Visible = true;
                if (coleccion[i].arbitrios > 0)
                    this.xarbitrios.Visible = true;
                if (coleccion[i].alcabala > 0)
                    this.xalcabala.Visible = true;
                if (coleccion[i].multas > 0)
                    this.xmultas.Visible = true;
                if (coleccion[i].fincas > 0)
                    this.xfincas.Visible = true;
                if (coleccion[i].alquileres > 0)
                    this.xalquileres.Visible = true;
                if (coleccion[i].tasas > 0)
                    this.xtasas.Visible = true;
                if(coleccion[i].predialI > 0)
                    this.xpredialI.Visible = true;
                if (coleccion[i].arbitriosI > 0)
                    this.xarbitriosI.Visible = true;
                if (coleccion[i].alcabalaI > 0)
                    this.xalcabalaI.Visible = true;
                if (coleccion[i].multasI > 0)
                    this.xmultasI.Visible = true;
                if (coleccion[i].fincasI > 0)
                    this.xfincasI.Visible = true;
                if (coleccion[i].alquileresI > 0)
                    this.xalquileresI.Visible = true;
                if (coleccion[i].tasasI > 0)
                    this.xtasasI.Visible = true;
            }            
            dataGridView1.DataSource = coleccion;
            
            foreach (Frac_Fraccionamiento frac in coleccion)
            {
                if(mayor<=frac.anio)
                {
                    mayor = frac.anio;
                }
            }
            dataGridView2.DataSource = fraccionamiento.listarFraccionamientos(persona_cod);
            calcularTotales();
        }
        public void calcularTotales()
        {
            int cantidad;
            decimal montoTotal = 0, m1;
            cantidad = dataGridView1.RowCount;
            for (int i = 0; i < cantidad; i++)
            {
                m1 = (decimal)dataGridView1.Rows[i].Cells["xtotal"].Value;
                montoTotal = montoTotal + m1;
            }
            txtTotal.Text = Convert.ToString(montoTotal);
        }
    }
}
