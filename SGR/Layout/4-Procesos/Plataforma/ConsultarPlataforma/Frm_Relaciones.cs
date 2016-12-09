using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGR.Core.Service;

namespace SGR.WinApp.Layout._4_Procesos.Plataforma.ConsultarPlataforma
{
    public partial class Frm_Relaciones : Form
    {
        private string persona_ID;
        private Mant_Relacion_ContribuyenteDataService RelacionContribuyenteDataService = new Mant_Relacion_ContribuyenteDataService();

        public Frm_Relaciones()
        {
            InitializeComponent();
        }

        public Frm_Relaciones(string persona_ID)
        {
            this.persona_ID = persona_ID;
            InitializeComponent();
        }

        private void Frm_Relaciones_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = RelacionContribuyenteDataService.listarRelacionporContribuyente(persona_ID);
        }
    }
}
