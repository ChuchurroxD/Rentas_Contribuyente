using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Core.Repository;
using SGR.Entity.Model;

namespace SGR.Core.Service
{
    public class Mant_DepreciacionDataService
    {
        Mant_DepreciacionRepository Mant_DepreciacionRepository = new Mant_DepreciacionRepository();
        Conf_MultitablaRepository Conf_MultitablaRepository = new Conf_MultitablaRepository();

        public void insert(Mant_Depreciacion Mant_Depreciacion)     
        {
            try
            {
                if (Mant_DepreciacionRepository.compararDepreciaciones(Mant_Depreciacion) > 0)
                    throw new Exception("Depreciación Repetido");
                Mant_DepreciacionRepository.Insert(Mant_Depreciacion);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void update(Mant_Depreciacion Mant_Depreciacion)
        {
            try
            {
                if (Mant_DepreciacionRepository.compararDepreciacionesModificar(Mant_Depreciacion) > 0)
                    throw new Exception("Depreciación Repetido");
                Mant_DepreciacionRepository.Update(Mant_Depreciacion);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Mant_Depreciacion> listartodo()
        {
            try
            {
                return Mant_DepreciacionRepository.listartodos();
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



        public List<Mant_Depreciacion> listartodoClasificacion(Int32 periodo, Int32 clasificacion)
        {
            try
            {
                return Mant_DepreciacionRepository.listartodoClasificacion(periodo, clasificacion);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Mant_Depreciacion> getColeccion(string where, string orderby)
        {
            try
            {
                return Mant_DepreciacionRepository.Getcoleccion(where, orderby);
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void deletebyid(int depreciacion_id)
        {
            try
            {
                Mant_DepreciacionRepository.DeleteByPrimaryKey(depreciacion_id);
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Conf_Multitabla> llenarClasificacion()
        {
            return Conf_MultitablaRepository.listarCbo("20");
        }
        public List<Conf_Multitabla> llenarMaterial()
        {
            return Conf_MultitablaRepository.listarCbo("21");
        }
        public List<Conf_Multitabla> llenarEstadoPiso()
        {
            return Conf_MultitablaRepository.listarCbo("22");
        }
        public List<Conf_Multitabla> llenarAntiguedad()
        {
            return Conf_MultitablaRepository.listarCbo("71");
        }
        public List<Mant_Periodo> llenarPeriodo()
        {
            try
            {
                Mant_PeriodoDataService Mant_PeriodoDataService = new Mant_PeriodoDataService();
                return Mant_PeriodoDataService.llenarPeriodo();
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Mant_Depreciacion> listarErroresDepreciacion(Int32 periodo)
        {
            try
            {
                return Mant_DepreciacionRepository.listarErroresDepreciacion(periodo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Mant_Depreciacion> listarDepreciaciones(Int16 anio, Int16 clasificacion)
        {
            return Mant_DepreciacionRepository.listarDepreciaciones(anio, clasificacion);
        }

        public List<Mant_Depreciacion> listarTodasDepreciaciones(Int16 anio)
        {
            return Mant_DepreciacionRepository.listarTodasDepreciaciones(anio);
        }
    }
}
