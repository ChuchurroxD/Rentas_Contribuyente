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

namespace SGR.WinApp.Layout._2_Configuraciones.Rol
{
    public partial class Frm_rol_detalle : Form
    {
        private Conf_Rol conf_Rol;
        private Sistema.Globales.Validaciones obValidacion = new Sistema.Globales.Validaciones();
        public Frm_rol_detalle()
        {
            InitializeComponent();
            OcultarElementos(false);
            txtDescripcion.MaxLength = 50;
            txtNombre.MaxLength = 50;
        }
        public Frm_rol_detalle(Conf_Rol conf_rol)
        {
            InitializeComponent();
            OcultarElementos(true);
            Conf_UnidadNegocioDataService conf_UnidadNegocioRepository = new Conf_UnidadNegocioDataService();
            this.conf_Rol = conf_rol;
            txtId.Text = conf_Rol.Rolec_iCodigo.ToString();
            txtDescripcion.Text = conf_Rol.Rolec_vDescripcion;
            txtNombre.Text = conf_Rol.Rolec_vNombre;
            ckbEstado.Checked = conf_Rol.Rolec_bActivo;

        }
        private void btnGrabar_Click(object sender, EventArgs e)
        {
           Conf_RolDataService Conf_RolDataService = new Conf_RolDataService();
                int codigo, cantidad;
                try
                { 
                if (txtDescripcion.Text.Trim().Length > 0 && txtNombre.Text.Trim().Length>0)
                    {
                    
                    if (MessageBox.Show("Desea Grabar?", Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (conf_Rol == null)
                        {
                            Conf_Rol conf_Rol = new Conf_Rol();
                            Conf_UnidadNegocio con_UniN = new Conf_UnidadNegocio();
                            conf_Rol.Rolec_vDescripcion = txtDescripcion.Text.Trim();
                            conf_Rol.Rolec_vNombre = txtNombre.Text.Trim();
                            cantidad = Conf_RolDataService.GetExisteDescripcionNuevo(conf_Rol.Rolec_vNombre);
                            if (cantidad > 0)
                            {
                                MessageBox.Show("Existe Descripción", Globales.Global_MessageBox);
                            }
                            else
                            {
                                codigo = Conf_RolDataService.Insert(conf_Rol);
                                if (codigo > 0)
                                {
                                    MessageBox.Show("Se Grabó Correctamente", Globales.Global_MessageBox);
                                }
                            }

                            this.Close();
                        }
                        else
                        {
                            Conf_Rol conf_Rol = new Conf_Rol();
                            Conf_UnidadNegocio con_UniN = new Conf_UnidadNegocio();
                            conf_Rol.Rolec_vDescripcion = txtDescripcion.Text.Trim();
                            conf_Rol.Rolec_vNombre = txtNombre.Text.Trim();
                            conf_Rol.Rolec_iCodigo = Int64.Parse(txtId.Text);
                            conf_Rol.Rolec_bActivo = ckbEstado.Checked;
                            cantidad = Conf_RolDataService.GetExisteDescripcionModificar(conf_Rol.Rolec_vNombre,conf_Rol.Rolec_iCodigo);
                            if (cantidad > 0)
                            {
                                MessageBox.Show("Existe Descripción", Globales.Global_MessageBox);
                            }
                            else
                            {
                                Conf_RolDataService.Update(conf_Rol);
                                MessageBox.Show("Se Grabó Correctamente", Globales.Global_MessageBox);
                            }

                            conf_Rol = null;
                            this.Close();
                        }
                    }
                }
                else
                        MessageBox.Show("Tiene que colocar una descripción y el nombre", Globales.Global_MessageBox);
                }
             catch (Exception ex)
                {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }   
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void OcultarElementos(bool tipo)
        {
            txtId.Visible = false;
            ckbEstado.Visible = tipo;
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.ValidaLetras(e, Globales.Global_MessageBox);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.ValidaLetras(e, Globales.Global_MessageBox);
        }

        private void Frm_rol_detalle_Load(object sender, EventArgs e)
        {

        }
    }
}
