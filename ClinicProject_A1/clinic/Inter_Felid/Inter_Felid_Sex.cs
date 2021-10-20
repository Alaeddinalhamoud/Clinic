using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib_Felid;

namespace Inter_Felid
{
    public interface  Inter_Felid_Sex
    {
        List<Felid_Sex> SP_Browes_Sex();
        List<Felid_Sex> SP_Browes_Sex_By_ID(int SexID);
    }
}
