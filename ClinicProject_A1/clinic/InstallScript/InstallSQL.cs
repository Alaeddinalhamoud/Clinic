using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;

using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Data;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System.Xml;
using InstallScript.Classes;
using System.Reflection;


namespace InstallScript
{
    [RunInstaller(true)]
    public partial class InstallSQL : Installer
    {

        //default value, it will be overwrite by the installer
        static string ConnStr;
        private static string _DatabaseServer;
        private static string _SetupPath;
        private static string _LoginName;
        private static string _UserName;
        private static string _LoginPassword;
        private static string _DatabaseName;
        private static bool _ServerVersion;


        public InstallSQL()
        {
            InitializeComponent();
        }


        static InstallSQL()
        {
            //تجهيز قيم المتحولات
            DatabaseName = "CLINICDB";
            UserName = "Abdulkarim Kanaan";
            LoginName = "Abdulkarim Kanaan";
            LoginPassword = "microsoftdotnet";
            ConnStr = GetLogin("(local)", "master");
        }

        /// <summary>
        /// Gets or Sets Database Server Name
        /// </summary>
        private static string DatabaseServer
        {
            get
            {
                return _DatabaseServer;
            }
            set
            {
                _DatabaseServer = value;
            }
        }

        /// <summary>
        /// Gets or Sets Setup Path
        /// </summary>
        private static string SetupPath
        {
            get
            {
                return _SetupPath;
            }
            set
            {
                _SetupPath = value;
            }
        }

        /// <summary>
        /// Gets or Sets User Name
        /// </summary>
        private static string UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                _UserName = value;
            }
        }

        private static string LoginName
        {
            get
            {
                return _LoginName;
            }
            set
            {
                _LoginName = value;
            }
        }

        /// <summary>
        /// Gets or Sets User Password
        /// </summary>
        private static string LoginPassword
        {
            get
            {
                return _LoginPassword;
            }
            set
            {
                _LoginPassword = value;
            }
        }

        /// <summary>
        /// Gets or Sets Database Name
        /// </summary>
        private static string DatabaseName
        {
            get
            {
                return _DatabaseName;
            }
            set
            {
                _DatabaseName = value;
            }
        }

        /// <summary>
        /// لتحديد فيما إذا كانت عملية التنصيب لنسخة خادم أم زبون
        /// </summary>
        private static bool ServerVersion
        {
            get
            {
                return _ServerVersion;
            }
            set
            {
                _ServerVersion = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="FileName"></param>
        /// <returns></returns>
        private static string GetScript(string FileName)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
           // MessageBox.Show("sratrmg strer");
           Stream stream = asm.GetManifestResourceStream(asm.GetName().Name + "." + FileName);
            //Stream stream =File.ReadAllText (("D:\\ClinicProject_A1\\clinic\\InstallScript"+FileName).ToString());
          //  MessageBox.Show(FileName.ToString());
           // MessageBox.Show(stream.ToString());
           StreamReader reader = new StreamReader(stream);
          //  StreamReader reader = new StreamReader(("D:\\ClinicProject_A1\\clinic\\InstallScript\\" + FileName).ToString());
          //  MessageBox.Show("end strer");
            return reader.ReadToEnd();
        }

        private static string GetLogin(string DatabaseServer, string DatabaseName)
        {
            return "Server=" + DatabaseServer + ";Database=" + DatabaseName +
                "; Integrated Security = true;";
        }

        private static string GetLogin(string DatabaseServer, string DatabaseName,
            string LoginName, string LoginPassword)
        {
            return "Server=" + DatabaseServer + ";Database=" + DatabaseName +
                ";uid='" + UserName + "';Password=" + LoginPassword;
        }

        private static void CreateDatabase()
        {
            SqlConnection sqlConn = new SqlConnection(ConnStr);
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = String.Format(
                "Create Database {0} " +
                "On" +
                "(Name = '{0}'" +
                ",FILENAME = '{1}{0}.mdf')" +
                "Log On" +
                "(NAME = '{0}Log'" +
                ",FILENAME = '{1}{0}_Log.ldf')"
                , DatabaseName
                , SetupPath + @"\Database\");

            try
            {
                sqlConn.Open();

                sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConn.Close();
            }
        }

        private static void ExecuteSql(SqlConnection sqlConn)
        {
            string[] SqlLine;
            Regex regex = new Regex("^GO", RegexOptions.IgnoreCase | RegexOptions.Multiline);

            string txtSQL = GetScript("Install.txt");
            SqlLine = regex.Split(txtSQL);

            SqlCommand sqlCmd = sqlConn.CreateCommand();
            sqlCmd.Connection = sqlConn;

            if (sqlConn.State == ConnectionState.Closed)
            {
                sqlConn.Open();
            }

            foreach (string line in SqlLine)
            {
                if (line.Length > 0)
                {
                    sqlCmd.CommandText = line;
                    sqlCmd.CommandType = CommandType.Text;
                    try
                    {
                        sqlCmd.ExecuteNonQuery();
                    }
                    catch (SqlException)
                    {
                        //rollback
                        ExecuteDrop(sqlConn);
                        break;
                    }
                }
            }
        }

        private static void ExecuteDrop(SqlConnection sqlConn)
        {
            if (sqlConn.State != ConnectionState.Closed)
            {
                sqlConn.Close();
            }

            sqlConn.Open();
            SqlCommand sqlCmd = sqlConn.CreateCommand();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = GetScript("Uninstall.txt");
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.ExecuteNonQuery();
            sqlConn.Close();
        }

        private static Server GetServer()
        {
            ServerConnection serverConn = new ServerConnection(new SqlConnection(ConnStr));
            return new Server(serverConn);
        }

        static void CreateLogin(string SqlLoginName, string SqlLoginPassword)
        {
            Server MyServer = GetServer();

            Login NewLogin = MyServer.Logins[SqlLoginName];
            ObjectPermissionSet objectPermissionSet = new ObjectPermissionSet();

            if (NewLogin != null)
            {
                NewLogin.Drop();
            }

            //تحديد السماحيات
            objectPermissionSet.Control = true;

            NewLogin = new Login(MyServer, SqlLoginName);
            NewLogin.PasswordPolicyEnforced = false;
            NewLogin.LoginType = LoginType.SqlLogin;
            NewLogin.Create(SqlLoginPassword);
            //NewLogin.Grant(objectPermissionSet, "sa");
            NewLogin.AddToRole("sysadmin");
        }

        static void CreateDatabaseUser(string DatabaseName, string SqlLoginName, string SqlUserName)
        {
            Server MyServer = GetServer();
            User dbUser = new User(MyServer.Databases[DatabaseName], SqlUserName);

            //Create DatabaseUser
            DatabaseMapping mapping = new DatabaseMapping(SqlLoginName, DatabaseName, SqlUserName);
            dbUser.Login = SqlLoginName;
            dbUser.Create();
            dbUser.AddToRole("db_owner");
            dbUser.AddToRole("db_securityadmin");
        }

        private static void UpdateKey(string KeyName, string KeyValue)
        {
            
            string AppConfigLocation = SetupPath + "\\"+"clinic" +".exe.Config";

            XmlDocument xmlDoc = new XmlDocument();

            xmlDoc.Load(AppConfigLocation);

            XmlNode appSettingsNode =
                xmlDoc.SelectSingleNode("configuration/appSettings");

            // Attempt to locate the requested setting.
            foreach (XmlNode childNode in appSettingsNode)
            {
                if (childNode.Attributes["key"].Value == KeyName)
                {
                    childNode.Attributes["value"].Value = KeyValue;
                }
            }
            //xmlDoc.Save(AppDomain.CurrentDomain.BaseDirectory);

            xmlDoc.Save(AppConfigLocation);
        }

        private static void InitilizeServerSettings()
        {
            Server server = GetServer();

            //Set Enable Server Authentication to SQL Server authentication and Windows authentication
            server.Settings.LoginMode = ServerLoginMode.Mixed;
            server.Settings.Alter();

            server.Refresh();
        }

        private static void UpdateConnectionString(string KeyName, string KeyValue)
        {
            string AppConfigLocation = SetupPath + "\\" + "clinic" + ".exe.Config";

            XmlDocument xmlDoc = new XmlDocument();

            xmlDoc.Load(AppConfigLocation);

            XmlNode appSettingsNode =
                xmlDoc.SelectSingleNode("configuration/connectionStrings");

            // Attempt to locate the requested setting.
            foreach (XmlNode childNode in appSettingsNode)
            {
                if (childNode.Attributes["name"].Value == KeyName)
                {
                    childNode.Attributes["connectionString"].Value = KeyValue;
                }
            }
            //xmlDoc.Save(AppDomain.CurrentDomain.BaseDirectory);

            xmlDoc.Save(AppConfigLocation);
        }

        private static void ServerSetup()
        {
            InitilizeServerSettings();

            //إنشاء قاعدة البيانات
            CreateDatabase();

            SqlConnection sqlConn = new SqlConnection(ConnStr);

            //تنصيب و تجهيز قاعدة البيانات
            ExecuteSql(sqlConn);

            if (sqlConn.State != ConnectionState.Closed)
            {
                sqlConn.Close();
            }

            //إنشاء حساب لتسجيل الدخول من خلاله
            CreateLogin(LoginName, LoginPassword);

            CreateDatabaseUser(DatabaseName, LoginName, UserName);
        }

        public override void Install(IDictionary stateSaver)
        {
            base.Install(stateSaver);

            if (Context.Parameters["DatabaseServer"].Length > 0)
            {
                DatabaseServer = Context.Parameters["DatabaseServer"];

                ConnStr = GetLogin(DatabaseServer, "master");

                //RijndaelCryptography rijndael = new RijndaelCryptography();
                //rijndael.GenKey();
                //rijndael.Encrypt(ConnStr);
                ////save information in the state-saver IDictionary
                ////to be used in the Uninstall method
                //stateSaver.Add("key", rijndael.Key);
                //stateSaver.Add("IV", rijndael.IV);
                //stateSaver.Add("ConnStr", rijndael.Encrypted);
            }

            ServerVersion = Convert.ToBoolean(Convert.ToInt32(Context.Parameters["ServerVersion"]));

            //Set Setup Path
            SetupPath = System.Reflection.Assembly.GetExecutingAssembly().Location.Substring
                (0, System.Reflection.Assembly.GetExecutingAssembly().Location.LastIndexOf("\\"));

            if (ServerVersion)
            {
                ServerSetup();
                UpdateKey("dbPicture", "");
                UpdateConnectionString("connectionStringName", GetLogin(DatabaseServer, DatabaseName, UserName, LoginPassword));
                UpdateKey("dbServerName", DatabaseServer);
            }

            else
            {
                UpdateConnectionString("connectionStringName", GetLogin(DatabaseServer, DatabaseName, UserName, LoginPassword));
                UpdateKey("dbServerName", DatabaseServer);
                UpdateKey("dbPicture", DatabaseServer);
            }
            //RijndaelCryptography rijndael = new RijndaelCryptography();
            //rijndael.GenKey();
            //rijndael.Encrypt(ConnStr);
            ////save information in the state-saver IDictionary
            ////to be used in the Uninstall method
            //stateSaver.Add("key", rijndael.Key);
            //stateSaver.Add("IV", rijndael.IV);
            //stateSaver.Add("ConnStr", rijndael.Encrypted);

            
        }



        public override void Uninstall(IDictionary savedState)
        {
            base.Uninstall(savedState);

            if (savedState.Contains("ConnStr"))
            {
                RijndaelCryptography rijndael = new RijndaelCryptography();
                rijndael.Key = (byte[])savedState["key"];
                rijndael.IV = (byte[])savedState["IV"];
                ConnStr = rijndael.Decrypt((byte[])savedState["ConnStr"]);
            }

            SqlConnection sqlConn = new SqlConnection(ConnStr);

            ExecuteDrop(sqlConn);
        }


    }
}
