using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Core.Repository;
using SGR.Entity.Model;
using SGR.Entity;

namespace SGR.Core.Service
{
    public class Pred_TributoDataService
    {
        private static Pred_TributoRepository Pred_TributoRepository = new Pred_TributoRepository();

        public List<Pred_Tributo> listarTodos(int anio)
        {
            try
            {
                return Pred_TributoRepository.listartodos(anio);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void insertarTributo(Pred_Tributo Pred_Tributo)
        {
            try
            {
                if (Pred_TributoRepository.compararDescripcion(Pred_Tributo.descripcion) > 0)
                    throw new Exception("Ingrese una descripcion diferente, descripcion igual");
                if (Pred_TributoRepository.compararCodigo(Pred_Tributo.tributos_ID) > 0)
                    throw new Exception("Ingrese un codigo diferente, codigo repetido");
               Pred_TributoRepository.Insert(Pred_Tributo);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void modificarTributo(Pred_Tributo Pred_Tributo)
        {
            try
            {
                if (Pred_TributoRepository.compararDescripcionModificar(Pred_Tributo.descripcion, Pred_Tributo.tributos_ID) > 0)
                    throw new Exception("Ingrese una descripcion diferente, descripcion igual");
                Pred_TributoRepository.Update(Pred_Tributo);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pred_Tributo> getColeccion(string whereSQL, string orderbySQL,string anio)
        {
            return Pred_TributoRepository.Getcoleccion(whereSQL, orderbySQL, 0, 0, 0,anio);
        }

        public void deleteByPrimary(string codigo)
        {
            try
            {
                Pred_TributoRepository.DeleteByPrimaryKey(codigo);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //public List<Pred_Tributo> GetALL()
        //{
        //    try
        //    {
        //        return Pred_TributoRepository.GetALL();
        //    }catch(Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}
        public List<Conf_Multitabla> llenarcomboTipoTributo()
        {
            try
            {
                Conf_MultitablaRepository Conf_MultitablaRepository = new Conf_MultitablaRepository();
                return Conf_MultitablaRepository.listarCbo("1");
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Trib_ClasificadorIngresos> llenarcomboClasificadorIngresos(string anio)
        {
            try
            {
                Trib_ClasificadorIngresosRepository Trib_ClasificadorIngresosRepository = new Trib_ClasificadorIngresosRepository();
                return Trib_ClasificadorIngresosRepository.llenarComboEnTributo(anio);
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Mant_Periodo> llenarPeriodo()
        {
            try
            {
                Mant_PeriodoRepository Mant_PeriodoRepository = new Mant_PeriodoRepository();
                return Mant_PeriodoRepository.llenarPeriodo();
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pred_Tributo> listarTributoCbo()
        {
            try
            {
                return Pred_TributoRepository.listarTributoCbo();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //listarTributoParaExoneracion
        public List<Pred_Tributo> listarTributoParaExoneracion(String predio)
        {
            try
            {
                return Pred_TributoRepository.listarTributoParaExoneracion(predio);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pred_Tributo> listarTributoTipo1y2(String anioIni, String anioFin, String mesIni, String mesFin)
        {
            try
            {
                return Pred_TributoRepository.listarTributoTipo1y2(anioIni, anioFin, mesIni, mesFin);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Liqu_TributosAfectos> listarTributoCbov2(string persona)
        {
            try
            {
                return Pred_TributoRepository.listarTributoCbov2(persona);
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pred_Tributo> listarTRibuto1y2Edit()
        {
            try
            {
                return Pred_TributoRepository.listarTRibuto1y2Edit();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pred_Tributo> listarTributoporFraccionamiento(Int32 fraccionamiento_ID)
        {
            try
            {
                return Pred_TributoRepository.listarTributosFraccionamiento(fraccionamiento_ID);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
