
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
    public class Pred_CertificadoAlcabalaRepository
    {

        private const String nombreprocedimiento = "_Pred_Certificado_Alcabala";
        private Database db = DatabaseFactory.CreateDatabase();
        public List<Pred_Certificado_Alcabala> listartodos(int anio, string vendedor, string comprador, String filtro)
        {
            try
            {
                var coleccion = new List<Pred_Certificado_Alcabala>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "anioGeneracion", DbType.Int32, anio);
                String cadena = vendedor;
                String cad1 = "%"; String cad2 = "%"; String cad3 = "%"; String cad4 = "%";
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
                db.AddInParameter(SQL, "v1", DbType.String, cad1);
                db.AddInParameter(SQL, "v2", DbType.String, cad2);
                db.AddInParameter(SQL, "v3", DbType.String, cad3);
                db.AddInParameter(SQL, "v4", DbType.String, cad4);

                cadena = comprador; cad1 = "%"; cad2 = "%"; cad3 = "%"; cad4 = "%";
                char[] arrays = cadena.ToCharArray();
                j = 0;
                for (int i = 0; i < cadena.Length; i++)
                {

                    if (arrays[i] == ' ')
                    {
                        j++;
                    }
                    if (j == 0 && arrays[i] != ' ')
                    {
                        cad1 = cad1 + arrays[i];
                    }
                    if (j == 1 && arrays[i] != ' ')
                    {
                        cad2 = cad2 + arrays[i];
                    }
                    if (j == 2 && arrays[i] != ' ')
                    {
                        cad3 = cad3 + arrays[i];
                    }
                    if (j == 3 && arrays[i] != ' ')
                    {
                        cad4 = cad4 + arrays[i];
                    }
                }
                cad1 = cad1 + "%";
                cad2 = cad2 + "%";
                cad3 = cad3 + "%";
                cad4 = cad4 + "%";
                db.AddInParameter(SQL, "c1", DbType.String, cad1);
                db.AddInParameter(SQL, "c2", DbType.String, cad2);
                db.AddInParameter(SQL, "c3", DbType.String, cad3);
                db.AddInParameter(SQL, "c4", DbType.String, cad4);
                if (filtro == "T")
                    db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 2);
                else
                    db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 14);
                db.AddInParameter(SQL, "filtro", DbType.String, filtro);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_Certificado_Alcabala
                        {
                            certalcabala_id = lector.GetInt32(lector.GetOrdinal("certalcabala_id")),
                            persona_id = lector.GetString(lector.GetOrdinal("persona_id")),
                            comprador = lector.GetString(lector.GetOrdinal("comprador")),
                            predio_id = lector.IsDBNull(lector.GetOrdinal("predio_id")) ? default(String) : lector.GetString(lector.GetOrdinal("predio_id")),
                            tipo_alcabala = lector.IsDBNull(lector.GetOrdinal("tipo_alcabala")) ? default(String) : lector.GetString(lector.GetOrdinal("tipo_alcabala")),
                            tipo_posesion = lector.IsDBNull(lector.GetOrdinal("tipo_posesion")) ? default(String) : lector.GetString(lector.GetOrdinal("tipo_posesion")),
                            tipo_adquisicion = lector.IsDBNull(lector.GetOrdinal("tipo_adquisicion")) ? default(String) : lector.GetString(lector.GetOrdinal("tipo_adquisicion")),
                            fecha_tramite = lector.GetDateTime(lector.GetOrdinal("fecha_tramite")),
                            condomino = lector.IsDBNull(lector.GetOrdinal("condomino")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("condomino")),
                            valor_venta = lector.IsDBNull(lector.GetOrdinal("valor_venta")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("valor_venta")),
                            valuo = lector.IsDBNull(lector.GetOrdinal("valuo")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("valuo")),
                            base_imponible = lector.GetDecimal(lector.GetOrdinal("base_imponible")),
                            uits = lector.GetDecimal(lector.GetOrdinal("uits")),
                            valor_afecto = lector.GetDecimal(lector.GetOrdinal("valor_afecto")),
                            alcabala = lector.GetDecimal(lector.GetOrdinal("alcabala")),
                            registro_fecha_add = lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            registro_pc_add = lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            //registro_user_add = lector.GetInt32(lector.GetOrdinal("registro_user_add")),
                            registro_fecha_update = lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                            registro_pc_update = lector.GetString(lector.GetOrdinal("registro_pc_update")),
                            //registro_user_update = lector.GetString(lector.GetOrdinal("registro_user_update")),
                            estado = lector.GetBoolean(lector.GetOrdinal("estado")),
                            comprador_name = lector.IsDBNull(lector.GetOrdinal("comprador_name")) ? default(String) : lector.GetString(lector.GetOrdinal("comprador_name")),
                            adquisicion_descripcion = lector.IsDBNull(lector.GetOrdinal("adquisicion_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("adquisicion_descripcion")),
                            posesion_descripcion = lector.IsDBNull(lector.GetOrdinal("posesion_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("posesion_descripcion")),
                            direccion_completa = lector.IsDBNull(lector.GetOrdinal("direccion_completa")) ? default(String) : lector.GetString(lector.GetOrdinal("direccion_completa")),
                            vendedor_name = lector.IsDBNull(lector.GetOrdinal("vendedor_name")) ? default(String) : lector.GetString(lector.GetOrdinal("vendedor_name")),
                            observacion = lector.IsDBNull(lector.GetOrdinal("OBSERVACIOn")) ? default(String) : lector.GetString(lector.GetOrdinal("OBSERVACIOn")),
                            anioGeneracion = lector.IsDBNull(lector.GetOrdinal("anioGeneracion")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("anioGeneracion"))

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
        public virtual int Insert(Pred_Certificado_Alcabala Pred_Certificado_Alcabala)
        {
            try
            {
                Pred_Certificado_Alcabala Certificado_Alcabala = new Pred_Certificado_Alcabala();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "persona_id", DbType.String, Pred_Certificado_Alcabala.persona_id);
                db.AddInParameter(SQL, "area", DbType.String, Pred_Certificado_Alcabala.area);
                db.AddInParameter(SQL, "comprador", DbType.String, Pred_Certificado_Alcabala.comprador);
                db.AddInParameter(SQL, "predio_id", DbType.String, Pred_Certificado_Alcabala.predio_id);
                db.AddInParameter(SQL, "tipo_alcabala", DbType.String, Pred_Certificado_Alcabala.tipo_alcabala);
                db.AddInParameter(SQL, "tipo_adquisicion", DbType.String, Pred_Certificado_Alcabala.tipo_adquisicion);
                db.AddInParameter(SQL, "fecha_alcabala", DbType.DateTime, Pred_Certificado_Alcabala.fecha_alcabala);
                //db.AddInParameter(SQL, "fecha_tramite", DbType.DateTime, Pred_Certificado_Alcabala.fecha_tramite);
                db.AddInParameter(SQL, "condomino", DbType.Decimal, Pred_Certificado_Alcabala.condomino);
                db.AddInParameter(SQL, "valor_venta", DbType.Decimal, Pred_Certificado_Alcabala.valor_venta);
                db.AddInParameter(SQL, "valuo", DbType.Decimal, Pred_Certificado_Alcabala.valuo);
                db.AddInParameter(SQL, "base_imponible", DbType.Decimal, Pred_Certificado_Alcabala.base_imponible);//tipo_posesion
                db.AddInParameter(SQL, "tipo_posesion", DbType.String, Pred_Certificado_Alcabala.tipo_posesion);
                db.AddInParameter(SQL, "valorTerreno", DbType.Decimal, Pred_Certificado_Alcabala.valorTerreno);
                db.AddInParameter(SQL, "registro_user_add", DbType.String, Pred_Certificado_Alcabala.registro_user_add);
                db.AddInParameter(SQL, "usopredio", DbType.String, Pred_Certificado_Alcabala.usopredio);
                db.AddInParameter(SQL, "anioGeneracion", DbType.String, Pred_Certificado_Alcabala.anioGeneracion);
                db.AddInParameter(SQL, "tipo_inmueble", DbType.String, Pred_Certificado_Alcabala.tipo_inmueble);

                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 3);
                SQL.CommandTimeout = 600;
                int huboexito = Convert.ToInt32(db.ExecuteScalar(SQL));
                SQL.Dispose();
                return huboexito;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void Update(Pred_Certificado_Alcabala Pred_Certificado_Alcabala)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "certalcabala_id", DbType.Int32, Pred_Certificado_Alcabala.certalcabala_id);
                db.AddInParameter(SQL, "persona_id", DbType.String, Pred_Certificado_Alcabala.persona_id);
                db.AddInParameter(SQL, "comprador", DbType.String, Pred_Certificado_Alcabala.comprador);
                db.AddInParameter(SQL, "predio_id", DbType.String, Pred_Certificado_Alcabala.predio_id);
                db.AddInParameter(SQL, "tipo_alcabala", DbType.String, Pred_Certificado_Alcabala.tipo_alcabala);
                db.AddInParameter(SQL, "tipo_adquisicion", DbType.String, Pred_Certificado_Alcabala.tipo_adquisicion);
                db.AddInParameter(SQL, "fecha_tramite", DbType.DateTime, Pred_Certificado_Alcabala.fecha_tramite);
                db.AddInParameter(SQL, "condomino", DbType.Decimal, Pred_Certificado_Alcabala.condomino);
                db.AddInParameter(SQL, "valor_venta", DbType.Decimal, Pred_Certificado_Alcabala.valor_venta);
                db.AddInParameter(SQL, "valuo", DbType.Decimal, Pred_Certificado_Alcabala.valuo);
                db.AddInParameter(SQL, "base_imponible", DbType.Decimal, Pred_Certificado_Alcabala.base_imponible);
                db.AddInParameter(SQL, "uits", DbType.Decimal, Pred_Certificado_Alcabala.uits);
                db.AddInParameter(SQL, "valor_afecto", DbType.Decimal, Pred_Certificado_Alcabala.valor_afecto);
                db.AddInParameter(SQL, "alcabala", DbType.Decimal, Pred_Certificado_Alcabala.alcabala);
                db.AddInParameter(SQL, "registro_user_update", DbType.String, Pred_Certificado_Alcabala.registro_user_update);
                db.AddInParameter(SQL, "estado", DbType.Boolean, Pred_Certificado_Alcabala.estado);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 1);
                int huboexito = db.ExecuteNonQuery(SQL);
                if (huboexito == 0)
                {
                    throw new Exception("Error");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual Pred_Certificado_Alcabala GetByPrimaryKey(Int32 Alcabala_id)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 4);//cambiar tipo
                db.AddInParameter(SQL, "certalcabala_id", DbType.Int32, Alcabala_id);
                var Pred_Certificado_Alcabala = default(Pred_Certificado_Alcabala);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        Pred_Certificado_Alcabala = new Pred_Certificado_Alcabala
                        {
                            certalcabala_id = lector.GetInt32(lector.GetOrdinal("certalcabala_id")),
                            persona_id = lector.GetString(lector.GetOrdinal("persona_id")),
                            comprador = lector.GetString(lector.GetOrdinal("comprador")),
                            predio_id = lector.IsDBNull(lector.GetOrdinal("predio_id")) ? default(String) : lector.GetString(lector.GetOrdinal("predio_id")),
                            tipo_alcabala = lector.IsDBNull(lector.GetOrdinal("tipo_alcabala")) ? default(String) : lector.GetString(lector.GetOrdinal("tipo_alcabala")),
                            tipo_adquisicion = lector.IsDBNull(lector.GetOrdinal("tipo_adquisicion")) ? default(String) : lector.GetString(lector.GetOrdinal("tipo_adquisicion")),
                            fecha_tramite = lector.GetDateTime(lector.GetOrdinal("fecha_tramite")),
                            condomino = lector.IsDBNull(lector.GetOrdinal("condomino")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("condomino")),
                            valor_venta = lector.IsDBNull(lector.GetOrdinal("valor_venta")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("valor_venta")),
                            valuo = lector.IsDBNull(lector.GetOrdinal("valuo")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("valuo")),
                            base_imponible = lector.GetDecimal(lector.GetOrdinal("base_imponible")),
                            uits = lector.GetDecimal(lector.GetOrdinal("uits")),
                            valor_afecto = lector.GetDecimal(lector.GetOrdinal("valor_afecto")),
                            valorTerreno = lector.GetDecimal(lector.GetOrdinal("valorTerreno")),
                            alcabala = lector.GetDecimal(lector.GetOrdinal("alcabala")),
                            registro_fecha_add = lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            registro_pc_add = lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            //registro_user_add = lector.GetInt32(lector.GetOrdinal("registro_user_add")),
                            registro_fecha_update = lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                            registro_pc_update = lector.GetString(lector.GetOrdinal("registro_pc_update")),
                            //registro_user_update = lector.GetString(lector.GetOrdinal("registro_user_update")),
                            estado = lector.GetBoolean(lector.GetOrdinal("estado")),
                            tasaAlcabala = lector.GetDecimal(lector.GetOrdinal("TasaArancelaria")),
                            comprador_name = lector.GetString(lector.GetOrdinal("comprador_name")),
                            documento = lector.GetString(lector.GetOrdinal("documento")),
                            OtraDireccion = lector.GetString(lector.GetOrdinal("OtraDireccion")),
                            anio = lector.GetInt32(lector.GetOrdinal("anio")),
                            caso = lector.IsDBNull(lector.GetOrdinal("caso")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("caso")),
                            area = lector.IsDBNull(lector.GetOrdinal("area")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("area"))

                        };
                    }
                }

                SQL.Dispose();
                return Pred_Certificado_Alcabala;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual int DeudaPendiente(string persona_ID)
        {
            try
            {
                Pred_Certificado_Alcabala Certificado_Alcabala = new Pred_Certificado_Alcabala();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "persona_id", DbType.String, persona_ID);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 5);
                int huboexito = Convert.ToInt32(db.ExecuteScalar(SQL));
                SQL.Dispose();
                return huboexito;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual int DeudaPendienteTotal(string predio_id)
        {
            try
            {
                Pred_Certificado_Alcabala Certificado_Alcabala = new Pred_Certificado_Alcabala();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "predio_id", DbType.String, predio_id);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 9);
                int huboexito = Convert.ToInt32(db.ExecuteScalar(SQL));
                SQL.Dispose();
                return huboexito;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //public virtual int ExisteRecibo(string num_recibo, string per, string anio)
        //{
        //    try
        //    {
        //        Pred_Certificado_Alcabala Certificado_Alcabala = new Pred_Certificado_Alcabala();
        //        DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
        //        db.AddInParameter(SQL, "num_recibo", DbType.String, num_recibo);
        //        db.AddInParameter(SQL, "persona_id", DbType.String, per);
        //        db.AddInParameter(SQL, "anioGeneracion", DbType.String, anio);
        //        db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 6);
        //        int huboexito = Convert.ToInt32(db.ExecuteScalar(SQL));
        //        SQL.Dispose();
        //        return huboexito;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}
        public virtual int ExisteRecibo(string predio_id, string per, string anio)
        {
            try
            {
                Pred_Certificado_Alcabala Certificado_Alcabala = new Pred_Certificado_Alcabala();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "predio_id", DbType.String, predio_id);
                db.AddInParameter(SQL, "comprador", DbType.String, per);
                db.AddInParameter(SQL, "anioGeneracion", DbType.String, anio);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 6);
                int huboexito = Convert.ToInt32(db.ExecuteScalar(SQL));
                SQL.Dispose();
                return huboexito;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual int TraspasoDePropiedad(DateTime fechadesde, int tipoadquisicion, int tipoposesion, String observacion, int anioCompra, String expediente,
            String Predio_id, String persona_ID, Decimal condomino, string registro_user_add, String comprador, String recibo, Decimal porcentajeCondominioMaximo,
            String impuesto, String usopredio, String tipo_inmueble)
        {
            try
            {
                Pred_Certificado_Alcabala Certificado_Alcabala = new Pred_Certificado_Alcabala();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "fechadesde", DbType.DateTime, fechadesde);
                db.AddInParameter(SQL, "tipoadquisicion", DbType.String, tipoadquisicion);
                db.AddInParameter(SQL, "tipoposesion", DbType.String, tipoposesion);
                db.AddInParameter(SQL, "observacion", DbType.String, observacion);
                db.AddInParameter(SQL, "anioCompra", DbType.String, anioCompra);
                db.AddInParameter(SQL, "anio", DbType.String, anioCompra);
                db.AddInParameter(SQL, "expediente", DbType.String, expediente);
                //db.AddInParameter(SQL, "pagadeuda", DbType.String, pagadeuda);
                db.AddInParameter(SQL, "Predio_id", DbType.String, Predio_id);
                db.AddInParameter(SQL, "persona_ID", DbType.String, persona_ID);
                db.AddInParameter(SQL, "condomino", DbType.String, condomino);
                db.AddInParameter(SQL, "registro_user_add", DbType.String, registro_user_add);
                db.AddInParameter(SQL, "num_recibo", DbType.String, recibo);
                db.AddInParameter(SQL, "comprador", DbType.String, comprador);
                db.AddInParameter(SQL, "maximo", DbType.Decimal, porcentajeCondominioMaximo);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 7);
                db.AddInParameter(SQL, "usopredio", DbType.String, usopredio);
                db.AddInParameter(SQL, "tipo_inmueble", DbType.String, tipo_inmueble);
                SQL.CommandTimeout = 600;
                int huboexito = Convert.ToInt32(db.ExecuteScalar(SQL));
                SQL.Dispose();
                return huboexito;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual Pred_Certificado_Alcabala GetByPrimaryPeComAnoPredio(String predio_id, String persona_id, String comprador, Int32 anioGeneracion)
        {
            try
            {
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 8);//cambiar tipo
                db.AddInParameter(SQL, "predio_id", DbType.String, predio_id);
                db.AddInParameter(SQL, "persona_id", DbType.String, persona_id);
                db.AddInParameter(SQL, "comprador", DbType.String, comprador);
                db.AddInParameter(SQL, "anioGeneracion", DbType.String, anioGeneracion);
                var Pred_Certificado_Alcabala = default(Pred_Certificado_Alcabala);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        Pred_Certificado_Alcabala = new Pred_Certificado_Alcabala
                        {
                            tipo_posesion = lector.IsDBNull(lector.GetOrdinal("tipo_posesion")) ? default(String) : lector.GetString(lector.GetOrdinal("tipo_posesion")),
                            tipo_adquisicion = lector.IsDBNull(lector.GetOrdinal("tipo_adquisicion")) ? default(String) : lector.GetString(lector.GetOrdinal("tipo_adquisicion")),
                            fecha_tramite = lector.GetDateTime(lector.GetOrdinal("fecha_tramite")),
                            condomino = lector.IsDBNull(lector.GetOrdinal("condomino")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("condomino")),
                            usopredio = lector.IsDBNull(lector.GetOrdinal("usopredio")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("usopredio")),
                            tipo_inmueble = lector.IsDBNull(lector.GetOrdinal("tipo_inmueble")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("tipo_inmueble")),
                            alcabala = lector.IsDBNull(lector.GetOrdinal("alcabala")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("alcabala"))

                        };
                    }
                }

                SQL.Dispose();
                return Pred_Certificado_Alcabala;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual string ErrorExistencia(string Predio_id, string comprador, int anio, int mes)
        {
            try
            {
                Pred_Certificado_Alcabala Certificado_Alcabala = new Pred_Certificado_Alcabala();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "Predio_id", DbType.String, Predio_id);
                db.AddInParameter(SQL, "comprador", DbType.String, comprador);
                db.AddInParameter(SQL, "anio", DbType.String, anio);
                db.AddInParameter(SQL, "mes", DbType.String, mes);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 10);
                String huboexito = Convert.ToString(db.ExecuteScalar(SQL));
                SQL.Dispose();
                return huboexito;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Pred_Certificado_Alcabala> listarPagados(int anio)
        {
            try
            {
                var coleccion = new List<Pred_Certificado_Alcabala>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "anioGeneracion", DbType.Int32, anio);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 11);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_Certificado_Alcabala
                        {
                            certalcabala_id = lector.GetInt32(lector.GetOrdinal("certalcabala_id")),
                            persona_id = lector.GetString(lector.GetOrdinal("persona_id")),
                            comprador = lector.GetString(lector.GetOrdinal("comprador")),
                            predio_id = lector.IsDBNull(lector.GetOrdinal("predio_id")) ? default(String) : lector.GetString(lector.GetOrdinal("predio_id")),
                            tipo_alcabala = lector.IsDBNull(lector.GetOrdinal("tipo_alcabala")) ? default(String) : lector.GetString(lector.GetOrdinal("tipo_alcabala")),
                            tipo_posesion = lector.IsDBNull(lector.GetOrdinal("tipo_posesion")) ? default(String) : lector.GetString(lector.GetOrdinal("tipo_posesion")),
                            tipo_adquisicion = lector.IsDBNull(lector.GetOrdinal("tipo_adquisicion")) ? default(String) : lector.GetString(lector.GetOrdinal("tipo_adquisicion")),
                            fecha_tramite = lector.GetDateTime(lector.GetOrdinal("fecha_tramite")),
                            condomino = lector.IsDBNull(lector.GetOrdinal("condomino")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("condomino")),
                            valor_venta = lector.IsDBNull(lector.GetOrdinal("valor_venta")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("valor_venta")),
                            valuo = lector.IsDBNull(lector.GetOrdinal("valuo")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("valuo")),
                            base_imponible = lector.GetDecimal(lector.GetOrdinal("base_imponible")),
                            uits = lector.GetDecimal(lector.GetOrdinal("uits")),
                            valor_afecto = lector.GetDecimal(lector.GetOrdinal("valor_afecto")),
                            alcabala = lector.GetDecimal(lector.GetOrdinal("alcabala")),
                            registro_fecha_add = lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            registro_pc_add = lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            //registro_user_add = lector.GetInt32(lector.GetOrdinal("registro_user_add")),
                            registro_fecha_update = lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                            registro_pc_update = lector.GetString(lector.GetOrdinal("registro_pc_update")),
                            //registro_user_update = lector.GetString(lector.GetOrdinal("registro_user_update")),
                            estado = lector.GetBoolean(lector.GetOrdinal("estado")),
                            comprador_name = lector.IsDBNull(lector.GetOrdinal("comprador_name")) ? default(String) : lector.GetString(lector.GetOrdinal("comprador_name")),
                            adquisicion_descripcion = lector.IsDBNull(lector.GetOrdinal("adquisicion_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("adquisicion_descripcion")),
                            posesion_descripcion = lector.IsDBNull(lector.GetOrdinal("posesion_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("posesion_descripcion")),
                            direccion_completa = lector.IsDBNull(lector.GetOrdinal("direccion_completa")) ? default(String) : lector.GetString(lector.GetOrdinal("direccion_completa")),
                            vendedor_name = lector.IsDBNull(lector.GetOrdinal("vendedor_name")) ? default(String) : lector.GetString(lector.GetOrdinal("vendedor_name")),
                            anioGeneracion = lector.IsDBNull(lector.GetOrdinal("anioGeneracion")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("anioGeneracion"))

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
        public List<Pred_Certificado_Alcabala> listarPagadosxPersona(int anio, string persona)
        {
            try
            {
                var coleccion = new List<Pred_Certificado_Alcabala>();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "anioGeneracion", DbType.Int32, anio);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.Byte, 12);
                db.AddInParameter(SQL, "persona_id", DbType.String, persona);
                using (var lector = db.ExecuteReader(SQL))
                {
                    while (lector.Read())
                    {
                        coleccion.Add(new Pred_Certificado_Alcabala
                        {
                            certalcabala_id = lector.GetInt32(lector.GetOrdinal("certalcabala_id")),
                            persona_id = lector.GetString(lector.GetOrdinal("persona_id")),
                            comprador = lector.GetString(lector.GetOrdinal("comprador")),
                            predio_id = lector.IsDBNull(lector.GetOrdinal("predio_id")) ? default(String) : lector.GetString(lector.GetOrdinal("predio_id")),
                            tipo_alcabala = lector.IsDBNull(lector.GetOrdinal("tipo_alcabala")) ? default(String) : lector.GetString(lector.GetOrdinal("tipo_alcabala")),
                            tipo_posesion = lector.IsDBNull(lector.GetOrdinal("tipo_posesion")) ? default(String) : lector.GetString(lector.GetOrdinal("tipo_posesion")),
                            tipo_adquisicion = lector.IsDBNull(lector.GetOrdinal("tipo_adquisicion")) ? default(String) : lector.GetString(lector.GetOrdinal("tipo_adquisicion")),
                            fecha_tramite = lector.GetDateTime(lector.GetOrdinal("fecha_tramite")),
                            condomino = lector.IsDBNull(lector.GetOrdinal("condomino")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("condomino")),
                            valor_venta = lector.IsDBNull(lector.GetOrdinal("valor_venta")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("valor_venta")),
                            valuo = lector.IsDBNull(lector.GetOrdinal("valuo")) ? default(Decimal) : lector.GetDecimal(lector.GetOrdinal("valuo")),
                            base_imponible = lector.GetDecimal(lector.GetOrdinal("base_imponible")),
                            uits = lector.GetDecimal(lector.GetOrdinal("uits")),
                            valor_afecto = lector.GetDecimal(lector.GetOrdinal("valor_afecto")),
                            alcabala = lector.GetDecimal(lector.GetOrdinal("alcabala")),
                            registro_fecha_add = lector.GetDateTime(lector.GetOrdinal("registro_fecha_add")),
                            registro_pc_add = lector.GetString(lector.GetOrdinal("registro_pc_add")),
                            //registro_user_add = lector.GetInt32(lector.GetOrdinal("registro_user_add")),
                            registro_fecha_update = lector.GetDateTime(lector.GetOrdinal("registro_fecha_update")),
                            registro_pc_update = lector.GetString(lector.GetOrdinal("registro_pc_update")),
                            //registro_user_update = lector.GetString(lector.GetOrdinal("registro_user_update")),
                            estado = lector.GetBoolean(lector.GetOrdinal("estado")),
                            comprador_name = lector.IsDBNull(lector.GetOrdinal("comprador_name")) ? default(String) : lector.GetString(lector.GetOrdinal("comprador_name")),
                            adquisicion_descripcion = lector.IsDBNull(lector.GetOrdinal("adquisicion_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("adquisicion_descripcion")),
                            posesion_descripcion = lector.IsDBNull(lector.GetOrdinal("posesion_descripcion")) ? default(String) : lector.GetString(lector.GetOrdinal("posesion_descripcion")),
                            direccion_completa = lector.IsDBNull(lector.GetOrdinal("direccion_completa")) ? default(String) : lector.GetString(lector.GetOrdinal("direccion_completa")),
                            vendedor_name = lector.IsDBNull(lector.GetOrdinal("vendedor_name")) ? default(String) : lector.GetString(lector.GetOrdinal("vendedor_name")),
                            anioGeneracion = lector.IsDBNull(lector.GetOrdinal("anioGeneracion")) ? default(Int32) : lector.GetInt32(lector.GetOrdinal("anioGeneracion")),
                            area = lector.IsDBNull(lector.GetOrdinal("area")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("area"))

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
        public virtual string Eliminar(int certalcabala_id)
        {
            try
            {
                Pred_Certificado_Alcabala Certificado_Alcabala = new Pred_Certificado_Alcabala();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "certalcabala_id", DbType.String, certalcabala_id);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 13);
                string g = Convert.ToString(db.ExecuteScalar(SQL));
                return g;
                SQL.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public virtual int InsertAlcabalaPasado(Pred_Certificado_Alcabala Pred_Certificado_Alcabala)
        {
            try
            {
                Pred_Certificado_Alcabala Certificado_Alcabala = new Pred_Certificado_Alcabala();
                DbCommand SQL = db.GetStoredProcCommand(nombreprocedimiento);
                db.AddInParameter(SQL, "persona_id", DbType.String, Pred_Certificado_Alcabala.persona_id);
                db.AddInParameter(SQL, "area", DbType.String, Pred_Certificado_Alcabala.area);
                db.AddInParameter(SQL, "comprador", DbType.String, Pred_Certificado_Alcabala.comprador);
                db.AddInParameter(SQL, "predio_id", DbType.String, Pred_Certificado_Alcabala.predio_id);
                db.AddInParameter(SQL, "tipo_alcabala", DbType.String, Pred_Certificado_Alcabala.tipo_alcabala);
                db.AddInParameter(SQL, "tipo_adquisicion", DbType.String, Pred_Certificado_Alcabala.tipo_adquisicion);
                db.AddInParameter(SQL, "fecha_alcabala", DbType.DateTime, Pred_Certificado_Alcabala.fecha_alcabala);
                db.AddInParameter(SQL, "condomino", DbType.Decimal, Pred_Certificado_Alcabala.condomino);
                db.AddInParameter(SQL, "valor_venta", DbType.Decimal, Pred_Certificado_Alcabala.valor_venta);
                db.AddInParameter(SQL, "valuo", DbType.Decimal, Pred_Certificado_Alcabala.valuo);
                db.AddInParameter(SQL, "base_imponible", DbType.Decimal, Pred_Certificado_Alcabala.base_imponible);//tipo_posesion
                db.AddInParameter(SQL, "tipo_posesion", DbType.String, Pred_Certificado_Alcabala.tipo_posesion);
                db.AddInParameter(SQL, "valorTerreno", DbType.Decimal, Pred_Certificado_Alcabala.valorTerreno);
                db.AddInParameter(SQL, "registro_user_add", DbType.String, Pred_Certificado_Alcabala.registro_user_add);
                db.AddInParameter(SQL, "usopredio", DbType.String, Pred_Certificado_Alcabala.usopredio);
                db.AddInParameter(SQL, "anioGeneracion", DbType.String, Pred_Certificado_Alcabala.anioGeneracion);
                db.AddInParameter(SQL, "tipo_inmueble", DbType.String, Pred_Certificado_Alcabala.tipo_inmueble);
                db.AddInParameter(SQL, "Tipoconsulta", DbType.String, 15);
                SQL.CommandTimeout = 600;
                int huboexito = Convert.ToInt32(db.ExecuteScalar(SQL));
                SQL.Dispose();
                return huboexito;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
