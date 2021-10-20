using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clinic.Report_Form;

namespace clinic.Invoice
{
    public partial class FrmMonthInvoice : Form
    {
        public FrmMonthInvoice()
        {
            InitializeComponent();
        }

        private void btn_Agree_Click(object sender, EventArgs e)
        {
            FrmReport Frm = new FrmReport();
            Frm.ReportInvoicebyMonth(Convert.ToDateTime(DPK_FormDate.Value),Convert.ToDateTime(DPK_TODate.Value));
            Frm.Show();
        }
    }
}
