using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGR.Core.Service;
using SGR.Entity.Model;

namespace SGR.WinApp.Layout._4_Procesos.Plataforma.ConsultarPlataforma
{
    public partial class Frm_PredioDetalle : Form
    {
        private Int16 periodo;
        private string predio_ID;
        private Pred_PredioContribuyenteDataService Pred_PredioContribuyenteDataService = new Pred_PredioContribuyenteDataService();
        private Pred_PisosDataService Pred_PisosDataService = new Pred_PisosDataService();

        public Frm_PredioDetalle()
        {
            InitializeComponent();
        }

        public Frm_PredioDetalle(string predio_ID, Int16 periodo)
        {
            InitializeComponent();
            this.predio_ID = predio_ID;
            this.periodo = periodo;
        }

        private void Frm_PredioDetalle_Load(object sender, EventArgs e)
        {
            try
            {
                if (predio_ID != null && periodo > 0)
                {
                    Pred_Predios Pred_Predio = new Pred_Predios();
                    Pred_Predio = Pred_PredioContribuyenteDataService.detallePredioContribuyente(periodo, predio_ID);
                    lblAnio.Text = periodo.ToString();
                    lblTipoPredio.Text = Pred_Predio.tipo_predio;
                    lblAreaTerreno.Text = Pred_Predio.area_terreno.ToString() + " m^2";
                    lblValorConstruc.Text = "S/. "+Pred_Predio.valor_construccion.ToString();
                    lblAdquisicion.Text = Pred_Predio.tipo_adquisicion;
                    lblCodPredio.Text = Pred_Predio.predio_ID;
                    lblTipoInmueb.Text = Pred_Predio.tipo_inmueble;
                    lblAreaConst.Text = Pred_Predio.area_construida.ToString() + " m^2";
                    lblValorOtrasIns.Text = "S/. "+Pred_Predio.valor_otra_instalacion.ToString();
                    lblFechaAdq.Text = Pred_Predio.fecha_adquisicion.ToShortDateString();
                    lblUbicacion.Text = Pred_Predio.direccion;
                    lblEstado.Text = Pred_Predio.estado_predio;
                    lblFrente.Text = Pred_Predio.frente_metros.ToString()+" m";
                    lblValorAreaCo.Text = "S/. "+Pred_Predio.valor_area_comun.ToString();
                    lblPosesion.Text = Pred_Predio.posesion;
                    lblSector.Text = Pred_Predio.sector;
                    lblUsoPredio.Text = Pred_Predio.uso_predio;
                    lblValorTerreno.Text = "S/. "+Pred_Predio.valor_terreno.ToString();
                    lblAutovaluo.Text = "S/. "+Pred_Predio.total_autovaluo.ToString();
                    lblActivo.Text = Pred_Predio.estado;
                    var coleccion = Pred_PisosDataService.pisoPredioContribuyente(periodo, predio_ID);
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataSource = coleccion;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
