using System;
using System.Data;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=KRISHNA-WINDOWS;Initial Catalog=dbDemoProject;Persist Security Info=True;User ID=sa;Password=dearsql");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindGridview();
        }
    }
    protected void BindGridview()
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("select RichTextData from RichTextBoxData", con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        gvdetails.DataSource = ds;
        gvdetails.DataBind();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("insert into RichTextBoxData(RichTextData) values(@Richtextbox)", con);
        cmd.Parameters.AddWithValue("@Richtextbox", FreeTextBox1.Text);
        cmd.ExecuteNonQuery();
        con.Close();
        FreeTextBox1.Text = "";
        BindGridview();
    }
}