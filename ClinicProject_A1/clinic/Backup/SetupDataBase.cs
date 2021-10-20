using System;
using System.IO;
using System.Threading;

using System.Collections.Generic;
using System.Text;
using System.Xml;

using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace NMS.SetupScripts
{
    class SetupDataBase
    {
        #region Private variables
        private string m_dbName = string.Empty;
        private string m_backUpFilePath = string.Empty;

        private string m_appConfigFileName = string.Empty;

        private string m_appPath = string.Empty;
        internal string m_datFilePath = string.Empty;

        private FrmLog m_log = null;
        #endregion

        #region Public methods

        public void Execute(FrmLog log)
        {
            m_log = log;

            SqlCommand cmd = null;
            SqlConnection conn = null;
            try
            {
                // Create connection string to datbase
                string connString = GetConnStringToLocalServer();
                log.WriteLine( "Connection string to local database created" );
                log.WriteLine( "Conn string is:   " + connString ); 
                conn = new SqlConnection( connString );

                // Show data lib path
                log.WriteLine( "Db directory name: " + m_datFilePath );  

                string query = string.Format(
                    @"restore database {1} from disk='{2}{0}'",
                    //@"WITH MOVE '{1}_Data' TO '{2}\{1}_Data.MDF', " +
                    //@"MOVE '{1}_Log' TO '{2}\{1}_Log.LDF'",
                    m_backUpFilePath,
                    m_dbName,
                    m_datFilePath
                );

                log.WriteLine( "Following query will be runned on SQL server:" ); 
                log.WriteLine( query ); 
                
                // Create SQL query 
                cmd = new SqlCommand( query, conn );
                cmd.CommandType = CommandType.Text;

                conn.Open();
                cmd.ExecuteNonQuery();

                log.WriteLine( "Database schema is created" );

                // Get 
                string[] parts = connString.Split( new char[] { ';' } );
                foreach( string part in parts )
                {
                    if( part.StartsWith( "Initial" ) )
                    {
                        connString = connString.Replace(
                            part,
                            string.Format( "Initial Catalog={0}", m_dbName )
                        );
                    }
                }

                log.WriteLine( "Conn string is updated to : connString" );
                UpdateAttribute( connString );

            }
            finally
            {
                if( cmd != null ) cmd.Dispose();
                if( conn != null ) conn.Dispose();
            }
        }
        #endregion

        #region Private methods

        public void UpdateAttribute(string connString)
        {
            // Create config file to create 
            string fileName = string.Format( 
                @"{0}{1}", AppPath, AppConfigFileName );

            // Updating connection string in file 
            m_log.WriteLine( "Updating connection string in file: " + fileName ); 
            
            XmlDocument xmlDom = new XmlDocument();
            xmlDom.Load( fileName );

            // Get XML node 
            XmlNode xmlNode = xmlDom.SelectSingleNode(
                "configuration/appSettings/add[@key='ConnString']" );
            xmlNode.Attributes["value"].Value = connString;

            // Updating connection string in file 
            m_log.WriteLine( "Followind node of config file will be updated: " + xmlNode.InnerXml );

            // Save to disk
            xmlDom.Save( fileName );
        }

        /// <summary>
        /// Create conn string to local database 
        /// </summary>
        /// <returns></returns>
        private string GetConnStringToLocalServer()
        {
            SqlDataSourceEnumerator sqlEnum = SqlDataSourceEnumerator.Instance;
            DataTable table = sqlEnum.GetDataSources();

            // Get local machine name 
            string machineName = Environment.MachineName;

            foreach( DataRow row in table.Rows )
            {
                if( row[0].ToString() == machineName )
                {
                    string connString = string.Format(
                        "Persist Security Info=False;Integrated Security=SSPI;Initial Catalog=master;Data Source={0}",
                        machineName );
                    return connString;
                }
            }

            throw new ApplicationException( "No local sql Server is installed" );
        }
        #endregion

        #region Public properties
        /// <summary>
        /// 
        /// </summary>
        public string DbName
        {
            get { return m_dbName; }
            set { m_dbName = value; }
        }

        /// <summary>
        /// Back 
        /// </summary>
        public string BackUpFilePath
        {
            get { return m_backUpFilePath; }
            set { m_backUpFilePath = value; }
        }

        /// <summary>
        /// Set application file 
        /// </summary>
        public string AppConfigFileName
        {
            get { return m_appConfigFileName; }
            set { m_appConfigFileName = value; }
        }

        public string AppPath
        {
            get { return m_appPath; }
            set { m_appPath = value; } 
        }
        #endregion
    }
}
