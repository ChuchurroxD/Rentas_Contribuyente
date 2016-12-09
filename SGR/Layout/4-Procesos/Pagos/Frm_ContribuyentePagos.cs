using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGR.Core.Repository;
using SGR.Core.Service;
using SGR.Entity;
using SGR.Entity.Model;

using WeifenLuo.WinFormsUI.Docking;

namespace SGR.WinApp.Layout._4_Procesos.Pagos
{
    public partial class Frm_ContribuyentePagos : DockContent
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
        public Frm_ContribuyentePagos()
        {
            InitializeComponent();
            rbtSeleccionado("rbtNDoc");
            llenarTipoSector();
        }
        private string CambiarTexto(string txt)
        {
            if (txt.TrimEnd() == "")
                return "%";
            return txt.TrimEnd();
        }
        private void Frm_ContribuyentePagos_Load(object sender, EventArgs e)
        {
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (rbtNDoc.Checked)
            {
                dgvContribuyenteBuscados.DataSource = mant_ContribuyenteDataService.listarBuscados('%' + txtNDocu.Text.Trim() + '%', 9, "ruc", GlobalesV1.Global_int_idoficina);
            }
            else
            {
                if (rbtCodContribuyente.Checked)
                {
                    dgvContribuyenteBuscados.DataSource = mant_ContribuyenteDataService.listarBuscados(txtCodContribuyente.Text.Trim(), 10, "persona_id", GlobalesV1.Global_int_idoficina);
                }
                else
                {
                    if (rbtNombre.Checked)
                    {
                        dgvContribuyenteBuscados.DataSource = mant_ContribuyenteDataService.listarBuscados('%' + txtNomRazon.Text.TrimEnd() + '%', 11, "razon_social", GlobalesV1.Global_int_idoficina);
                    }
                    else
                    {
                        if (rbtDirección.Checked)
                        {
                            int junv = 0;
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
                            dgvContribuyenteBuscados.DataSource = mant_ContribuyenteDataService.listarBuscadosxDireccion(mant_Contribuyente1, GlobalesV1.Global_int_idoficina);
                        }
                    }
                }
            }
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
        public void llenarTipoSector()
        {
            //llenar combos para busqueda            
            cboSectorB.DisplayMember = "descripcion";
            cboSectorB.ValueMember = "sector_id";
            cboSectorB.DataSource = pred_SectorDataService.listarSectorCbo(GlobalesV1.Global_int_idoficina);
            //cboCalleB.DisplayMember = "Descripcion";
            //cboCalleB.ValueMember = "Via_id";
            //cboCalleB.DataSource = pred_ViasDataService.listarViasCboCodAntiguo("130107");
        }
        private Mant_Per_Cont obtenerDatosParaModificar(Mant_Per_Cont mant_Per_Conta)
        {

            mant_Per_Conta.departamento = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["departamento"].Value;
            mant_Per_Conta.provincia = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["provincia"].Value;
            mant_Per_Conta.via_ID = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["via_ID"].Value;
            mant_Per_Conta.c_via = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["c_via"].Value;
            mant_Per_Conta.c_junta = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["c_junta"].Value;
            mant_Per_Conta.junta_ID = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["junta_ID"].Value;
            mant_Per_Conta.c_dpto = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["c_dpto"].Value;
            mant_Per_Conta.C_edificio = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["C_edificio"].Value;
            mant_Per_Conta.c_interior = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["c_interior"].Value;
            mant_Per_Conta.c_lote = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["c_lote"].Value;
            mant_Per_Conta.c_mz = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["c_mz"].Value;
            mant_Per_Conta.c_num = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["c_num"].Value;
            mant_Per_Conta.c_piso = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["c_piso"].Value;
            mant_Per_Conta.c_tienda = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["c_tienda"].Value;
            mant_Per_Conta.celular = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["celular"].Value;
            mant_Per_Conta.Contacto = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["Contacto"].Value;
            mant_Per_Conta.DireccRepresentante = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["DireccRepresentante"].Value;
            mant_Per_Conta.distrito = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["distrito"].Value;
            mant_Per_Conta.dniRepresentante = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["dniRepresentante"].Value;
            mant_Per_Conta.documento = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["documento"].Value;
            mant_Per_Conta.Dpto = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["Dpto"].Value;
            mant_Per_Conta.edificio = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["edificio"].Value;
            mant_Per_Conta.email = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["email"].Value;
            mant_Per_Conta.expediente = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["expediente"].Value;
            mant_Per_Conta.fechaNacimiento = (DateTime)dgvContribuyenteBuscados.SelectedRows[0].Cells["fechaNacimiento"].Value;
            mant_Per_Conta.Fono_Domicilio = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["Fono_Domicilio"].Value;
            mant_Per_Conta.fono_oficina = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["fono_oficina"].Value;
            mant_Per_Conta.interior = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["interior"].Value;
            mant_Per_Conta.junta_ID = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["junta_ID"].Value;
            mant_Per_Conta.Lote = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["Lote"].Value;
            mant_Per_Conta.materno = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["materno"].Value;
            mant_Per_Conta.mz = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["mz"].Value;
            mant_Per_Conta.nombres = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["nombres"].Value;
            mant_Per_Conta.num_via = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["num_via"].Value;
            mant_Per_Conta.paterno = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["paterno"].Value;
            mant_Per_Conta.persona_ID = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["persona_ID"].Value;
            mant_Per_Conta.piso = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["piso"].Value;
            mant_Per_Conta.referencia = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["referencia"].Value;
            mant_Per_Conta.tienda = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["tienda"].Value;
            mant_Per_Conta.tipo_documento = (Int16)dgvContribuyenteBuscados.SelectedRows[0].Cells["tipo_documento"].Value;
            mant_Per_Conta.tipo_persona = (Int16)dgvContribuyenteBuscados.SelectedRows[0].Cells["tipo_persona"].Value;
            mant_Per_Conta.via_ID = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["via_ID"].Value;
            mant_Per_Conta.Sexo = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["Sexo"].Value;

            return mant_Per_Conta;
        }
        private void dgvContribuyenteBuscados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                string persona = (string)dgvContribuyenteBuscados.Rows[e.RowIndex].Cells["persona_ID"].Value;
                string documento = (string)dgvContribuyenteBuscados.Rows[e.RowIndex].Cells["documento"].Value;
                string direccion = (string)dgvContribuyenteBuscados.Rows[e.RowIndex].Cells["DireccRepresentante"].Value;
                string nombres = ((string)dgvContribuyenteBuscados.Rows[e.RowIndex].Cells["nombres"].Value).TrimEnd() + " " +
                                 ((string)dgvContribuyenteBuscados.Rows[e.RowIndex].Cells["paterno"].Value).TrimEnd() + " " +
                                 ((string)dgvContribuyenteBuscados.Rows[e.RowIndex].Cells["materno"].Value).TrimEnd();
                Frm_CalculaPago Frm_Liqui = new Frm_CalculaPago(nombres,persona, documento, " ");
                Frm_Liqui.StartPosition = FormStartPosition.CenterParent;
                Frm_Liqui.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo invocar el formulario");
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void cboSectorB_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCalleB.ValueMember = "Via_Id";
            cboCalleB.DisplayMember = "Descripcion";
            cboCalleB.DataSource = pred_ViasDataService.listarViasPorSector(cboSectorB.SelectedValue.ToString(), GlobalesV1.Global_int_idoficina);
        }
    }
}
