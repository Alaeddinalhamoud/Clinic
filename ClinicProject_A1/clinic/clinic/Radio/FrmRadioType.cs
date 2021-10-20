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

namespace clinic.RadioType
{
    public partial class FrmRadioType : Form
    {
        public FrmRadioType()
        {
            InitializeComponent();
        }
        SP_RadioType _SP_RadioType = new SP_RadioType();
        Felid_RadioType _Felid_RadioType = new Felid_RadioType();
        private void FrmRadioType_Load(object sender, EventArgs e)
        {
            TS_RadioType.Renderer = new Renderers.WindowsVistaRenderer();
            Fill_DGV_All();
        }

        private void Fill_DGV_All()
        {
            DGV_RadioType_All.DataSource = _SP_RadioType.SP_Browes_RadioType_All();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (txt_TEXT.Text == "")
            {
                MessageBox.Show(" التصوير الاشعاعي  ادخل اسم", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
              //  Thread ThSearch = new Thread(Do_Search);
                
                try
                {
                  //  ThSearch.Start();
                   
                    _Felid_RadioType = _SP_RadioType.SP_Browes_RadioType_By_Name_Felid(txt_TEXT.Text);
                    txt_RadioTypeID.Text = _Felid_RadioType.RadioTypeID.ToString();
                    txt_RadioType.Text = _Felid_RadioType.RadioType;
                   // ThSearch.Abort();
                }
                catch (Exception ex)
                {
                  //  ThSearch.Abort();
                    MessageBox.Show(ex.Message);
                   
                }
            }
        }

        private void Clear_Tools()
        {
            txt_RadioTypeID.Clear();
            txt_RadioType.Clear();
        }

        private void TS_Delete_RadioType_Click(object sender, EventArgs e)
        {




            if (txt_RadioTypeID.Text == "")
            {
                MessageBox.Show("لم تقم باختيار التصوير ",
                                        "تحذير",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("هل انت متأكد من عملية الحذف؟", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    _SP_RadioType.SP_Delete_RadioType(Convert.ToInt32(txt_RadioTypeID.Text));


                    Fill_DGV_All();
                    Clear_Tools();

                }

            }

        }
       
        private void TS_Add_RadioType_Click(object sender, EventArgs e)
        {
            if (txt_RadioType.Text == "")
            { 
                MessageBox.Show("ادخل اسم التصوير الاشعاعي");
            }
            else
            {
                try
                {
                  //  InstantObject.ThLoading.Open_Loading();
                    _Felid_RadioType.RadioType = txt_RadioType.Text;

                    _SP_RadioType.SP_Insert_RadioType(_Felid_RadioType);



                    Fill_DGV_All();
                    Clear_Tools();
                   // InstantObject.ThLoading.Abort_Loading();
                }
                catch (Exception ex)
                {
                  //  InstantObject.ThLoading.Abort_Loading();
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void TS_UpData_RadioType_Click(object sender, EventArgs e)
        {
            if (txt_RadioTypeID.Text == "")
            {
                MessageBox.Show("لم تقم باختيار التصوير ",
                                        "تحذير",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                  //  InstantObject.ThLoading.Open_Loading();
                    _Felid_RadioType.RadioTypeID = Convert.ToInt32(txt_RadioTypeID.Text);
                    _Felid_RadioType.RadioType = txt_RadioType.Text;
                    _SP_RadioType.SP_UpData_RadioType(_Felid_RadioType);



                    Fill_DGV_All();
                    Clear_Tools();
                  //  InstantObject.ThLoading.Abort_Loading();

                }
                catch (Exception ex)
                {
                   // InstantObject.ThLoading.Abort_Loading();
                    MessageBox.Show(ex.Message);

                }
            }
        }

       
        private void Fill_Tools()
        {

            try
            {
                if (DGV_RadioType_All.Rows.Count > 0)
                {
                   // InstantObject.ThLoading.Open_Loading();
                    //Method For Fill Tools at Patient
                    int _RowIndex;
                    _RowIndex = DGV_RadioType_All.CurrentCell.RowIndex;

                    object _CurrentRow = DGV_RadioType_All[0, _RowIndex];
                    int _Value_Current_Row = Convert.ToInt32(DGV_RadioType_All[0, _RowIndex].Value);
                    _Felid_RadioType = _SP_RadioType.SP_Browes_RadioType_By_ID_Felid(_Value_Current_Row);
                    txt_RadioTypeID.Text = _Felid_RadioType.RadioTypeID.ToString();
                    txt_RadioType.Text = _Felid_RadioType.RadioType;
                   // InstantObject.ThLoading.Abort_Loading();
                }
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

        private void TS_MAin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TS_Report_By_NameAll_Click(object sender, EventArgs e)
        {
          //  InstantObject.ThLoading.Open_Loading();
            FrmReport Frm = new FrmReport();
            Frm.ReportRptRadioTypeALL();
         //   InstantObject.ThLoading.Abort_Loading();
            Frm.Show();
        }

        private void TS_Report_Char_Click(object sender, EventArgs e)
        {
          //  InstantObject.ThLoading.Open_Loading();
            FrmReport Frm = new FrmReport();
            Frm.ReportRptRadioFlowChar();
       //    InstantObject.ThLoading.Abort_Loading();
            Frm.Show();
        }

        private void DGV_RadioType_All_DoubleClick(object sender, EventArgs e)
        {
            
            Fill_Tools();
        }

        private void TS_IpmortExcel_Click(object sender, EventArgs e)
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

                    InstantObject.ImportExcel.ReadDataFromExcelIntoSqlServer(path, "RadioTypeTB", "RadioTypeID", "RadioType");

                     Fill_DGV_All();
                }
            }
          

                                
        }
        }
    }

