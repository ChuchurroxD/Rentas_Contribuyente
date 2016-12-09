using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using SGR.Core.Service;
using SGR.Entity.Model;
using SGR.WinApp.Layout._5_Reportes_Gestion;

namespace SGR.WinApp.Layout._4_Procesos.Fraccionamiento.Seguimiento_Fraccionamiento
{
    public partial class Frm_FraccionamientoSeguimiento : DockContent
    {
        Conf_MultitablaDataService conf_MultitablaDataService = new Conf_MultitablaDataService();
        Conf_UbicacionDataService conf_UbicacionDataService = new Conf_UbicacionDataService();
        Pred_SectorDataService pred_SectorDataService = new Pred_SectorDataService();
        Pred_ViasDataService pred_ViasDataService = new Pred_ViasDataService();
        Mant_PersonaDataService mant_PersonaDataService = new Mant_PersonaDataService();
        Mant_ContribuyenteDataService mant_ContribuyenteDataService = new Mant_ContribuyenteDataService();
        Mant_JuntaViaDataService mant_JuntaViaDataService = new Mant_JuntaViaDataService();
        Frac_FraccionamientoDataService FraccionamientoDataService = new Frac_FraccionamientoDataService();
        List<Pred_Sector> listaSec = new List<Pred_Sector>();
        List<Pred_Vias> listaVias = new List<Pred_Vias>();
        List<Trib_TipoFraccionamiento> listTipo = new List<Trib_TipoFraccionamiento>();
        List<Conf_Multitabla> listaEstados = new List<Conf_Multitabla>();
        List<Mant_Periodo> listaPeriodos = new List<Mant_Periodo>();
        Mant_PeriodoDataService periodo = new Mant_PeriodoDataService();
        List<Frac_FraccionamientoListado2> coleccion = new List<Frac_FraccionamientoListado2>();
        List<Frac_DeudaFraccionada> coleccion2 = new List<Frac_DeudaFraccionada>();
        public Frm_FraccionamientoSeguimiento()
        {
            InitializeComponent();            
        }

        private void Frm_FraccionamientoSeguimiento_Load(object sender, EventArgs e)
        {
            try
            {
                llenarTipoFraccionamiento();
                llenarEstadoFraccionamiento();
                llenarTipoSector();
                Mant_Periodo elemen = new Mant_Periodo();
                elemen.Peric_canio = 0;
                elemen.Peric_vdescripcion = "TODOS";
                cboPeriodo.DisplayMember = "Peric_vdescripcion";
                cboPeriodo.ValueMember = "Peric_canio";                
                listaPeriodos.Add(elemen);
                listaPeriodos.AddRange(periodo.GetAllMant_Periodo());
                cboPeriodo.DataSource = listaPeriodos;
                //cboPeriodo.Items.Add('');
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        
        private void llenarTipoFraccionamiento()
        {
            Trib_TipoFraccionamiento elem = new Trib_TipoFraccionamiento();
            elem.TiFr_base_legal = "TODOS";
            elem.TiFr_tipo_fraccionamiento_ID = 0;
            cboTipoFraccionamiento.DisplayMember = "TiFr_base_legal";
            cboTipoFraccionamiento.ValueMember = "TiFr_tipo_fraccionamiento_ID";            
            listTipo.Add(elem);
            listTipo.AddRange(FraccionamientoDataService.listarFraccionamiento());
            cboTipoFraccionamiento.DataSource = listTipo;
        }
        private void llenarEstadoFraccionamiento()
        {
            Conf_Multitabla elemen = new Conf_Multitabla();
            elemen.Multc_vDescripcion = "TODOS";
            elemen.Multc_cValor = "0";
            cboEstadoFracc.DisplayMember = "Multc_vDescripcion";
            cboEstadoFracc.ValueMember = "Multc_cValor";            
            listaEstados.Add(elemen);
            listaEstados.AddRange(conf_MultitablaDataService.GetCboConf_Multitabla("39"));
            cboEstadoFracc.DataSource = listaEstados;
        }
        public void llenarTipoSector()
        {
            //llenar combos para busqueda            
            Pred_Sector elem = new Pred_Sector();
            elem.sector_id = 0;
            elem.descripcion = "TODOS";
            cboSectorB.DisplayMember = "descripcion";
            cboSectorB.ValueMember = "sector_id";            
            listaSec.Add(elem);
            listaSec.AddRange(pred_SectorDataService.listarSectorCbo(GlobalesV1.Global_int_idoficina));
            cboSectorB.DataSource = listaSec;            
            //cboCalleB.DisplayMember = "Descripcion";
            //cboCalleB.ValueMember = "Via_id";
            //cboCalleB.DataSource = pred_ViasDataService.listarViasCboCodAntiguo("130107");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                //if(txtRazonSocial.Text.Trim().Length <= 0)
                //{
                //    MessageBox.Show("Debe Ingresar un Contribuyente", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    return;
                //}
                if(dtpFechaFin.Value < dtpFechaInicio.Value)
                {
                    MessageBox.Show("La fecha inicio debe ser menor a la fecha fin", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                int cuotas = 0,cuotasVenc=0;
                try
                {
                    cuotas = Convert.ToInt32(txtNroCuota.Text);
                }
                catch(Exception ex)
                {

                }
                try
                {
                    cuotasVenc = Convert.ToInt32(txtNroCuotaVenc.Text);
                }
                catch (Exception ex)
                {

                }
                coleccion= FraccionamientoDataService.listarFraccionamientosRecaudacion(cuotas, cuotasVenc,
                    (string)cboCalleB.SelectedValue, (Int32)cboSectorB.SelectedValue, txtRazonSocial.Text,
                    (string)cboEstadoFracc.SelectedValue, (Int32)cboTipoFraccionamiento.SelectedValue, (Int32)cboPeriodo.SelectedValue,
                    dtpFechaInicio.Value, dtpFechaFin.Value);
                dataGridView1.DataSource = coleccion;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void cboSectorB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pred_Vias elem = new Pred_Vias();
            elem.Via_id = "0";
            elem.Descripcion = "TODOS";
            cboCalleB.ValueMember = "Via_Id";
            cboCalleB.DisplayMember = "Descripcion";
            listaVias= pred_ViasDataService.listarViasPorSector(cboSectorB.SelectedValue.ToString(), GlobalesV1.Global_int_idoficina);
            listaVias.Add(elem);
            cboCalleB.DataSource = listaVias;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                //if(txtRazonSocial.Text.Trim().Length <= 0)
                //{
                //    MessageBox.Show("Debe Ingresar un Contribuyente", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    return;
                //}
                if (dtpFechaFin.Value < dtpFechaInicio.Value)
                {
                    MessageBox.Show("La fecha inicio debe ser menor a la fecha fin", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                int cuotas = 0, cuotasVenc = 0;
                try
                {
                    cuotas = Convert.ToInt32(txtNroCuota.Text);
                }
                catch (Exception ex)
                {

                }
                try
                {
                    cuotasVenc = Convert.ToInt32(txtNroCuotaVenc.Text);
                }
                catch (Exception ex)
                {

                }
                coleccion2 = FraccionamientoDataService.listarMontoFraccionado(cuotas, cuotasVenc,
                    (string)cboCalleB.SelectedValue, (Int32)cboSectorB.SelectedValue, txtRazonSocial.Text,
                    (string)cboEstadoFracc.SelectedValue, (Int32)cboTipoFraccionamiento.SelectedValue, (Int32)cboPeriodo.SelectedValue,
                    dtpFechaInicio.Value, dtpFechaFin.Value);
                Frm_Visor_Global frmvisor = new Frm_Visor_Global();
                frmvisor.reportViewer1.LocalReport.DataSources.Clear();
                frmvisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._4_Procesos.Fraccionamiento.Seguimiento_Fraccionamiento.rptListadoFraccionamientos.rdlc";
                frmvisor.reportViewer1.LocalReport.DataSources.Add(new
                    Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", coleccion2));
                frmvisor.reportViewer1.RefreshReport();
                frmvisor.StartPosition = FormStartPosition.CenterScreen;
                frmvisor.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                int fraccionamiento_ID = (Int32)dataGridView1.Rows[e.RowIndex].Cells["xfraccionamiento_id"].Value;
                Frm_FraccionamientoReporte Frm_fracc = new Frm_FraccionamientoReporte(fraccionamiento_ID);
                Frm_fracc.StartPosition = FormStartPosition.CenterParent;
                Frm_fracc.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo invocar el formulario");
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
    }
}
