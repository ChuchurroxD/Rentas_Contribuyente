using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SGR.WinApp.Layout._4_Procesos.Coactivo
{
    public partial class Frm_Notificacion : Form
    {
        public Frm_Notificacion()
        {
            InitializeComponent();
        }
        private string Verificar(string dato)
        {
            lblExpediente.ForeColor = System.Drawing.Color.Black;

            if (txtExpedienteAnio.Text.Trim().Length == 0)
            {
                dato = dato + "Anio de Expediente, ";
                lblExpediente.ForeColor = System.Drawing.Color.Red;
            }
            if (txtExpedienteN.Text.Trim().Length == 0)
            {
                dato = dato + "Nro de Expediente, ";
                lblExpediente.ForeColor = System.Drawing.Color.Red;
            }
            return dato;
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                string dato = Verificar("");
                if (dato.Trim().Length != 0)
                {
                    MessageBox.Show("Falta " + dato, Globales.Global_MessageBox);
                    return;
                }
                MessageBox.Show("Se generó notificación", Globales.Global_MessageBox);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), Globales.Global_MessageBox);
            }
        }
    }
}
