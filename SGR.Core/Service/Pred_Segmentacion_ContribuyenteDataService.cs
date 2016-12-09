using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Core.Repository;
using SGR.Entity;
using SGR.Entity.Model;
namespace SGR.Core.Service
{
    public class Pred_Segmentacion_ContribuyenteDataService
    {
        private static Pred_Segmentacion_ContribuyenteRepository Pred_Segmentacion_ContribuyenteRepository = new Pred_Segmentacion_ContribuyenteRepository();
        public List<Pred_Segmentacion_Contribuyente> listartodos(string tipo, string perio)
        {
            try
            {
                return Pred_Segmentacion_ContribuyenteRepository.listartodos(tipo,perio);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual int Insert(Pred_Segmentacion_Contribuyente segmentacion_contribuyente)
        {
            try
            {
                return Pred_Segmentacion_ContribuyenteRepository.Insert(segmentacion_contribuyente);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual void Update(Pred_Segmentacion_Contribuyente segmentacion_contribuyente)
        {
            try
            {
                Pred_Segmentacion_ContribuyenteRepository.Update(segmentacion_contribuyente);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void Segmentar(String periodo_id, string tipo,string usuario)
        {
            try
            {
                Pred_Segmentacion_ContribuyenteRepository.Segmentar(periodo_id, tipo,usuario);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
