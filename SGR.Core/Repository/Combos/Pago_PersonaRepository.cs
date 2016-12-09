using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGR.Entity.Model.Combos;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Data.Common;
namespace SGR.Core.Repository.Combos
{
    public class Pago_PersonaRepository
    {
        private const String nombreprocedimiento = "_combos";
        private Database db = DatabaseFactory.CreateDatabase();
        public List<Pago_Persona> listartodos(string persona_ID)
        {
            try
            {
                var coleccion = new List<Pago_Persona>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 1);
                db.AddInParameter(SQL, "persona", DbType.String, persona_ID);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pago_Persona
                        {                            
                            persona_ID = lector.GetString(lector.GetOrdinal("persona_ID")).Trim(),
                            persona_Desc = lector.GetString(lector.GetOrdinal("NombreCompleto"))
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
        public List<Pago_Persona> listarcontribuyentes(string busqueda)
        {
            try
            {
                var coleccion = new List<Pago_Persona>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);
                String cadena = busqueda;
                String cad1 = "%";
                String cad2 = "%";
                String cad3 = "%";
                String cad4 = "%";
                char[] array = cadena.ToCharArray();
                int j = 0;
                for (int i = 0; i < cadena.Length; i++)
                {

                    if (array[i] == ' ')
                    {
                        j++;
                    }
                    if (j == 0 && array[i] != ' ')
                    {
                        cad1 = cad1 + array[i];
                    }
                    if (j == 1 && array[i] != ' ')
                    {
                        cad2 = cad2 + array[i];
                    }
                    if (j == 2 && array[i] != ' ')
                    {
                        cad3 = cad3 + array[i];
                    }
                    if (j == 3 && array[i] != ' ')
                    {
                        cad4 = cad4 + array[i];
                    }
                }
                cad1 = cad1 + "%";
                cad2 = cad2 + "%";
                cad3 = cad3 + "%";
                cad4 = cad4 + "%";
                db.AddInParameter(SQL, "n1", DbType.String, cad1);
                db.AddInParameter(SQL, "n2", DbType.String, cad2);
                db.AddInParameter(SQL, "n3", DbType.String, cad3);
                db.AddInParameter(SQL, "n4", DbType.String, cad4);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pago_Persona
                        {
                            persona_ID = lector.GetString(lector.GetOrdinal("codigo")).Trim(),
                            persona_Desc = lector.GetString(lector.GetOrdinal("descripcion"))
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
        public List<Pago_Persona> listarcontribuyentesPN(String predio_id,int periodo,string busqueda)
        {
            try
            {
                var coleccion = new List<Pago_Persona>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 6);
                db.AddInParameter(SQL, "predio_id", DbType.String, predio_id);
                db.AddInParameter(SQL, "periodo", DbType.String, periodo);
                String cadena = busqueda;
                String cad1 = "%";
                String cad2 = "%";
                String cad3 = "%";
                String cad4 = "%";
                char[] array = cadena.ToCharArray();
                int j = 0;
                for (int i = 0; i < cadena.Length; i++)
                {

                    if (array[i] == ' ')
                    {
                        j++;
                    }
                    if (j == 0 && array[i] != ' ')
                    {
                        cad1 = cad1 + array[i];
                    }
                    if (j == 1 && array[i] != ' ')
                    {
                        cad2 = cad2 + array[i];
                    }
                    if (j == 2 && array[i] != ' ')
                    {
                        cad3 = cad3 + array[i];
                    }
                    if (j == 3 && array[i] != ' ')
                    {
                        cad4 = cad4 + array[i];
                    }
                }
                cad1 = cad1 + "%";
                cad2 = cad2 + "%";
                cad3 = cad3 + "%";
                cad4 = cad4 + "%";
                db.AddInParameter(SQL, "n1", DbType.String, cad1);
                db.AddInParameter(SQL, "n2", DbType.String, cad2);
                db.AddInParameter(SQL, "n3", DbType.String, cad3);
                db.AddInParameter(SQL, "n4", DbType.String, cad4);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pago_Persona
                        {
                            persona_ID = lector.GetString(lector.GetOrdinal("codigo")).Trim(),
                            persona_Desc = lector.GetString(lector.GetOrdinal("descripcion"))
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
        public List<Pago_Persona> listarcontribuyentesPM(String predio_id, int periodo,String per_id,string busqueda)
        {
            try
            {
                var coleccion = new List<Pago_Persona>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 5);
                db.AddInParameter(SQL, "predio_id", DbType.String, predio_id);
                db.AddInParameter(SQL, "periodo", DbType.String, periodo);
                db.AddInParameter(SQL, "persona", DbType.String, per_id);

                String cadena = busqueda;
                String cad1 = "%";
                String cad2 = "%";
                String cad3 = "%";
                String cad4 = "%";
                char[] array = cadena.ToCharArray();
                int j = 0;
                for (int i = 0; i < cadena.Length; i++)
                {

                    if (array[i] == ' ')
                    {
                        j++;
                    }
                    if (j == 0 && array[i] != ' ')
                    {
                        cad1 = cad1 + array[i];
                    }
                    if (j == 1 && array[i] != ' ')
                    {
                        cad2 = cad2 + array[i];
                    }
                    if (j == 2 && array[i] != ' ')
                    {
                        cad3 = cad3 + array[i];
                    }
                    if (j == 3 && array[i] != ' ')
                    {
                        cad4 = cad4 + array[i];
                    }
                }
                cad1 = cad1 + "%";
                cad2 = cad2 + "%";
                cad3 = cad3 + "%";
                cad4 = cad4 + "%";
                db.AddInParameter(SQL, "n1", DbType.String, cad1);
                db.AddInParameter(SQL, "n2", DbType.String, cad2);
                db.AddInParameter(SQL, "n3", DbType.String, cad3);
                db.AddInParameter(SQL, "n4", DbType.String, cad4);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pago_Persona
                        {
                            persona_ID = lector.GetString(lector.GetOrdinal("codigo")).Trim(),
                            persona_Desc = lector.GetString(lector.GetOrdinal("descripcion"))
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
        public List<Pago_Persona> listarpersonaxID(string predio_id, Int32 periodo)
        {
            try
            {
                var coleccion = new List<Pago_Persona>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 4);
                db.AddInParameter(SQL, "predio_id", DbType.String, predio_id);
                db.AddInParameter(SQL, "periodo", DbType.String, periodo);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pago_Persona
                        {
                            persona_ID = lector.GetString(lector.GetOrdinal("codigo")).Trim(),
                            persona_Desc = lector.GetString(lector.GetOrdinal("descripcion"))
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
        public List<Pago_Persona> buscar(String busqueda)
        {
            try
            {
                var coleccion = new List<Pago_Persona>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
                db.AddInParameter(SQL, "busqueda", DbType.String, busqueda);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pago_Persona
                        {
                            persona_ID = lector.GetString(lector.GetOrdinal("persona_ID")).Trim(),
                            persona_Desc = lector.GetString(lector.GetOrdinal("NombreCompleto"))
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
        public List<Pago_Persona> listarcontribuyentesCodigo(string busqueda)
        {
            try
            {
                var coleccion = new List<Pago_Persona>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 3);
                db.AddInParameter(SQL, "persona", DbType.String, busqueda);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pago_Persona
                        {
                            persona_ID = lector.GetString(lector.GetOrdinal("codigo")).Trim(),
                            persona_Desc = lector.GetString(lector.GetOrdinal("descripcion"))
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
