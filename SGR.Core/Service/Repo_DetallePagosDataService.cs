using SGR.Core.Repository;
using SGR.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Core.Service
{
    public class Repo_DetallePagosDataService
    {
        Repo_DetallePagosRepository repo_DetallePagosRepository = new Repo_DetallePagosRepository();
        public List<Repo_DetallePagos> ListarDetallePagos(string FechaPagoDesde, string FechaPagoHasta,Int32 Caja_id)
        {
            try
            {
                return repo_DetallePagosRepository.ListarDetallePagos(FechaPagoDesde,FechaPagoHasta, Caja_id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Repo_DetallePagos> listarPorCaja(Int32 Caja_id)
        {
            try
            {
                return repo_DetallePagosRepository.listarPorCaja(Caja_id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
