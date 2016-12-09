using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGR.Entity;
using SGR.Core.Service;

namespace SGR.WinApp.Layout._1_Tablas_Maestras.Junta_Via
{
    public partial class Frm_Junta_ViaDetalle : Form
    {
        private Mant_Junta_Via mant_Junta_Via;
        private Mant_JuntaViaDataService Mant_JuntaViaDataService = new Mant_JuntaViaDataService();

        public Frm_Junta_ViaDetalle()
        {
            InitializeComponent();
        }

        public Frm_Junta_ViaDetalle(Mant_Junta_Via mant_Junta_Via)
        {
            this.mant_Junta_Via = mant_Junta_Via;
            InitializeComponent();
        }

        private void Frm_Junta_ViaDetalle_Load(object sender, EventArgs e)
        {
            try
            {
                llenarComboSector();
                llenarComboVia();
                if(mant_Junta_Via != null)
                {
                    cboSector.SelectedValue = Convert.ToInt32(mant_Junta_Via.junta_ID);
                    cboVia.SelectedValue = mant_Junta_Via.via_ID;
                    chkEstado.Checked = mant_Junta_Via.estado;
                }else
                {
                    chkEstado.Checked = true;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void llenarComboSector()
        {
            cboSector.DisplayMember = "descripcion";
            cboSector.ValueMember = "sector_id";
            cboSector.DataSource = Mant_JuntaViaDataService.llenarCombosector(GlobalesV1.Global_int_idoficina);
        }
        private void llenarComboVia()
        {
            cboVia.DisplayMember = "descripcion";
            cboVia.ValueMember = "Via_id";
            cboVia.DataSource = Mant_JuntaViaDataService.llenarComboVia();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea Grabar?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if(mant_Junta_Via == null)
                    {
                        Mant_Junta_Via mant_Junta_Via = new Mant_Junta_Via();
                        mant_Junta_Via.junta_ID = cboSector.SelectedValue.ToString();
                        mant_Junta_Via.via_ID = cboVia.SelectedValue.ToString();
                        mant_Junta_Via.estado = chkEstado.Checked;
                        mant_Junta_Via.registro_fecha_add = DateTime.Now;
                        mant_Junta_Via.registro_pc_add = Environment.MachineName;
                        mant_Junta_Via.registro_user_add = Globales.UsuarioPrueba;
                        Mant_JuntaViaDataService.insert(mant_Junta_Via);
                    }
                    else
                    {
                        mant_Junta_Via.junta_ID = cboSector.SelectedValue.ToString();
                        mant_Junta_Via.via_ID = cboVia.SelectedValue.ToString();
                        mant_Junta_Via.estado = chkEstado.Checked;
                        mant_Junta_Via.registro_fecha_update = DateTime.Now;
                        mant_Junta_Via.registro_pc_update = Environment.MachineName;
                        mant_Junta_Via.registro_user_update = Globales.UsuarioPrueba;
                        Mant_JuntaViaDataService.update(mant_Junta_Via);
                    }
                    this.Dispose();
                }
                }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
