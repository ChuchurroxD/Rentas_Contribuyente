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
using SGR.Core.Service.Combos;
using SGR.Entity.Model.Combos;
namespace SGR.WinApp.Layout._4_Procesos.Predio.Adeudo
{
    public partial class Frm_ConstanciaAdeudoDetalle : Form
    {
        private Pred_ConstanciaNoDebeDataService ConstanciaNoDebeDataService = new Pred_ConstanciaNoDebeDataService();
        private Pago_PersonaDataService persona = new Pago_PersonaDataService();

        public Frm_ConstanciaAdeudoDetalle(Pred_ConstanciaNoDebe Pred_ConstanciaNo)
        {
            InitializeComponent();
            //txtAño.Text=Pred_ConstanciaNo.idPeriodo.ToString() ;
            txtBusqueda.Text = Pred_ConstanciaNo.Persona;
            txtImpuestoImporte.Text = Pred_ConstanciaNo.ImpuestoImporte.ToString();
            txtImpuestoRecibo.Text = Pred_ConstanciaNo.ImpuestoRecibo.ToString();
            txtTramiteImporte.Text = Pred_ConstanciaNo.TramiteImporte.ToString();
            txtTramiteRecibo.Text = Pred_ConstanciaNo.TramiteRecibo;
            txtObligacion.Text = Pred_ConstanciaNo.Obligacion;
            txtDescripcion.Text = Pred_ConstanciaNo.Descripcion;
            txtExpediente.Text = Pred_ConstanciaNo.Expediente;
            txtId.Text = Pred_ConstanciaNo.idConstancia.ToString();
            ckbEstado.Checked = Pred_ConstanciaNo.estado;
            txtObligacion.MaxLength = 995;
            txtDescripcion.MaxLength = 995;
        }

        //public Frm_ConstanciaAdeudoDetalle()
        //{
        //    InitializeComponent();
        //}

        private string verificar(string dato)
        {
            ////lblAño.ForeColor = System.Drawing.Color.Black;
            lblContribuyente.ForeColor = System.Drawing.Color.Black;
            lblExpediente.ForeColor = System.Drawing.Color.Black;
            //lblTransferencia.ForeColor = System.Drawing.Color.Black;
            //if (txtAño.Text.Trim().Length == 0)
            //{
            //    dato = dato + "Año, ";
            //    lblAño.ForeColor = System.Drawing.Color.Red;
            //}
            //if (cboPersona.SelectedIndex==-1)
            //{
            //    dato = dato + "Contribuyente, ";
            //    lblContribuyente.ForeColor = System.Drawing.Color.Red;
            //}
            if (txtExpediente.Text.Trim().Length == 0)
            {
                dato = dato + "Expediente";
                lblExpediente.ForeColor = System.Drawing.Color.Red;
            }
            //if (txtTransferencia.Text.Trim().Length == 0)
            //{
            //    dato = dato + "Transferencia, ";
            //    lblTransferencia.ForeColor = System.Drawing.Color.Red;
            //}
            if (txtTramiteImporte.Text.Trim().Length == 0)
            {
                dato = dato + "Importe de trámite, ";
                lblTramiteImporte.ForeColor = System.Drawing.Color.Red;
            }
            if (txtTramiteRecibo.Text.Trim().Length == 0)
            {
                dato = dato + "Recibo de trámite, ";
                lblTramiteRecibo.ForeColor = System.Drawing.Color.Red;
            }
            if (txtImpuestoImporte.Text.Trim().Length == 0)
            {
                dato = dato + "Importe de Impuesto, ";
                lblImpuestoImporte.ForeColor = System.Drawing.Color.Red;
            }
            if (txtImpuestoRecibo.Text.Trim().Length == 0)
            {
                dato = dato + "Recibo de Impuesto ";
                lblImpuestoRecibo.ForeColor = System.Drawing.Color.Red;
            }
            return dato;
        }

        private void listarPersonaN(String predio_id, string busqueda)
        {
            cboContribuyente.DisplayMember = "persona_Desc";
            cboContribuyente.ValueMember = "persona_ID";
            cboContribuyente.DataSource = persona.listarcontribuyentesPN(predio_id, 0, busqueda); ;
            this.cboContribuyente.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.cboContribuyente.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                //
                string dato = verificar("");
                if (dato.Trim().Length != 0)
                {
                    MessageBox.Show("Falta " + dato, Globales.Global_MessageBox);
                    return;
                }
                if (MessageBox.Show("Desea Grabar?", Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Pred_ConstanciaNoDebe ConstanciaNoDebe = new Pred_ConstanciaNoDebe();
                    //ConstanciaNoDebe.CompraVenta = Convert.ToDecimal(txtPorcentajeContenido.Text.Trim());
                    //ConstanciaNoDebe.a = txtAño.Text; ConstanciaNoDebe;
                    ConstanciaNoDebe.Descripcion = txtDescripcion.Text;
                    ConstanciaNoDebe.estado = ckbEstado.Checked;
                    ConstanciaNoDebe.Expediente = txtExpediente.Text;
                    //ConstanciaNoDebe.idPeriodo = int.Parse(txtAño.Text);
                    ConstanciaNoDebe.IdPersona = (String)cboContribuyente.SelectedValue;
                    ConstanciaNoDebe.ImpuestoImporte = Convert.ToDecimal(txtImpuestoImporte.Text);
                    ConstanciaNoDebe.ImpuestoRecibo = txtImpuestoRecibo.Text;
                    ConstanciaNoDebe.Obligacion = txtObligacion.Text;
                    ConstanciaNoDebe.registro_user_add = GlobalesV1.Global_str_Usuario;
                    ConstanciaNoDebe.registro_user_update = GlobalesV1.Global_str_Usuario;
                    //ConstanciaNoDebe.Saldo = txtAño.Text;
                    //ConstanciaNoDebe.Tipo = txtAño.Text;
                    ConstanciaNoDebe.TramiteImporte = Convert.ToDecimal(txtTramiteImporte.Text);
                    ConstanciaNoDebe.TramiteRecibo = txtTramiteRecibo.Text;
                    ConstanciaNoDebe.idConstancia = Convert.ToInt32(txtId.Text);
                    //ConstanciaNoDebe.Transferencia = txtTransferencia.Text;
                    //ConstanciaNoDebe.UIT = txtAño.Text;
                    //ConstanciaNoDebe.Valuo = txtAño.Text;                
                    ConstanciaNoDebeDataService.Update2(ConstanciaNoDebe);
                    MessageBox.Show("Se Grabó Correctamente", Globales.Global_MessageBox);
                    btnGuardar.Enabled = false;
                    //}
                    this.Close();
                }
            }
            else
            {
                string dato = verificar("");
                if (dato.Trim().Length != 0)
                {
                    MessageBox.Show("Falta " + dato, Globales.Global_MessageBox);
                    return;
                }
                if (MessageBox.Show("Desea Grabar?", Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Pred_ConstanciaNoDebe ConstanciaNoDebe = new Pred_ConstanciaNoDebe();
                    //ConstanciaNoDebe.CompraVenta = Convert.ToDecimal(txtPorcentajeContenido.Text.Trim());
                    //ConstanciaNoDebe.a = txtAño.Text; ConstanciaNoDebe;
                    ConstanciaNoDebe.Descripcion = txtDescripcion.Text;
                    ConstanciaNoDebe.estado = ckbEstado.Checked;
                    ConstanciaNoDebe.Expediente = txtExpediente.Text;
                    //ConstanciaNoDebe.idPeriodo = int.Parse(txtAño.Text);
                    //ConstanciaNoDebe.IdPersona = cboPersona.SelectedValue.ToString();
                    ConstanciaNoDebe.ImpuestoImporte = Convert.ToDecimal(txtImpuestoImporte.Text);
                    ConstanciaNoDebe.ImpuestoRecibo = txtImpuestoRecibo.Text;
                    ConstanciaNoDebe.Obligacion = txtObligacion.Text;
                    ConstanciaNoDebe.registro_user_add = GlobalesV1.Global_str_Usuario;
                    ConstanciaNoDebe.registro_user_update = GlobalesV1.Global_str_Usuario;
                    //ConstanciaNoDebe.Saldo = txtAño.Text;
                    //ConstanciaNoDebe.Tipo = txtAño.Text;
                    ConstanciaNoDebe.TramiteImporte = Convert.ToDecimal(txtTramiteImporte.Text);
                    ConstanciaNoDebe.TramiteRecibo = txtTramiteRecibo.Text;
                    ConstanciaNoDebe.idConstancia = Convert.ToInt32(txtId.Text);
                    //ConstanciaNoDebe.Transferencia = txtTransferencia.Text;
                    //ConstanciaNoDebe.UIT = txtAño.Text;
                    //ConstanciaNoDebe.Valuo = txtAño.Text;                
                    ConstanciaNoDebeDataService.Update(ConstanciaNoDebe);
                    MessageBox.Show("Se Grabó Correctamente", Globales.Global_MessageBox);
                    btnGuardar.Enabled = false;
                    //}
                    this.Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ckbEstado_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbEstado.Checked == false)
            {
                if (MessageBox.Show("Desea desactivar esta constancia?", Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ckbEstado.Checked = false;
                }
                else
                {
                    ckbEstado.Checked = true;
                }
            }
            else
            {
                if (MessageBox.Show("Desea activar esta constancia?", Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ckbEstado.Checked = true;
                }
                else
                {
                    ckbEstado.Checked = false;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {                
                btnBusqueda.Enabled = true;
            }
            else
            {
                //txt_pagante.Enabled = false;
                btnBusqueda.Enabled = false;
                //txt_pagante.Clear();
                cboContribuyente.DataSource = null;
                cboContribuyente.Items.Clear();
                cboContribuyente.Enabled = false;
                
            }
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBusqueda.Text.TrimEnd().Length != 0)
                {
                    cboContribuyente.Enabled = true;
                    listarPersonaN("", txtBusqueda.Text.TrimEnd());
                    //cboPersona.SelectedValue = persona_id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
