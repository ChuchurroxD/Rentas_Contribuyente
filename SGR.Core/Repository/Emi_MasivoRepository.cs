using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity.Model;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Data.Common;

namespace SGR.Core.Repository
{
    public class Emi_MasivoRepository
    {
        private const String nombreprocedimiento = "_Rep_HR";
        private Database db = DatabaseFactory.CreateDatabase();

        public List<Emi_Masivo> listartodos(Int32 sector)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "TipoConsulta", DbType.Byte, 9);
                db.AddInParameter(SQL, "Sector", DbType.Int32,sector);
                var coleccion = new List<Emi_Masivo>();
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Emi_Masivo
                        {
                            //Coa_coactivo_cta_ID = lector.GetInt32(lector.GetOrdinal("Coa_coactivo_cta_ID")),                            
                            persona_ID = lector.IsDBNull(lector.GetOrdinal("persona_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("persona_ID")),
                            nombres = lector.IsDBNull(lector.GetOrdinal("nombres")) ? default(String) : lector.GetString(lector.GetOrdinal("nombres")),
                            documento = lector.IsDBNull(lector.GetOrdinal("documento")) ? default(String) : lector.GetString(lector.GetOrdinal("documento")),
                            direccion = lector.IsDBNull(lector.GetOrdinal("direccion")) ? default(String) : lector.GetString(lector.GetOrdinal("direccion"))

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

        public List<Emi_Masivo> listarNuevaImpresion(String persona, Int32 sector)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "TipoConsulta", DbType.Byte, 10);
                db.AddInParameter(SQL, "Sector", DbType.Int32, sector);
                db.AddInParameter(SQL, "nombres", DbType.String, persona);
                var coleccion = new List<Emi_Masivo>();
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Emi_Masivo
                        {
                            //Coa_coactivo_cta_ID = lector.GetInt32(lector.GetOrdinal("Coa_coactivo_cta_ID")),                            
                            persona_ID = lector.IsDBNull(lector.GetOrdinal("persona_ID")) ? default(String) : lector.GetString(lector.GetOrdinal("persona_ID")),
                            nombres = lector.IsDBNull(lector.GetOrdinal("nombres")) ? default(String) : lector.GetString(lector.GetOrdinal("nombres")),
                            documento = lector.IsDBNull(lector.GetOrdinal("documento")) ? default(String) : lector.GetString(lector.GetOrdinal("documento")),
                            direccion = lector.IsDBNull(lector.GetOrdinal("direccion")) ? default(String) : lector.GetString(lector.GetOrdinal("direccion"))

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
