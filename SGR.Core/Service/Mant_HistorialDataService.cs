using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity;
using SGR.Entity.Model;
using SGR.Core.Repository;

namespace SGR.Core.Service
{
    public class Mant_HistorialDataService
    {
        private static Mant_HistorialRepository mant_HistorialRepository = new Mant_HistorialRepository();
        Mant_PeriodoDataService mant_PeriodoDataService = new Mant_PeriodoDataService();

        public List<Mant_Historial> listartodos(Int32 tipo, string idPersona, Int32 idPeriodo)
        {
            try
            {
                return mant_HistorialRepository.listartodos(tipo, idPersona, idPeriodo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual Mant_Historial GetByPrimaryKey()
        {
            try
            {
                return mant_HistorialRepository.GetByPrimaryKey();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Mant_Historial> Getcoleccion(string wheresql, string orderbysql)
        {
            try
            {
                return mant_HistorialRepository.Getcoleccion(wheresql, orderbysql);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual int Insert(Mant_Historial mant_Historial)
        {
            try
            {
                return mant_HistorialRepository.Insert(mant_Historial);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual void Update(Mant_Historial mant_Historial)
        {
            try
            {
                mant_HistorialRepository.Update(mant_Historial);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
