using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib_Felid;

namespace Inter_Felid
{
    public interface  Inter_Felid_ClinicData
    {
        int SP_Insert_Dr_Info(Felid_ClincData Felid);
        int SP_UpData_Dr_Info(Felid_ClincData Felid);
        Felid_ClincData SP_Browse_Dr_Felid();
        int SP_UpData_Dr_Image(Felid_ClincData Felid);
    }
}
