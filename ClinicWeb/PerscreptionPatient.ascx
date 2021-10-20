<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PerscreptionPatient.ascx.cs" Inherits="PerscreptionPatient" %>

<table id="Table1" class="style1" dir="rtl" runat="server" style="margin-right: 0px">
    <tr>
        
        <td style="font-size: medium; font-weight: bold; color: #3399FF; border-style: ridge; border-width: medium" 
            width="1024px">
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            
            <asp:Button ID="Button1" runat="server" Text="استعراض" Width="136px" 
                Font-Bold="True" Font-Size="Medium" ForeColor="#3399FF" 
                onclick="Button1_Click" />
            &nbsp;
                &nbsp;
                &nbsp;
                &nbsp; &nbsp;
                &nbsp;
                &nbsp;
                &nbsp; &nbsp;
                &nbsp;
                &nbsp;
                &nbsp;
                &nbsp;
                &nbsp;
                &nbsp;
                &nbsp;
                &nbsp;
                &nbsp;
                <asp:Label ID="lblPaientID" runat="server" Text="رقم المريض" Height="30px"></asp:Label>
                &nbsp;
                &nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Width="98px" Height="29px"></asp:TextBox>
             &nbsp;
                &nbsp;
                 &nbsp;
                &nbsp;
            <asp:Label ID="Label1" runat="server" Text="اسم المريض" Height="30px" Visible="false"></asp:Label>
                
        </td>
    </tr>
    <tr>
        <td align="center" class="style2" 
            style="border-style: outset; border-width: medium">
       
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                AllowPaging="true" AllowSorting="true" Height="16px">
                <Columns>
                    <asp:BoundField DataField="PrescriptionID" HeaderText="رقم الوصفة" />
                    <asp:BoundField DataField="MedicationID" HeaderText="رقم الدواء" 
                        Visible="False" />
                    <asp:BoundField DataField="MedicationName" HeaderText="اسم الدواء" />
                    <asp:BoundField DataField="Dose" HeaderText="عدد الجرعات" />
                    <asp:BoundField DataField="MedicalCount" HeaderText="عدد العلب" />
                    <asp:BoundField DataField="Cleander_Of_Dose" HeaderText="موعد الدواء" />
                    <asp:BoundField DataField="Type_Of_Medication" HeaderText="شكل العلبة" />
                    <asp:BoundField HeaderText="وقت الدواء" />
                    <asp:BoundField DataField="Note" HeaderText="الملاحظات" />
                </Columns>
            </asp:GridView>
       
        </td>
    </tr>
</table>