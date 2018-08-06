using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Newtonsoft.Json;
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
    }

    protected void btnEnviar_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(txtDestino.Text) && !string.IsNullOrEmpty(txtAsunto.Text) && !string.IsNullOrEmpty(__composetextarea.Text))
        {
            string json = correoBLL.InsertCorreo(txtDestino.Text.Trim(), txtAsunto.Text.Trim(), __composetextarea.Text.Trim(), 1);
            var jCorreo = JsonConvert.DeserializeObject<dynamic>(json);
            bool status = Convert.ToBoolean(jCorreo.Status);
            if (status)
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
        __composetextarea.Text = string.Empty;
    }
}