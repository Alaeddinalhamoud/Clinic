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
using Microsoft.SqlServer.Management.Smo;

namespace clinic.FrmStamp
{
    public partial class FrmStamptype : Form
    {
        public FrmStamptype()
        {
            InitializeComponent();
        }
        SP_Stamp _SP_Stamp = new SP_Stamp();

        Felid_Stamp _Felid = new Felid_Stamp();
        private void TSB_Exit_Stamp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmStamptype_Load(object sender, EventArgs e)
        {
            TS_Stamp.Renderer = new Renderers.WindowsVistaRenderer();


            Fill_DGV();
        }

        private void Fill_DGV()
        {
            DGV_Stamp.DataSource = _SP_Stamp.SP_Browes_StampAll();
        }

        private void TSB_Delete_Stamp_Click(object sender, EventArgs e)
        {
            if (txt_StampID.Text == "")
            {
                MessageBox.Show("لم تقم باختيار العلامة التي تريد حذفها", "تحذير", MessageBoxButtons.OK,
                                       MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("هل انت متأكد من عملية الحذف؟", "تحذير", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    _SP_Stamp.SP_Delete_Stamp(Convert.ToInt32(txt_StampID.Text));
                    Tools_Empty();
                    Fill_DGV();
                    MessageBox.Show("تم الحذف");


                }
            }
        }

        private void Tools_Empty()
        {
            txt_StampID.Clear();
            txt_StampName.Clear();
        }

        private void TSB_Add_Stamp_Click(object sender, EventArgs e)
        {
            if (txt_StampName.Text == "")
            {
                MessageBox.Show("لم تقم بادخال العلامة ", "تحذير", MessageBoxButtons.OK,
                                       MessageBoxIcon.Warning);
                txt_StampName.Focus();
            }
            else
            {
                try
                {
                    _Felid.StampName = txt_StampName.Text;
                    _SP_Stamp.SP_Insert_Stamp(_Felid);
                    Tools_Empty();
                    Fill_DGV();
                    MessageBox.Show("تمت عملية الاضافة");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void TSB_Update_Stamp_Click(object sender, EventArgs e)
        {
            if (txt_StampID.Text == "")
            {
                MessageBox.Show("لم تقم باختيار العلامة التي تريد تعديها", "تحذير", MessageBoxButtons.OK,
                                                       MessageBoxIcon.Warning);
                txt_StampName.Focus();
            }
            else if (txt_StampName.Text == "")
            {
                MessageBox.Show("لم تقم بادخال العلامة ", "تحذير", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                txt_StampName.Focus();
            }
            else
            {
                try
                {
                    _Felid.StampID = Convert.ToInt32(txt_StampID.Text);
                    _Felid.StampName = txt_StampName.Text;
                    _SP_Stamp.SP_UpDate_Stamp(_Felid);
                    Tools_Empty();
                    Fill_DGV();
                    MessageBox.Show("تمت عملية التعديل");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DGV_Stamp_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (DGV_Stamp.Rows.Count > 0)
                {
                    //Method For Fill Tools at Patient
                    int _RowIndex;
                    _RowIndex = DGV_Stamp.CurrentCell.RowIndex;

                    object _CurrentRow = DGV_Stamp[0, _RowIndex];


                    int _Value_Current_Row = Convert.ToInt32(DGV_Stamp[0, _RowIndex].Value);

                    _Felid = _SP_Stamp.SP_Browse_Stamp_ByID(_Value_Current_Row);
                    txt_StampID.Text = _Felid.StampID.ToString();
                    txt_StampName.Text = _Felid.StampName;
                }
            }
            catch (Exception Ex) { MessageBox.Show(Ex.Message); }

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (txt_Search.Text == "")
            {
                MessageBox.Show("ادخل اسم العلامة", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    // Thread ThSearch = new Thread(Do_Search);
                    //ThSearch.Start();

                    _Felid = _SP_Stamp.SP_Browes_Stamp_By_Name_DataTale(txt_Search.Text);
                    txt_StampID.Text = _Felid.StampID.ToString();
                    txt_StampName.Text = _Felid.StampName;
                    txt_Search.Clear();
                }
                catch (Exception Ex) { MessageBox.Show(Ex.Message); }
            }
        }

        private void TSB_Empty_Click(object sender, EventArgs e)
        {
            txt_Search.Clear();
            txt_StampID.Clear();
            txt_StampName.Clear();
            txt_StampName.Focus();
        }

       
    }


}

