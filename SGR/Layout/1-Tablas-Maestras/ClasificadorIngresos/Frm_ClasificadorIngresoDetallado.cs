using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGR.Entity.Model;
using SGR.Core.Service;

namespace SGR.WinApp.Layout._1_Tablas_Maestras.ClasificadorIngresos
{
    public partial class Frm_ClasificadorIngresosDetalle : Form
    {
        int op;
        Trib_ClasificadorIngresos padre = new Trib_ClasificadorIngresos();
        Trib_ClasificadorIngresos tributo = new Trib_ClasificadorIngresos();
        string codNuevo;
        public Frm_ClasificadorIngresosDetalle()
        {
            InitializeComponent();
        }

        public Frm_ClasificadorIngresosDetalle(Trib_ClasificadorIngresos ingreso, int opcion)
        {
            InitializeComponent();
            padre = ingreso;
            op = opcion;
            if (opcion == 1)
            {
                txtClasiPrevio.Text = ingreso.Tribc_vCodigo + " " + ingreso.Tribc_vDescripcion;
                switch (ingreso.Tribc_vCodigo.Length)
                {
                    case 0:
                        txtCodigo.MaxLength = 1;
                        lblCaracteres.Text = "1 Dígito";
                        break;
                    case 1:
                        txtCodigo.MaxLength = 2;
                        lblCaracteres.Text = "2 Dígitos";
                        break;
                    case 3:
                        txtCodigo.MaxLength = 2;
                        lblCaracteres.Text = "2 Dígitos";
                        break;
                    case 5:
                        txtCodigo.MaxLength = 1;
                        lblCaracteres.Text = "1 Dígito";
                        break;
                    case 6:
                        txtCodigo.MaxLength = 2;
                        lblCaracteres.Text = "2 Dígitos";
                        break;
                    case 8:
                        txtCodigo.MaxLength = 2;
                        lblCaracteres.Text = "2 Dígitos";
                        break;
                }
            }
            else
            {
                string cod;
                int cantidad = 0;
                switch (padre.Tribc_vCodigo.Length)
                {
                    case 1:
                        cantidad = 1;
                        txtCodigo.MaxLength = 1;
                        lblCaracteres.Text = "1 Dígito";
                        break;
                    case 3:
                        cantidad = 1;
                        txtCodigo.MaxLength = 2;
                        lblCaracteres.Text = "2 Dígitos";
                        break;
                    case 5:
                        cantidad = 3;
                        txtCodigo.MaxLength = 2;
                        lblCaracteres.Text = "2 Dígitos";
                        break;
                    case 6:
                        cantidad = 5;
                        txtCodigo.MaxLength = 1;
                        lblCaracteres.Text = "1 Dígito";
                        break;
                    case 8:
                        cantidad = 6;
                        txtCodigo.MaxLength = 2;
                        lblCaracteres.Text = "2 Dígitos";
                        break;
                    case 10:
                        cantidad = 8;
                        txtCodigo.MaxLength = 2;
                        lblCaracteres.Text = "2 Dígitos";
                        break;
                }
                
                Trib_ClasificadorIngresosDataService manejaTributo = new Trib_ClasificadorIngresosDataService();
                cod = padre.Tribc_vCodigo.Substring(0, cantidad);                
                codNuevo= padre.Tribc_vCodigo.Substring(cantidad, padre.Tribc_vCodigo.Length - cantidad);
                txtCodigo.Text = codNuevo;
                tributo = manejaTributo.GetByPrimaryKey(cod,padre.Tribc_vAnio);
                txtDescripcion.Text = padre.Tribc_vDescripcion;
                txtClasiPrevio.Text = tributo.Tribc_vCodigo + " " + tributo.Tribc_vDescripcion;
                chk_estado.Checked = padre.Tribc_bEstado;

            }
        }
        

        private void RegistraCodigo(object sender, KeyEventArgs e)
        {
            if (txtCodigo.Text.Length == txtCodigo.MaxLength)
                MessageBox.Show("Se ingreso la maxima cantidad de caracteres en este nivel", Globales.Global_MessageBox);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int exito;
            if (txtCodigo.Text.Length != txtCodigo.MaxLength)
                MessageBox.Show("Número de carácteres del código no válido", Globales.Global_MessageBox);
            else
            {
                if (txtDescripcion.Text.Equals(""))
                    MessageBox.Show("Digite descripción", Globales.Global_MessageBox);
                else
                {
                    if (MessageBox.Show("Desea Grabar?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (op == 1)
                        {
                            Trib_ClasificadorIngresosDataService tributos = new Trib_ClasificadorIngresosDataService();
                            int cantidad = 0;
                            if (tributos.ExisteDescripcion(txtDescripcion.Text, padre.Tribc_vAnio) > 0)
                            {
                                MessageBox.Show("Descripción ya existe", Globales.Global_MessageBox);
                                cantidad++;
                            }
                            if (tributos.ExisteCodigo(padre.Tribc_vCodigo + txtCodigo.Text, padre.Tribc_vAnio) > 0)
                            {
                                MessageBox.Show("Código ya existe", Globales.Global_MessageBox);
                                cantidad++;
                            }
                            if (cantidad == 0)
                            {
                                Trib_ClasificadorIngresos elemento = new Trib_ClasificadorIngresos();
                                elemento.Tribc_vCodigo = padre.Tribc_vCodigo + txtCodigo.Text;
                                elemento.Tribc_vDescripcion = txtDescripcion.Text;
                                elemento.Tribc_bEstado = chk_estado.Checked;
                                elemento.Tribc_vAnio = padre.Tribc_vAnio;
                                elemento.registro_user_add = GlobalesV1.Global_str_Usuario;
                                elemento.registro_user_update = GlobalesV1.Global_str_Usuario;
                                exito = tributos.Insert(elemento);
                                if (exito > 0)
                                {
                                    MessageBox.Show("Se Agregó Correctamente", Globales.Global_MessageBox);
                                    this.Close();
                                }
                            }
                        }
                        else
                        {
                            Trib_ClasificadorIngresosDataService tributos = new Trib_ClasificadorIngresosDataService();
                            int cantidad = 0;

                            if (!padre.Tribc_vDescripcion.Equals(txtDescripcion.Text))
                            {
                                if (tributos.ExisteDescripcion(txtDescripcion.Text, padre.Tribc_vAnio) > 0)
                                {
                                    MessageBox.Show("Descripción ya existe", Globales.Global_MessageBox);
                                    cantidad++;
                                }
                            }
                            if (!codNuevo.Equals(txtCodigo.Text))
                            {
                                if (tributos.ExisteCodigo(padre.Tribc_vCodigo + txtCodigo.Text, padre.Tribc_vAnio) > 0)
                                {
                                    MessageBox.Show("Código ya existe", Globales.Global_MessageBox);
                                    cantidad++;
                                }
                            }
                            if (cantidad == 0)
                            {
                                Trib_ClasificadorIngresos elemento = new Trib_ClasificadorIngresos();
                                elemento.Tribc_vCodigo = tributo.Tribc_vCodigo + txtCodigo.Text;
                                elemento.Tribc_vDescripcion = txtDescripcion.Text;
                                elemento.Tribc_bEstado = chk_estado.Checked;
                                elemento.Tribc_vAnio = padre.Tribc_vAnio;
                                elemento.registro_user_update = GlobalesV1.Global_str_Usuario;
                                tributos.Update(elemento,padre.Tribc_vCodigo);
                                MessageBox.Show("Se Grabó Correctamente", Globales.Global_MessageBox);
                                this.Close();
                            }
                        }
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
