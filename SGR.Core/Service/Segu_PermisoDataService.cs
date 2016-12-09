using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity;

namespace SGR.Core.Service
{
    public class Segu_PermisoDataService
    {
        private static Segu_PermisoRepository Segu_PermisoRepository = new Segu_PermisoRepository();

        public List<Segu_Permiso> GetAllSegu_Permiso()
        {
            return Segu_PermisoRepository.listartodos();
        }

        public int Insert(Segu_Permiso Segu_Permiso)
        {
            return Segu_PermisoRepository.Insert(Segu_Permiso);
        }
        public void Update(Segu_Permiso Segu_Permiso)
        {
            Segu_PermisoRepository.Update(Segu_Permiso);
        }
        public void DeleteByPrimaryKey(Int64 UnNec_iCodigo)
        {
            Segu_PermisoRepository.DeleteByPrimaryKey(UnNec_iCodigo);
        }

        public int GetExisteDescripcionNuevo(Int64 rol, Int64 tarea)
        {
            return Segu_PermisoRepository.GetExisteDescripcionNuevo(rol,tarea); 
        }

        //public int GetExisteDescripcionModificar(String UnNec_vDescripcion, Int64 UnNec_iCodigo)
        //{
        //    return Segu_PermisoRepository.GetExisteDescripcionModificar(UnNec_iCodigo, UnNec_vDescripcion); 
        //}
        //public List<Segu_Permiso> GetActivosSegu_Permiso()//para el combo
        //{
        //    return Segu_PermisoRepository.listarActivos();
        //}
        //public int GetIndiceCombo(Segu_Permiso conf_UnNeg)
        //{
        //    return conf_UnNeg.obtenerIndice(conf_UnNeg.UnNec_iCodigo, GetActivosSegu_Permiso());
        //}
    }
}

