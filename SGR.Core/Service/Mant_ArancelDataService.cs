using SGR.Core.Repository;
using SGR.Entity;
using SGR.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Core.Service
{
    public class Mant_ArancelDataService
    {
        Mant_ArancelRepository mant_ArancelRepository = new Mant_ArancelRepository();

        public List<Mant_Arancel> listarTodos(int anio)
        {
            return mant_ArancelRepository.listarTodos(anio);
        }
        public List<Mant_Arancel> listarTodosPorSector(int Sector_id,int anio)
        {
            return mant_ArancelRepository.listarTodosPorsector(Sector_id,anio);
        }

        public List<Mant_Arancel> listarTodosPorVia(String Via_id,int anio)
        {
            return mant_ArancelRepository.listarTodosPorVia(Via_id,anio);
        }

        public List<Mant_Arancel> listarTodosPorSectorAñoVia(int anio, int Sector_id,String Via_id)
        {
            return mant_ArancelRepository.listarTodosPorSectorAñoVia(anio, Sector_id, Via_id);
        }
        public void insertarArancel(Mant_Arancel mant_Arancel)
        {
            mant_ArancelRepository.Insert(mant_Arancel);
        }

        public void updateArancel(Mant_Arancel mant_Arancel)
        {
            mant_ArancelRepository.Update(mant_Arancel);
        }

        public virtual int ExisteElementosPeriodoAnterior(int tipoConsulta)
        {
            try
            {
                return mant_ArancelRepository.ExisteElementosPeriodoAnterior(tipoConsulta);
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
                mant_ArancelRepository.CopiarElementosPeriodoAnterior(ussr);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void deletebyprimarykey(int arancel_ID)
        {
            mant_ArancelRepository.DeleteByPrimaryKey(arancel_ID);
        }

        public List<Mant_Periodo> llenarAnio()
        {
            try
            {
                Mant_PeriodoRepository Mant_PeriodoRepository = new Mant_PeriodoRepository();
                return Mant_PeriodoRepository.llenarPeriodo();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pred_Sector> llenarSector(int oficina)
        {
            try
            {
                Pred_SectorRespository pred_SectorRespository = new Pred_SectorRespository();
                return pred_SectorRespository.listarSectorCbo(oficina);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public decimal GetMonto(int idjuntavia, int anio,int lado, int cuadra)
        {
            return mant_ArancelRepository.GetMonto(idjuntavia, anio,lado,cuadra); 
        }

        public virtual Int32 GetExisteArancelNuevo(Int32 anio, Int32 cuadra, Int32 lado, Int32 sector_id, String via_id)
        {
            return mant_ArancelRepository.GetExisteArancelNuevo(anio, cuadra, lado, sector_id, via_id);
        }

        public virtual Int32 GetExisteArancelModificar(Int32 anio, Int32 cuadra, Int32 lado, Int32 sector_id, String via_id, Int32 arancel_id)
        {
            return mant_ArancelRepository.GetExisteArancelModificar(anio, cuadra, lado, sector_id, via_id, arancel_id);
        }
    }
}
