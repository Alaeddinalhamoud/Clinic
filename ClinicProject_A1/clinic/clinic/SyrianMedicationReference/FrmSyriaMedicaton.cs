using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace clinic.SyrianMedicationReference
{
    public partial class FrmSyriaMedicaton : Form
    {
        public FrmSyriaMedicaton()
        {
            InitializeComponent();
        }

        private void FrmSyriaMedicaton_Load(object sender, EventArgs e)
        {

        }
        string Web_Path;
        private void TV_SMR_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string File_Path = TV_SMR.SelectedNode.Name.ToString();
           // MessageBox.Show(File_Path);
            if (File_Path == "Nod1_Child1")
            {
                Web_Path = Application.StartupPath + @"\SDR\1\1.htm";
            }
            else if (File_Path == "Nod1_Child2")
            {
                Web_Path = Application.StartupPath + @"\SDR\1\2.htm";
            }

            else if (File_Path == "Nod2_Child1")
            {
                Web_Path = Application.StartupPath + @"\SDR\2\1.htm";
            }
            else if (File_Path == "Nod3_Child1")
            {
                Web_Path = Application.StartupPath + @"\SDR\3\1.htm";
            }
            else if (File_Path == "Nod3_Child2")
            {
                Web_Path = Application.StartupPath + @"\SDR\3\2.htm";
            }
            else if (File_Path == "Nod3_Child3")
            {
                Web_Path = Application.StartupPath + @"\SDR\3\3.htm";
            }
            else if (File_Path == "Nod3_Child4")
            {
                Web_Path = Application.StartupPath + @"\SDR\3\4.htm";
            }
            else if (File_Path == "Nod3_Child5")
            {
                Web_Path = Application.StartupPath + @"\SDR\3\5.htm";

            }
            else if (File_Path == "Nod3_Child6")
            {
                Web_Path = Application.StartupPath + @"\SDR\3\6.htm";
            }

            else if (File_Path == "Nod4_Child1")
            {
                Web_Path = Application.StartupPath + @"\SDR\4\1.htm";
            }

            else if (File_Path == "Nod4_Child2")
            {
                Web_Path = Application.StartupPath + @"\SDR\4\2.htm";
            }

            else if (File_Path == "Nod4_Child3")
            {
                Web_Path = Application.StartupPath + @"\SDR\4\3.htm";
            }

            else if (File_Path == "Nod4_Child4")
            {
                Web_Path = Application.StartupPath + @"\SDR\4\4.htm";
            }

            else if (File_Path == "Nod4_Child5")
            {
                Web_Path = Application.StartupPath + @"\SDR\4\5.htm";
            }

            else if (File_Path == "Nod4_Child6")
            {
                Web_Path = Application.StartupPath + @"\SDR\4\6.htm";
            }
            else if (File_Path == "Nod4_Child7")
            {
                Web_Path = Application.StartupPath + @"\SDR\4\7.htm";
            }
            else if (File_Path == "Nod5_Child1")
            {
                Web_Path = Application.StartupPath + @"\SDR\5\1.htm";
            }
            else if (File_Path == "Nod5_Child2")
            {
                Web_Path = Application.StartupPath + @"\SDR\5\2.htm";
            }
            else if (File_Path == "Nod5_Child3")
            {
                Web_Path = Application.StartupPath + @"\SDR\5\3.htm";
            }
            else if (File_Path == "Nod5_Child4")
            {
                Web_Path = Application.StartupPath + @"\SDR\5\4.htm";
            }

            else if (File_Path == "Nod6_Child1")
            {
                Web_Path = Application.StartupPath + @"\SDR\6\1.htm";
            }
            else if (File_Path == "Nod6_Child2")
            {
                Web_Path = Application.StartupPath + @"\SDR\6\2.htm";
            }
            else if (File_Path == "Nod7_Child1")
            {
                Web_Path = Application.StartupPath + @"\SDR\7\1.htm";
            }
            else if (File_Path == "Nod7_Child2")
            {
                Web_Path = Application.StartupPath + @"\SDR\7\2.htm";
            }
            else if (File_Path == "Nod7_Child3")
            {
                Web_Path = Application.StartupPath + @"\SDR\7\3.htm";
            }
            else if (File_Path == "Nod7_Child4")
            {
                Web_Path = Application.StartupPath + @"\SDR\7\4.htm";
            }
            else if (File_Path == "Nod7_Child5")
            {
                Web_Path = Application.StartupPath + @"\SDR\7\5.htm";
            }
            else if (File_Path == "Nod7_Child6")
            {
                Web_Path = Application.StartupPath + @"\SDR\7\6.htm";
            }
            else if (File_Path == "Nod8_Child1")
            {
                Web_Path = Application.StartupPath + @"\SDR\8\1.htm";
            }
            else if (File_Path == "Nod8_Child2")
            {
                Web_Path = Application.StartupPath + @"\SDR\8\2.htm";
            }
            else if (File_Path == "Nod8_Child3")
            {
                Web_Path = Application.StartupPath + @"\SDR\8\3.htm";
            }
            else if (File_Path == "Nod8_Child4")
            {
                Web_Path = Application.StartupPath + @"\SDR\8\4.htm";
            }
            else if (File_Path == "Nod9_Child1")
            {
                Web_Path = Application.StartupPath + @"\SDR\9\1.htm";
            }
            else if (File_Path == "Nod9_Child2")
            {
                Web_Path = Application.StartupPath + @"\SDR\9\2.htm";
            }
            else if (File_Path == "Nod9_Child3")
            {
                Web_Path = Application.StartupPath + @"\SDR\9\3.htm";
            }
            else if (File_Path == "Nod9_Child4")
            {
                Web_Path = Application.StartupPath + @"\SDR\9\4.htm";
            }
            else if (File_Path == "Nod9_Child5")
            {
                Web_Path = Application.StartupPath + @"\SDR\9\5.htm";
            }
            else if (File_Path == "Nod9_Child6")
            {
                Web_Path = Application.StartupPath + @"\SDR\9\6.htm";
            }
            else if (File_Path == "Nod9_Child7")
            {
                Web_Path = Application.StartupPath + @"\SDR\9\7.htm";
            }
            else if (File_Path == "Nod9_Child8")
            {
                Web_Path = Application.StartupPath + @"\SDR\9\8.htm";
            }
            else if (File_Path == "Nod9_Child9")
            {
                Web_Path = Application.StartupPath + @"\SDR\9\9.htm";
            }
            else if (File_Path == "Nod10_Child1")
            {
                Web_Path = Application.StartupPath + @"\SDR\10\1.htm";
            }
            else if (File_Path == "Nod10_Child2")
            {
                Web_Path = Application.StartupPath + @"\SDR\10\2.htm";
            }
            else if (File_Path == "Nod10_Child3")
            {
                Web_Path = Application.StartupPath + @"\SDR\10\3.htm";
            }
            else if (File_Path == "Nod10_Child4")
            {
                Web_Path = Application.StartupPath + @"\SDR\10\4.htm";
            }
            else if (File_Path == "Nod10_Child5")
            {
                Web_Path = Application.StartupPath + @"\SDR\10\5.htm";
            }
            else if (File_Path == "Nod11_Child1")
            {
                Web_Path = Application.StartupPath + @"\SDR\11\1.htm";
            }
            else if (File_Path == "Nod11_Child2")
            {
                Web_Path = Application.StartupPath + @"\SDR\11\2.htm";
            }
            else if (File_Path == "Nod11_Child3")
            {
                Web_Path = Application.StartupPath + @"\SDR\11\3.htm";
            }
            else if (File_Path == "Nod11_Child4")
            {
                Web_Path = Application.StartupPath + @"\SDR\11\4.htm";
            }
            else if (File_Path == "Nod11_Child5")
            {
                Web_Path = Application.StartupPath + @"\SDR\11\5.htm";
            }
            else if (File_Path == "Nod11_Child6")
            {
                Web_Path = Application.StartupPath + @"\SDR\11\6.htm";
            }
            else if (File_Path == "Nod11_Child7")
            {
                Web_Path = Application.StartupPath + @"\SDR\11\7.htm";
            }
            else if (File_Path == "Nod12_Child1")
            {
                Web_Path = Application.StartupPath + @"\SDR\12\1.htm";
            }
            else if (File_Path == "Nod12_Child2")
            {
                Web_Path = Application.StartupPath + @"\SDR\12\2.htm";
            }
            else if (File_Path == "Nod12_Child3")
            {
                Web_Path = Application.StartupPath + @"\SDR\12\3.htm";
            }
            else if (File_Path == "Nod12_Child4")
            {
                Web_Path = Application.StartupPath + @"\SDR\12\4.htm";
            }
            else if (File_Path == "Nod12_Child5")
            {
                Web_Path = Application.StartupPath + @"\SDR\12\5.htm";
            }
            else if (File_Path == "Nod12_Child6")
            {
                Web_Path = Application.StartupPath + @"\SDR\12\6.htm";
            }
            else if (File_Path == "Nod12_Child7")
            {
                Web_Path = Application.StartupPath + @"\SDR\12\7.htm";
            }
            else if (File_Path == "Nod12_Child8")
            {
                Web_Path = Application.StartupPath + @"\SDR\12\8.htm";
            }
            else if (File_Path == "Nod13_Child1")
            {
                Web_Path = Application.StartupPath + @"\SDR\13\1.htm";
            }
            else if (File_Path == "Nod13_Child2")
            {
                Web_Path = Application.StartupPath + @"\SDR\13\2.htm";
            }
            else if (File_Path == "Nod13_Child3")
            {
                Web_Path = Application.StartupPath + @"\SDR\13\3.htm";
            }
            else if (File_Path == "Nod14_Child1")
            {
                Web_Path = Application.StartupPath + @"\SDR\14\1.htm";
            }
            else if (File_Path == "Nod14_Child2")
            {
                Web_Path = Application.StartupPath + @"\SDR\14\2.htm";
            }
            else if (File_Path == "Nod14_Child3")
            {
                Web_Path = Application.StartupPath + @"\SDR\14\3.htm";
            }
            else if (File_Path == "Nod14_Child4")
            {
                Web_Path = Application.StartupPath + @"\SDR\14\4.htm";
            }
            else if (File_Path == "Nod14_Child5")
            {
                Web_Path = Application.StartupPath + @"\SDR\14\5.htm";
            }
            else if (File_Path == "Nod15_Child1")
            {
                Web_Path = Application.StartupPath + @"\SDR\15\1.htm";
            }
            else if (File_Path == "Nod15_Child2")
            {
                Web_Path = Application.StartupPath + @"\SDR\15\2.htm";
            }
            else if (File_Path == "Nod16_Child1")
            {
                Web_Path = Application.StartupPath + @"\SDR\16\1.htm";
            }
            else if (File_Path == "Nod17_Child1")
            {
                Web_Path = Application.StartupPath + @"\SDR\17\1.htm";
            }
            else if (File_Path == "Nod17_Child2")
            {
                Web_Path = Application.StartupPath + @"\SDR\17\2.htm";
            }
            else if (File_Path == "Nod17_Child3")
            {
                Web_Path = Application.StartupPath + @"\SDR\17\3.htm";
            }
            else if (File_Path == "Nod17_Child4")
            {
                Web_Path = Application.StartupPath + @"\SDR\17\4.htm";
            }
            else if (File_Path == "Nod17_Child5")
            {
                Web_Path = Application.StartupPath + @"\SDR\17\5.htm";
            }
            Web_SMR.Navigate(Web_Path);
            TS_Path_Location.Text = TV_SMR.SelectedNode.Text.ToString();
        }
    }
}
