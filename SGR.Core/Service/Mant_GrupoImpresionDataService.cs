using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity.Model;
using SGR.Core.Repository;

namespace SGR.Core.Service
{
    public class Mant_GrupoImpresionDataService
    {
        private Mant_GrupoImpresionRepository Mant_GrupoImpresionRepository = new Mant_GrupoImpresionRepository();
        public List<Mant_GrupoImpresion> listartodos()
        {
            try
            {
                return Mant_GrupoImpresionRepository.listartodos();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void insertar(Mant_GrupoImpresion Mant_GrupoImpresion)
        {
            try
            {
                Mant_GrupoImpresionRepository.Insert(Mant_GrupoImpresion);
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void update(Mant_GrupoImpresion Mant_GrupoImpresion)
        {
            try
            {
                Mant_GrupoImpresionRepository.Update(Mant_GrupoImpresion);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Mant_GrupoImpresion> getColeccion(string where, string order)
        {
            try
            {
                return Mant_GrupoImpresionRepository.Getcoleccion(where, order);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pred_Tributo> listarTributoporGrupoImpresion(string grupoTipoImpresion,Int32 periodo , string tipo_tributo)
        {
            try
            {
                return Mant_GrupoImpresionRepository.listarTributoporGrupoTipoImpresion(grupoTipoImpresion,periodo,tipo_tributo);
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Conf_Multitabla> listarGrupoTipoImpresion()
        {
            try
            {
                Conf_MultitablaDataService Conf_MultitablaDataService = new Conf_MultitablaDataService();
                return Conf_MultitablaDataService.GetCboConf_Multitabla("77");
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Mant_Periodo> listarPeriodo()
        {
            try
            {
                Mant_PeriodoDataService Mant_PeriodoDataService = new Mant_PeriodoDataService();
                return Mant_PeriodoDataService.llenarPeriodo();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
