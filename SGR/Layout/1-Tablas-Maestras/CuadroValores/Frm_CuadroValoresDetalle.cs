using DgvFilterPopup;
using SGR.Core;
using SGR.Core.Service;
using SGR.Entity;
using System;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace SGR.WinApp.Layout._1_Tablas_Maestras.CuadroValores
{
    public partial class Frm_CuadroValoresDetalle : Form
    {
        int opcion = 0;
        private Mant_CuadroValoresDataService mant_cuadrovalroes = new Mant_CuadroValoresDataService();
        private Conf_MultitablaDataService tablas = new Conf_MultitablaDataService();
        private Mant_PeriodoDataService periodos = new Mant_PeriodoDataService();
        Mant_CuadroValores cuadro_valoress = new Mant_CuadroValores();
        public Frm_CuadroValoresDetalle()
        {
            InitializeComponent();
            cargarCombos();
        }
        public Frm_CuadroValoresDetalle(Mant_CuadroValores cuadroValores)
        {
            InitializeComponent();
            cargarCombos();
            this.cuadro_valoress = cuadroValores;
            opcion = 1;
            asignarValores(cuadroValores);
        }
        public void asignarValores(Mant_CuadroValores elemento)
        {
            cboPeriodo.SelectedValue = elemento.anio;
            cboSerie.SelectedValue = elemento.serie.Trim();
            cboTipo.SelectedValue = Convert.ToString(elemento.codigo);
            txtDescripcion.Text = elemento.descripcion;
            txtMonto.Text = Convert.ToString(elemento.monto);
            if (elemento.estado == 0)
                chkEstado.Checked = false;
            else
                chkEstado.Checked = true;
        }
        public void cargarCombos()
        {
            cboPeriodo.DisplayMember = "Peric_canio";
            cboPeriodo.ValueMember = "Peric_canio";
            cboPeriodo.DataSource = periodos.GetAllMant_Periodo();

            cboSerie.DisplayMember = "Multc_vDescripcion";
            cboSerie.ValueMember = "Multc_cValor";
            cboSerie.DataSource = tablas.GetCboConf_Multitabla("26");

            cboTipo.DisplayMember = "Multc_vDescripcion";
            cboTipo.ValueMember = "Multc_cValor";
            cboTipo.DataSource = tablas.GetCboConf_Multitabla("27");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Grabar?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (cboPeriodo.Text.Equals("") || cboSerie.Text.Equals("") || cboTipo.Text.Equals("")
                    || txtDescripcion.Text.Equals("") || txtMonto.Text.Equals(""))
                    MessageBox.Show("Por favor complete los campos");
                else
                {
                    Mant_CuadroValores elemento = new Mant_CuadroValores();
                    elemento.anio = Convert.ToInt32(cboPeriodo.SelectedValue);
                    elemento.codigo = Convert.ToInt32(Convert.ToString(cboTipo.SelectedValue).Trim());
                    elemento.serie = Convert.ToString(cboSerie.SelectedValue).Trim();
                    elemento.descripcion = txtDescripcion.Text;
                    if (chkEstado.Checked)
                        elemento.estado = 1;
                    else elemento.estado = 0;
                    elemento.monto = Convert.ToDecimal(txtMonto.Text);
                    try
                    {
                        if (mant_cuadrovalroes.valida(elemento)==0)
                        {
                            if (opcion == 0)
                            {
                                int resultado = mant_cuadrovalroes.Insert(elemento);
                                if (resultado != 0)
                                    MessageBox.Show("Se insertó correctamente", Globales.Global_MessageBox);
                                this.Close();
                            }
                            else
                            {
                                elemento.cuadro_valores_id = cuadro_valoress.cuadro_valores_id;
                                mant_cuadrovalroes.Update(elemento);
                                MessageBox.Show("Se actualizaron los datos", Globales.Global_MessageBox); this.Close();
                            }
                        }
                        else
                        {
                            if (opcion != 0 && elemento.codigo==cuadro_valoress.codigo && elemento.anio==cuadro_valoress.anio
                                && elemento.serie==cuadro_valoress.serie)
                            {
                                elemento.cuadro_valores_id = cuadro_valoress.cuadro_valores_id;
                                mant_cuadrovalroes.Update(elemento);
                                MessageBox.Show("Se actualizaron los datos", Globales.Global_MessageBox); this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Ya se registró el valor para el año, serie y tipo indicados", Globales.Global_MessageBox);
                                this.Close();
                            }
                        }

                        

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al Grabar", Globales.Global_MessageBox);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
