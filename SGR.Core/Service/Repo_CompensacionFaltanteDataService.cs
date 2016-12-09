using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity;
using SGR.Core.Repository;
using SGR.Entity.Model;

namespace SGR.Core.Service
{
    public class Repo_CompensacionFaltanteDataService
    {
        Repo_CompensacionFaltanteRepository repo_CompensacionFaltanteRepository = new Repo_CompensacionFaltanteRepository();

        public List<Repo_CompensacionFaltante> listarCompensacionesFaltantes(Int32 anio)
        {
            return repo_CompensacionFaltanteRepository.listarCompensacionesFaltantes(anio);
        }

        public List<Repo_CompensacionFaltante> buscar(Int32 anio, string busqueda)
        {
            return repo_CompensacionFaltanteRepository.buscar(anio, busqueda);
        }
    }
}
