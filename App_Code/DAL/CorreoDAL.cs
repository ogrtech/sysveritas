using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.Data.SqlClient;

/// <summary>
/// Descripción breve de CorreoDA
/// </summary>
public class CorreoDAL
{
    public CorreoDAL()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public string Prueba()
    {
        string jsonStr = null;
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
                list.Add(new { IdCorreo = mydr["idCorreo"].ToString(), Destino = mydr["destino"].ToString(), EstadoCorreo = mydr["estadoCorreo"].ToString(), FechaRegistro = mydr["fechaRegistro"].ToString() });

            }
            if (list.Count > 0)
            {
                jsonStr = JsonConvert.SerializeObject(list);
            }
        }
        catch (Exception ex)
        {
            throw;
        }
        finally
        {

        }
        return jsonStr;
    }
}