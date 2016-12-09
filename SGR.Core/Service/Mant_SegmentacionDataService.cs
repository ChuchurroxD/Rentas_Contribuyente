using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity.Model;
using SGR.Core.Repository;
namespace SGR.Core.Service
{
    public class Mant_SegmentacionDataService
    {
        private static Mant_SegmentacionRepository Mant_SegmentacionRepository = new Mant_SegmentacionRepository();
        public List<Mant_Segmentacion> listartodos(String periodo)
        {
            try
            {
                return Mant_SegmentacionRepository.listartodos(periodo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

       

        public virtual int Insert(Mant_Segmentacion Mant_Segmentacion)
        {
            try
            {
                return Mant_SegmentacionRepository.Insert(Mant_Segmentacion);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual void Update(Mant_Segmentacion Mant_Segmentacion)
        {
            try
            {
                Mant_SegmentacionRepository.Update(Mant_Segmentacion);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual int ExisteElementosPeriodoAnterior(int tipoConsulta)
        {
            try
            {
                return Mant_SegmentacionRepository.ExisteElementosPeriodoAnterior(tipoConsulta);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void CopiarElementosPeriodoAnterior(string ussr)
        {
            try
            {
                Mant_SegmentacionRepository.CopiarElementosPeriodoAnterior(ussr);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
