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
using SGR.Entity;
using WeifenLuo.WinFormsUI.Docking;
using SGR.Core.Service.Combos;
using SGR.WinApp.Layout._5_Reportes_Gestion;
using Microsoft.Reporting.WinForms;
using SGR.WinApp.Layout._1_Tablas_Maestras.Contribuyente;

namespace SGR.WinApp.Layout._4_Procesos.Multa
{
    public partial class Frm_MultasAdministrativas : DockContent
    {
        Pago_PersonaDataService persona = new Pago_PersonaDataService();
        Conf_MultitablaDataService conf_MultitablaDataService = new Conf_MultitablaDataService();
        Mult_MultasDataService mult_MultasDataService = new Mult_MultasDataService();
        private Mult_Multas mult_Multas;
        string archivo = "";
        public Frm_MultasAdministrativas()
        {
            try
            {

                InitializeComponent();
                llenarcboMultitabla("136", cboTipoInfraccion);
                llenarcboMultitabla("136", cboTipoRecurso);
                llenarcboMultitabla("136", cboDeclaro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        public Frm_MultasAdministrativas(Mult_Multas mult_Multas)
        {
            InitializeComponent();
            this.mult_Multas = mult_Multas;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ofdArchivo.Filter = "Archivos PDF|*.pdf";
            ofdArchivo.Title = "Seleccione un Archivo";
            ofdArchivo.ShowDialog();
        }

        private void ofdArchivo_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                archivo = subirImagen(ofdArchivo.FileName, ofdArchivo.SafeFileName);
                if (archivo.Trim().Length == 0)
                    MessageBox.Show("No se subió el archivo", Globales.Global_MessageBox);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }
        private string subirImagen(string origen, string nombreArchivo)
        {
            try
            {
                DateTime fechaHoy = DateTime.Now;
                string destino = System.IO.Directory.GetCurrentDirectory() + "\\resolucion-multa";
                //string destino = Globales.DireccionMapaCasa;// "D:\\sgr_11_05_2016\\SGR\\SGR\\Resources\\casamapa";
                string cadena = fechaHoy.Year.ToString() + fechaHoy.Month.ToString() + fechaHoy.Day.ToString() +
                               fechaHoy.Hour.ToString() + fechaHoy.Minute.ToString() + fechaHoy.Second.ToString();
                if (!System.IO.Directory.Exists(destino))
                {
                    System.IO.Directory.CreateDirectory(destino);
                }
                System.IO.File.Copy(origen, destino + "\\" + cadena + nombreArchivo, true);
                return destino + "\\" + cadena + nombreArchivo;
            }
            catch (Exception ed)
            {
                MessageBox.Show(ed.ToString(), Globales.Global_MessageBox);
            }
            return "";
        }

        private void btnNuevoContribuyente_Click(object sender, EventArgs e)
        {
            Frm_Contribuyente_Detalle Frm_Contribuyente_Detalle = new Frm_Contribuyente_Detalle();
            Frm_Contribuyente_Detalle.StartPosition = FormStartPosition.CenterParent;
            Frm_Contribuyente_Detalle.ShowDialog();
            cboContribuyente.DataSource = persona.listarcontribuyentes(txtBusqueda.Text.Trim());
        }
        private string Verificar(string dato)
        {

            lblContribuyente.ForeColor = System.Drawing.Color.Black;
            lblDeclaro.ForeColor = System.Drawing.Color.Black;
            lblDireccion.ForeColor = System.Drawing.Color.Black;
            lblTipoInfraccion.ForeColor = System.Drawing.Color.Black;
            lblTipoRecurso.ForeColor = System.Drawing.Color.Black;
            lblMontoo.ForeColor = System.Drawing.Color.Black;
            lblNroResolucion.ForeColor = System.Drawing.Color.Black;
            lblResolucion.ForeColor = System.Drawing.Color.Black;
            if (cboContribuyente.SelectedIndex == -1)
            {
                dato = dato + "Contribuyente, ";
                lblContribuyente.ForeColor = System.Drawing.Color.Red;
            }
            if (cboDeclaro.SelectedIndex == -1)
            {
                dato = dato + "Declarar, ";
                lblDeclaro.ForeColor = System.Drawing.Color.Red;
            }
            if (cboTipoInfraccion.SelectedIndex == -1)
            {
                dato = dato + "Tipo de Infracción, ";
                lblTipoInfraccion.ForeColor = System.Drawing.Color.Red;
            }
            if (cboTipoRecurso.SelectedIndex == -1)
            {
                dato = dato + "Tipo de Recurso, ";
                lblTipoRecurso.ForeColor = System.Drawing.Color.Red;
            }
            if (txtDireccion.Text.Trim().Length == 0)
            {
                dato = dato + "Dirección, ";
                lblDireccion.ForeColor = System.Drawing.Color.Red;
            }
            if (txtMontoPagado.Text.Trim().Length == 0)
            {
                dato = dato + "Monto Pagado, ";
                lblMontoo.ForeColor = System.Drawing.Color.Red;
            }
            //if (txtNroResolucion.Text.Trim().Length == 0)
            //{
            //    dato = dato + "N° de Resolucion, ";
            //    lblNroResolucion.ForeColor = System.Drawing.Color.Red;
            //}
            if (txtResolucion.Text.Trim().Length == 0)
            {
                dato = dato + "Resolución, ";
                lblResolucion.ForeColor = System.Drawing.Color.Red;
            }
            if (txtResolucionAnio.Text.Trim().Length == 0)
            {
                dato = dato + "Resolucion de Anio, ";
                lblResolucion.ForeColor = System.Drawing.Color.Red;
            }


            return dato;
        }
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_oculto.Text.Length == 0)
                {
                    string dato = Verificar("");
                    if (dato.Trim().Length > 0)
                    {
                        MessageBox.Show("Falta " + dato, Globales.Global_MessageBox);
                        return;
                    }
                    //if (mult_MultasDataService.VerificarResolucion(txtResolucion.Text.Trim(), txtResolucionAnio.Text.Trim()) == 0)
                    //{
                    //    MessageBox.Show("No existe Resolucion", Globales.Global_MessageBox);
                    //    return;
                    //}
                    if (MessageBox.Show("Desea Grabar?", Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Mult_Multas mult_Multas = new Mult_Multas();
                        if (rbtAdmin.Checked)
                            mult_Multas.clase_Multa = 1;
                        else
                            mult_Multas.clase_Multa = 2;

                        mult_Multas.persona_id = cboContribuyente.SelectedValue.ToString();
                        mult_Multas.fech_recurso = dtpFechaRecurso.Value;
                        //getdatemult_Multas.fecha_genera=
                        mult_Multas.fecha_notifica = dtpFechaNotificacion.Value;
                        mult_Multas.fecha_vence = dtpFechaVencimiento.Value;
                        mult_Multas.mult_anio_resolucion = txtResolucionAnio.Text;
                        mult_Multas.mult_archivo = archivo;
                        mult_Multas.mult_direccion = txtDireccion.Text;
                        //mult_Multas.mult_estado=
                        mult_Multas.mult_fecha_resol = dtpFechaEmision.Value;
                        mult_Multas.mult_monto = Convert.ToDecimal(txtMontoPagado.Text);
                        mult_Multas.mult_nro_resolucion = txtResolucion.Text;
                        mult_Multas.tp_declaro = Convert.ToInt32(cboDeclaro.SelectedValue);
                        mult_Multas.tp_recurso = Convert.ToInt32(cboTipoRecurso.SelectedValue);
                        mult_Multas.TipoMulta_id = Convert.ToInt32(cboTipoInfraccion.SelectedValue);
                        mult_Multas.mult_observacion = txtObservacion.Text;
                        mult_Multas.registro_user = GlobalesV1.Global_str_Usuario;
                        mult_Multas.resol_resuelve = txtNroResolucion.Text;
                        mult_Multas.registro_user = GlobalesV1.Global_str_Usuario;
                        mult_MultasDataService.Insert(mult_Multas);
                        MessageBox.Show("Se grabó correctamente", Globales.Global_MessageBox);
                        this.Dispose();
                    }
                }
                else
                {
                    if (chkEstado.Checked)
                    {
                        if (MessageBox.Show("Esta seguro que desea anular la multa?", Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Mult_Multas mult_Multas = new Mult_Multas();
                            mult_Multas.mult_observacion = txtObservacion.Text;
                            mult_Multas.mult_id = Convert.ToInt32(txt_oculto.Text);
                            mult_Multas.registro_user = GlobalesV1.Global_str_Usuario;
                            //mult_Multas.registro_user = "nadaaaa";
                            mult_MultasDataService.Update(mult_Multas);
                            MessageBox.Show("Se grabó correctamente", Globales.Global_MessageBox);
                            this.Dispose();
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }

        }
        public void llenarcboMultitabla(string dep, ComboBox cbo)
        {
            cbo.DisplayMember = "Multc_vDescripcion";
            cbo.ValueMember = "Multc_cValor";
            cbo.DataSource = conf_MultitablaDataService.GetCboConf_Multitabla(dep);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cboContribuyente.SelectedIndex = -1;
            cboDeclaro.SelectedIndex = -1;
            cboTipoInfraccion.SelectedIndex = -1;
            cboTipoRecurso.SelectedIndex = -1;
            txtDireccion.Text = "";
            txtMontoPagado.Text = "";
            txtNroResolucion.Text = "";
            txtResolucion.Text = "";
            txtResolucionAnio.Text = "";

        }

        private void llenarcomboPersona()
        {
            try
            {
                cboContribuyente.DisplayMember = "persona_Desc";
                cboContribuyente.ValueMember = "persona_ID";
                cboContribuyente.DataSource = persona.listartodos("");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void Frm_MultasAdministrativas_Load(object sender, EventArgs e)
        {
            try
            {
                llenarcboMultitabla("136", cboTipoInfraccion);
                llenarcboMultitabla("1", cboTipoRecurso);
                llenarcboMultitabla("1", cboDeclaro);

                if (mult_Multas != null)
                {

                    txtResolucion.Enabled = false;
                    txtResolucion.Enabled = false;
                    txtResolucionAnio.Enabled = false;
                    txtMontoPagado.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtNroResolucion.Enabled = false;
                    dtpFechaEmision.Enabled = false;
                    dtpFechaVencimiento.Enabled = false;
                    dtpFechaNotificacion.Enabled = false;
                    dtpFechaRecurso.Enabled = false;
                    cboContribuyente.Enabled = false;
                    cboTipoRecurso.Enabled = false;
                    cboDeclaro.Enabled = false;
                    cboTipoInfraccion.Enabled = false;
                    btnNuevoContribuyente.Visible = false;
                    button1.Visible = false;
                    btnLimpiar.Visible = false;
                    label16.Visible = false;
                    label11.Visible = false;
                    label5.Visible = false;

                    txtResolucion.Text = mult_Multas.mult_nro_resolucion.ToString();
                    txtResolucionAnio.Text = mult_Multas.mult_anio_resolucion.ToString();
                    txtMontoPagado.Text = mult_Multas.mult_monto.ToString();
                    txtDireccion.Text = mult_Multas.mult_direccion.ToString();
                    txtObservacion.Text = mult_Multas.mult_observacion.ToString();
                    txt_oculto.Text = mult_Multas.mult_id.ToString();
                    txtNroResolucion.Text = mult_Multas.resol_resuelve.ToString();
                    dtpFechaEmision.Text = mult_Multas.fecha_genera.ToString();
                    dtpFechaVencimiento.Text = mult_Multas.fecha_vence.ToString();
                    dtpFechaNotificacion.Text = mult_Multas.fecha_notifica.ToString();
                    dtpFechaRecurso.Text = mult_Multas.fech_recurso.ToString();
                    cboContribuyente.Text = mult_Multas.persona;
                    cboTipoRecurso.Text = mult_Multas.recursod;
                    cboDeclaro.Text = mult_Multas.declarod;
                    cboTipoInfraccion.Text = mult_Multas.tipomultad;
                    chkEstado.Checked = false;
                }
                else
                {
                    txtResolucion.Text = "";
                    txtResolucionAnio.Text = "";
                    txtMontoPagado.Text = "";
                    txtDireccion.Text = "";
                    txtObservacion.Text = "";
                    txtNroResolucion.Text = "";
                    chkEstado.Visible = false;
                    btnCancelar.Visible = false;

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

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                cboContribuyente.DisplayMember = "persona_Desc";
                cboContribuyente.ValueMember = "persona_ID";
                cboContribuyente.DataSource = persona.listarcontribuyentes(txtBusqueda.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void cboTipoInfraccion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
