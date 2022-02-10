using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginEntityFramework
{
    public partial class CustomerLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            CustomerContext custContext = new CustomerContext();
            var query = from customer in custContext.customers where customer.username == txtUName.Text
                        && customer.passowrd == txtPwd.Text
                        select customer;

            /*var username = "";
            var password = "";
           foreach(var customer in query)
            {
                username = customer.username;
                Response.Write(username);
                password = customer.passowrd;
                Response.Write(password);
            }*/


            /*if (FormsAuthentication.Authenticate(username, password))
            {
                FormsAuthentication.RedirectFromLoginPage(username, true);
            }
            else
            {
                Response.Write("Invalid Username or Password");
            }*/

           if(query.Count() > 0)
            {
                Response.Redirect("LoginSuccess.aspx");
            }
            else
            {
                Response.Write("Invalid Username or Password");
            }
        }
    }
}