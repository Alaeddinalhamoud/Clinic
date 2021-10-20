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

public partial class PaientPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((Request.QueryString["UC"] != null) && !Request.QueryString["UC"].Equals(""))
        {
            UserControl usercontrol1 = (UserControl)LoadControl(Request.QueryString["UC"] + (".ascx"));
            Add_User_Control.Controls.Add(usercontrol1);


        }
        if ((Request.QueryString["UC1"] != null) && !Request.QueryString["UC1"].Equals(""))
        {
            UserControl usercontrol2 = (UserControl)LoadControl(Request.QueryString["UC1"] + (".ascx"));
            Add_User_Control.Controls.Add(usercontrol2);


        }
        if ((Request.QueryString["UC2"] != null) && !Request.QueryString["UC2"].Equals(""))
        {
            UserControl usercontrol3 = (UserControl)LoadControl(Request.QueryString["UC2"] + (".ascx"));
            Add_User_Control.Controls.Add(usercontrol3);


        }
    }
}
