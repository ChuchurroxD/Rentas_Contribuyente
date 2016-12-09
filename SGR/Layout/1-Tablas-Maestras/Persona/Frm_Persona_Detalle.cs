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

namespace SGR.WinApp.Layout._1_Tablas_Maestras.Persona
{
    public partial class Frm_Persona_Detalle : Form
    {
        private Conf_MultitablaDataService conf_MultitablaDataService = new Conf_MultitablaDataService();
        private Conf_UbicacionDataService conf_UbicacionDataService = new Conf_UbicacionDataService();
        private Pred_SectorDataService pred_SectorDataService = new Pred_SectorDataService();
        private Pred_ViasDataService pred_ViasDataService = new Pred_ViasDataService();
        private Mant_Persona mant_personaa = new Mant_Persona();
        private Mant_JuntaViaDataService mant_JuntaViaDataService = new Mant_JuntaViaDataService();
        private Mant_PersonaDataService mant_PersonaDataService = new Mant_PersonaDataService();
        private Sistema.Globales.Validaciones obValidacion = new Sistema.Globales.Validaciones();
        public Frm_Persona_Detalle()
        {
            InitializeComponent();
            maxTextos();
            llenarTipoSector();
            txtId.Enabled = true;
            txtId.Text= mant_PersonaDataService.GetIdPersonaMax().ToString();
            ckbEstado.Visible = false;
            Maximos();
        }
        public Frm_Persona_Detalle(Mant_Persona mant_Persona)
        {
            InitializeComponent();
            maxTextos();
            if (mant_Persona != null)
            {
                ckbEstado.Visible = true;
                this.mant_personaa = mant_Persona;
                llenarTipoSelectorE(mant_personaa);
                llenarDatos(mant_personaa);
                txtId.Enabled = false;
                Maximos();
            }

        }
        public void  Maximos()
        {
            txtLote.MaxLength = 4;
            txtDpto.MaxLength = 4;
            txtTienda.MaxLength = 12;
            txtVia.MaxLength = 4;
            txtEdificio.MaxLength = 4;
            txtMz.MaxLength = 4;
            txtPiso.MaxLength = 4;
            txtInterior.MaxLength = 12;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Pred_SectorDataService Pred_SectorDataService = new Pred_SectorDataService();
            Mant_Persona mant_Persona = new Mant_Persona();
            try
            {
                //MessageBox.Show("fff", Globales.Global_MessageBox);
                if (VerificarCombos())
                {
                    int junta_via; string elementoFaltante = "";
                    junta_via = mant_JuntaViaDataService.GetJuntaVia_id(int.Parse(cboSector.SelectedValue.ToString()), int.Parse(cboCalle.SelectedValue.ToString()));
                    if (junta_via != 0)
                    {
                    elementoFaltante = verificarTexto();
                        if (elementoFaltante.CompareTo("OK") == 0)
                        {
                            
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
                                mant_Persona.registro_user = GlobalesV1.Global_str_Usuario;//"UsuarioPrueba";
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
                                if (txtIdOculto.Text.Length == 0)//nuevo
                                {
                                    //if (!mant_PersonaDataService.GetExisteCodigo(txtId.Text.Trim())) { 
                                        //if (!mant_PersonaDataService.GetExistePersona(txtNDoc.Text.Trim(), Int16.Parse(cboTipoDoc.SelectedValue.ToString())))
                                        //{
                                            mant_Persona.persona_ID = txtId.Text;//mant_PersonaDataService.GetIdPersonaMax().ToString();
                                            mant_PersonaDataService.Insert(mant_Persona);
                                            MessageBox.Show("Se Grabó Correctamente", Globales.Global_MessageBox);
                                            this.Close();
                                        //}
                                        //else MessageBox.Show("Ya existe Persona con número de documento", Globales.Global_MessageBox);
                                    //}
                                    //else MessageBox.Show("Ya existe Código de Persona", Globales.Global_MessageBox);
                                }
                                else//modificar
                                {
                                    mant_Persona.ESTADO = ckbEstado.Checked;
                                    mant_Persona.persona_ID = txtIdOculto.Text.Trim();
                                    mant_PersonaDataService.Update(mant_Persona);
                                    MessageBox.Show("Se grabó correctamente", Globales.Global_MessageBox);
                                    this.Dispose();
                                }
                        
                        }
                        else MessageBox.Show("Falta llenar el " + elementoFaltante, Globales.Global_MessageBox);
                    }
                    else MessageBox.Show("No existe Vía en ese sector", Globales.Global_MessageBox);
                }
                else MessageBox.Show("Falta llenar algún combo", Globales.Global_MessageBox);
            }
            catch (Exception ex) {
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
        private string verificarTexto()
        {
            
            if (txtPaterno.Text.Length > 0)
            {
                 if (txtNDoc.Text.Length > 0)
                        {
                            if (txtExpediente.Text.Length > 0)
                            {
                                return "OK";
                            }
                            else
                                return "Expediente";
                        }
                        else
                            return "Número de Doc";
            }
            else
                return "Apellido Paterno";

        }
        private void maxTextos()
        {
            txtCelular.MaxLength = 30; txtDpto.MaxLength = 50;
            txtEdificio.MaxLength = 100; txtEmail.MaxLength = 50;
            txtExpediente.MaxLength = 50; txtFnoOficina.MaxLength = 50; txtFonoDomicilio.MaxLength = 50;
            txtInterior.MaxLength = 50; txtLote.MaxLength = 10;
            txtMaterno.MaxLength = 250; txtMz.MaxLength = 15;
            txtNDoc.MaxLength = 25; txtNombre.MaxLength = 250;
            txtPaterno.MaxLength = 250; txtPiso.MaxLength = 100;
            txtTienda.MaxLength = 100;
            txtVia.MaxLength = 3; 

        }
        public void llenarTipoSector()
        {
            cboTipoPersona.DisplayMember = "Multc_vDescripcion";
            cboTipoPersona.ValueMember = "Multc_cValor";
            cboTipoPersona.DataSource = conf_MultitablaDataService.GetCboConf_Multitabla("19");
            cboTipoPersona.SelectedValue = "1";
            cboTipoDoc.DisplayMember = "Multc_vDescripcion";
            cboTipoDoc.ValueMember = "Multc_cValor";
            cboTipoDoc.DataSource = conf_MultitablaDataService.GetCboConf_Multitabla("3");
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
        private void llenarDatos(Mant_Persona maant_Persona)
        {
            txtIdOculto.Text= maant_Persona.persona_ID;
            txtId.Text = maant_Persona.persona_ID;
            txtCelular.Text = maant_Persona.celular;
            txtTienda.Text= maant_Persona.tienda;
            txtPiso.Text= maant_Persona.piso;
            txtEdificio.Text= maant_Persona.edificio;
            dtpFNacimiento.Value= maant_Persona.fechaNacimiento;
            if (String.Compare(maant_Persona.sexo.Trim(), "F") == 0)
            {
                rbtFemenino.Checked = true;
            }
            else rbtMasculino.Checked = true;
            txtExpediente.Text= maant_Persona.expediente;
            txtOtraDireccion.Text= maant_Persona.OtraDireccion;
            
            ckbEstado.Checked= maant_Persona.ESTADO;
            txtEmail.Text= maant_Persona.email;
            txtFnoOficina.Text= maant_Persona.fono_oficina;
            txtFonoDomicilio.Text= maant_Persona.Fono_Domicilio;
            txtLote.Text= maant_Persona.Lote;
            txtMz.Text= maant_Persona.mz;
            txtDpto.Text= maant_Persona.Dpto;
            txtInterior.Text= maant_Persona.interior;
            txtVia.Text= maant_Persona.num_via;
            txtNombre.Text= maant_Persona.nombres;
            txtMaterno.Text= maant_Persona.materno;
            txtPaterno.Text= maant_Persona.paterno;
            txtNDoc.Text= maant_Persona.documento;
            


        }
        private void llenarTipoSelectorE(Mant_Persona maant_Persona)
        {
            cboTipoPersona.DisplayMember = "Multc_vDescripcion";
            cboTipoPersona.ValueMember = "Multc_cValor";
            cboTipoPersona.DataSource = conf_MultitablaDataService.GetCboConf_Multitabla("19");
            cboTipoPersona.SelectedValue = Convert.ToString(maant_Persona.tipo_persona).Trim();
            cboTipoDoc.DisplayMember = "Multc_vDescripcion";
            cboTipoDoc.ValueMember = "Multc_cValor";
            cboTipoDoc.DataSource = conf_MultitablaDataService.GetCboConf_Multitabla("3");
            cboTipoDoc.SelectedValue = Convert.ToString(maant_Persona.tipo_documento).Trim();
            //cboDepartamento.DisplayMember = "Descripcion";
            //cboDepartamento.ValueMember = "Ubicacion_id";
            //cboDepartamento.DataSource = conf_UbicacionDataService.GetDepartamentos();
            //cboDepartamento.SelectedValue = maant_Persona.dep;
            //cboProvincia.DisplayMember = "Descripcion";
            //cboProvincia.ValueMember = "Ubicacion_id";
            //cboProvincia.DataSource = conf_UbicacionDataService.GetProvincia(maant_Persona.dep + "%", 9);
            //cboProvincia.SelectedValue = maant_Persona.prov;
            //cboDistrito.DisplayMember = "Descripcion";
            //cboDistrito.ValueMember = "Ubicacion_id";
            //cboDistrito.DataSource = conf_UbicacionDataService.GetProvincia(maant_Persona.prov + "%", 10);
            //cboDistrito.SelectedValue = maant_Persona.Ubi_codigo;
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
            cboSector.SelectedValue = Convert.ToInt32(maant_Persona.junta_ID.Trim());
            cboCalle.DisplayMember = "Descripcion";
            cboCalle.ValueMember = "Via_id";
            //cboCalle.DataSource = pred_ViasDataService.listarViasCboCodAntiguo(maant_Persona.Ubi_codigo);//pred_ViasDataService.listarViasCbo();
            //cboCalle.SelectedValue = (maant_Persona.via_ID.Trim());
            cboCalle.DataSource = pred_ViasDataService.listarViasPorSector(cboSector.SelectedValue.ToString(), GlobalesV1.Global_int_idoficina);
            cboCalle.SelectedValue = (maant_Persona.via_ID.Trim());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboProvincia.DataSource = conf_UbicacionDataService.GetProvincia(cboDepartamento.SelectedValue + "%", 9);
        }

        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDistrito.DataSource = conf_UbicacionDataService.GetProvincia(cboProvincia.SelectedValue + "%", 10);
        }

        private void cboDistrito_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cboCalle.DataSource= pred_ViasDataService.listarViasCboCodAntiguo(cboDistrito.SelectedValue.ToString());
        }

        private void txtNDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.validaNumeroEntero(e, Globales.Global_MessageBox);

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

        private void txtExpediente_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.validaNumeroEntero(e, Globales.Global_MessageBox);
        }

        private void Frm_Persona_Detalle_Load(object sender, EventArgs e)
        {

        }

        private void cboTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (String.Compare(cboTipoDoc.SelectedValue.ToString().Trim(), "1") == 0)
                txtNDoc.MaxLength = 8;
            else if (String.Compare(cboTipoDoc.SelectedValue.ToString().Trim(), "3") == 0)
                txtNDoc.MaxLength = 10;
            else txtNDoc.MaxLength = 15;
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
    }
}
