using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGR.Core.Service;
using SGR.Entity;
using Microsoft.Reporting.WinForms;
using SGR.Entity.Model;
namespace SGR.WinApp.Layout._1_Tablas_Maestras.Relacion_Contribuyente
{
    public partial class Frm_Relacion_Contribuyente : Form
    {
        private String cont_id = "";
        private Mant_Relacion_ContribuyenteDataService mant_Relacion_ContribuyenteDataService = new Mant_Relacion_ContribuyenteDataService();
        public Frm_Relacion_Contribuyente()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }
        public Frm_Relacion_Contribuyente(String allegado, String nombreallegado)
        {
            try
            {
                InitializeComponent();
                this.cont_id = allegado;
                lblPersona.Text = nombreallegado + " - " + allegado;
                dgvRelCOntribuyente.DataSource = mant_Relacion_ContribuyenteDataService.listartodos(cont_id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }
        private void toolnuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_Relacion_Contribuyente_Detalle Frm_Relacion_Contribuyente_Detalle = new Frm_Relacion_Contribuyente_Detalle(cont_id);
                Frm_Relacion_Contribuyente_Detalle.StartPosition = FormStartPosition.CenterParent;
                Frm_Relacion_Contribuyente_Detalle.ShowDialog();
                dgvRelCOntribuyente.DataSource = mant_Relacion_ContribuyenteDataService.listartodos(cont_id);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
           
        }

        private void tooleditar_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_Relacion_Contribuyente_Detalle Frm_Relacion_Contribuyente_Detalle = new Frm_Relacion_Contribuyente_Detalle(obtenerdatos());
                Frm_Relacion_Contribuyente_Detalle.StartPosition = FormStartPosition.CenterParent;
                Frm_Relacion_Contribuyente_Detalle.ShowDialog();
                dgvRelCOntribuyente.DataSource = mant_Relacion_ContribuyenteDataService.listartodos(cont_id);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void dgvRelCOntribuyente_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tooleditar.PerformClick();
        }
        private Mant_Relacion_Contribuyente obtenerdatos()
        {
            Mant_Relacion_Contribuyente mant_Relacion_Contribuyente = new Mant_Relacion_Contribuyente();
            mant_Relacion_Contribuyente.estado = (bool)dgvRelCOntribuyente.SelectedRows[0].Cells["estado"].Value;
            mant_Relacion_Contribuyente.relacion_ID = (int)dgvRelCOntribuyente.SelectedRows[0].Cells["relacion_ID"].Value;
            mant_Relacion_Contribuyente.tipo_relacion = (int)dgvRelCOntribuyente.SelectedRows[0].Cells["tipo_relacion"].Value;
            return mant_Relacion_Contribuyente;
        }

        private void tooleliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRelCOntribuyente.SelectedRows.Count > 0)
                {
                    bool es= (bool)dgvRelCOntribuyente.SelectedRows[0].Cells["estado"].Value;
                    if(es)
                    {
                        Mant_Relacion_Contribuyente mant_Relacion_Contribuyente = new Mant_Relacion_Contribuyente();
                        mant_Relacion_Contribuyente.relacion_ID = (int)dgvRelCOntribuyente.SelectedRows[0].Cells["relacion_ID"].Value;
                        mant_Relacion_Contribuyente.tipo_relacion = (int)dgvRelCOntribuyente.SelectedRows[0].Cells["tipo_relacion"].Value;
                        mant_Relacion_Contribuyente.estado = false;
                        mant_Relacion_ContribuyenteDataService.Update(mant_Relacion_Contribuyente);
                            MessageBox.Show("Se Desactivó el registro Correctamente", Globales.Global_MessageBox);
                        }
                    else MessageBox.Show("Debe de seleccionar un registro", Globales.Global_MessageBox);
                }
                else
                    MessageBox.Show("Debe de seleccionar un registro", Globales.Global_MessageBox);
                Frm_Relacion_Contribuyente_Detalle Frm_Relacion_Contribuyente_Detalle = new Frm_Relacion_Contribuyente_Detalle(obtenerdatos());
                Frm_Relacion_Contribuyente_Detalle.StartPosition = FormStartPosition.CenterParent;
                Frm_Relacion_Contribuyente_Detalle.ShowDialog();
                dgvRelCOntribuyente.DataSource = mant_Relacion_ContribuyenteDataService.listartodos(cont_id);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }

        }
    }
}
