using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using clinic.FrmThread;

namespace clinic.Classes
{
    public class C_ThreadLoding
    {
        Thread ThLoading ;
        public void Open_Loading()
        {
            ThLoading= new Thread(Do_Loading);
            ThLoading.Start();

        }
        public void Abort_Loading()
        {
            ThLoading.Abort();
        }

       public void Do_Loading()
        {
         //   FrmMain FrmM = new FrmMain();
            FrmBusy FrmB = new FrmBusy();
           // FrmB.MdiParent = FrmM;
            FrmB.ShowDialog();
        }
    }
}
