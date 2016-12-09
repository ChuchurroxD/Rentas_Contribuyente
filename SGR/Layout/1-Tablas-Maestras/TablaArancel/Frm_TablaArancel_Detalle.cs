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

namespace SGR.WinApp.Layout._1_Tablas_Maestras.TablaArancel
{
    public partial class Frm_TablaArancel_Detalle : Form
    {
        private Mant_TablaArancel mant_TablaArancel;
        Mant_TablaArancelDataService mant_TablaArancelDataService = new Mant_TablaArancelDataService();
        public Frm_TablaArancel_Detalle()
        {
            InitializeComponent();
        }
        public Frm_TablaArancel_Detalle(Mant_TablaArancel mant_TablaArancel)
        {
            InitializeComponent();
            this.mant_TablaArancel = mant_TablaArancel;
        }
        #region Metodos y Funciones
        public void limpiar()
        {
            txtDescripcion.Clear();
        }
        private bool verificarTexto()
        {
            if (txtDescripcion.Text.Trim().Length == 0 )
            {
                return false;
            }
            else
                return true;
        }
        #endregion
        private void botonGuardar_Click(object sender, EventArgs e)
        {
            Mant_TablaArancelDataService mant_ArancelTablaDataService = new Mant_TablaArancelDataService();
            Mant_TablaArancel mant_TablaArancel = new Mant_TablaArancel();
            try
            {
                if (verificarTexto())
                {
                    MessageBox.Show("¿Esta seguro que Desea Grabar?", Globales.Global_MessageBox, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    Mant_JuntaViaDataService mant_JuntaViaDataService = new Mant_JuntaViaDataService();
                    if (txtCodigoOculto.Text.Length == 0) //Es nuevo ?
                    {
                        if (mant_ArancelTablaDataService.GetExisteDescripcionNuevo(txtDescripcion.Text.Trim()) > 0)
                            throw new Exception("Nombre ya existe. No se pudo grabar.");

                        mant_TablaArancel.Descripcion = txtDescripcion.Text;
                        mant_TablaArancel.Estado = chkEstado.Checked;
                        mant_TablaArancel.registro_user_add = "UsuarioPrueba";
                        mant_ArancelTablaDataService.Insert(mant_TablaArancel);
                        MessageBox.Show("Se Registro Correctamente", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        if (mant_ArancelTablaDataService.GetExisteDescripcionModificar(Convert.ToInt32(txtCodigoOculto.Text.Trim()), txtDescripcion.Text.Trim()) > 0)
                            throw new Exception("Nombre ya existe. No se pudo grabar.");

                        mant_TablaArancel.idTablaArancel = Convert.ToInt32(txtCodigoOculto.Text.Trim());
                        mant_TablaArancel.Descripcion = txtDescripcion.Text;
                        mant_TablaArancel.Estado = chkEstado.Checked;
                        mant_TablaArancel.registro_user_update = "UsuarioPrueba";
                        mant_ArancelTablaDataService.Update(mant_TablaArancel);
                        mant_TablaArancel = null;
                        this.Close();
                        MessageBox.Show("Se Grabó Correctamente", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Falta llenar un elemento", Globales.Global_MessageBox);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Frm_TablaArancel_Detalle_Load(object sender, EventArgs e)
        {
            try
            {
                txtDescripcion.Focus();
                if (mant_TablaArancel != null)
                {
                    txtCodigoOculto.Text = mant_TablaArancel.idTablaArancel.ToString().Trim();
                    txtDescripcion.Text = mant_TablaArancel.Descripcion;
                    chkEstado.Checked = mant_TablaArancel.Estado;
                }
                else
                {
                    chkEstado.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
           

            
        }
    }
}
