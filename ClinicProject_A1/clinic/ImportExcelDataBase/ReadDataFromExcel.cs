using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.ApplicationBlocks.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data.Common;

namespace ImportExcelDataBase
{
 public   class ReadDataFromExcel
    {

        public void ReadDataFromExcelIntoSqlServer(string FileName,string TableName,string FieldNameID,string FieldName)
        {
            try{
            // Connection String to Excel Workbook
                string excelConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + FileName + ";Extended Properties=Excel 8.0";
//@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Book1.xls;Extended Properties=""Excel 8.0;HDR=YES;""";

            


            // Create Connection to Excel Workbook
            OleDbConnection connection = new OleDbConnection(excelConnectionString);

            OleDbCommand command = new OleDbCommand("Select " + FieldNameID + "," + FieldName + " FROM [Sheet1$]", connection);

                connection.Open();

                // Create DbDataReader to Data Worksheet
                DbDataReader dr = command.ExecuteReader();
                
                    // SQL Server Connection String
                  

                    // Bulk Copy to SQL Server
                   SqlBulkCopy bulkCopy = new SqlBulkCopy(SqlHelper.ConnStr);
                    
                        bulkCopy.DestinationTableName = TableName;
                        bulkCopy.WriteToServer(dr);
            }catch(Exception ex)
            {throw ex;}
                    
                }


        public void ReadDataFromExcelMedicationIntoSqlServer(string FileName, string TableName, string MedicationID
                                                                                 , string MedicationName
                                                                                 , string Company
                                                                                 , string GroupOfRemedial
                                                                                 , string Classification
                                                                                 , string Page
                                                                                 , string MedicalOfConsultation
                                                                                 , string AntiOfMedical_Consultation
                                                                                 , string Warning
                                                                                 , string OverlapOfMedication
                                                                                 , string SideOfEffect)
        {

       try{
            // Connection String to Excel Workbook
                string excelConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + FileName + ";Extended Properties=Excel 8.0";
//@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Book1.xls;Extended Properties=""Excel 8.0;HDR=YES;""";

            


            // Create Connection to Excel Workbook
            OleDbConnection connection = new OleDbConnection(excelConnectionString);

            OleDbCommand command = new OleDbCommand("Select " + MedicationID + "," + MedicationName + "," + Company + "," + GroupOfRemedial + "," + Classification + "," + Page + "," + MedicalOfConsultation + "," + AntiOfMedical_Consultation + "," + Warning + "," + OverlapOfMedication + "," + SideOfEffect + " FROM [Sheet1$]", connection);

                connection.Open();

                // Create DbDataReader to Data Worksheet
                DbDataReader dr = command.ExecuteReader();
                
                    // SQL Server Connection String
                  

                    // Bulk Copy to SQL Server
                   SqlBulkCopy bulkCopy = new SqlBulkCopy(SqlHelper.ConnStr);
                    
                        bulkCopy.DestinationTableName = TableName;
                        bulkCopy.WriteToServer(dr);
            }catch(Exception ex)
            {throw ex;}
                    
                }



        }

        }

   

