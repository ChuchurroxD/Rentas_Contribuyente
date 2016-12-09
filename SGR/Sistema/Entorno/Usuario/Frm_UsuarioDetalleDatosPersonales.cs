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
using WeifenLuo.WinFormsUI.Docking;

namespace SGR.WinApp.Sistema.Entorno.Usuario
{
    public partial class Frm_UsuarioDetalleDatosPersonales : DockContent
    {

        private Segu_Usuario segu_Usuario= new Segu_Usuario();
        Segu_UsuarioDataService segu_UsuarioDataService = new Segu_UsuarioDataService();
        //public Frm_UsuarioDetalleDatosPersonales()
        //{
        //    InitializeComponent();
        //}
        public Frm_UsuarioDetalleDatosPersonales()
        {
            InitializeComponent();
            string usu = GlobalesV1.Global_str_Usuario;
            this.segu_Usuario = segu_UsuarioDataService.DatosUsuario(usu);
            txtNombre.Text = segu_Usuario.Seguc_vNombre;
            txtApellido.Text = segu_Usuario.Seguc_vApellidos;
            txtLogin.Text = segu_Usuario.Seguc_vLogin;
            txtPassword.Text = segu_Usuario.Seguc_password;
        }

        private void Frm_UsuarioDetalleDatosPersonales_Load(object sender, EventArgs e)
        {
             
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
               
                if (MessageBox.Show("Desea Grabar?", "SGR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                        segu_Usuario.Seguc_vNombre = txtNombre.Text.Trim();
                        segu_Usuario.Seguc_vApellidos = txtApellido.Text.Trim();
                        segu_Usuario.Seguc_vLogin = txtLogin.Text.Trim();
                        segu_Usuario.Seguc_password = txtPassword.Text.Trim();
                        segu_UsuarioDataService.updateUsuarioDatosPersonales(segu_Usuario);
                        MessageBox.Show("Se Grabó Correctamente");
                        segu_Usuario = null;
                        this.Close();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
