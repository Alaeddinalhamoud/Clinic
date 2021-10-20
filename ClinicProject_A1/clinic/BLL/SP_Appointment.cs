using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inter_Felid;
using DataAccessDal;
using Lib_Felid;
using System.Data;

namespace BLL
{
    public class SP_Appointment 
    {
        public static readonly Inter_Felid_Appointment dal = DataAccess.CreateAppointmentTB();


        #region Inter_Felid_Appointment Members

        public List<Felid_Appointment> SP_Browes_Appointment_All_By_Date(DateTime Date)
        {
            return dal.SP_Browes_Appointment_All_By_Date(Date);
        }

        public Felid_Appointment SP_Browes_Appointment_By_ID_Felid(int ID)
        {
            return dal.SP_Browes_Appointment_By_ID_Felid(ID);
        }

        public int SP_Delete_Appointment_By_ID(int ID)
        {
            return dal.SP_Delete_Appointment_By_ID(ID);
        }

        public int SP_Insert_Appointment(Felid_Appointment Felid)
        {
            return dal.SP_Insert_Appointment(Felid);
        }

        public int SP_Updata_Appointment_By_ID(Felid_Appointment Felid)
        {
            return dal.SP_Updata_Appointment_By_ID(Felid);
        }






        public DataTable SP_Brows_Datials_Appointement(DateTime Da)
        {
            return dal.SP_Brows_Datials_Appointement(Da);
        }

        

        public int SP_Delete_Appoitment_By_Date(DateTime Date)
        {
            return dal.SP_Delete_Appoitment_By_Date(Date);
        }

        #endregion
    }
}
