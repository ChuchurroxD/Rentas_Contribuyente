using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity;
using SGR.Entity.Model;

namespace SGR.Core.Service
{
    public class Mant_JuntaViaDataService
    {
        private static Mant_JuntaViaRepository Mant_JuntaViaRepository = new Mant_JuntaViaRepository();


        public int GetJuntaVia_id(int junta, int via)
        {
            return Mant_JuntaViaRepository.GetJuntaVia(junta, via);
        }
        public List<Mant_Junta_Via> listartodos()
        {
            try
            {
                return Mant_JuntaViaRepository.listartodos();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Mant_Junta_Via> getColeccion(string where, string order)
        {
            try
            {
                return Mant_JuntaViaRepository.Getcoleccion(where, order);
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void insert(Mant_Junta_Via Mant_Junta_Via)
        {
            try
            {
                if (Mant_JuntaViaRepository.compararSectorJuntaVia(Mant_Junta_Via.via_ID, Mant_Junta_Via.junta_ID) > 0)
                    throw new Exception("El sector ya ha sido asignado a esta junta Via");
                Mant_JuntaViaRepository.Insert(Mant_Junta_Via);
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void update(Mant_Junta_Via Mant_Junta_Via)
        {
            try
            {
                if (Mant_JuntaViaRepository.compararSectorViaModificar(Mant_Junta_Via.junta_via_ID,Mant_Junta_Via.via_ID, Mant_Junta_Via.junta_ID) > 0)
                    throw new Exception("El sector ya ha sido asignado a esta junta Via");
                Mant_JuntaViaRepository.Update(Mant_Junta_Via);
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pred_Sector> llenarCombosector(int oficina)
        {
            try
            {
                Pred_SectorDataService sector = new Pred_SectorDataService();
                return sector.listarSectorCbo(oficina);
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pred_Vias> llenarComboVia()
        {
            try
            {
                Pred_ViasDataService vias = new Pred_ViasDataService();
                return vias.listarViasCbo();
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

