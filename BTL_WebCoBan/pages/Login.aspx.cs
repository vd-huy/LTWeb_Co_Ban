using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_WebCoBan.pages
{
    public partial class Login : System.Web.UI.Page
    {
        List<objects.user> users;
        protected void Page_Load(object sender, EventArgs e)
        {
            users = (List<objects.user>)Application["users"];
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
             string userName = Request.Form["userName"];
            string passWord = Request.Form["passWord"];

            if (IsPostBack)
            {
                foreach (objects.user user in users)
                {
                    if (user.userName == userName && user.password == passWord)
                    {
                        Session["user"] = user;
                        Session["userName"] = user.userName;
                        Response.Redirect("HomePage.aspx");
                    }
                    else
                    {
                        errorLogin.InnerHtml = "ERROR: Wrong UserName or Password!";
                    }
                }
            }

        }

    }
}