using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

using Lib_Felid;
using Lib_Felid.Patient;
using BLL;


/// <summary>
/// Summary description for InstanceObject
/// </summary>
public class InstanceObject
{
	public InstanceObject()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    //PaitentID & His name
    public static int PatientIDLog;
    public static string PatientName;
    public static string UserFullName;
    public static int PerscreptionIDPatient;

    public static readonly SP_User _SP_User = new SP_User();
    public static readonly SP_Patient _SP_Patient = new SP_Patient();
    public static readonly SP_ClincData _SP_ClincData = new SP_ClincData();
    public static readonly SP_Visit _SP_Visit=new SP_Visit ();
    public static readonly SP_Prescription _SP_Prescription = new SP_Prescription();
    public static readonly SP_Prescription_Medications _SP_Prescription_Medications = new SP_Prescription_Medications();
    public static readonly SP_Invoice _SP_Invoice = new SP_Invoice();
    public static readonly SP_Appointment _SP_Appointment = new SP_Appointment();
    public static readonly SP_Time _SP_Time = new SP_Time();

    public static readonly SP_VisitType _SP_VisitType = new SP_VisitType();

    //Felids

    public static Felid_User _Felid_User = new Felid_User();
    public static Felid_ClincData _Felid_ClincData = new Felid_ClincData();
    public static  Felid_Patient _Felid_Patient = new Felid_Patient();

    public static Felid_Prescription _Felid_Prescription = new Felid_Prescription();
    public static Felid_Prescription_Medications _Felid_Prescription_Medications = new Felid_Prescription_Medications();
    public static Felid_Time _Felid_Time = new Felid_Time();
    public static Felid_Appointment _Felid_Appointment = new Felid_Appointment();
}
