using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity.Model;
using SGR.Core.Repository;

namespace SGR.Core.Service
{
    public class Coa_coactivo_ctaDataService
    {
        Coa_coactivo_ctaRepository Coa_coactivo_ctaRepository = new Coa_coactivo_ctaRepository();
        public List<Coa_coactivo_cta> listartodos(int anio, string cadena, string codigo)
        {
            try
            {
                return Coa_coactivo_ctaRepository.listartodos(anio, cadena, codigo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Coa_coactivo_cta> listarTodosPorContribuyente(string persona_id)
        {
            try
            {
                return Coa_coactivo_ctaRepository.listarTodosPorContribuyente(persona_id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Coa_coactivo_cta> listarPorContribuyenteAnio(string persona_id, Int16 anio)
        {
            try
            {
                return Coa_coactivo_ctaRepository.listarPorContribuyenteAnio(persona_id, anio);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
