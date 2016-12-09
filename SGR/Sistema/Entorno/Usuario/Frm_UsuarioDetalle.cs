using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGR.Entity.Model;
using SGR.Core.Service;
using SGR.Entity;
using System.Globalization;

namespace SGR.WinApp.Sistema.Entorno.Usuario
{
    public partial class Frm_UsuarioDetalle : Form
    {

        private Segu_Usuario segu_Usuario;
        Segu_UsuarioDataService segu_UsuarioDataService = new Segu_UsuarioDataService();

        public Frm_UsuarioDetalle()
        {
            InitializeComponent();
        }

        public Frm_UsuarioDetalle(Segu_Usuario segu_Usuario)
        {
            InitializeComponent();
            this.segu_Usuario = segu_Usuario;
        }

        private void Frm_UsuarioDetalle_Load(object sender, EventArgs e)
        {
            
            Orga_AreaDataService org_AreaDataService = new Orga_AreaDataService();
            Conf_RolDataService conf_RolDataService = new Conf_RolDataService();
            List<Conf_Rol> coleccion = new List<Conf_Rol>();
            coleccion = conf_RolDataService.listarRolesActivo();

            foreach (Conf_Rol conf_Rol in coleccion)
            {
                chkListRoles.Items.Add(conf_Rol.Rolec_vNombre);
            }

            cboArea.ValueMember = "Areac_vCodigo";
            cboArea.DisplayMember = "Areac_vDescripcion";
            cboArea.DataSource = org_AreaDataService.listarAreasActivas();

            if (segu_Usuario != null)
            {
                txtNombre.Text = segu_Usuario.Seguc_vNombre;
                txtApellido.Text = segu_Usuario.Seguc_vApellidos;
                txtLogin.Text = segu_Usuario.Seguc_vLogin;
                txtPassword.Text = segu_Usuario.Seguc_password;
                txtPassword.Enabled = false;
                chkEstado.Checked = segu_Usuario.Seguc_bEstado;
                cboArea.SelectedValue = segu_Usuario.areas_codarea;
                coleccion = segu_UsuarioDataService.listarRolesXUsuario(segu_Usuario.per_codigo);
                foreach (Conf_Rol conf_Rol in coleccion)
                {
                    int index = chkListRoles.FindString(conf_Rol.Rolec_vNombre, -1);
                    chkListRoles.SetItemChecked(index, true);               
                }
            }
            else
            {
                chkEstado.Checked = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {            
            try
            {
                               
                if (txtNombre.Text.Trim().Length <= 0)
                    throw new Exception("Debe ingresar un nombre.");
                if (txtApellido.Text.Trim().Length <= 0)
                    throw new Exception("Debe ingresar una apellido.");
                if (txtLogin.Text.Trim().Length <= 0)
                    throw new Exception("Debe ingresar una login.");
                if (txtPassword.Text.Trim().Length <= 0)
                    throw new Exception("Debe ingresar una password.");
                if (chkListRoles.CheckedItems.Count <= 0)
                    throw new Exception("Debe seleccionar un rol.");
                
                if (MessageBox.Show("Desea Grabar?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                { 
                    if (segu_Usuario == null)
                    {
                        if (segu_UsuarioDataService.GetExisteLoginNuevo(txtLogin.Text.Trim()) > 0)
                            throw new Exception("Login ya existe. No se pudo grabar.");

                        Segu_Usuario segu_Usuario1 = new Segu_Usuario();
                        segu_Usuario1.Seguc_vNombre = txtNombre.Text.Trim();
                        segu_Usuario1.Seguc_vApellidos = txtApellido.Text.Trim();
                        segu_Usuario1.areas_codarea = cboArea.SelectedValue.ToString();
                        segu_Usuario1.Seguc_vLogin = txtLogin.Text.Trim();
                        segu_Usuario1.Seguc_password = txtPassword.Text.Trim();
                        segu_Usuario1.Seguc_vLast = "";
                        segu_Usuario1.Seguc_vSession = "";
                        segu_Usuario1.Seguc_bEstado = chkEstado.Checked;
                        segu_UsuarioDataService.insertUsuario(segu_Usuario1);

                        foreach(string  rol in chkListRoles.CheckedItems)
                        {
                            segu_UsuarioDataService.insertRolUsuario(segu_Usuario1, rol);
                        }                  
                        
                        MessageBox.Show("Se Grabó Correctamente");
                        this.Close();
                    }
                    else
                    {
                        if (segu_UsuarioDataService.GetExisteLoginModificar(segu_Usuario.per_codigo, txtLogin.Text.Trim()) > 0)
                            throw new Exception("Login ya existe. No se pudo grabar.");
                        segu_Usuario.Seguc_vNombre = txtNombre.Text.Trim();
                        segu_Usuario.Seguc_vApellidos = txtApellido.Text.Trim();
                        segu_Usuario.areas_codarea = cboArea.SelectedValue.ToString();
                        segu_Usuario.Seguc_vLogin = txtLogin.Text.Trim();
                        segu_Usuario.Seguc_password = txtPassword.Text.Trim();
                        segu_Usuario.Seguc_vLast = "";
                        segu_Usuario.Seguc_vSession = "";
                        segu_Usuario.Seguc_bEstado = chkEstado.Checked;
                        segu_UsuarioDataService.deleteRolUsuario(segu_Usuario);
                        segu_UsuarioDataService.updateUsuario(segu_Usuario);
                        foreach (string rol in chkListRoles.CheckedItems)
                        {
                            segu_UsuarioDataService.insertRolUsuario(segu_Usuario, rol);
                        }
                        MessageBox.Show("Se Grabó Correctamente");
                        segu_Usuario = null;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
