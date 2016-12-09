using SGR.Core.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SGR.WinApp.Layout._4_Procesos.Predio
{
    public partial class Frm_Validacion : Form
    {

        Segu_UsuarioDataService segu_UsuarioDataService = new Segu_UsuarioDataService();
        public Frm_Validacion()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string pass = txtpassword.Text.Trim();
            string usua = txtusuario.Text.Trim();
            if (usua.Length == 0 || pass.Length == 0) {

                MessageBox.Show("Logee para continuar", Globales.Global_MessageBox);
                return;
            }
            Globales.validado = 0;
            Globales.validado=segu_UsuarioDataService.VerificarSiEsADmin(usua,pass);
                if(Globales.validado==0)
                    MessageBox.Show("Logee incorrecto o su usario no es administrador", Globales.Global_MessageBox);
                else
                    MessageBox.Show("Logee correcto", Globales.Global_MessageBox);
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
    //if(/*txtpassword*/.te)
}

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Globales.validado = 0;
            this.Dispose();
        }
    }
}
