using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using SGR.Core.Service;
using System.Windows.Forms;

namespace SGR.WinApp.Layout._4_Procesos.Plataforma.ConsultarPlataforma
{
    public partial class Frm_Valores : Form
    {
        private Mant_PeriodoDataService Mant_PeriodoDataService = new Mant_PeriodoDataService();
        private Valo_ValoresCobranzaDataService Valo_ValoresCobranza = new Valo_ValoresCobranzaDataService();
        private string persona_ID;

        public Frm_Valores()
        {
            InitializeComponent();
        }

        public Frm_Valores(string persona_ID)
        {
            this.persona_ID = persona_ID;
            InitializeComponent();
        }

        private void Frm_Valores_Load(object sender, EventArgs e)
        {
            try
            {
                llenarPeriodo();
                if (persona_ID != null)
                {
                    cboPeriodo.SelectedValue = Mant_PeriodoDataService.GetPeriodoActivo();
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataSource = Valo_ValoresCobranza.listarporContribuyente(persona_ID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void llenarPeriodo()
        {
            cboPeriodo.DisplayMember = "Peric_canio";
            cboPeriodo.ValueMember = "Peric_canio";
            cboPeriodo.DataSource = Mant_PeriodoDataService.llenarPeriodo();
        }

        private void cboPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            //dataGridView1.DataSource = Valo_ValoresCobranza.listarporContribuyente(persona_ID);
            dataGridView1.DataSource = Valo_ValoresCobranza.listarporContribuyentePeriodo(persona_ID, Convert.ToInt16(cboPeriodo.SelectedValue));
        }
    }
}
