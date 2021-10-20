<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AddAndDeleteAppointment.ascx.cs" Inherits="AddAndDeleteAppointment" %>
<style type="text/css">
    .style2
    {
        height: 55px;
    }
    .style3
    {
        width: 277px;
        height: 52px;
    }
    .style4
    {
    }
    .style5
    {
        width: 277px;
        height: 46px;
        position: relative;
        float: right;
    }
    .style6
    {
        width: 277px;
        height: 285px;
    }
    #Select1
    {
        width: 117px;
    }
    .style7
    {
        width: 277px;
        height: 63px;
    }
</style>
<p style="direction: rtl">
    <asp:Button ID="btn_Save" runat="server" onclick="btn_Save_Click" 
        Text="حجز موعد" Width="258px" />
    <table style="width: 100%; height: 494px;" >
        <tr>
            <td colspan="2" class="style2">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Medium" 
                    ForeColor="#0066FF" Text="بيانات اضافة الموعد"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
        </tr>
        <tr>
            <td class="style5">
                &nbsp;<asp:Label ID="lbl_NamePatient" runat="server" Text="اسم المريض:"></asp:Label>
            &nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtPatientName" runat="server" Width="130px"></asp:TextBox>
            </td>
            <td class="style4" rowspan="4" align="center">
                <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="#0066FF" 
                    Text="تم اضافة موعدك بنجاح " Visible="False"></asp:Label>
                <br />
                <asp:Label ID="lblIDAppo" runat="server"></asp:Label>
                <br />
                <asp:Label ID="lblShowdate" runat="server" Visible="False"></asp:Label>
                <br />
                <br />
                <asp:Label ID="lbl_Thnx" runat="server" Text="نرجو ا ال" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;&nbsp;
                <asp:Label ID="lblvisitType" runat="server" Text="نوع الزياره:"></asp:Label>
&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="DropDownListVisit" runat="server" Height="35px" 
                    Width="135px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style7">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblTime" runat="server" Text="الوقت:"></asp:Label>
&nbsp;&nbsp; &nbsp;
                <asp:DropDownList ID="DropDownListVisitTime" runat="server" Height="34px" 
                    Width="135px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style6">
                <asp:Label ID="lbl_Data" runat="server" Text="التاريخ:"></asp:Label>
                <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#3366CC" 
                    BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" 
                    Font-Size="8pt" ForeColor="#003399" Height="200px" Width="247px">
                    <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                    <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                    <WeekendDayStyle BackColor="#CCCCFF" />
                    <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                    <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                    <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" 
                        Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                </asp:Calendar>
            </td>
        </tr>
    </table>
</p>
