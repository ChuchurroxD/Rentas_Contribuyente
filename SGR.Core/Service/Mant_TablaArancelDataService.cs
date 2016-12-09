using SGR.Core.Repository;
using SGR.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGR.Core.Service
{
    public class Mant_TablaArancelDataService
    {
        Mant_TablaArancelRepository mant_TablaArancelRepository = new Mant_TablaArancelRepository();
        public List<Mant_TablaArancel> listartodos()
        {
            try
            {
                return mant_TablaArancelRepository.listartodos();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }//listarActivosConCosto

        public virtual Mant_TablaArancel GetByPrimaryKey()
        {
            try
            {
                return mant_TablaArancelRepository.GetByPrimaryKey();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Mant_TablaArancel> Getcoleccion(string wheresql, string orderbysql)
        {
            try
            {
                return mant_TablaArancelRepository.Getcoleccion(wheresql, orderbysql);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual void Insert(Mant_TablaArancel mant_TablaArancel)
        {
            try
            {
                mant_TablaArancelRepository.Insert(mant_TablaArancel);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual void Update(Mant_TablaArancel mant_TablaArancel)
        {
            try
            {
                mant_TablaArancelRepository.Update(mant_TablaArancel);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Mant_TablaArancel> llenarcomboTablaArancel()
        {
            try
            {
                return mant_TablaArancelRepository.llenarcomboTablaArancel();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
        public List<Mant_TablaArancel> listarActivosConCosto(String predio_id,string peridoo)
        {
            try
            {
                return mant_TablaArancelRepository.listarActivosConCosto(predio_id,peridoo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }//

        public virtual Int32 GetExisteDescripcionNuevo(String descripcion)
        {
            return mant_TablaArancelRepository.GetExisteDescripcionNuevo(descripcion);
        }

        public virtual Int32 GetExisteDescripcionModificar(Int32 id, String descripcion)
        {
            return mant_TablaArancelRepository.GetExisteDescripcionModificar(id, descripcion);
        }
    }
}
