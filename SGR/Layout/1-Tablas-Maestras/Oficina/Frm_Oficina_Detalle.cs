using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGR.Entity.Model;
using SGR.Entity;
using SGR.Core.Service;

namespace SGR.WinApp.Layout._1_Tablas_Maestras.Oficina
{
    public partial class Frm_Oficina_Detalle : Form
    {
        private Pago_Oficina Pago_Oficina;
        private Sistema.Globales.Validaciones obValidacion = new Sistema.Globales.Validaciones();
        public Frm_Oficina_Detalle()
        {
            InitializeComponent();
            txtDescripcion.MaxLength = 70;
            OcultarElementos(false);
        }
        public Frm_Oficina_Detalle(Pago_Oficina Pago_Oficina)
        {
            InitializeComponent();
            txtDescripcion.MaxLength = 70;
            this.Pago_Oficina = Pago_Oficina;
            if (Pago_Oficina != null)
            {
                txtDescripcion.Text = Pago_Oficina.Descripcion;
                txtId.Text = Pago_Oficina.oficina_id.ToString();
                ckbEstado.Checked =bool.Parse(Pago_Oficina.Estado.ToString());
                OcultarElementos(true);
            }
        }
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Pago_OficinaDataService Pago_OficinaDataService = new Pago_OficinaDataService();
            int codigo, cantidad;

            if (Cursor.Current == Cursors.WaitCursor)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (txtDescripcion.Text.Trim().Length > 0)
                    {
                    if (MessageBox.Show("Desea Grabar?", Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (Pago_Oficina == null)
                            {
                                ////dataGridView1.DataSource = Pago_OficinaDataService.GetAllSegu_Usuarios();
                    
                                    Pago_Oficina Pago_Oficina = new Pago_Oficina();
                                    Pago_Oficina.Descripcion = txtDescripcion.Text.Trim();
                                    Pago_Oficina.Estado =ckbEstado.Checked;
                                    Pago_Oficina.registro_user_add = GlobalesV1.Global_str_Usuario;//"UsuarioPrueba";
                                    cantidad = Pago_OficinaDataService.GetExisteDescripcionNuevo(Pago_Oficina.Descripcion);
                                    if (cantidad > 0)
                                    {
                                        MessageBox.Show("Existe Descripción", Globales.Global_MessageBox);
                                    }
                                    else
                                    {
                                        codigo = Pago_OficinaDataService.Insert(Pago_Oficina);
                                        if (codigo > 0)
                                        {
                                            MessageBox.Show("Se Grabó Correctamente", Globales.Global_MessageBox);
                                        }
                                    }

                                    this.Close();
                    
                            }
                            else
                            {
                                Pago_Oficina.Descripcion = txtDescripcion.Text.Trim();
                                Pago_Oficina.oficina_id = Int32.Parse(txtId.Text.Trim());
                                Pago_Oficina.Estado =ckbEstado.Checked;
                                Pago_Oficina.registro_user_update = GlobalesV1.Global_str_Usuario;// "UsuarioPrueba";
                                cantidad = Pago_OficinaDataService.GetExisteDescripcionModificar(Pago_Oficina.Descripcion, Convert.ToInt32(txtId.Text));
                                if (cantidad > 0)
                                {
                                    MessageBox.Show("Existe Descripción", Globales.Global_MessageBox);
                                }
                                else
                                {
                                    Pago_OficinaDataService.Update(Pago_Oficina);
                                    MessageBox.Show("Se Modifico Correctamente", Globales.Global_MessageBox);
                                }

                                Pago_Oficina = null;
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
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void OcultarElementos(bool visibl)
        {
            txtId.Visible = false;
            ckbEstado.Visible = visibl;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            obValidacion.ValidaLetras(e, Globales.Global_MessageBox);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
