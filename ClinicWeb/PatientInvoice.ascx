<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PatientInvoice.ascx.cs" Inherits="PatientInvoice" %>
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
        
          
                
        </td>
    </tr>
    <tr>
        <td align="center" class="style2" 
            style="border-style: outset; border-width: medium">
       
           
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" AllowPaging="true">
                <Columns>
                    <asp:BoundField DataField="InVoiceID" HeaderText="رقم الفاتورة" />
                    <asp:BoundField DataField="VisitID" HeaderText="رقم الزيارة" Visible="False" />
                    <asp:BoundField DataField="DataOfVisit" HeaderText="تاريخ الزيارة" />
                    <asp:BoundField DataField="PatientID" HeaderText="PatientID" Visible="False" />
                    <asp:BoundField DataField="FirstName" HeaderText="اسم المريض" />
                    <asp:BoundField DataField="PaidMoney" HeaderText="المبلغ المدفوع" />
                    <asp:BoundField DataField="Reminder" HeaderText="الباقي" />
                    <asp:BoundField DataField="Discount" HeaderText="الحسم" />
                    <asp:BoundField DataField="Total" HeaderText="المبلغ الكلي" />
                    <asp:BoundField DataField="DateInvoice" HeaderText="تاريخ الفاتورة" />
                </Columns>
            </asp:GridView>
       
           
        </td>
    </tr>
</table>
