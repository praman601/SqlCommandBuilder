using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace sqlcmdbuilder
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=PRADEEP\\SQLEXPRESS;Initial Catalog=employeeAttendance;Integrated Security=true");
            String sqlQuery = "select * from tblAttendance where Id =" + TextBox1.Text;

             
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Employee");

            ViewState["Sql_Query"] = sqlQuery;
            ViewState["Dataset"] = ds;

            if (ds.Tables["Employee"].Rows.Count > 0)
            {
                DataRow dr = ds.Tables["Employee"].Rows[0];
                TextBox2.Text = dr["Name"].ToString();
                Label6.Text = dr["TotalDays"].ToString();
                DropDownList1.SelectedValue = dr["Status"].ToString();

            }
            else
            {
                Label5.ForeColor = System.Drawing.Color.Red;
                Label5.Text = "No Employee record with id =" + TextBox1.Text;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=PRADEEP\\SQLEXPRESS;Initial Catalog=employeeAttendance;Integrated Security=true");
            SqlDataAdapter da = new SqlDataAdapter((string)ViewState["Sql_Query"], con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);

            

            DataSet ds = (DataSet)ViewState["Dataset"];

            if(ds.Tables["Employee"].Rows.Count>0)
            {

                DataRow dr = ds.Tables["Employee"].Rows[0];
                dr["Name"] = TextBox2.Text;
                dr["Status"] = DropDownList1.SelectedValue;


                dr["TotalDays"] = TextBox3.Text;
            }

           int rowsUpdated= da.Update(ds,"Employee");
            if(rowsUpdated>0)
            {
                Label5.ForeColor = System.Drawing.Color.Green;
                Label5.Text = rowsUpdated.ToString() + "row(s) updated";
            }
            else
            {
                Label5.ForeColor = System.Drawing.Color.Red;
                Label5.Text = rowsUpdated.ToString() + "row(s) updated";
            }
        }
    }
  }
