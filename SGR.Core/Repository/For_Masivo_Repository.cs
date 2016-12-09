using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity.Model;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;
using System.Data;

namespace SGR.Core.Repository.Combos
{
    public class For_Masivo_Repository
    {
        private const String nombreprocedimiento = "_NumeracionAuto";
        //private const String NombreTabla = "banco";
        private Database db = DatabaseFactory.CreateDatabase();
        public virtual void Insert()
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);               
                db.AddInParameter(SQL, "TipoConsulta", DbType.Int32, 1);
                int huboexito = db.ExecuteNonQuery(SQL);
                if (huboexito == 0)
                {
                    throw new Exception("Error al agregar al");
                }
                SQL.Dispose();
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
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "TipoConsulta", DbType.Int32, 5);
                int huboexito = db.ExecuteNonQuery(SQL);
                if (huboexito == 0)
                {
                    throw new Exception("Error al agregar al");
                }
                SQL.Dispose();
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
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "TipoConsulta", DbType.Int32, 3);
                int huboexito = db.ExecuteNonQuery(SQL);
                if (huboexito == 0)
                {
                    throw new Exception("Error al agregar al");
                }
                SQL.Dispose();
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
                var coleccion = new List<For_Masivo>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "TipoConsulta", DbType.Byte, 2);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new For_Masivo
                        {

                            numero = lector.IsDBNull(lector.GetOrdinal("numero")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("numero")),                           
                        });
                    }
                }
                SQL.Dispose();
                return coleccion;
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
                var coleccion = new List<For_Masivo>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "TipoConsulta", DbType.Byte, 6);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new For_Masivo
                        {

                            numero = lector.IsDBNull(lector.GetOrdinal("numero")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("numero")),
                        });
                    }
                }
                SQL.Dispose();
                return coleccion;
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
                var coleccion = new List<For_Masivo>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "TipoConsulta", DbType.Byte, 4);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new For_Masivo
                        {

                            numero = lector.IsDBNull(lector.GetOrdinal("numero")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("numero")),
                        });
                    }
                }
                SQL.Dispose();
                return coleccion;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
