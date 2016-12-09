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

namespace SGR.WinApp.Layout._1_Tablas_Maestras.RolOficina
{
    public partial class Frm_rolOficina_detalle : Form
    {
        private Conf_RolOficina conf_RolOficina;        

        public Frm_rolOficina_detalle()
        {
            InitializeComponent();
        }

        public Frm_rolOficina_detalle(Conf_RolOficina conf_RolOficina)
        {
            InitializeComponent();
            this.conf_RolOficina = conf_RolOficina;
        }

        private void Frm_rolOficina_detalle_Load(object sender, EventArgs e)
        {
            Conf_RolDataService conf_RolDataService = new Conf_RolDataService();
            Pago_OficinaDataService Pago_OficinaDataService = new Pago_OficinaDataService();

            cboRol.ValueMember = "Rolec_iCodigo";
            cboRol.DisplayMember = "Rolec_vNombre";
            cboRol.DataSource = conf_RolDataService.listarRolesActivo();

            cboOficina.ValueMember = "Tarec_iCodigo";
            cboOficina.DisplayMember = "Tarec_vNombre";
            cboOficina.DataSource = Pago_OficinaDataService.listarActivos();

            if (conf_RolOficina != null)
            {
                cboRol.SelectedValue = conf_RolOficina.rol_id;
                cboOficina.SelectedValue = conf_RolOficina.rol_id;
                chkEstado.Checked = conf_RolOficina.estado;
            }
            else
            {
                chkEstado.Checked = true;
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Conf_RolOficinaDataService conf_RolOficinaDataService = new Conf_RolOficinaDataService();
            try
            {
                if (MessageBox.Show("Desea Grabar?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (conf_RolOficina == null)
                    {
                        if (conf_RolOficinaDataService.existeRolOficina((Int64)cboRol.SelectedValue, (Int64)cboOficina.SelectedValue) > 0)
                            throw new Exception("Rol Tare ya existe. No se pudo grabar.");

                        Conf_RolOficina conf_RolOficina1 = new Conf_RolOficina();
                        conf_RolOficina1.rol_id = (Int64)cboRol.SelectedValue;
                        conf_RolOficina1.rol_descripcion = cboRol.SelectedText.Trim();
                        conf_RolOficina1.oficina_id = (Int64)cboOficina.SelectedValue;
                        conf_RolOficina1.oficina_descripcion = cboOficina.SelectedText.Trim();
                        conf_RolOficina1.estado = chkEstado.Checked;
                        conf_RolOficinaDataService.Insert(conf_RolOficina1);
                        MessageBox.Show("Se Grabó Correctamente");
                        this.Close();
                    }
                    else
                    {
                        conf_RolOficina.rol_id = (Int64)cboRol.SelectedValue;
                        conf_RolOficina.rol_descripcion = cboRol.SelectedText.Trim();
                        conf_RolOficina.oficina_id = (Int64)cboOficina.SelectedValue;
                        conf_RolOficina.oficina_descripcion = cboOficina.SelectedText.Trim();
                        conf_RolOficina.estado = chkEstado.Checked;

                        conf_RolOficinaDataService.Update(conf_RolOficina);
                        MessageBox.Show("Se Grabó Correctamente");
                        conf_RolOficina = null;
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
