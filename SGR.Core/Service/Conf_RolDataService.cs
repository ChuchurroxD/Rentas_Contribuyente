using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity;

namespace SGR.Core.Service
{
    public class Conf_RolDataService
    {
        private static Conf_RolRepository Conf_RolRepository = new Conf_RolRepository();

        
            public List<Conf_Rol> listarxusuario(Segu_Usuario Segu_Usuario)
        {
            return Conf_RolRepository.listarxusuario (Segu_Usuario);
        }


        public List<Conf_Rol> GetAllConf_Rol()
        {
            return Conf_RolRepository.listartodos();
        }
        public List<Conf_Rol> Getcoleccion(string whereSQL, string orderbySQL)
        {
            return Conf_RolRepository.Getcoleccion(whereSQL, orderbySQL, 0, 0, 0);

        }
        public int Insert(Conf_Rol Conf_Rol)
        {
            return Conf_RolRepository.Insert(Conf_Rol);
        }
        public void Update(Conf_Rol Conf_Rol)
        {
            Conf_RolRepository.Update(Conf_Rol);
        }
        public void DeleteByPrimaryKey(Int64 Mult_iCodigo)
        {
            Conf_RolRepository.DeleteByPrimaryKey(Mult_iCodigo);
        }

        public int GetExisteDescripcionNuevo(String Nombre)
        {
            return Conf_RolRepository.GetExisteDescripcionNuevo(Nombre); ;
        }

        public int GetExisteDescripcionModificar(String Nombre,Int64 Id)
        {
            return Conf_RolRepository.GetExisteDescripcionModificar(Id, Nombre); 
        }

        public List<Conf_Rol> listarRolesActivo()
        {
            return Conf_RolRepository.listarRolesActivo();
        }
    }
}
