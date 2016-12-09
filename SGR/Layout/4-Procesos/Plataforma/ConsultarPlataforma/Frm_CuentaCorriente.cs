using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGR.Entity;
using SGR.Entity.Model;
using SGR.Core.Service;
using SGR.WinApp.Layout._5_Reportes_Gestion;
using Microsoft.Reporting.WinForms;
using System.IO;

namespace SGR.WinApp.Layout._4_Procesos.Plataforma.ConsultarPlataforma
{
    public partial class Frm_CuentaCorriente : Form
    {
        private string persona_ID;
        private Pago_CuentaCorrienteDataService Pago_CuentaCorrienteDataService = new Pago_CuentaCorrienteDataService();
        private List<Pago_CuentaCorriente> coleccion = new List<Pago_CuentaCorriente>();
        public Frm_CuentaCorriente()
        {
            InitializeComponent();
        }

        public Frm_CuentaCorriente(string persona_ID)
        {
            this.persona_ID = persona_ID;
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void Frm_CuentaCorriente_Load_1(object sender, EventArgs e)
        {
            try
            {
                
                if (persona_ID != null)
                {
                    coleccion = Pago_CuentaCorrienteDataService.estadoCuentaValores(persona_ID);
                    dataGridView1.DataSource = coleccion;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                coleccion = Pago_CuentaCorrienteDataService.estadoCuentaValores(persona_ID);
                Frm_Visor_Global frmVisor = new Frm_Visor_Global();
                frmVisor.reportViewer1.LocalReport.DataSources.Clear();
                frmVisor.reportViewer1.LocalReport.ReportEmbeddedResource = "SGR.WinApp.Layout._4_Procesos.Plataforma.ConsultarPlataforma.Rep_CuentaCorriente.rdlc";
                frmVisor.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", coleccion));
              
                frmVisor.reportViewer1.RefreshReport();
                frmVisor.StartPosition = FormStartPosition.CenterParent;
                frmVisor.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
