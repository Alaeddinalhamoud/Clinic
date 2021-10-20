using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
         lblYearNow.Text = System.DateTime.Now.Year.ToString(); 
    }
    protected void Login1_Authenticate1(object sender, AuthenticateEventArgs e)
    {
       
    }
    protected void TabBar1_TabClick(object sender, System.ComponentModel.CancelEventArgs ce)
    {
       
      
    }
}
