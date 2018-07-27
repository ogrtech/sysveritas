using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class correos_index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dt = new DataTable();

        dt.Columns.Add("ID", typeof(string));
        dt.Columns.Add("Rendering engine", typeof(string));
        dt.Columns.Add("Browser", typeof(string));
        dt.Columns.Add("Platform(s)", typeof(string));
        dt.Columns.Add("Engine version", typeof(string));
        dt.Columns.Add("CSS grade", typeof(string));

        dt.Rows.Add(1, "Trident", "Internet Explorer 4.0", "Win 95+", "4", "X");
        dt.Rows.Add(2, "Trident", "Internet Explorer 5.0", "Win 95+", "5", "C");
        dt.Rows.Add(3, "Trident", "Internet Explorer 5.5", "Win 95+", "5.5", "A");
        dt.Rows.Add(4, "Trident", "Internet Explorer 6", "Win 98+", "6", "A");
        dt.Rows.Add(5, "Trident", "Internet Explorer 7", "Win XP SP2+", "7", "A");
        dt.Rows.Add(6, "Trident", "AOL browser (AOL desktop)", "Win XP", "6", "A");
        dt.Rows.Add(7, "Gecko", "Firefox 1.0", "Win 98+ / OSX.2+", "1.7", "A");
        dt.Rows.Add(8, "Gecko", "Firefox 1.5", "Win 98+ / OSX.2+", "1.8", "A");
        dt.Rows.Add(9, "Gecko", "Firefox 2.0", "Win 98+ / OSX.2+", "1.8", "A");
        dt.Rows.Add(10, "Gecko", "Firefox 3.0", "Win 2k+ / OSX.3+", "1.9", "A");
        dt.Rows.Add(11, "Gecko", "Camino 1.0", "OSX.2+", "1.8", "A");
        dt.Rows.Add(12, "Gecko", "Camino 1.5", "OSX.3+", "1.8", "A");
        dt.Rows.Add(13, "Gecko", "Netscape 7.2", "Win 95+ / Mac OS 8.6-9.2", "1.7", "A");
        dt.Rows.Add(14, "Gecko", "Netscape Browser 8", "Win 98SE+", "1.7", "A");
        dt.Rows.Add(15, "Gecko", "Netscape Navigator 9", "Win 98+ / OSX.2+", "1.8", "A");
        dt.Rows.Add(16, "Gecko", "Mozilla 1.0", "Win 95+ / OSX.1+", "1", "A");
        dt.Rows.Add(17, "Gecko", "Mozilla 1.1", "Win 95+ / OSX.1+", "1.1", "A");
        dt.Rows.Add(18, "Gecko", "Mozilla 1.2", "Win 95+ / OSX.1+", "1.2", "A");
        dt.Rows.Add(19, "Gecko", "Mozilla 1.3", "Win 95+ / OSX.1+", "1.3", "A");
        dt.Rows.Add(20, "Gecko", "Mozilla 1.4", "Win 95+ / OSX.1+", "1.4", "A");
        dt.Rows.Add(21, "Gecko", "Mozilla 1.5", "Win 95+ / OSX.1+", "1.5", "A");
        dt.Rows.Add(22, "Gecko", "Mozilla 1.6", "Win 95+ / OSX.1+", "1.6", "A");
        dt.Rows.Add(23, "Gecko", "Mozilla 1.7", "Win 98+ / OSX.1+", "1.7", "A");
        dt.Rows.Add(24, "Gecko", "Mozilla 1.8", "Win 98+ / OSX.1+", "1.8", "A");
        dt.Rows.Add(25, "Gecko", "Seamonkey 1.1", "Win 98+ / OSX.2+", "1.8", "A");
        dt.Rows.Add(26, "Gecko", "Epiphany 2.20", "Gnome", "1.8", "A");
        dt.Rows.Add(27, "Webkit", "Safari 1.2", "OSX.3", "125.5", "A");
        dt.Rows.Add(28, "Webkit", "Safari 1.3", "OSX.3", "312.8", "A");
        dt.Rows.Add(29, "Webkit", "Safari 2.0", "OSX.4+", "419.3", "A");
        dt.Rows.Add(30, "Webkit", "Safari 3.0", "OSX.4+", "522.1", "A");
        dt.Rows.Add(31, "Webkit", "OmniWeb 5.5", "OSX.4+", "420", "A");
        dt.Rows.Add(32, "Webkit", "iPod Touch / iPhone", "iPod", "420.1", "A");
        dt.Rows.Add(33, "Webkit", "S60", "S60", "413", "A");
        dt.Rows.Add(34, "Presto", "Opera 7.0", "Win 95+ / OSX.1+", "-", "A");
        dt.Rows.Add(35, "Presto", "Opera 7.5", "Win 95+ / OSX.2+", "-", "A");
        dt.Rows.Add(36, "Presto", "Opera 8.0", "Win 95+ / OSX.2+", "-", "A");
        dt.Rows.Add(37, "Presto", "Opera 8.5", "Win 95+ / OSX.2+", "-", "A");
        dt.Rows.Add(38, "Presto", "Opera 9.0", "Win 95+ / OSX.3+", "-", "A");
        dt.Rows.Add(39, "Presto", "Opera 9.2", "Win 88+ / OSX.3+", "-", "A");
        dt.Rows.Add(40, "Presto", "Opera 9.5", "Win 88+ / OSX.3+", "-", "A");
        dt.Rows.Add(41, "Presto", "Opera for Wii", "Wii", "-", "A");
        dt.Rows.Add(42, "Presto", "Nokia N800", "N800", "-", "A");
        dt.Rows.Add(43, "Presto", "Nintendo DS browser", "Nintendo DS", "8.5", "C/A1");
        dt.Rows.Add(44, "KHTML", "Konqureror 3.1", "KDE 3.1", "3.1", "C");
        dt.Rows.Add(45, "KHTML", "Konqureror 3.3", "KDE 3.3", "3.3", "A");
        dt.Rows.Add(46, "KHTML", "Konqureror 3.5", "KDE 3.5", "3.5", "A");
        dt.Rows.Add(47, "Tasman", "Internet Explorer 4.5", "Mac OS 8-9", "-", "X");
        dt.Rows.Add(48, "Tasman", "Internet Explorer 5.1", "Mac OS 7.6-9", "1", "C");
        dt.Rows.Add(49, "Tasman", "Internet Explorer 5.2", "Mac OS 8-X", "1", "C");
        dt.Rows.Add(50, "Misc", "NetFront 3.1", "Embedded devices", "-", "C");
        dt.Rows.Add(51, "Misc", "NetFront 3.4", "Embedded devices", "-", "A");
        dt.Rows.Add(52, "Misc", "Dillo 0.8", "Embedded devices", "-", "X");
        dt.Rows.Add(53, "Misc", "Links", "Text only", "-", "X");
        dt.Rows.Add(54, "Misc", "Lynx", "Text only", "-", "X");
        dt.Rows.Add(55, "Misc", "IE Mobile", "Windows Mobile 6", "-", "C");
        dt.Rows.Add(56, "Misc", "PSP browser", "PSP", "-", "C");
        dt.Rows.Add(57, "Other browsers", "All others", "-", "-", "U");

        //GridView1.DataSource = dt;
        //GridView1.DataBind();


    }

    private void BindGrid()
    {
        DataTable dt = new DataTable();

        dt.Columns.Add("ID", typeof(string));
        dt.Columns.Add("Rendering engine", typeof(string));
        dt.Columns.Add("Browser", typeof(string));
        dt.Columns.Add("Platform(s)", typeof(string));
        dt.Columns.Add("Engine version", typeof(string));
        dt.Columns.Add("CSS grade", typeof(string));

        dt.Rows.Add(1, "Trident", "Internet Explorer 4.0", "Win 95+", "4", "X");
        dt.Rows.Add(2, "Trident", "Internet Explorer 5.0", "Win 95+", "5", "C");
        dt.Rows.Add(3, "Trident", "Internet Explorer 5.5", "Win 95+", "5.5", "A");
        dt.Rows.Add(4, "Trident", "Internet Explorer 6", "Win 98+", "6", "A");
        dt.Rows.Add(5, "Trident", "Internet Explorer 7", "Win XP SP2+", "7", "A");
        dt.Rows.Add(6, "Trident", "AOL browser (AOL desktop)", "Win XP", "6", "A");
        dt.Rows.Add(7, "Gecko", "Firefox 1.0", "Win 98+ / OSX.2+", "1.7", "A");
        dt.Rows.Add(8, "Gecko", "Firefox 1.5", "Win 98+ / OSX.2+", "1.8", "A");
        dt.Rows.Add(9, "Gecko", "Firefox 2.0", "Win 98+ / OSX.2+", "1.8", "A");
        dt.Rows.Add(10, "Gecko", "Firefox 3.0", "Win 2k+ / OSX.3+", "1.9", "A");
        dt.Rows.Add(11, "Gecko", "Camino 1.0", "OSX.2+", "1.8", "A");
        dt.Rows.Add(12, "Gecko", "Camino 1.5", "OSX.3+", "1.8", "A");
        dt.Rows.Add(13, "Gecko", "Netscape 7.2", "Win 95+ / Mac OS 8.6-9.2", "1.7", "A");
        dt.Rows.Add(14, "Gecko", "Netscape Browser 8", "Win 98SE+", "1.7", "A");
        dt.Rows.Add(15, "Gecko", "Netscape Navigator 9", "Win 98+ / OSX.2+", "1.8", "A");
        dt.Rows.Add(16, "Gecko", "Mozilla 1.0", "Win 95+ / OSX.1+", "1", "A");
        dt.Rows.Add(17, "Gecko", "Mozilla 1.1", "Win 95+ / OSX.1+", "1.1", "A");
        dt.Rows.Add(18, "Gecko", "Mozilla 1.2", "Win 95+ / OSX.1+", "1.2", "A");
        dt.Rows.Add(19, "Gecko", "Mozilla 1.3", "Win 95+ / OSX.1+", "1.3", "A");
        dt.Rows.Add(20, "Gecko", "Mozilla 1.4", "Win 95+ / OSX.1+", "1.4", "A");
        dt.Rows.Add(21, "Gecko", "Mozilla 1.5", "Win 95+ / OSX.1+", "1.5", "A");
        dt.Rows.Add(22, "Gecko", "Mozilla 1.6", "Win 95+ / OSX.1+", "1.6", "A");
        dt.Rows.Add(23, "Gecko", "Mozilla 1.7", "Win 98+ / OSX.1+", "1.7", "A");
        dt.Rows.Add(24, "Gecko", "Mozilla 1.8", "Win 98+ / OSX.1+", "1.8", "A");
        dt.Rows.Add(25, "Gecko", "Seamonkey 1.1", "Win 98+ / OSX.2+", "1.8", "A");
        dt.Rows.Add(26, "Gecko", "Epiphany 2.20", "Gnome", "1.8", "A");
        dt.Rows.Add(27, "Webkit", "Safari 1.2", "OSX.3", "125.5", "A");
        dt.Rows.Add(28, "Webkit", "Safari 1.3", "OSX.3", "312.8", "A");
        dt.Rows.Add(29, "Webkit", "Safari 2.0", "OSX.4+", "419.3", "A");
        dt.Rows.Add(30, "Webkit", "Safari 3.0", "OSX.4+", "522.1", "A");
        dt.Rows.Add(31, "Webkit", "OmniWeb 5.5", "OSX.4+", "420", "A");
        dt.Rows.Add(32, "Webkit", "iPod Touch / iPhone", "iPod", "420.1", "A");
        dt.Rows.Add(33, "Webkit", "S60", "S60", "413", "A");
        dt.Rows.Add(34, "Presto", "Opera 7.0", "Win 95+ / OSX.1+", "-", "A");
        dt.Rows.Add(35, "Presto", "Opera 7.5", "Win 95+ / OSX.2+", "-", "A");
        dt.Rows.Add(36, "Presto", "Opera 8.0", "Win 95+ / OSX.2+", "-", "A");
        dt.Rows.Add(37, "Presto", "Opera 8.5", "Win 95+ / OSX.2+", "-", "A");
        dt.Rows.Add(38, "Presto", "Opera 9.0", "Win 95+ / OSX.3+", "-", "A");
        dt.Rows.Add(39, "Presto", "Opera 9.2", "Win 88+ / OSX.3+", "-", "A");
        dt.Rows.Add(40, "Presto", "Opera 9.5", "Win 88+ / OSX.3+", "-", "A");
        dt.Rows.Add(41, "Presto", "Opera for Wii", "Wii", "-", "A");
        dt.Rows.Add(42, "Presto", "Nokia N800", "N800", "-", "A");
        dt.Rows.Add(43, "Presto", "Nintendo DS browser", "Nintendo DS", "8.5", "C/A1");
        dt.Rows.Add(44, "KHTML", "Konqureror 3.1", "KDE 3.1", "3.1", "C");
        dt.Rows.Add(45, "KHTML", "Konqureror 3.3", "KDE 3.3", "3.3", "A");
        dt.Rows.Add(46, "KHTML", "Konqureror 3.5", "KDE 3.5", "3.5", "A");
        dt.Rows.Add(47, "Tasman", "Internet Explorer 4.5", "Mac OS 8-9", "-", "X");
        dt.Rows.Add(48, "Tasman", "Internet Explorer 5.1", "Mac OS 7.6-9", "1", "C");
        dt.Rows.Add(49, "Tasman", "Internet Explorer 5.2", "Mac OS 8-X", "1", "C");
        dt.Rows.Add(50, "Misc", "NetFront 3.1", "Embedded devices", "-", "C");
        dt.Rows.Add(51, "Misc", "NetFront 3.4", "Embedded devices", "-", "A");
        dt.Rows.Add(52, "Misc", "Dillo 0.8", "Embedded devices", "-", "X");
        dt.Rows.Add(53, "Misc", "Links", "Text only", "-", "X");
        dt.Rows.Add(54, "Misc", "Lynx", "Text only", "-", "X");
        dt.Rows.Add(55, "Misc", "IE Mobile", "Windows Mobile 6", "-", "C");
        dt.Rows.Add(56, "Misc", "PSP browser", "PSP", "-", "C");
        dt.Rows.Add(57, "Other browsers", "All others", "-", "-", "U");

        //GridView1.DataSource = dt;
        //GridView1.DataBind();
    }

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        //GridView1.PageIndex = e.NewPageIndex;
        BindGrid();
    }
}
