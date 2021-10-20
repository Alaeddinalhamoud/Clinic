using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using Lib_Felid;

namespace clinic.FrmAccident
{
    public partial class FrmAccidentType : Form
    {
        public FrmAccidentType()
        {
            InitializeComponent();
        }

        SP_Accident _SP_Accident = new SP_Accident();


        Felid_Accident _Felid = new Felid_Accident();
        private void FrmAccidentType_Load(object sender, EventArgs e)
        {
            TS_Accident.Renderer = new Renderers.WindowsVistaRenderer();
            Fill_DGV();
        }

        private void Fill_DGV()
        {
            DGV_Accident.DataSource = _SP_Accident.SP_Browes_AccidentAll();
        }

        private void TSB_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TSB_Empty_Accident_Click(object sender, EventArgs e)
        {
            ClearTools();

        }

        private void ClearTools()
        {
            txt_AccidentID.Clear();
            txt_AccidentName.Clear();
            txt_Search.Clear();
        }

        private void TSB_Delete_Accident_Click(object sender, EventArgs e)
        {
            if (txt_AccidentID.Text == "")
            {
                MessageBox.Show("لم تقم باختيار العرض التي تريد حذفها", "تحذير", MessageBoxButtons.OK,
                                       MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("هل انت متأكد من عملية الحذف؟", "تحذير", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    _SP_Accident.SP_Delete_Accident(Convert.ToInt32(txt_AccidentID.Text));
                    Fill_DGV();
                    ClearTools();
                    MessageBox.Show("تمت عملية الحذف");
                }
            }
        }

        private void TSB_Add_Accident_Click(object sender, EventArgs e)
        {
            if (txt_AccidentName.Text == "")
            {
                MessageBox.Show("لم تقم بادخال العرض ", "تحذير", MessageBoxButtons.OK,
                                       MessageBoxIcon.Warning);
                txt_AccidentName.Focus();
            }
            else
            {
                try
                {
                    _Felid.AccidentName = txt_AccidentName.Text;
                    _SP_Accident.SP_Insert_Accident(_Felid);

                    ClearTools();
                    Fill_DGV();
                    MessageBox.Show("تمت عملية الاضافة");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void TSB_UpDate_Accident_Click(object sender, EventArgs e)
        {
            if (txt_AccidentID.Text == "")
            {
                MessageBox.Show("لم تقم باختيار العرض الذي تريد تعديله", "تحذير", MessageBoxButtons.OK,
                                       MessageBoxIcon.Warning);
            }
           else  if (txt_AccidentName.Text == "")
            {
                MessageBox.Show("لم تقم بادخال العرض ", "تحذير", MessageBoxButtons.OK,
                                       MessageBoxIcon.Warning);
                txt_AccidentName.Focus();
            }
            else
            {
                try
                {
                    _Felid.AccidentID = Convert.ToInt32(txt_AccidentID.Text);
                    _Felid.AccidentName = txt_AccidentName.Text;
                    _SP_Accident.SP_UpDate_Accident(_Felid);

                    ClearTools();
                    Fill_DGV();
                    MessageBox.Show("تمت عملية الاضافة");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (txt_Search.Text == "")
            {
                MessageBox.Show("ادخل اسم العرض", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_AccidentName.Focus();
            }
            else
            {
                try
                {
                  
                    _Felid = _SP_Accident.SP_Browes_Accident_ByName_Felid(txt_Search.Text);
                    txt_AccidentID.Text = _Felid.AccidentID.ToString();
                    txt_AccidentName.Text = _Felid.AccidentName;
                    txt_Search.Clear();
                }
                catch (Exception Ex) { MessageBox.Show(Ex.Message); }
            }
        }

        private void DGV_Accident_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (DGV_Accident.Rows.Count > 0)
                {
                    //Method For Fill Tools at Patient
                    int _RowIndex;
                    _RowIndex = DGV_Accident.CurrentCell.RowIndex;

                    object _CurrentRow = DGV_Accident[0, _RowIndex];


                    int _Value_Current_Row = Convert.ToInt32(DGV_Accident[0, _RowIndex].Value);

                   

                    _Felid = _SP_Accident.SP_Browes_Accident_ByID_Felid(_Value_Current_Row);
                    txt_AccidentID.Text = _Felid.AccidentID.ToString();
                    txt_AccidentName.Text = _Felid.AccidentName;
                }
            }
            catch (Exception Ex) { MessageBox.Show(Ex.Message); }
        }
    }
}
