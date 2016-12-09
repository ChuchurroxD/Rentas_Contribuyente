using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGR.Core.Service;

namespace SGR.WinApp.Layout._4_Procesos.Plataforma.ConsultarPlataforma
{
    public partial class Frm_LiquidacionesDetalle : Form
    {
        private int liquidacion_ID;
        private Liqu_DeudaDetalleMontoDataService LiquiDetalleDataService = new Liqu_DeudaDetalleMontoDataService();
        public Frm_LiquidacionesDetalle()
        {
            InitializeComponent();
        }
        private void Frm_LiquidacionesDetalle_Load(object sender, EventArgs e)
        {
            try
            {
                if (liquidacion_ID != 0)
                {
                    lblDetalle.Text = "Detalle de Liquidación N°" + liquidacion_ID.ToString();
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataSource = LiquiDetalleDataService.listardetalleTributoporLiquidacion(liquidacion_ID);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    }
        public Frm_LiquidacionesDetalle(int liquidacion_ID)
        {
            this.liquidacion_ID = liquidacion_ID;
            InitializeComponent();
        }
    }
}
