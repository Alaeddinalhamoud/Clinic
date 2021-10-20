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
using Microsoft.ApplicationBlocks.Data;

public partial class AddAndDeleteAppointment : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DropDownListVisit.DataTextField = "VisitType";
        DropDownListVisit.DataValueField = "VisitTypeID";
        DropDownListVisit.DataSource = InstanceObject._SP_VisitType.VisitTypeTB_Browes_All();
        DropDownListVisit.DataBind();

        UpdateTime();

        Calendar1.SelectedDate = DateTime.Now;

    }

    private void UpdateTime()
    {

        DropDownListVisitTime.DataTextField = "Time";
        DropDownListVisitTime.DataValueField = "TimeID";
        DropDownListVisitTime.DataSource = InstanceObject._SP_Time.Browes_TimeTB_All_List();
        DropDownListVisitTime.DataBind();
    }
    protected void btn_Save_Click(object sender, EventArgs e)
    {
        if (txtPatientName.Text == "")
        {

            Label2.Text = "عملية حجز الموعد هذه غير مشروعة وذلك بسبب عدم ادخال الاسم أو انك قد حجزت موعد من قبل  ";
            Label1.Visible = false ;
            lblShowdate.Visible = false;
            return;
        }
        else
        {
            InstanceObject._Felid_Appointment.PatientName = txtPatientName.Text;
            InstanceObject._Felid_Appointment.Date = Calendar1.SelectedDate;
            InstanceObject._Felid_Appointment.Time = DropDownListVisitTime.Text;
            InstanceObject._Felid_Appointment.VisitTypeID = Convert.ToInt32(DropDownListVisit.SelectedValue);

            InstanceObject._Felid_Appointment.Note = "تم حجز الموعد عن طريق الموقع";
            //InstanceObject._SP_Appointment.SP_Insert_Appointment(InstanceObject._Felid_Appointment);
            string TimePatient = DropDownListVisitTime.Text;
            int a =Convert.ToInt32( SqlHelper.ExecuteScalar(SqlHelper.ConnStr,"SP_Insert_Appointment", InstanceObject._Felid_Appointment.PatientName,InstanceObject._Felid_Appointment.Date,
                InstanceObject._Felid_Appointment.Time,InstanceObject._Felid_Appointment.VisitTypeID,InstanceObject._Felid_Appointment.Note));
            InstanceObject._SP_Time.Delete_TimeTB(Convert.ToInt32(DropDownListVisitTime.SelectedValue));
           

            txtPatientName.Text = "";

            Label1.Visible = true;
            lblShowdate.Visible = true;
            lblIDAppo.Text = "رقم ملف الموعد " + a.ToString();
            lblShowdate.Text = "تاريخ الموعد :" + Calendar1.SelectedDate.Date.Year + "/" + Calendar1.SelectedDate.Date.Month + "/" + Calendar1.SelectedDate.Date.Day
                + "      " +"والوقت :"+ TimePatient;
            UpdateTime();
            txtPatientName.Enabled = false;

          
        }
        
    }
}
