using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Lib_Felid;
using System.Threading;
using clinic.FrmThread;
using BLL;
using clinic.Report_Form;
using clinic.Classes;
using System.IO;

namespace clinic.Operation
{
    public partial class FrmOperationType : Form
    {
        
        public FrmOperationType()
        {
            InitializeComponent();
        }

        //SP For Operation Type
        SP_OperationType _SP_OperationType = new SP_OperationType();

        //Felid FOr OperationType
        Felid_OperationType _Felid_OperationType = new Felid_OperationType();

        private void FrmOperationType_Load(object sender, EventArgs e)
        {
            TS_Operation.Renderer = new Renderers.WindowsVistaRenderer();
            Fill_DVG_Browes_All_From_OperationType();
        }

        private void Fill_DVG_Browes_All_From_OperationType()
        {
            //Fill DGV OperationType
            DGV_OperationType.DataSource = _SP_OperationType.SP_Browes_OperationType_All();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (txt_Search.Text == "")
            {
                MessageBox.Show("ادخل اسم العملية", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
             //   Thread ThSearch = new Thread(Do_Search);

                try
                {
                 //   ThSearch.Start();

                    _Felid_OperationType = _SP_OperationType.SP_Browes_OperationType_By_Name(txt_Search.Text);
                    txt_OperationTypeID.Text = _Felid_OperationType.OperationTypeID.ToString();
                    txt_OperationType.Text = _Felid_OperationType.OperationType;
                   // ThSearch.Abort();
                }
                catch (Exception ex)
                {
                   // ThSearch.Abort(); 
                    MessageBox.Show(ex.Message); 
                };
                 
            }
        }

        
        

        private void TS_Add_OperationType_Click(object sender, EventArgs e)
        {
            if (txt_OperationType.Text=="")
                MessageBox.Show("ادخل اسم العملية");
            else
            {
                _Felid_OperationType.OperationType = txt_OperationType.Text;
                try
                {
                 //   InstantObject.ThLoading.Open_Loading();
                    _SP_OperationType.SP_Insert_OperationType(_Felid_OperationType);


                    //Fill From OperationType By Method

                    Fill_DVG_Browes_All_From_OperationType();
                 //   InstantObject.ThLoading.Abort_Loading();
                }
                catch (Exception ex)
                {
                 //   InstantObject.ThLoading.Abort_Loading();
                    MessageBox.Show(ex.Message);
                }


            }

            Clear_Tools();
        }

        private void Clear_Tools()
        {
            txt_OperationTypeID.Clear();
            txt_OperationType.Clear();

        }

        private void TS_UpData_OperationTpye_Click(object sender, EventArgs e)
        {
           
            if (txt_OperationTypeID.Text.Trim()=="")
            {
                MessageBox.Show("اختر رقم العملية", "تحذير", MessageBoxButtons.OK,
                                       MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    _Felid_OperationType.OperationType = txt_OperationType.Text;
                   // InstantObject.ThLoading.Open_Loading();
                    _SP_OperationType.SP_UpData_OperationType_By_ID(_Felid_OperationType);


                    //Fill From OperationType By Method

                    Fill_DVG_Browes_All_From_OperationType();
                   // InstantObject.ThLoading.Abort_Loading();
                }
                catch (Exception ex) 
                {
                  //  InstantObject.ThLoading.Abort_Loading();
                    MessageBox.Show(ex.Message); 
                }

                
            }

            Clear_Tools();
        }

        private void TS_Delete_OperationType_Click(object sender, EventArgs e)
        {
            if (txt_OperationTypeID.Text.Trim() == "")
            {
                MessageBox.Show("اختر رقم العملية", "تحذير", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);


            }
            else
            {
                if (MessageBox.Show("هل انت متأكد من عملية الحذف؟", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                  //  InstantObject.ThLoading.Open_Loading();
                    _SP_OperationType.SP_Delete_OperationType_By_ID(Convert.ToInt32(txt_OperationTypeID.Text));
                    //Fill DVG All
                    Fill_DVG_Browes_All_From_OperationType();


                    Clear_Tools();
                  //  InstantObject.ThLoading.Abort_Loading();
                }

            }
        }

        private void DGV_OperationType_Click(object sender, EventArgs e)
        {
            try
            {
                //            InstantObject.ThLoading.Open_Loading();
                //Method For Fill Tools at Patient
                int _RowIndex;
                _RowIndex = DGV_OperationType.CurrentCell.RowIndex;
                int _CurrentRow = Convert.ToInt32(DGV_OperationType[0, _RowIndex].Value);
                //_Felid_Patient = _SP_Patient_All.SP_Browes_Patient_By_PatientID(_CurrentRow);
                _Felid_OperationType = _SP_OperationType.SP_Browes_OperationType_By_ID_Felid(_CurrentRow);
                txt_OperationTypeID.Text = _Felid_OperationType.OperationTypeID.ToString();
                txt_OperationType.Text = _Felid_OperationType.OperationType;
                //         InstantObject.ThLoading.Abort_Loading();
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

        private void TSS_Report_All_Click(object sender, EventArgs e)
        {
          //  InstantObject.ThLoading.Open_Loading();
            FrmReport Frm = new FrmReport();
            Frm.ShowReportOperationTypeAll();
          //  InstantObject.ThLoading.Abort_Loading();
            Frm.Show();
        }

        private void TSS_Report_FlowChar_Click(object sender, EventArgs e)
        {
          //  InstantObject.ThLoading.Open_Loading();
            FrmReport Frm = new FrmReport();
            Frm.ShowReportOperationTypeFlowChar();
          //  InstantObject.ThLoading.Abort_Loading();
            Frm.Show();
        }

        private void TS_Back_To_Main_Click(object sender, EventArgs e)
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

                    InstantObject.ImportExcel.ReadDataFromExcelIntoSqlServer(path, "OperationTypeTB", "OperationTypeID", "OperationType");

                    Fill_DVG_Browes_All_From_OperationType();
                }
            }
        }

    }
}
