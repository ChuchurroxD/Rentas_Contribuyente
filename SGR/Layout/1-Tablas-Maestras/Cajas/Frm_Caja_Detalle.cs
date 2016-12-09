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

namespace SGR.WinApp.Layout._1_Tablas_Maestras.Cajas
{
    public partial class Frm_Caja_Detalle : Form
    {
        private Pago_Caja pago_Caja;
        private Pago_CajaDataService Pago_CajaDataService = new Pago_CajaDataService();

        public Frm_Caja_Detalle()
        {
            InitializeComponent();
            llenarOficina();
        }

        public Frm_Caja_Detalle(Pago_Caja pago_Caja)
        {
            this.pago_Caja = pago_Caja;
            InitializeComponent();
        }
        private void llenarOficina()
        {
            cboOficina.ValueMember = "oficina_id";
            cboOficina.DisplayMember = "Descripcion";
            cboOficina.DataSource = Pago_CajaDataService.llenarOficina();
        }

        private void Frm_Caja_Detalle_Load(object sender, EventArgs e)
        {
            try
            {
                llenarOficina();
                cboOficina.SelectedIndex = 0;
                if (pago_Caja != null)
                {
                    txtDescripcion.Text = pago_Caja.Descripcion;
                    cboOficina.SelectedValue = pago_Caja.idOficina;
                    chkEstado.Checked = pago_Caja.Estado;
                }
                else
                {
                    chkEstado.Checked = true;
                }
             }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDescripcion.Text.Trim().Length <= 0)
                {
                    MessageBox.Show("Debe ingresar una descripcion", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }
                if (MessageBox.Show("Desea Grabar?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (pago_Caja == null)
                    {
                        Pago_Caja pago_Caja = new Pago_Caja();
                        pago_Caja.Descripcion = txtDescripcion.Text;
                        pago_Caja.idOficina = Convert.ToInt32(cboOficina.SelectedValue);
                        pago_Caja.Estado = chkEstado.Checked;
                        pago_Caja.registro_fecha_add = DateTime.Now;
                        pago_Caja.registro_user_add = Globales.UsuarioPrueba;
                        pago_Caja.registro_pc_add = Environment.MachineName;
                        Pago_CajaDataService.insert(pago_Caja);
                    }else
                    {
                        pago_Caja.Descripcion = txtDescripcion.Text;
                        pago_Caja.idOficina = Convert.ToInt32(cboOficina.SelectedValue);
                        pago_Caja.Estado = chkEstado.Checked;
                        pago_Caja.registro_fecha_update = DateTime.Now;
                        pago_Caja.registro_user_update = Globales.UsuarioPrueba;
                        pago_Caja.registro_pc_update = Environment.MachineName;
                        Pago_CajaDataService.update(pago_Caja);
                    }
                    this.Dispose();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
