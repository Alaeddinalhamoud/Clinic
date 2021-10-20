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

namespace clinic
{
    public partial class FrmDisease : Form
    {
        public FrmDisease()
        {
            InitializeComponent();
        }
        //SP For All Disease
        SP_Disease _SP_Disease = new SP_Disease();

        //Felid FOr Disease

        Felid_Disease _Felid_Disease=new Felid_Disease();

        private void FrmDisease_Load(object sender, EventArgs e)
        {
            TS_Disease.Renderer = new Renderers.WindowsVistaRenderer();
            Fill_DVG_Browes_All_From_Disease();
        }

        private void Fill_DVG_Browes_All_From_Disease()
        {
            //For Fill DVG Disease
            DVG_Disease_All.DataSource = _SP_Disease.SP_Browes_Disease_All();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (RD_btn_DiseaseID.Checked == true)
            {
                if (txt_Search.Text == "")
                {
                    MessageBox.Show("ادخل رقم المرض");
                }
                else
                {
                   // Thread ThSearch = new Thread(Do_Search);
                   // ThSearch.Start();
                    try
                    {
                            DVG_Disease_All.DataSource = _SP_Disease.SP_Browes_Disease_By_ID(Convert.ToInt32(txt_Search.Text));
                           // ThSearch.Abort();
                       
                        
                    }
                    catch (Exception ex)
                    {
                       // ThSearch.Abort();
                        MessageBox.Show(ex.Message);
                    }
                    //catch(FieldAccessException ex)
                    //{
                    //    ThSearch.Abort();
                    //    MessageBox.Show("ادخل رقم المرض");
                    //}

                }
            }
            else
            {

                if (txt_Search.Text == "")
                {
                    MessageBox.Show("ادخل اسم المرض");
                }
                else
                {
                   // Thread ThSearch = new Thread(Do_Search);
                   // ThSearch.Start();
                    try
                    {
                        DVG_Disease_All.DataSource = _SP_Disease.SP_Browes_Disease_By_Name(txt_Search.Text);

                      //  ThSearch.Abort();
                    }
                    catch (Exception ex)
                    {
                      //  ThSearch.Abort();
                        MessageBox.Show(ex.Message);
                    }
                    //catch
                    //{
                    //    ThSearch.Abort();
                    //    MessageBox.Show("ادخل اسم المرض");

                    //}

                }
            }
        }

        private void RD_btn_DiseaseID_CheckedChanged(object sender, EventArgs e)
        {
            txt_Search.Text = "";
            lbl_TEXT.Text = RD_btn_DiseaseID.Text;
            Fill_DVG_Browes_All_From_Disease();
        }

        private void RD_btn_Disease_CheckedChanged(object sender, EventArgs e)
        {
            txt_Search.Text = "";
            lbl_TEXT.Text = RD_btn_Disease.Text;
            Fill_DVG_Browes_All_From_Disease();
        }

        private void TS_Add_Disease_Click(object sender, EventArgs e)
        {
            if (txt_Disease.Text == "")
                MessageBox.Show("ادخل اسم  المرض");
            else
            {
                Felid_Disease _Felid_Disease = new Felid_Disease();
                _Felid_Disease.DiseaseName = txt_Disease.Text;
                try
                {
                  //  InstantObject.ThLoading.Open_Loading();
                    _SP_Disease.SP_Insert_Disease(_Felid_Disease);

                    //Fill From Medications By Method
                    Fill_DVG_Browes_All_From_Disease();
                   // InstantObject.ThLoading.Abort_Loading();
                }
                catch (Exception ex)
                {
                   // InstantObject.ThLoading.Abort_Loading();
                    MessageBox.Show(ex.Message);
                }
                
            }
            Clear_Tools();

        }

        private void TS_Update_Disease_Click(object sender, EventArgs e)
        {
            if (txt_DiseaseID.Text.Trim() == "")
            {
                MessageBox.Show("اختر رقم المرض", "تحذير", MessageBoxButtons.OK,
                                       MessageBoxIcon.Warning);
            }
            else
            {

                _Felid_Disease.DiseaseName = txt_Disease.Text;
                try
                {
                 //   InstantObject.ThLoading.Open_Loading();
                    _SP_Disease.SP_UpDate_Disease_By_ID(_Felid_Disease);
                     Fill_DVG_Browes_All_From_Disease();
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

        private void DVG_Disease_All_Click(object sender, EventArgs e)
        {
            try
            {
                //    InstantObject.ThLoading.Open_Loading();
                //Method For Fill Tools at Patient
                int _RowIndex;
                _RowIndex = DVG_Disease_All.CurrentCell.RowIndex;
                int _CurrentRow = Convert.ToInt32(DVG_Disease_All[0, _RowIndex].Value);

                _Felid_Disease = _SP_Disease.SP_Browes_Disease_By_ID_Felid(_CurrentRow);
                txt_DiseaseID.Text = _Felid_Disease.DiseaseID.ToString();
                txt_Disease.Text = _Felid_Disease.DiseaseName;
                //      InstantObject.ThLoading.Abort_Loading();
            }
            catch { };
        }

        private void TS_Delete_Disease_Click(object sender, EventArgs e)
        {
            if (txt_DiseaseID.Text.Trim()=="")
            {
                MessageBox.Show("اختر رقم المرض", "تحذير", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);


            }
            else
            {
                if (MessageBox.Show(":هل انت متأكد", "تحذير", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                  //  InstantObject.ThLoading.Open_Loading();
                    _SP_Disease.SP_Delete_Disease_By_ID(Convert.ToInt32(txt_DiseaseID.Text));

                    //Fill All Disase
                    Fill_DVG_Browes_All_From_Disease();

                    Clear_Tools();
                  //  InstantObject.ThLoading.Abort_Loading();
                }

            }
        }

        private void Clear_Tools()
        {
            txt_DiseaseID.Clear();
            txt_Disease.Clear();
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
            Frm.ShowReportDiseaseAll();
           // InstantObject.ThLoading.Abort_Loading();
            Frm.Show();
        }

        private void TS_BAck_To_Main_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TSS_Report_Disiase_FlowChar_Click(object sender, EventArgs e)
        {

          //  InstantObject.ThLoading.Open_Loading();
            FrmReport Frm = new FrmReport();
            Frm.ReportRptDiseaseInhert();
          //  InstantObject.ThLoading.Abort_Loading();
            Frm.Show();

           
        }

        private void TS_ImportExcel_Click(object sender, EventArgs e)
        {
            String path;
            Stream myStream;
            OpenFileDialog openFileDialogExcel = new OpenFileDialog();
            // openFileDialogPicture.InitialDirectory = "C:\\temp\\image.jpg";
            openFileDialogExcel.Filter = "Excel (*.xls)|*.xls";
            openFileDialogExcel.FilterIndex = 2;
            openFileDialogExcel.RestoreDirectory = true;
            if (openFileDialogExcel.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = openFileDialogExcel.OpenFile()) != null)
                {
                    path = openFileDialogExcel.FileName;

                    InstantObject.ImportExcel.ReadDataFromExcelIntoSqlServer(path, "DiseaseTB", "DiseaseID", "DiseaseName");

                    Fill_DVG_Browes_All_From_Disease();
                }
            }
           
        }
       

       
    }
}
