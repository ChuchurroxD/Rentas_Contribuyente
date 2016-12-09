
using SGR.Core.Repository;
using SGR.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Core.Service
{
    public class Repo_FacturadoCobradoDataService
    {
        Repo_FacturadoCobradoRepository repo_FacturadoCobradoRepository = new Repo_FacturadoCobradoRepository();
        public List<Repo_FacturadoCobrado> ListarFacturadoCobrado(Int32 anio, Int32 mes, Int32 mesFin, Int32 oficina_id)
        {
            try
            {
               return repo_FacturadoCobradoRepository.ListarFacturadoCobrado(anio,mes, mesFin, oficina_id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
