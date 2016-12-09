using SGR.Core.Service;
using SGR.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SGR.WinApp.Layout._4_Procesos.Liquidacion
{
    public partial class FrmListadoLiquidacion : Form
    {
        Liqu_LiquidacionDataService Liqu_LiquidacionDataService = new Liqu_LiquidacionDataService();
        List<Liqu_Liquidacion> coleccion = new List<Liqu_Liquidacion>();
        int tipo = 0;
        DateTime fecha_ini, fecha_fin;
        string estado, tipo_liqui, contribuyente;
        public FrmListadoLiquidacion()
        {
            InitializeComponent();
            tipo = 1;
            cargarGrilla();            
        }
        public FrmListadoLiquidacion(DateTime fecha_ini, DateTime fecha_fin,
           string estado, string tipo_liqui, string contribuyente)
        {
            InitializeComponent();
            tipo = 2;
            this.fecha_ini = fecha_ini;
            this.fecha_fin = fecha_fin;
            this.estado = estado;
            this.tipo_liqui = tipo_liqui;
            this.contribuyente = contribuyente;
            cargarGrilla();
        }


        private void FrmListadoLiquidacion_Load(object sender, EventArgs e)
        {
            
        }
        public void cargarGrilla()
        {
            try
            {
                if(tipo==1)
                    coleccion = Liqu_LiquidacionDataService.listadoLiquidaciones();
                else
                    coleccion = Liqu_LiquidacionDataService.listadoLiquidacionesBusqueda(fecha_ini,fecha_fin,estado,
                        tipo_liqui,contribuyente);
                dataGridView1.DataSource = coleccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea Anular el registro?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    int liquidacion_ID =(Int32)dataGridView1.SelectedRows[0].Cells["xliquidacion_id"].Value;
                    if (Liqu_LiquidacionDataService.eliminarLiquidacion(liquidacion_ID))
                        MessageBox.Show("Se Anulo Correctamente", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Error al Anular", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarGrilla();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al anular el registro", Globales.Global_MessageBox);
            }
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            Frm_BusquedaAvanzada f = new Frm_BusquedaAvanzada();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea Anular liquidaciones pendientes?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {                    
                    if (Liqu_LiquidacionDataService.eliminarLiquidacionPendiente())
                        MessageBox.Show("Se Anulo Correctamente", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Error al Anular", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarGrilla();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al anular liquidaciones", Globales.Global_MessageBox);
            }
        }
        private void CambiarPosicion(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Convert.ToString(dataGridView1.SelectedRows[0].Cells["xestado"].Value).Equals("Pendiente"))
                    toolAnular.Enabled = true;
                else
                    toolAnular.Enabled = false;
            }
            catch (Exception ex)
            {

            }
        }
    }
}
