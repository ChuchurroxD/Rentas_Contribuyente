using DgvFilterPopup;
using SGR.Core.Service;
using SGR.Entity.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.Linq;
using Microsoft.Reporting.WinForms;
using SGR.WinApp.Layout._5_Reportes_Gestion;
using SGR.Entity;

namespace SGR.WinApp.Layout._4_Procesos.Predio.Historial_PC
{
    public partial class Frm_HistorialPC : Form
    {
        private string id = "1";//"002131526001";
        private int periodo = 2016;
        private int tipo = 1;//tipo 1:persona, tio2:predio

        private Mant_HistorialDataService mant_HistorialDataService = new Mant_HistorialDataService();
        private Mant_PeriodoDataService mant_PeriodoDataService = new Mant_PeriodoDataService();

        private List<Mant_Historial> coleccion = new List<Mant_Historial>();
        private System.Windows.Forms.SortOrder Orden = new System.Windows.Forms.SortOrder();

        public Frm_HistorialPC()
        {
            InitializeComponent();
        }
        public Frm_HistorialPC(string idd, int perio, int tipo)
        {
            InitializeComponent();
            this.id = idd;
            this.periodo = perio;
            this.tipo = tipo;
        }

        private void Frm_HistorialPC_Load(object sender, EventArgs e)
        {
            llenarcomboPeriodo();
            cboPeriodo.SelectedValue = periodo;
            dgHistorial.DataSource = mant_HistorialDataService.listartodos(tipo, id, (Int32)cboPeriodo.SelectedValue);
        }

        private void llenarcomboPeriodo()
        {
            try
            {
                cboPeriodo.DisplayMember = "Peric_canio";
                cboPeriodo.ValueMember = "Peric_canio";
                cboPeriodo.DataSource = mant_PeriodoDataService.llenarPeriodo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void cboPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgHistorial.DataSource = mant_HistorialDataService.listartodos(tipo, id, (Int32)cboPeriodo.SelectedValue);
        }

        private void toolNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_HistorialPC_detalle frm_HistorialPC_detalle = new Frm_HistorialPC_detalle(id, tipo);
                frm_HistorialPC_detalle.StartPosition = FormStartPosition.CenterParent;
                frm_HistorialPC_detalle.ShowDialog();
                Mant_HistorialDataService mant_HistorialDataService = new Mant_HistorialDataService();
                dgHistorial.DataSource = mant_HistorialDataService.listartodos(tipo, id, (Int32)cboPeriodo.SelectedValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private Mant_Historial obtenerDatos()
        {
            Mant_Historial mant_Historial = new Mant_Historial();
            mant_Historial.idHistorial = (Int32)(dgHistorial.SelectedRows[0].Cells["idHistorial"].Value);
            if(tipo == 2)               
                mant_Historial.idPredio = (string)dgHistorial.SelectedRows[0].Cells["idPredio"].Value.ToString().TrimEnd();
            else
                mant_Historial.idPersona = (string)dgHistorial.SelectedRows[0].Cells["idPersona"].Value.ToString().TrimEnd();
            mant_Historial.tipo = (Int32)(dgHistorial.SelectedRows[0].Cells["tipo_"].Value);
            mant_Historial.idPeriodo = (Int32)(dgHistorial.SelectedRows[0].Cells["idPeriodo"].Value);
            mant_Historial.Descripcion = (string)dgHistorial.SelectedRows[0].Cells["descripcion"].Value.ToString().TrimEnd();
            mant_Historial.Obligacion = (string)dgHistorial.SelectedRows[0].Cells["obligacion"].Value.ToString().TrimEnd();
            mant_Historial.Expediente = (string)dgHistorial.SelectedRows[0].Cells["expediente"].Value.ToString().TrimEnd();
            mant_Historial.TipoOperacion = (Int32)(dgHistorial.SelectedRows[0].Cells["tipoOperacion"].Value);
            mant_Historial.tipoOperDescrip = (string)dgHistorial.SelectedRows[0].Cells["tipoOperDescrip"].Value.ToString().TrimEnd();
            mant_Historial.tipoDocumento = (string)dgHistorial.SelectedRows[0].Cells["tipoDocumento"].Value.ToString().TrimEnd();
            mant_Historial.registro_user_add = (string)dgHistorial.SelectedRows[0].Cells["registro_user_add"].Value.ToString().TrimEnd();
            mant_Historial.registro_user_update = (string)dgHistorial.SelectedRows[0].Cells["registro_user_update"].Value.ToString().TrimEnd();
            mant_Historial.registro_pc_add = (string)dgHistorial.SelectedRows[0].Cells["registro_pc_add"].Value.ToString().TrimEnd();
            mant_Historial.registro_pc_update = (string)dgHistorial.SelectedRows[0].Cells["registro_pc_update"].Value.ToString().TrimEnd();
            mant_Historial.estado = (bool)dgHistorial.SelectedRows[0].Cells["estado"].Value;
            return mant_Historial;
        }

        private void toolEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgHistorial.CurrentRow == null)
                    throw new Exception("Debe seleccionar una fila.");
                Globales.validado = 0;
                Frm_HistorialPC_detalle frm_HistorialPC_detalle = new Frm_HistorialPC_detalle(obtenerDatos());
                frm_HistorialPC_detalle.StartPosition = FormStartPosition.CenterParent;
                frm_HistorialPC_detalle.ShowDialog();

                dgHistorial.DataSource = mant_HistorialDataService.listartodos(tipo, id, (Int32)cboPeriodo.SelectedValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
