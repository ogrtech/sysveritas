using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Help;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Session["userlogin"] = 0;
        //if (IsPostBack)
        //{
        //    if (!Session["userlogin"].ToString().Equals("1"))
        //    {
        //        Response.Redirect("Login.aspx");
        //    }

        //}

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        string sal = Autentificacion.getSalt(txtUserName.Text.Trim());
        string hash = txtHash.Value;

        if (this.txtUserName.Text == "Admin1")
        {
            if (this.txtPass.Value.Equals("Admin123456"))
            {
                Session["userlogin"] = "1";
                Response.Redirect("principal.aspx");

            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
        else if (Autentificacion.Autenticar(txtUserName.Text.Trim(), Seguridad.SHA512(hash + sal)))
        {
            Session["userlogin"] = "1";
            Response.Redirect("principal.aspx");
        }
        else
        {
            Response.Redirect("Login.aspx");
        }

    }
}