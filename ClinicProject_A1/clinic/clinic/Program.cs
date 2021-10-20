using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using clinic.FrmAboutUS;
using clinic.Security;
using System.Threading;

namespace clinic
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool logoff = true;
             Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
            //    Application.Run(new FrmPermission());
                do
                {
                    FrmLogin _frmlogin = new FrmLogin();
                    _frmlogin.ShowDialog();

                    FrmMain Frm = new FrmMain();
                    Application.Run(Frm);
                    if (Frm.DialogFormResult != FrmMain.FormResult.LogOff )
                    {
                        logoff = false;
                    }
                } while (logoff);





        }
    }
}
