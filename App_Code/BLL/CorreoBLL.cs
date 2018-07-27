using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

/// <summary>
/// Descripción breve de CorreoBLL
/// </summary>
namespace BLL
{
    public class CorreoBLL
    {
        //public CorreoBLL()
        //{
        //    //
        //    // TODO: Agregar aquí la lógica del constructor
        //    //
        //}
        private CorreoDAL correoDAL = new CorreoDAL();
        public string BuscarAllCorreos()
        {
            return correoDAL.BuscarAllCorreos();
        }

        public string InsertCorreo(string destino, string sujeto, string contenido, Int64 idUsuario)
        {
            return correoDAL.InsertCorreo(destino, sujeto, contenido, idUsuario);
        }
    }
}
