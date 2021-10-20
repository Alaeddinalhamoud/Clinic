<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BrowesAllAppointment.ascx.cs" Inherits="BrowesAllAppointment" %>
<style type="text/css">
    .style1
    {
        width: 100%;
        height: 365px;
    }
    .style4
    {
        width: 797px;
        height: 245px;
    }
    .style5
    {
        width: 797px;
        height: 37px;
    }
</style>
<table class="style1" style="border: medium outset #3399FF" dir="rtl">
    <tr>
       
             
           
         
          <td class="style5" align="center" style="border: medium outset #3399FF" >
            <asp:Button ID="Button1" runat="server" Text="عرض" BorderStyle="Outset" 
                 Font-Bold="True" ForeColor="#3399FF" Height="32px" style="margin-right: 76px" 
                 Width="115px" onclick="Button1_Click" />
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:Label ID="Label1" runat="server" Height="25px" Text="تاريخ المواعيد" 
                 Width="84px" Font-Bold="True" ForeColor="#3399FF"></asp:Label>
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                  
                 
                 
                 <asp:TextBox ID="TextBox1" runat="server" Height="28px"></asp:TextBox>
                 
                 
                 <br />
                 </td>
                 

             
     
    </tr>
    <tr>
        <td  class="style4" align="center" >
        
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                AllowPaging="True" CellPadding="4" Font-Bold="True" ForeColor="#333333" 
                GridLines="None" Width="613px" Height="16px">
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <Columns>
                    <asp:BoundField DataField="AppointmentID" HeaderText="رقم الموعد" />
                    <asp:BoundField DataField="PatientName" HeaderText="اسم المريض" />
                    <asp:BoundField DataField="Date" HeaderText="التاريخ" />
                    <asp:BoundField DataField="Time" HeaderText="الوقت" />
                    <asp:BoundField DataField="VisitTypeID" HeaderText="VisitTypeID" 
                        Visible="False" />
                    <asp:BoundField DataField="VisitType" HeaderText="نوع الزيارة" />
                    <asp:BoundField DataField="Note" HeaderText="ملاحظات" />
                </Columns>
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <EditRowStyle BackColor="#999999" />
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            </asp:GridView>
        </td>
    </tr>
</table>
