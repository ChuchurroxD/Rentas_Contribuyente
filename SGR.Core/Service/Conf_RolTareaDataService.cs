using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity;
using SGR.Core.Repository;
using SGR.Entity.Model;

namespace SGR.Core.Service
{
    public class Conf_RolTareaDataService
    {
        private static Conf_RolTareaRepository conf_RolTareaRepository = new Conf_RolTareaRepository();

        public virtual int Insert(Conf_RolTarea conf_RolTarea)
        {
            return conf_RolTareaRepository.Insert(conf_RolTarea);
        }

        public virtual int Update(Conf_RolTarea conf_RolTarea)
        {
            return conf_RolTareaRepository.Update(conf_RolTarea);
        }

        public List<Conf_RolTarea> listarTodosRolTarea()
        {
            return conf_RolTareaRepository.listarTodosRolTarea();
        }

        public List<Conf_RolTarea> listarActivosRolTarea()
        {
            return conf_RolTareaRepository.listarActivosRolTarea();
        }

        public List<Conf_RolTarea> buscarRolTarea(String busqueda)
        {
            return conf_RolTareaRepository.buscarRolTarea(busqueda);
        }

        public int existeRolTarea(Int64 rol_id, Int64 tarea_id)
        {
            return conf_RolTareaRepository.existeRolTarea(rol_id, tarea_id);
        }
    }
}
