using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity;

namespace SGR.Core.Service
{
    public class Conf_GrupoDataService
    {
        private static Conf_GrupoRepository Conf_GrupoRepository = new Conf_GrupoRepository();

        public List<Conf_Grupo> GetAllConf_Grupo()
        {
            return Conf_GrupoRepository.listartodos();
        }

        public List<Conf_Grupo> listarxrol(int rol_id)
        {
            return Conf_GrupoRepository.listarxrol (rol_id);
        }

        public int Insert(Conf_Grupo Conf_Grupo)
        {
            return Conf_GrupoRepository.Insert(Conf_Grupo);
        }

        public void Update(Conf_Grupo Conf_Grupo)
        {
            Conf_GrupoRepository.Update(Conf_Grupo);
        }

        public void DeleteByPrimaryKey(Int64 UnNec_iCodigo)
        {
            Conf_GrupoRepository.DeleteByPrimaryKey(UnNec_iCodigo);
        }

        //public int GetExisteNombreNuevo(String UnNec_vNombre)
        //{
        //    return Conf_GrupoRepository.GetExisteNombreNuevo(UnNec_vNombre);
        //}

        //public int GetExisteNombreModificar(String UnNec_vNombre, Int64 UnNec_iCodigo)
        //{
        //    return Conf_GrupoRepository.GetExisteNombreModificar(UnNec_iCodigo, UnNec_vNombre);
        //}

        public List<Conf_Grupo> GetActivosConf_Grupo()//para el combo
        {
            return Conf_GrupoRepository.listarActivos();
        }

        public List<Conf_Grupo> Getcoleccion(string whereSQL, string orderbySQL)
        {
            return Conf_GrupoRepository.Getcoleccion(whereSQL, orderbySQL, 0, 0, 0);
        }

        //public int GetIndiceCombo(Conf_Grupo conf_UnNeg)
        //{
        //    return conf_UnNeg.obtenerIndice(conf_UnNeg.UnNec_iCodigo, GetActivosConf_Grupo());
        //}

        //public List<Conf_Grupo> listarBusqueda(String Grupc_vNombre)
        //{

        //    // return Conf_GrupoRepository.listarBusqueda(Grupc_vNombre);
        //}

        public List<Conf_Grupo> listarGruposActivosInactivos()
        {
            return Conf_GrupoRepository.listarGruposActivosInactivos();
        }

        public int GetExisteNombreNuevo(String UnNec_vNombre)
        {
            return Conf_GrupoRepository.GetExisteNombreNuevo(UnNec_vNombre);
        }

        public int GetExisteNombreModificar(String UnNec_vNombre, Int64 UnNec_iCodigo)
        {
            return Conf_GrupoRepository.GetExisteNombreModificar(UnNec_iCodigo, UnNec_vNombre);
        }

        public List<Conf_Grupo> listarBusqueda(String Grupc_vNombre)
        {
            return Conf_GrupoRepository.listarBusqueda(Grupc_vNombre);
        }
    }
}

