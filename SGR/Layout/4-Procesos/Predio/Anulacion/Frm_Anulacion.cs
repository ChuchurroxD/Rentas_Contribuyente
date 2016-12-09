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
using WeifenLuo.WinFormsUI.Docking;

namespace SGR.WinApp.Layout._4_Procesos.Predio.Anulacion
{
    public partial class Frm_Anulacion : DockContent
    {
        private Mant_PeriodoDataService PeriodoDataService = new Mant_PeriodoDataService();
        private Pred_AnulacionDataService pred_AnulacionDataService = new Pred_AnulacionDataService();

        public Frm_Anulacion()
        {
            InitializeComponent();
        }

        private void Frm_Anulacion_Load(object sender, EventArgs e)
        {
            cboPeriodo.ValueMember = "Peric_canio";
            cboPeriodo.DisplayMember = "Peric_canio";
            cboPeriodo.DataSource = PeriodoDataService.llenarPeriodo();
        }

        private void toolnuevo_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodContribuyente.Text.Trim().Length <= 0)
                    throw new Exception("Debe ingresar el código del contribuyente.");
                Frm_AnulacionDetalle frm_AnulacionDetalle = new Frm_AnulacionDetalle(txtCodContribuyente.Text);//8832
                frm_AnulacionDetalle.StartPosition = FormStartPosition.CenterParent;
                frm_AnulacionDetalle.ShowDialog();
                button1_Click(sender, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tributosID="";
            if (rbtPredio.Checked == true)
                tributosID = "0008";
            if (rbtArbitrio.Checked == true)
                tributosID = "0043";
            if (rbtAmbos.Checked == true)
                tributosID = "0000";
            if (rbtFormulario.Checked == true)
                tributosID = "0016";

            dgAnulacion.DataSource = pred_AnulacionDataService.listartodos(tributosID, txtCodContribuyente.Text.Trim(), Convert.ToInt32(cboPeriodo.SelectedValue.ToString()));
        }
    }
}
