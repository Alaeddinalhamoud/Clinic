using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class PatientVisits : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
       

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
      

            if (TextBox1.Text == "")
            {
                lblPaientID.Text = "ادخل رقم المريض";
            }
            else
            {

                GridView1.DataSource = InstanceObject._SP_Visit.SP_Browes_Visit_Detiles_PatientID(Convert.ToInt32(TextBox1.Text));
                GridView1.DataBind();
            }
        
    }
}
