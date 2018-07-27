using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Text;
public partial class formularios_rdonantesempresas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        List<Hashtable> list = new List<Hashtable>();
        Hashtable campos = new Hashtable();

        var builder = new StringBuilder();
        builder.AppendLine("<table id='tblDonantes' class='table table-bordered table-striped table-hover'><thead><tr><th>ID</th><th>Donante</th><th>Fecha Ingreso</th><th>Tel. Celular</th><th>Correo</th><th>DUI</th></tr></thead><tbody>");

        campos.Add("ID", 1); campos.Add("engine", " Trident"); campos.Add("Browser", " Internet Explorer 4.0"); campos.Add("Platform", " Win 95+"); campos.Add("version", "4"); campos.Add("grade", " X"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 2); campos.Add("engine", " Trident"); campos.Add("Browser", " Internet Explorer 5.0"); campos.Add("Platform", " Win 95+"); campos.Add("version", "5"); campos.Add("grade", " C"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 3); campos.Add("engine", " Trident"); campos.Add("Browser", " Internet Explorer 5.5"); campos.Add("Platform", " Win 95+"); campos.Add("version", "5.5"); campos.Add("grade", " A"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 4); campos.Add("engine", " Trident"); campos.Add("Browser", " Internet Explorer 6"); campos.Add("Platform", " Win 98+"); campos.Add("version", "6"); campos.Add("grade", " A"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 5); campos.Add("engine", " Trident"); campos.Add("Browser", " Internet Explorer 7"); campos.Add("Platform", " Win XP SP2+"); campos.Add("version", "7"); campos.Add("grade", " A"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 6); campos.Add("engine", " Trident"); campos.Add("Browser", " AOL browser (AOL desktop)"); campos.Add("Platform", " Win XP"); campos.Add("version", "6"); campos.Add("grade", " A"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 7); campos.Add("engine", " Gecko"); campos.Add("Browser", " Firefox 1.0"); campos.Add("Platform", " Win 98+ / OSX.2+"); campos.Add("version", "1.7"); campos.Add("grade", " A"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 8); campos.Add("engine", " Gecko"); campos.Add("Browser", " Firefox 1.5"); campos.Add("Platform", " Win 98+ / OSX.2+"); campos.Add("version", "1.8"); campos.Add("grade", " A"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 9); campos.Add("engine", " Gecko"); campos.Add("Browser", " Firefox 2.0"); campos.Add("Platform", " Win 98+ / OSX.2+"); campos.Add("version", "1.8"); campos.Add("grade", " A"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 10); campos.Add("engine", " Gecko"); campos.Add("Browser", " Firefox 3.0"); campos.Add("Platform", " Win 2k+ / OSX.3+"); campos.Add("version", "1.9"); campos.Add("grade", " A"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 11); campos.Add("engine", " Gecko"); campos.Add("Browser", " Camino 1.0"); campos.Add("Platform", " OSX.2+"); campos.Add("version", "1.8"); campos.Add("grade", " A"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 12); campos.Add("engine", " Gecko"); campos.Add("Browser", " Camino 1.5"); campos.Add("Platform", " OSX.3+"); campos.Add("version", "1.8"); campos.Add("grade", " A"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 13); campos.Add("engine", " Gecko"); campos.Add("Browser", " Netscape 7.2"); campos.Add("Platform", " Win 95+ / Mac OS 8.6-9.2"); campos.Add("version", "1.7"); campos.Add("grade", " A"); list.Add(campos);


        foreach (Hashtable row in list)
        {
            builder.AppendLine("<tr><td>" + row["ID"].ToString() + "</td><td>" + row["engine"].ToString() + "</td><td>" + row["Browser"].ToString() + "</td><td>" + row["Platform"].ToString() + "</td><td>" + row["version"].ToString() + "</td><td>" + row["grade"].ToString() + "</td></tr>");
        }
        builder.AppendLine("</tbody></table>");
        //builder.AppendLine("</tbody><tfoot><tr><th>ID</th><th>Rendering engine</th><th>Browser</th><th>Platform(s)</th><th>Engine version</th><th>CSS grade</th></tr></tfoot></table>");

        contenido.InnerHtml = builder.ToString();

    }
}