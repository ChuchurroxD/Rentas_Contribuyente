using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Data.Common;
using SGR.Entity.Model;
using SGR.Entity;
using SGR.Core.Service;

namespace SGR.Core.Repository
{
    public class Pred_FiscalizacionCtaCteRepository
    {
        private const String nombreprocedimiento = "_Pred_Fiscalizacion_CtaCte";
        private Database db = DatabaseFactory.CreateDatabase();
        private Mant_PeriodoDataService PeriodoDataService = new Mant_PeriodoDataService();

        public void GenerarCtaCorrienteParaUnredioFiscaNuevo(string periodoini, string periodofin, string predio_ID, string registro_user, int tipo)
        {
            try
            {
                //tipo 8=predial, tipo 9=arbitrio, 10 ambos
                var coleccion = new List<Mant_Depreciacion>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, tipo);
                db.AddInParameter(SQL, "periodoini", DbType.String, periodoini);
                db.AddInParameter(SQL, "periodofin", DbType.String, periodofin);
                db.AddInParameter(SQL, "predio_ID", DbType.String, predio_ID);
                db.AddInParameter(SQL, "registro_user", DbType.String, registro_user);
                SQL.CommandTimeout = 600;
                db.ExecuteNonQuery(SQL);
                SQL.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void GenerarCtaCorrienteParaPersonaFiscaNuevo(string periodoini, string periodofin, string persona_ID, string registro_user, int tipo)
        {
            try
            {
                //tipo 7=predial, tipo 6=arbitrio, 5 ambos
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, tipo);
                db.AddInParameter(SQL, "periodoini", DbType.String, periodoini);
                db.AddInParameter(SQL, "periodofin", DbType.String, periodofin);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona_ID);
                db.AddInParameter(SQL, "registro_user", DbType.String, registro_user);
                SQL.CommandTimeout = 600;
                db.ExecuteNonQuery(SQL);
                SQL.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}

