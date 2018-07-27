using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Entidades;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public partial class index : System.Web.UI.Page
{
    private CorreoBLL correoBLL = new CorreoBLL();
    protected void Page_Load(object sender, EventArgs e)
    {
        string json = correoBLL.BuscarAllCorreos();
        Respuesta m = JsonConvert.DeserializeObject<Respuesta>(json);
        List<object> records = m.List;

        var builder = new StringBuilder();
        builder.AppendLine("<table id='example2' class='table table-bordered table-striped table-hover'><thead><tr><th>ID</th><th>Destino</th><th>Asunto</th><th>Estado</th><th>Fecha Registro</th></tr></thead><tbody>");


        foreach (JObject row in m.List)
        {
            //Type tipo = row.GetType();
            builder.AppendLine("<tr><td>" + row["IdCorreo"].ToString() + "</td><td>" + row["Destino"].ToString() + "</td><td>" + row["Sujeto"].ToString() + "</td><td>" + row["EstadoCorreo"].ToString() + "</td><td>" + row["FechaRegistro"].ToString() + "</tr>");
        }

        builder.AppendLine("</tbody><tfoot><tr><th>ID</th><th>Destino</th><th>Asunto</th><th>Estado</th><th>Fecha Registro</th></tr></tfoot></table>");

        contenido.InnerHtml = builder.ToString();

    }
}