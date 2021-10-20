using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib_Felid;

namespace Inter_Felid
{
    public interface Inter_Felid_Blood
    {
        List<Felid_Blood> SP_Browes_Blood();
        List<Felid_Blood> SP_Browes_Blood_By_ID(int ID);

    }
}
