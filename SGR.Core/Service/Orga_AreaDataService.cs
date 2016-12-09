using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Core.Service;
using SGR.Entity.Model;

namespace SGR.Core.Service
{
    public  class Orga_AreaDataService
    {
        private static Orga_AreaRepository Orga_areaRepository = new Orga_AreaRepository();
        public List<Orga_Area> listartodos()
        {
            try
            {
                return Orga_areaRepository.listartodos();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Orga_Area> listarHijos(string padre)
        {
            try
            {
                return Orga_areaRepository.listarHijos(padre);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int ExisteDescripcion(String descripcion)
        {
            return Orga_areaRepository.ExistenciaDescripcion(descripcion);
        }
        public int ExisteCodigo(String codigo)
        {
            return Orga_areaRepository.ExistenciaCodigo(codigo);
        }
        public virtual Orga_Area GetByPrimaryKey(String codigo)
        {
            try
            {
                return Orga_areaRepository.GetByPrimaryKey(codigo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual bool DeleteByPrimaryKey(string codigo)
        {
            try
            {
                return Orga_areaRepository.DeleteByPrimaryKey(codigo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Orga_Area> Getcoleccion(string wheresql, string orderbysql)
        {
            try
            {
                return Orga_areaRepository.Getcoleccion(wheresql, orderbysql);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual int Insert(Orga_Area Area)
        {
            try
            {
                return Orga_areaRepository.Insert(Area);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Update(Orga_Area Area,string codigo)
        {
            try
            {
                Orga_areaRepository.Update(Area,codigo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Orga_Area> listarAreaReporte()
        {
            try
            {
                return Orga_areaRepository.listarAreaReporte();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Orga_Area> listarAreasActivas()
        {
            return Orga_areaRepository.listarAreasActivas();
        }
    }
}