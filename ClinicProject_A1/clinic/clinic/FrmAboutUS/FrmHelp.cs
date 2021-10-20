using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AgentServerObjects;
using SpeechLib;

namespace clinic.FrmAboutUS
{
    public partial class FrmHelp : Form
    {
        public FrmHelp()
        {
            InitializeComponent();

           
        }

        SpVoice speech = new SpVoice();
        IAgentCharacterEx CharacterEx = null;
        //private void ShowAgent()
        //{
        //    AgentServer Srv = new AgentServer();
        //    if (Srv == null)
        //    { MessageBox.Show("ERROR: Agent Server couldn't be started!"); }

        //    IAgentEx SrvEx;
        //    // The following cast does the QueryInterface to fetch IAgentEx interface from the IAgent interface, directly supported by the object
        //    SrvEx = (IAgentEx)Srv;

        //    // First try to load the default character
        //    int dwCharID = 0, dwReqID = 0;
        //    try
        //    {
        //        // null is used where VT_EMPTY variant is expected by the COM object
        //        String strAgentCharacterFile = null;

        //        //Get the acs path you can download more Agents from this link //http://www.msagentring.org/chars.htm 
        //        strAgentCharacterFile = AppDomain.CurrentDomain.BaseDirectory + "\\CLIPPIT.ACS"; //merlin.acs";


        //        //load the acs file
        //        SrvEx.Load(strAgentCharacterFile, out dwCharID, out dwReqID);

        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("Failed to load Agent character! Exception details:");
        //    }

        //    SrvEx.GetCharacterEx(dwCharID, out CharacterEx);
        //    //show the agent
        //    CharacterEx.Show(0, out dwReqID);
          
        //    // Set Location
        //    CharacterEx.SetPosition(Screen.PrimaryScreen.WorkingArea.Width - 200, Screen.PrimaryScreen.WorkingArea.Height - 200);
        //    CharacterEx.Speak("Wel Come To Futuer Clinic", null, out dwReqID);


        //}

        private void FrmHelp_Load(object sender, EventArgs e)
        {

           // ShowAgent();
            // speech.Speak("Wel Come To Futuer Clinic", SpeechVoiceSpeakFlags.SVSFVoiceMask);
        }

    }
}
