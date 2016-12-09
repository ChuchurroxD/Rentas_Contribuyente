using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Core;
using SGR.Entity;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Data.Common;
using SGR.Entity.Model;

namespace SGR.Core.Repository
{
    public class Repo_GrandesBasesImponiblesRepository
    {
        private const String nombreprocedimiento = "_Repo_MayoresBasesImponibles";
        private Database db = DatabaseFactory.CreateDatabase();

        public List<Repo_GrandesBasesImponibles> generarReporte(int periodo_id, int top)
        {
            try
            {
                var coleccion = new List<Repo_GrandesBasesImponibles>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "periodo_id", DbType.Int32, periodo_id);
                db.AddInParameter(SQL, "top", DbType.Int32, top);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 1);//modificar de acuerdo a tipo de  consulta
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Repo_GrandesBasesImponibles
                        {
                            persona_id = lector.GetString(lector.GetOrdinal("persona_id")),
                            periodo_id = lector.GetInt32(lector.GetOrdinal("periodo_id")),
                            razon_social = lector.IsDBNull(lector.GetOrdinal("razon_social")) ? default(String) : lector.GetString(lector.GetOrdinal("razon_social")),
                            direccion_completa = lector.IsDBNull(lector.GetOrdinal("direccCompleta")) ? default(String) : lector.GetString(lector.GetOrdinal("direccCompleta")),
                            base_imponible = lector.GetDecimal(lector.GetOrdinal("BASE IMPONIBLE"))
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
