<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PatientVisits.ascx.cs"
    Inherits="PatientVisits" %>

<table class="style1" dir="rtl" runat="server" style="margin-right: 0px">
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
            <asp:TextBox ID="TextBox1" runat="server" Width="224px" Height="29px"></asp:TextBox>
                
        </td>
    </tr>
    <tr>
        <td align="center" class="style2" 
            style="border-style: outset; border-width: medium">
            <asp:GridView ID="GridView1" runat="server" Width="664px" 
                AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                GridLines="None" AllowPaging="True" AllowSorting="True" 
                style="margin-right: 0px">
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <Columns>
                    <asp:BoundField DataField="VisitID" HeaderText="رقم الزيارة" />
                    <asp:BoundField DataField="PatientID" HeaderText="رقم المريض" Visible="False" />
                    <asp:BoundField DataField="FirstName" HeaderText="اسم المريض" />
                    <asp:BoundField DataField="DataOfVisit" HeaderText="تاريخ الزيارة" 
                        SortExpression="DataOfVisit" />
                    <asp:BoundField DataField="VisitTypeID" HeaderText="رقم نوع الزيارة" 
                        Visible="False" />
                    <asp:BoundField DataField="VisitType" HeaderText="نوع الزيارة" />
                    <asp:BoundField DataField="Weight" HeaderText="الوزن" />
                    <asp:BoundField DataField="BloodPressure" HeaderText="ضغط الدم" />
                    <asp:BoundField DataField="PulseHeart" HeaderText="نبضات القلب" />
                    <asp:BoundField DataField="Temperature" HeaderText="درجة الحرارة" />
                    <asp:BoundField DataField="PhysicalExamination" HeaderText="الفحص الفيزيائي" />
                    <asp:BoundField DataField="BedExamination" HeaderText="الفحص السريري" />
                    <asp:BoundField DataField="Note" HeaderText="الملاحظات" />
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
