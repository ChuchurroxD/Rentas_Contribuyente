using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using SGR.Core.Service;
using System.Windows.Forms;
using SGR.Entity.Model;

namespace SGR.WinApp.Layout._4_Procesos.Plataforma.ConsultarPlataforma
{
    public partial class Frm_Coactivo : Form
    {
        private Mant_PeriodoDataService Mant_PeriodoDataService = new Mant_PeriodoDataService();
        private Valo_ValoresCobranzaDataService Valo_ValoresCobranza = new Valo_ValoresCobranzaDataService();
        private Coa_coactivo_ctaDataService Coa_coactivo_cta = new Coa_coactivo_ctaDataService();
        private List<Coa_coactivo_cta> coleccion = new List<Coa_coactivo_cta>();
        private string persona_ID;

        public Frm_Coactivo()
        {
            InitializeComponent();
        }

        public Frm_Coactivo(string persona_ID)
        {
            this.persona_ID = persona_ID;
            InitializeComponent();
        }

        private void llenarPeriodo()
        {
            cboPeriodo.DisplayMember = "Peric_vdescripcion";
            cboPeriodo.ValueMember = "Peric_canio";
            cboPeriodo.DataSource = Mant_PeriodoDataService.listarCboPeriodov2();
        }

        private void Frm_Coactivo_Load(object sender, EventArgs e)
        {
            try
            {
                llenarPeriodo();
                if (persona_ID != null)
                {
                    //cboPeriodo.SelectedValue = Mant_PeriodoDataService.GetPeriodoActivo();
                    dataGridView1.AutoGenerateColumns = false;
                    coleccion = Coa_coactivo_cta.listarTodosPorContribuyente(persona_ID);
                    dataGridView1.DataSource = coleccion;                    
                }
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt16(cboPeriodo.SelectedValue) == 0)
            {
                dataGridView1.AutoGenerateColumns = false;
                coleccion = Coa_coactivo_cta.listarTodosPorContribuyente(persona_ID);
                dataGridView1.DataSource = coleccion;
            } else
            {
                dataGridView1.AutoGenerateColumns = false;
                coleccion = Coa_coactivo_cta.listarPorContribuyenteAnio(persona_ID, Convert.ToInt16(cboPeriodo.SelectedValue));
                dataGridView1.DataSource = coleccion;
            }
           
        }
    }
}
