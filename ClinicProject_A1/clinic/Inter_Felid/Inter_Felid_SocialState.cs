﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib_Felid;

namespace Inter_Felid
{
    public interface Inter_Felid_SocialState
    {
        List<Felid_SocialState> SP_Browes_SocialState();
        List<Felid_SocialState> SP_Browes_SocialState_By_ID(int ID);
    }
}
