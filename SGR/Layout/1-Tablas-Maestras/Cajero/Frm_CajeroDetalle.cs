using DgvFilterPopup;
using SGR.Core.Service;
using SGR.Core.Service.Combos;
using SGR.Entity;
using SGR.Entity.Model.Combos;
using System;
using System.Windows.Forms;

namespace SGR.WinApp.Layout._1_Tablas_Maestras.Cajero
{
    public partial class Frm_CajeroDetalle : Form
    {
        Pago_PersonaDataService persona = new Pago_PersonaDataService();
        Pago_CajeroDataService cajero = new Pago_CajeroDataService();
        string persona_ID;
        public Frm_CajeroDetalle()
        {
            persona_ID = "";
            InitializeComponent();
            cboPersona.DisplayMember = "persona_Desc";
            cboPersona.ValueMember = "persona_ID";
            cboPersona.DataSource = persona.listartodos("");
            this.cboPersona.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.cboPersona.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtFechaFin.Visible = false;
            label3.Visible = false;
        }
        public Frm_CajeroDetalle(Pago_Cajero cajero)
        {
            InitializeComponent();
            persona_ID = cajero.Persona_id;
            cboPersona.DisplayMember = "persona_Desc";
            cboPersona.ValueMember = "persona_ID";
            cboPersona.DataSource = persona.listartodos(cajero.Persona_id);
            this.cboPersona.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.cboPersona.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cboPersona.SelectedValue = cajero.Persona_id;
            cboPersona.Enabled = false;
            txtFechaIni.Value = cajero.FechaInicio;
            txtFechaFin.Value = cajero.FechaFin;
            txtObservacion.Text = cajero.Observacion;
            chkEstado.Checked = cajero.Estado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (persona_ID.Equals(""))
                {
                    Pago_Cajero elemento = new Pago_Cajero();
                    elemento.Persona_id = Convert.ToString(cboPersona.SelectedValue);
                    elemento.FechaInicio = txtFechaIni.Value;
                    elemento.FechaFin = txtFechaFin.Value;
                    elemento.Estado = chkEstado.Checked;
                    elemento.Observacion = txtObservacion.Text;
                    //MessageBox.Show(Convert.ToString(cboPersona.SelectedValue));
                    int respuesta = cajero.Insert(elemento);
                    if (respuesta == 1)
                        MessageBox.Show("Registro correctamente registrado", Globales.Global_MessageBox);
                    else
                        MessageBox.Show("Error al agregar el registro", Globales.Global_MessageBox);
                }
                else
                {
                    Pago_Cajero elemento = new Pago_Cajero();
                    elemento.Persona_id = Convert.ToString(cboPersona.SelectedValue);
                    elemento.FechaInicio = txtFechaIni.Value;
                    elemento.FechaFin = txtFechaFin.Value;
                    elemento.Estado = chkEstado.Checked;
                    elemento.Observacion = txtObservacion.Text;
                    //MessageBox.Show(Convert.ToString(cboPersona.SelectedValue));
                    cajero.Update(elemento);
                    MessageBox.Show("Se actualizó correctamente", Globales.Global_MessageBox);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al grabar", Globales.Global_MessageBox);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
