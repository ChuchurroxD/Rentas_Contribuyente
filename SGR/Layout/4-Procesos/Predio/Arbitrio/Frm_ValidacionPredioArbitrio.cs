using SGR.Core.Service;
using SGR.Entity.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace SGR.WinApp.Layout._4_Procesos.Predio.Arbitrio
{
    public partial class Frm_ValidacionPredioArbitrio : DockContent
    {
        Mant_PeriodoDataService mant_PeriodoDataService = new Mant_PeriodoDataService();
        Pred_ValidacionPredioArbitrioDataService pred_ValidacionPredioArbitrioDataService = new Pred_ValidacionPredioArbitrioDataService();
        private List<Pred_ValidacionPredioArbitrio> Coleccion;
        public Frm_ValidacionPredioArbitrio()
        {
            InitializeComponent();
        }

        private void llenarcomboPeriodo()
        {
            try
            {
                comboPeriodoBusqueda.DisplayMember = "Peric_canio";
                comboPeriodoBusqueda.ValueMember = "Peric_canio";
                comboPeriodoBusqueda.DataSource = mant_PeriodoDataService.llenarPeriodo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void Frm_ValidacionPredioArbitrio_Load(object sender, EventArgs e)
        {
            try
            {
                txtBusquedaContribuyente.Focus();
                DateTime fechaHoy = DateTime.Now;
                llenarcomboPeriodo();
                comboPeriodoBusqueda.SelectedValue = Convert.ToInt32(fechaHoy.Year.ToString());
                Coleccion = pred_ValidacionPredioArbitrioDataService.ValidarPredioArbitrio((int)comboPeriodoBusqueda.SelectedValue);
                dgvValidacionPredioArbitrio.DataSource = Coleccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void comboPeriodoBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            Coleccion = pred_ValidacionPredioArbitrioDataService.ValidarPredioArbitrio((int)comboPeriodoBusqueda.SelectedValue);
            dgvValidacionPredioArbitrio.DataSource = Coleccion;
        }

        private void txtBusquedaContribuyente_TextChanged(object sender, EventArgs e)
        {
            Coleccion = pred_ValidacionPredioArbitrioDataService.buscarPredioArbitrio((int)comboPeriodoBusqueda.SelectedValue, txtBusquedaContribuyente.Text.ToString().Trim());
            dgvValidacionPredioArbitrio.DataSource = Coleccion; 
        }
    }
}
