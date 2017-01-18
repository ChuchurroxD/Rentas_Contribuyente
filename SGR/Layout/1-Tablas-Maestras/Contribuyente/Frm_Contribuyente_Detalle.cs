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
namespace SGR.WinApp.Layout._1_Tablas_Maestras.Contribuyente
{
    public partial class Frm_Contribuyente_Detalle : Form
    {
        Conf_MultitablaDataService conf_MultitablaDataService = new Conf_MultitablaDataService();
        Conf_UbicacionDataService conf_UbicacionDataService = new Conf_UbicacionDataService();
        Pred_SectorDataService pred_SectorDataService = new Pred_SectorDataService();
        Pred_ViasDataService pred_ViasDataService = new Pred_ViasDataService();
        Mant_PersonaDataService mant_PersonaDataService = new Mant_PersonaDataService();
        Mant_ContribuyenteDataService mant_ContribuyenteDataService = new Mant_ContribuyenteDataService();
        Mant_JuntaViaDataService mant_JuntaViaDataService = new Mant_JuntaViaDataService();
        private Sistema.Globales.Validaciones obValidacion = new Sistema.Globales.Validaciones();
        private string usser = "nada";
        public Frm_Contribuyente_Detalle()
        {
            InitializeComponent();
            llenarTipoSector();
            maxTextos();
            txtId.Text = mant_PersonaDataService.GetIdPersonaMax().ToString();
            txtId.Enabled = true;
        }
        public Frm_Contribuyente_Detalle(Mant_Per_Cont mant_Per_Conta)
        {
            InitializeComponent();
            limpiar();
            llenarTipoSector(mant_Per_Conta);
            maxTextos();
            txtId.Enabled = false;
            CargarElementosTextosE(mant_Per_Conta);            
            chkJubilado.Checked = mant_Per_Conta.jubilado;

        }
        public void llenarTipoSector(Mant_Per_Cont mant_Per_Conta)
        {
            try
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
                this.cboSector.AutoCompleteMode = AutoCompleteMode.Suggest;
                this.cboSector.AutoCompleteSource = AutoCompleteSource.CustomSource;
                cboSector.SelectedValue =Convert.ToInt32( mant_Per_Conta.junta_ID);
                cboSector2.DisplayMember = "descripcion";
                cboSector2.ValueMember = "sector_id";
                cboSector2.DataSource = pred_SectorDataService.listarSectorCbo(GlobalesV1.Global_int_idoficina);
                this.cboSector2.AutoCompleteMode = AutoCompleteMode.Suggest;
                this.cboSector2.AutoCompleteSource = AutoCompleteSource.CustomSource;

                cboSector2.SelectedValue = Convert.ToInt32(mant_Per_Conta.c_junta);
                cboCalle.DisplayMember = "Descripcion";
                cboCalle.ValueMember = "Via_id";
                //cboCalle.DataSource = pred_ViasDataService.listarViasCboCodAntiguo("130107");
                cboCalle2.DisplayMember = "Descripcion";
                cboCalle2.ValueMember = "Via_id";
                //cboCalle2.DataSource = pred_ViasDataService.listarViasCboCodAntiguo("130107");
                cboCalle2.DataSource = pred_ViasDataService.listarViasPorSector(cboSector2.SelectedValue.ToString(), GlobalesV1.Global_int_idoficina);
                cboCalle.DataSource = pred_ViasDataService.listarViasPorSector(cboSector.SelectedValue.ToString(), GlobalesV1.Global_int_idoficina);
                this.cboCalle2.AutoCompleteMode = AutoCompleteMode.Suggest;
                this.cboCalle2.AutoCompleteSource = AutoCompleteSource.CustomSource;
                this.cboCalle.AutoCompleteMode = AutoCompleteMode.Suggest;
                this.cboCalle.AutoCompleteSource = AutoCompleteSource.CustomSource;
                cboCalle.SelectedValue = mant_Per_Conta.via_ID.Trim();
                cboCalle2.SelectedValue = mant_Per_Conta.c_via.Trim();
            } catch (Exception EX) {
            }
           

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
            this.cboSector.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.cboSector.AutoCompleteSource = AutoCompleteSource.CustomSource;
            ////cboSector.SelectedValue = mant_Per_Conta.junta_ID;
            cboSector2.DisplayMember = "descripcion";
            cboSector2.ValueMember = "sector_id";
            cboSector2.DataSource = pred_SectorDataService.listarSectorCbo(GlobalesV1.Global_int_idoficina);
            this.cboSector2.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.cboSector2.AutoCompleteSource = AutoCompleteSource.CustomSource;

            //cboSector2.SelectedValue = mant_Per_Conta.c_junta;
            cboCalle.DisplayMember = "Descripcion";
            cboCalle.ValueMember = "Via_id";
            //cboCalle.DataSource = pred_ViasDataService.listarViasCboCodAntiguo("130107");
            cboCalle2.DisplayMember = "Descripcion";
            cboCalle2.ValueMember = "Via_id";
            //cboCalle2.DataSource = pred_ViasDataService.listarViasCboCodAntiguo("130107");
            cboCalle2.DataSource = pred_ViasDataService.listarViasPorSector(cboSector2.SelectedValue.ToString(), GlobalesV1.Global_int_idoficina);
            cboCalle.DataSource = pred_ViasDataService.listarViasPorSector(cboSector.SelectedValue.ToString(), GlobalesV1.Global_int_idoficina);
            this.cboCalle2.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.cboCalle2.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.cboCalle.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.cboCalle.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //cboCalle.SelectedValue = mant_Per_Conta.via_ID;
            //cboCalle2.SelectedValue = mant_Per_Conta.c_via;

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
        private void limpiar()
        {
            txtCelular.Text = ""; txtDpto.Text = ""; txtDpto2.Text = ""; txtEdificio.Text = ""; txtEdificio2.Text = "";
            txtEmail.Text = ""; txtExpediente.Text = ""; txtFnoOficina.Text = ""; txtFonoDomicilio.Text = "";
            txtInterior.Text = ""; txtInterior2.Text = ""; txtLote.Text = ""; txtLote2.Text = ""; txtMaterno.Text = ""; txtMz.Text = "";
            txtMz2.Text = ""; txtNDoc.Text = ""; txtNombre.Text = ""; txtNVia.Text = ""; txtPaterno.Text = ""; txtPiso.Text = "";
            txtPiso2.Text = ""; txtTienda.Text = ""; txtTienda2.Text = ""; txtVia.Text = ""; ckbCopiar.Checked = false;
            txtIdOculto.Text = ""; txtReferencia.Text = ""; dtpFNacimiento.Text = "01/01/1990 14:52";
            rbtFemenino.Checked = true; ckbCopiar.Checked = false; txtDniRep.Text = ""; txtContacto.Text = ""; txtDirecRep.Text = "";
            chkJubilado.Checked = false;
        }
        private void maxTextos()
        {
            txtCelular.MaxLength = 30;
            txtEmail.MaxLength = 50;
            txtExpediente.MaxLength = 50; txtFnoOficina.MaxLength = 50; txtFonoDomicilio.MaxLength = 50;
            txtMaterno.MaxLength = 250;
            txtNDoc.MaxLength = 25; txtNombre.MaxLength = 250; txtPaterno.MaxLength = 250;
            txtDniRep.MaxLength = 8; txtContacto.MaxLength = 150; txtDirecRep.MaxLength = 150;
            txtLote.MaxLength = 4;
            txtDpto.MaxLength = 4;
            txtTienda.MaxLength = 12;
            txtVia.MaxLength = 4;
            txtEdificio.MaxLength = 4;
            txtMz.MaxLength = 4;
            txtPiso.MaxLength = 4;
            txtInterior.MaxLength = 4;
            txtLote2.MaxLength = 4;
            txtDpto2.MaxLength = 4;
            txtTienda2.MaxLength = 12;
            txtNVia.MaxLength = 4;
            txtEdificio2.MaxLength = 4;
            txtMz2.MaxLength = 4;
            txtPiso2.MaxLength = 4;
            txtInterior2.MaxLength = 12;
        }
        private string verificarTexto(String dato)
        {
            this.lblPaterno.ForeColor = System.Drawing.Color.Black;
            this.lblMaterno.ForeColor = System.Drawing.Color.Black;
            this.lblNDocumento.ForeColor = System.Drawing.Color.Black;
            this.lblNombres.ForeColor = System.Drawing.Color.Black;
            this.lblNVia.ForeColor = System.Drawing.Color.Black;
            //this.lblVia.ForeColor = System.Drawing.Color.Black;
            this.lblExpediente.ForeColor = System.Drawing.Color.Black;
            if (cboTipoPersona.SelectedValue.ToString() == "1")
            {
                if (txtMaterno.Text.Trim().Length == 0)
                {
                    dato = dato + "Materno,";
                    lblMaterno.ForeColor = System.Drawing.Color.Red;
                }
                if (txtNombre.Text.Trim().Length == 0)
                {
                    dato = dato + "Nombre,";
                    lblNombres.ForeColor = System.Drawing.Color.Red;
                }
            }
            if (txtPaterno.Text.Trim().Length == 0)
            {
                dato = dato + "Paterno,";
                lblPaterno.ForeColor = System.Drawing.Color.Red;
            }
            
            if (txtNDoc.Text.Trim().Length == 0)
            {
                dato = dato + "Nº Doc,";
                lblNDocumento.ForeColor = System.Drawing.Color.Red;
            }
            if (txtExpediente.Text.Trim().Length == 0)
            {
                dato = dato + "Expediente,";
                lblExpediente.ForeColor = System.Drawing.Color.Red;
            }
            //if (txtNVia.Text.Trim().Length == 0)
            //{
            //    dato = dato + "Nº Vía del código postal,";
            //    lblNVia.ForeColor = System.Drawing.Color.Red;
            //}
            //if (txtVia.Text.Trim().Length == 0)
            //{
            //    dato = dato + "Nº vía";
            //    lblVia.ForeColor = System.Drawing.Color.Red;
            //}
            return dato;

        }
        private void CargarElementosTextosE(Mant_Per_Cont mant_Per_Conta)
        {
            txtCelular.Text = mant_Per_Conta.celular;
            txtContacto.Text = mant_Per_Conta.Contacto;
            txtDirecRep.Text = mant_Per_Conta.DireccRepresentante;
            txtDniRep.Text = mant_Per_Conta.dniRepresentante;
            txtDpto.Text = mant_Per_Conta.Dpto;
            txtDpto2.Text = mant_Per_Conta.c_dpto;
            txtEdificio.Text = mant_Per_Conta.edificio;
            txtEdificio2.Text = mant_Per_Conta.C_edificio;
            txtEmail.Text = mant_Per_Conta.email;
            txtExpediente.Text = mant_Per_Conta.expediente;
            txtFnoOficina.Text = mant_Per_Conta.fono_oficina;
            txtFonoDomicilio.Text = mant_Per_Conta.Fono_Domicilio;
            txtInterior.Text = mant_Per_Conta.interior;
            txtInterior2.Text = mant_Per_Conta.c_interior;
            txtLote.Text = mant_Per_Conta.Lote;
            txtLote2.Text = mant_Per_Conta.c_lote;
            txtMaterno.Text = mant_Per_Conta.materno;
            txtMz.Text = mant_Per_Conta.mz;
            txtMz2.Text = mant_Per_Conta.c_mz;
            txtNDoc.Text = mant_Per_Conta.documento;
            txtNombre.Text = mant_Per_Conta.nombres;
            txtPaterno.Text = mant_Per_Conta.paterno;
            txtPiso.Text = mant_Per_Conta.piso;
            txtPiso2.Text = mant_Per_Conta.c_piso;
            txtReferencia.Text = mant_Per_Conta.referencia;
            txtTienda.Text = mant_Per_Conta.tienda;
            txtTienda2.Text = mant_Per_Conta.c_tienda;
            txtVia.Text = mant_Per_Conta.num_via;
            txtNVia.Text = mant_Per_Conta.c_num;
            txtIdOculto.Text = mant_Per_Conta.persona_ID;
            txtId.Text = mant_Per_Conta.persona_ID;
            ckbEmpresaConstru.Checked = mant_Per_Conta.empresaCOnstrucora;
            try
            {
                cboTipoPersona.SelectedValue = mant_Per_Conta.tipo_persona.ToString();
            }
            catch (Exception ex)
            {
            }
            try
            {
                cboTipoDoc.SelectedValue = mant_Per_Conta.tipo_documento.ToString();
            }
            catch (Exception ex)
            {
            }
            
            if (String.Compare(mant_Per_Conta.Sexo.Trim(), "F") == 0)
            {
                rbtFemenino.Checked = true;
            }
            else rbtMasculino.Checked = true;
            txtReferencia.Text = mant_Per_Conta.referencia;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                Mant_Persona mant_Persona = new Mant_Persona();
            Mant_Contribuyente mant_Contribuyente = new Mant_Contribuyente();
                if(cboSector.SelectedIndex == -1 || cboSector2.SelectedIndex == -1 || cboCalle.SelectedIndex == -1 || cboCalle2.SelectedIndex == -1)
                {
                    MessageBox.Show("Falta llenar el sector o la calle", Globales.Global_MessageBox);
                    return;
                }
            int junta_via, junta_via2; string elementoFaltante = "";
            junta_via = mant_JuntaViaDataService.GetJuntaVia_id(int.Parse(cboSector.SelectedValue.ToString()), int.Parse(cboCalle.SelectedValue.ToString()));
            junta_via2 = mant_JuntaViaDataService.GetJuntaVia_id(int.Parse(cboSector2.SelectedValue.ToString()), int.Parse(cboCalle2.SelectedValue.ToString()));
            if (VerificarCombos())
            {
                if (junta_via != 0 || junta_via2 != 0)
                {
                    elementoFaltante = verificarTexto("");
                    if (elementoFaltante.CompareTo("") == 0)
                    {
                        //llenar objetos
                        mant_Persona.Declaracion = "";
                        mant_Persona.documento = txtNDoc.Text.Trim();
                        mant_Persona.Dpto = txtDpto.Text.TrimEnd();
                        mant_Persona.email = txtEmail.Text.Trim();
                        mant_Persona.ESTADO = true;
                        mant_Persona.expediente = txtExpediente.Text.Trim();
                        mant_Persona.Fono_Domicilio = txtFonoDomicilio.Text.Trim();
                        mant_Persona.fono_oficina = txtFnoOficina.Text.Trim();
                        mant_Persona.interior = txtInterior.Text.TrimEnd();
                        mant_Persona.junta_via_ID = junta_via;//mant_JuntaViaDataService.GetJuntaVia_id(int.Parse(cboSector.SelectedValue.ToString()), int.Parse(cboCalle.SelectedValue.ToString()));
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
                        mant_Persona.registro_user = GlobalesV1.Global_str_Usuario;//usser;
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
                        //contribuyente
                        mant_Contribuyente.c_dpto = txtDpto2.Text.TrimEnd();
                        mant_Contribuyente.c_interior = txtInterior2.Text.TrimEnd();
                        mant_Contribuyente.c_lote = txtLote2.Text.TrimEnd();
                        mant_Contribuyente.c_mz = txtMz2.Text.TrimEnd();
                        mant_Contribuyente.c_num = txtNVia.Text.TrimEnd();
                        mant_Contribuyente.c_piso = txtPiso2.Text.TrimEnd();
                        mant_Contribuyente.c_edificio = txtEdificio2.Text.TrimEnd();
                        mant_Contribuyente.c_tienda = txtTienda2.Text.TrimEnd();
                        mant_Contribuyente.junta_via_ID = junta_via2;
                        mant_Contribuyente.ruc = mant_Persona.documento;
                        mant_Contribuyente.dniRepresentante = "00000000";
                        mant_Contribuyente.DireccRepresentante = txtDirecRep.Text.TrimEnd();
                        mant_Contribuyente.dniRepresentante = txtDniRep.Text.Trim();
                        mant_Contribuyente.Contacto = txtContacto.Text.TrimStart();
                        mant_Contribuyente.estado = true;
                        mant_Contribuyente.razon_social = mant_Persona.NombreCompleto;
                        mant_Contribuyente.Ubi_codigo = mant_Persona.Ubi_codigo;
                        mant_Contribuyente.registro_user =
                        mant_Persona.registro_user = GlobalesV1.Global_str_Usuario; //usser;
                        mant_Contribuyente.referencia = txtReferencia.Text.TrimEnd();
                        mant_Contribuyente.empresaCOnstrucora = ckbEmpresaConstru.Checked;
                            mant_Contribuyente.jubilado = chkJubilado.Checked;
                        if (String.Compare(txtIdOculto.Text.Trim(), "") == 0)//NUEVO
                        {
                            //if (!mant_PersonaDataService.GetExisteCodigo(txtId.Text.Trim()))
                            //{

                                //si no existe persona
                                if (!mant_PersonaDataService.GetExistePersona(txtNDoc.Text.Trim(), Int16.Parse(cboTipoDoc.SelectedValue.ToString())))
                                {
                                    mant_Persona.persona_ID = mant_PersonaDataService.GetIdPersonaMax().ToString();
                                        // mant_Contribuyente.persona_id = mant_Persona.persona_ID;
                                        mant_Contribuyente.persona_id= mant_PersonaDataService.Insert(mant_Persona);
                                    mant_ContribuyenteDataService.Insert(mant_Contribuyente);
                                    MessageBox.Show("Se grabó correctamente con còdigo "+ mant_Contribuyente.persona_id, Globales.Global_MessageBox);
                                    this.Dispose();
                                }
                                else
                                {//si existe persona
                                    mant_Persona.persona_ID = mant_PersonaDataService.GetPersonaExistente(txtNDoc.Text.Trim(), Int16.Parse(cboTipoDoc.SelectedValue.ToString()));
                                    mant_Contribuyente.persona_id = mant_Persona.persona_ID;

                                    if (mant_ContribuyenteDataService.GetExisteContribuyente(mant_Persona.persona_ID) == 0)//no existe contribuyente
                                    {//si no existe contribuyente
                                        if (MessageBox.Show("Ya existe la persona, pero no contribuyente; desea modificar los datos de persona y crear un contribuyente?", Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                        {
                                            mant_PersonaDataService.Update(mant_Persona);
                                            mant_ContribuyenteDataService.Insert(mant_Contribuyente);
                                            MessageBox.Show("Se grabó correctamente con còdigo " + mant_Persona.persona_ID, Globales.Global_MessageBox);
                                            this.Dispose();
                                        }

                                    }
                                    else
                                        {
                                        if (MessageBox.Show("Ya existe contribuyente con ese documento.Desea Grabar?", Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                        {
                                            mant_Persona.persona_ID = mant_PersonaDataService.GetIdPersonaMax().ToString();
                                            mant_Contribuyente.persona_id = mant_PersonaDataService.Insert(mant_Persona);
                                            mant_ContribuyenteDataService.Insert(mant_Contribuyente);
                                            MessageBox.Show("Se grabó correctamente con còdigo " + mant_Contribuyente.persona_id, Globales.Global_MessageBox);
                                            this.Dispose();
                                        }
                                    }

                                    }
                                limpiar();
                            //}
                            //else MessageBox.Show("Ya existe Código de Persona", Globales.Global_MessageBox);
                        }//FIN DE GRABADO NUEVO
                        else
                        {//INICIO DE GRABADO MODIFICADO
                            mant_Persona.persona_ID = txtIdOculto.Text.Trim();
                            mant_Contribuyente.persona_id = txtIdOculto.Text.Trim();
                            mant_PersonaDataService.Update(mant_Persona);
                            mant_ContribuyenteDataService.Update(mant_Contribuyente);
                            MessageBox.Show("Se grabó correctamente", Globales.Global_MessageBox);
                            this.Dispose();
                        }



                    }
                    else
                        MessageBox.Show("Falta llenar  " + elementoFaltante, Globales.Global_MessageBox);
                }
                else
                    MessageBox.Show("No existe la calle en ese sector", Globales.Global_MessageBox);
            }
            else
                MessageBox.Show("Falta llenar un combobox", Globales.Global_MessageBox);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboProvincia.DataSource = conf_UbicacionDataService.GetProvincia(cboDepartamento.SelectedValue.ToString() + "%", 9);
        }
        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDistrito.DataSource = conf_UbicacionDataService.GetProvincia(cboProvincia.SelectedValue.ToString() + "%", 10);
        }
        private void cboDistrito_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cboSector_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCalle.DataSource = pred_ViasDataService.listarViasPorSector(cboSector.SelectedValue.ToString(), GlobalesV1.Global_int_idoficina);
            this.cboCalle.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.cboCalle.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void cboSector2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCalle2.DataSource = pred_ViasDataService.listarViasPorSector(cboSector2.SelectedValue.ToString(), GlobalesV1.Global_int_idoficina);
            this.cboCalle2.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.cboCalle2.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void cboTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (String.Compare(cboTipoDoc.SelectedValue.ToString().Trim(), "1") == 0)
                txtNDoc.MaxLength = 8;
            else if (String.Compare(cboTipoDoc.SelectedValue.ToString().Trim(), "3") == 0)
                txtNDoc.MaxLength = 11;
            else txtNDoc.MaxLength = 15;
        }

        private void ckbCopiar_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbCopiar.Checked)
            {
                copiarDireccion();
            }
        }
        private void copiarDireccion()
        {
            cboSector2.SelectedValue = cboSector.SelectedValue;
            cboCalle2.SelectedValue = cboCalle.SelectedValue;
            txtNVia.Text = txtVia.Text.TrimEnd();
            txtInterior2.Text = txtInterior.Text.TrimEnd();
            txtLote2.Text = txtLote.Text.TrimEnd();
            txtEdificio2.Text = txtEdificio.Text.TrimEnd();
            txtInterior2.Text = txtInterior.Text.TrimEnd();
            txtDpto2.Text = txtDpto.Text.TrimEnd();
            txtPiso2.Text = txtPiso.Text.TrimEnd();
            txtTienda2.Text = txtTienda.Text.TrimEnd();
            txtMz2.Text = txtMz.Text.TrimEnd();
        }

        private void txtPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            //obValidacion.ValidaLetras(e, Globales.Global_MessageBox);
        }
        private void txtMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            //obValidacion.ValidaLetras(e, Globales.Global_MessageBox);
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //obValidacion.ValidaLetras(e, Globales.Global_MessageBox);
        }
        private void txtNDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.validaNumeroEntero(e, Globales.Global_MessageBox);
        }
        private void txtVia_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.validaNumeroEntero(e, Globales.Global_MessageBox);
        }
        private void txtNVia_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.validaNumeroEntero(e, Globales.Global_MessageBox);
        }

        private void cboTipoPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoPersona.SelectedValue.ToString().Trim() == "2")
            {
                txtMaterno.Enabled = false;
                txtNombre.Enabled = false;
            }
            else if (cboTipoPersona.SelectedValue.ToString().Trim() == "1")
            {
                txtMaterno.Enabled = true;
                txtNombre.Enabled = true;
                ckbEmpresaConstru.Enabled = true;
            }
            else
            {
                txtMaterno.Enabled = false;
                txtNombre.Enabled = false;
            }
        }
    }
}
