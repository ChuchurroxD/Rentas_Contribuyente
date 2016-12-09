using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity.Model;
using SGR.Core.Repository;
namespace SGR.Core.Service
{
    public class Mant_Relacion_ContribuyenteDataService
    {
        private static Mant_Relacion_ContribuyenteRepository Mant_Relacion_ContribuyenteRepository = new Mant_Relacion_ContribuyenteRepository();
        public List<Mant_Relacion_Contribuyente> listartodos(String allegado)
        {
            try
            {
                return Mant_Relacion_ContribuyenteRepository.listartodos(allegado);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual Mant_Relacion_Contribuyente GetByPrimaryKey(Int32 relacion_ID)
        {
            try
            {
                return Mant_Relacion_ContribuyenteRepository.GetByPrimaryKey(relacion_ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Mant_Relacion_Contribuyente> Getcoleccion(string wheresql, string orderbysql)
        {
            try
            {
                return Mant_Relacion_ContribuyenteRepository.Getcoleccion(wheresql, orderbysql);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual int Insert(Mant_Relacion_Contribuyente Mant_Relacion_Contribuyente)
        {
            try
            {
                return Mant_Relacion_ContribuyenteRepository.Insert(Mant_Relacion_Contribuyente);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual void Update(Mant_Relacion_Contribuyente Mant_Relacion_Contribuyente)
        {
            try
            {
                Mant_Relacion_ContribuyenteRepository.Update(Mant_Relacion_Contribuyente);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Mant_Relacion_Contribuyente> listarRelacionporContribuyente(string persona_ID)
        {
            try
            {
                return Mant_Relacion_ContribuyenteRepository.listarRelacionporContribuyente(persona_ID);
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }

    }
}
