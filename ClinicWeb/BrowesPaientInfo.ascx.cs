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

public partial class BrowesPaientInfo : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text == "")
        {
            Label1.Text = "ادخل اسم الاول للمريض";
            return;
        }
        else
        {
            try
            {
                if (RbtnID.Checked == true)
                {
                    GridView1.DataSource = InstanceObject._SP_Patient.SP_Browes_Patient_By_PatientID_Felid(Convert.ToInt32(TextBox1.Text));
                    GridView1.DataBind();
                }
                else if (RbtnFirstName.Checked == true)
                {
                    GridView1.DataSource = InstanceObject._SP_Patient.SP_Browes_Patient_List_By_FirstName(TextBox1.Text);
                    GridView1.DataBind();
                }
                else
                {
                    GridView1.DataSource = InstanceObject._SP_Patient.SP_Browes_Patient_List_By_LastName(TextBox1.Text);
                    GridView1.DataBind();
                }
            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message;
            }
            RbtnID.Checked = false;
            RbtnLastName.Checked = false;
            RbtnFirstName.Checked = false;

        }
        

    }
    protected void RbtnID_CheckedChanged(object sender, EventArgs e)
    {
        
            Label1.Text = "رقم المريض";
            RbtnFirstName.Checked = false;
            RbtnLastName.Checked =false;
           
    }
    protected void RbtnFirstName_CheckedChanged(object sender, EventArgs e)
    {
          Label1.Text = "الاسم الاول ";
            RbtnID.Checked = false ;
            RbtnLastName.Checked = false;
           
            
       
    }
    protected void RbtnLastName_CheckedChanged(object sender, EventArgs e)
    {
           Label1.Text = "الاسم الاخير ";
            RbtnID.Checked = false;
            RbtnFirstName.Checked = false;

        
    }
}
