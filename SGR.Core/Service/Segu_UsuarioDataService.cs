using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity;

namespace SGR.Core.Service
{
    public class Segu_UsuarioDataService
    {
        private static Segu_UsuarioRepository Segu_UsuarioRepository = new Segu_UsuarioRepository();

        public List<Segu_Usuario> GetAllSegu_Usuarios()
        {
            return Segu_UsuarioRepository.listartodos ();

        }

        public Segu_Usuario validarUsuario(Segu_Usuario Segu_Usuario)
        {
            try
            {

                return Segu_UsuarioRepository.validarUsuario (Segu_Usuario );

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual List<Segu_Usuario> listarUsuarios()
        {
            return Segu_UsuarioRepository.listarUsuarios();
        }

        public virtual List<Segu_Usuario> listarUsuariosActivos()
        {
            return Segu_UsuarioRepository.listarUsuariosActivos();
        }

        public virtual Int32 insertUsuario(Segu_Usuario segu_Usuario) //string rol_nombre)
        {
            return Segu_UsuarioRepository.insertUsuario(segu_Usuario);//, rol_nombre);
        }

        public virtual Int32 updateUsuario(Segu_Usuario segu_Usuario)
        {
            return Segu_UsuarioRepository.updateUsuario(segu_Usuario);
        }
        public virtual Int32 updateUsuarioDatosPersonales(Segu_Usuario segu_Usuario)
        {
            return Segu_UsuarioRepository.updateUsuarioDatosPersonales(segu_Usuario);
        }
        public virtual Int32 GetExisteLoginNuevo(String per_login)
        {
            return Segu_UsuarioRepository.GetExisteLoginNuevo(per_login);
        }

        public virtual Int32 GetExisteLoginModificar(string per_codigo, String per_login)
        {
            return Segu_UsuarioRepository.GetExisteLoginModificar(per_codigo, per_login);
        }

        public virtual Int32 insertRolUsuario(Segu_Usuario segu_Usuario, string rol_nombre)
        {
            return Segu_UsuarioRepository.insertRolUsuario(segu_Usuario, rol_nombre);
        }

        public List<Conf_Rol> listarRolesXUsuario(string per_codigo)
        {
            return Segu_UsuarioRepository.listarRolesXUsuario(per_codigo);
        }

        public virtual Int32 deleteRolUsuario(Segu_Usuario segu_Usuario)
        {
            return Segu_UsuarioRepository.deleteRolUsuario(segu_Usuario);
        }

        public virtual List<Segu_Usuario> buscarUsuario(string buscar)
        {
            return Segu_UsuarioRepository.buscarUsuario(buscar);
        }
        public Segu_Usuario DatosUsuario(string usuario)
        {
            try
            {

                return Segu_UsuarioRepository.DatosUsuario(usuario);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual Int32 VerificarSiEsADmin(string per_login, string per_pass)
        {
            try
            {

                return Segu_UsuarioRepository.VerificarSiEsADmin(per_login, per_pass);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
