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

public partial class ConectPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        InstanceObject._Felid_ClincData = InstanceObject._SP_ClincData.SP_Browse_Dr_Felid();
        txt_DrName.Text = InstanceObject._Felid_ClincData.DrName;
        txt_Despcription.Text = InstanceObject._Felid_ClincData.Speciaty;
        txt_Tel.Text = InstanceObject._Felid_ClincData.Phone;
        txt_Mobil.Text = InstanceObject._Felid_ClincData.Mobile;
        txt_Fax.Text = InstanceObject._Felid_ClincData.Fax;
        txt_Email.Text = InstanceObject._Felid_ClincData.Email;
        txt_WebSite.Text = InstanceObject._Felid_ClincData.WebSiteAddress;
        txt_City.Text = InstanceObject._Felid_ClincData.City;
        txt_Adress.Text = InstanceObject._Felid_ClincData.Address;


    }
}
