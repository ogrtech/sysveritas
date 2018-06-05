using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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

        if (this.txtUserName.Text == "Admin1"
            )
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
        else {
            Response.Redirect("Login.aspx");
        }
            
    }
}