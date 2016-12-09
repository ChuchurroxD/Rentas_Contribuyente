using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using SGR.Core.Service;
using System.Windows.Forms;

namespace SGR.WinApp.Layout._4_Procesos.Plataforma.ConsultarPlataforma
{
    public partial class Frm_PagosDetalle : Form
    {
        private int value;
        private Pago_PagoDataService Pago_PagoDataService = new Pago_PagoDataService();

        public Frm_PagosDetalle()
        {
            InitializeComponent();
        }

        public Frm_PagosDetalle(int value)
        {
            this.value = value;
            InitializeComponent();
        }

        private void Frm_PagosDetalle_Load(object sender, EventArgs e)
        {
            try
            {
                if(value > 0)
                {
                    dgvDetalle.AutoGenerateColumns = false;
                    dgvDetalle.DataSource = Pago_PagoDataService.listarDetallePagos(value);
                    dgvTributoPago.AutoGenerateColumns = false;
                    dgvTributoPago.DataSource = Pago_PagoDataService.listarDetalleTributov2(value);
                    lblTotal.Text = Pago_PagoDataService.totalPago(value).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
