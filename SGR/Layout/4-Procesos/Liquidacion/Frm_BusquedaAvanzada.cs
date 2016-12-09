using SGR.Core.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SGR.WinApp.Layout._4_Procesos.Liquidacion
{
    public partial class Frm_BusquedaAvanzada : Form
    {
        Liqu_LiquidacionDataService Liqu_LiquidacionDataService = new Liqu_LiquidacionDataService();
        Conf_MultitablaDataService conf_mult = new Conf_MultitablaDataService();
        public Frm_BusquedaAvanzada()
        {
            InitializeComponent();
            llenarComboTipo();
        }
        public void llenarComboTipo()
        {
            cboEstado.ValueMember = "Multc_cValor";
            cboEstado.DisplayMember = "Multc_vDescripcion";
            cboEstado.DataSource = conf_mult.GetCboConf_Multitabla("48");
            cboTipo.ValueMember = "Multc_cValor";
            cboTipo.DisplayMember = "Multc_vDescripcion";
            cboTipo.DataSource = conf_mult.GetCboConf_Multitabla("33");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmListadoLiquidacion Frm_Liqui = new FrmListadoLiquidacion(dtpFechaInicio.Value, dtpFechaFin.Value,
                (string)cboEstado.SelectedValue,(string)cboTipo.SelectedValue,txtContribuyente.Text);
            Frm_Liqui.StartPosition = FormStartPosition.CenterParent;
            Frm_Liqui.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
