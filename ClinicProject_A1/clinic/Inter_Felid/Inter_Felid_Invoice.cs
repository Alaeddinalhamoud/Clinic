using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib_Felid;
using System.Data;

namespace Inter_Felid
{
  public interface Inter_Felid_Invoice
    {
      List<Felid_Invoice> SP_Browes_Invioce_All();
      Felid_Invoice SP_Browes_Invioce_By_PatientID_Felid(int ID);
      Felid_Invoice SP_Browes_Invoic_By_ID_Felid(int InvoicID);
      int SP_Insert_Invoice(Felid_Invoice Felid);
      int SP_UpDate_Invoice(Felid_Invoice  Felid);
      int SP_Delete_Invoice(int ID);
      List<Felid_Invoice> SP_Browes_InVoiceID_By_PatientID(int ID);
      DataTable SP_Brows_Invoic_By_Invoice_Report(int InvoiceID);
      DataTable SP_Brows_Invoice_Datials();
      DataTable SP_Brows_Invoice_Detials_By_PatientID(int ID);
      DataTable SP_Browes_Invoice_ReprtByPatientID(int PatientID);
      DataTable SP_Browes_Invoice_ReportMonth(DateTime From, DateTime To);

     
    }
}
