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

namespace SGR.WinApp.Layout._1_Tablas_Maestras.FormatoCampos
{
    public partial class Frm_FormatoCamposDetalle : Form
    {
        private Trib_FormatoCampos trib_FormatoCampos;
        private Pred_TributoDataService pred_TributoDataService = new Pred_TributoDataService();
        Trib_FormatoCamposDataService trib_FormatoCamposDataService = new Trib_FormatoCamposDataService();

        public Frm_FormatoCamposDetalle()
        {
            InitializeComponent();
        }

        public Frm_FormatoCamposDetalle(Trib_FormatoCampos trib_FormatoCampos)
        {
            InitializeComponent();
            this.trib_FormatoCampos = trib_FormatoCampos;
        }

        private void Frm_FormatoCamposDetalle_Load(object sender, EventArgs e)
        {
            llenarTipoFormato();
            llenarPeriodo();
            txtColumna2.Enabled = false;
            txtColumna3.Enabled = false;
            txtColumna4.Enabled = false;
            txtColumna2.Text = "";
            txtColumna3.Text = "";
            txtColumna4.Text = "";
            if (trib_FormatoCampos != null)
            {
                cboPeriodo.SelectedValue = trib_FormatoCampos.anio;
                cboTipoFormato.SelectedValue = trib_FormatoCampos.tipo_formato_id;
                txtColumna1.Text = trib_FormatoCampos.colum1;
                txtColumna2.Text = trib_FormatoCampos.colum2;
                txtColumna3.Text = trib_FormatoCampos.colum3;
                txtColumna4.Text = trib_FormatoCampos.colum4;
                txtColumna1_Validated(sender, EventArgs.Empty);
                txtColumna2_Validated(sender, EventArgs.Empty);
                txtColumna3_Validated(sender, EventArgs.Empty);
            }
        }

        private void llenarPeriodo()
        {
            try
            {
                cboPeriodo.DisplayMember = "Peric_canio";
                cboPeriodo.ValueMember = "Peric_canio";
                cboPeriodo.DataSource = pred_TributoDataService.llenarPeriodo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void llenarTipoFormato()
        {
            try
            {
                var coleccion = new List<Trib_TipoFormato>();
                coleccion = trib_FormatoCamposDataService.llenarComboTipoformato();
                cboTipoFormato.DisplayMember = "descripcion";
                cboTipoFormato.ValueMember = "valor";
                cboTipoFormato.DataSource = coleccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtColumna1.Text.Trim().Length <= 0)
                    throw new Exception("Debe ingresar el nombre de almenos una columna.");

                if (MessageBox.Show("Desea Grabar?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (trib_FormatoCampos == null)
                    {
                        if (trib_FormatoCamposDataService.GetExisteFormatoCampoNuevo(cboTipoFormato.SelectedValue.ToString(), (Int32)cboPeriodo.SelectedValue) > 0)
                            throw new Exception("Ya existe formato para este periodo.");

                        Trib_FormatoCampos trib_FormatoCampos1 = new Trib_FormatoCampos();
                        trib_FormatoCampos1.tipo_formato_id = cboTipoFormato.SelectedValue.ToString();
                        trib_FormatoCampos1.anio = (Int32)cboPeriodo.SelectedValue;
                        trib_FormatoCampos1.colum1 = txtColumna1.Text.Trim();
                        trib_FormatoCampos1.colum2 = txtColumna2.Text.Trim();
                        trib_FormatoCampos1.colum3 = txtColumna3.Text.Trim();
                        trib_FormatoCampos1.colum4 = txtColumna4.Text.Trim();
                        trib_FormatoCampos1.registro_user_add = GlobalesV1.Global_str_Usuario;
                        trib_FormatoCampos1.registro_user_update = GlobalesV1.Global_str_Usuario;

                        trib_FormatoCamposDataService.Insert(trib_FormatoCampos1);
                        MessageBox.Show("Se Grabó Correctamente");
                        this.Close();
                    }
                    else
                    {
                        if (trib_FormatoCamposDataService.GetExisteFormatoCampoModificar(trib_FormatoCampos.id, cboTipoFormato.SelectedValue.ToString(), (Int32)cboPeriodo.SelectedValue) > 0)
                            throw new Exception("Ya existe formato para este periodo.");

                        trib_FormatoCampos.tipo_formato_id = cboTipoFormato.SelectedValue.ToString();
                        trib_FormatoCampos.anio = (Int32)cboPeriodo.SelectedValue;
                        trib_FormatoCampos.colum1 = txtColumna1.Text.Trim();
                        trib_FormatoCampos.colum2 = txtColumna2.Text.Trim();
                        trib_FormatoCampos.colum3 = txtColumna3.Text.Trim();
                        trib_FormatoCampos.colum4 = txtColumna4.Text.Trim();
                        trib_FormatoCampos.registro_user_update = GlobalesV1.Global_str_Usuario;

                        trib_FormatoCamposDataService.Update(trib_FormatoCampos);
                        MessageBox.Show("Se Grabó Correctamente");
                        trib_FormatoCampos = null;
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

        private void txtColumna1_Validated(object sender, EventArgs e)
        {
            if (txtColumna1.Text.Trim().Length > 0)
                txtColumna2.Enabled = true;
            else
                txtColumna2.Enabled = false;
        }

        private void txtColumna2_Validated(object sender, EventArgs e)
        {
            if (txtColumna2.Text.Trim().Length > 0)
                txtColumna3.Enabled = true;
            else
                txtColumna3.Enabled = false;
        }

        private void txtColumna3_Validated(object sender, EventArgs e)
        {
            if (txtColumna3.Text.Trim().Length > 0)
                txtColumna4.Enabled = true;
            else
                txtColumna4.Enabled = false;
        }

        private void txtColumna4_Validated(object sender, EventArgs e)
        {
            if (txtColumna4.Text.Trim().Length == 0)
            {
                txtColumna4.Enabled = false;
            }
        }

        private void cboTipoFormato_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cboTipoFormato.SelectedValue + "DSADSA");
        }
    }
}

