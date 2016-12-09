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

namespace SGR.WinApp.Layout._1_Tablas_Maestras.Arancel
{
    

    public partial class Frm_Arancel_Detalle : Form
    {
        Conf_UbicacionDataService conf_UbicacionDataService = new Conf_UbicacionDataService();
        private Mant_Arancel mant_Arancel;
        Pred_ViasDataService pred_ViasDataService = new Pred_ViasDataService();
        Pred_SectorDataService pred_SectorDataService = new Pred_SectorDataService();
        Mant_ArancelDataService mant_ArancelDataService = new Mant_ArancelDataService();
        Mant_PeriodoDataService mant_PeriodoDataService = new Mant_PeriodoDataService();
        Validaciones validaciones = new Validaciones();

        public Frm_Arancel_Detalle()
        {
            InitializeComponent();
        }

        public Frm_Arancel_Detalle(Mant_Arancel mant_Arancel)
        {
            InitializeComponent();
            this.mant_Arancel = mant_Arancel;
        }
        #region Metodos y Funciones
        private bool VerificarCombos()
        {
            if ( comboCalle.SelectedIndex == -1 || comboSector.SelectedIndex == -1 || comboAnio.SelectedIndex == -1)
                return false;
            else
                return true;
        }
        private void llenarcomboaño()
        {
            try
            {
                comboAnio.DisplayMember = "Peric_canio";
                comboAnio.ValueMember = "Peric_canio";
                comboAnio.DataSource = mant_PeriodoDataService.llenarPeriodo();
                comboAnio.SelectedValue = "2016";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void llenarcomboSector()
        {
            try
            {
                comboSector.ValueMember = "sector_id";
                comboSector.DisplayMember = "descripcion";
                comboSector.DataSource = pred_SectorDataService.listarSectorCbo();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void llenarcomboViaCalle()
        {
            try
            {
                comboCalle.ValueMember = "Via_Id";
                comboCalle.DisplayMember = "Descripcion";
                comboCalle.DataSource = pred_ViasDataService.listarViasPorSector(comboSector.SelectedValue.ToString(), GlobalesV1.Global_int_idoficina);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }
        private bool verificarTexto()
        {
            if (txtMontoArancel.Text.Trim().Length == 0 || txtCuadra.Text.Trim().Length == 0 || txtLado.Text.Trim().Length==0)
            {
                    return false;
            }
            else
                return true;
        }

        #endregion       

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Mant_ArancelDataService mant_ArancelDataService = new Mant_ArancelDataService();
            Mant_Arancel mant_Arancel = new Mant_Arancel();
            try
            {
                if (VerificarCombos() && verificarTexto())
                {
                    MessageBox.Show("¿Esta seguro que Desea Grabar?", Globales.Global_MessageBox, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    Mant_JuntaViaDataService mant_JuntaViaDataService = new Mant_JuntaViaDataService();
                    int junta_via = mant_JuntaViaDataService.GetJuntaVia_id(int.Parse(comboSector.SelectedValue.ToString()), int.Parse(comboCalle.SelectedValue.ToString()));
                    if (txtIDoculto.Text.Length == 0) //Es nuevo ?
                    {
                        if (mant_ArancelDataService.GetExisteArancelNuevo(int.Parse(comboAnio.Text), int.Parse(txtCuadra.Text), int.Parse(txtLado.Text), int.Parse(comboSector.SelectedValue.ToString()), comboCalle.SelectedValue.ToString()) > 0)
                            throw new Exception("Arancel ya existe. No se pudo grabar.");

                            mant_Arancel.anio = int.Parse(comboAnio.Text);
                            mant_Arancel.arancel_monto = Decimal.Parse(txtMontoArancel.Text.Trim());
                            mant_Arancel.junta_via_ID = junta_via;
                            mant_Arancel.activo = chkActivo.Checked;
                            mant_Arancel.registro_user_add = GlobalesV1.Global_str_Usuario;
                            mant_Arancel.cuadra = int.Parse(txtCuadra.Text);
                            mant_Arancel.lado = int.Parse(txtLado.Text);                        
                            mant_ArancelDataService.insertarArancel(mant_Arancel);
                            MessageBox.Show("Se Registro Correctamente", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                    }
                    else
                    {
                        if (mant_ArancelDataService.GetExisteArancelModificar(int.Parse(comboAnio.Text), int.Parse(txtCuadra.Text), int.Parse(txtLado.Text), int.Parse(comboSector.SelectedValue.ToString()), comboCalle.SelectedValue.ToString(), int.Parse(txtIDoculto.Text)) > 0)
                            throw new Exception("Arancel ya existe. No se pudo grabar.");

                        mant_Arancel.arancel_ID = int.Parse(txtIDoculto.Text);
                        mant_Arancel.anio = int.Parse(comboAnio.SelectedValue.ToString());
                        mant_Arancel.arancel_monto = decimal.Parse(txtMontoArancel.Text);
                        mant_Arancel.junta_via_ID = junta_via;
                        mant_Arancel.cuadra = int.Parse(txtCuadra.Text.Trim());
                        mant_Arancel.lado = int.Parse(txtLado.Text.Trim());
                        mant_Arancel.activo = chkActivo.Checked;
                        mant_Arancel.registro_user_update = GlobalesV1.Global_str_Usuario;
                        mant_ArancelDataService.updateArancel(mant_Arancel);
                        mant_Arancel = null;
                        MessageBox.Show("Se Grabó Correctamente", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Falta llenar un elemento", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Frm_Arancel_Detalle_Load(object sender, EventArgs e)
        {
            try
            {
                llenarcomboaño();
                llenarcomboSector();

                if (mant_Arancel != null)
                {
                    txtIDoculto.Text = mant_Arancel.arancel_ID.ToString();
                    txtMontoArancel.Text = mant_Arancel.arancel_monto.ToString();
                    txtCuadra.Text = mant_Arancel.cuadra.ToString();
                    txtLado.Text = mant_Arancel.lado.ToString();
                    comboAnio.Text = mant_Arancel.anio.ToString();
                    comboSector.Text = mant_Arancel.SectorDescripcion;
                    llenarcomboViaCalle();
                    comboCalle.Text = mant_Arancel.ViaDescripcion;
                    chkActivo.Checked = mant_Arancel.activo;
                }
                else
                {
                    chkActivo.Checked = true;
                    comboAnio.SelectedValue = 2016;
                    llenarcomboViaCalle();
                    txtCuadra.Text = 0.ToString();
                    txtLado.Text = 0.ToString();
                    
                }
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

        private void comboSector_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarcomboViaCalle();
        }

        private void txtMontoArancel_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            validaciones.ValidarNumeroDecimal(e, txtMontoArancel.Text, "Monto no Valido");
        }

        private void txtCuadra_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.validaNumeroEntero(e, txtCuadra.Text);
        }

        private void Frm_Arancel_Detalle_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtLado_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.validaNumeroEntero(e, txtLado.Text);
        }
    }
}
