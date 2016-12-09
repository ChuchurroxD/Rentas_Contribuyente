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
    public class Repo_PorcentajePrediosRepository
    {
        private const String nombreprocedimiento = "_Repo_PorcentajePredios";
        private Database db = DatabaseFactory.CreateDatabase();

        public List<Repo_PorcentajePredios> listarPorcentaje(Int32 anioDesde, Int32 anioHasta)
        {
            try
            {
                var coleccion = new List<Repo_PorcentajePredios>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "anioDesde", DbType.Int32, anioDesde);
                db.AddInParameter(SQL, "anioHasta", DbType.Int32, anioHasta);
                db.AddInParameter(SQL, "tipoConsulta", DbType.Byte, 1);//modificar de acuerdo a
                                                                       //rol_id, rol_nombre, rol_descripcion, rol_activo,idUnidadNegocio
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Repo_PorcentajePredios
                        {
                            tipo_predio = lector.GetInt32(lector.GetOrdinal("tipo_predio")),
                            descripcion = lector.IsDBNull(lector.GetOrdinal("descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("descripcion")),
                            porcentaje = lector.GetDecimal(lector.GetOrdinal("porcentaje")),
                            cantidad = lector.GetInt32(lector.GetOrdinal("cantidad"))
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

        public List<Repo_PorcentajePredios> listarPorcentaje2(Int32 anioDesde, Int32 anioHasta)
        {
            try
            {
                var coleccion = new List<Repo_PorcentajePredios>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "anioDesde", DbType.Int32, anioDesde);
                db.AddInParameter(SQL, "anioHasta", DbType.Int32, anioHasta);
                db.AddInParameter(SQL, "tipoConsulta", DbType.Byte, 2);//modificar de acuerdo a
                                                                       //rol_id, rol_nombre, rol_descripcion, rol_activo,idUnidadNegocio
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Repo_PorcentajePredios
                        {
                            tipo_predio = lector.GetInt32(lector.GetOrdinal("piso_clasificacion")),
                            descripcion = lector.IsDBNull(lector.GetOrdinal("descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("descripcion")),
                            porcentaje = lector.GetDecimal(lector.GetOrdinal("porcentaje")),
                            cantidad = lector.GetInt32(lector.GetOrdinal("cantidad"))
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
