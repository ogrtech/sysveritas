using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.Data.SqlClient;
using Entidades;

/// <summary>
/// Descripción breve de CorreoDA
/// </summary>
namespace DAL
{
    public class CorreoDAL
    {
        //public CorreoDAL()
        //{
        //    //
        //    // TODO: Agregar aquí la lógica del constructor
        //    //
        //}

        public string BuscarAllCorreos()
        {
            string jsonStr = null;
            var respuesta = new object();
            List<object> list = new List<object>();
            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["cnVeritas"].ToString());
            string sql = "SELECT idCorreo,destino,sujeto,contenido,Estado_Correo.idEstadoCorreo,Estado_Correo.estadoCorreo,fechaRegistro,idUsuario FROM CORREOS inner join Estado_Correo on CORREOS.idEstadoCorreo = Estado_Correo.idEstadoCorreo order by fechaRegistro desc";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader mydr = null;
            try
            {
                conn.Open();
                mydr = cmd.ExecuteReader();
                if (mydr.HasRows)
                {
                    while (mydr.Read())
                    {
                        list.Add(new
                        {
                            IdCorreo = mydr["idCorreo"].ToString(),
                            Destino = mydr["destino"].ToString(),
                            Sujeto = mydr["sujeto"].ToString(),
                            EstadoCorreo = mydr["estadoCorreo"].ToString(),
                            FechaRegistro = mydr["fechaRegistro"].ToString()
                        });
                    }
                }
                if (list.Count > 0)
                {
                    respuesta = new
                    {
                        Msg = string.Empty,
                        Status = true,
                        List = list
                    };
                    jsonStr = JsonConvert.SerializeObject(respuesta);
                }
            }
            catch (Exception ex)
            {
                respuesta = new
                {
                    Msg = ex.Message,
                    Status = false,
                    List = list
                };
                jsonStr = JsonConvert.SerializeObject(respuesta);
            }
            finally
            {
                if (mydr != null) { mydr.Close(); mydr.Dispose(); cmd.Dispose(); }
                if (conn != null) { conn.Close(); conn.Dispose(); }
            }
            return jsonStr;
        }

        public string InsertCorreo(string destino, string sujeto, string contenido, Int64 idUsuario)
        {
            Int64 id = 0;
            string jsonStr = null;
            var respuesta = new object();
            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["cnVeritas"].ConnectionString);
            string sql = "insert into CORREOS (destino,sujeto,contenido,idUsuario) values (@destino,@sujeto,@contenido,@idUsuario);SELECT IDENT_CURRENT('CORREOS') as id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@destino", destino);
            cmd.Parameters.AddWithValue("@sujeto", sujeto);
            cmd.Parameters.AddWithValue("@contenido", contenido);
            cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
            try
            {
                conn.Open();
                cmd.Dispose();
                id = Convert.ToInt64(cmd.ExecuteScalar());
                if (id > 0)
                {
                    respuesta = new
                    {
                        Msg = "Correo agregado satisfactoriamente",
                        Status = true,
                        IdIdentidad = Convert.ToInt64(id)
                    };
                    jsonStr = JsonConvert.SerializeObject(respuesta);
                }

            }
            catch (Exception ex)
            {
                respuesta = new
                {
                    Msg = ex.Message,
                    Status = false,
                    IdIdentidad = Convert.ToInt64(id)
                };
                jsonStr = JsonConvert.SerializeObject(respuesta);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return jsonStr;
        }
    }
}
