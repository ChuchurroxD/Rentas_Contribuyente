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

namespace SGR.WinApp.Layout._2_Configuraciones
{
    public partial class Frm_tablas_detalle : Form
    {
        private Conf_Multitabla conf_Multitabla;
        private int tipo;
        public Frm_tablas_detalle()
        {
            txtDescripcion.MaxLength = 70;
            txtAbreviatura.MaxLength = 7;
            InitializeComponent();
        }
        public Frm_tablas_detalle(Conf_Multitabla conf_Multitabla, int tipo)
        {
            this.tipo = tipo;
            InitializeComponent();
            txtDescripcion.MaxLength = 70;
            txtAbreviatura.MaxLength = 7;
            switch (tipo)
            {
                case 1://Agregar padres
                    txtPadre.Text = "0";
                    OcultarElementos(false);
                    break;
                case 2://Agregar hijos
                    this.conf_Multitabla = conf_Multitabla;
                    txtPadre.Text = conf_Multitabla.Multc_cValor;
                    OcultarElementos(false);
                    break;
                case 3://modificar padres
                    txtId.Text = Convert.ToString(conf_Multitabla.Multc_iCodigo);
                    txtDescripcion.Text = conf_Multitabla.Multc_vDescripcion;
                    txtAbreviatura.Text = conf_Multitabla.Multc_vAbreviatura;
                    OcultarElementos(true);
                    ckbEstado.Checked = conf_Multitabla.Multc_bEstado;
                    txtPadre.Text = "0";
                    break;
                case 4://modificar hijos
                    txtId.Text = Convert.ToString(conf_Multitabla.Multc_iCodigo);
                    txtDescripcion.Text = conf_Multitabla.Multc_vDescripcion;
                    txtAbreviatura.Text = conf_Multitabla.Multc_vAbreviatura;
                    OcultarElementos(true);
                    ckbEstado.Checked = conf_Multitabla.Multc_bEstado;
                    txtPadre.Text = conf_Multitabla.Multc_cDependencia;
                    break;

            }
        }
        private void cleanTextos()
        {
            txtId.Text = "";
            txtDescripcion.Text = "";
            txtAbreviatura.Text = "";
            txtPadre.Text = "";
        }
        private void btnGrabar_Click(object sender, EventArgs e)
        {
           Conf_MultitablaDataService Conf_MultitablaDataService = new Conf_MultitablaDataService();
                int codigo, cantidad;
                try     
                {
                if (txtDescripcion.Text.Trim().Length > 0)
                {
                    if (MessageBox.Show("Desea Grabar?", Globales.Global_MessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Conf_Multitabla conf_Multitabla1 = new Conf_Multitabla();

                                conf_Multitabla1.Multc_vDescripcion = txtDescripcion.Text.Trim();
                                conf_Multitabla1.Multc_vAbreviatura = txtAbreviatura.Text.Trim();
                                conf_Multitabla1.Multc_cDependencia = txtPadre.Text;

                                if (txtId.Text == "")
                                {//If es muevo
                                    cantidad = Conf_MultitablaDataService.GetExisteDescripcionNuevo(conf_Multitabla1.Multc_vDescripcion, conf_Multitabla1.Multc_cDependencia);
                                    if (cantidad > 0)
                                    {
                                        MessageBox.Show("Existe Descripción", Globales.Global_MessageBox);
                                    }
                                    else
                                    {
                                        codigo = Conf_MultitablaDataService.Insert(conf_Multitabla1);
                                        if (codigo > 0)
                                        {
                                            MessageBox.Show("Se Grabó Correctamente", Globales.Global_MessageBox);
                                }
                                    }
                                }
                                else
                                {//si modificamos
                                    conf_Multitabla1.Multc_iCodigo = Convert.ToInt64(txtId.Text);
                                    conf_Multitabla1.Multc_bEstado = ckbEstado.Checked;
                                    cantidad = Conf_MultitablaDataService.GetExisteDescripcionModificar(conf_Multitabla1.Multc_vDescripcion, conf_Multitabla1.Multc_cDependencia, Convert.ToInt64(txtId.Text));
                                    if (cantidad > 0)
                                    {
                                        MessageBox.Show("Existe Descripción", Globales.Global_MessageBox);
                            }
                                    else
                                    {
                                        Conf_MultitablaDataService.Update(conf_Multitabla1);

                                        MessageBox.Show("Se Grabó Correctamente", Globales.Global_MessageBox);

                            }
                                }


                                this.Close();
                    }
                }else
                MessageBox.Show("Falta llenar descripción", Globales.Global_MessageBox);
            }
            catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void OcultarElementos(bool visibl)
        {
            txtId.Visible = false;
            txtPadre.Visible = false;
            ckbEstado.Visible = visibl;
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ValidaNumeros(e);
        }

        private void txtAbreviatura_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ValidaNumeros(e);
        }
        private void ValidaNumeros(KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
