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
namespace SGR.WinApp.Layout._1_Tablas_Maestras.Tarea
{
    public partial class Frm_tareas_detalle : Form
    {
        private Conf_Tarea conf_Tarea;

        public Frm_tareas_detalle()
        {
            InitializeComponent();
        }

        public Frm_tareas_detalle(Conf_Tarea conf_Tarea)
        {
            InitializeComponent();
            this.conf_Tarea = conf_Tarea;
        }

        private void Frm_tareas_detalle_Load(object sender, EventArgs e)
        {
            llenarComboGrupos();

            if (conf_Tarea != null)
            {
                cboGrupo.SelectedValue = conf_Tarea.Grupo_id;
                txtNombre.Text = conf_Tarea.Tarec_vNombre;
                txtDescripcion.Text = conf_Tarea.Tarec_vDescripcion;
                txtUrl.Text = conf_Tarea.Tarec_vUrl;
                chkEstado.Checked = conf_Tarea.Tarec_bActivo;
            }
            else
            {
                chkEstado.Checked = true;
            }
        }

        private void llenarComboGrupos()
        {
            Conf_GrupoDataService conf_GrupoDataService = new Conf_GrupoDataService();
            cboGrupo.DisplayMember = "Grupc_vDescripcion";
            cboGrupo.ValueMember = "Grupc_iCodigo";
            cboGrupo.DataSource = conf_GrupoDataService.GetActivosConf_Grupo();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Conf_TareaDataService conf_TareaDataService = new Conf_TareaDataService();
            try
            {
                if (txtNombre.Text.Trim().Length <= 0)
                    throw new Exception("Debe ingresar un nombre.");
                if (txtDescripcion.Text.Trim().Length <= 0)
                    throw new Exception("Debe ingresar una descripción.");
                if (txtUrl.Text.Trim().Length <= 0)
                    throw new Exception("Debe ingresar una url.");

                if (MessageBox.Show("Desea Grabar?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (conf_Tarea == null)
                    {
                        if (conf_TareaDataService.GetExisteNombreNuevo(txtNombre.Text.Trim()) > 0)
                            throw new Exception("Nombre ya existe. No se pudo grabar.");

                        Conf_Tarea conf_Tarea1 = new Conf_Tarea();
                        conf_Tarea1.Grupo_id = (Int64)cboGrupo.SelectedValue;
                        conf_Tarea1.Tarec_vNombre = txtNombre.Text.Trim();
                        conf_Tarea1.Tarec_vDescripcion = txtDescripcion.Text.Trim();
                        conf_Tarea1.Tarec_vUrl = txtUrl.Text.Trim();
                        conf_Tarea1.Tarec_bActivo = chkEstado.Checked;
                        conf_Tarea1.registro_user_add = GlobalesV1.Global_str_Usuario;
                        conf_Tarea1.registro_user_update = GlobalesV1.Global_str_Usuario;
                        conf_TareaDataService.Insert(conf_Tarea1);
                        MessageBox.Show("Se Grabó Correctamente");
                        this.Close();
                    }
                    else
                    {
                        if (conf_TareaDataService.GetExisteNombreModificar(txtNombre.Text.Trim(), conf_Tarea.Tarec_iCodigo) > 0)
                            throw new Exception("Nombre ya existe. No se pudo grabar.");

                        conf_Tarea.Grupo_id = (Int64)cboGrupo.SelectedValue;
                        conf_Tarea.Tarec_vNombre = txtNombre.Text.Trim();
                        conf_Tarea.Tarec_vDescripcion = txtDescripcion.Text.Trim();
                        conf_Tarea.Tarec_vUrl = txtUrl.Text.Trim();
                        conf_Tarea.Tarec_bActivo = chkEstado.Checked;
                        conf_Tarea.registro_user_update = GlobalesV1.Global_str_Usuario;
                        conf_TareaDataService.Update(conf_Tarea);
                        MessageBox.Show("Se Grabó Correctamente");
                        conf_Tarea = null;
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
    }
}
