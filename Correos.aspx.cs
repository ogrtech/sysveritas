using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        List<Hashtable> list = new List<Hashtable>();
        Hashtable campos = new Hashtable();

        var builder = new StringBuilder();
        builder.AppendLine("<table id='example2' class='table table-bordered table-striped table-hover'><thead><tr><th>ID</th><th>Rendering engine</th><th>Browser</th><th>Platform(s)</th><th>Engine version</th><th>CSS grade</th></tr></thead><tbody>");

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
        campos = new Hashtable(); campos.Add("ID", 14); campos.Add("engine", " Gecko"); campos.Add("Browser", " Netscape Browser 8"); campos.Add("Platform", " Win 98SE+"); campos.Add("version", "1.7"); campos.Add("grade", " A"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 15); campos.Add("engine", " Gecko"); campos.Add("Browser", " Netscape Navigator 9"); campos.Add("Platform", " Win 98+ / OSX.2+"); campos.Add("version", "1.8"); campos.Add("grade", " A"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 16); campos.Add("engine", " Gecko"); campos.Add("Browser", " Mozilla 1.0"); campos.Add("Platform", " Win 95+ / OSX.1+"); campos.Add("version", "1"); campos.Add("grade", " A"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 17); campos.Add("engine", " Gecko"); campos.Add("Browser", " Mozilla 1.1"); campos.Add("Platform", " Win 95+ / OSX.1+"); campos.Add("version", "1.1"); campos.Add("grade", " A"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 18); campos.Add("engine", " Gecko"); campos.Add("Browser", " Mozilla 1.2"); campos.Add("Platform", " Win 95+ / OSX.1+"); campos.Add("version", "1.2"); campos.Add("grade", " A"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 19); campos.Add("engine", " Gecko"); campos.Add("Browser", " Mozilla 1.3"); campos.Add("Platform", " Win 95+ / OSX.1+"); campos.Add("version", "1.3"); campos.Add("grade", " A"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 20); campos.Add("engine", " Gecko"); campos.Add("Browser", " Mozilla 1.4"); campos.Add("Platform", " Win 95+ / OSX.1+"); campos.Add("version", "1.4"); campos.Add("grade", " A"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 21); campos.Add("engine", " Gecko"); campos.Add("Browser", " Mozilla 1.5"); campos.Add("Platform", " Win 95+ / OSX.1+"); campos.Add("version", "1.5"); campos.Add("grade", " A"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 22); campos.Add("engine", " Gecko"); campos.Add("Browser", " Mozilla 1.6"); campos.Add("Platform", " Win 95+ / OSX.1+"); campos.Add("version", "1.6"); campos.Add("grade", " A"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 23); campos.Add("engine", " Gecko"); campos.Add("Browser", " Mozilla 1.7"); campos.Add("Platform", " Win 98+ / OSX.1+"); campos.Add("version", "1.7"); campos.Add("grade", " A"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 24); campos.Add("engine", " Gecko"); campos.Add("Browser", " Mozilla 1.8"); campos.Add("Platform", " Win 98+ / OSX.1+"); campos.Add("version", "1.8"); campos.Add("grade", " A"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 25); campos.Add("engine", " Gecko"); campos.Add("Browser", " Seamonkey 1.1"); campos.Add("Platform", " Win 98+ / OSX.2+"); campos.Add("version", "1.8"); campos.Add("grade", " A"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 26); campos.Add("engine", " Gecko"); campos.Add("Browser", " Epiphany 2.20"); campos.Add("Platform", " Gnome"); campos.Add("version", "1.8"); campos.Add("grade", " A"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 27); campos.Add("engine", " Webkit"); campos.Add("Browser", " Safari 1.2"); campos.Add("Platform", " OSX.3"); campos.Add("version", "125.5"); campos.Add("grade", " A"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 28); campos.Add("engine", " Webkit"); campos.Add("Browser", " Safari 1.3"); campos.Add("Platform", " OSX.3"); campos.Add("version", "312.8"); campos.Add("grade", " A"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 29); campos.Add("engine", " Webkit"); campos.Add("Browser", " Safari 2.0"); campos.Add("Platform", " OSX.4+"); campos.Add("version", "419.3"); campos.Add("grade", " A"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 30); campos.Add("engine", " Webkit"); campos.Add("Browser", " Safari 3.0"); campos.Add("Platform", " OSX.4+"); campos.Add("version", "522.1"); campos.Add("grade", " A"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 31); campos.Add("engine", " Webkit"); campos.Add("Browser", " OmniWeb 5.5"); campos.Add("Platform", " OSX.4+"); campos.Add("version", "420"); campos.Add("grade", " A"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 32); campos.Add("engine", " Webkit"); campos.Add("Browser", " iPod Touch / iPhone"); campos.Add("Platform", " iPod"); campos.Add("version", "420.1"); campos.Add("grade", " A"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 33); campos.Add("engine", " Webkit"); campos.Add("Browser", " S60"); campos.Add("Platform", " S60"); campos.Add("version", "413"); campos.Add("grade", " A"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 34); campos.Add("engine", " Presto"); campos.Add("Browser", " Opera 7.0"); campos.Add("Platform", " Win 95+ / OSX.1+"); campos.Add("version", " -"); campos.Add("grade", " A"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 35); campos.Add("engine", " Presto"); campos.Add("Browser", " Opera 7.5"); campos.Add("Platform", " Win 95+ / OSX.2+"); campos.Add("version", " -"); campos.Add("grade", " A"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 36); campos.Add("engine", " Presto"); campos.Add("Browser", " Opera 8.0"); campos.Add("Platform", " Win 95+ / OSX.2+"); campos.Add("version", " -"); campos.Add("grade", " A"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 37); campos.Add("engine", " Presto"); campos.Add("Browser", " Opera 8.5"); campos.Add("Platform", " Win 95+ / OSX.2+"); campos.Add("version", " -"); campos.Add("grade", " A"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 38); campos.Add("engine", " Presto"); campos.Add("Browser", " Opera 9.0"); campos.Add("Platform", " Win 95+ / OSX.3+"); campos.Add("version", " -"); campos.Add("grade", " A"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 39); campos.Add("engine", " Presto"); campos.Add("Browser", " Opera 9.2"); campos.Add("Platform", " Win 88+ / OSX.3+"); campos.Add("version", " -"); campos.Add("grade", " A"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 40); campos.Add("engine", " Presto"); campos.Add("Browser", " Opera 9.5"); campos.Add("Platform", " Win 88+ / OSX.3+"); campos.Add("version", " -"); campos.Add("grade", " A"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 41); campos.Add("engine", " Presto"); campos.Add("Browser", " Opera for Wii"); campos.Add("Platform", " Wii"); campos.Add("version", " -"); campos.Add("grade", " A"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 42); campos.Add("engine", " Presto"); campos.Add("Browser", " Nokia N800"); campos.Add("Platform", " N800"); campos.Add("version", " -"); campos.Add("grade", " A"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 43); campos.Add("engine", " Presto"); campos.Add("Browser", " Nintendo DS browser"); campos.Add("Platform", " Nintendo DS"); campos.Add("version", "8.5"); campos.Add("grade", " C/A1"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 44); campos.Add("engine", " KHTML"); campos.Add("Browser", " Konqureror 3.1"); campos.Add("Platform", " KDE 3.1"); campos.Add("version", "3.1"); campos.Add("grade", " C"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 45); campos.Add("engine", " KHTML"); campos.Add("Browser", " Konqureror 3.3"); campos.Add("Platform", " KDE 3.3"); campos.Add("version", "3.3"); campos.Add("grade", " A"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 46); campos.Add("engine", " KHTML"); campos.Add("Browser", " Konqureror 3.5"); campos.Add("Platform", " KDE 3.5"); campos.Add("version", "3.5"); campos.Add("grade", " A"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 47); campos.Add("engine", " Tasman"); campos.Add("Browser", " Internet Explorer 4.5"); campos.Add("Platform", " Mac OS 8-9"); campos.Add("version", " -"); campos.Add("grade", " X"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 48); campos.Add("engine", " Tasman"); campos.Add("Browser", " Internet Explorer 5.1"); campos.Add("Platform", " Mac OS 7.6-9"); campos.Add("version", "1"); campos.Add("grade", " C"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 49); campos.Add("engine", " Tasman"); campos.Add("Browser", " Internet Explorer 5.2"); campos.Add("Platform", " Mac OS 8-X"); campos.Add("version", "1"); campos.Add("grade", " C"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 50); campos.Add("engine", " Misc"); campos.Add("Browser", " NetFront 3.1"); campos.Add("Platform", " Embedded devices"); campos.Add("version", " -"); campos.Add("grade", " C"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 51); campos.Add("engine", " Misc"); campos.Add("Browser", " NetFront 3.4"); campos.Add("Platform", " Embedded devices"); campos.Add("version", " -"); campos.Add("grade", " A"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 52); campos.Add("engine", " Misc"); campos.Add("Browser", " Dillo 0.8"); campos.Add("Platform", " Embedded devices"); campos.Add("version", " -"); campos.Add("grade", " X"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 53); campos.Add("engine", " Misc"); campos.Add("Browser", " Links"); campos.Add("Platform", " Text only"); campos.Add("version", " -"); campos.Add("grade", " X"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 54); campos.Add("engine", " Misc"); campos.Add("Browser", " Lynx"); campos.Add("Platform", " Text only"); campos.Add("version", " -"); campos.Add("grade", " X"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 55); campos.Add("engine", " Misc"); campos.Add("Browser", " IE Mobile"); campos.Add("Platform", " Windows Mobile 6"); campos.Add("version", " -"); campos.Add("grade", " C"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 56); campos.Add("engine", " Misc"); campos.Add("Browser", " PSP browser"); campos.Add("Platform", " PSP"); campos.Add("version", " -"); campos.Add("grade", " C"); list.Add(campos);
        campos = new Hashtable(); campos.Add("ID", 57); campos.Add("engine", " Other browsers"); campos.Add("Browser", " All others"); campos.Add("Platform", " -"); campos.Add("version", " -"); campos.Add("grade", " U"); list.Add(campos);

        foreach (Hashtable row in list)
        {
            builder.AppendLine("<tr><td>" + row["ID"].ToString() + "</td><td>" + row["engine"].ToString() + "</td><td>" + row["Browser"].ToString() + "</td><td>" + row["Platform"].ToString() + "</td><td>" + row["version"].ToString() + "</td><td>" + row["grade"].ToString() + "</td></tr>");
        }

        builder.AppendLine("</tbody><tfoot><tr><th>ID</th><th>Rendering engine</th><th>Browser</th><th>Platform(s)</th><th>Engine version</th><th>CSS grade</th></tr></tfoot></table>");

        contenido.InnerHtml = builder.ToString();

    }
}