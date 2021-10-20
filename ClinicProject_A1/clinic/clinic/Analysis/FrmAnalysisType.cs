using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Lib_Felid;
using Microsoft.ApplicationBlocks.Data;
using System.Threading;
using clinic.FrmThread;
using BLL;
using clinic.Report_Form;
using clinic.Classes;
using System.IO;

namespace clinic.Analysis
{
    public partial class FrmAnalysisType : Form
    {
        public FrmAnalysisType()
        {
            InitializeComponent();
        }

        SP_AnalysisType _SP_AnalysisType = new SP_AnalysisType();
        Filed_AnalysisType _Felid_AnalysisType = new Filed_AnalysisType();


        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void TS_Add_AnalysisType_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_AnalysisType.Text == "")
                {
                    MessageBox.Show("ادخل اسم التحليل", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    _Felid_AnalysisType.Analysis = txt_AnalysisType.Text;
                    try
                    {
                        //  InstantObject.ThLoading.Open_Loading();
                        _SP_AnalysisType.SP_Insert_AnalysisTypeTB(_Felid_AnalysisType);
                        //  InstantObject.ThLoading.Abort_Loading();
                    }
                    catch (Exception ex)
                    {
                        // InstantObject.ThLoading.Abort_Loading();
                        MessageBox.Show(ex.Message);

                    }


                    Fill_DGV_ALL();
                    Clear_Tools();

                }
            }
            catch { };
        }

        private void FrmAnalysisType_Load(object sender, EventArgs e)
        {
            TS_AnalysisType.Renderer = new Renderers.WindowsVistaRenderer();
            Fill_DGV_ALL();
        }

        private void Fill_DGV_ALL()
        {
            DGV_AnalysisTpye.DataSource = _SP_AnalysisType.SP_Browes_AnalysisTypeTB_All();
        }

        private void Clear_Tools()
        {
            txt_AnalysisTypeID.Clear();
            txt_AnalysisType.Clear();
        }

        private void TS_UpData_AnalysisType_Click(object sender, EventArgs e)
        {
            if (txt_AnalysisTypeID.Text == "")
            {
                MessageBox.Show("لم تقم باختيار التحليل ",
                                        "تحذير",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    _Felid_AnalysisType.AnalysisTypeID = Convert.ToInt32(txt_AnalysisTypeID.Text);
                    _Felid_AnalysisType.Analysis = txt_AnalysisType.Text;

                 //   InstantObject.ThLoading.Open_Loading();
                    _SP_AnalysisType.SP_UpData_AnalysisTypeTB(_Felid_AnalysisType);
                    Fill_DGV_ALL();
                    Clear_Tools();
                  //  InstantObject.ThLoading.Abort_Loading();
                }
                catch(Exception ex)
                { //InstantObject.ThLoading.Abort_Loading();
                    MessageBox.Show(ex.Message);
                   
                };

            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Search.Text == "")
                {
                    MessageBox.Show("ادخل اسم التحليل", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Thread ThSearch = new Thread(Do_Search);
                    //ThSearch.Start();

                    _Felid_AnalysisType = _SP_AnalysisType.SP_Browes_AnalysisTypeTB_By_Name_Felid(txt_Search.Text);
                    txt_AnalysisTypeID.Text = _Felid_AnalysisType.AnalysisTypeID.ToString();
                    txt_AnalysisType.Text = _Felid_AnalysisType.Analysis;

                    //  ThSearch.Abort();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
        private void TS_Delete_AnalysisType_Click(object sender, EventArgs e)
        {




            if (txt_AnalysisTypeID.Text=="")
            {
                MessageBox.Show("لم تقم باختيار التحليل ",
                                        "تحذير",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("هل انت متأكد من عملية الحذف؟", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                   // _SP_Patient_All.SP_Delete_Patient_By_PatientID(Convert.ToInt32(txt_PatientID.Text));

                    _SP_AnalysisType.SP_Delete_AnalysisTypeTB(Convert.ToInt32(txt_AnalysisTypeID.Text));

                    Fill_DGV_ALL();
                    Clear_Tools();

                }
            }





        }

        private void DGV_AnalysisTpye_Click(object sender, EventArgs e)
        {
            Fill_Tools();
        }


        private void Fill_Tools()
        {



            try
            {
                //Method For Fill Tools at Patient
                int _RowIndex;
                _RowIndex = DGV_AnalysisTpye.CurrentCell.RowIndex;

                object _CurrentRow = DGV_AnalysisTpye[0, _RowIndex];


                int _Value_Current_Row = Convert.ToInt32(DGV_AnalysisTpye[0, _RowIndex].Value);
                _Felid_AnalysisType = _SP_AnalysisType.SP_Browes_AnalysisTypeTB_By_ID_Felid(_Value_Current_Row);

                txt_AnalysisTypeID.Text = _Felid_AnalysisType.AnalysisTypeID.ToString();
                txt_AnalysisType.Text = _Felid_AnalysisType.Analysis;
            }
            catch { };
        }

        //void Do_Search()
        //{
        //    try
        //    {
        //        FrmSearch FrmS = new FrmSearch();
        //        FrmS.ShowDialog();
        //    }
        //    catch { };
        //}

        private void TSS_Report_FlowChar_Click(object sender, EventArgs e)
        {
          //  InstantObject.ThLoading.Open_Loading();
            FrmReport Frm = new FrmReport();
            Frm.ShowReportAnalysisFlowChar();
           // InstantObject.ThLoading.Abort_Loading();
            Frm.Show();
        }

        private void TSS_Report_All_Click(object sender, EventArgs e)
        {
           // InstantObject.ThLoading.Open_Loading();
            FrmReport Frm = new FrmReport();
            Frm.ShowReportAnalysisAll();
           // InstantObject.ThLoading.Abort_Loading();
            Frm.Show();
        }

        private void TS_BAckToMAin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TS_ImportExcel_Click(object sender, EventArgs e)
        {
            String path;
            Stream myStream;
            OpenFileDialog openFileDialogExcel =new OpenFileDialog();
           // openFileDialogPicture.InitialDirectory = "C:\\temp\\image.jpg";
            openFileDialogExcel.Filter = "Excel (*.xls)|*.xls";
            openFileDialogExcel.FilterIndex = 2;
            openFileDialogExcel.RestoreDirectory = true;
            if (openFileDialogExcel.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = openFileDialogExcel.OpenFile()) != null)
                {
                    path = openFileDialogExcel.FileName;

                    InstantObject.ImportExcel.ReadDataFromExcelIntoSqlServer(path, "AnalysisTypeTB", "AnalysisTypeID", "Analysis");

                    Fill_DGV_ALL();
                }
            }
           

                                
        }

    }
    
       
}
