using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using SGR.Core.Service;
using SGR.Entity.Model;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using SGR.Entity;

namespace SGR.WinApp.Layout._4_Procesos.Plataforma.ConsultarPlataforma
{
    public partial class Frm_ConsultarPlataforma : DockContent
    {
        Conf_MultitablaDataService conf_MultitablaDataService = new Conf_MultitablaDataService();
        Conf_UbicacionDataService conf_UbicacionDataService = new Conf_UbicacionDataService();
        Pred_SectorDataService pred_SectorDataService = new Pred_SectorDataService();
        Pred_ViasDataService pred_ViasDataService = new Pred_ViasDataService();
        Mant_PersonaDataService mant_PersonaDataService = new Mant_PersonaDataService();
        Mant_ContribuyenteDataService mant_ContribuyenteDataService = new Mant_ContribuyenteDataService();
        Mant_JuntaViaDataService mant_JuntaViaDataService = new Mant_JuntaViaDataService();
        private List<Mant_Per_Cont> Coleccion;
        private SortOrder Orden = new SortOrder();
        public Frm_ConsultarPlataforma()
        {
            InitializeComponent();
            rbtSeleccionado("rbtNDoc");
            llenarTipoSector();
        }
        public void llenarTipoSector()
        {
            //llenar combos para busqueda            
            cboSectorB.DisplayMember = "descripcion";
            cboSectorB.ValueMember = "sector_id";
            cboSectorB.DataSource = pred_SectorDataService.listarSectorCbo(GlobalesV1.Global_int_idoficina);
        }
        private string CambiarTexto(string txt)
        {
            if (txt.TrimEnd() == "")
                return "%";
            return txt.TrimEnd();
        }
        private void limpiarParaBusqueda()
        {
            txtNDocu.Text = "";
            txtCodContribuyente.Text = "";
            txtNomRazon.Text = "";
            cboCalleB.Text = "";
            cboSectorB.Text = "";
            txtViaB.Text = "";
            txtPisoB.Text = "";
            txtTiendaB.Text = "";
            txtInteriorB.Text = "";
            txtManzanaB.Text = "";
            txtEdificioB.Text = "";
            txtDptoB.Text = "";
            txtLoteB.Text = "";
        }
        private void rbtSeleccionado(string rbtselec)
        {
            limpiarParaBusqueda();
            switch (rbtselec)
            {
                case "rbtNDoc":
                    txtNDocu.Enabled = true;
                    txtCodContribuyente.Enabled = false;
                    txtNomRazon.Enabled = false;
                    cboCalleB.Enabled = false;
                    cboSectorB.Enabled = false;
                    txtViaB.Enabled = false;
                    txtPisoB.Enabled = false;
                    txtTiendaB.Enabled = false;
                    txtInteriorB.Enabled = false;
                    txtManzanaB.Enabled = false;
                    txtEdificioB.Enabled = false;
                    txtDptoB.Enabled = false;
                    txtLoteB.Enabled = false;
                    break;
                case "rbtCodContribuyente":
                    txtNDocu.Enabled = false;
                    txtCodContribuyente.Enabled = true;
                    txtNomRazon.Enabled = false;
                    cboCalleB.Enabled = false;
                    cboSectorB.Enabled = false;
                    txtViaB.Enabled = false;
                    txtPisoB.Enabled = false;
                    txtTiendaB.Enabled = false;
                    txtInteriorB.Enabled = false;
                    txtManzanaB.Enabled = false;
                    txtEdificioB.Enabled = false;
                    txtDptoB.Enabled = false;
                    txtLoteB.Enabled = false;
                    break;
                case "rbtNombre":
                    txtNDocu.Enabled = false;
                    txtCodContribuyente.Enabled = false;
                    txtNomRazon.Enabled = true;
                    cboCalleB.Enabled = false;
                    cboSectorB.Enabled = false;
                    txtViaB.Enabled = false;
                    txtPisoB.Enabled = false;
                    txtTiendaB.Enabled = false;
                    txtInteriorB.Enabled = false;
                    txtManzanaB.Enabled = false;
                    txtEdificioB.Enabled = false;
                    txtDptoB.Enabled = false;
                    txtLoteB.Enabled = false;
                    break;
                case "rbtDirección":
                    txtNDocu.Enabled = false;
                    txtCodContribuyente.Enabled = false;
                    txtNomRazon.Enabled = false;
                    cboCalleB.Enabled = true;
                    cboSectorB.Enabled = true;
                    txtViaB.Enabled = true;
                    txtPisoB.Enabled = true;
                    txtTiendaB.Enabled = true;
                    txtInteriorB.Enabled = true;
                    txtManzanaB.Enabled = true;
                    txtEdificioB.Enabled = true;
                    txtDptoB.Enabled = true;
                    txtLoteB.Enabled = true;
                    break;
                case "rbtCPredio":
                    txtNDocu.Enabled = false;
                    txtCodContribuyente.Enabled = false;
                    txtNomRazon.Enabled = false;
                    cboCalleB.Enabled = false;
                    cboSectorB.Enabled = false;
                    txtViaB.Enabled = false;
                    txtPisoB.Enabled = false;
                    txtTiendaB.Enabled = false;
                    txtInteriorB.Enabled = false;
                    txtManzanaB.Enabled = false;
                    txtEdificioB.Enabled = false;
                    txtDptoB.Enabled = false;
                    txtLoteB.Enabled = false;
                    break;
                case "rbtExpediente":
                    txtNDocu.Enabled = false;
                    txtCodContribuyente.Enabled = false;
                    txtNomRazon.Enabled = false;
                    cboCalleB.Enabled = false;
                    cboSectorB.Enabled = false;
                    txtViaB.Enabled = false;
                    txtPisoB.Enabled = false;
                    txtTiendaB.Enabled = false;
                    txtInteriorB.Enabled = false;
                    txtManzanaB.Enabled = false;
                    txtEdificioB.Enabled = false;
                    txtDptoB.Enabled = false;
                    txtLoteB.Enabled = false;
                    break;

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (rbtNDoc.Checked)
            {
                dataGridView1.DataSource = mant_ContribuyenteDataService.listarBuscados1('%' + txtNDocu.Text.Trim() + '%', 23, "ruc",GlobalesV1.Global_int_idoficina);
            }
            else
            {
                if (rbtCodContribuyente.Checked)
                {
                    dataGridView1.DataSource = mant_ContribuyenteDataService.listarBuscados1(txtCodContribuyente.Text.Trim(), 24, "persona_id", GlobalesV1.Global_int_idoficina);
                }
                else
                {
                    if (rbtNombre.Checked)
                    {
                        dataGridView1.DataSource = mant_ContribuyenteDataService.listarBuscados1('%' + txtNomRazon.Text.TrimEnd() + '%', 25, "razon_social", GlobalesV1.Global_int_idoficina);
                    }
                    else
                    {
                        if (rbtDirección.Checked)
                        {
                            int junv = 0; if (cboCalleB.SelectedIndex == -1)
                            {
                                MessageBox.Show("No hay contribuyentes en ese sector", Globales.Global_MessageBox);
                                return;
                            }
                            Mant_Contribuyente mant_Contribuyente1 = new Mant_Contribuyente();
                            junv = mant_JuntaViaDataService.GetJuntaVia_id(int.Parse(cboSectorB.SelectedValue.ToString()), int.Parse(cboCalleB.SelectedValue.ToString()));
                            //if es tipo 15 
                            if (junv != 0)
                                mant_Contribuyente1.ruc = junv.ToString();
                            else
                                mant_Contribuyente1.ruc = "%";
                            //if cambio  a tipo 14 mant_Contribuyente1.Junta_via=junv
                            mant_Contribuyente1.c_dpto = CambiarTexto(txtDptoB.Text.TrimEnd());
                            mant_Contribuyente1.c_interior = CambiarTexto(txtInteriorB.Text.TrimEnd());
                            mant_Contribuyente1.c_lote = CambiarTexto(txtLoteB.Text.TrimEnd());
                            mant_Contribuyente1.c_mz = CambiarTexto(txtManzanaB.Text.TrimEnd());
                            mant_Contribuyente1.c_num = CambiarTexto(txtViaB.Text.TrimEnd());
                            mant_Contribuyente1.c_piso = CambiarTexto(txtPisoB.Text.TrimEnd());
                            mant_Contribuyente1.c_edificio = CambiarTexto(txtEdificioB.Text.TrimEnd());
                            mant_Contribuyente1.c_tienda = CambiarTexto(txtTiendaB.Text.TrimEnd());
                            dataGridView1.DataSource = mant_ContribuyenteDataService.listarBuscadosxDireccion1(mant_Contribuyente1);
                        }
                    }
                }
            }
        }
        private void rbtNDoc_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtNDoc.Checked)
            {
                rbtSeleccionado("rbtNDoc");
            }
        }

        private void rbtCodContribuyente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtCodContribuyente.Checked)
            {
                rbtSeleccionado("rbtCodContribuyente");
            }
        }

        private void rbtNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtNombre.Checked)
            {
                rbtSeleccionado("rbtNombre");
            }
        }

        private void rbtDirección_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtDirección.Checked)
            {
                rbtSeleccionado("rbtDirección");
            }
        }

        private void cboSectorB_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCalleB.ValueMember = "Via_Id";
            cboCalleB.DisplayMember = "Descripcion";
            cboCalleB.DataSource = pred_ViasDataService.listarViasPorSector(cboSectorB.SelectedValue.ToString(), GlobalesV1.Global_int_idoficina);
        }

        private void dgvContribuyenteBuscados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                Mant_Cont Mant_Cont = new Mant_Cont();
                Mant_Cont.persona_ID = (string)dataGridView1.Rows[e.RowIndex].Cells["persona_ID"].Value;
                Mant_Cont.nombres = ((string)dataGridView1.Rows[e.RowIndex].Cells["nombres"].Value).TrimEnd() + " " +
                                 ((string)dataGridView1.Rows[e.RowIndex].Cells["paterno"].Value).TrimEnd() + " " +
                                 ((string)dataGridView1.Rows[e.RowIndex].Cells["materno"].Value).TrimEnd();
                Mant_Cont.direccCompleta = (string)dataGridView1.Rows[e.RowIndex].Cells["direccCompleta"].Value;
                Mant_Cont.documento = ((string)dataGridView1.Rows[e.RowIndex].Cells["tipoDocumentoDescripcion"].Value).TrimEnd() + " " +
                                   ((string)dataGridView1.Rows[e.RowIndex].Cells["documento"].Value).TrimEnd();
                Mant_Cont.sector = (string)dataGridView1.Rows[e.RowIndex].Cells["sector"].Value;
                Mant_Cont.estado_contribuyente = (string)dataGridView1.Rows[e.RowIndex].Cells["estado_contribuyente"].Value;
                Frm_ConsultarPlataformaDetalle Frm_Detalle = new Frm_ConsultarPlataformaDetalle(Mant_Cont);
                Frm_Detalle.StartPosition = FormStartPosition.CenterParent;
                Frm_Detalle.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,Globales.Global_MessageBox,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
    }
}
