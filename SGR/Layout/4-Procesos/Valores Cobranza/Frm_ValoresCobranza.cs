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
using System.IO;
using Microsoft.Reporting.WinForms;

namespace SGR.WinApp.Layout._4_Procesos.Valores_Cobranza
{
    public partial class Frm_ValoresCobranza : DockContent
    {
        List<Valo_ListadoDeudores> coleccion2 = new List<Valo_ListadoDeudores>();
        List<Valo_ValoresCobranza> coleccion = new List<Valo_ValoresCobranza>();
        private Mant_PeriodoDataService periodos = new Mant_PeriodoDataService();
        private List<Mant_Periodo> periodo = new List<Mant_Periodo>();
        private List<Mant_Periodo> periodo2 = new List<Mant_Periodo>();
        RepoValoresCobranzaDataService operaciones = new RepoValoresCobranzaDataService();
        Pago_PersonaDataService persona = new Pago_PersonaDataService();
        private Conf_MultitablaDataService tablas = new Conf_MultitablaDataService();
        List<Pred_Sector> listaSec = new List<Pred_Sector>();
        Pred_SectorDataService pred_SectorDataService = new Pred_SectorDataService();
        Valo_ValoresCobranzaDataService valo_ValoresDataService = new Valo_ValoresCobranzaDataService();
        public Frm_ValoresCobranza()
        {
            InitializeComponent();
            cargarCombos();
            this.grupo1.Controls.Clear();
        }
        public void cargarCombos()
        {
            listaSec.AddRange(pred_SectorDataService.listarSectorCboValidos());
            cboSector.DisplayMember = "descripcion";
            cboSector.ValueMember = "sector_id";
            cboSector.DataSource = listaSec;

            cboSectorImpresion.DisplayMember = "descripcion";
            cboSectorImpresion.ValueMember = "sector_id";
            cboSectorImpresion.DataSource = listaSec;

            cboSector2.DisplayMember = "descripcion";
            cboSector2.ValueMember = "sector_id";
            cboSector2.DataSource = listaSec;

            periodo = periodos.GetAllMant_Periodo();
            periodo2 = periodos.GetAllMant_Periodo();
            cboAnioIni.DisplayMember = "Peric_canio";
            cboAnioIni.ValueMember = "Peric_canio";
            cboAnioIni.DataSource = periodos.GetAllMant_Periodo();

            cboAnioFin.DisplayMember = "Peric_canio";
            cboAnioFin.ValueMember = "Peric_canio";
            cboAnioFin.DataSource = periodos.GetAllMant_Periodo();

            cboAnioIni2.DisplayMember = "Peric_canio";
            cboAnioIni2.ValueMember = "Peric_canio";
            cboAnioIni2.DataSource = periodos.GetAllMant_Periodo();

            cboAnioFin2.DisplayMember = "Peric_canio";
            cboAnioFin2.ValueMember = "Peric_canio";
            cboAnioFin2.DataSource = periodos.GetAllMant_Periodo();

            cboPeriodoIni.DisplayMember = "Peric_canio";
            cboPeriodoIni.ValueMember = "Peric_canio";
            cboPeriodoIni.DataSource = periodos.GetAllMant_Periodo();

            cboPeriodoFin.DisplayMember = "Peric_canio";
            cboPeriodoFin.ValueMember = "Peric_canio";
            cboPeriodoFin.DataSource = periodos.GetAllMant_Periodo();

            cboPeriodoHasta.DisplayMember = "Peric_canio";
            cboPeriodoHasta.ValueMember = "Peric_canio";
            cboPeriodoHasta.DataSource = periodos.GetAllMant_Periodo();

            cboPeriodoDesde.DisplayMember = "Peric_canio";
            cboPeriodoDesde.ValueMember = "Peric_canio";
            cboPeriodoDesde.DataSource = periodos.GetAllMant_Periodo();
        }

        private void cboAnioIni_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cantidad;
            cantidad = periodo.Count;
            List<Mant_Periodo> periodo2_ = new List<Mant_Periodo>();

            for (int i = 0; i < cantidad; i++)
            {
                if (Convert.ToInt32(periodo[i].Peric_canio) >= Convert.ToInt32(cboAnioIni.SelectedValue))
                {
                    Mant_Periodo peri = new Mant_Periodo();
                    peri.Peric_canio = periodo[i].Peric_canio;
                    periodo2_.Add(peri);
                }
            }
            cboAnioFin.DisplayMember = "Peric_canio";
            cboAnioFin.ValueMember = "Peric_canio";
            cboAnioFin.DataSource = periodo2;
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            try
            {
                lblSector1.Text = cboSector.Text;
                lblAnio1.Text = cboAnioIni.Text + " - " + cboAnioFin.Text;
                lblDeuda1.Text = txtMontoMin.Text + " - " + txtMontoMax.Text;
                int anio1 = 0, anio2 = 0, anio3 = 0, anio4 = 0;
                if (checkBox2.Checked)
                {
                    anio1 = (Int32)cboAnioIni.SelectedValue;
                    anio2 = (Int32)cboAnioFin.SelectedValue;
                }
                if (checkBox3.Checked)
                {
                    anio3 = (Int32)cboAnioIni2.SelectedValue;
                    anio4 = (Int32)cboAnioFin2.SelectedValue;
                }
                coleccion = valo_ValoresDataService.listarMonto((Int32)cboSector.SelectedValue, anio1,
                    anio2, anio3, anio4, Convert.ToDecimal(txtMontoMin.Text), Convert.ToDecimal(txtMontoMax.Text));
                dgvMonto.DataSource = coleccion;

                cboTipoValor.DisplayMember = "Multc_vDescripcion";
                cboTipoValor.ValueMember = "Multc_cValor";
                cboTipoValor.DataSource = valo_ValoresDataService.listarTipos();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.grupo1.Controls.Clear();
            this.grupo1.Controls.Add(this.tabMonto);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.grupo1.Controls.Clear();
            this.grupo1.Controls.Add(this.tabMorosidad);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.grupo1.Controls.Clear();
            this.grupo1.Controls.Add(this.tabContribuyente);
            cboTipoValor3.DisplayMember = "Multc_vDescripcion";
            cboTipoValor3.ValueMember = "Multc_cValor";
            cboTipoValor3.DataSource = valo_ValoresDataService.listarTipos();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.grupo1.Controls.Clear();
            this.grupo1.Controls.Add(this.tabImpresion);
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                valo_ValoresDataService.insertarValores((Int32)cboSector.SelectedValue, (Int32)cboAnioIni.SelectedValue,
                (Int32)cboAnioFin.SelectedValue, (Int32)cboAnioIni2.SelectedValue, (Int32)cboAnioFin2.SelectedValue,
                Convert.ToDecimal(txtMontoMin.Text), Convert.ToDecimal(txtMontoMax.Text),
                Convert.ToInt32((string)cboTipoValor.SelectedValue), GlobalesV1.Global_str_Usuario);
                MessageBox.Show("Valores Correctamente Generados", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboAnioIni2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cantidad;
            cantidad = periodo.Count;
            List<Mant_Periodo> periodo2_ = new List<Mant_Periodo>();

            for (int i = 0; i < cantidad; i++)
            {
                if (Convert.ToInt32(periodo2[i].Peric_canio) >= Convert.ToInt32(cboAnioIni2.SelectedValue))
                {
                    Mant_Periodo peri = new Mant_Periodo();
                    peri.Peric_canio = periodo2[i].Peric_canio;
                    periodo2_.Add(peri);
                }
            }
            cboAnioFin2.DisplayMember = "Peric_canio";
            cboAnioFin2.ValueMember = "Peric_canio";
            cboAnioFin2.DataSource = periodo2_;
        }

        private void lblAnio1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void cboPeriodoIni_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cantidad;
            cantidad = periodo.Count;
            List<Mant_Periodo> periodo2_ = new List<Mant_Periodo>();

            for (int i = 0; i < cantidad; i++)
            {
                if (Convert.ToInt32(periodo[i].Peric_canio) >= Convert.ToInt32(cboPeriodoIni.SelectedValue))
                {
                    Mant_Periodo peri = new Mant_Periodo();
                    peri.Peric_canio = periodo[i].Peric_canio;
                    periodo2_.Add(peri);
                }
            }
            cboPeriodoFin.DisplayMember = "Peric_canio";
            cboPeriodoFin.ValueMember = "Peric_canio";
            cboPeriodoFin.DataSource = periodo2;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            cboAnioIni.Enabled = checkBox2.Checked;
            cboAnioFin.Enabled = checkBox2.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            cboAnioIni2.Enabled = checkBox3.Checked;
            cboAnioFin2.Enabled = checkBox3.Checked;
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            coleccion2 = valo_ValoresDataService.listarMorosidad((Int32)cboSector2.SelectedValue,
                    (Int32)cboPeriodoIni.SelectedValue, (Int32)cboPeriodoFin.SelectedValue, Convert.ToInt32(txtNumero.Text));
            dataGridView1.DataSource = coleccion2;
            cboTipoValor2.DisplayMember = "Multc_vDescripcion";
            cboTipoValor2.ValueMember = "Multc_cValor";
            cboTipoValor2.DataSource = valo_ValoresDataService.listarTipos();
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dataGridView1.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                valo_ValoresDataService.insertarValores2((Int32)cboSector2.SelectedValue, (Int32)cboPeriodoIni.SelectedValue,
                (Int32)cboPeriodoFin.SelectedValue, Convert.ToInt32((string)cboTipoValor2.SelectedValue), GlobalesV1.Global_str_Usuario,
                Convert.ToInt32(txtNumero.Text));
                MessageBox.Show("Valores Correctamente Generados", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabMorosidad_Click(object sender, EventArgs e)
        {

        }
        private void listarPersonaN(String predio_id, string busqueda)
        {
            cboPersona.DisplayMember = "persona_Desc";
            cboPersona.ValueMember = "persona_ID";
            cboPersona.DataSource = persona.listarcontribuyentesPN(predio_id, 0, busqueda); ;
            this.cboPersona.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.cboPersona.AutoCompleteSource = AutoCompleteSource.CustomSource;

            cboContri.DisplayMember = "persona_Desc";
            cboContri.ValueMember = "persona_ID";
            cboContri.DataSource = persona.listarcontribuyentesPN(predio_id, 0, busqueda); ;
            this.cboContri.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.cboContri.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBusqueda.Text.TrimEnd().Length != 0)
                {
                    cboPersona.Enabled = true;
                    listarPersonaN("", txtBusqueda.Text.TrimEnd());
                    //cboPersona.SelectedValue = persona_id;
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void cboPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<Mant_Periodo> coleccion = new List<Mant_Periodo>();
                coleccion = valo_ValoresDataService.listarPeriodos((string)cboPersona.SelectedValue);
                cboPeriodoValor.DisplayMember = "Peric_canio";
                cboPeriodoValor.ValueMember = "Peric_canio";
                cboPeriodoValor.DataSource = coleccion;
                if (coleccion.Count > 0)
                    cboPeriodoValor.Enabled = true;
                else
                    cboPeriodoValor.Enabled = true;
            }
            catch (Exception ex)
            {
                cboPeriodoValor.Enabled = true;
            }
        }

        private void cboPeriodoValor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<Valo_ValorTipoValor> coleccion = new List<Valo_ValorTipoValor>();
                coleccion = valo_ValoresDataService.listarValores((string)cboPersona.SelectedValue, (Int32)cboPeriodoValor.SelectedValue);
                cboValorGenerado.DisplayMember = "descripcion";
                cboValorGenerado.ValueMember = "valor_ID";
                cboValorGenerado.DataSource = coleccion;
                if (coleccion.Count > 0)
                    cboValorGenerado.Enabled = true;
                else
                    cboValorGenerado.Enabled = false;
            }
            catch (Exception ex)
            {
                cboValorGenerado.Enabled = false;
            }
        }
        public void impresionNotificacion(int notificacion, string persona)
        {
            try
            {
                List<RepoValoresCobranza> coleccionPersona = operaciones.datosContribuyente(notificacion);
                List<RepoValoresCobranza> documentosNotificados = operaciones.documentosNotificados(notificacion);
                Frm_Visor_Global frmVisor = new Frm_Visor_Global();
                frmVisor.reportViewer1.LocalReport.DataSources.Clear();
                frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._4_Procesos.Valores_Cobranza.rptDeterminacion1.rdlc";
                frmVisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsContribuyente", coleccionPersona));
                frmVisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsDocumentos", documentosNotificados));

                ReportParameter[] param = new ReportParameter[2];
                param[0] = new ReportParameter("AñoActual", "2016");
                param[1] = new ReportParameter("Documento", "0101");
                frmVisor.reportViewer1.LocalReport.SetParameters(param);
                frmVisor.reportViewer1.RefreshReport();
                frmVisor.StartPosition = FormStartPosition.CenterParent;
                frmVisor.ShowDialog();
            }
            catch (Exception ex)
            {

            }
        }
        public void impresionResolucionDeterminacion(int valor, string codigoPersona, int anio_valor, int nroNotificacion, int nroValor,
            int notificacion_ID, string mensaje, string baseLegal)
        {
            List<RepoValoresCobranza> coleccionPersona = operaciones.datosContribuyente(notificacion_ID);
            List<RepoValoresCobranza> liquidacionDatos = operaciones.liquidacionTributo(codigoPersona, anio_valor);
            List<RepoValoresCobranza> UITS = operaciones.detalleUIT(codigoPersona, anio_valor);
            List<RepoValoresCobranza> predios = operaciones.todosPrediosDeclarados(codigoPersona, anio_valor);

            Frm_Visor_Global frmVisor = new Frm_Visor_Global();
            frmVisor.reportViewer1.LocalReport.DataSources.Clear();
            frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._4_Procesos.Valores_Cobranza.rptDeterminacion2.rdlc";
            frmVisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsContribuyente", coleccionPersona));
            frmVisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsLiquidacion", liquidacionDatos));
            frmVisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsUITS", UITS));

            ReportParameter[] param2 = new ReportParameter[4];
            param2[0] = new ReportParameter("Año", Convert.ToString(anio_valor));
            param2[1] = new ReportParameter("valor", "Resolución de Determinación Nr°:" + Convert.ToString(nroValor) + "-" + Convert.ToString(anio_valor));
            param2[2] = new ReportParameter("mensaje", mensaje);
            param2[3] = new ReportParameter("baseLegal", baseLegal);
            frmVisor.reportViewer1.LocalReport.SetParameters(param2);
            frmVisor.reportViewer1.RefreshReport();
            frmVisor.StartPosition = FormStartPosition.CenterParent;
            frmVisor.ShowDialog();

            //Impresión Predios total
            frmVisor = new Frm_Visor_Global();
            frmVisor.reportViewer1.LocalReport.DataSources.Clear();
            frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._4_Procesos.Valores_Cobranza.rptDeterminacion3.rdlc";
            frmVisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsContribuyente", coleccionPersona));
            frmVisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsPredios", predios));

            ReportParameter[] param3 = new ReportParameter[3];
            param3[0] = new ReportParameter("Periodo", Convert.ToString(anio_valor));
            param3[1] = new ReportParameter("Valor", Convert.ToString(nroValor));
            param3[2] = new ReportParameter("CargoNotificacion", Convert.ToString(nroNotificacion));
            frmVisor.reportViewer1.LocalReport.SetParameters(param3);
            frmVisor.reportViewer1.RefreshReport();
            frmVisor.StartPosition = FormStartPosition.CenterParent;
            frmVisor.ShowDialog();

            //Impresión Predio

            for (int i = 0; i < predios.Count(); i++)
            {
                List<RepoValoresCobranza> predio = operaciones.predioDeclarado(predios[i].predio_id, anio_valor);
                List<RepoValoresCobranza> piso = operaciones.detallePisos(predios[i].predio_id, anio_valor);

                frmVisor = new Frm_Visor_Global();
                frmVisor.reportViewer1.LocalReport.DataSources.Clear();
                frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._4_Procesos.Valores_Cobranza.rptResolucionDeterminacionPredial.rdlc";
                frmVisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsContribuyente", coleccionPersona));
                frmVisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsPredio", predio));
                frmVisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsPiso", piso));

                ReportParameter[] param4 = new ReportParameter[3];
                param4[0] = new ReportParameter("Periodo", Convert.ToString(anio_valor));
                param4[1] = new ReportParameter("Valor", Convert.ToString(nroValor));
                param4[2] = new ReportParameter("CargoNotificacion", Convert.ToString(nroNotificacion));
                frmVisor.reportViewer1.LocalReport.SetParameters(param4);
                frmVisor.reportViewer1.RefreshReport();
                frmVisor.StartPosition = FormStartPosition.CenterParent;
                frmVisor.ShowDialog();
            }


        }
        public void impresionOrdenPago(string persona_ID, int anio_curso)
        {
            try
            {
                var coleccion = new List<Valo_OrdenPago>();
                coleccion = valo_ValoresDataService.generarReporte(anio_curso, persona_ID, "3");
                Frm_Visor_Global frmVisor = new Frm_Visor_Global();
                frmVisor.reportViewer1.LocalReport.DataSources.Clear();
                frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._4_Procesos.Valores_Cobranza.rptValoresCobranza.rdlc";
                frmVisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", coleccion));

                List<Frac_CuentaFraccionada> origen2 = new List<Frac_CuentaFraccionada>();
                Frac_CuentaFraccionada elementoo = new Frac_CuentaFraccionada();
                string _path = Path.Combine(Application.StartupPath, @"LogoCabecera.jpg");
                elementoo.logoEmpresa = File.ReadAllBytes(_path);
                elementoo.convenio = "convenio";
                origen2.Add(elementoo);
                ReportDataSource dataSourceEmpresa = new ReportDataSource("DataSet2", origen2);
                frmVisor.reportViewer1.LocalReport.DataSources.Add(dataSourceEmpresa);


                //ReportParameter[] param = new ReportParameter[1];
                //param[0] = new ReportParameter("Empresa", Globales.NombreEmpresa);
                //frmVisor.reportViewer1.LocalReport.SetParameters(param);
                frmVisor.reportViewer1.RefreshReport();
                frmVisor.StartPosition = FormStartPosition.CenterParent;
                frmVisor.ShowDialog();
            }
            catch (Exception ex)
            {

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string codigoPersona = (string)cboPersona.SelectedValue;
                int notificacion_id = (Int32)cboValorGenerado.SelectedValue;
                //impresionNotificacion(notificacion_id,codigoPersona);
                List<RepoValoresCobranza> coleccionPersona = operaciones.datosContribuyente(notificacion_id);
                List<RepoValoresCobranza> documentosNotificados = operaciones.documentosNotificados((Int32)cboValorGenerado.SelectedValue);
                List<Valo_ValoresCobranzaReporte> listaValores = operaciones.listarValores((Int32)cboValorGenerado.SelectedValue);
                Frm_Visor_Global frmVisor = new Frm_Visor_Global();
                frmVisor.reportViewer1.LocalReport.DataSources.Clear();
                frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._4_Procesos.Valores_Cobranza.rptDeterminacion1.rdlc";
                frmVisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsContribuyente", coleccionPersona));
                frmVisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsDocumentos", documentosNotificados));

                //ReportParameter[] param = new ReportParameter[2];
                //param[0] = new ReportParameter("AñoActual", Convert.ToString(coleccionPersona[0].año));
                //param[1] = new ReportParameter("Documento", Convert.ToString(coleccionPersona[0].numero));
                //frmVisor.reportViewer1.LocalReport.SetParameters(param);
                frmVisor.reportViewer1.RefreshReport();
                frmVisor.StartPosition = FormStartPosition.CenterParent;
                frmVisor.ShowDialog();
                for (int i = 0; i < listaValores.Count(); i++)
                {
                    if (listaValores[i].tipo_valor == 1)
                        impresionResolucionDeterminacion(listaValores[i].valor_ID, codigoPersona, listaValores[i].anioValor, coleccionPersona[0].numero,
                            listaValores[i].nroValor, notificacion_id, listaValores[i].mensaje, listaValores[i].baseLegal);
                    else
                    {
                        impresionOrdenPago(codigoPersona, listaValores[i].anioValor);
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_Visor_Global frmVisor = new Frm_Visor_Global();
            try
            {
                lblAnio1.Text = cboAnioIni.Text + " - " + cboAnioFin.Text;
                lblDeuda1.Text = txtMontoMin.Text + " - " + txtMontoMax.Text;
                int anio1 = 0, anio2 = 0;
                if (checkBox2.Checked)
                {
                    anio1 = (Int32)cboAnioIni.SelectedValue;
                    anio2 = (Int32)cboAnioFin.SelectedValue;
                }
                frmVisor.reportViewer1.LocalReport.DataSources.Clear();
                frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._4_Procesos.Valores_Cobranza.ListadoDeuda.rdlc";
                frmVisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", coleccion));

                ReportParameter[] paramsx = new ReportParameter[5];
                paramsx[0] = new ReportParameter("Sector", cboSector.Text);
                paramsx[1] = new ReportParameter("AnioInicio", anio1.ToString());
                paramsx[2] = new ReportParameter("AnioFin", anio2.ToString());
                paramsx[3] = new ReportParameter("RangoDeuda", txtMontoMin.Text + " y " + txtMontoMax.Text);
                paramsx[4] = new ReportParameter("Usuario", GlobalesV1.Global_str_Usuario);
                frmVisor.reportViewer1.LocalReport.SetParameters(paramsx);

                frmVisor.reportViewer1.RefreshReport();
                frmVisor.StartPosition = FormStartPosition.CenterParent;
                frmVisor.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_Visor_Global frmVisor = new Frm_Visor_Global();
            try
            {
                frmVisor.reportViewer1.LocalReport.DataSources.Clear();
                frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._4_Procesos.Valores_Cobranza.ListadoMorosos.rdlc";
                frmVisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", coleccion2));

                ReportParameter[] paramsx = new ReportParameter[5];
                paramsx[0] = new ReportParameter("Sector", cboSector.Text);
                paramsx[1] = new ReportParameter("AnioInicio", ((Int32)cboPeriodoIni.SelectedValue).ToString());
                paramsx[2] = new ReportParameter("AnioFin", ((Int32)cboPeriodoFin.SelectedValue).ToString());
                paramsx[3] = new ReportParameter("Numero", (Convert.ToInt32(txtNumero.Text)).ToString());
                paramsx[4] = new ReportParameter("Usuario", GlobalesV1.Global_str_Usuario);
                frmVisor.reportViewer1.LocalReport.SetParameters(paramsx);

                frmVisor.reportViewer1.RefreshReport();
                frmVisor.StartPosition = FormStartPosition.CenterParent;
                frmVisor.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_Visor_Global frmVisor = new Frm_Visor_Global();
            try
            {
                frmVisor.reportViewer1.LocalReport.DataSources.Clear();
                frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._4_Procesos.Valores_Cobranza.ListadoMorosos.rdlc";
                frmVisor.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1",
                    valo_ValoresDataService.listarMorosidad((Int32)cboSector2.SelectedValue,
                    (Int32)cboPeriodoIni.SelectedValue, (Int32)cboPeriodoFin.SelectedValue, Convert.ToInt32(txtNumero.Text))));

                ReportParameter[] paramsx = new ReportParameter[5];
                paramsx[0] = new ReportParameter("Sector", cboSector.Text);
                paramsx[1] = new ReportParameter("AnioInicio", ((Int32)cboPeriodoIni.SelectedValue).ToString());
                paramsx[2] = new ReportParameter("AnioFin", ((Int32)cboPeriodoFin.SelectedValue).ToString());
                paramsx[3] = new ReportParameter("Numero", (Convert.ToInt32(txtNumero.Text)).ToString());
                paramsx[4] = new ReportParameter("Usuario", GlobalesV1.Global_str_Usuario);
                frmVisor.reportViewer1.LocalReport.SetParameters(paramsx);

                frmVisor.reportViewer1.RefreshReport();
                frmVisor.StartPosition = FormStartPosition.CenterParent;
                frmVisor.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtContribuyente.Text.TrimEnd().Length != 0)
                {
                    cboContri.Enabled = true;
                    listarPersonaN("", txtContribuyente.Text.TrimEnd());
                    //cboPersona.SelectedValue = persona_id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                this.grupo1.Controls.Clear();
                this.grupo1.Controls.Add(this.tabPage3);
                dgvValoresVencidos.AutoGenerateColumns = false;
                dgvValoresVencidos.DataSource = valo_ValoresDataService.listarVencidos();
            }
            catch (Exception ex) { }
        }

        private void dgvValoresVencidos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvValoresVencidos.Columns[e.ColumnIndex].Name == "coactivo")
            {
                if (MessageBox.Show("Confirmar Envio a Coactivo?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int valor_ID = (Int32)dgvValoresVencidos.Rows[e.RowIndex].Cells["valor_id"].Value;
                    valo_ValoresDataService.enviarCoactivo(valor_ID, GlobalesV1.Global_str_Usuario);
                    MessageBox.Show("Valor Enviado a Coactivo", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvValoresVencidos.AutoGenerateColumns = false;
                    dgvValoresVencidos.DataSource = valo_ValoresDataService.listarVencidos();
                }
            }
        }

        private void linkLabel13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                this.grupo1.Controls.Clear();
                this.grupo1.Controls.Add(this.tabNotificacion);
                dgvNotificacion.AutoGenerateColumns = false;
                dgvNotificacion.DataSource = valo_ValoresDataService.listarGenerados();
            }
            catch (Exception ex) { }
        }

        private void dgvNotificacion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNotificacion.Columns[e.ColumnIndex].Name == "xnotificar")
            {
                if (MessageBox.Show("Confirmar Notificación de Valor?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int valor_ID = (Int32)dgvNotificacion.Rows[e.RowIndex].Cells["xvalorgenerado"].Value;
                    valo_ValoresDataService.notificar(valor_ID, GlobalesV1.Global_str_Usuario);
                    MessageBox.Show("Notificación Registrada Correctamente", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvNotificacion.AutoGenerateColumns = false;
                    dgvNotificacion.DataSource = valo_ValoresDataService.listarGenerados();
                }
            }
        }

        private void btnGenerarContri_Click(object sender, EventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                valo_ValoresDataService.insertarValores3((String)cboContri.SelectedValue, (Int32)cboPeriodoDesde.SelectedValue,
                (Int32)cboPeriodoHasta.SelectedValue, Convert.ToInt32((string)cboTipoValor3.SelectedValue), GlobalesV1.Global_str_Usuario);
                MessageBox.Show("Valores Correctamente Generados", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel14_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                this.grupo1.Controls.Clear();
                this.grupo1.Controls.Add(this.tbpAnular);
                dgvAnular.AutoGenerateColumns = false;
                dgvAnular.DataSource = valo_ValoresDataService.listarNotificados();
            }
            catch (Exception ex) { }
        }

        

        private void dgvAnular_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAnular.Columns[e.ColumnIndex].Name == "xanular")
            {
                if (MessageBox.Show("Confirmar Anulación de Valor?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int valor_ID = (Int32)dgvAnular.Rows[e.RowIndex].Cells["xvaloranula"].Value;
                    valo_ValoresDataService.anular(valor_ID, GlobalesV1.Global_str_Usuario);
                    MessageBox.Show("Valor Anulado Correctamente", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvAnular.AutoGenerateColumns = false;
                    dgvAnular.DataSource = valo_ValoresDataService.listarNotificados();
                }
            }
        }

        //private void btnGenerarContri_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        valo_ValoresDataService.insertarValores3((String)cboContri.SelectedValue, (Int32)cboPeriodoDesde.SelectedValue,
        //        (Int32)cboPeriodoHasta.SelectedValue, Convert.ToInt32((string)cboTipoValor3.SelectedValue), GlobalesV1.Global_str_Usuario);
        //        MessageBox.Show("Valores Correctamente Generados", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
    }
}
