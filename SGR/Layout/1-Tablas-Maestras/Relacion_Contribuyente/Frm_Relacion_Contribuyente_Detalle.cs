
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
   
    public partial class Frm_Relacion_Contribuyente_Detalle : Form
    {
        String allegado_id = "44";
        string usser = GlobalesV1.Global_str_Usuario;
        private Mant_Relacion_ContribuyenteDataService mant_Relacion_ContribuyenteDataService = new Mant_Relacion_ContribuyenteDataService();
        private Conf_MultitablaDataService conf_MultitablaDataService = new Conf_MultitablaDataService();
        private Conf_UbicacionDataService conf_UbicacionDataService = new Conf_UbicacionDataService();
        private Pred_SectorDataService pred_SectorDataService = new Pred_SectorDataService();
        private Pred_ViasDataService pred_ViasDataService = new Pred_ViasDataService();
        private Mant_Persona mant_personaa = new Mant_Persona();
        private Mant_JuntaViaDataService mant_JuntaViaDataService = new Mant_JuntaViaDataService();
        private Mant_PersonaDataService mant_PersonaDataService = new Mant_PersonaDataService();
        private Sistema.Globales.Validaciones obValidacion = new Sistema.Globales.Validaciones();
        private int edicion = 0;
        public Frm_Relacion_Contribuyente_Detalle(string allegado)
        {
            try {
                InitializeComponent();
                this.allegado_id = allegado;
                maxTextos();
                llenarTipoSector();
                txtId.Enabled = true;
                txtId.Text = mant_PersonaDataService.GetIdPersonaMax().ToString();
                llenarcboMultitabla(cboTipoRelacion, "Multc_vDescripcion", "Multc_cValor", "23");
                mostrarTab(1);
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), Globales.Global_MessageBox);
            }
            
        }
        public Frm_Relacion_Contribuyente_Detalle(Mant_Relacion_Contribuyente mant_Relacion_Contribuyente)
        {
            try
            {
                InitializeComponent();
                maxTextos();
                llenarTipoSector();
                txtId.Enabled = true;
                txtId.Text = mant_PersonaDataService.GetIdPersonaMax().ToString();
                llenarcboMultitabla(cboTipoRelacion, "Multc_vDescripcion", "Multc_cValor", "23");
                cboTipoPersona.SelectedValue = mant_Relacion_Contribuyente.tipo_relacion;
                ckbActivo.Checked = mant_Relacion_Contribuyente.estado;
                txtidrel.Text = mant_Relacion_Contribuyente.relacion_ID.ToString();
                edicion = 1;
                rbtNuevaPersona.Enabled = false;
                radioButton1.Enabled = false;
                this.tbcGeneral.Controls.Clear();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Globales.Global_MessageBox);
            }
        }

        private void rbtNuevaPersona_CheckedChanged(object sender, EventArgs e)
        {
            mostrarTab(1);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            mostrarTab(2);
        }
        private void mostrarTab(int tipo)
        {
            this.tbcGeneral.Controls.Clear();
            if(tipo==1)
                this.tbcGeneral.Controls.Add(this.tbpNuevaPersona);
            else
                this.tbcGeneral.Controls.Add(this.tbpPersonaExistente);
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                Mant_Relacion_Contribuyente mant_Relacion_Contribuyente = new Mant_Relacion_Contribuyente();
                mant_Relacion_Contribuyente.tipo_relacion = Convert.ToInt32(cboTipoRelacion.SelectedValue);
                mant_Relacion_Contribuyente.estado = ckbActivo.Checked;
                mant_Relacion_Contribuyente.registro_user_update = usser;
                if (edicion == 1)
                {
                    mant_Relacion_Contribuyente.relacion_ID = Convert.ToInt32(txtidrel.Text);
                    mant_Relacion_ContribuyenteDataService.Update(mant_Relacion_Contribuyente);
                    MessageBox.Show("Se Grabó Correctamente", Globales.Global_MessageBox);
                    this.Dispose();
                }
                else
                {
                    mant_Relacion_Contribuyente.cod_allegado = allegado_id;
                    mant_Relacion_Contribuyente.registro_user_add = usser;
                    if (rbtNuevaPersona.Checked)//persona nueva
                    {
                        if (!VerificarCombos())
                        {
                            MessageBox.Show("Falta llenar combos", Globales.Global_MessageBox);
                            return;
                        }
                        int junta_via; string elementoFaltante = verificarTexto("");
                        junta_via = mant_JuntaViaDataService.GetJuntaVia_id(int.Parse(cboSector.SelectedValue.ToString()), int.Parse(cboCalle.SelectedValue.ToString()));
                        if (elementoFaltante.Length != 0)
                            {
                                MessageBox.Show("Falta registros", Globales.Global_MessageBox);
                                return;
                            }
                            Mant_Persona mant_Persona = new Mant_Persona();
                            mant_Persona.Declaracion = "";
                            mant_Persona.documento = txtNDoc.Text.Trim();
                            mant_Persona.Dpto = txtDpto.Text.TrimEnd();
                            mant_Persona.email = txtEmail.Text.Trim();
                            mant_Persona.ESTADO = true;
                            mant_Persona.expediente = txtExpediente.Text.Trim();
                            mant_Persona.Fono_Domicilio = txtFonoDomicilio.Text.Trim();
                            mant_Persona.fono_oficina = txtFnoOficina.Text.Trim();
                            mant_Persona.interior = txtInterior.Text.TrimEnd();
                            mant_Persona.junta_via_ID = junta_via;
                            mant_Persona.Lote = txtLote.Text.TrimEnd();
                            mant_Persona.materno = txtMaterno.Text.TrimEnd();
                            mant_Persona.mz = txtMz.Text.Trim();
                            mant_Persona.NombreCompleto = txtPaterno.Text.TrimEnd() + " " + txtMaterno.Text.TrimEnd() + " " + txtNombre.Text.TrimEnd();
                            mant_Persona.nombres = txtNombre.Text.TrimEnd();
                            mant_Persona.num_via = txtVia.Text.TrimEnd();
                            mant_Persona.Observacion = "";
                            mant_Persona.OtraDireccion = cboCalle.SelectedText;
                            mant_Persona.paterno = txtPaterno.Text.TrimEnd();
                            mant_Persona.per_edad = "0";
                            mant_Persona.registro_user = usser;
                            mant_Persona.Sector = cboSector.SelectedText;
                            mant_Persona.tipo_documento = Int16.Parse(cboTipoDoc.SelectedValue.ToString());
                            mant_Persona.tipo_persona = Int16.Parse(cboTipoPersona.SelectedValue.ToString());
                            mant_Persona.fechaNacimiento = DateTime.Parse(dtpFNacimiento.Text.ToString());
                            mant_Persona.edificio = txtEdificio.Text.TrimEnd();
                            mant_Persona.piso = txtPiso.Text.TrimEnd();
                            mant_Persona.tienda = txtTienda.Text.TrimEnd();
                            mant_Persona.celular = txtCelular.Text.TrimEnd();
                            mant_Persona.Ubi_codigo = cboDistrito.SelectedValue.ToString();
                       if (rbtFemenino.Checked)
                                mant_Persona.sexo = "F";
                       else
                                mant_Persona.sexo = "M";
                      //if (!mant_PersonaDataService.GetExisteCodigo(txtId.Text.Trim()))
                      //{
                            //if (!mant_PersonaDataService.GetExistePersona(txtNDoc.Text.Trim(), Int16.Parse(cboTipoDoc.SelectedValue.ToString())))
                            //{
                            //mant_Relacion_Contribuyente.persona_ID = mant_Persona.persona_ID;// = txtId.Text;//mant_PersonaDataService.GetIdPersonaMax().ToString();
                                //if (mant_PersonaDataService.Insert(mant_Persona) > 0)
                                //{
                                    mant_Relacion_Contribuyente.persona_ID = mant_PersonaDataService.Insert(mant_Persona);
                                    if (mant_Relacion_ContribuyenteDataService.Insert(mant_Relacion_Contribuyente) > 0)
                                    {
                                        MessageBox.Show("Se Grabó Correctamenten con código "+ mant_Relacion_Contribuyente.persona_ID, Globales.Global_MessageBox);
                                        this.Dispose();
                                    }
                                    else
                                    {
                                        mant_PersonaDataService.DeleteByPrimaryKey(mant_Persona.persona_ID);
                                        MessageBox.Show("No se grabó la relación", Globales.Global_MessageBox);
                                    }
                                //}
                                //else
                                //{
                                //    MessageBox.Show("No se grabó a la persona", Globales.Global_MessageBox);
                                //}
                               
                            //}else MessageBox.Show("Ya existe Persona con número de documento", Globales.Global_MessageBox);
                    //}
                    // else MessageBox.Show("Ya existe Código de Persona", Globales.Global_MessageBox);

                    
                }
                else//persona existente
                {
                        if (dgvPersonasBuscadas.SelectedRows.Count > 0)
                        {
                            mant_Relacion_Contribuyente.persona_ID = (string)dgvPersonasBuscadas.SelectedRows[0].Cells["per_ID"].Value;
                            if (mant_Relacion_ContribuyenteDataService.Insert(mant_Relacion_Contribuyente) > 0)
                            {
                                MessageBox.Show("Se Grabó Correctamente",Globales.Global_MessageBox);
                                this.Dispose();
                            }
                    
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Globales.Global_MessageBox);
            }
        }
        private bool VerificarCombos()
        {
            if (cboDistrito.SelectedIndex == -1 || cboDepartamento.SelectedIndex == -1 || cboCalle.SelectedIndex == -1 ||
                cboProvincia.SelectedIndex == -1 || cboSector.SelectedIndex == -1 || cboTipoDoc.SelectedIndex == -1 ||
                cboTipoPersona.SelectedIndex == -1)
                return false;
            else
                return true;
        }
        private string verificarTexto(String dato)
        {
            lblPaterno.ForeColor = System.Drawing.Color.Black;
            lblExpediente.ForeColor = System.Drawing.Color.Black;
            //lblNVia.ForeColor = System.Drawing.Color.Black;
            lblNDoc.ForeColor = System.Drawing.Color.Black;
            if (txtPaterno.Text.Length == 0)
            {
                dato = dato + "Apell.Paterno, ";
                lblPaterno.ForeColor = System.Drawing.Color.Red;
            }
            //if (txtVia.Text.Length == 0)
            //{
            //    dato = dato + "Nº Vía, ";
            //    lblNVia.ForeColor = System.Drawing.Color.Red;
            //}
            if (txtNDoc.Text.Length == 0)
            {
                dato = dato + "NªDocumento, ";
                lblNDoc.ForeColor = System.Drawing.Color.Red;
            }
            if (txtExpediente.Text.Length == 0)
            {
                dato = dato + "Expediente, ";
                lblExpediente.ForeColor = System.Drawing.Color.Red;
            }

            return dato;
        }
        private void maxTextos()
        {
            txtCelular.MaxLength = 30; 
            txtEmail.MaxLength = 50;
            txtExpediente.MaxLength = 50; txtFnoOficina.MaxLength = 50; txtFonoDomicilio.MaxLength = 50;
            txtMaterno.MaxLength = 250; 
            txtNDoc.MaxLength = 25; txtNombre.MaxLength = 250;
            txtPaterno.MaxLength = 250;
            txtLote.MaxLength = 4;
            txtDpto.MaxLength = 4;
            txtTienda.MaxLength = 12;
            txtVia.MaxLength = 4;
            txtEdificio.MaxLength = 4;
            txtMz.MaxLength = 4;
            txtPiso.MaxLength = 4;
            txtInterior.MaxLength = 12;

        }
        public void llenarTipoSector()
        {
            llenarcboMultitabla(cboTipoPersona, "Multc_vDescripcion", "Multc_cValor", "19");
            llenarcboMultitabla(cboTipoDoc, "Multc_vDescripcion", "Multc_cValor", "3");
            cboTipoPersona.SelectedValue = "1";
            cboTipoDoc.SelectedValue = "1";
            cboDepartamento.DisplayMember = "Descripcion";
            cboDepartamento.ValueMember = "Ubicacion_id";
            cboDepartamento.DataSource = conf_UbicacionDataService.GetDepartamentos();
            cboDepartamento.SelectedValue = "13";
            cboProvincia.DisplayMember = "Descripcion";
            cboProvincia.ValueMember = "Ubicacion_id";
            cboProvincia.DataSource = conf_UbicacionDataService.GetProvincia("13%", 9);
            cboProvincia.SelectedValue = "1301";
            cboDistrito.DisplayMember = "Descripcion";
            cboDistrito.ValueMember = "Ubicacion_id";
            cboDistrito.DataSource = conf_UbicacionDataService.GetProvincia("1301%", 10);
            cboDistrito.SelectedValue = "130107";
            cboSector.DisplayMember = "descripcion";
            cboSector.ValueMember = "sector_id";
            cboSector.DataSource = pred_SectorDataService.listarSectorCbo(GlobalesV1.Global_int_idoficina);
            cboCalle.DisplayMember = "Descripcion";
            cboCalle.ValueMember = "Via_id";
            cboCalle.DataSource = pred_ViasDataService.listarViasPorSector(cboSector.SelectedValue.ToString(), GlobalesV1.Global_int_idoficina);
            //cboCalle.DataSource = pred_ViasDataService.listarViasCboCodAntiguo("130107");
        }
        public void llenarcboMultitabla(ComboBox cbo,String dislay,String value,String tipo)
        {
            cbo.DisplayMember = dislay;
            cbo.ValueMember = value;
            cbo.DataSource = conf_MultitablaDataService.GetCboConf_Multitabla(tipo);
        }

        private void txtPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.ValidaLetras(e, Globales.Global_MessageBox);
        }

        private void txtMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.ValidaLetras(e, Globales.Global_MessageBox);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.ValidaLetras(e, Globales.Global_MessageBox);
        }

        private void txtNDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.validaNumeroEntero(e, Globales.Global_MessageBox);
        }
        
        private void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboProvincia.DataSource = conf_UbicacionDataService.GetProvincia(cboDepartamento.SelectedValue + "%", 9);
        }

        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDistrito.DataSource = conf_UbicacionDataService.GetProvincia(cboProvincia.SelectedValue + "%", 10);
        }
        private void cboSector_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cboCalle.ValueMember = "Via_Id";
                cboCalle.DisplayMember = "Descripcion";
                cboCalle.DataSource = pred_ViasDataService.listarViasPorSector(cboSector.SelectedValue.ToString(), GlobalesV1.Global_int_idoficina);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void cboTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (String.Compare(cboTipoDoc.SelectedValue.ToString().Trim(), "1") == 0)
                txtNDoc.MaxLength = 8;
            else if (String.Compare(cboTipoDoc.SelectedValue.ToString().Trim(), "3") == 0)
                txtNDoc.MaxLength = 10;
            else txtNDoc.MaxLength = 15;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtNomRazon_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //dataGridView1.DataSource = pred_sectordataservice.Getcoleccion("Descripcion like '%" + txtbusqueda.Text + "%'", "Descripcion");
                dgvPersonasBuscadas.DataSource = mant_PersonaDataService.listarbuscados(txtNomRazon.Text.TrimEnd());
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    dgvPersonas.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }


        }
    }
}
