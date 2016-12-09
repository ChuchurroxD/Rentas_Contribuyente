using SGR.Core.Repository;
using SGR.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Core.Service
{
    public class Repo_PlanillaIngresosDataService
    {
        Repo_PlanillaIngresosRepository repo_PlanillaIngresosRepository = new Repo_PlanillaIngresosRepository();

        public List<Repo_PlanillaIngresos> listarPorOficina(Int32 oficina_id)
        {
            try
            {
                return repo_PlanillaIngresosRepository.listarPorOficina(oficina_id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Repo_PlanillaIngresos> listarPorFechaDesdeHasta(string FechaDesde, string FechaHasta, int oficina_id)
        {
            try
            {
                return repo_PlanillaIngresosRepository.listarPorFechaDesdeHasta(FechaDesde, FechaHasta, oficina_id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Repo_PlanillaIngresos> listarPorFechaDesdeHastaContribuyente(string FechaDesde, string FechaHasta, int oficina_id, string persona_id)
        {
            try
            {
                return repo_PlanillaIngresosRepository.listarPorFechaDesdeHastaContribuyente(FechaDesde, FechaHasta, oficina_id, persona_id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        

        public List<Repo_PlanillaIngresos> listarResumenPorDia(string FechaDesde, string FechaHasta)
        {
            try
            {
                return repo_PlanillaIngresosRepository.listarResumenPorDia(FechaDesde, FechaHasta);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Repo_PlanillaIngresos> listarResumenPorDiaConcepto(string FechaDesde, string FechaHasta, string concepto)
        {
            try
            {
                return repo_PlanillaIngresosRepository.listarResumenPorDiaConcepto(FechaDesde, FechaHasta, concepto);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Repo_PlanillaIngresos> listarResumenPorDevolucion(string FechaDesde, string FechaHasta)
        {
            try
            {
                return repo_PlanillaIngresosRepository.listarResumenPorDevolucion(FechaDesde, FechaHasta);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Repo_PlanillaIngresos> listarResumenPorDevolucionPlanilla(string FechaDesde, string FechaHasta, string Concepto)
        {
            try
            {
                return repo_PlanillaIngresosRepository.listarResumenPorDevolucionPlanilla(FechaDesde, FechaHasta, Concepto);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Repo_PlanillaIngresos> listarResumenPorPartida(string FechaDesde, string FechaHasta)
        {
            try
            {
                return repo_PlanillaIngresosRepository.listarResumenPorPartida(FechaDesde, FechaHasta);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Repo_PlanillaIngresos> listarResumenPorPartidaPlanilla(string FechaDesde, string FechaHasta, string Concepto)
        {
            try
            {
                return repo_PlanillaIngresosRepository.listarResumenPorPartidaPlanilla(FechaDesde, FechaHasta, Concepto);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
