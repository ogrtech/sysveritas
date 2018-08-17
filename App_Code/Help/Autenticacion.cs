using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Help
{
    /// <summary>
    /// Descripción breve de Autentificacion
    /// </summary>
    public class Autentificacion
    {
        public Autentificacion()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }

        public static string getSalt(string usuario)
        {
            string r = "";
            //consulta a la base de datos
            string sql = @"SELECT salt FROM ts WHERE idUsuario in (select idUsuario from USUARIOS where usuario = @user)";
            //cadena conexion
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnVeritas"].ToString()))
            {
                conn.Open();//abrimos conexion

                SqlCommand cmd = new SqlCommand(sql, conn); //ejecutamos la instruccion
                cmd.Parameters.AddWithValue("@user", usuario); //enviamos los parametros

                r = Convert.ToString(cmd.ExecuteScalar()); //devuelve la fila afectada
            }
            return r;
        }

        public static bool Autenticar(string usuario, string password)
        {
            //consulta a la base de datos
            string sql = @"SELECT COUNT(*) FROM USUARIOS WHERE usuario = @user AND llave = @pass";
            //cadena conexion
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnVeritas"].ToString()))
            {
                conn.Open();//abrimos conexion

                SqlCommand cmd = new SqlCommand(sql, conn); //ejecutamos la instruccion
                cmd.Parameters.AddWithValue("@user", usuario); //enviamos los parametros
                cmd.Parameters.AddWithValue("@pass", password);

                int count = Convert.ToInt32(cmd.ExecuteScalar()); //devuelve la fila afectada

                if (count == 0)
                    return false;
                else
                    return true;

            }
        }
    }
}