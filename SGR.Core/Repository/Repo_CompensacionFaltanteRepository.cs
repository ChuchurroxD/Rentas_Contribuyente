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
    public class Repo_CompensacionFaltanteRepository
    {
        private const String nombreprocedimiento = "_ReporteCompensacionFaltante";
        private Database db = DatabaseFactory.CreateDatabase();

        public List<Repo_CompensacionFaltante> listarCompensacionesFaltantes(Int32 anio)
        {
            try
            {
                var coleccion = new List<Repo_CompensacionFaltante>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "anio", DbType.Int32, anio);
                db.AddInParameter(SQL, "tipoConsulta", DbType.Byte, 1);//modificar de acuerdo a
                                                                       //rol_id, rol_nombre, rol_descripcion, rol_activo,idUnidadNegocio
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Repo_CompensacionFaltante
                        {
                            compensacionFaltante_id = lector.GetInt32(lector.GetOrdinal("compensacionFaltante_id")),
                            persona_id = lector.GetString(lector.GetOrdinal("persona_id")).ToString().Trim(),
                            razon_social = lector.IsDBNull(lector.GetOrdinal("razon_social")) ? default(String) : lector.GetString(lector.GetOrdinal("razon_social")),
                            predio_id = lector.GetString(lector.GetOrdinal("predio_ID")).ToString().Trim(),
                            tributos_id = lector.GetString(lector.GetOrdinal("tributos_ID")).ToString().Trim(),
                            trib_descripcion = lector.IsDBNull(lector.GetOrdinal("descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("descripcion")),
                            montoFaltante = lector.GetDecimal(lector.GetOrdinal("montoFaltante")),
                            observacion = lector.IsDBNull(lector.GetOrdinal("observacion")) ? default(String) : lector.GetString(lector.GetOrdinal("observacion")),
                            expediente = lector.IsDBNull(lector.GetOrdinal("expediente")) ? default(String) : lector.GetString(lector.GetOrdinal("expediente")),
                            anio = lector.GetInt32(lector.GetOrdinal("anio")),
                            mes = lector.GetInt32(lector.GetOrdinal("mes"))
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

        public List<Repo_CompensacionFaltante> buscar(Int32 anio, string busqueda)
        {
            try
            {
                var coleccion = new List<Repo_CompensacionFaltante>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "anio", DbType.Int32, anio);
                db.AddInParameter(SQL, "busqueda", DbType.String, busqueda);
                db.AddInParameter(SQL, "tipoConsulta", DbType.Byte, 2);//modificar de acuerdo a
                                                                       //rol_id, rol_nombre, rol_descripcion, rol_activo,idUnidadNegocio
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Repo_CompensacionFaltante
                        {
                            compensacionFaltante_id = lector.GetInt32(lector.GetOrdinal("compensacionFaltante_id")),
                            persona_id = lector.GetString(lector.GetOrdinal("persona_id")).ToString().Trim(),
                            razon_social = lector.IsDBNull(lector.GetOrdinal("razon_social")) ? default(String) : lector.GetString(lector.GetOrdinal("razon_social")),
                            predio_id = lector.GetString(lector.GetOrdinal("predio_ID")).ToString().Trim(),
                            tributos_id = lector.GetString(lector.GetOrdinal("tributos_ID")).ToString().Trim(),
                            trib_descripcion = lector.IsDBNull(lector.GetOrdinal("descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("descripcion")),
                            montoFaltante = lector.GetDecimal(lector.GetOrdinal("montoFaltante")),
                            observacion = lector.IsDBNull(lector.GetOrdinal("observacion")) ? default(String) : lector.GetString(lector.GetOrdinal("observacion")),
                            expediente = lector.IsDBNull(lector.GetOrdinal("expediente")) ? default(String) : lector.GetString(lector.GetOrdinal("expediente")),
                            anio = lector.GetInt32(lector.GetOrdinal("anio")),
                            mes = lector.GetInt32(lector.GetOrdinal("mes"))
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
