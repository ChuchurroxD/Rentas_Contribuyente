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
using SGR.WinApp.Sistema.Globales;

namespace SGR.WinApp.Layout._1_Tablas_Maestras.ArancelRustico
{
    
    public partial class Frm_AranceRustico_Detalle : Form
    {

        Mant_PeriodoDataService mant_PeriodoDataService = new Mant_PeriodoDataService();
        Conf_MultitablaDataService conf_MultitablaDataService = new Conf_MultitablaDataService();
        Mant_ArancelRusticoDataService mant_ArancelRusticoDataService = new Mant_ArancelRusticoDataService();
        private Mant_ArancelRustico mant_ArancelRustico;
        Validaciones validaciones = new Validaciones();
        public Frm_AranceRustico_Detalle()
        {
            InitializeComponent();
        }

        public Frm_AranceRustico_Detalle(Mant_ArancelRustico mant_ArancelRustico)
        {
            InitializeComponent();
            this.mant_ArancelRustico = mant_ArancelRustico;
        }

        #region Metodos y Funciones
        private bool VerificarCombos()
        {
            if (comboCategoriaRustico.SelectedIndex == -1 || 
                comboGrupoRustico.SelectedIndex == -1 || 
                comboPeriodo.SelectedIndex == -1)
                return false;
            else
                return true;
        }
        private bool verificarTexto()
        {
            if (txtValorRustico.Text.Trim().Length == 0)
            {
                return false;
            }
            else
                return true;
        }

        private bool verificarDiferenteCeroInsertar()
        {
            Boolean control = true;

            if (txtValorRustico.Text == "0")
            {
                MessageBox.Show("No se Permite Valor Cero. Ingrese Valor valido", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                control = false;
            }

            return control;
        }

        private bool verificarDiferenteCero()
        {
            Boolean control = true;

            if (txtValorRustico.Text == "0.00")
            {
                MessageBox.Show("No se Permite Valor Cero. Ingrese Valor valido", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                control = false;
            }

            return control;
        }
        private void llenarcomboPeriodo()
        {
            try
            {
                comboPeriodo.DisplayMember = "Peric_canio";
                comboPeriodo.ValueMember = "Peric_canio";
                comboPeriodo.DataSource = mant_PeriodoDataService.llenarPeriodo();
                comboPeriodo.SelectedValue = 2016;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void llenarComboCategoria()
        {
            try {
                comboCategoriaRustico.DisplayMember = "Multc_vDescripcion";
                comboCategoriaRustico.ValueMember = "Multc_cValor";
                comboCategoriaRustico.DataSource = mant_ArancelRusticoDataService.llenarComboCategoriaRustico();
            } catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void llenarComboGrupo()
        {
            try
            {
                comboGrupoRustico.DisplayMember = "Multc_vDescripcion";
                comboGrupoRustico.ValueMember = "Multc_cValor";
                comboGrupoRustico.DataSource = mant_ArancelRusticoDataService.llenarComboGrupoRustico();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        
        #endregion

        private void botonGrabar_Click(object sender, EventArgs e)
        {
            Mant_ArancelRusticoDataService mant_ArancelRusticoDataService = new Mant_ArancelRusticoDataService();
            Mant_ArancelRustico mant_ArancelRustico = new Mant_ArancelRustico();
            try
            {
                if (VerificarCombos() && verificarTexto() && verificarDiferenteCero() && verificarDiferenteCeroInsertar())
                {
                    MessageBox.Show("¿Esta seguro que Desea Grabar?", Globales.Global_MessageBox, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (txtArancelRustico_idOculto.Text.Length == 0)
                        {
                        mant_ArancelRustico.idPeriodo = int.Parse(comboPeriodo.Text);
                        mant_ArancelRustico.ValorRustico = Decimal.Parse(txtValorRustico.Text.Trim());
                        mant_ArancelRustico.Categoria_Rustico = int.Parse(comboCategoriaRustico.SelectedValue.ToString());
                        mant_ArancelRustico.idGrupoRustico = int.Parse(comboGrupoRustico.SelectedValue.ToString());
                        mant_ArancelRustico.activo = chkEstado.Checked;
                        mant_ArancelRustico.registro_user_add = GlobalesV1.Global_str_Usuario;
                        mant_ArancelRusticoDataService.insertarArancelRustico(mant_ArancelRustico);
                        MessageBox.Show("Se Registro Correctamente", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        Mant_ArancelRustico mant_ArancelRustico1 = new Mant_ArancelRustico();
                        mant_ArancelRustico1.ArancelRustico_id = int.Parse(txtArancelRustico_idOculto.Text);
                        mant_ArancelRustico1.idPeriodo = int.Parse(comboPeriodo.SelectedValue.ToString());
                        mant_ArancelRustico1.idGrupoRustico = int.Parse(comboGrupoRustico.SelectedValue.ToString());
                        mant_ArancelRustico1.Categoria_Rustico = int.Parse(comboCategoriaRustico.SelectedValue.ToString());
                        mant_ArancelRustico1.ValorRustico = decimal.Parse(txtValorRustico.Text);
                        mant_ArancelRustico1.activo = chkEstado.Checked;
                        mant_ArancelRustico1.registro_user_update = GlobalesV1.Global_str_Usuario;
                        mant_ArancelRusticoDataService.updateArancelRustico(mant_ArancelRustico1);
                        mant_ArancelRustico1 = null;
                        MessageBox.Show("Se Modificó Correctamente", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else{
                    MessageBox.Show("Ingresar Datos",Globales.Global_MessageBox,MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registro Existente", Globales.Global_MessageBox);
            }
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Frm_AranceRustico_Detalle_Load(object sender, EventArgs e)
        {
            try
            {
                llenarComboCategoria();
                llenarComboGrupo();
                llenarcomboPeriodo();
                if (mant_ArancelRustico != null)
                {
                    txtArancelRustico_idOculto.Text = mant_ArancelRustico.ArancelRustico_id.ToString();
                    txtValorRustico.Text = mant_ArancelRustico.ValorRustico.ToString();
                    comboPeriodo.Text = mant_ArancelRustico.idPeriodo.ToString();
                    comboGrupoRustico.Text = mant_ArancelRustico.GrupoRusticoDescripcion;
                    comboCategoriaRustico.Text = mant_ArancelRustico.Categoria_RusticoDescripcion;
                    chkEstado.Checked = mant_ArancelRustico.activo;
                }
                else
                {
                    comboPeriodo.SelectedValue = 2016;
                    chkEstado.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void txtValorRustico_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.ValidarNumeroDecimal(e, txtValorRustico.Text, "Ingresar Valor Valido");
        }
    }
}
