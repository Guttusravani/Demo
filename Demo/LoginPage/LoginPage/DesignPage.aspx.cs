using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginPage
{
    public partial class DesignPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text=="sravani" && txtPassword.Text =="*****")
            {
                Response.Redirect("Welcomeform.aspx");
            }
            else
            {
               Label1.Visible = true;
            }
        }
    }
}