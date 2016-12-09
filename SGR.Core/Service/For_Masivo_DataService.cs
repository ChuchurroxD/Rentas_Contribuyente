using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Core.Repository;
using SGR.Entity.Model;
using SGR.Core.Repository.Combos;

namespace SGR.Core.Service
{
    public class For_Masivo_DataService
    {
        For_Masivo_Repository For_Masivo_Repository = new For_Masivo_Repository();
        public virtual void Insert()
        {
            try
            {
                For_Masivo_Repository.Insert();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual void InsertPU()
        {
            try
            {
                For_Masivo_Repository.InsertPU();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual void InsertPR()
        {
            try
            {
                For_Masivo_Repository.InsertPR();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<For_Masivo> Numeracion()
        {
            try
            {
                return For_Masivo_Repository.Numeracion();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<For_Masivo> NumeracionPU()
        {
            try
            {
                return For_Masivo_Repository.NumeracionPU();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<For_Masivo> NumeracionPR()
        {
            try
            {
                return For_Masivo_Repository.NumeracionPR();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
