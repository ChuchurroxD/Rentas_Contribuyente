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
using SGR.Entity;

namespace SGR.WinApp.Layout._1_Tablas_Maestras.Grupo
{
    public partial class Frm_grupos_detalle : Form
    {
        private Conf_Grupo conf_Grupo;

        public Frm_grupos_detalle()
        {
            InitializeComponent();
        }

        public Frm_grupos_detalle(Conf_Grupo conf_Grupo)
        {
            InitializeComponent();
            this.conf_Grupo = conf_Grupo;
        }

        private void Frm_grupos_detalle_Load(object sender, EventArgs e)
        {
            if (conf_Grupo != null)
            {
                txtNombre.Text = conf_Grupo.Grupc_vNombre;
                txtDescripcion.Text = conf_Grupo.Grupc_vDescripcion;
                chkEstado.Checked = conf_Grupo.Grupc_bActivo;
            }
            else
            {
                chkEstado.Checked = true;
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Conf_GrupoDataService conf_GrupoDataService = new Conf_GrupoDataService();
            try
            {
                if (txtNombre.Text.Trim().Length <= 0)
                    throw new Exception("Debe ingresar un nombre.");
                if (txtDescripcion.Text.Trim().Length <= 0)
                    throw new Exception("Debe ingresar una descripción.");

                if (MessageBox.Show("Desea Grabar?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (conf_Grupo == null)
                    {
                        if (conf_GrupoDataService.GetExisteNombreNuevo(txtNombre.Text.Trim()) > 0)
                            throw new Exception("Nombre ya existe. No se pudo grabar.");

                        Conf_Grupo conf_Grupo1 = new Conf_Grupo();
                        conf_Grupo1.Grupc_vNombre = txtNombre.Text.Trim();
                        conf_Grupo1.Grupc_vDescripcion = txtDescripcion.Text.Trim();
                        conf_Grupo1.Grupc_bActivo = chkEstado.Checked;
                        conf_Grupo1.registro_user_add = GlobalesV1.Global_str_Usuario;
                        conf_Grupo1.registro_user_update = GlobalesV1.Global_str_Usuario;
                        conf_GrupoDataService.Insert(conf_Grupo1);
                        MessageBox.Show("Se Grabó Correctamente");
                        this.Close();
                    }
                    else
                    {
                        if (conf_GrupoDataService.GetExisteNombreModificar(txtNombre.Text.Trim(), conf_Grupo.Grupc_iCodigo) > 0)
                            throw new Exception("Nombre ya existe. No se pudo grabar.");
                        conf_Grupo.Grupc_vNombre = txtNombre.Text.Trim();
                        conf_Grupo.Grupc_vDescripcion = txtDescripcion.Text.Trim();
                        conf_Grupo.Grupc_bActivo = chkEstado.Checked;
                        conf_Grupo.registro_user_update = GlobalesV1.Global_str_Usuario;
                        conf_GrupoDataService.Update(conf_Grupo);
                        MessageBox.Show("Se Grabó Correctamente");
                        conf_Grupo = null;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Frm_grupos_detalle_Load_1(object sender, EventArgs e)
        {

        }
    }
}
