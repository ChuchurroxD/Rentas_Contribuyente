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
namespace SGR.WinApp.Layout._4_Procesos.Predio.PredioContribuyente
{
    public partial class Frm_PredioContribuyente : Form
    {
        private List<Pred_PredioContribuyente> Coleccion;
        private SortOrder Orden = new SortOrder();
        Pred_PredioContribuyenteDataService PredContribuyenteDataService = new Pred_PredioContribuyenteDataService();
        public Frm_PredioContribuyente()
        {
            InitializeComponent();
        }

        private void toolnuevo_Click(object sender, EventArgs e)
        {
            Frm_PredioContribuyente_Detalle Frm_PredioContribuyente_Detalle = new Frm_PredioContribuyente_Detalle();
            Frm_PredioContribuyente_Detalle.StartPosition = FormStartPosition.CenterParent;
            Frm_PredioContribuyente_Detalle.ShowDialog();
            dataGridView1.DataSource = PredContribuyenteDataService.listartodos();
        }

        private void tooleditar_Click(object sender, EventArgs e)
        {
            Frm_PredioContribuyente_Detalle Frm_PredioContribuyente_Detalle = new Frm_PredioContribuyente_Detalle(obtenerdatos());
            Frm_PredioContribuyente_Detalle.StartPosition = FormStartPosition.CenterParent;
            Frm_PredioContribuyente_Detalle.ShowDialog();
            dataGridView1.DataSource = PredContribuyenteDataService.listartodos();
        }
        private Pred_PredioContribuyente obtenerdatos()
        {
            Pred_PredioContribuyente PredContribuyente = new Pred_PredioContribuyente();
            PredContribuyente.predio_contribuyente_id = (Int32)dataGridView1.SelectedRows[0].Cells["predio_contribuyente_id"].Value;
            PredContribuyente.idPeriodo = (Int16)dataGridView1.SelectedRows[0].Cells["idPeriodo"].Value;
            PredContribuyente.Fecha = (DateTime)dataGridView1.SelectedRows[0].Cells["Fecha"].Value;
            PredContribuyente.Porcentaje_Condomino = (decimal)dataGridView1.SelectedRows[0].Cells["Porcentaje_Condomino"].Value;
            PredContribuyente.ExonAutoValuo = (bool)dataGridView1.SelectedRows[0].Cells["ExonAutoValuo"].Value;
            PredContribuyente.AnioCompra = (Int32)dataGridView1.SelectedRows[0].Cells["AnioCompra"].Value;
            PredContribuyente.Predio_id = (string)dataGridView1.SelectedRows[0].Cells["Predio_id"].Value;
            PredContribuyente.persona_ID = (string)dataGridView1.SelectedRows[0].Cells["persona_ID"].Value;
            PredContribuyente.tipo_adquisicion = (Int32)dataGridView1.SelectedRows[0].Cells["tipo_adquisicion"].Value;
            PredContribuyente.tipo_posesion = (Int32)dataGridView1.SelectedRows[0].Cells["tipo_posesion"].Value;
            PredContribuyente.expediente = (string)dataGridView1.SelectedRows[0].Cells["expediente"].Value;
            PredContribuyente.observaciones = (string)dataGridView1.SelectedRows[0].Cells["observaciones"].Value;
            PredContribuyente.estado = (bool)dataGridView1.SelectedRows[0].Cells["Estado"].Value;
            
            return PredContribuyente;
        }

        private void Frm_PredioContribuyente_Load(object sender, EventArgs e)
        {
            try
            {
                Coleccion = PredContribuyenteDataService.listartodos();
                dataGridView1.DataSource = Coleccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }
    }
}
