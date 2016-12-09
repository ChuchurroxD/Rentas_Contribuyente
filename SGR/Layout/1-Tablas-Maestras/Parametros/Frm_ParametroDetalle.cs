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
using SGR.WinApp.Sistema.Globales;

namespace SGR.WinApp.Layout._1_Tablas_Maestras.Parametros
{
    public partial class Frm_ParametroDetalle : Form
    {
        private Mant_Parametros mant_Parametros;
        private Mant_ParametrosDataService Mant_ParametrosDataService = new Mant_ParametrosDataService();
        Validaciones validaciones = new Validaciones();
        private int anio;

        public Frm_ParametroDetalle(int v)
        {
            InitializeComponent();
            this.anio = v;
        }

        public Frm_ParametroDetalle(Mant_Parametros mant_Parametros)
        {
            this.mant_Parametros = mant_Parametros;
            InitializeComponent();
        }

        private void Frm_ParametroDetalle_Load(object sender, EventArgs e)
        {
            try
            {
                if(mant_Parametros != null)
                {
                    botonEditar();
                }else
                {
                    llenarcomboPeriodo();
                    cboPeriodo.SelectedValue = anio;
                    chkEstado.Checked = true;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void botonEditar()
        {
            llenarcomboDescripcion();
            bloquearDescripcionText(true);
            cboDescripcion.SelectedValue = mant_Parametros.codigo;
            llenarcomboPeriodo();
            cboPeriodo.SelectedValue = mant_Parametros.anio;
            txtValor.Text = mant_Parametros.valor.ToString();
            txtValor1.Text = mant_Parametros.valor1.ToString();
            chkEstado.Checked = mant_Parametros.estado;
            cboPeriodo.Enabled = false;
            cboDescripcion.Enabled = false;
            toolStrip1.Visible = false;
        }
        private void bloquearDescripcionText(bool estado)
        {
            txtDescripcion.Visible = !estado;
            cboDescripcion.Visible = estado;
        }
        private void llenarcomboPeriodo()
        {
            cboPeriodo.DisplayMember = "Peric_canio";
            cboPeriodo.ValueMember = "Peric_canio";
            cboPeriodo.DataSource = Mant_ParametrosDataService.llenarComboPeriodo();
        }
        private void llenarcomboDescripcion()
        {
            cboDescripcion.DisplayMember = "descripcion";
            cboDescripcion.ValueMember = "codigo";
            cboDescripcion.DataSource = Mant_ParametrosDataService.llenarComboDescripcion();
        }
        private void llenarcomboPeriodoporDescripcion()
        {
            cboPeriodo.DisplayMember = "Peric_canio";
            cboPeriodo.ValueMember = "Peric_canio";
            cboPeriodo.DataSource = Mant_ParametrosDataService.llenarComboPeriodoporDescripcion(Convert.ToInt32(cboDescripcion.SelectedValue));
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtValor.Text.Trim().Length <= 0)
                {
                    MessageBox.Show("Debe ingresar un valor", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MessageBox.Show("Desea Grabar?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if(mant_Parametros == null)
                    {
                        Mant_Parametros Mant_Parametros = new Mant_Parametros();
                        Mant_Parametros.anio = Convert.ToInt32(cboPeriodo.SelectedValue);
                        if (txtDescripcion.Text.Trim().Length > 0)
                            Mant_Parametros.descripcion = txtDescripcion.Text.TrimEnd().TrimStart();
                        else
                        {
                            Mant_Parametros.codigo = Convert.ToInt32(cboDescripcion.SelectedValue);
                            Mant_Parametros.descripcion = cboDescripcion.Text.ToString();
                        }
                        Mant_Parametros.valor = Convert.ToDecimal(txtValor.Text);

                        if (txtValor1.Text.Trim().Length > 0)
                            Mant_Parametros.valor1 = Convert.ToInt32(txtValor1.Text);
                        else
                            Mant_Parametros.valor1 = 0;
                        Mant_Parametros.estado = chkEstado.Checked;
                        Mant_Parametros.registro_fecha_add = DateTime.Now;
                        Mant_Parametros.registro_pc_add = Environment.MachineName;
                        Mant_Parametros.registro_user_add = Globales.UsuarioPrueba;
                        
                        if(Mant_Parametros.codigo <= 0)
                        {
                            if (txtDescripcion.Text.Trim().Length <= 0)
                            {
                                MessageBox.Show("Debe ingresar una descripción", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            Mant_ParametrosDataService.insertar(Mant_Parametros);
                        }else
                        {
                            Mant_ParametrosDataService.insertarv2(Mant_Parametros);
                        }

                    }else
                    {
                        mant_Parametros.codigo = Convert.ToInt32(cboDescripcion.SelectedValue);
                        mant_Parametros.anio = Convert.ToInt32(cboPeriodo.SelectedValue);
                        mant_Parametros.descripcion = cboDescripcion.Text.ToString();
                        mant_Parametros.valor = Convert.ToDecimal(txtValor.Text);
                        if (txtValor1.Text.Trim().Length > 0)
                            mant_Parametros.valor1 = Convert.ToInt32(txtValor1.Text);
                        else
                            mant_Parametros.valor1 = 0;
                        mant_Parametros.estado = chkEstado.Checked;
                        mant_Parametros.registro_fecha_update = DateTime.Now;
                        mant_Parametros.registro_pc_add = Environment.MachineName;
                        mant_Parametros.registro_user_update = Globales.UsuarioPrueba;
                        Mant_ParametrosDataService.modificar(mant_Parametros);
                    }
                    this.Dispose();
                }
                }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cboDescripcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                llenarcomboPeriodoporDescripcion();
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

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.ValidarNumeroDecimal(e,txtValor.Text, Globales.Global_MessageBox);
        }

        private void txtValor1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.validaNumeroEntero(e, Globales.Global_MessageBox);
        }

        private void toolDescripcion_Click(object sender, EventArgs e)
        {
            bloquearDescripcionText(true);
            llenarcomboDescripcion();
            llenarcomboPeriodoporDescripcion();
        }

        private void toolNuevo_Click(object sender, EventArgs e)
        {
            bloquearDescripcionText(false);
            llenarcomboPeriodo();
            cboPeriodo.SelectedValue = anio;
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
