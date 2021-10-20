using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Lib_Felid;
using clinic.Classes;
using BLL;
using CustomControls;

namespace clinic.Visit
{
    public partial class FrmVisit : Form
    {
        public FrmVisit()
        {
            InitializeComponent();
        }
        //SP Visit F

        //Felid for Visit



        private void FrmVisit_Load(object sender, EventArgs e)
        {



            // ExCheckedListBox CLB_Accident = new ExCheckedListBox();

            // Let's bind it to data from a Database
            // var GenreList = from c in databasebObjectContext.Genres orderby c.gnDescription select c;
            // cbGenreList.DataSource = GenreList.ToArray();



            MU_Diseas.Renderer = new Renderers.WindowsVistaRenderer();
            TS_Vist.Renderer = new Renderers.WindowsVistaRenderer();

            txt_PatientInhre.Text = InstantObject.PatientID.ToString();

            if (Convert.ToInt32(txt_PatientInhre.Text) == 0)
            {

                Fill_CmbVisit();
                DGV_VIST_ALL.AutoGenerateColumns = false;
                // AutoGenerateColumns = false;
                Fill_CmbPatientFull();
                Fill_CmbDisases();

                Fill_Tools();
            }
            else
            {
                Cmb_FullName.ValueMember = "PatientID";
                Cmb_FullName.DisplayMember = "FirstName";
                Cmb_FullName.DataSource = InstantObject._SP_Patient.SP_Browes_Patient_FullName_By_ID(Convert.ToInt32(txt_PatientInhre.Text));

                Fill_CmbVisit();
                Fill_CmbDisases();

                DGV_VIST_ALL.DataSource = InstantObject._SP_Visit.SP_Browes_Visit_Detiles_PatientID(Convert.ToInt32(txt_PatientInhre.Text));

            }



            Fill_CLB_Accident();
            Fill_CLB_Stamp();

        }

        private void Fill_CLB_Stamp()
        {
            CLB_Stamp.DataSource = InstantObject._SP_Stamp.SP_Browes_StampAll();
            CLB_Stamp.DisplayMember = "StampName";
            CLB_Stamp.ValueMember = "StampID";
        }

        private void Fill_CLB_Accident()
        {


            CLB_Accident.DataSource = InstantObject._SP_Accident.SP_Browes_AccidentAll();
            CLB_Accident.DisplayMember = "AccidentName";
            CLB_Accident.ValueMember = "AccidentID";



          
        }



        private void Fill_CmbPatientFull()
        {
            Cmb_FullName.ValueMember = "PatientID";
            Cmb_FullName.DisplayMember = "FirstName";
            Cmb_FullName.DataSource = InstantObject._SP_Patient.SP_Browes_Patient_FullName();
        }

        private void Fill_CmbVisit()
        {
            Cmb_VisitTypeID.DisplayMember = "VisitType";
            Cmb_VisitTypeID.ValueMember = "VisitTypeID";
            Cmb_VisitTypeID.DataSource = InstantObject._SP_VisitType.VisitTypeTB_Browes_All();
        }

        private void Fill_CmbDisases()
        {
            Cmb_Disase.ValueMember = "DiseaseID";
            Cmb_Disase.DisplayMember = "DiseaseName";
            Cmb_Disase.DataSource = InstantObject._SP_Disease.SP_Browes_Disease_All();
        }

        private void Fill_Tools()
        {
            
            //Fill ToolS

            DGV_VIST_ALL.DataSource = InstantObject._SP_Visit.SP_Browes_Visit_Detiles_PatientID(InstantObject.PatientID);

        }

        private void TS_Add_Visit_Click(object sender, EventArgs e)
        {
            if (Cmb_FullName.Text == "")
            {
                MessageBox.Show("اختر المريض");
            }
            else if (Cmb_VisitTypeID.Text == "")
            {
                MessageBox.Show("اختر نوع الزيارة");
            }
            else if (txt_Weight.Text == "")
            {
                MessageBox.Show("ادخل الوزن");
            }
            else if (txt_BloodPressure.Text == "")
            {
                MessageBox.Show("ادخل ضغط الدم");
            }
            else if (txt_PulseHeart.Text == "")
            {
                MessageBox.Show("ادخل نبضات القلب");
            }
            else if (txt_Temperature.Text == "")
            {
                MessageBox.Show("ادخل درجة الحرارة");
            }


            else
            {
                // InstantObject.ThLoading.Open_Loading();
                InstantObject._Felid_Visit.PatientID = Convert.ToInt32(Cmb_FullName.SelectedValue);
                InstantObject._Felid_Visit.DataOfVisit = Convert.ToDateTime(DPK_DataOfVisit.Value);
                InstantObject._Felid_Visit.VisitTypeID = Convert.ToInt32(Cmb_VisitTypeID.SelectedValue);
                InstantObject._Felid_Visit.Weight = Convert.ToDouble(txt_Weight.Text);
                InstantObject._Felid_Visit.BloodPressure = Convert.ToDouble(txt_BloodPressure.Text);
                InstantObject._Felid_Visit.PulseHeart = Convert.ToInt32(txt_PulseHeart.Text);
                InstantObject._Felid_Visit.Temperature = Convert.ToDouble(txt_Temperature.Text);
                InstantObject._Felid_Visit.PhysicalExamination = txt_PhysicalExamination.Text;

                InstantObject._Felid_Visit.Note = txt_Note.Text;
                int Scalar_VisitID = InstantObject._SP_Visit.SP_Insert_VisitTB(InstantObject._Felid_Visit);
                //  InstantObject.ThLoading.Abort_Loading()


                
                for (int i = 0; i < CLB_Stamp.CheckedIndices.Count; i++)
                {
                    DataRowView dr = (DataRowView)CLB_Stamp.Items[i];
                    InstantObject._Felid_Visit_Stamp.PatientID = Convert.ToInt32(Cmb_FullName.SelectedValue);
                    InstantObject._Felid_Visit_Stamp.VisitID = Scalar_VisitID;
                    InstantObject._Felid_Visit_Stamp.StampID = Convert.ToInt32(dr[CLB_Stamp.ValueMember]);
                    InstantObject._SP_Visit_Stamp.SP_Insert_Visit_Stamp(InstantObject._Felid_Visit_Stamp);


                }
                for (int i = 0; i < CLB_Accident.CheckedIndices.Count; i++)
                {
                    DataRowView dr = (DataRowView)CLB_Accident.Items[i];
                    InstantObject._Felid_Visit_Accident.PatientID = Convert.ToInt32(Cmb_FullName.SelectedValue);
                    InstantObject._Felid_Visit_Accident.VisitID = Scalar_VisitID;
                    InstantObject._Felid_Visit_Accident.AccidentID = Convert.ToInt32(dr[CLB_Accident.ValueMember]);

                    InstantObject._SP_Visit_Accident.SP_Insert_Visit_Accident(InstantObject._Felid_Visit_Accident);


                }


                MessageBox.Show("تمت الاضافة");

                //Clear Tools
                Clear_Tools();
                //Fill Tools
                Fill_Tools();

            }


        }

        private void Clear_Tools()
        {
            txt_VisitID.Clear();
            txt_Weight.Clear();
            txt_BloodPressure.Clear();
            txt_PulseHeart.Clear();
            txt_Temperature.Clear();
            txt_PhysicalExamination.Clear();

            txt_Note.Clear();
            ClearClB();

        }

        private void ClearClB()
        {
            for (int i = 0; i < CLB_Stamp.Items.Count; i++)
            {
                CLB_Stamp.SetItemCheckState(i, CheckState.Unchecked);
            }
            for (int i = 0; i < CLB_Accident.Items.Count; i++)
            {
                CLB_Accident.SetItemCheckState(i, CheckState.Unchecked);
            }
        }



        private void TS_UpData_Visit_Click(object sender, EventArgs e)
        {
            if (txt_VisitID.Text == "")
            {
                MessageBox.Show("اختر الزيارة");
            }
            else if (Cmb_FullName.Text == "")
            {
                MessageBox.Show("اختر المريض");
            }
            else if (Cmb_VisitTypeID.Text == "")
            {
                MessageBox.Show("اختر نوع الزيارة");
            }
            else if (txt_Weight.Text == "")
            {
                MessageBox.Show("ادخل الوزن");
            }
            else if (txt_BloodPressure.Text == "")
            {
                MessageBox.Show("ادخل ضغط الدم");
            }
            else if (txt_PulseHeart.Text == "")
            {
                MessageBox.Show("ادخل نبضات القلب");
            }
            else if (txt_Temperature.Text == "")
            {
                MessageBox.Show("ادخل درجة الحرارة");
            }
            else if (txt_PhysicalExamination.Text == "")
            {
                MessageBox.Show("ادخل التشخيص المبدئي");
            }

            else
            {
                // InstantObject.ThLoading.Open_Loading();
                InstantObject._Felid_Visit.VisitID = Convert.ToInt32(txt_VisitID.Text);
                InstantObject._Felid_Visit.PatientID = Convert.ToInt32(Cmb_FullName.SelectedValue);
                InstantObject._Felid_Visit.DataOfVisit = Convert.ToDateTime(DPK_DataOfVisit.Value);
                InstantObject._Felid_Visit.VisitTypeID = Convert.ToInt32(Cmb_VisitTypeID.SelectedValue);
                InstantObject._Felid_Visit.Weight = Convert.ToDouble(txt_Weight.Text);
                InstantObject._Felid_Visit.BloodPressure = Convert.ToDouble(txt_BloodPressure.Text);
                InstantObject._Felid_Visit.PulseHeart = Convert.ToInt32(txt_PulseHeart.Text);
                InstantObject._Felid_Visit.Temperature = Convert.ToDouble(txt_Temperature.Text);
                InstantObject._Felid_Visit.PhysicalExamination = txt_PhysicalExamination.Text;

                InstantObject._Felid_Visit.Note = txt_Note.Text;
                InstantObject._SP_Visit.SP_UpData_VisitTB_By_ID(InstantObject._Felid_Visit);
                //  InstantObject.ThLoading.Abort_Loading();

                for (int i = 0; i < CLB_Stamp.Items.Count; i++)
                {
                    if (CLB_Stamp.GetItemChecked(i) == true)
                    {
                        DataRowView dr = (DataRowView)CLB_Stamp.Items[i];
                        InstantObject._Felid_Visit_Stamp.PatientID = Convert.ToInt32(Cmb_FullName.SelectedValue);
                        InstantObject._Felid_Visit_Stamp.VisitID = Convert.ToInt32(txt_VisitID.Text);
                        InstantObject._Felid_Visit_Stamp.StampID = Convert.ToInt32(dr[CLB_Stamp.ValueMember]);
                        InstantObject._SP_Visit_Stamp.SP_Insert_Visit_Stamp(InstantObject._Felid_Visit_Stamp);
                    }
                    else {
                        DataRowView dr = (DataRowView)CLB_Stamp.Items[i];
                        InstantObject._SP_Visit_Stamp.SP_Delete_Visit_Stamp_ByVisitID(Convert.ToInt32(dr[CLB_Stamp.ValueMember]));

                    }
                }
                for (int i = 0; i < CLB_Accident.Items.Count; i++)
                {
                    if (CLB_Accident.GetItemChecked(i) == true)
                    {
                        DataRowView dr = (DataRowView)CLB_Accident.Items[i];
                        InstantObject._Felid_Visit_Accident.PatientID = Convert.ToInt32(Cmb_FullName.SelectedValue);
                        InstantObject._Felid_Visit_Accident.VisitID = Convert.ToInt32(txt_VisitID.Text);
                        InstantObject._Felid_Visit_Accident.AccidentID = Convert.ToInt32(dr[CLB_Accident.ValueMember]);
                        InstantObject._SP_Visit_Accident.SP_Insert_Visit_Accident(InstantObject._Felid_Visit_Accident);
                    }
                    else
                    {
                        DataRowView dr = (DataRowView)CLB_Accident.Items[i];
                        InstantObject._SP_Visit_Accident.SP_Delete_Visit_Accident_ByAccidentID(Convert.ToInt32(dr[CLB_Accident.ValueMember]));

                    }
                }

                MessageBox.Show(" تم التعديل");

                //Clear Tools
                Clear_Tools();
                //Fill Tools
                //Fill_Tools();
                Fill_Tools();
            }
        }

        private void TS_Delete_Visit_Click(object sender, EventArgs e)
        {
            if (txt_VisitID.Text.Trim() == "")
            {
                MessageBox.Show("لم تقم باختيار المرض السابق",
                                        "تحذير",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
            }



            else
            {
                if (MessageBox.Show("هل انت متأكد من عملية الحذف؟", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    //  InstantObject.ThLoading.Open_Loading();
                    InstantObject._SP_Visit.SP_Delete_VisitTB_By_ID(Convert.ToInt32(txt_VisitID.Text));
                    //  InstantObject.ThLoading.Abort_Loading();
                    Clear_Tools();
                    Fill_Tools();
                }
            }




        }


        private void Fill_DGV_DisasaeVisit()
        {
            DGV_Diseaes.DataSource = InstantObject._SP_DisaseVisit.SP_Brows_Diasase_Patient_AndVisit(Convert.ToInt32(Cmb_FullName.SelectedValue), Convert.ToInt32(txt_VisitID.Text));
        }


        private void Mu_Add_dissae_Click(object sender, EventArgs e)
        {
            if (txt_VisitID.Text == "")
            {
                MessageBox.Show("اختر اسم المريض", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                
                    InstantObject._Felid_Disase_Visit.VisitID = Convert.ToInt32(txt_VisitID.Text);
                    InstantObject._Felid_Disase_Visit.PatientID = Convert.ToInt32(Cmb_FullName.SelectedValue);
                    InstantObject._Felid_Disase_Visit.DiseaseID = Convert.ToInt32(Cmb_Disase.SelectedValue);
                    InstantObject._SP_DisaseVisit.SP_Insert_Diasase_Patient_AndVisit(InstantObject._Felid_Disase_Visit);
                    Fill_DGV_DisasaeVisit();
                    Fill_CmbDisases();
                  
                }
                catch (Exception ex)
                {
                    // InstantObject.ThLoading.Abort_Loading();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Mu_Detete_Desaie_Click(object sender, EventArgs e)
        {
            if (Cmb_Disase.Text == "")
            {
                MessageBox.Show("اختر المرض", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //   InstantObject.ThLoading.Open_Loading();
                InstantObject._SP_DisaseVisit.SP_Delete_Diasase_Patient_AndVisit(Convert.ToInt32(Cmb_Disase.SelectedValue));

                Fill_CmbDisases();
                Fill_DGV_DisasaeVisit();
                Cmb_Disase.Text = "";
                //  InstantObject.ThLoading.Abort_Loading();
            }
        }

        private void MU_Updata_Diseae_Click(object sender, EventArgs e)
        {
            if (txt_VisitID.Text == "")
            {
                MessageBox.Show("اختر اسم المرض", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    // InstantObject.ThLoading.Open_Loading();
                    InstantObject._Felid_Disase_Visit.VisitID = Convert.ToInt32(txt_VisitID.Text);
                    InstantObject._Felid_Disase_Visit.PatientID = Convert.ToInt32(Cmb_FullName.SelectedValue);
                    InstantObject._Felid_Disase_Visit.DiseaseID = Convert.ToInt32(Cmb_Disase.SelectedValue);
                    InstantObject._SP_DisaseVisit.SP_UPdate_Diasase_Patient_AndVisit(InstantObject._Felid_Disase_Visit);
                    Fill_DGV_DisasaeVisit();
                    Fill_CmbDisases();
                    //  InstantObject.ThLoading.Abort_Loading();

                }
                catch (Exception ex)
                {
                    //   InstantObject.ThLoading.Abort_Loading();
                    MessageBox.Show(ex.Message);
                }


            }
        }



        private void TS_BAckToMAin_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void DGV_VIST_ALL_DoubleClick(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            List<int> list1 = new List<int>();
            try
            {
                if (DGV_VIST_ALL.Rows.Count > 0)
                {
                    //InstantObject.ThLoading.Open_Loading();
                    int _RowIndex;
                    _RowIndex = DGV_VIST_ALL.CurrentCell.RowIndex;
                    int _CurrentRow = Convert.ToInt32(DGV_VIST_ALL[0, _RowIndex].Value);


                    InstantObject._Felid_Visit = InstantObject._SP_Visit.SP_Browes_VisitTB_By_ID_Felid(_CurrentRow);


                    txt_VisitID.Text = InstantObject._Felid_Visit.VisitID.ToString();
                    Cmb_FullName.ValueMember = "PatientID";
                    Cmb_FullName.DisplayMember = "FirstName";
                    Cmb_FullName.DataSource = InstantObject._SP_Patient.SP_Browes_Patient_FullName_By_ID(InstantObject._Felid_Visit.PatientID);
                    DPK_DataOfVisit.Value = Convert.ToDateTime(InstantObject._Felid_Visit.DataOfVisit);
                    Fill_CmbVisit();
                    string NameOfVisitType = Convert.ToString(DGV_VIST_ALL[5, _RowIndex].Value);

                    Cmb_VisitTypeID.Text = NameOfVisitType;
                    txt_Weight.Text = InstantObject._Felid_Visit.Weight.ToString();
                    txt_BloodPressure.Text = InstantObject._Felid_Visit.BloodPressure.ToString();
                    txt_PulseHeart.Text = InstantObject._Felid_Visit.PulseHeart.ToString();
                    txt_Temperature.Text = InstantObject._Felid_Visit.Temperature.ToString();
                    txt_PhysicalExamination.Text = InstantObject._Felid_Visit.PhysicalExamination.ToString();

                    txt_Note.Text = InstantObject._Felid_Visit.Note.ToString();
                    
                    // InstantObject.ThLoading.Abort_Loading();

                    list = InstantObject._SP_Visit_Stamp.SP_Browes_Stamp_Visit_ByPatient_Visit(Convert.ToInt32(txt_VisitID.Text), Convert.ToInt32(Cmb_FullName.SelectedValue));

                    
                    //here this code to check every Visit to own
                    if (_CurrentRow != -1)
                    {
                        ClearClB();
                    }


                    Fill_CLB_Accident();
                    Fill_CLB_Stamp();
                    TS_Show_Stamp_Checked.Text = "اظهار العلامات المختاره";
                    TS_Accident_Checked.Text = "اظهار الاعراض المختارة";
                    for (int ii = 0; ii < CLB_Stamp.Items.Count; ii++)
                    {
                        
                        DataRowView drv = (DataRowView)CLB_Stamp.Items[ii];



                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i].ToString() == drv[CLB_Stamp.ValueMember.ToString()].ToString())
                            {
                                CLB_Stamp.SetItemCheckState(ii, CheckState.Checked);
                            }
                        }
                    }
                    list1 = InstantObject._SP_Visit_Accident.SP_Browes_Accident_Visit_ByPatient_Visit(Convert.ToInt32(txt_VisitID.Text), Convert.ToInt32(Cmb_FullName.SelectedValue));
                    for (int j = 0; j <CLB_Accident.Items.Count; j++)
                    {
                        DataRowView drv1 = (DataRowView)CLB_Accident.Items[j];
                        for (int jj = 0; jj < list1.Count; jj++)
                        {
                            if (list1[jj].ToString() == drv1[CLB_Accident.ValueMember.ToString()].ToString())
                            {
                                CLB_Accident.SetItemCheckState(j, CheckState.Checked);
                            }
                        }
                    }
                    GB_Out.Visible = true;
                    Fill_DGV_DisasaeVisit();
                }
               
            }
            catch { };
            
        }

        private void DGV_Diseaes_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (DGV_Diseaes.Rows.Count > 0)
                {
                    // InstantObject.ThLoading.Open_Loading();
                    int _RowIndex;
                    _RowIndex = DGV_Diseaes.CurrentCell.RowIndex;
                    int _CurrentRow = Convert.ToInt32(DGV_Diseaes[0, _RowIndex].Value);

                    InstantObject._Felid_Disase_Visit = InstantObject._SP_DisaseVisit.SP_Brows_Disise_Visit_Felid(_CurrentRow);
                    Fill_CmbDisases();
                    string NameOfDisase = Convert.ToString(DGV_Diseaes[1, _RowIndex].Value);

                    Cmb_Disase.Text = NameOfDisase;
                    // InstantObject.ThLoading.Abort_Loading();
                }
            }
            catch { };
        }

        private void TS_Empty_Click(object sender, EventArgs e)
        {
            Clear_Tools();
            Fill_CmbPatientFull();
            Fill_CmbVisit();
            GB_Out.Visible = false;

        }



        private void txt_Weight_KeyPress(object sender, KeyPressEventArgs e)
        {
            InstantObject.KeyPress(e);
        }

        

        private void TS_Show_Stamp_Checked_Click(object sender, EventArgs e)
        {
            try
            {
                if (TS_Show_Stamp_Checked.Text == "اظهار العلامات المختاره")
                {
                    for (int i = 0; i < CLB_Stamp.Items.Count; i++)
                    {
                        DataRowView dr = (DataRowView)CLB_Stamp.Items[i];
                        if (CLB_Stamp.GetItemChecked(i) == false)
                        {
                            dr.Delete();
                        }


                    }

                    for (int i = 0; i < CLB_Stamp.Items.Count; i++)
                    {
                        CLB_Stamp.SetItemCheckState(i, CheckState.Checked);
                    }
                    TS_Show_Stamp_Checked.Text = "اظهار الكل";
                }
                else
                {
                    List<int> list;
                    Fill_CLB_Stamp();
                    list = InstantObject._SP_Visit_Stamp.SP_Browes_Stamp_Visit_ByPatient_Visit(Convert.ToInt32(txt_VisitID.Text), Convert.ToInt32(Cmb_FullName.SelectedValue));
                    for (int ii = 0; ii < CLB_Stamp.Items.Count; ii++)
                    {

                        DataRowView drv = (DataRowView)CLB_Stamp.Items[ii];



                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i].ToString() == drv[CLB_Stamp.ValueMember.ToString()].ToString())
                            {
                                CLB_Stamp.SetItemCheckState(ii, CheckState.Checked);
                            }
                        }
                    }
                    TS_Show_Stamp_Checked.Text = "اظهار العلامات المختاره";

                }
            }
            catch { }
            
        }

        private void TS_Accident_Checked_Click(object sender, EventArgs e)
        {
            try
            {
                if (TS_Accident_Checked.Text == "اظهار الاعراض المختاره")
                {
                    for (int i = 0; i < CLB_Accident.Items.Count; i++)
                    {
                        DataRowView dr = (DataRowView)CLB_Accident.Items[i];
                        if (CLB_Accident.GetItemChecked(i) == false)
                        {
                            dr.Delete();
                        }


                    }

                    for (int i = 0; i < CLB_Accident.Items.Count; i++)
                    {
                        CLB_Accident.SetItemCheckState(i, CheckState.Checked);
                    }
                    TS_Accident_Checked.Text = "اظهار الكل";
                }
                else
                {
                    List<int> list;
                    Fill_CLB_Accident();
                    list = InstantObject._SP_Visit_Accident.SP_Browes_Accident_Visit_ByPatient_Visit(Convert.ToInt32(txt_VisitID.Text), Convert.ToInt32(Cmb_FullName.SelectedValue));
                    for (int ii = 0; ii < CLB_Accident.Items.Count; ii++)
                    {

                        DataRowView drv = (DataRowView)CLB_Accident.Items[ii];



                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i].ToString() == drv[CLB_Accident.ValueMember.ToString()].ToString())
                            {
                                CLB_Accident.SetItemCheckState(ii, CheckState.Checked);
                            }
                        }
                    }
                    TS_Accident_Checked.Text = "اظهار الاعراض المختاره";

                }
            }
            catch { }
        }
    }
}