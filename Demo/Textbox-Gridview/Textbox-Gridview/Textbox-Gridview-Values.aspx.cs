using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Textbox_Gridview
{
    public partial class Textbox_Gridview_Values : System.Web.UI.Page
    {
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {  
            if(!Page.IsPostBack)
            {
                if (ViewState["Records"] == null)
                {
                    dt.Columns.Add("Name");
                    dt.Columns.Add("Email");
                    dt.Columns.Add("ContactDetails");
                    ViewState["Records"] = dt;
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            dt = (DataTable)ViewState["Records"];
            dt.Rows.Add(TxtName.Text, TxtEmail.Text, TxtContactDetails.Text);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}