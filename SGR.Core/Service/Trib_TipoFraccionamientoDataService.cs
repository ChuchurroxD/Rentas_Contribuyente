using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity.Model;
using SGR.Core;

namespace SGR.Core.Service
{
    public class Trib_TipoFraccionamientoDataService
    {

        private static Trib_TipoFraccionamientoRepository Trib_TipoFraccionamiento = new Trib_TipoFraccionamientoRepository();
        public List<Trib_TributoFraccionamiento> listarTributosporTipo(int codigo,int tipoTributo)
        {
            try
            {
                return Trib_TipoFraccionamiento.listarTributosporTipo(codigo,tipoTributo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Trib_TributoFraccionamiento> listarTributosFraccionamiento(int codigo)
        {
            try
            {
                return Trib_TipoFraccionamiento.listarTributosFraccionamiento(codigo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual int InsertTributoFracc(Trib_TributoFraccionamiento TributoFracc)
        {
            try
            {
                return Trib_TipoFraccionamiento.InsertTributoFracc(TributoFracc);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual int EliminaTributoFracc(int codigo)
        {
            try
            {
                return Trib_TipoFraccionamiento.EliminaTributoFracc(codigo);
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public virtual int EliminaTributosFracc()
        {
            try
            {
                return Trib_TipoFraccionamiento.EliminaTributosFracc();
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public List<Trib_TipoFraccionamiento> listartodos()
        {
            try
            {
                return Trib_TipoFraccionamiento.listartodos();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void actualizarTributos(int codigo)
        {
            try
            {
                Trib_TipoFraccionamiento.actualizarTributos(codigo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual Trib_TipoFraccionamiento GetByPrimaryKey(int codigo)
        {
            try
            {
                return Trib_TipoFraccionamiento.GetByPrimaryKey(codigo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Trib_TipoFraccionamiento> Getcoleccion(string wheresql, string orderbysql)
        {
            try
            {
                return Trib_TipoFraccionamiento.Getcoleccion(wheresql, orderbysql);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual int Insert(Trib_TipoFraccionamiento TipoFraccionamiento)
        {
            try
            {
                return Trib_TipoFraccionamiento.Insert(TipoFraccionamiento);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual void Update(Trib_TipoFraccionamiento TipoFraccionamiento)
        {
            try
            {
                Trib_TipoFraccionamiento.Update(TipoFraccionamiento);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void DeleteByPrimaryKey(int codigo)
        {
            try
            {
                Trib_TipoFraccionamiento.DeleteByPrimaryKey(codigo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
