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

namespace SGR.WinApp.Layout._1_Tablas_Maestras.RolTarea
{
    public partial class Frm_rolTarea_detalle : Form
    {
        private Conf_RolTarea conf_RolTarea;

        public Frm_rolTarea_detalle()
        {
            InitializeComponent();
        }

        public Frm_rolTarea_detalle(Conf_RolTarea conf_RolTarea)
        {
            InitializeComponent();
            this.conf_RolTarea = conf_RolTarea;
        }

        private void Frm_rolTarea_detalle_Load(object sender, EventArgs e)
        {
            Conf_RolDataService conf_RolDataService = new Conf_RolDataService();
            Conf_TareaDataService conf_TareaDataService = new Conf_TareaDataService();

            cboRol.ValueMember = "Rolec_iCodigo";
            cboRol.DisplayMember = "Rolec_vNombre";
            cboRol.DataSource = conf_RolDataService.listarRolesActivo();

            cboTarea.ValueMember = "Tarec_iCodigo";
            cboTarea.DisplayMember = "Tarec_vNombre";
            cboTarea.DataSource = conf_TareaDataService.listarActivos((long)0);

            if (conf_RolTarea != null)
            {
                cboRol.SelectedValue = conf_RolTarea.rol_id;
                cboTarea.SelectedValue = conf_RolTarea.tarea_id;
                chkEstado.Checked = conf_RolTarea.estado;
            }
            else
            {
                chkEstado.Checked = true;
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Conf_RolTareaDataService conf_RolTareaDataService = new Conf_RolTareaDataService();
            try
            {
                if (MessageBox.Show("Desea Grabar?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (conf_RolTarea == null)
                    {
                        if (conf_RolTareaDataService.existeRolTarea((Int64)cboRol.SelectedValue, (Int64)cboTarea.SelectedValue) > 0)
                            throw new Exception("Rol Tare ya existe. No se pudo grabar.");

                        Conf_RolTarea conf_RolTarea1 = new Conf_RolTarea();
                        conf_RolTarea1.rol_id = (Int64)cboRol.SelectedValue;
                        conf_RolTarea1.rol_descripcion = cboRol.SelectedText.Trim();
                        conf_RolTarea1.tarea_id = (Int64)cboTarea.SelectedValue;
                        conf_RolTarea1.tar_descripcion = cboTarea.SelectedText.Trim();
                        conf_RolTarea1.estado = chkEstado.Checked;
                        conf_RolTareaDataService.Insert(conf_RolTarea1);
                        MessageBox.Show("Se Grabó Correctamente");
                        this.Close();
                    }
                    else
                    {
                        conf_RolTarea.rol_id = (Int64)cboRol.SelectedValue;
                        conf_RolTarea.rol_descripcion = cboRol.SelectedText.Trim();
                        conf_RolTarea.tarea_id = (Int64)cboTarea.SelectedValue;
                        conf_RolTarea.tar_descripcion = cboTarea.SelectedText.Trim();
                        conf_RolTarea.estado = chkEstado.Checked;

                        conf_RolTareaDataService.Update(conf_RolTarea);
                        MessageBox.Show("Se Grabó Correctamente");
                        conf_RolTarea = null;
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
