using System;
using System.IO; 
using System.Collections;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NMS.SetupScripts
{
    public partial class FrmLog : Form
    {
        private TextWriter m_writer = null;
        private readonly string m_fullLogName = null;
        private const string FILE_NAME = "_InstallLog";

        public FrmLog(string appPath)
        {
            InitializeComponent();
            m_fullLogName = String.Format( 
                @"{0}\{1}", appPath, FILE_NAME );

            if( File.Exists( m_fullLogName ) ) File.Delete( m_fullLogName );

            m_writer = new StreamWriter( File.Create( m_fullLogName ) );
        }

        public void WriteLine(string msg)
        {
            ArrayList list = new ArrayList();
            list.AddRange( textBox.Lines );

            // Add new line 
            list.Add( msg );
            textBox.Lines = ( string[] )list.ToArray( typeof( string ) ); 
            
            this.Refresh();
            textBox.Refresh();

            m_writer.WriteLine( msg );
        }//

        public void Release()
        {
            if( m_writer != null ) m_writer.Close();
        }
    }
}