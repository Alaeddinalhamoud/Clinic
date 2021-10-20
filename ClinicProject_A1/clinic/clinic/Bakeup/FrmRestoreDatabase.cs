using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using clinic.Classes;


namespace clinic.Bakeup
{
    public partial class FrmRestoreDatabase : Form
    {
        public FrmRestoreDatabase()
        {
            InitializeComponent();
        }
        OpenFileDialog opend = new OpenFileDialog();

        private void btnStart_Click(object sender, EventArgs e)
        {
           
            if (txt_Path.Text == "")
            {
                MessageBox.Show("لم تقم بتحديد المسار واسم الملف", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                button1_Click(sender, e);
                return;
            }
            else
            {

                Database CurrentDatabase;

                Server server =GetServer();
                Restore restore = new Restore();
                restore.Database = InstantObject.DatabaseName;
                restore.Action = RestoreActionType.Database;
                restore.Devices.AddDevice(txt_Path.Text, DeviceType.File);
                restore.ReplaceDatabase = true;
                restore.PercentCompleteNotification = 5;

                CurrentDatabase = server.Databases[InstantObject.DatabaseName];

                //Initilize restore Events
               // restore.PercentComplete += new PercentCompleteEventHandler(pbBackupRestore_PercentComplete);
                //restore.Complete += new ServerMessageEventHandler(BackupRestore_Complete);

                try
                {
                    if (CurrentDatabase != null)
                    {
                        server.KillAllProcesses(CurrentDatabase.Name);
                    }

                    //InstantObject.ThLoading.Open_Loading();
                    restore.RelocateFiles.Add(new RelocateFile(InstantObject.DatabaseName,
                                InstantObject.dbFolder + InstantObject.DatabaseName + ".mdf"));

                    restore.SqlRestore(server);

                    CurrentDatabase = server.Databases[InstantObject.DatabaseName];
                    CurrentDatabase.SetOnline();
                   // InstantObject.ThLoading.Abort_Loading();
                }
                catch (Exception ex)
                {
                   // InstantObject.ThLoading.Abort_Loading();
                    MessageBox.Show (ex.Message);
    
                }

                MessageBox.Show("   تمت العملية الاستعاده....حتى يعمل النظام بشكل جيد يجب عليك اعادة تشغيله", "معلومات", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                this.Close();
                System.Environment.Exit(0);
               
            }
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            opend.Title = "حدد مسار الملف";
            opend.Filter = "Backup file (*.Bak)|*.Bak";

            if (opend.ShowDialog() == DialogResult.OK)
            {
                txt_Path.Text = opend.FileName;

            }
        }
        public static Server GetServer()
        {
            ServerConnection serverConn = new ServerConnection(
                InstantObject.dbServerName
               );

            Server myServer = new Server(serverConn);

            return myServer;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRestoreDatabase_Load(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
        }

        private void txt_Path_TextChanged(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
        }
    }
}
