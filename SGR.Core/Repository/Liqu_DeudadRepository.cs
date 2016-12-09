using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Core;
using SGR.Entity.Model;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Data.Common;

namespace SGR.Core.Repository
{
    public class Liqu_DeudadRepository
    {

        private const String nombreprocedimiento = "_liqu_Deuda";
        private Database db = DatabaseFactory.CreateDatabase();
        public List<Liqu_Deuda> listartodos(String persona_ID)
        {
            try
            {
                var coleccion = new List<Liqu_Deuda>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "tipo", DbType.Byte, 1);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona_ID);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Liqu_Deuda
                        {
                            persona_ID = lector.GetString(lector.GetOrdinal("persona_ID")),
                            predio_ID = lector.GetString(lector.GetOrdinal("predio_cod")),
                            predio = lector.IsDBNull(lector.GetOrdinal("predio")) ? default(String):lector.GetString(lector.GetOrdinal("predio")),
                            tributo_ID = lector.GetString(lector.GetOrdinal("tributo_cod")),
                            tributo = lector.GetString(lector.GetOrdinal("tributo")),
                            monto = lector.GetDecimal(lector.GetOrdinal("monto")),
                            interes = lector.GetDecimal(lector.GetOrdinal("interes")),
                            total = lector.GetDecimal(lector.GetOrdinal("total")),
                            deudaVencida = lector.GetDecimal(lector.GetOrdinal("deudaVencida"))
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
