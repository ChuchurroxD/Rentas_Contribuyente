using SGR.Core.Service;
using SGR.Entity.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SGR.WinApp.Layout._1_Tablas_Maestras.Vias
{
    public partial class Frm_Vias_Detalle : Form
    {
        private Pred_Vias pred_Vias;
        Pred_ViasDataService pred_ViasDataService = new Pred_ViasDataService();
        public Frm_Vias_Detalle()
        {
            InitializeComponent();
            
        }

        public Frm_Vias_Detalle(Pred_Vias pred_Vias)
        {
            InitializeComponent();
            this.pred_Vias = pred_Vias;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Grabar?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Pred_ViasDataService pred_ViasDataService = new Pred_ViasDataService();
                Conf_UbicacionDataService conf_UbicacionDataService = new Conf_UbicacionDataService();
                try
                {
                    if (pred_Vias == null)
                    {
                        if (txtDescripcion.Text.Trim().Length < 0)
                            MessageBox.Show("Debe Ingresar una descripcion");
                        if (comboTipoVia.SelectedIndex == -1)
                            MessageBox.Show("Seleccione una opción");
                        if (txtDescripcion.Text.Length > 0 || comboTipoVia.SelectedIndex == 0)
                        {
                            Pred_Vias pred_Vias1 = new Pred_Vias();
                            pred_Vias1.Via_id = txtVia_id.Text;
                            pred_Vias1.Descripcion = txtDescripcion.Text;
                            pred_Vias1.TipoVia = comboTipoVia.SelectedValue.ToString();
                            pred_Vias1.Estado = chkEstado.Checked;
                            pred_Vias1.registro_user_add = "UsuarioPrueba";
                            pred_Vias1.CodigoAntiguo = txtCodigoAntiguo.Text;
                            if (conf_UbicacionDataService.GetExistUbicacionId(txtCodigoAntiguo.Text) == 0)
                            {
                                //MessageBox.Show("El Codigo Antiguo Digitado no existe", Globales.Global_MessageBox);
                                pred_ViasDataService.insertarVias(pred_Vias1);
                                MessageBox.Show("Se Registro Correctamente", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }                                
                            else
                            {
                                throw new Exception("El código ya existe.");
                            }                            
                        }
                    }
                    else
                    {
                        
                        pred_Vias.Via_id = txtVia_id.Text;
                        pred_Vias.Descripcion = txtDescripcion.Text;
                        pred_Vias.TipoVia = comboTipoVia.SelectedValue.ToString();
                        pred_Vias.Estado = chkEstado.Checked;
                        pred_Vias.registro_user_update = "UsuarioPrueba";
                        pred_Vias.CodigoAntiguo = txtCodigoAntiguo.Text;
                        //if (conf_UbicacionDataService.GetExistUbicacionId(txtCodigoAntiguo.Text) == 0)
                        //    MessageBox.Show("El Codigo Antiguo Digitado no existe", Globales.Global_MessageBox);
                        //else
                        //{
                        pred_ViasDataService.updateVias(pred_Vias);
                        pred_Vias = null;
                        this.Close();
                        //}
                        MessageBox.Show("Se Grabó Correctamente", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Globales.Global_MessageBox);
                }
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();             
        }


        private void Frm_Vias_Detalle_Load(object sender, EventArgs e)
        {
            llenarTipoVia();
            comboTipoVia.SelectedIndex = 0;
            if (pred_Vias != null)
            {
                txtVia_id.Enabled = false;
                txtVia_id.Text = pred_Vias.Via_id.Trim();
                txtDescripcion.Text = pred_Vias.Descripcion;
                comboTipoVia.SelectedValue = pred_Vias.TipoVia;
                chkEstado.Checked = pred_Vias.Estado;
                txtCodigoAntiguo.Text = pred_Vias.CodigoAntiguo;
                txtDescripcion.Focus();
            }
            else
            {
                
                chkEstado.Checked = true;
                //txtVia_id.Text = pred_ViasDataService.GetIdViaMax().ToString();
            }
        }

        #region Metodos y Funciones
        public void llenarTipoVia()
        {
            comboTipoVia.DisplayMember = "Descripcion";
            comboTipoVia.ValueMember = "valor";
            Pred_ViasDataService pred_ViasDataService = new Pred_ViasDataService();
            comboTipoVia.DataSource = pred_ViasDataService.llenarTipoVia();

        }
        public void limpiar()
        {
            txtDescripcion.Clear();
            comboTipoVia.SelectedIndex = 0;
        }

        #endregion

        private void txtVia_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten Numeros", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCodigoAntiguo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten Numeros", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
