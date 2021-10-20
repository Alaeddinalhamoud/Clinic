using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Windows.Forms;
using BLL;
using Inter_Felid;
using Lib_Felid;
using ImportExcelDataBase;
using CustomControls;
using Lib_Felid.Patient;

namespace clinic.Classes
{
 public   class InstantObject
    {
        public static string dbUserName = ConfigurationManager.AppSettings["dbUserName"];
        public static string dbPassword = ConfigurationManager.AppSettings["dbPassword"];
        public static string dbServerName = ConfigurationManager.AppSettings["dbServerName"];
        public static string DatabaseName = ConfigurationManager.AppSettings["DatabaseName"];
        public static string dbFolder = Application.StartupPath + @"\Database\";

        public static string ImageFolder =  @"\Image_Path\Patient\";
        public static string Image_X_Folder =  @"\Image_Path\X_Ray\";
        public static string Image_Logo_Folder =  @"\Image_Path\Logo\";
        public static string ImageUserFolder = @"\Image_Path\User\";
      //SP Declration
        public static readonly SP_Disease _SP_Disease = new SP_Disease();
        public static readonly SP_DisaseVisit _SP_DisaseVisit = new SP_DisaseVisit();
        public static readonly SP_Appointment _SP_Appointment = new SP_Appointment();
        public static readonly SP_User _SP_User = new SP_User();
        public static readonly SP_Sex _SP_Sex = new SP_Sex();
        public static readonly SP_Permission _SP_Permission = new SP_Permission();
        public static readonly SP_Accident _SP_Accident = new SP_Accident();
        public static readonly SP_Stamp _SP_Stamp = new SP_Stamp();
        public static readonly SP_Visit _SP_Visit = new SP_Visit();
        public static readonly SP_VisitType _SP_VisitType = new SP_VisitType();
        public static readonly SP_Patient _SP_Patient = new SP_Patient();
        public static readonly SP_Visit_Stamp _SP_Visit_Stamp = new SP_Visit_Stamp();
        public static readonly SP_Visit_Accident _SP_Visit_Accident = new SP_Visit_Accident();
        public static readonly SP_Medications _SP_Medications = new SP_Medications();
        //Felid Declration
        public static  Felid_Disase_Visit _Felid_Disase_Visit = new Felid_Disase_Visit();
        public static Felid_Disease _Felid_Disease = new Felid_Disease();
        public static Felid_User _Felid_User = new Felid_User();
        public static Felid_Permission _Felid_Permission = new Felid_Permission();
        public static Felid_Accident _Felid_Accident = new Felid_Accident();
        public static Felid_Stamp _Felid_Stamp = new Felid_Stamp();
        public static Felid_Visit _Felid_Visit = new Felid_Visit();
        public static Felid_Visit_Stamp _Felid_Visit_Stamp = new Felid_Visit_Stamp();
        public static Felid_Patient _Felid_Patient = new Felid_Patient();
        public static Felid_Visit_Accident _Felid_Visit_Accident = new Felid_Visit_Accident();
        public static Felid_Medications _Felid_Medications = new Felid_Medications();
     //Other Work
      public static  C_ThreadLoding ThLoading = new C_ThreadLoding();
 public static ExCheckedListBox ECheckedListBox = new ExCheckedListBox();

          
      //Felid For Inher


      public static int PatientID = 0;
    
      public static int UserID = 0;
     
      public static string UserName=null;
      public static int Medcation_ID;

     // Function

      public static void KeyPress(KeyPressEventArgs e)
      {
          if (Char.IsNumber(e.KeyChar) || e.KeyChar == (char)8)
          {
              e.Handled = false;
          }
          else e.Handled = true;
      }

     
     public static readonly  ReadDataFromExcel ImportExcel = new ReadDataFromExcel();



    }
}
