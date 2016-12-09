using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity;
using SGR.Core.Repository;

namespace SGR.Core.Service
{
    public class Repo_PorcentajePrediosDataService
    {
        Repo_PorcentajePrediosRepository repo_PorcentajePrediosRepository = new Repo_PorcentajePrediosRepository();

        public List<Repo_PorcentajePredios> listarPorcentaje(Int32 anioDesde, Int32 anioHasta)
        {
            return repo_PorcentajePrediosRepository.listarPorcentaje(anioDesde, anioHasta);
        }

        public List<Repo_PorcentajePredios> listarPorcentaje2(Int32 anioDesde, Int32 anioHasta)
        {
            return repo_PorcentajePrediosRepository.listarPorcentaje2(anioDesde, anioHasta);
        }
    }
}
