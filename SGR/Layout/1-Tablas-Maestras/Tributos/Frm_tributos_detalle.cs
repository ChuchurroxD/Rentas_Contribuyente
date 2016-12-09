using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGR.Core.Service;
using SGR.Entity.Model;

namespace SGR.WinApp.Layout._1_Tablas_Maestras.Tributos
{
    public partial class Frm_tributos_detalle : Form
    {
        private Pred_Tributo pred_Tributo;
        private Int32 periodo;
        private Pred_TributoDataService Pred_TributoDataService = new Pred_TributoDataService();
        Orga_AreaDataService area = new Orga_AreaDataService();

        public Frm_tributos_detalle()
        {
            InitializeComponent();
            llenarTipoTributo();
            llenarPeriodo();
            LoadAreasByModulo();
            chkEstado.Checked = true;
            cboPeriodo.SelectedValue = 2013;
        }

        public Frm_tributos_detalle(Pred_Tributo pred_Tributo,Int32 periodo)
        {
            this.pred_Tributo = pred_Tributo;
            this.periodo = periodo;
            InitializeComponent();
            try
            {
                llenarTipoTributo();
                llenarPeriodo();
                cboTipoTributo.SelectedIndex = 0;
                LoadAreasByModulo();
                if (pred_Tributo != null)
                {
                    txtCodigo.Text = pred_Tributo.tributos_ID;
                    txtDescripcion.Text = pred_Tributo.descripcion;
                    txtImporte.Text = Convert.ToString(pred_Tributo.importe);
                    txtAbreviatura.Text = pred_Tributo.abrev;
                    cboTipoTributo.SelectedValue = pred_Tributo.tipo_tributo.Trim();
                    txtPorcentajeUIT.Text = Convert.ToString(pred_Tributo.porce_uit);

                    cboPeriodo.SelectedValue = periodo;
                    llenarClasificadorIngresos();

                    cboClasificacionIngresos.SelectedValue = pred_Tributo.clai_codigo;
                    chkEstado.Checked = pred_Tributo.activo;
                    txtPorcentajeArea.Text = Convert.ToString(pred_Tributo.porce_area);

                    cboArea1.SelectedValue = pred_Tributo.are_codigo.Substring(0, 2);
                    cboArea2.SelectedValue = pred_Tributo.are_codigo;
                    if (pred_Tributo.cobro_interes == 1)
                        chkCobroIntereses.Checked = true;
                    else
                        chkCobroIntereses.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void LoadAreasByModulo()
        {
            try
            {
                List<Orga_Area> menus = new List<Orga_Area>();
                menus = area.listarHijos("");
                cboArea1.DisplayMember = "Areac_vDescripcion";
                cboArea1.ValueMember = "Areac_vCodigo";
                cboArea1.DataSource = menus;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void llenarAreaporModulo2()
        {
            try
            {
                cboArea2.DisplayMember = "Areac_vDescripcion";
                cboArea2.ValueMember = "Areac_vCodigo";
                cboArea2.DataSource = area.listarHijos(cboArea1.SelectedValue.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void llenarTipoTributo()
        {
            try
            {
                cboTipoTributo.DisplayMember = "Multc_vDescripcion";
                cboTipoTributo.ValueMember = "Multc_cValor";
                cboTipoTributo.DataSource = Pred_TributoDataService.llenarcomboTipoTributo();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void llenarPeriodo()
        {
            try
            {
                cboPeriodo.DisplayMember = "Peric_canio";
                cboPeriodo.ValueMember = "Peric_canio";
                cboPeriodo.DataSource = Pred_TributoDataService.llenarPeriodo();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void llenarClasificadorIngresos()
        {
            try
            {
                cboClasificacionIngresos.DisplayMember = "Tribc_vDescripcion";
                cboClasificacionIngresos.ValueMember = "Tribc_vCodigo";
                cboClasificacionIngresos.DataSource = Pred_TributoDataService.llenarcomboClasificadorIngresos(Convert.ToString(cboPeriodo.SelectedValue));
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
            if (((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 46 && (e.KeyChar != (char)Keys.Back)) || (!EsNumerico && e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números decimales validos", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cboPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                llenarClasificadorIngresos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Pred_TributoDataService Pred_TributoDataService = new Pred_TributoDataService();
            try
            {
                if (txtCodigo.Text.Trim().Length <= 0)
                {
                    MessageBox.Show("Debe ingresar un código", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtDescripcion.Text.Trim().Length <= 0)
                {
                    MessageBox.Show("Debe ingresar una descripción", Globales.Global_MessageBox,MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return;
                }
                if (txtImporte.Text.Trim().Length <= 0)
                {
                    MessageBox.Show("Debe ingresar un importe", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if(txtPorcentajeArea.Text.Trim().Length <= 0)
                {
                    MessageBox.Show("Debe ingresar un Porcentaje Area", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if(txtPorcentajeUIT.Text.Trim().Length <= 0)
                {
                    MessageBox.Show("Debe ingresar un Pocentaje UIT", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MessageBox.Show("Desea Grabar?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (pred_Tributo == null)
                    {
                    
                        Pred_Tributo pred_Tributo = new Pred_Tributo();
                        pred_Tributo.tributos_ID = txtCodigo.Text.Trim();
                        pred_Tributo.descripcion = txtDescripcion.Text.Trim();
                        pred_Tributo.importe = Convert.ToDecimal(txtImporte.Text.Trim());
                        pred_Tributo.activo = chkEstado.Checked;
                        pred_Tributo.abrev = txtAbreviatura.Text.Trim();
                        pred_Tributo.tipo_tributo = cboTipoTributo.SelectedValue.ToString();
                        pred_Tributo.porce_uit = Convert.ToDecimal(txtPorcentajeUIT.Text.Trim());
                        pred_Tributo.clai_codigo = cboClasificacionIngresos.SelectedValue.ToString();
                        pred_Tributo.cod_contable = "";
                        pred_Tributo.are_codigo = cboArea2.SelectedValue.ToString();
                        pred_Tributo.porce_area = Convert.ToDecimal(txtPorcentajeArea.Text.Trim());
                        pred_Tributo.fuente = "";
                        if (chkCobroIntereses.Checked)
                            pred_Tributo.cobro_interes = 1;
                        else
                            pred_Tributo.cobro_interes = 0;
                        Pred_TributoDataService.insertarTributo(pred_Tributo);
                        this.Close();
                    }
                    else
                    {
                        pred_Tributo.tributos_ID = txtCodigo.Text.Trim();
                        pred_Tributo.descripcion = txtDescripcion.Text.Trim();
                        pred_Tributo.importe = Convert.ToDecimal(txtImporte.Text.Trim());
                        pred_Tributo.activo = chkEstado.Checked;
                        pred_Tributo.abrev = txtAbreviatura.Text.Trim();
                        pred_Tributo.tipo_tributo = cboTipoTributo.SelectedValue.ToString();
                        pred_Tributo.porce_uit = Convert.ToDecimal(txtPorcentajeUIT.Text.Trim());
                        pred_Tributo.clai_codigo = cboClasificacionIngresos.SelectedValue.ToString();
                        pred_Tributo.cod_contable = "";
                        pred_Tributo.are_codigo = cboArea2.SelectedValue.ToString();
                        pred_Tributo.porce_area = Convert.ToDecimal(txtPorcentajeArea.Text.Trim());
                        pred_Tributo.fuente = "";
                        if (chkCobroIntereses.Checked)
                            pred_Tributo.cobro_interes = 1;
                        else
                            pred_Tributo.cobro_interes = 0;
                        Pred_TributoDataService.modificarTributo(pred_Tributo);
                        pred_Tributo = null;
                        this.Close();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cboArea1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                llenarAreaporModulo2();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumero(e, txtImporte.Text);

        }

        private void txtPorcentajeUIT_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumero(e, txtPorcentajeUIT.Text);
        }

        private void txtPorcentajeArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumero(e, txtPorcentajeArea.Text);
        }

        private void txtAbreviatura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && e.KeyChar != 46 && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void Frm_tributos_detalle_Load(object sender, EventArgs e)
        {

        }
    }
}
