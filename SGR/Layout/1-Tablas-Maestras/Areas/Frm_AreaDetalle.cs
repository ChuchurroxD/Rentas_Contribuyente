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

namespace SGR.WinApp.Layout._1_Tablas_Maestras.Areas
{
    public partial class Frm_AreaDetalle : Form
    {
        Orga_Area padre = new Orga_Area();
        Orga_Area are = new Orga_Area();
        int op;
        string codNuevo;
        public Frm_AreaDetalle()
        {
            InitializeComponent();
        }


        public Frm_AreaDetalle(Orga_Area area,int opcion)
        {
            InitializeComponent();
            padre = area;
            op = opcion;
            if (opcion == 1)
            {
                txtClasiPrevio.Text = area.Areac_vCodigo + " " + area.Areac_vDescripcion;
                switch (area.Areac_vCodigo.Length)
                {
                    case 0:
                        txtCodigo.MaxLength = 2;
                        label4.Text = "2 Dígitos";
                        break;
                    case 2:
                        txtCodigo.MaxLength = 2;
                        label4.Text = "2 Dígitos";
                        break;                    
                }
            }
            else
            {
                string cod;
                int cantidad = 0;
                switch (padre.Areac_vCodigo.Length)
                {
                    case 2:
                        cantidad = 0;
                        txtCodigo.MaxLength = 2;
                        label4.Text = "2 Dígitos";
                        break;
                    case 4:
                        cantidad = 2;
                        txtCodigo.MaxLength = 2;
                        label4.Text = "2 Dígitos";
                        break;                  
                }

                Orga_AreaDataService manejaArea = new Orga_AreaDataService();
                cod = padre.Areac_vCodigo.Substring(0, cantidad);
                codNuevo = padre.Areac_vCodigo.Substring(cantidad, padre.Areac_vCodigo.Length - cantidad);
                txtCodigo.Text = codNuevo;
                are = manejaArea.GetByPrimaryKey(cod);
                if (!cod.Equals(""))
                    txtClasiPrevio.Text = are.Areac_vCodigo + " " + are.Areac_vDescripcion;                                 
                chk_estado.Checked = padre.Areac_bactivo;
                txtDescripcion.Text = padre.Areac_vDescripcion;
            }
             
        }

        private void button1_Click(object sender, EventArgs e)
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
                            Orga_AreaDataService areas = new Orga_AreaDataService();
                            int cantidad = 0;
                            if (areas.ExisteDescripcion(txtDescripcion.Text) > 0)
                            {
                                MessageBox.Show("Descripción ya existe", Globales.Global_MessageBox);
                                cantidad++;
                            }
                            if (areas.ExisteCodigo(padre.Areac_vCodigo + txtCodigo.Text) > 0)
                            {
                                MessageBox.Show("Código ya existe", Globales.Global_MessageBox);
                                cantidad++;
                            }
                            if (cantidad == 0)
                            {
                                Orga_Area elemento = new Orga_Area();
                                elemento.Areac_vCodigo = padre.Areac_vCodigo + txtCodigo.Text;
                                elemento.Areac_vDescripcion = txtDescripcion.Text;
                                elemento.Areac_bactivo = chk_estado.Checked;
                                elemento.registro_user_add = GlobalesV1.Global_str_Usuario;
                                elemento.registro_user_update = GlobalesV1.Global_str_Usuario;
                                exito = areas.Insert(elemento);
                                if (exito > 0)
                                {
                                    MessageBox.Show("Se Agregó Correctamente", Globales.Global_MessageBox);
                                    this.Close();
                                }


                            }
                        }
                        else
                        {
                            Orga_AreaDataService areas = new Orga_AreaDataService();
                            int cantidad = 0;

                            if (!(codNuevo.Equals(txtCodigo.Text)))
                            {
                                if (areas.ExisteCodigo(txtDescripcion.Text) > 0)
                                {
                                    MessageBox.Show("Código ya existe", Globales.Global_MessageBox);
                                    cantidad++;
                                }
                            }
                            if (!(padre.Areac_vDescripcion.Equals(txtDescripcion.Text)))
                            {
                                if (areas.ExisteDescripcion(padre.Areac_vCodigo + txtCodigo.Text) > 0)
                                {
                                    MessageBox.Show("Descripción ya existe", Globales.Global_MessageBox);
                                    cantidad++;
                                }
                            }
                            if (cantidad == 0)
                            {
                                Orga_Area elemento = new Orga_Area();
                                elemento.Areac_vCodigo = padre.Areac_vCodigo + txtCodigo.Text;
                                elemento.Areac_vDescripcion = txtDescripcion.Text;
                                elemento.Areac_bactivo = chk_estado.Checked;
                                elemento.registro_user_update = GlobalesV1.Global_str_Usuario;
                                areas.Update(elemento, padre.Areac_vCodigo);
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
