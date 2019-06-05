using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

public partial class _Default2 : System.Web.UI.Page
{
    SampleDataContext sampleDataContext = new SampleDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindGridview();
        }
    }
    protected void BindGridview()
    {
        gvdetails.DataSource = sampleDataContext.RichTextBoxDatas.ToList();
        gvdetails.DataBind();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        sampleDataContext.RichTextBoxDatas.Add(new RichTextBoxData() {
            RichTextData = FreeTextBox1.Text.Trim()
        });
        sampleDataContext.SaveChanges();
        BindGridview();
    }
}