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
using SGR.Entity;
using WeifenLuo.WinFormsUI.Docking;

namespace SGR.WinApp.Layout._4_Procesos.Fraccionamiento.Fraccionamiento
{
    public partial class Frm_CalculoFraccionamiento : DockContent
    {
        Mant_PeriodoDataService periodos = new Mant_PeriodoDataService();
        Frac_FraccionamientoDataService fraccionamiento = new Frac_FraccionamientoDataService();
        int cod_fracc = 0;
        public Frm_CalculoFraccionamiento()
        {
            InitializeComponent();
            cargarCombos();
        }
        public void cargarCombos()
        {
            cboAnioFraccionamiento.DisplayMember = "Peric_canio";
            cboAnioFraccionamiento.ValueMember = "Peric_canio";
            cboAnioFraccionamiento.DataSource = periodos.GetAllMant_Periodo();
        }

        private void txtNroFraccionamiento_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    Frac_Fraccionamiento elemen = new Frac_Fraccionamiento();
                    switch (fraccionamiento.validarFraccio((Int32)cboAnioFraccionamiento.SelectedValue,
                        Convert.ToInt32(txtNroFraccionamiento.Text)))
                    {
                        case 0:
                            lblResultadoFrac.Text = "Fraccionamiento no existe";
                            txtContFracc.Text = "";
                            cod_fracc = 0;
                            break;
                        case 1:
                            elemen = fraccionamiento.listarPorCodigo2((Int32)cboAnioFraccionamiento.SelectedValue,
                            Convert.ToInt32(txtNroFraccionamiento.Text));
                            lblResultadoFrac.Text = "";
                            txtContFracc.Text = elemen.persona_ID;
                            cod_fracc = elemen.anio;
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Globales.Global_MessageBox);
                }
            }
        }

        private void cboAnioFraccionamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Frac_Fraccionamiento elemen = new Frac_Fraccionamiento();
                switch (fraccionamiento.validarFraccio((Int32)cboAnioFraccionamiento.SelectedValue,
                    Convert.ToInt32(txtNroFraccionamiento.Text)))
                {
                    case 0:
                        lblResultadoFrac.Text = "Fraccionamiento no existe";
                        txtContFracc.Text = "";
                        cod_fracc = 0;
                        break;
                    case 1:
                        elemen = fraccionamiento.listarPorCodigo2((Int32)cboAnioFraccionamiento.SelectedValue,
                        Convert.ToInt32(txtNroFraccionamiento.Text));
                        lblResultadoFrac.Text = "";
                        txtContFracc.Text = elemen.persona_ID;
                        cod_fracc = elemen.anio;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }
    }
}
