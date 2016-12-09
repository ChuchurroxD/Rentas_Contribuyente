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

namespace SGR.WinApp.Layout._1_Tablas_Maestras.Depreciaciones
{
    public partial class Frm_DepreciacionDetalle : Form
    {
        private Mant_Depreciacion mant_Depreciacion;
        private Mant_DepreciacionDataService Mant_DepreciacionDataService = new Mant_DepreciacionDataService();

        public Frm_DepreciacionDetalle()
        {
            InitializeComponent();
        }

        public Frm_DepreciacionDetalle(Mant_Depreciacion mant_Depreciacion)
        {
            this.mant_Depreciacion = mant_Depreciacion;
            InitializeComponent();
        }
        private void llenarClasificacion()
        {
            cboClasificacion.DisplayMember = "Multc_vDescripcion";
            cboClasificacion.ValueMember = "Multc_cValor";
            cboClasificacion.DataSource = Mant_DepreciacionDataService.llenarClasificacion();
        }
        private void llenarMaterial()
        {
            cboMaterial.DisplayMember = "Multc_vDescripcion";
            cboMaterial.ValueMember = "Multc_cValor";
            cboMaterial.DataSource = Mant_DepreciacionDataService.llenarMaterial();
        }
        private void llenarEstadoPiso()
        {
            cboEstadoPiso.DisplayMember = "Multc_vDescripcion";
            cboEstadoPiso.ValueMember = "Multc_cValor";
            cboEstadoPiso.DataSource = Mant_DepreciacionDataService.llenarEstadoPiso();
        }
        private void llenarAntiguedad()
        {
            cboAntiguedad.DisplayMember = "Multc_vDescripcion";
            cboAntiguedad.ValueMember = "Multc_cValor";
            cboAntiguedad.DataSource = Mant_DepreciacionDataService.llenarAntiguedad();
        }
        private void llenarPeriodo()
        {
            cboAnio.DisplayMember = "Peric_canio";
            cboAnio.ValueMember = "Peric_canio";
            cboAnio.DataSource = Mant_DepreciacionDataService.llenarPeriodo();
        }
        private void Frm_DepreciacionDetalle_Load(object sender, EventArgs e)
        {
            try
            {
                llenarClasificacion();
                llenarEstadoPiso();
                llenarMaterial();
                llenarAntiguedad();
                llenarPeriodo();
                if(mant_Depreciacion != null)
                {
                    cboAnio.SelectedValue = Convert.ToInt32(mant_Depreciacion.anio);
                    cboClasificacion.SelectedValue = mant_Depreciacion.clasificacion.ToString();
                    cboAntiguedad.SelectedValue = mant_Depreciacion.antiguedad.ToString();
                    cboMaterial.SelectedValue = mant_Depreciacion.material.ToString();
                    cboEstadoPiso.SelectedValue = mant_Depreciacion.estado_piso.ToString();
                    txtPorcentaje.Text = Convert.ToString(mant_Depreciacion.porcentaje);
                    chkEstado.Checked = mant_Depreciacion.estado;
                }else
                {
                    chkEstado.Checked = true;
                    cboAnio.SelectedValue = 2016;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ValidarNumero(KeyPressEventArgs e, String txt)
        {
            decimal Dft = 0;
            string Comprobar = txt + e.KeyChar.ToString();
            bool EsNumerico = decimal.TryParse(Comprobar, out Dft);
            if (((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 44 && (e.KeyChar != (char)Keys.Back)) || (!EsNumerico && e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números decimales validos", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPorcentaje.Text.Trim().Length <= 0)
                {
                    MessageBox.Show("Debe ingresar un Porcentaje", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (MessageBox.Show("Desea Grabar?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string comboAntiguedad = cboAntiguedad.Text.ToString();
                    if (mant_Depreciacion == null)
                    {
                        Mant_Depreciacion Mant_Depreciacion = new Mant_Depreciacion();
                        Mant_Depreciacion.anio = Int16.Parse(cboAnio.SelectedValue.ToString());
                        Mant_Depreciacion.clasificacion = Convert.ToInt16(cboClasificacion.SelectedValue);
                        Mant_Depreciacion.antiguedad = cboAntiguedad.SelectedValue.ToString();
                        
                        int firstCharacter = cboAntiguedad.Text.ToString().IndexOf("-");
                        Mant_Depreciacion.anti_final = Convert.ToInt16(comboAntiguedad.Substring(firstCharacter + 1));
                        Mant_Depreciacion.anti_inicial = Convert.ToInt16(comboAntiguedad.Substring(0, comboAntiguedad.Length - (Mant_Depreciacion.anti_final.ToString().Length + 1)));
                        Mant_Depreciacion.material = Convert.ToInt16(cboMaterial.SelectedValue);
                        Mant_Depreciacion.estado_piso = Convert.ToInt16(cboEstadoPiso.SelectedValue);
                        Mant_Depreciacion.porcentaje = Convert.ToDecimal(txtPorcentaje.Text);
                        Mant_Depreciacion.estado = chkEstado.Checked;
                        Mant_Depreciacion.registro_user_add = GlobalesV1.Global_str_Usuario;
                        Mant_Depreciacion.registro_user_update = GlobalesV1.Global_str_Usuario;
                        Mant_DepreciacionDataService.insert(Mant_Depreciacion);
                    }else
                    {
                        mant_Depreciacion.anio = Int16.Parse(cboAnio.SelectedValue.ToString());
                        mant_Depreciacion.clasificacion = Convert.ToInt16(cboClasificacion.SelectedValue);
                        mant_Depreciacion.antiguedad = cboAntiguedad.SelectedValue.ToString();
                       
                        int firstCharacter = comboAntiguedad.IndexOf("-");
                        mant_Depreciacion.anti_final = Convert.ToInt16(comboAntiguedad.Substring(firstCharacter+1));
                        mant_Depreciacion.anti_inicial = Convert.ToInt16(comboAntiguedad.Substring(0,comboAntiguedad.Length - (mant_Depreciacion.anti_final.ToString().Length+1)));
                      
                        mant_Depreciacion.material = Convert.ToInt16(cboMaterial.SelectedValue);
                        mant_Depreciacion.estado_piso = Convert.ToInt16(cboEstadoPiso.SelectedValue);
                        mant_Depreciacion.porcentaje = Convert.ToDecimal(txtPorcentaje.Text);
                        mant_Depreciacion.estado = chkEstado.Checked;
                        mant_Depreciacion.registro_user_update = GlobalesV1.Global_str_Usuario;
                        Mant_DepreciacionDataService.update(mant_Depreciacion);
                    }
                    this.Dispose();
                    }
                }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void txtPorcentaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumero(e, txtPorcentaje.Text);
        }
    }
}
