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

namespace SGR.WinApp.Layout._4_Procesos.Fraccionamiento
{
    public partial class Frm_FraccionamientoListado : DockContent
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
        public Frm_FraccionamientoListado()
        {
            InitializeComponent();
            try
            {
                llenarTipoFraccionamiento();
                llenarTipoSector();
            }
            catch (Exception ex)
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
        public void llenarTipoSector()
        {      
            Pred_Sector elem = new Pred_Sector();
            elem.sector_id = 0;
            elem.descripcion = "TODOS";
            cboSectorB.DisplayMember = "descripcion";
            cboSectorB.ValueMember = "sector_id";            
            listaSec.Add(elem);
            listaSec.AddRange(pred_SectorDataService.listarSectorCbo(GlobalesV1.Global_int_idoficina));
            cboSectorB.DataSource = listaSec;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtpFechaFin.Value < dtpFechaInicio.Value)
                {
                    MessageBox.Show("La fecha inicio debe ser menor a la fecha fin", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                int cuotas = 0, cuotasVenc = 0;                
                try
                {
                    cuotasVenc = Convert.ToInt32(txtNroCuotaVenc.Text);
                }
                catch (Exception ex)
                {

                }
                coleccion = FraccionamientoDataService.listarFraccionamientosRecaudacion2(cuotas, cuotasVenc,
                    (string)cboCalleB.SelectedValue, (Int32)cboSectorB.SelectedValue, txtRazonSocial.Text,
                    "0", (Int32)cboTipoFraccionamiento.SelectedValue, 0,dtpFechaInicio.Value, dtpFechaFin.Value);
                dataGridView1.DataSource = coleccion;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void cboSectorB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pred_Vias elem = new Pred_Vias();
            elem.Via_id = "0";
            elem.Descripcion = "TODOS";
            cboCalleB.ValueMember = "Via_Id";
            cboCalleB.DisplayMember = "Descripcion";
            listaVias = pred_ViasDataService.listarViasPorSector(cboSectorB.SelectedValue.ToString(), GlobalesV1.Global_int_idoficina);
            listaVias.Add(elem);
            cboCalleB.DataSource = listaVias;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "xanular")
            {
                try
                {
                    if (MessageBox.Show("Desea Anular el fraccionamiento?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Int32 fraccionamiento_id;
                        fraccionamiento_id = (Int32)dataGridView1.Rows[e.RowIndex].Cells["xfraccionamiento_id"].Value;
                        FraccionamientoDataService.anularFraccionamiento(fraccionamiento_id);
                        MessageBox.Show("Fraccionamiento Anulado Correctamente", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
