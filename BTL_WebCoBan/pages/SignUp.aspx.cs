using BTL_WebCoBan.objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_WebCoBan
{
    public partial class SignUp : System.Web.UI.Page
    {
        List<objects.user> users;
        protected void Page_Load(object sender, EventArgs e)
        {
            users = (List<objects.user>)Application["users"];
        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            string firstName = Request.Form["firstName"];
            string lastName = Request.Form["lastName"];
            string userName = Request.Form["userName"];
            string passWord = Request.Form["passWord"];
            string email = Request.Form["email"];
            bool check = true;

            if (IsPostBack)
            {

                foreach (objects.user user in users)
                {
                    
                    if (user.userName == userName)
                    {
                        errorLogin.InnerHtml = "ERROR: User Name have already";
                        check = false;
                    }
                    if (user.email == email)
                    {
                        errorLogin.InnerHtml = "ERROR: Email have already";
                        check = false;
                    }
                    
                }
                if (check && userName != "" && firstName != "" && lastName != ""&& email!="" && passWord != "")
                {
                    errorLogin.InnerHtml = "Đăng ký thành công";
                    users.Add(new objects.user(firstName,lastName,userName,email,passWord));

                    /*Thread.Sleep(5000);
                    Response.Redirect("Login.aspx");*/


                }
            }


        }
    }
}