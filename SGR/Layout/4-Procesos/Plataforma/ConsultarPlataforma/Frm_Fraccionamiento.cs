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
    public partial class Frm_Fraccionamiento : Form
    {
        private string persona_ID;
        private Frac_FraccionamientoDataService Frac_FraccionamientoDataService = new Frac_FraccionamientoDataService();

        public Frm_Fraccionamiento()
        {
            InitializeComponent();
        }

        public Frm_Fraccionamiento(string persona_ID)
        {
            this.persona_ID = persona_ID;
            InitializeComponent();
        }

        private void Frm_Fraccionamiento_Load(object sender, EventArgs e)
        {
            try
            {
                if(persona_ID != null)
                {
                    dataGridView1.DataSource = Frac_FraccionamientoDataService.listarfraccinamientoContribuyente(persona_ID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Error);               
            }
        }
        private Frac_Fraccionamientos obtenerObjeto()
        {
            try
            {
                var Frac_Fraccionamiento = new Frac_Fraccionamientos
                {
                    fraccionamiento_id = (Int32)dataGridView1.SelectedRows[0].Cells["fraccionamiento_id"].Value,
                    base_legal = (string)dataGridView1.SelectedRows[0].Cells["base_legal"].Value,
                    fecha_acogida = (string)dataGridView1.SelectedRows[0].Cells["fecha_acogida"].Value,
                    periodos = (string)dataGridView1.SelectedRows[0].Cells["periodos"].Value,
                    deuda_total = (decimal)dataGridView1.SelectedRows[0].Cells["deuda_total"].Value,
                    inicial = (decimal)dataGridView1.SelectedRows[0].Cells["inicial"].Value,
                    saldo = (decimal)dataGridView1.SelectedRows[0].Cells["saldo"].Value,
                    valorCuota = (decimal)dataGridView1.SelectedRows[0].Cells["valorCuota"].Value,
                    nroCuotas = (Int32)dataGridView1.SelectedRows[0].Cells["nroCuotas"].Value,
                    estado = (string)dataGridView1.SelectedRows[0].Cells["estado"].Value
                };
                return Frac_Fraccionamiento;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                Frm_FraccionamientoDetalle Frm_detalle = new Frm_FraccionamientoDetalle(obtenerObjeto());
                Frm_detalle.MdiParent = this.MdiParent;
                Frm_detalle.Show();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
