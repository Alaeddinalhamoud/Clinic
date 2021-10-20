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

public partial class DeleteAllAppointment : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label2.Visible = false;

        if (TextBox1.Text == "")
        {
            Label2.Visible = true;
            Label2.Text = "ادخل التاريخ";
            return;
        }
        else
        {
            InstanceObject._SP_Appointment.SP_Delete_Appoitment_By_Date (Convert.ToDateTime(TextBox1.Text));
            Label2.Visible = true;
            Label2.Text = "لقد تمت عملية الالغاء بنجاح";
        }
    }
}
