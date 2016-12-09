using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGR.Core.Service;
using SGR.Entity;
using SGR.Entity.Model;

namespace SGR.WinApp.Layout._4_Procesos.Predio.Historial_PC
{
    public partial class Frm_HistorialPC_detalle : Form
    {
        private Conf_MultitablaDataService conf_MultitablaDataService = new Conf_MultitablaDataService();
        Mant_Historial mant_Historial;
        private string id;// = "1";//"002131526001";
        private int periodo; // = 2016;
        private int tipo; // = 1;//tipo 1:persona, tio2:predio


        public Frm_HistorialPC_detalle()
        {
            InitializeComponent();
        }

        public Frm_HistorialPC_detalle(Mant_Historial mant_Historial)
        {
            InitializeComponent();
            this.mant_Historial = mant_Historial;
        }

        public Frm_HistorialPC_detalle(string id, Int32 tipo)
        {
            InitializeComponent();
            this.id = id;
            this.tipo = tipo;
        }

        private void Frm_HistorialPC_detalle_Load(object sender, EventArgs e)
        {
            llenarCboMultitabla();

            if (mant_Historial != null)
            {
                txtDescripcion.Text = mant_Historial.Descripcion;
                txtExpediente.Text = mant_Historial.Expediente;
                txtObligacion.Text = mant_Historial.Obligacion;
                cboTipoOperacion.SelectedValue = mant_Historial.TipoOperacion.ToString();
                cboTipoDoc.SelectedValue = mant_Historial.tipoDocumento.ToString();
                chkActivo.Checked = mant_Historial.estado;
            }
            else
            {
                cboTipoOperacion.SelectedIndex = 1;
                chkActivo.Checked = true;
            }
        }

        private void llenarCboMultitabla()
        {
            try
            {
                cboTipoOperacion.DisplayMember = "Multc_vDescripcion";
                cboTipoOperacion.ValueMember = "Multc_cValor";
                cboTipoOperacion.DataSource = conf_MultitablaDataService.GetCboConf_Multitabla("12");
                cboTipoOperacion.SelectedIndex = 0;

                cboTipoDoc.DisplayMember = "Multc_vDescripcion";
                cboTipoDoc.ValueMember = "Multc_cValor";
                cboTipoDoc.DataSource = conf_MultitablaDataService.GetCboConf_Multitabla("135");
                cboTipoDoc.SelectedIndex = 0;


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

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Mant_HistorialDataService mant_HistoriaDataService = new Mant_HistorialDataService();
            try
            {
                if (cboTipoOperacion.SelectedIndex == -1)
                    throw new Exception("Seleccione un tipo de operación.");
                if (txtExpediente.Text.Length <= 0)
                    throw new Exception("Debe ingresar el expediente.");
                if (txtDescripcion.Text.Length <= 0 || txtObligacion.Text.Length <= 0)
                    throw new Exception("Debe ingresar al menos una descripción o una obligación.");

                if (MessageBox.Show("Desea Grabar?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (mant_Historial == null)
                    {
                        Mant_Historial mant_Historial1 = new Mant_Historial();
                        if (tipo == 1)
                            mant_Historial1.idPersona = id;
                        if (tipo == 2)
                            mant_Historial1.idPredio = id;
                        mant_Historial1.tipo = tipo;
                        mant_Historial1.Descripcion = txtDescripcion.Text;
                        mant_Historial1.Obligacion = txtObligacion.Text;
                        mant_Historial1.Expediente = txtExpediente.Text;
                        mant_Historial1.TipoOperacion = Convert.ToInt32(cboTipoOperacion.SelectedValue.ToString());
                        mant_Historial1.tipoDocumento = cboTipoDoc.SelectedValue.ToString().Trim();
                        mant_Historial1.fecha = dtpFecha.Value;
                        mant_Historial1.registro_user_add = GlobalesV1.Global_str_Usuario;
                        mant_Historial1.estado = chkActivo.Checked;
                        mant_HistoriaDataService.Insert(mant_Historial1);
                        Globales.validado = 1;
                        MessageBox.Show("Se Grabó Correctamente");
                        this.Close();
                    }
                    else
                    {
                        mant_Historial.Descripcion = txtDescripcion.Text;
                        mant_Historial.Obligacion = txtObligacion.Text;
                        mant_Historial.Expediente = txtExpediente.Text;
                        mant_Historial.TipoOperacion = Convert.ToInt32(cboTipoOperacion.SelectedValue.ToString());
                        mant_Historial.tipoDocumento = cboTipoDoc.SelectedValue.ToString().Trim();
                        mant_Historial.fecha = dtpFecha.Value;
                        mant_Historial.registro_user_update = GlobalesV1.Global_str_Usuario;
                        mant_Historial.estado = chkActivo.Checked;
                        mant_HistoriaDataService.Update(mant_Historial);
                        MessageBox.Show("Se Grabó Correctamente");
                        mant_Historial = null;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
