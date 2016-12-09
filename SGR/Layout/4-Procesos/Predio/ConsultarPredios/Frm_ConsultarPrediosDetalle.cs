using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGR.Entity.Model;

namespace SGR.WinApp.Layout._4_Procesos.Predio.ConsultarPredios
{
    public partial class Frm_ConsultarPrediosDetalle : Form
    {
        private Mant_Cont mant_Cont;

        public Frm_ConsultarPrediosDetalle()
        {
            InitializeComponent();
        }

        public Frm_ConsultarPrediosDetalle(Mant_Cont mant_Cont)
        {
            InitializeComponent();
            this.mant_Cont = mant_Cont;
        }

        private void Frm_ConsultarPrediosDetalle_Load(object sender, EventArgs e)
        {
            if(mant_Cont != null)
            {
                lblNombre.Text = mant_Cont.nombres;
                lblDireccion.Text = mant_Cont.direccCompleta;
                lblDoc.Text = mant_Cont.tipoDocumentoDescripcion +" "+ mant_Cont.documento;
                lblSector.Text = mant_Cont.sector;
                lblEstadoCuenta.Text = mant_Cont.estado_contribuyente;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Frm_Predios Frm_Predios = new Frm_Predios(mant_Cont.persona_ID);
            //Frm_Predios.MdiParent = this;
            //Frm_Predios.Show();
        }
    }
}
