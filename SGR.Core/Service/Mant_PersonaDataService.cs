using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity;

namespace SGR.Core.Service
{
    public class Mant_PersonaDataService
    {
        private static Mant_PersonaRepository Mant_PersonaRepository = new Mant_PersonaRepository();
        public List<Mant_Persona> listartodos()
        {
            try
            {
                return Mant_PersonaRepository.listartodos();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Mant_Persona> listarbuscados(String documento)
        {
            try
            {
                return Mant_PersonaRepository.listarbuscados(documento);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Mant_Persona GetByPrimaryKey()
        {
            try
            {
                return Mant_PersonaRepository.GetByPrimaryKey();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //public List<Mant_Persona> Getcoleccion(string wheresql, string orderbysql)
        //{
        //    try
        //    {
        //        return Mant_PersonaRepository.Getcoleccion(wheresql, orderbysql);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}

        public string Insert(Mant_Persona Persona)
        {
            try
            {
                return Mant_PersonaRepository.Insert(Persona);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Mant_Persona Persona)
        {
            try
            {
                Mant_PersonaRepository.Update(Persona);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int GetIdPersonaMax()
        {
            try
            {
                return Mant_PersonaRepository.GetIdPersonaMax();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public bool GetExistePersona(String doc, Int16 tipo)
        {
            try
            {
                if (Mant_PersonaRepository.GetExistePersona(doc, tipo) > 0)
                    return true;
                else return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public bool GetExisteCodigo(String cod)
        {
            try
            {
                if (Mant_PersonaRepository.GetExisteCodigo(cod) > 0)
                    return true;
                else return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        //
        public string GetPersonaExistente(String doc, Int16 tipo)
        {
            try
            {
                return Mant_PersonaRepository.GetPersonaExistente(doc, tipo);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public bool DeleteByPrimaryKey(String persona_id)
        {
            
            try
            {
                return Mant_PersonaRepository.DeleteByPrimaryKey(persona_id);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
        public List<Mant_Persona> listarxIdPersona(int idpersona)
        {
            try
            {
                return Mant_PersonaRepository.listarxidpersona(idpersona);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}

