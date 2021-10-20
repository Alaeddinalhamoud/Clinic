using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using clinic.Classes;
using System.Configuration;

namespace clinic.Bakeup
{
    public partial class frmTakeBackup : Form
    {
        public frmTakeBackup()
        {
            InitializeComponent();
        }
        OpenFileDialog openFileDialog = new OpenFileDialog();
        SaveFileDialog save = new SaveFileDialog();
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      

      
        public static Server GetServer()
        {
            ServerConnection serverConn = new ServerConnection(
                InstantObject.dbServerName
               );

            Server myServer = new Server(serverConn);

            return myServer;
        }

        private void btnRestore_Click_1(object sender, EventArgs e)
        {
            object ob;
            if (txtRestorePath.Text == "")
            {
                MessageBox.Show("لم تقم بتحديد المسار واسم الملف", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Show_Dialog_Buk();

                return;
            }
            else
            {

                SP_BackUpDataBase T = new SP_BackUpDataBase();
                ob = T.TakeBackUpDatabase(txtRestorePath.Text);
            }
            Server server = GetServer();
            Backup backup = new Backup();
            backup.Action = BackupActionType.Database;
            backup.Database = InstantObject.DatabaseName;
            backup.Devices.AddDevice(txtRestorePath.Text, DeviceType.File);



            try
            {
                //    InstantObject.ThLoading.Open_Loading();
                backup.SqlBackup(server);
                // InstantObject.ThLoading.Abort_Loading();
            }
            catch (Exception ex)
            {
                //   InstantObject.ThLoading.Abort_Loading();
                MessageBox.Show(ex.Message);

            }



            MessageBox.Show("عملية اخذ النسخة انتهت:", "معلومات", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();


            //try
            //{
            //    Backup SqlBackup = new Backup();
            //    SqlBackup.Action = BackupActionType.Database;
            //    SqlBackup.BackupSetDescription = "ArchiveDataBase:" + DateTime.Now.ToShortDateString();
            //    SqlBackup.BackupSetName = "Archive";
               
            //    SqlBackup.Database = InstantObject.DatabaseName;
            //    BackupDeviceItem deviceitem = new BackupDeviceItem(txtRestorePath.Text, DeviceType.File);
            //    ServerConnection connection = new ServerConnection(ConfigurationManager.ConnectionStrings["connectionStringName"].ToString());
            //    Server server1 = new Server(connection);
            //    //Database db = server.Databases["CLINICDB"];
            //    SqlBackup.Initialize = true;
            //    SqlBackup.Checksum = true;
            //    SqlBackup.ContinueAfterError = true;
            //    SqlBackup.Devices.Add(deviceitem);
            //    SqlBackup.Incremental = false;
            //    SqlBackup.ExpirationDate = DateTime.Now.AddDays(3);
            //    SqlBackup.LogTruncation = BackupTruncateLogType.Truncate;
            //    SqlBackup.FormatMedia = false;
            //    SqlBackup.SqlBackup(server);

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Show_Dialog_Buk();
        }

        private void Show_Dialog_Buk()
        {
            save.Title = "حدد مسار الملف";
            save.Filter = "Backup file (*.Bak)|*.Bak";

            if (save.ShowDialog() == DialogResult.OK)
            {
                txtRestorePath.Text = save.FileName;

            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTakeBackup_Load(object sender, EventArgs e)
        {
            if (txtRestorePath.Text == "")
            {
                btnRestore.Enabled = false;
            }
        }

        private void txtRestorePath_TextChanged(object sender, EventArgs e)
        {
            btnRestore.Enabled = true;
        }

       
    }
}
