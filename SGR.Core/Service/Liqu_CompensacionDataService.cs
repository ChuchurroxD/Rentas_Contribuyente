using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity;
using SGR.Entity.Model;
using SGR.Core.Repository;

namespace SGR.Core.Service
{
    public class Liqu_CompensacionDataService
    {
        private static Liqu_CompensacionRepository liqu_CompensacionRepository = new Liqu_CompensacionRepository();

        public virtual int Insert(Liqu_Compensacion liqu_Compensacion)
        {
            return liqu_CompensacionRepository.Insert(liqu_Compensacion);
        }

        public virtual int Insert_Detalle1(int compensacion_id, String persona_id, String tributos_id, Int16 anio, Int16 mes, string predio_id)
        {
            return liqu_CompensacionRepository.Insert_Detalle1(compensacion_id, persona_id, tributos_id, anio, mes, predio_id);
        }

        public virtual int Insert_Detalle2(int compensacion_id, String persona_id, String tributos_id, Int16 anio, Int16 mes, Decimal montoCompensar, string predio_id)
        {
            return liqu_CompensacionRepository.Insert_Detalle2(compensacion_id, persona_id, tributos_id, anio, mes, montoCompensar, predio_id);
        }

        public List<Liqu_Compensacion> listartodos(String persona_id)
        {
            return liqu_CompensacionRepository.listartodos(persona_id);
        }

        public List<Liqu_CompensacionDetalle> listarDetallePositivos(string persona_id, string predio_id, string tributos_id)
        {
            return liqu_CompensacionRepository.listarDetallePositivos(persona_id, predio_id, tributos_id);
        }

        public List<Liqu_CompensacionDetalle> listarDetalleNegativos(string persona_id, string predio_id, string tributos_id)
        {
            return liqu_CompensacionRepository.listarDetalleNegativos(persona_id, predio_id, tributos_id);
        }

        public decimal montoCompensar(string persona_id, string predio_id, string tributos_id)
        {
            return liqu_CompensacionRepository.montoCompensar(persona_id, predio_id, tributos_id);
        }
        public virtual int compensarNegativos(string persona, string tributo_id, string predio_id, decimal montoCompensar, decimal montoResultante)
        {
            return liqu_CompensacionRepository.compensarNegativos(persona, tributo_id, predio_id, montoCompensar, montoResultante);
        }

        public List<Liqu_Compensacion> listarCompensaciones(String persona_id)
        {
            return liqu_CompensacionRepository.listarCompensaciones(persona_id);
        }

        public List<Liqu_Compensacion> listarCompensacionesDetalle(Int32 compensacion_id)
        {
            return liqu_CompensacionRepository.listarCompensacionesDetalle(compensacion_id);
        }

        public virtual int compensarFaltantes(string persona, string tributo_id, string predio_id, decimal montoCompensar, decimal montoResultante)
        {
            return liqu_CompensacionRepository.compensarFaltantes(persona, tributo_id, predio_id, montoCompensar, montoResultante);
        }

        public decimal montoFaltante(string persona_id, string predio_id, string tributos_id)
        {
            return liqu_CompensacionRepository.montoFaltante(persona_id, predio_id, tributos_id);
        }

        public virtual int insertarCompensacionFaltante(Liqu_Compensacion liqu_Compensacion, decimal montoResultante)
        {
            return liqu_CompensacionRepository.insertarCompensacionFaltante(liqu_Compensacion, montoResultante);
        }
    }
}
