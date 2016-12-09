using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity.Model;
using SGR.Core.Repository;

namespace SGR.Core.Service
{
    public class Repo_GerencialDataService
    {
        private static Repo_GerencialRepository repo_GerencialRepository = new Repo_GerencialRepository();
        public List<Repo_Gerencial> ingresoMes(int anio)
        {
            return repo_GerencialRepository.ingresoMes(anio);
        }

        public List<Repo_Gerencial> porTipoPago(int anio)
        {
            return repo_GerencialRepository.porTipoPago(anio);
        }

        public List<Repo_Gerencial> fraccionamientoMes(int anio)
        {
            return repo_GerencialRepository.fraccionamientoMes(anio);
        }

        public List<Repo_Gerencial> emisionTributo(int anio)
        {
            return repo_GerencialRepository.emisionTributo(anio);
        }
    }
}
