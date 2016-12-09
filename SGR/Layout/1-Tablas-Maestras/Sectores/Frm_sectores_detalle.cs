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

namespace SGR.WinApp.Layout._1_Tablas_Maestras.Sectores
{
    public partial class Frm_sectores_detalle : Form
    {
        private Pred_Sector pred_Sector;

        public Frm_sectores_detalle()
        {
            InitializeComponent();
        }

        public Frm_sectores_detalle(Pred_Sector pred_Sector)
        {
            InitializeComponent();
            this.pred_Sector = pred_Sector;
        }
        public void llenarTipoSector()
        {
            cboTipoSector.DisplayMember = "descripcion";
            cboTipoSector.ValueMember = "valor";
            Pred_SectorDataService Pred_SectorDataService = new Pred_SectorDataService();
            cboTipoSector.DataSource = Pred_SectorDataService.llenarTipoSector();
            
        }
        public void limpiar()
        {
            txtDescripcion.Clear();
            cboTipoSector.SelectedIndex = 0;
        }
        
        private void btnGrabar_Click(object sender, EventArgs e)
        {
             Pred_SectorDataService Pred_SectorDataService = new Pred_SectorDataService();
            try
            {
                if (txtDescripcion.Text.Trim().Length <= 0)
                {
                    MessageBox.Show("Debe Ingresar una descripción", Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (cboTipoSector.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione una opción",Globales.Global_MessageBox,MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Desea Grabar?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (pred_Sector == null)
                     {
                        Pred_Sector pred_Sector1 = new Pred_Sector();
                        pred_Sector1.descripcion = txtDescripcion.Text;
                        pred_Sector1.tipo_Junta = cboTipoSector.SelectedValue.ToString();
                        pred_Sector1.barrido = chkBarrido.Checked;
                        pred_Sector1.recojo = chkRecojo.Checked;
                        pred_Sector1.jardin = chkJardin.Checked;
                        pred_Sector1.serenazgo = chkSerenazgo.Checked;
                        pred_Sector1.estado = chkEstado.Checked;
                        pred_Sector1.sysUser = "0";
                        pred_Sector1.registro_user_add = GlobalesV1.Global_str_Usuario;
                        pred_Sector1.registro_user_update = GlobalesV1.Global_str_Usuario;

                        Pred_SectorDataService.insertarSector(pred_Sector1);
                        // MessageBox.Show("Se Grabó Correctamente");
                        this.Close();
                    }
                    else
                        {
                        pred_Sector.descripcion = txtDescripcion.Text;
                        pred_Sector.tipo_Junta = cboTipoSector.SelectedValue.ToString();
                        pred_Sector.barrido = chkBarrido.Checked;
                        pred_Sector.recojo = chkRecojo.Checked;
                        pred_Sector.jardin = chkJardin.Checked;
                        pred_Sector.serenazgo = chkSerenazgo.Checked;
                        pred_Sector.estado = chkEstado.Checked;
                        pred_Sector.sysUser = "0";
                        pred_Sector.registro_user_update = GlobalesV1.Global_str_Usuario;
                        Pred_SectorDataService.updateSector(pred_Sector);
                        //MessageBox.Show("Se Grabó Correctamente");
                        pred_Sector = null;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            //cboTipoSector.DataSource = null;
            //cboTipoSector.Items.Clear();
        }

        private void Frm_sectores_detalle_Load(object sender, EventArgs e)
        {
            llenarTipoSector();
            cboTipoSector.SelectedIndex = 0;
            if (pred_Sector != null)
            {
                txtDescripcion.Text = pred_Sector.descripcion;
                cboTipoSector.SelectedValue = pred_Sector.tipo_Junta;
                chkBarrido.Checked = pred_Sector.barrido;
                chkRecojo.Checked = pred_Sector.recojo;
                chkJardin.Checked = pred_Sector.jardin;
                chkSerenazgo.Checked = pred_Sector.serenazgo;
                chkEstado.Checked = pred_Sector.estado;
            }
            else
            {
                chkEstado.Checked = true;
            }
        }
    }
}
