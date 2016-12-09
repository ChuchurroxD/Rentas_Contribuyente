using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity.Model;
using SGR.Core.Repository;
namespace SGR.Core.Service
{
    public class Mult_MultasDataService
    {
        private static Mult_MultasRepository Mult_MultasRepository = new Mult_MultasRepository();
        public virtual int Insert(Mult_Multas Mult_Multas)
        {
            try
            {
                return Mult_MultasRepository.Insert(Mult_Multas);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Mult_Multas Mult_Multas)
        {
            Mult_MultasRepository.Update(Mult_Multas);
        }

        public List<Mult_Multas> listartodos()
        {
            try
            {
                return Mult_MultasRepository.listartodos();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public List<Mult_Multas> listarTodosPorAnio(int anio,int CLASEMULT)
        {
            try
            {
                return Mult_MultasRepository.listarTodosPorAnio(anio, CLASEMULT);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Mult_Multas> listarTodosPorAnio2(int anio, string tipo,int CLASEMULT)
        {
            try
            {
                return Mult_MultasRepository.listarTodosPorAnio2(anio, tipo, CLASEMULT);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Mult_Multas> Getcoleccion(string wheresql, string orderbysql)
        {
            try
            {
                return Mult_MultasRepository.Getcoleccion(wheresql, orderbysql);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual int VerificarResolucion(string mult_nro_resolucion, string mult_anio_resolucion)
        {
            try
            {
                return Mult_MultasRepository.VerificarResolucion(mult_nro_resolucion, mult_anio_resolucion);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void Delete(int mult_id, string registro_user)
        {
            try
            {
                Mult_MultasRepository.Delete(mult_id, registro_user);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Mult_Multas> listarTodosPorAño(int anio)
        {
            try
            {
                return Mult_MultasRepository.listarTodosPorAño(anio);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void EnviarCoactivo(int mult_id, string registro_user, string idpersona)
        {
            try
            {
                Mult_MultasRepository.EnviarCoactivo(mult_id, registro_user, idpersona);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
