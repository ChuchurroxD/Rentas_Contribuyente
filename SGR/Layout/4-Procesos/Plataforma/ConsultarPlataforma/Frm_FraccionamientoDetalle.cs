using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGR.Entity.Model;
using SGR.Core.Service;

namespace SGR.WinApp.Layout._4_Procesos.Plataforma.ConsultarPlataforma
{
    public partial class Frm_FraccionamientoDetalle : Form
    {
        private Frac_Fraccionamientos frac_Fraccionamientos;
        private Pred_TributoDataService Pred_TributoDataService = new Pred_TributoDataService();
        private Frac_FraccionamientoDataService Frac_FraccionamientoDataService = new Frac_FraccionamientoDataService();

        public Frm_FraccionamientoDetalle()
        {
            InitializeComponent();
        }

        public Frm_FraccionamientoDetalle(Frac_Fraccionamientos frac_Fraccionamientos)
        {
            this.frac_Fraccionamientos = frac_Fraccionamientos;
            InitializeComponent();
        }

        private void Frm_FraccionamientoDetalle_Load(object sender, EventArgs e)
        {
            try
            {
                if(frac_Fraccionamientos != null)
                {
                    lblBaseLegal.Text = frac_Fraccionamientos.base_legal;
                    lblFechaAcogida.Text = frac_Fraccionamientos.fecha_acogida;
                    lblPeriodos.Text = frac_Fraccionamientos.periodos;
                    lblEstado.Text = frac_Fraccionamientos.estado;
                    lblDeudaTotal.Text = "S/. " + frac_Fraccionamientos.deuda_total.ToString();
                    lblDeudaFrac.Text = "S/." + frac_Fraccionamientos.saldo.ToString();
                    lblValorCuota.Text = "S/. " + frac_Fraccionamientos.valorCuota.ToString();
                    lblNroCuotas.Text = frac_Fraccionamientos.nroCuotas.ToString();
                    lblInicial.Text = "S/. " + frac_Fraccionamientos.inicial.ToString();
                    //tributos afectados
                    dataGridView1.DataSource = Pred_TributoDataService.listarTributoporFraccionamiento(frac_Fraccionamientos.fraccionamiento_id);
                    //cronograma de pagos
                    dataGridView2.DataSource = Frac_FraccionamientoDataService.listarCronoContribuyente(frac_Fraccionamientos.fraccionamiento_id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
