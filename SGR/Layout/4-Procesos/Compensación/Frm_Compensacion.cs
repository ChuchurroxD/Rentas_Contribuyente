using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using SGR.Core.Service;
using SGR.Entity;

namespace SGR.WinApp.Layout._4_Procesos.Compensación
{
    public partial class Frm_Compensacion : DockContent
    {
        private List<Mant_Per_Cont> coleccion;
        private Mant_ContribuyenteDataService Mant_ContribuyenteDataService = new Mant_ContribuyenteDataService();
        private Pred_ViasDataService Pred_ViasDataService = new Pred_ViasDataService();
        private Pred_SectorDataService Pred_SectorDataService = new Pred_SectorDataService();
        private Mant_JuntaViaDataService mant_JuntaViaDataService = new Mant_JuntaViaDataService();

        public Frm_Compensacion()
        {
            InitializeComponent();
            llenarTipoSector();
            seleccionrbt("rbtNumDoc");
        }

        private void llenarTipoSector()
        {
            cboSector.DisplayMember = "descripcion";
            cboSector.ValueMember = "sector_id";
            cboSector.DataSource = Pred_SectorDataService.listarSectorCbo(GlobalesV1.Global_int_idoficina);
        }
        private void seleccionrbt(string seleccion)
        {
            switch (seleccion)
            {
                case "rbtNumDoc":
                    pContribuyente.Enabled = true;
                    pDireccion.Enabled = false;
                    txtCodContribuyente.Enabled = false;
                    txtNombre.Enabled = false;
                    txtNumDoc.Enabled = true;
                    break;
                case "rbtCodContribuyente":
                    pContribuyente.Enabled = true;
                    pDireccion.Enabled = false;
                    txtNumDoc.Enabled = false;
                    txtNombre.Enabled = false;
                    txtCodContribuyente.Enabled = true;
                    break;
                case "rbtNombre":
                    pContribuyente.Enabled = true;
                    pDireccion.Enabled = false;
                    txtNumDoc.Enabled = false;
                    txtCodContribuyente.Enabled = false;
                    txtNombre.Enabled = true;
                    break;
                case "rbtDireccion":
                    pContribuyente.Enabled = false;
                    pDireccion.Enabled = true;
                    break;
            }
        }
        private string CambiarTexto(string txt)
        {
            if (txt.TrimEnd() == "")
                return "%";
            return txt.TrimEnd();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbtNumdoc.Checked)
                {
                    coleccion = Mant_ContribuyenteDataService.listarBuscados('%' + txtNumDoc.Text.Trim() + '%', 9, "ruc", GlobalesV1.Global_int_idoficina);
                    dataGridView1.DataSource = coleccion;
                }
                if (rbtCodContribuyente.Checked)
                {
                    coleccion = Mant_ContribuyenteDataService.listarBuscados(txtCodContribuyente.Text.Trim(), 10, "persona_id", GlobalesV1.Global_int_idoficina);
                    dataGridView1.DataSource = coleccion;
                }
                if (rbtNombre.Checked)
                {
                    coleccion = Mant_ContribuyenteDataService.listarBuscados(txtNombre.Text.TrimEnd(), 11, "razon_social", GlobalesV1.Global_int_idoficina);
                    dataGridView1.DataSource = coleccion;
                }
                if (rbtDireccion.Checked)
                {
                    int junv = 0;
                    Mant_Contribuyente mant_Contribuyente = new Mant_Contribuyente();
                    junv = mant_JuntaViaDataService.GetJuntaVia_id(int.Parse(cboSector.SelectedValue.ToString()), int.Parse(cboCalle.SelectedValue.ToString()));
                    //if es tipo 15 
                    if (junv != 0)
                        mant_Contribuyente.ruc = junv.ToString();
                    else
                        mant_Contribuyente.ruc = "%";
                    //if cambio  a tipo 14 mant_Contribuyente1.Junta_via=junv
                    mant_Contribuyente.c_dpto = CambiarTexto(txtDpto.Text.TrimEnd());
                    mant_Contribuyente.c_interior = CambiarTexto(txtInterior.Text.TrimEnd());
                    mant_Contribuyente.c_lote = CambiarTexto(txtLote.Text.TrimEnd());
                    mant_Contribuyente.c_mz = CambiarTexto(txtMz.Text.TrimEnd());
                    mant_Contribuyente.c_num = CambiarTexto(txtNroVia.Text.TrimEnd());
                    mant_Contribuyente.c_piso = CambiarTexto(txtPiso.Text.TrimEnd());
                    mant_Contribuyente.c_edificio = CambiarTexto(txtEdificio.Text.TrimEnd());
                    mant_Contribuyente.c_tienda = CambiarTexto(txtTienda.Text.TrimEnd());
                    coleccion = Mant_ContribuyenteDataService.listarBuscadosxDireccion(mant_Contribuyente, GlobalesV1.Global_int_idoficina);
                    dataGridView1.DataSource = coleccion;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cboSector_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCalle.DisplayMember = "Descripcion";
            cboCalle.ValueMember = "Via_id";
            cboCalle.DataSource = Pred_ViasDataService.listarViasPorSectorv2(cboSector.SelectedValue.ToString());
        }

        private void rbtNumdoc_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtNumdoc.Checked)
                seleccionrbt("rbtNumDoc");
        }

        private void rbtCodContribuyente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtCodContribuyente.Checked)
                seleccionrbt("rbtCodContribuyente");
        }

        private void rbtNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtNombre.Checked)
                seleccionrbt("rbtNombre");
        }

        private void rbtDireccion_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtDireccion.Checked)
                seleccionrbt("rbtDireccion");
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Frm_Compensacion_Contribuyente frm_Compensacion_Contribuyente = new Frm_Compensacion_Contribuyente(obtenerObjeto());
                frm_Compensacion_Contribuyente.StartPosition = FormStartPosition.CenterParent;
                frm_Compensacion_Contribuyente.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private Mant_Per_Cont obtenerObjeto()
        {
            try
            {
                Mant_Per_Cont Mant_Per_Cont = new Mant_Per_Cont();
                Mant_Per_Cont.persona_ID = (string)dataGridView1.SelectedRows[0].Cells["persona_ID"].Value;
                Mant_Per_Cont.documento = (string)dataGridView1.SelectedRows[0].Cells["documento"].Value;
                Mant_Per_Cont.paterno = (string)dataGridView1.SelectedRows[0].Cells["paterno"].Value;
                Mant_Per_Cont.materno = (string)dataGridView1.SelectedRows[0].Cells["materno"].Value;
                Mant_Per_Cont.nombres = (string)dataGridView1.SelectedRows[0].Cells["nombres"].Value;
                Mant_Per_Cont.direccCompleta = (string)dataGridView1.SelectedRows[0].Cells["direccion"].Value;
                return Mant_Per_Cont;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }
        }
    }
}
