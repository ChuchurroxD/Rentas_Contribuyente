using DgvFilterPopup;
using SGR.Core;
using SGR.Core.Service;
using SGR.Entity;
using SGR.Entity.Model;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace SGR.WinApp.Layout._1_Tablas_Maestras.FormatoValor
{
    public partial class Trib_FormatoValorDetalle : Form
    {
        Trib_FormatoValor formato_valor = new Trib_FormatoValor();
        Conf_MultitablaDataService tablas = new Conf_MultitablaDataService();
        Mant_PeriodoDataService periodo = new Mant_PeriodoDataService();
        Trib_FormatoValorDataService formatos = new Trib_FormatoValorDataService();
        int cod = 0;

        public Trib_FormatoValorDetalle()
        {
            InitializeComponent();
            t1.Controls.Clear();
            cargarCombos();
            chkEstado.Checked = true;
        }

        public Trib_FormatoValorDetalle(Trib_FormatoValor trib_Formato)
        {
            InitializeComponent();
            t1.Controls.Clear();
            formato_valor = trib_Formato;
            cargarCombos();
            txtDescripcion.Text = formato_valor.Valoc_vdescripcion;
            txtColumna3.Text = formato_valor.Valoc_vbase_legal;
            txtColumna1.Text = formato_valor.Valoc_vmot_determ;
            txtColumna2.Text = formato_valor.Valoc_vmensaje;
            txtColumna4.Text = formato_valor.Valoc_vpie_pag;
            chkEstado.Checked = formato_valor.Valoc_bactivo;
            cboPeriodo.SelectedIndexChanged -= new EventHandler(cboPeriodo_SelectedIndexChanged);
            cboPeriodo.SelectedValue = formato_valor.Valoc_ianio;
            cboPeriodo.SelectedIndexChanged += new EventHandler(cboPeriodo_SelectedIndexChanged);
            cboValores.SelectedValue = (formato_valor.Valoc_vtipodoc).Trim();
            //cboValores.SelectedValue = formato_valor.Valoc_vtipodoc;
            cod = trib_Formato.Valoc_iformato_valores_ID;
        }

        public void cargarCombos()
        {
            cboPeriodo.SelectedIndexChanged -= new EventHandler(cboPeriodo_SelectedIndexChanged);
            cboValores.SelectedIndexChanged -= new EventHandler(cboValores_SelectedIndexChanged);

            cboPeriodo.DisplayMember = "Peric_canio";
            cboPeriodo.ValueMember = "Peric_canio";
            cboPeriodo.DataSource = periodo.GetAllMant_Periodo();

            cboValores.DisplayMember = "Multc_vDescripcion";
            cboValores.ValueMember = "Multc_cValor";
            cboValores.DataSource = tablas.GetCboConf_Multitabla("51");
            cboPeriodo.SelectedIndexChanged += new EventHandler(cboPeriodo_SelectedIndexChanged);
            cboValores.SelectedIndexChanged += new EventHandler(cboValores_SelectedIndexChanged);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDescripcion.Text.Trim().Length <= 0)
                    throw new Exception("Debe llenar una descripción.");

                Trib_FormatoValor elemento = new Trib_FormatoValor();
                elemento.Valoc_vdescripcion = txtDescripcion.Text;
                elemento.Valoc_ianio = Convert.ToInt32(cboPeriodo.SelectedValue);
                elemento.Valoc_bactivo = chkEstado.Checked;
                if (txtColumna1.Text.Trim().Length > 0)
                {
                    elemento.Valoc_vmot_determ = txtColumna1.Text;
                }
                if (txtColumna2.Text.Trim().Length > 0)
                {
                    elemento.Valoc_vmensaje = txtColumna2.Text;
                }
                if (txtColumna3.Text.Trim().Length > 0)
                {
                    elemento.Valoc_vbase_legal = txtColumna3.Text;
                }
                if (txtColumna4.Text.Trim().Length > 0)
                {
                    elemento.Valoc_vpie_pag = txtColumna4.Text;
                }

                elemento.Valoc_vtipodoc = Convert.ToString(cboValores.SelectedValue);
                
                if (cod == 0)
                {
                    elemento.registro_user_add = GlobalesV1.Global_str_Usuario;
                    elemento.registro_user_update = GlobalesV1.Global_str_Usuario;
                    int respuesta = formatos.Insert(elemento);
                    if (respuesta != 0)
                    {
                        MessageBox.Show("Registro correctamente agregado", Globales.Global_MessageBox);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Error al agregar registro", Globales.Global_MessageBox);
                }
                else
                {
                    elemento.Valoc_iformato_valores_ID = formato_valor.Valoc_iformato_valores_ID;
                    elemento.registro_user_update = GlobalesV1.Global_str_Usuario;
                    formatos.Update(elemento);
                    MessageBox.Show("Registro editado correctamente", Globales.Global_MessageBox);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void cboValores_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.t1.Controls.Clear();
                var tipodoc = cboValores.SelectedValue.ToString();
                var anio = (Int32)cboPeriodo.SelectedValue;
                Trib_FormatoCampos trib_FormatoCampos = new Trib_FormatoCampos();
                Trib_FormatoCamposDataService trib_FormatoCamposDataService = new Trib_FormatoCamposDataService();
                Trib_FormatoValor trib_FormatoValor = new Trib_FormatoValor();
                List<Trib_FormatoValor> coleccion = new List<Trib_FormatoValor>();
                trib_FormatoValor = formatos.buscarByAnioByTipoValor(anio, tipodoc);

                trib_FormatoCampos = trib_FormatoCamposDataService.mostrarCampos(cboValores.SelectedValue.ToString(), (Int32)cboPeriodo.SelectedValue);
                if (trib_FormatoCampos == null)
                {
                    throw new Exception("No hay formato determinado para este tipo de formato.");
                }

                if (trib_FormatoCampos.colum1.Length > 0)
                {
                    tabPage1.Text = trib_FormatoCampos.colum1;
                    this.t1.Controls.Add(tabPage1);
                }
                if (trib_FormatoCampos.colum2.Length > 0)
                {
                    tabPage2.Text = trib_FormatoCampos.colum2;
                    this.t1.Controls.Add(tabPage2);
                }
                if (trib_FormatoCampos.colum3.Length > 0)
                {
                    tabPage3.Text = trib_FormatoCampos.colum3;
                    this.t1.Controls.Add(tabPage3);
                }
                if (trib_FormatoCampos.colum4.Length > 0)
                {
                    tabPage4.Text = trib_FormatoCampos.colum4;
                    this.t1.Controls.Add(tabPage4);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cboPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.t1.Controls.Clear();
                var tipodoc = cboValores.SelectedValue.ToString();
                var anio = (Int32)cboPeriodo.SelectedValue;
                Trib_FormatoCampos trib_FormatoCampos = new Trib_FormatoCampos();
                Trib_FormatoCamposDataService trib_FormatoCamposDataService = new Trib_FormatoCamposDataService();
                Trib_FormatoValor trib_FormatoValor = new Trib_FormatoValor();
                List<Trib_FormatoValor> coleccion = new List<Trib_FormatoValor>();
                trib_FormatoValor = formatos.buscarByAnioByTipoValor(anio, tipodoc);

                trib_FormatoCampos = trib_FormatoCamposDataService.mostrarCampos(cboValores.SelectedValue.ToString(), (Int32)cboPeriodo.SelectedValue);
                if (trib_FormatoCampos == null)
                {
                    throw new Exception("No hay formato determinado para este tipo de formato.");
                }

                if (trib_FormatoCampos.colum1.Length > 0)
                {
                    tabPage1.Text = trib_FormatoCampos.colum1;
                    this.t1.Controls.Add(tabPage1);
                }
                if (trib_FormatoCampos.colum2.Length > 0)
                {
                    tabPage2.Text = trib_FormatoCampos.colum2;
                    this.t1.Controls.Add(tabPage2);
                }
                if (trib_FormatoCampos.colum3.Length > 0)
                {
                    tabPage3.Text = trib_FormatoCampos.colum3;
                    this.t1.Controls.Add(tabPage3);
                }
                if (trib_FormatoCampos.colum4.Length > 0)
                {
                    tabPage4.Text = trib_FormatoCampos.colum4;
                    this.t1.Controls.Add(tabPage4);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
