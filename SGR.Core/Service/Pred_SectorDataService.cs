using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Core.Repository;
using SGR.Entity;
using SGR.Entity.Model;

namespace SGR.Core.Service
{
    public class Pred_SectorDataService
    {
        private static Pred_SectorRespository Pred_SectorRepository = new Pred_SectorRespository();

        public List<Pred_Sector> listarTodos()
        {
            return Pred_SectorRepository.listarTodos();
        }

        public List<Pred_Sector> Getcoleccion(string whereSQL ,string  orderbySQL)
        {
            return Pred_SectorRepository.Getcoleccion (whereSQL , orderbySQL, 0,0,0);

        }
        public void insertarSector(Pred_Sector pred_Sector)
        {
            try
            {
                if (Pred_SectorRepository.compararDescripcion(pred_Sector.descripcion) > 0)
                    throw new Exception("Ingrese otra descripción , descripción repetida");
                Pred_SectorRepository.Insert(pred_Sector);
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void updateSector(Pred_Sector pred_Sector)
        {
            if (Pred_SectorRepository.compararDescripcionModificar(pred_Sector.descripcion, pred_Sector.sector_id) > 0)
                throw new Exception("Ingrese otra descripción, descripción repetida");
            Pred_SectorRepository.Update(pred_Sector);
        }
        public void deletebyprimarykey(int sector_id)
        {
            Pred_SectorRepository.DeleteByPrimaryKey(sector_id);
        }
        public List<Pred_TipoSector> llenarTipoSector()
        {
            return Pred_SectorRepository.llenarTipoSector();
        }
        public List<Pred_Sector> listarSectorCbo(int oficina)
        {
            return Pred_SectorRepository.listarSectorCbo(oficina);
        }
        public List<Pred_Sector> listarSectorCbo()
        {
            return Pred_SectorRepository.listarSectorCbo();
        }
        public List<Pred_Sector> listarSectorCboValidos()
        {
            return Pred_SectorRepository.listarSectorCboValidos();
        }
    }
}
