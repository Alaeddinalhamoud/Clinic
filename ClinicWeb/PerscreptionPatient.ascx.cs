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

public partial class PerscreptionPatient : System.Web.UI.UserControl
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
            InstanceObject._Felid_Prescription = InstanceObject._SP_Prescription.Browes_Perscreption_All_List_By_PatientID(Convert.ToInt32(TextBox1.Text));
            
           

            
            Label1.Visible = true;
            InstanceObject._Felid_Patient = InstanceObject._SP_Patient.SP_Browes_Patient_FullName_By_ID_Felid(Convert.ToInt32(TextBox1.Text));
            Label1.Text = "اسم المريض: "+""+InstanceObject._Felid_Patient.FirstName;
            GridView1.DataSource = InstanceObject._SP_Prescription_Medications.SP_Browes_Prescription_Medication_By_PrescriptionID_List(InstanceObject._Felid_Prescription.PrescriptionID);
            GridView1.DataBind();
        }
    }
}
