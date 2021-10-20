using System;
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

public partial class _Default : System.Web.UI.Page
{

    public string userName;
    public string Password;
    public static string PaName ;
    protected void Page_Load(object sender, EventArgs e)
    {

        Calendar1.SelectedDate = DateTime.Now.Date;

        if (Session["adminpass"]== "auth")
        {
            Login1.Visible = false;
            Label2.Visible = true;
            CheckBox1.Visible = false;
            Label2.Text = "اهلا بك يا " + InstanceObject.UserFullName;
        }
        else if (Session["PatientPass"]== "Patientauth") 
        {
            Login1.Visible = false;
            Label2.Visible = true;
            CheckBox1.Visible = false;
            Label2.Text = "اهلا بك يا" +" "+ InstanceObject.PatientName+"..."+"ادارة الموقع تتمنى لك الشفاء العاجل";
        }
        else
        {
            Login1.Visible = true ;
            Label2.Visible = false;
            
        }

    }
    protected void Login1_Authenticate1(object sender, AuthenticateEventArgs e)
    {




        if (CheckBox1.Checked == false)
        {
            userName = Login1.UserName;
            Password = Login1.Password;
            InstanceObject._Felid_User = InstanceObject._SP_User.SP_Browse_UserInfo_For_Login(userName, Password);

            if (InstanceObject._Felid_User.UserName == userName && InstanceObject._Felid_User.PassWord == Password)
            {
                

                Session["adminpass"] = "auth";
                InstanceObject.UserFullName = InstanceObject._Felid_User.FullName;

                Response.Redirect("AdminPage.aspx");
            }
            else
            {
                
                Response.Redirect("Defualt.aspx");
            }
        }

        else
        {

            int PatientIDLog = Convert.ToInt32(Login1.Password);
            string PatientName = Login1.Password;
            InstanceObject._Felid_Patient = InstanceObject._SP_Patient.SP_Browes_Patient_FullName_By_ID_Felid(PatientIDLog);
            if (InstanceObject._Felid_Patient.PatientID == PatientIDLog)
            {
                Session["PatientPass"] = "Patientauth";
                InstanceObject.PatientName = InstanceObject._Felid_Patient.FirstName + InstanceObject._Felid_Patient.LastName;
                //PaName = InstanceObject._Felid_Patient.FirstName + InstanceObject.PatientName;
                Response.Redirect("PaientPage.aspx");
                
            }


        }



    }

    protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
    {


    }

}