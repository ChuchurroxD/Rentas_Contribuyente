using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Core.Repository;
using SGR.Entity.Model;

namespace SGR.Core.Service
{
    public class Mant_BancoDataService
    {
        Mant_BancoRepository Mant_BancoRepository = new Mant_BancoRepository();
        public List<Mant_Banco> listartodos()
        {
            try
            {
                return Mant_BancoRepository.listartodos();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Mant_Banco> listaActivos()
        {
            try
            {
                return Mant_BancoRepository.listarActivos();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Mant_Banco> Getcoleccion(string wheresql, string orderbysql)
        {
            try
            {
                return Mant_BancoRepository.Getcoleccion(wheresql, orderbysql);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual void Insert(Mant_Banco banco)
        {
            try
            {
                if (Mant_BancoRepository.compararDescripcion(banco.descripcion) > 0)
                {
                    throw new Exception("La descripción ya fue creada, ingrese otra descripción");
                }
                Mant_BancoRepository.Insert(banco);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual void Update(Mant_Banco banco)
        {
            try
            {
                if (Mant_BancoRepository.compararDescripcionModificar(banco.descripcion, banco.banco_ID) > 0)
                    throw new Exception("La descripción ya fue creada, ingrese otra descripción");
                Mant_BancoRepository.Update(banco);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
