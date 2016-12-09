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

    public class Pred_ConstanciaAdeudoRepository
    {
        private const String nombreprocedimiento = "_Pred_ConstanciaNoAdeudo";
        //private const String NombreTabla = "Grupo";
        private Database db = DatabaseFactory.CreateDatabase();
        public List<Mant_Mes> listarDeuda(String persona_ID, String tributo_ID, String predio_ID, String grupo_trib)
        {
            try
            {
                var coleccion = new List<Mant_Mes>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 1);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona_ID);
                db.AddInParameter(SQL, "tributo_ID", DbType.String, tributo_ID);
                db.AddInParameter(SQL, "predio_ID", DbType.String, predio_ID);
                db.AddInParameter(SQL, "grupo_trib", DbType.String, grupo_trib);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Mant_Mes
                        {
                            Enero = Convert.ToString(lector.GetDecimal(lector.GetOrdinal("ENE"))),
                            Febrero = Convert.ToString(lector.GetDecimal(lector.GetOrdinal("FEB"))),
                            Marzo = Convert.ToString(lector.GetDecimal(lector.GetOrdinal("MAR"))),
                            Abril = Convert.ToString(lector.GetDecimal(lector.GetOrdinal("ABR"))),
                            Mayo = Convert.ToString(lector.GetDecimal(lector.GetOrdinal("MAY"))),
                            Junio = Convert.ToString(lector.GetDecimal(lector.GetOrdinal("JUN"))),
                            Julio = Convert.ToString(lector.GetDecimal(lector.GetOrdinal("JUL"))),
                            Agosto = Convert.ToString(lector.GetDecimal(lector.GetOrdinal("AGO"))),
                            Setiembre = Convert.ToString(lector.GetDecimal(lector.GetOrdinal("SEP"))),
                            Octubre = Convert.ToString(lector.GetDecimal(lector.GetOrdinal("OCT"))),
                            Noviembre = Convert.ToString(lector.GetDecimal(lector.GetOrdinal("NOV"))),
                            Anio = Convert.ToString(lector.GetInt32(lector.GetOrdinal("ANIO"))),
                            Total = Convert.ToString(lector.GetDecimal(lector.GetOrdinal("TOT"))),
                            Diciembre = Convert.ToString(lector.GetDecimal(lector.GetOrdinal("DIC")))
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
