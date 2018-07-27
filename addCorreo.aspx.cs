using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Entidades;

public partial class add : System.Web.UI.Page
{
    private CorreoBLL correoBLL = new CorreoBLL();
    protected void Page_Load(object sender, EventArgs e)
    {
        //https://stackoverflow.com/questions/25493951/extract-values-from-jobject


        //dynamic dynamicResultObject = JsonConvert.DeserializeObject(json);
        //string foobar = dynamicResultObject.Msg;
        //bool estado = dynamicResultObject["Status"];

        //JObject studentObj = JObject.Parse(json);
        //string name = (string)studentObj["Msg"];



        //var row = JsonConvert.DeserializeObject<object>(json);
        //object x = new object();
        //x = row;
        //Type tipo = x.GetType();
        //Int64 idIdentidad = Convert.ToInt64(tipo.GetProperty("IdIdentidad").GetValue(x, null).ToString());
        //bool status = Convert.ToBoolean(tipo.GetProperty("Status").GetValue(x, null).ToString());
        //string msg = tipo.GetProperty("Msg").GetValue(x, null).ToString();
        //string hola = string.Empty;
    }

    protected void btnEnviar_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(txtDestino.Text) && !string.IsNullOrEmpty(txtAsunto.Text))
        {
            string json = correoBLL.InsertCorreo(txtDestino.Text.Trim(), txtAsunto.Text.Trim(), txtContenido.Text.Trim(), 1);
            Respuesta m = JsonConvert.DeserializeObject<Respuesta>(json);
            if (m.Status)
            {
                Limpiar();
                Response.Redirect("Correos.aspx");
            }

        }
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Limpiar();
        Response.Redirect("Correos.aspx");
    }

    private void Limpiar()
    {
        txtDestino.Text = string.Empty;
        txtAsunto.Text = string.Empty;
        txtContenido.Text = string.Empty;
    }
}