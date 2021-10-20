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

public partial class AppointmentControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text == "")
        {
            Label1.Text = "ادخل الوقت الذي تريد اضافته";
        }
        else
        {
            InstanceObject._Felid_Time.Time = TextBox1.Text;
            try
            {
                InstanceObject._SP_Time.Insert_TimeTB(InstanceObject._Felid_Time);
                GridView1.DataSource = InstanceObject._SP_Time.Browes_TimeTB_All_List();
                GridView1.DataBind();
            }
            catch (Exception ex) { Label1.Text = ex.Message; }
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text == "")
        {
            Label1.Text = "ادخل رقم الوقت الذي تريد حذفه";
        }
        else
        {

            InstanceObject._SP_Time.Delete_TimeTB(Convert.ToInt32(TextBox1.Text));
        }
    }
}
