using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Respuesta
/// </summary>
namespace Entidades
{
    public class Respuesta
    {
        //public Respuesta()
        //{
        //    //
        //    // TODO: Agregar aquí la lógica del constructor
        //    //
        //}

        //para cualquier emensaje
        private string msg;
        public string Msg
        {
            get { return msg; }
            set { msg = value; }
        }

        //estado de la transaccion
        private bool status;
        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        //al momento de hacer el insert es el IDENT_CURRENT
        private Int64 idIdentidad;
        public Int64 IdIdentidad
        {
            get { return idIdentidad; }
            set { idIdentidad = value; }
        }

        //las filas afectadas al momento de hacer un update
        private Int64 affectedrow;
        public Int64 AffectedRow
        {
            get { return affectedrow; }
            set { affectedrow = value; }
        }

        //meter cualquier cosa al devolver un valor nada mas
        private string escalar;
        public string Escalar
        {
            get { return escalar; }
            set { escalar = value; }
        }

        //donde se agrega el select pero solo de un registro
        private object record;
        public object Record
        {
            get { return record; }
            set { record = value; }
        }

        //donde se agrega el select de todos los registro
        private List<object> list;
        public List<object> List
        {
            get { return list; }
            set { list = value; }
        }
    }
}