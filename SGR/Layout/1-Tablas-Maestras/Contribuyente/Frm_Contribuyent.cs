using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGR.Core.Repository;
using SGR.Core.Service;
using SGR.Entity;
using WeifenLuo.WinFormsUI.Docking;
using SGR.WinApp.Layout._1_Tablas_Maestras.Relacion_Contribuyente;
namespace SGR.WinApp.Layout._1_Tablas_Maestras.Contribuyente
{
    public partial class Frm_Contribuyent : DockContent
    {
        Conf_MultitablaDataService conf_MultitablaDataService = new Conf_MultitablaDataService();
        Conf_UbicacionDataService conf_UbicacionDataService = new Conf_UbicacionDataService();
        Pred_SectorDataService pred_SectorDataService = new Pred_SectorDataService();
        Pred_ViasDataService pred_ViasDataService = new Pred_ViasDataService();
        Mant_PersonaDataService mant_PersonaDataService = new Mant_PersonaDataService();
        Mant_ContribuyenteDataService mant_ContribuyenteDataService = new Mant_ContribuyenteDataService();
        Mant_JuntaViaDataService mant_JuntaViaDataService = new Mant_JuntaViaDataService();
        private Sistema.Globales.Validaciones obValidacion = new Sistema.Globales.Validaciones();
        private List<Mant_Per_Cont> Coleccion;
        private SortOrder Orden = new SortOrder();
        private Mant_PeriodoDataService PeriodoDataService = new Mant_PeriodoDataService();
        private int periodo;
        public Frm_Contribuyent()
        {
            InitializeComponent();
            llenarTipoSector();
            rbtSeleccionado("rbtNDoc");
            periodo = PeriodoDataService.GetPeriodoActivo();
            lblPeriodo.Text = periodo.ToString();

        }
        private void rbtSeleccionado(string rbtselec)
        {
            //limpiarParaBusqueda();
            switch (rbtselec)
            {
                case "rbtNDoc":
                    txtNDocu.Enabled = true;
                    txtCodContribuyente.Enabled = false;
                    txtCodPredio.Enabled = false;
                    txtNomRazon.Enabled = false;
                    cboCalleB.Enabled = false;
                    cboSectorB.Enabled = false;
                    txtViaB.Enabled = false;
                    txtPisoB.Enabled = false;
                    txtTiendaB.Enabled = false;
                    txtInteriorB.Enabled = false;
                    txtManzanaB.Enabled = false;
                    txtEdificioB.Enabled = false;
                    txtDptoB.Enabled = false;
                    txtExpedienteB.Enabled = false;
                    txtLoteB.Enabled = false;
                    txtDireccionANtigua.Enabled = false;
                    //cboDepBusqueda.Enabled = false;
                    //cboProvBusqueda.Enabled = false;
                    //cboDistBusque.Enabled = false;
                    break;
                case "rbtCodContribuyente":
                    txtNDocu.Enabled = false;
                    txtCodContribuyente.Enabled = true;
                    txtCodPredio.Enabled = false;
                    txtNomRazon.Enabled = false;
                    cboCalleB.Enabled = false;
                    cboSectorB.Enabled = false;
                    txtViaB.Enabled = false;
                    txtPisoB.Enabled = false;
                    txtTiendaB.Enabled = false;
                    txtInteriorB.Enabled = false;
                    txtManzanaB.Enabled = false;
                    txtEdificioB.Enabled = false;
                    txtDptoB.Enabled = false;
                    txtExpedienteB.Enabled = false;
                    txtLoteB.Enabled = false;
                    txtDireccionANtigua.Enabled = false;
                    //cboDepBusqueda.Enabled = false;
                    //cboProvBusqueda.Enabled = false;
                    //cboDistBusque.Enabled = false;
                    break;
                case "rbtNombre":
                    txtNDocu.Enabled = false;
                    txtCodContribuyente.Enabled = false;
                    txtCodPredio.Enabled = false;
                    txtNomRazon.Enabled = true;
                    cboCalleB.Enabled = false;
                    cboSectorB.Enabled = false;
                    txtViaB.Enabled = false;
                    txtPisoB.Enabled = false;
                    txtTiendaB.Enabled = false;
                    txtInteriorB.Enabled = false;
                    txtManzanaB.Enabled = false;
                    txtEdificioB.Enabled = false;
                    txtDptoB.Enabled = false;
                    txtExpedienteB.Enabled = false;
                    txtLoteB.Enabled = false;
                    txtDireccionANtigua.Enabled = false;
                    //cboDepBusqueda.Enabled = false;
                    //cboProvBusqueda.Enabled = false;
                    //cboDistBusque.Enabled = false;
                    break;
                case "rbtDirección":
                    txtNDocu.Enabled = false;
                    txtCodContribuyente.Enabled = false;
                    txtCodPredio.Enabled = false;
                    txtNomRazon.Enabled = false;
                    cboCalleB.Enabled = true;
                    cboSectorB.Enabled = true;
                    txtViaB.Enabled = true;
                    txtPisoB.Enabled = true;
                    txtTiendaB.Enabled = true;
                    txtInteriorB.Enabled = true;
                    txtManzanaB.Enabled = true;
                    txtEdificioB.Enabled = true;
                    txtDptoB.Enabled = true;
                    txtExpedienteB.Enabled = false;
                    txtLoteB.Enabled = true;
                    txtDireccionANtigua.Enabled = false;
                    //cboSectorB.SelectedIndex = 0;
                    //cboCalleB.SelectedIndex = 0;
                    //cboDepBusqueda.Enabled = true;
                    //cboProvBusqueda.Enabled = true;
                    //cboDistBusque.Enabled = true;
                    break;
                case "rbtCPredio":
                    txtNDocu.Enabled = false;
                    txtCodContribuyente.Enabled = false;
                    txtCodPredio.Enabled = true;
                    txtNomRazon.Enabled = false;
                    cboCalleB.Enabled = false;
                    cboSectorB.Enabled = false;
                    txtViaB.Enabled = false;
                    txtPisoB.Enabled = false;
                    txtTiendaB.Enabled = false;
                    txtInteriorB.Enabled = false;
                    txtManzanaB.Enabled = false;
                    txtEdificioB.Enabled = false;
                    txtDptoB.Enabled = false;
                    txtExpedienteB.Enabled = false;
                    txtLoteB.Enabled = false;
                    txtDireccionANtigua.Enabled = false;
                    //cboDepBusqueda.Enabled = false;
                    //cboProvBusqueda.Enabled = false;
                    //cboDistBusque.Enabled = false;
                    break;
                case "rbtExpediente":
                    txtNDocu.Enabled = false;
                    txtCodContribuyente.Enabled = false;
                    txtCodPredio.Enabled = false;
                    txtNomRazon.Enabled = false;
                    cboCalleB.Enabled = false;
                    cboSectorB.Enabled = false;
                    txtViaB.Enabled = false;
                    txtPisoB.Enabled = false;
                    txtTiendaB.Enabled = false;
                    txtInteriorB.Enabled = false;
                    txtManzanaB.Enabled = false;
                    txtEdificioB.Enabled = false;
                    txtDptoB.Enabled = false;
                    txtExpedienteB.Enabled = true;
                    txtLoteB.Enabled = false;
                    txtDireccionANtigua.Enabled = false;
                    //cboDepBusqueda.Enabled = false;
                    //cboProvBusqueda.Enabled = false;
                    //cboDistBusque.Enabled = false;
                    break;
                case "rbtDreccionAntigua":
                    txtNDocu.Enabled = false;
                    txtCodContribuyente.Enabled = false;
                    txtCodPredio.Enabled = false;
                    txtNomRazon.Enabled = false;
                    cboCalleB.Enabled = false;
                    cboSectorB.Enabled = false;
                    txtViaB.Enabled = false;
                    txtPisoB.Enabled = false;
                    txtTiendaB.Enabled = false;
                    txtInteriorB.Enabled = false;
                    txtManzanaB.Enabled = false;
                    txtEdificioB.Enabled = false;
                    txtDptoB.Enabled = false;
                    txtExpedienteB.Enabled = false;
                    txtLoteB.Enabled = false;
                    txtDireccionANtigua.Enabled = true;
                    //cboDepBusqueda.Enabled = false;
                    //cboProvBusqueda.Enabled = false;
                    //cboDistBusque.Enabled = false;
                    break;

            }
        }
        public void llenarTipoSector()
        {
            //cargarCboIndividual(cboDepBusqueda, "Descripcion", "Ubicacion_id");
            //cboDepBusqueda.DataSource = conf_UbicacionDataService.GetDepartamentos();
            //cboDepBusqueda.SelectedValue = "13";
            //cargarCboIndividual(cboProvBusqueda, "Descripcion", "Ubicacion_id");
            //cboProvBusqueda.DataSource = conf_UbicacionDataService.GetProvincia("13%", 9);
            //cboProvBusqueda.SelectedValue = "1301";
            //cargarCboIndividual(cboDistBusque, "Descripcion", "Ubicacion_id");
            //cboDistBusque.DataSource = conf_UbicacionDataService.GetProvincia("1301%", 10);
            //cboDistBusque.SelectedValue = "130107";
            cargarCboIndividual(cboSectorB, "descripcion", "sector_id");
            cboSectorB.DataSource = pred_SectorDataService.listarSectorCbo(GlobalesV1.Global_int_idoficina);
            cboSectorB.SelectedIndex = 0;
            cargarCboIndividual(cboCalleB, "Descripcion", "Via_id");
            cboCalleB.DataSource = pred_ViasDataService.listarViasPorSector(cboSectorB.SelectedValue.ToString(), GlobalesV1.Global_int_idoficina);
            cboCalleB.SelectedIndex = 0;
            this.cboSectorB.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.cboSectorB.AutoCompleteSource = AutoCompleteSource.CustomSource;

            this.cboCalleB.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.cboCalleB.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        public void cargarCboIndividual(ComboBox cbo, String display, String value)
        {
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
        }
        private Mant_Per_Cont obtenerDatosParaModificar(Mant_Per_Cont mant_Per_Conta)
        {

            mant_Per_Conta.departamento = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["departamento"].Value;
            mant_Per_Conta.provincia = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["provincia"].Value;
            mant_Per_Conta.via_ID = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["via_ID"].Value;
            mant_Per_Conta.c_via = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["c_via"].Value;
            mant_Per_Conta.c_junta = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["c_junta"].Value;
            mant_Per_Conta.junta_ID = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["junta_ID"].Value;
            mant_Per_Conta.c_dpto = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["c_dpto"].Value;
            mant_Per_Conta.C_edificio = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["C_edificio"].Value;
            mant_Per_Conta.c_interior = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["c_interior"].Value;
            mant_Per_Conta.c_lote = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["c_lote"].Value;
            mant_Per_Conta.c_mz = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["c_mz"].Value;
            mant_Per_Conta.c_num = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["c_num"].Value;
            mant_Per_Conta.c_piso = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["c_piso"].Value;
            mant_Per_Conta.c_tienda = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["c_tienda"].Value;
            mant_Per_Conta.celular = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["celular"].Value;
            mant_Per_Conta.Contacto = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["Contacto"].Value;
            mant_Per_Conta.DireccRepresentante = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["DireccRepresentante"].Value;
            mant_Per_Conta.distrito = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["distrito"].Value;
            mant_Per_Conta.dniRepresentante = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["dniRepresentante"].Value;
            mant_Per_Conta.documento = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["documento"].Value;
            mant_Per_Conta.Dpto = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["Dpto"].Value;
            mant_Per_Conta.edificio = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["edificio"].Value;
            mant_Per_Conta.email = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["email"].Value;
            mant_Per_Conta.expediente = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["expediente"].Value;
            mant_Per_Conta.fechaNacimiento = (DateTime)dgvContribuyenteBuscados.SelectedRows[0].Cells["fechaNacimiento"].Value;
            mant_Per_Conta.Fono_Domicilio = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["Fono_Domicilio"].Value;
            mant_Per_Conta.fono_oficina = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["fono_oficina"].Value;
            mant_Per_Conta.interior = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["interior"].Value;
            mant_Per_Conta.junta_ID = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["junta_ID"].Value;
            mant_Per_Conta.Lote = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["Lote"].Value;
            mant_Per_Conta.materno = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["materno"].Value;
            mant_Per_Conta.mz = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["mz"].Value;
            mant_Per_Conta.nombres = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["nombres"].Value;
            mant_Per_Conta.num_via = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["num_via"].Value;
            mant_Per_Conta.paterno = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["paterno"].Value;
            mant_Per_Conta.persona_ID = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["persona_ID"].Value;
            mant_Per_Conta.piso = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["piso"].Value;
            mant_Per_Conta.referencia = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["referencia"].Value;
            mant_Per_Conta.tienda = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["tienda"].Value;
            mant_Per_Conta.tipo_documento = (Int16)dgvContribuyenteBuscados.SelectedRows[0].Cells["tipo_documento"].Value;
            mant_Per_Conta.tipo_persona = (Int16)dgvContribuyenteBuscados.SelectedRows[0].Cells["tipo_persona"].Value;
            mant_Per_Conta.via_ID = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["via_ID"].Value;
            mant_Per_Conta.Sexo = (string)dgvContribuyenteBuscados.SelectedRows[0].Cells["Sexo"].Value;
            mant_Per_Conta.jubilado = (bool)dgvContribuyenteBuscados.SelectedRows[0].Cells["jubilado"].Value;
            return mant_Per_Conta;
        }
        private void toolnuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_Contribuyente_Detalle Frm_Contribuyente_Detalle = new Frm_Contribuyente_Detalle();
                Frm_Contribuyente_Detalle.StartPosition = FormStartPosition.CenterParent;
                Frm_Contribuyente_Detalle.ShowDialog();
                btnBuscar.PerformClick();
                //Coleccion = mant_ContribuyenteDataService.listartodos();
                //dgvContribuyenteBuscados.DataSource = Coleccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }
        private void tooleditar_Click(object sender, EventArgs e)
        {
                         
           
           
            try
            {
                if (dgvContribuyenteBuscados.SelectedRows.Count > 0)
                {
                    Mant_Per_Cont mant_Per_Conta = new Mant_Per_Cont();
                    mant_Per_Conta = obtenerDatosParaModificar(mant_Per_Conta);
                    Frm_Contribuyente_Detalle Frm_Contribuyente_Detalle = new Frm_Contribuyente_Detalle(mant_Per_Conta);
                    Frm_Contribuyente_Detalle.StartPosition = FormStartPosition.CenterParent;
                    Frm_Contribuyente_Detalle.ShowDialog();
                    btnBuscar.PerformClick();
                    //Coleccion = mant_ContribuyenteDataService.listartodos();
                    //dgvContribuyenteBuscados.DataSource = Coleccion;
                }
                else
                    MessageBox.Show("Seleccione un elemento", Globales.Global_MessageBox);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }
        private string CambiarTexto(string txt)
        {
            if (txt.TrimEnd() == "")
                return "%";
            return txt.TrimEnd();
        }
        private void ss(String txt)
        {
            //String s = "aaaaabbbcccccccdd";
            //Char charRange = 'b';
            //int startIndex = s.IndexOf(charRange);
            //int endIndex = s.LastIndexOf(charRange);
            //int length = endIndex - startIndex + 1;
            //Console.WriteLine("{0}.Substring({1}, {2}) = {3}",
            //                  s, startIndex, length,
            //                  s.Substring(startIndex, length));
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (rbtNDoc.Checked)
            {
                //listarBuscados
                dgvContribuyenteBuscados.DataSource = mant_ContribuyenteDataService.listarBuscados('%' + txtNDocu.Text.Trim() + '%', 9, "ruc", GlobalesV1.Global_int_idoficina);
            }
            else if (rbtCodContribuyente.Checked)
            {
                dgvContribuyenteBuscados.DataSource = mant_ContribuyenteDataService.listarBuscados(txtCodContribuyente.Text.Trim(), 10, "persona_id", GlobalesV1.Global_int_idoficina);
            }
            else if (rbtNombre.Checked)
            {
                dgvContribuyenteBuscados.DataSource = mant_ContribuyenteDataService.listarBuscados(txtNomRazon.Text.TrimEnd(), 11, "razon_social", GlobalesV1.Global_int_idoficina);
            }
            else if (rbtExpediente.Checked)
            {
                dgvContribuyenteBuscados.DataSource = mant_ContribuyenteDataService.listarBuscados(txtExpedienteB.Text.Trim(), 13, "expedientebusqueda", GlobalesV1.Global_int_idoficina);

            }
            else if (rbtDirección.Checked)
            {
               int junv = 0;
               Mant_Contribuyente mant_Contribuyente1 = new Mant_Contribuyente();
                if(cboCalleB.SelectedIndex==-1 || cboSectorB.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione la calle y sector",Globales.Global_MessageBox);
                    return;
                }
               junv = mant_JuntaViaDataService.GetJuntaVia_id(int.Parse(cboSectorB.SelectedValue.ToString()), int.Parse(cboCalleB.SelectedValue.ToString()));
                                //if es tipo 15 
                                if (junv != 0)
                                    mant_Contribuyente1.ruc = junv.ToString();
                                else
                                    mant_Contribuyente1.ruc = "%";
                                //if cambio  a tipo 14 mant_Contribuyente1.Junta_via=junv
                                mant_Contribuyente1.c_dpto = CambiarTexto(txtDptoB.Text.TrimEnd());
                                mant_Contribuyente1.c_interior = CambiarTexto(txtInteriorB.Text.TrimEnd());
                                mant_Contribuyente1.c_lote = CambiarTexto(txtLoteB.Text.TrimEnd());
                                mant_Contribuyente1.c_mz = CambiarTexto(txtManzanaB.Text.TrimEnd());
                                mant_Contribuyente1.c_num = CambiarTexto(txtViaB.Text.TrimEnd());
                                mant_Contribuyente1.c_piso = CambiarTexto(txtPisoB.Text.TrimEnd());
                                mant_Contribuyente1.c_edificio = CambiarTexto(txtEdificioB.Text.TrimEnd());
                                mant_Contribuyente1.c_tienda = CambiarTexto(txtTiendaB.Text.TrimEnd());
                                dgvContribuyenteBuscados.DataSource = mant_ContribuyenteDataService.listarBuscadosxDireccion(mant_Contribuyente1, GlobalesV1.Global_int_idoficina);
          }
          else if (rbtCPredio.Checked)
          {
                dgvContribuyenteBuscados.DataSource = mant_ContribuyenteDataService.listarBuscadoxExpediente(txtCodPredio.Text.Trim(), 16, "codpredio", periodo);
          }
          else if (rbtDreccionAntigua.Checked)
            {
                dgvContribuyenteBuscados.DataSource = mant_ContribuyenteDataService.listarBuscadoxExpediente(txtDireccionANtigua.Text.TrimEnd(), 12, "OtraDireccion", periodo);
            }
        }
        //----
        private void dgvContribuyenteBuscados_DoubleClick(object sender, EventArgs e)
        {
            tooleditar.PerformClick();
        }
        private void dgvContribuyenteBuscados_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                DataGridViewColumn ColumnaOrdenar = dgvContribuyenteBuscados.Columns[e.ColumnIndex];

                if (dgvContribuyenteBuscados.SortOrder == SortOrder.None)
                {

                    if (ColumnaOrdenar.Name == "persona_ID")
                    {
                        if (Orden == SortOrder.Descending)
                        {
                            dgvContribuyenteBuscados.DataSource = Coleccion.OrderBy(p => p.persona_ID).ToList();
                            Orden = SortOrder.Ascending;
                        }
                        else
                        {
                            dgvContribuyenteBuscados.DataSource = Coleccion.OrderBy(p => p.persona_ID).Reverse().ToList();
                            Orden = SortOrder.Descending;
                        }
                    }
                    else if (ColumnaOrdenar.Name == "paterno")
                    {
                        if (Orden == SortOrder.Descending)
                        {
                            dgvContribuyenteBuscados.DataSource = Coleccion.OrderBy(p => p.paterno).ToList();
                            Orden = SortOrder.Ascending;
                        }
                        else
                        {
                            dgvContribuyenteBuscados.DataSource = Coleccion.OrderBy(p => p.paterno).Reverse().ToList();
                            Orden = SortOrder.Descending;
                        }

                    }
                    else if (ColumnaOrdenar.Name == "materno")
                    {
                        if (Orden == SortOrder.Descending)
                        {
                            dgvContribuyenteBuscados.DataSource = Coleccion.OrderBy(p => p.materno).ToList();
                            Orden = SortOrder.Ascending;
                        }
                        else
                        {
                            dgvContribuyenteBuscados.DataSource = Coleccion.OrderBy(p => p.materno).Reverse().ToList();
                            Orden = SortOrder.Descending;
                        }

                    }
                    else if (ColumnaOrdenar.Name == "nombres")
                    {
                        if (Orden == SortOrder.Descending)
                        {
                            dgvContribuyenteBuscados.DataSource = Coleccion.OrderBy(p => p.nombres).ToList();
                            Orden = SortOrder.Ascending;
                        }
                        else
                        {
                            dgvContribuyenteBuscados.DataSource = Coleccion.OrderBy(p => p.nombres).Reverse().ToList();
                            Orden = SortOrder.Descending;
                        }

                    }
                    else if (ColumnaOrdenar.Name == "documento")
                    {
                        if (Orden == SortOrder.Descending)
                        {
                            dgvContribuyenteBuscados.DataSource = Coleccion.OrderBy(p => p.documento).ToList();
                            Orden = SortOrder.Ascending;
                        }
                        else
                        {
                            dgvContribuyenteBuscados.DataSource = Coleccion.OrderBy(p => p.documento).Reverse().ToList();
                            Orden = SortOrder.Descending;
                        }

                    }
                    else if (ColumnaOrdenar.Name == "direccCompleta")
                    {
                        if (Orden == SortOrder.Descending)
                        {
                            dgvContribuyenteBuscados.DataSource = Coleccion.OrderBy(p => p.direccCompleta).ToList();
                            Orden = SortOrder.Ascending;
                        }
                        else
                        {
                            dgvContribuyenteBuscados.DataSource = Coleccion.OrderBy(p => p.direccCompleta).Reverse().ToList();
                            Orden = SortOrder.Descending;
                        }

                    }
                }

            }
        }

        private void cboDepBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cboProvBusqueda.DataSource = conf_UbicacionDataService.GetProvincia(cboDepBusqueda.SelectedValue.ToString() + "%", 9);
        }

        private void cboProvBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cboDistBusque.DataSource = conf_UbicacionDataService.GetProvincia(cboProvBusqueda.SelectedValue.ToString() + "%", 10);
        }

        private void cboSectorB_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCalleB.DataSource = pred_ViasDataService.listarViasPorSector(cboSectorB.SelectedValue.ToString(), GlobalesV1.Global_int_idoficina);

            //this.cboSectorB.AutoCompleteMode = AutoCompleteMode.Suggest;
            //this.cboSectorB.AutoCompleteSource = AutoCompleteSource.CustomSource;

            this.cboCalleB.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.cboCalleB.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void rbtNDoc_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtNDoc.Checked)
            {
                rbtSeleccionado("rbtNDoc");
            }
        }

        private void rbtCodContribuyente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtCodContribuyente.Checked)
            {
                rbtSeleccionado("rbtCodContribuyente");
            }
        }

        private void rbtNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtNombre.Checked)
            {
                rbtSeleccionado("rbtNombre");
            }
        }

        private void rbtDirección_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtDirección.Checked)
            {
                rbtSeleccionado("rbtDirección");
            }
        }

        private void rbtExpediente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtExpediente.Checked)
            {
                rbtSeleccionado("rbtExpediente");
            }
        }

        private void rbtCPredio_CheckedChanged(object sender, EventArgs e)
        {

            if (rbtCPredio.Checked)
            {
                rbtSeleccionado("rbtCPredio");
            }

        }

        private void rbtDreccionAntigua_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtDreccionAntigua.Checked)
            {
                rbtSeleccionado("rbtDreccionAntigua");
            }
        }

        private void txtNDocu_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    btnBuscar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtCodContribuyente_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    btnBuscar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtNomRazon_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    btnBuscar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtExpedienteB_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    btnBuscar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtCodPredio_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    btnBuscar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtDireccionANtigua_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    btnBuscar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
             try
            {
                if (dgvContribuyenteBuscados.SelectedRows.Count > 0)
                {
                    ///*mant_P*/er_Conta.tipo_persona = (Int16)dgvContribuyenteBuscados.SelectedRows[0].Cells["tipo_persona"].Value;

                    String perso = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["persona_ID"].Value;
                    Int16 tipo_persona = (Int16)dgvContribuyenteBuscados.SelectedRows[0].Cells["tipo_persona"].Value;
                    String paterno = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["paterno"].Value;
                    String materno = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["materno"].Value;
                    String nombres = (String)dgvContribuyenteBuscados.SelectedRows[0].Cells["nombres"].Value;
                    Frm_Relacion_Contribuyente frm_Relacion_Contribuyente = new Frm_Relacion_Contribuyente(perso, paterno + " " + materno + " " + nombres);//8832
                    frm_Relacion_Contribuyente.StartPosition = FormStartPosition.CenterParent;
                    frm_Relacion_Contribuyente.ShowDialog();
                }
                else
                    MessageBox.Show("Seleccione un elemento", Globales.Global_MessageBox);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Globales.Global_MessageBox);
            }
        }
    }
}
