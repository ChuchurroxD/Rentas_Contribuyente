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
namespace SGR.WinApp.Layout._2_Configuraciones.UnidadNegoci
{
    public partial class Frm_unidadNegocio_detalle : Form
    {
        private Conf_UnidadNegocio conf_UnidadNegocio;
        private Sistema.Globales.Validaciones obValidacion = new Sistema.Globales.Validaciones();
        public Frm_unidadNegocio_detalle()
        {
            InitializeComponent();
            txtDescripcion.MaxLength = 70;
            OcultarElementos(false);
        }
        public Frm_unidadNegocio_detalle(Conf_UnidadNegocio conf_UnidadNegocio)
        {
            InitializeComponent();
            txtDescripcion.MaxLength = 140;
            this.conf_UnidadNegocio = conf_UnidadNegocio;
            if (conf_UnidadNegocio != null)
            {
                txtDescripcion.Text = conf_UnidadNegocio.UnNec_vDescripcion;
                txtId.Text = conf_UnidadNegocio.UnNec_iCodigo.ToString();
                ckbEstado.Checked = conf_UnidadNegocio.UnNegoc_bActivo;
                OcultarElementos(true);
            }
        }
        private void btnGrabar_Click(object sender, EventArgs e)
        {
           
            Conf_UnidadNegocioDataService Conf_UnidadNegocioDataService = new Conf_UnidadNegocioDataService();
             int codigo,cantidad;
            try{
                if (txtDescripcion.Text.Trim().Length > 0)
                    
                {
                    if (MessageBox.Show("Desea Grabar?", Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (conf_UnidadNegocio == null)
                        {
                            Conf_UnidadNegocio conf_UnidadNegocio = new Conf_UnidadNegocio();
                                conf_UnidadNegocio.UnNec_vDescripcion = txtDescripcion.Text.Trim();

                                cantidad = Conf_UnidadNegocioDataService.GetExisteDescripcionNuevo(conf_UnidadNegocio.UnNec_vDescripcion);
                                if (cantidad > 0)
                                {
                                MessageBox.Show("Existe Descripción", Globales.Global_MessageBox);
                                }
                                else
                                {
                                    codigo = Conf_UnidadNegocioDataService.Insert(conf_UnidadNegocio);
                                    if (codigo > 0)
                                    {
                                        MessageBox.Show("Se Grabó Correctamente", Globales.Global_MessageBox);
                                    }
                                }
                           
                                this.Close();
                        } else
                                {
                                    conf_UnidadNegocio.UnNec_vDescripcion = txtDescripcion.Text.Trim();
                                    conf_UnidadNegocio.UnNec_iCodigo = Int64.Parse(txtId.Text.Trim());
                                    conf_UnidadNegocio.UnNegoc_bActivo = ckbEstado.Checked;
                                    cantidad = Conf_UnidadNegocioDataService.GetExisteDescripcionModificar(conf_UnidadNegocio.UnNec_vDescripcion, Convert.ToInt64(txtId.Text));
                                    if (cantidad > 0)
                                    {
                                        MessageBox.Show("Existe Descripción", Globales.Global_MessageBox);
                                    }
                                    else
                                    {
                                        Conf_UnidadNegocioDataService.Update(conf_UnidadNegocio);
                                        MessageBox.Show("Se Grabó Correctamente", Globales.Global_MessageBox);
                                    }
                        
                                    conf_UnidadNegocio = null;
                                    
                                    this.Close();
                                }
                    }
                }
                else MessageBox.Show("Debe de digitar una descripción", Globales.Global_MessageBox);
            }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }
        private void OcultarElementos(bool visibl)
        {
            txtId.Visible = false;
            ckbEstado.Visible = visibl;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.ValidaLetras(e, Globales.Global_MessageBox);
        }
    }
}
