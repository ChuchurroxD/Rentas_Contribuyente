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
    public partial class Frm_Predios : Form
    {
        private string persona_ID;
        Mant_PeriodoDataService Mant_PeriodoDataService = new Mant_PeriodoDataService();
        Pred_PredioContribuyenteDataService Pred_PredioContribuyenteDataService = new Pred_PredioContribuyenteDataService();

        public Frm_Predios()
        {
            InitializeComponent();
        }

        public Frm_Predios(string persona_ID)
        {
            this.persona_ID = persona_ID;
            InitializeComponent();
            llenarPeriodo();
            cboPeriodo.SelectedValue = Mant_PeriodoDataService.GetPeriodoActivo();
            var coleccion = new List<Pred_PredioContribuyente>();
            coleccion = Pred_PredioContribuyenteDataService.listarPorPeriodoContribuyente(Convert.ToInt32(cboPeriodo.SelectedValue), persona_ID);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = coleccion;
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
            dataGridView1.DataSource = Pred_PredioContribuyenteDataService.listarPorPeriodoContribuyente(Convert.ToInt32(cboPeriodo.SelectedValue), persona_ID);
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                string predio_ID = (string)dataGridView1.SelectedRows[0].Cells["Predio_id"].Value;
                Int16 periodo = Convert.ToInt16(cboPeriodo.SelectedValue);

                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();

                Frm_PredioDetalle Frm_Detalle = new Frm_PredioDetalle(predio_ID, periodo);
                // Frm_Detalle.MdiParent = Frm_ConsultarPlataformaDetalle.ActiveForm;
              // Frm_ConsultarPlataformaDetalle f = new Frm_ConsultarPlataformaDetalle();
               // f.panel2.Controls.Clear();
                Frm_Detalle.MdiParent = this.MdiParent;
               // Frm_Detalle.MdiParent = f;
                //this.TopLevel = false;
                //Frm_Detalle.Dock = DockStyle.Fill;
                //f.panel2.Controls.Add(Frm_Detalle);
                Frm_Detalle.Show();
                this.Dispose();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
    }
}
