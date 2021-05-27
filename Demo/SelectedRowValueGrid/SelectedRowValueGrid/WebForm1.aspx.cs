using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SelectedRowValueGrid
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        int ExistingEmp_Id = 0;
        SqlConnection connection = new SqlConnection(@"Data Source=adminvm\SQLEXPRESS;Initial Catalog=Database1;User ID=sa;Password=pass@123");
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                show();
                btnSave.Text = "Save";
            }
        }

        public void show()
        {

            int maxEmp_ID = 0;
            da = new SqlDataAdapter("select * from Emp_Details ", connection);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    int Emp_Id = dr.Field<int>("Emp_ID");
                    maxEmp_ID = Math.Max(maxEmp_ID, Emp_Id) + 1;


                    ExistingEmp_Id = Emp_Id;
                }
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            txtEmp_ID.Text = maxEmp_ID.ToString();
        }
        protected void Save_Click(object sender, EventArgs e)
        {
            string Query = string.Empty;
            Query = "insert into Emp_Details(Emp_Name,Department,Location)values('" + txtEmp_Name.Text + "','" + txtDepartment.Text + "','" + txtLocation.Text + "');";
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand(Query, connection);
            SqlDataReader reader;
            reader = sqlCommand.ExecuteReader();
            connection.Close();
            ClearControls();
            show();
            Response.Write("Record Inserted");
        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            int rowind = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
            {
                txtEmp_ID.Text = GridView1.Rows[rowind].Cells[1].Text;
                txtEmp_Name.Text = GridView1.Rows[rowind].Cells[2].Text;
                txtDepartment.Text = GridView1.Rows[rowind].Cells[3].Text;
                txtLocation.Text = GridView1.Rows[rowind].Cells[4].Text;
               /* btnSave.Text = "Update";*/

            }
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
        private void ClearControls()
        {
            txtEmp_ID.Text = string.Empty;
            txtEmp_Name.Text = string.Empty;
            txtDepartment.Text = string.Empty;
            txtLocation.Text = string.Empty;

        }

        protected void LinkButton1_Click1(object sender, EventArgs e)

        {



        }
    }
}