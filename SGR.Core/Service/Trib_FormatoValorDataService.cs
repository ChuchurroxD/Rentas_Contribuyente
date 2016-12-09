using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Core.Repository;
using SGR.Entity;
using SGR.Entity.Model;

namespace SGR.Core.Service
{
    public class Trib_FormatoValorDataService
    {
        Trib_FormatoValorRepository Trib_FormatoValores = new Trib_FormatoValorRepository();
        public List<Trib_FormatoValor> listartodos()
        {
            try
            {
                return Trib_FormatoValores.listartodos();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual Trib_FormatoValor GetByPrimaryKey(Int32 formato_valores_ID)
        {
            try
            {
                return Trib_FormatoValores.GetByPrimaryKey(formato_valores_ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Trib_FormatoValor> Getcoleccion(string wheresql, string orderbysql)
        {
            try
            {
                return Trib_FormatoValores.Getcoleccion(wheresql, orderbysql);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual int Insert(Trib_FormatoValor formato_valores)
        {
            try
            {
                return Trib_FormatoValores.Insert(formato_valores);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual void Update(Trib_FormatoValor formato_valores)
        {
            try
            {
                Trib_FormatoValores.Update(formato_valores);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Trib_FormatoValor buscarByAnioByTipoValor(Int32 anio, string tipodoc)
        {
            try
            {
                return Trib_FormatoValores.buscarByAnioByTipoValor(anio, tipodoc);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
