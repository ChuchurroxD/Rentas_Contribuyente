using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGR.Entity;
using SGR.Core.Service;
using SGR.Entity.Model;
using System;
using System.Collections.Generic;
using WeifenLuo.WinFormsUI.Docking;
using Microsoft.Reporting.WinForms;
using SGR.WinApp.Layout._5_Reportes_Gestion;
using DgvFilterPopup;
using SGR.WinApp.Sistema.Globales;

namespace SGR.WinApp.Sistema.Entorno.Usuario
{
    public partial class Frm_Usuario : DockContent
    {
        private Segu_UsuarioDataService segu_UsuarioDataService = new Segu_UsuarioDataService();
        private List<Segu_Usuario> coleccion;
        private System.Windows.Forms.SortOrder Orden = new System.Windows.Forms.SortOrder();

        public Frm_Usuario()
        {
            InitializeComponent();
        }

        private void Frm_Usuario_Load(object sender, EventArgs e)
        {
            try
            {
                txtBusqueda.Focus();
                coleccion = segu_UsuarioDataService.listarUsuarios();
                dgUsuario.DataSource = coleccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_UsuarioDetalle frm_usuarioDetalle = new Frm_UsuarioDetalle();
                frm_usuarioDetalle.StartPosition = FormStartPosition.CenterParent;
                frm_usuarioDetalle.ShowDialog();
                Segu_UsuarioDataService segu_UsuarioDataService = new Segu_UsuarioDataService();
                dgUsuario.DataSource = segu_UsuarioDataService.listarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgUsuario.CurrentRow == null)
                    throw new Exception("Debe seleccionar una fila.");

                Frm_UsuarioDetalle frm_usuarioDetalle = new Frm_UsuarioDetalle(obtenerDatos());
                frm_usuarioDetalle.StartPosition = FormStartPosition.CenterParent;
                frm_usuarioDetalle.ShowDialog();

                if (txtBusqueda.Text.Trim().Length == 0)
                    dgUsuario.DataSource = segu_UsuarioDataService.listarUsuarios();
                //else
                    //dgUsuario.DataSource = segu_UsuarioDataService..listarBusqueda(txtBusqueda.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Segu_Usuario obtenerDatos()
        {
            Segu_Usuario segu_Usuario = new Segu_Usuario();
            segu_Usuario.Seguc_iCodigo = (Int32)dgUsuario.SelectedRows[0].Cells["xUsuario_codigo"].Value;
            segu_Usuario.per_codigo = (string)dgUsuario.SelectedRows[0].Cells["xPersona_codigo"].Value.ToString().TrimEnd();
            segu_Usuario.Seguc_vNombre = (string)dgUsuario.SelectedRows[0].Cells["xUsuario_nombre"].Value.ToString().TrimEnd();
            segu_Usuario.Seguc_vApellidos = (string)dgUsuario.SelectedRows[0].Cells["xUsuario_apellido"].Value.ToString().TrimEnd();
            segu_Usuario.areas_codarea = (string)dgUsuario.SelectedRows[0].Cells["xUsuario_codArea"].Value.ToString().TrimEnd();
            segu_Usuario.Seguc_fFechaCreacion = (DateTime)dgUsuario.SelectedRows[0].Cells["xUsuario_fechaCreacion"].Value;
            segu_Usuario.Seguc_vLogin = (string)dgUsuario.SelectedRows[0].Cells["xUsuario_login"].Value.ToString().TrimEnd();
            segu_Usuario.Seguc_password = (string)dgUsuario.SelectedRows[0].Cells["xUsuario_password"].Value.ToString().TrimEnd();
            //segu_Usuario.Seguc_vLast = (string)dgUsuario.SelectedRows[0].Cells["xUsuario_last"].Value.ToString().TrimEnd();
            //segu_Usuario.Seguc_vSession = (string)dgUsuario.SelectedRows[0].Cells["xUsuario_Session"].Value.ToString().TrimEnd();
            segu_Usuario.Seguc_fFechaCese = (DateTime)dgUsuario.SelectedRows[0].Cells["xUsuario_fechaCese"].Value;
            segu_Usuario.Seguc_bEstado = (bool)dgUsuario.SelectedRows[0].Cells["xUsuario_estado"].Value;
            return segu_Usuario;
        }

        private void dgUsuario_DoubleClick(object sender, EventArgs e)
        {
            toolEditar.PerformClick();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            coleccion = segu_UsuarioDataService.buscarUsuario(txtBusqueda.Text.Trim());
            dgUsuario.DataSource = coleccion;
        }
    }
}
