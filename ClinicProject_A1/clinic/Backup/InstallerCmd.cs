using System;
using System.Threading;

using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;

namespace NMS.SetupScripts
{
    [RunInstaller( true )]
    public partial class InstallerCmd : Installer
    {
        public InstallerCmd()
        {
            InitializeComponent();
        }

        public override void Install(System.Collections.IDictionary stateSaver)
        {
            FrmLog log = null; ;
            try
            {   
               
                base.Install( stateSaver );

                log = new FrmLog( Context.Parameters["AppPath"] );
                log.Show();

                SetupDataBase db = new SetupDataBase();
                
                // Database name 
                db.DbName = Context.Parameters["dbName"];
                log.WriteLine( "Database name: " + db.DbName );

                // Backup file
                db.BackUpFilePath = Context.Parameters["BackUpFile"];
                log.WriteLine( "Backup file: " + db.BackUpFilePath );

                // Application file
                db.AppConfigFileName = Context.Parameters["ConfigFile"];
                log.WriteLine( "Config file: " + db.AppConfigFileName );

                // Application file
                db.AppPath = Context.Parameters["AppPath"];
                log.WriteLine( "AppPath: " + db.AppPath );


                db.m_datFilePath = Context.Parameters["DATFile"];
                log.WriteLine( "DATFile: " + db.m_datFilePath );

                db.Execute(log);
            }
            catch( Exception e )
            {
                log.WriteLine( "Data base creation failed:" );
                log.WriteLine( e.Message );

                throw new ApplicationException( 
                    "Database creation fault: \n" + e.Message );
            }
            finally
            {
                Thread.Sleep( 60 * 1000 );
                
                log.Close();
                log.Release();
            }
        }
    }
}