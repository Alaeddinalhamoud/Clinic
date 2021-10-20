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

public partial class UserControlC : System.Web.UI.UserControl
{
    public static string ImgePath = null;
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["adminpass"] != null)
        {
            if (!(Session["adminpass"].ToString() == "auth"))
                Response.Redirect("AdminPage.aspx");
        }
        else
        {
            Response.Redirect("AdminPage.aspx");
        }

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
    protected void btn_Update_Click(object sender, EventArgs e)

    {
        InstanceObject._Felid_ClincData = InstanceObject._SP_ClincData.SP_Browse_Dr_Felid();
        InstanceObject._Felid_ClincData.DrName = txt_DrName.Text;
        InstanceObject._Felid_ClincData.Speciaty = txt_Despcription.Text;
        InstanceObject._Felid_ClincData.Phone = txt_Tel.Text;
        InstanceObject._Felid_ClincData.Mobile = txt_Mobil.Text;
        InstanceObject._Felid_ClincData.Fax = txt_Fax.Text;
        InstanceObject._Felid_ClincData.Email = txt_Email.Text;
        InstanceObject._Felid_ClincData.WebSiteAddress = txt_WebSite.Text;
        InstanceObject._Felid_ClincData.City = txt_City.Text;
        InstanceObject._Felid_ClincData.Address = txt_Adress.Text;
        ImgePath = InstanceObject._Felid_ClincData.Image;
        InstanceObject._Felid_ClincData.Image = ImgePath;
        InstanceObject._SP_ClincData.SP_UpData_Dr_Info(InstanceObject._Felid_ClincData);



    }
}
