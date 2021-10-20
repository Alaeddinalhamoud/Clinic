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
using System.Windows.Forms;
using System.Xml.Linq;


public partial class BrowesAllAppointment : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
      
       
        if (Session["adminpass"] != null)
        {
            if (!(Session["adminpass"].ToString() == "auth"))
                Response.Redirect("Appo.aspx");
        }
        else
        {
            Response.Redirect("Appo.aspx");
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text == "")
        {
            Label1.Text = "ادخل تاريخ المواعيد";
        }
        else
        {
            GridView1.DataSource = InstanceObject._SP_Appointment.SP_Brows_Datials_Appointement(Convert.ToDateTime(TextBox1.Text));
            GridView1.DataBind();
        }
    }
}
