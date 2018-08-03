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

public partial class index : System.Web.UI.Page
{
    private CorreoBLL correoBLL = new CorreoBLL();
    protected void Page_Load(object sender, EventArgs e)
    {
        string json = correoBLL.BuscarAllCorreos();
        var jCorreo = JsonConvert.DeserializeObject<dynamic>(json);
        
        var builder = new StringBuilder();
        builder.AppendLine("<table id='example2' class='table table-bordered table-striped table-hover'><thead><tr><th>ID</th><th>Destino</th><th>Asunto</th><th>Estado</th><th>Fecha Registro</th></tr></thead><tbody>");
        
        foreach (var row in jCorreo.List)
        {
            builder.AppendLine("<tr><td>" + row.IdCorreo + "</td><td>" + row.Destino + "</td><td>" + row.Sujeto + "</td><td>" + row.EstadoCorreo + "</td><td>" + row.FechaRegistro + "</tr>");
        }

        builder.AppendLine("</tbody><tfoot><tr><th>ID</th><th>Destino</th><th>Asunto</th><th>Estado</th><th>Fecha Registro</th></tr></tfoot></table>");

        contenido.InnerHtml = builder.ToString();

    }
}