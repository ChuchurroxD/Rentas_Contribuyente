using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity.Model;
using SGR.Core.Repository;
namespace SGR.Core.Service
{
    public class Pred_Certificado_AlcabalaDataService
    {
        private static Pred_CertificadoAlcabalaRepository Pred_CertificadoAlcabalaRepository = new Pred_CertificadoAlcabalaRepository();

        public List<Pred_Certificado_Alcabala> listartodos(int anio, string ven, string comp,string filtro)
        {
            try
            {
                return Pred_CertificadoAlcabalaRepository.listartodos(anio, ven, comp,filtro);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual int Insert(Pred_Certificado_Alcabala certificado_alcabala)
        {
            try
            {
                return Pred_CertificadoAlcabalaRepository.Insert(certificado_alcabala);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual void Update(Pred_Certificado_Alcabala certificado_alcabala)
        {
            try
            {
                Pred_CertificadoAlcabalaRepository.Update(certificado_alcabala);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Pred_Certificado_Alcabala GetByPrimaryKey(int Alcabala_id)
        {
            try
            {
                return Pred_CertificadoAlcabalaRepository.GetByPrimaryKey(Alcabala_id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int DeudaPendiente(String per_id)
        {
            try
            {
                return Pred_CertificadoAlcabalaRepository.DeudaPendiente(per_id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int DeudaPendienteTotal(string predio_id)
        {
            try
            {
                return Pred_CertificadoAlcabalaRepository.DeudaPendienteTotal(predio_id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //public int ExisteRecibo(string num_recibo, string per, string anio)
        //{
        //    try
        //    {
        //        return Pred_CertificadoAlcabalaRepository.ExisteRecibo(num_recibo, per, anio);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}
        public int  ExisteRecibo(string predio_id, string per, string anio)
        {
            try
            {
                return Pred_CertificadoAlcabalaRepository.ExisteRecibo(predio_id, per, anio);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int TraspasoDePropiedad(DateTime fechadesde, int tipoadquisicion, int tipoposesion, String observacion, int anioCompra, String expediente,
            String Predio_id, String persona_ID, Decimal condomino, string registro_user_add, String comprador, String recibo,
            Decimal porcentajeCondominioMaximo, String impuesto, String uso, String tipo_inmueble)
        {
            try
            {
                return Pred_CertificadoAlcabalaRepository.TraspasoDePropiedad(fechadesde, tipoadquisicion, tipoposesion, observacion, anioCompra, expediente,
                         Predio_id, persona_ID, condomino, registro_user_add, comprador, recibo, porcentajeCondominioMaximo,
                         impuesto, uso, tipo_inmueble);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Pred_Certificado_Alcabala GetByPrimaryPeComAnoPredio(String predio_id, String persona_id, String comprador, Int32 anioGeneracion)
        {
            try
            {
                return Pred_CertificadoAlcabalaRepository.GetByPrimaryPeComAnoPredio(predio_id, persona_id, comprador, anioGeneracion);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual string ErrorExistencia(string Predio_id, string comprador,int anio,int mes)
        {
            try
            {
                return Pred_CertificadoAlcabalaRepository.ErrorExistencia(Predio_id, comprador,anio,mes);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pred_Certificado_Alcabala> listarPagados(int anio)
        {
            try
            {
                return Pred_CertificadoAlcabalaRepository.listarPagados(anio);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pred_Certificado_Alcabala> listarPagadosxPersona(int anio, string persona)
        {
            try
            {
                return Pred_CertificadoAlcabalaRepository.listarPagadosxPersona(anio, persona);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual string Eliminar(int certalcabala_id)
        {
            try
            {
               return Pred_CertificadoAlcabalaRepository.Eliminar(certalcabala_id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual int InsertAlcabalaPasado(Pred_Certificado_Alcabala certificado_alcabala)
        {
            try
            {
                return Pred_CertificadoAlcabalaRepository.InsertAlcabalaPasado(certificado_alcabala);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
