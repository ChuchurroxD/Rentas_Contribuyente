using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGR.Entity.Model;

namespace SGR.WinApp.Layout._4_Procesos.Plataforma.ConsultarPlataforma
{
    public partial class Frm_ConsultarPlataformaDetalle : Form
    {

        private Mant_Cont mant_Cont;

        public Frm_ConsultarPlataformaDetalle()
        {
            InitializeComponent();
        }

        public Frm_ConsultarPlataformaDetalle(Mant_Cont mant_Cont)
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
        private void cerrarVentanas()
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            cerrarVentanas();
            Frm_Predios Frm_Predios = new Frm_Predios(mant_Cont.persona_ID);
            Frm_Predios.MdiParent = this;
            //Frm_Predios.TopLevel = false;
            //Frm_Predios.Dock = DockStyle.Fill;

            //panel2.Controls.Add(Frm_Predios);
            //panel2.Hide();
            Frm_Predios.Show();
        }

        private void btnFraccionamiento_Click(object sender, EventArgs e)
        {
            cerrarVentanas();
            Frm_Fraccionamiento frm_fraccionamiento = new Frm_Fraccionamiento(mant_Cont.persona_ID);
            frm_fraccionamiento.MdiParent = this;
            frm_fraccionamiento.Show();
        }

        private void btnEstadoDeudas_Click(object sender, EventArgs e)
        {          

            cerrarVentanas();
            Frm_EstadoDeudas frm_EstadoDeudas = new Frm_EstadoDeudas(mant_Cont.persona_ID);
            frm_EstadoDeudas.MdiParent = this;
            frm_EstadoDeudas.Show();
        }

        private void btnLiquidaciones_Click(object sender, EventArgs e)
        {
            cerrarVentanas();
            Frm_Liquidaciones frm_Liquidaciones = new Frm_Liquidaciones(mant_Cont);
            frm_Liquidaciones.MdiParent = this;
            frm_Liquidaciones.Show();
        }

        private void btnCuentaCorriente_Click(object sender, EventArgs e)
        {
            cerrarVentanas();
            Frm_CuentaCorriente frm_cuentaCorriente = new Frm_CuentaCorriente(mant_Cont.persona_ID);
            frm_cuentaCorriente.MdiParent = this;
            frm_cuentaCorriente.Show();
        }

        private void btnRecibos_Click(object sender, EventArgs e)
        {
            cerrarVentanas();
            Frm_Recibos frm_Recibo = new Frm_Recibos(mant_Cont.persona_ID);
            frm_Recibo.MdiParent = this;
            frm_Recibo.Show();
        }

        private void btnRelaciones_Click(object sender, EventArgs e)
        {
            cerrarVentanas();
            Frm_Relaciones frm_Relaciones = new Frm_Relaciones(mant_Cont.persona_ID);
            frm_Relaciones.MdiParent = this;
            frm_Relaciones.Show();
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            cerrarVentanas();
            Frm_Pagos frm_pago = new Frm_Pagos(mant_Cont.persona_ID);
            frm_pago.MdiParent = this;
            frm_pago.Show();
        }

        private void btnValores_Click(object sender, EventArgs e)
        {
            cerrarVentanas();
            Frm_Valores frm_valores = new Frm_Valores(mant_Cont.persona_ID);
            frm_valores.MdiParent = this;
            frm_valores.Show();
        }

        private void btn_coactivo_Click(object sender, EventArgs e)
        {
            cerrarVentanas();
            Frm_Coactivo frm_Coactivo = new Frm_Coactivo(mant_Cont.persona_ID);
            frm_Coactivo.MdiParent = this;
            frm_Coactivo.Show();
        }
    }
}
