using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity.Model;

namespace SGR.Core.Service
{
    public class Trib_ClasificadorIngresosDataService
    {
        private static Trib_ClasificadorIngresosRepository Trib_ClasificadorIngresos = new Trib_ClasificadorIngresosRepository();
        public List<Trib_ClasificadorIngresos> listartodos()
        {
            try
            {
                return Trib_ClasificadorIngresos.listartodos();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void copiarClasificadores(string periodoPrevio, string periodoActual)
        {
            try
            {
                Trib_ClasificadorIngresos.copiarClasificadores(periodoPrevio,periodoActual);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Trib_ClasificadorIngresos> listarHijos(String padre, String anio)
        {
            try
            {
                return Trib_ClasificadorIngresos.listarHijos(padre, anio);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int ExisteDescripcion(String descripcion, string anio)
        {
            return Trib_ClasificadorIngresos.ExistenciaDescripcion(descripcion,anio);
        }
        public int ExisteCodigo(String codigo, string anio)
        {
            return Trib_ClasificadorIngresos.ExistenciaCodigo(codigo,anio);
        }
        public virtual Trib_ClasificadorIngresos GetByPrimaryKey(String clai_codigo, String clai_anio)
        {
            try
            {
                return Trib_ClasificadorIngresos.GetByPrimaryKey(clai_codigo, clai_anio);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Trib_ClasificadorIngresos> Getcoleccion(string wheresql, string orderbysql)
        {
            try
            {
                return Trib_ClasificadorIngresos.Getcoleccion(wheresql, orderbysql);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual bool DeleteByPrimaryKey(string codigo,string anio)
        {
            try
            {
                return Trib_ClasificadorIngresos.DeleteByPrimaryKey(codigo,anio);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual int Insert(Trib_ClasificadorIngresos Clasificador_ingresos)
        {
            try
            {
                return Trib_ClasificadorIngresos.Insert(Clasificador_ingresos);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual void Update(Trib_ClasificadorIngresos Clasificador_ingresos,string codigo)
        {
            try
            {
                Trib_ClasificadorIngresos.Update(Clasificador_ingresos,codigo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
