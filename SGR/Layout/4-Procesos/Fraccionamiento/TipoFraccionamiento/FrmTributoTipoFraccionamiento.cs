using DgvFilterPopup;
using SGR.Core.Service;
using SGR.Entity.Model;
using System;
using System.Windows.Forms;


namespace SGR.WinApp.Layout._4_Procesos.Fraccionamiento.TipoFraccionamiento
{
    public partial class FrmTributoTipoFraccionamiento : Form
    {
        private Trib_TipoFraccionamientoDataService trib_TipoFraccionamiento = new Trib_TipoFraccionamientoDataService();
        private Conf_MultitablaDataService tablas = new Conf_MultitablaDataService();
        int cod;
        public FrmTributoTipoFraccionamiento()
        {
            InitializeComponent();
        }
        public FrmTributoTipoFraccionamiento(int codigo)
        {
            InitializeComponent();
            cod = codigo;
            cargarComboTipo();
            cargarComboTributo(codigo, Convert.ToInt32(cboTipoTributo.SelectedValue));

        }
        public void cargarComboTipo()
        {
            cboTipoTributo.DisplayMember = "Multc_vDescripcion";
            cboTipoTributo.ValueMember = "Multc_cValor";
            cboTipoTributo.DataSource = tablas.GetCboConf_Multitabla("1");


        }
        public void cargarComboTributo(int codi, int codigo)
        {
            cboTributo.DisplayMember = "TrFrc_vtribDesc";
            cboTributo.ValueMember = "TrFrc_vtrib";
            cboTributo.DataSource = trib_TipoFraccionamiento.listarTributosporTipo(codi, codigo);
        }

        private void FrmTributoTipoFraccionamiento_Load(object sender, EventArgs e)
        {

        }

        private void recargarTributos(object sender, EventArgs e)
        {
            cargarComboTributo(cod, Convert.ToInt32(cboTipoTributo.SelectedValue));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int exito;
            if (!cboTributo.Text.Equals(""))
            {
                if (MessageBox.Show("Desea Grabar?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Trib_TributoFraccionamiento elemento = new Trib_TributoFraccionamiento();
                    elemento.TrFrc_vtrib = cboTributo.SelectedValue.ToString();
                    elemento.TrFrc_icod = cod;

                    exito = trib_TipoFraccionamiento.InsertTributoFracc(elemento);
                    if (exito > 0)
                    {
                        MessageBox.Show("Se Grabó Correctamente", Globales.Global_MessageBox);
                        this.Close();
                    }
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Por Favor Seleccionar Un Tributo", Globales.Global_MessageBox);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
