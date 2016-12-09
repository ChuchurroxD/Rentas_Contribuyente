using SGR.Core.Repository;
using SGR.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Core.Service
{
    public class Rep_EstadisticosDataService
    {
        Rep_EstadisticosRepository rep_EstadisticosRepository = new Rep_EstadisticosRepository();
        public List<Rep_Estadistico1> ReporteCuentaCorrienteAño(Int32 anio)
        {
            try
            {
                return rep_EstadisticosRepository.ReporteCuentaCorrienteAño(anio);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Rep_Estadistico1> ReporteSaldosCoactivo(Int32 anio)
        {
            try
            {
                return rep_EstadisticosRepository.ReporteSaldosCoactivo(anio);  
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Rep_Estadistico1> ReporteSaldosCoactivoAbono(Int32 anio)
        {
            try
            {
                return rep_EstadisticosRepository.ReporteSaldosCoactivoAbono(anio);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Rep_Estadistico1> ReporteCuentaCorrienteTotal(Int32 anio)
        {
            try
            {
                return rep_EstadisticosRepository.ReporteCuentaCorrienteTotal(anio);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Rep_Estadistico1> ReporteCuentaCorrienteMeses(Int32 anio, Int32 mes1, Int32 mes2)
        {
            try
            {
                return rep_EstadisticosRepository.ReporteCuentaCorrienteMeses(anio, mes1, mes2);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Repo_estadistico2> ReportePagosMesComparado(Int32 anio1, Int32 mes1, Int32 anio2, Int32 mes2)
        {
            try
            {
                return rep_EstadisticosRepository.ReportePagosMesComparado(anio1, mes1, anio2, mes2);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public List<Rep_Estadistico1> ReporteCuentaCorrienteMesesTotal(Int32 anio, Int32 mes1, Int32 mes2)
        {
            try
            {
                return rep_EstadisticosRepository.ReporteCuentaCorrienteMesesTotal(anio, mes1, mes2);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
