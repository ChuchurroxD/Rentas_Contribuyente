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

namespace SGR.WinApp.Layout._1_Tablas_Maestras.CajeroCajas
{
    public partial class Frm_CajeroCajaDetalle : Form
    {
        private Pago_CajeroCaja pago_CajeroCaja;
        private Pago_CajeroCajaDataService Pago_CajeroCajaDataService = new Pago_CajeroCajaDataService();

        public Frm_CajeroCajaDetalle()
        {
            InitializeComponent();
        }

        public Frm_CajeroCajaDetalle(Pago_CajeroCaja pago_CajeroCaja)
        {
            InitializeComponent();
            this.pago_CajeroCaja = pago_CajeroCaja;
        }
        private void llenarComboCaja()
        {
            cboCaja.DisplayMember = "Descripcion";
            cboCaja.ValueMember = "Caja_id";
            cboCaja.DataSource = Pago_CajeroCajaDataService.llenarComboCaja();
        }
        private void llenarComboCajaporCajero(string persona_id)
        {
            cboCaja.DisplayMember = "Descripcion";
            cboCaja.ValueMember = "Caja_id";
            cboCaja.DataSource = Pago_CajeroCajaDataService.llenarComboCajaporCajero(persona_id);
        }
        private void llenarcomboCajero()
        {
            cboCajero.DisplayMember = "Persona_desc";
            cboCajero.ValueMember = "Persona_id";
            cboCajero.DataSource = Pago_CajeroCajaDataService.llenarComboCajero();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea Grabar?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if(pago_CajeroCaja == null)
                    {
                        Pago_CajeroCaja Pago_CajeroCaja = new Pago_CajeroCaja();
                        Pago_CajeroCaja.Caja_id = Convert.ToInt32(cboCaja.SelectedValue);
                        Pago_CajeroCaja.Persona_id = cboCajero.SelectedValue.ToString();
                        Pago_CajeroCaja.Estado = chkEstado.Checked;
                        Pago_CajeroCaja.registro_fecha_add = DateTime.Now;
                        Pago_CajeroCaja.registro_pc_add = Globales.UsuarioPrueba;
                        Pago_CajeroCaja.registro_user_add = GlobalesV1.Global_str_Usuario; 
                        Pago_CajeroCajaDataService.insertar(Pago_CajeroCaja);
                    }else
                    {
                    //    pago_CajeroCaja.Caja_id = Convert.ToInt32(cboCaja.SelectedValue);
                    //    pago_CajeroCaja.Persona_id = cboCajero.SelectedValue.ToString();
                        pago_CajeroCaja.Estado = chkEstado.Checked;
                        pago_CajeroCaja.registro_fecha_update = DateTime.Now;
                        pago_CajeroCaja.registro_pc_update = Environment.MachineName;
                        pago_CajeroCaja.registro_user_update = GlobalesV1.Global_str_Usuario;
                        Pago_CajeroCajaDataService.modificar(pago_CajeroCaja);
                    }
                    this.Dispose();
                }
                }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Frm_CajeroCajaDetalle_Load(object sender, EventArgs e)
        {
            try {
                llenarComboCaja();
                llenarcomboCajero();
                if (pago_CajeroCaja != null)
                {
                    cboCajero.SelectedValue = pago_CajeroCaja.Persona_id.Trim();
                    llenarComboCaja();
                    cboCaja.SelectedValue = pago_CajeroCaja.Caja_id;
                    chkEstado.Checked = pago_CajeroCaja.Estado;
                    cboCaja.Enabled = false;
                    cboCajero.Enabled = false;
                } else
                {
                    chkEstado.Checked = true;
                }
            }catch (Exception ex)
            {

            }
        }

        private void cboCajero_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarComboCajaporCajero(cboCajero.SelectedValue.ToString());
        }
    }
}
