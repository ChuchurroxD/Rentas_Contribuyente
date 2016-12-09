using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity;
using SGR.Core.Repository;
using SGR.Entity.Model;

namespace SGR.Core.Service
{
    public class Conf_RolOficinaDataService
    {
        private static Conf_RolOficinaRepository conf_RolOficinaRepository = new Conf_RolOficinaRepository();

        public virtual int Insert(Conf_RolOficina conf_RolOficina)
        {
            return conf_RolOficinaRepository.Insert(conf_RolOficina);
        }

        public virtual int Update(Conf_RolOficina conf_RolOficina)
        {
            return conf_RolOficinaRepository.Update(conf_RolOficina);
        }

        public List<Conf_RolOficina> listarTodosRolOficina()
        {
            return conf_RolOficinaRepository.listarTodosRolOficina();
        }

        public List<Conf_RolOficina> listarActivosRolOficina()
        {
            return conf_RolOficinaRepository.listarActivosRolOficina();
        }

        public List<Conf_RolOficina> buscarRolOficina(String busqueda)
        {
            return conf_RolOficinaRepository.buscarRolOficina(busqueda);
        }

        public int existeRolOficina(Int64 rol_id, Int64 oficina_id)
        {
            return conf_RolOficinaRepository.existeRolOficina(rol_id, oficina_id);
        }
    }
}
