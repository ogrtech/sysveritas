using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class principal : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //string session = Session["userlogin"].ToString();
            if (Session["userlogin"]==null)
            {

                Response.Redirect("Login.aspx");
            }
        }
    }

}