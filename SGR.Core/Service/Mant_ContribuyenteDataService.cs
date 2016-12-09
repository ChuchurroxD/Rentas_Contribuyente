using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity;
using SGR.Entity.Model;

namespace SGR.Core.Service
{
    public class Mant_ContribuyenteDataService
    {
        private static Mant_ContribuyenteRepository Mant_ContribuyenteRepository = new Mant_ContribuyenteRepository();

        public List<Mant_Per_Cont> listartodos()
        {
            try
            {
                return Mant_ContribuyenteRepository.listartodos();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual Mant_Contribuyente GetByPrimaryKey(String codigo)
        {
            try
            {
                return Mant_ContribuyenteRepository.GetByPrimaryKey(codigo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Mant_Contribuyente> Getcoleccion(string wheresql, string orderbysql)
        {
            try
            {
                return Mant_ContribuyenteRepository.Getcoleccion(wheresql, orderbysql);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual int Insert(Mant_Contribuyente Contribuyente)
        {
            try
            {
                return Mant_ContribuyenteRepository.Insert(Contribuyente);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual void Update(Mant_Contribuyente Contribuyente)
        {
            try
            {
                Mant_ContribuyenteRepository.Update(Contribuyente);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Int32 GetExisteContribuyente(String per_id)
        {
            try
            {
                return Mant_ContribuyenteRepository.GetExisteContribuyente(per_id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Mant_Per_Cont> listarBuscados(string busqueda, int tipo, string nombreCampo, int oficina)
        {
            try
            {
                return Mant_ContribuyenteRepository.listarBuscados(busqueda, tipo, nombreCampo, oficina);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Mant_Per_Cont> listarBuscadoxExpediente(string busqueda, int tipo, string nombreCampo, int periodo)
        {
            try
            {
                return Mant_ContribuyenteRepository.listarBuscadoxExpediente(busqueda, tipo, nombreCampo, periodo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //
        public List<Mant_Per_Cont> listarBuscadosxDireccion(Mant_Contribuyente cont, int oficina)
        {
            try
            {
                return Mant_ContribuyenteRepository.listarBuscadosxDireccion(cont, oficina);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Mant_Per_Cont> listarBuscadosxDireccionDePredio(Mant_Contribuyente cont, int odifina)
        {
            try
            {
                return Mant_ContribuyenteRepository.listarBuscadosxDireccionDePredio(cont, odifina);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Mant_Per_Cont> listarBuscadosxDireccionDePredio2(Mant_Contribuyente cont, int odifina, int tipo)
        {
            try
            {
                return Mant_ContribuyenteRepository.listarBuscadosxDireccionDePredio2(cont, odifina, tipo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Mant_Contribuyente> listarIdContribuyente(int persona_id)
        {
            try
            {
                return Mant_ContribuyenteRepository.listarIdContribuyente(persona_id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Mant_Cont> listarBuscados1(string busqueda, int tipo, string nombreCampo, int oficina)
        {
            try
            {
                return Mant_ContribuyenteRepository.listarBuscados1(busqueda, tipo, nombreCampo, oficina);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Mant_Cont> listarBuscadosxDireccion1(Mant_Contribuyente cont)
        {
            try
            {
                return Mant_ContribuyenteRepository.listarBuscadosxDireccion1(cont);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Mant_Per_Cont> listarSoloCOntribuyente(String documento, string persona_ID, string cadena, int tipo)
        {
            try
            {
                return Mant_ContribuyenteRepository.listarSoloCOntribuyente(documento, persona_ID, cadena, tipo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Mant_Per_Cont listarDatosPersonales(string persona_ID, int tipo)
        {
            try
            {
                return Mant_ContribuyenteRepository.listarDatosPersonales(persona_ID, tipo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Mant_Per_Cont> listarBuscadosParaReajuste(string sector_id, int oficina, int tipo)
        {
            try
            {
                return Mant_ContribuyenteRepository.listarBuscadosParaReajuste(sector_id, oficina, tipo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

