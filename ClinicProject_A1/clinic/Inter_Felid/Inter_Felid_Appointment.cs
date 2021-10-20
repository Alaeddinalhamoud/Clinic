using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib_Felid;
using System.Data;

namespace Inter_Felid
{
   public interface Inter_Felid_Appointment
    {
       List<Felid_Appointment> SP_Browes_Appointment_All_By_Date(DateTime Date);
       Felid_Appointment SP_Browes_Appointment_By_ID_Felid(int ID);
       int SP_Delete_Appointment_By_ID(int ID);
       int SP_Insert_Appointment(Felid_Appointment Felid);
       int SP_Updata_Appointment_By_ID(Felid_Appointment Felid);
       DataTable SP_Brows_Datials_Appointement(DateTime Da);
       int SP_Delete_Appoitment_By_Date(DateTime Date);


    }
}
