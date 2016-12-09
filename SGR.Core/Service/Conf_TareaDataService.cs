using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity;

namespace SGR.Core.Service
{
    public class Conf_TareaDataService
    {
        private static Conf_TareaRepository Conf_TareaRepository = new Conf_TareaRepository();

        public List<Conf_Tarea> GetAllConf_Tarea(Int64 idgrupo , int idrol )
        {
            return Conf_TareaRepository.listartodos(idgrupo  , idrol );
        }

        public int Insert(Conf_Tarea Conf_Tarea)
        {
            return Conf_TareaRepository.Insert(Conf_Tarea);
        }
        public void Update(Conf_Tarea Conf_Tarea)
        {
            Conf_TareaRepository.Update(Conf_Tarea);
        }
        public Conf_Tarea GetByPrimaryKey(Int64 UnNec_iCodigo)
        {

         return    Conf_TareaRepository.GetByPrimaryKey(UnNec_iCodigo);
        }

        public int GetExisteDescripcionNuevo(String UnNec_vDescripcion)
        {
            return Conf_TareaRepository.GetExisteDescripcionNuevo(UnNec_vDescripcion); 
        }

        public int GetExisteDescripcionModificar(String UnNec_vDescripcion, Int64 UnNec_iCodigo)
        {
            return Conf_TareaRepository.GetExisteDescripcionModificar(UnNec_iCodigo, UnNec_vDescripcion); 
        }

        //public List<Conf_Tarea> GetActivosConf_Tarea()//para el combo
        //{
        //    return Conf_TareaRepository.listarActivos();
        //}
        //public int GetIndiceCombo(Conf_Tarea conf_UnNeg)
        //{
        //    return conf_UnNeg.obtenerIndice(conf_UnNeg.UnNec_iCodigo, GetActivosConf_Tarea());
        //}

        public List<Conf_Tarea> listarActivos(Int64 grupo_id)
        {
            return Conf_TareaRepository.listarActivos(grupo_id);
        }

        public int GetExisteNombreNuevo(String UnNec_vNombre)
        {
            return Conf_TareaRepository.GetExisteNombreNuevo(UnNec_vNombre);
        }

        public int GetExisteNombreModificar(String UnNec_vNombre, Int64 UnNec_iCodigo)
        {
            return Conf_TareaRepository.GetExisteNombreModificar(UnNec_iCodigo, UnNec_vNombre);
        }

        public List<Conf_Tarea> listarBusquedaByGrupo(String buscar, Int64 Grupo_id)
        {
            return Conf_TareaRepository.listarBusquedaByGrupo(buscar, Grupo_id);
        }

        public List<Conf_Tarea> listarTareasActivasInactivas(Int64 idGrupo)
        {
            return Conf_TareaRepository.listarTareasActivasInactivas(idGrupo);
        }
    }
}

