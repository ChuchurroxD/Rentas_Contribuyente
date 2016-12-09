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

namespace SGR.WinApp.Sistema.Entorno
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                Segu_Usuario Segu_Usuario = new Segu_Usuario();
                Segu_Usuario.Seguc_vLogin = txtusuario.Text;
                Segu_Usuario.Seguc_password = txtpassword.Text;
                Segu_UsuarioDataService segu_UsuarioDataService = new Segu_UsuarioDataService();
                Segu_Usuario = segu_UsuarioDataService.validarUsuario(Segu_Usuario);
                    if (Segu_Usuario == null)
                {
                    MessageBox.Show("Usuario Invalido");
                    return;
                }
            GlobalesV1.Global_str_Nombre = Segu_Usuario.Seguc_vNombre;
            Conf_RolDataService Conf_RolDataService = new Conf_RolDataService();
            cborol .DataSource =    Conf_RolDataService.listarxusuario(Segu_Usuario);
            cborol.DisplayMember = "Rolec_vNombre";
            cborol.ValueMember = "Rolec_iCodigo";
            cborol.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbooficina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                if (cborol.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione Rol");
                    return;
                }
                if (cbooficina.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione Oficina");
                    return;
                }

                if (cborol.SelectedIndex == 0)
                {
                    MessageBox.Show("Seleccione Rol");
                    return;
                }

                if (cbooficina.SelectedIndex == 0)
                {
                    MessageBox.Show("Seleccione Oficina");
                    return;
                }
                GlobalesV1.Global_str_Rol = cborol.Text;
                GlobalesV1.Global_str_Usuario = txtusuario.Text;
                GlobalesV1.Global_str_oficina = cbooficina.Text;
                GlobalesV1.Global_int_idrol = int.Parse ( cborol.SelectedValue.ToString());
                GlobalesV1.Global_int_idoficina = int.Parse(cbooficina.SelectedValue.ToString());
                MainPrincipal.Instancia.Show();
                this.Hide();
            }
          
        }

        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtpassword.Focus();
            }
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                button1.Focus();
            }
        }


        void confirol()
        {          
            Pago_OficinaDataService Pago_OficinaDataService = new Pago_OficinaDataService();
            cbooficina.DataSource = Pago_OficinaDataService.listarxrol(cborol.SelectedValue.ToString());
            cbooficina.DisplayMember = "Descripcion";
            cbooficina.ValueMember = "oficina_id";
            cbooficina.Focus();
        }

        private void cborol_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cborol.SelectedIndex == -1)
                return;

            if (cborol.SelectedIndex == 0)                           
                return;

                        
            confirol();
        }

        private void cborol_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (cborol.SelectedIndex == -1)
                    return;

                if (cborol.SelectedIndex == 0)
                {
                    MessageBox.Show("Seleccione Rol");
                    return;


                }

                confirol();

            }
        }

        private void cbooficina_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cborol_Click(object sender, EventArgs e)
        {

          
           
          
        }
    }
}
