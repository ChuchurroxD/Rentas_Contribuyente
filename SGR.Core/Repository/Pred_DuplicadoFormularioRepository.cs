using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Data.Common;
using SGR.Entity.Model;
using SGR.Core.Service;

namespace SGR.Core.Repository
{
    public class Pred_DuplicadoFormularioRepository
    {
        private const String nombreprocedimiento = "_Pred_DuplicadoFormulario";
        private Database db = DatabaseFactory.CreateDatabase();
        public virtual void Generar(String PERSONA, String ini, string fin, string registro_user, int hp,int cant)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "persona_id", DbType.String, PERSONA);
                db.AddInParameter(SQL, "periodoIni", DbType.String, ini);
                db.AddInParameter(SQL, "periodoFIn", DbType.String, fin);
                db.AddInParameter(SQL, "registro_user", DbType.String, registro_user);
                db.AddInParameter(SQL, "hp", DbType.String, hp);
                db.AddInParameter(SQL, "cantidad", DbType.String, cant);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 4);
                int huboexito = db.ExecuteNonQuery(SQL);
               
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual string Verificar(String PERSONA, String ini, string fin)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "persona_id", DbType.String, PERSONA);
                db.AddInParameter(SQL, "periodoIni", DbType.String, ini);
                db.AddInParameter(SQL, "periodoFIn", DbType.String, fin);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 1);
                string huboexito = Convert.ToString(db.ExecuteScalar(SQL));
                return huboexito;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
