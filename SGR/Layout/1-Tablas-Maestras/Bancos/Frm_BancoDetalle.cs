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

namespace SGR.WinApp.Layout._1_Tablas_Maestras.Bancos
{
    public partial class Frm_BancoDetalle : Form
    {
        private Mant_Banco mant_Banco;
        private Mant_BancoDataService Mant_BancoDataService = new Mant_BancoDataService();

        public Frm_BancoDetalle()
        {
            InitializeComponent();
        }

        public Frm_BancoDetalle(Mant_Banco mant_Banco)
        {
            this.mant_Banco = mant_Banco;
            InitializeComponent();
        }

        private void Frm_BancoDetalle_Load(object sender, EventArgs e)
        {
            try
            {
                if(mant_Banco != null)
                {
                    txtDescripcion.Text = mant_Banco.descripcion;
                    chkEstado.Checked = mant_Banco.estado;
                }else
                {
                    chkEstado.Checked = true;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDescripcion.Text.Trim().Length <= 0)
                {
                    MessageBox.Show("Debe ingresar una descripción",Globales.Global_MessageBox);
                    return;
                }
                if (MessageBox.Show("Desea Grabar?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (mant_Banco == null)
                    {
                        Mant_Banco Mant_banco = new Mant_Banco();
                        Mant_banco.descripcion = txtDescripcion.Text;
                        Mant_banco.estado = chkEstado.Checked;
                        Mant_banco.registro_fecha_add = DateTime.Now;
                        Mant_banco.registro_pc_add = Environment.MachineName;
                        Mant_banco.registro_user_add = Globales.UsuarioPrueba;
                        Mant_BancoDataService.Insert(Mant_banco);
                    }
                    else
                    {
                        mant_Banco.descripcion = txtDescripcion.Text;
                        mant_Banco.estado = chkEstado.Checked;
                        mant_Banco.registro_fecha_update = DateTime.Now;
                        mant_Banco.registro_pc_update = Environment.MachineName;
                        mant_Banco.registro_user_update = Globales.UsuarioPrueba;
                        Mant_BancoDataService.Update(mant_Banco);
                    }
                    this.Dispose();
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
