<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BrowesPaientInfo.ascx.cs"
    Inherits="BrowesPaientInfo" %>
<style type="text/css">
    .style1
    {
        height: 293px;
    }
    .style3
    {
        height: 48px;
        width: 274px;
    }
    .style5
    {
        height: 48px;
    }
</style>
<table style="border: medium outset #3399FF; width: 100%;" dir="rtl">
    <tr>
        <td class="style3" align="center">
            &nbsp;<asp:Panel ID="Panel1" runat="server" Height="73px" Width="177px" 
                Font-Bold="True" ForeColor="#3399FF" >
                <asp:RadioButton ID="RbtnID" runat="server" Text="رقم المريض" 
                    oncheckedchanged="RbtnID_CheckedChanged" />
                <br />
                <asp:RadioButton ID="RbtnFirstName" runat="server" Text="الاسم الاول" 
                    oncheckedchanged="RbtnFirstName_CheckedChanged" />
                <br />
                <asp:RadioButton ID="RbtnLastName" runat="server"  Text="الاسم الاخير" 
                    oncheckedchanged="RbtnLastName_CheckedChanged"/>
            </asp:Panel>
&nbsp;&nbsp;
        </td>
        <td class="style5" align="center" >
        <br />
            <asp:Button ID="Button1" runat="server" BorderColor="#3399FF" BorderStyle="Outset"
                Height="34px" Text="بحث" Width="148px" OnClick="Button1_Click" 
                Font-Bold="True" Font-Size="Medium" ForeColor="#3399FF" />
                &nbsp;
                &nbsp;
                &nbsp;
                &nbsp;
                
                 <asp:Label ID="Label1" runat="server" Text="اسم المريض" Font-Bold="True" ForeColor="#3399FF"></asp:Label>
                 
                  &nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Height="21px"></asp:TextBox>
           
            &nbsp;
        </td>
    </tr>
    <tr>
        <td class="style1" colspan="2" align="center">
            &nbsp;<asp:Label ID="Label2" runat="server" Text="Label" Visible="False"></asp:Label>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True"
                AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                GridLines="None" Height="238px">
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <Columns>
                    <asp:BoundField DataField="PatientID" HeaderText="رقم المريض" />
                    <asp:BoundField DataField="FirstName" HeaderText="الاسم الاول" />
                    <asp:BoundField DataField="LastName" HeaderText="الاسم الاخير" />
                    <asp:BoundField DataField="DataOfRegister" HeaderText="تاريخ التسجيل" />
                    <asp:BoundField DataField="DataOFBirth" HeaderText="DataOFBirth" Visible="False" />
                    <asp:BoundField DataField="SexID" HeaderText="SexID" Visible="False" />
                    <asp:BoundField DataField="BloodID" HeaderText="BloodID" Visible="False" />
                    <asp:BoundField DataField="SocialStateID" HeaderText="SocialStateID" Visible="False" />
                    <asp:BoundField DataField="ChidNo" HeaderText="ChidNo" Visible="False" />
                    <asp:BoundField DataField="Job" HeaderText="العمل" />
                    <asp:BoundField DataField="AddressHome" HeaderText="AddressHome" Visible="False" />
                    <asp:BoundField DataField="AddressWork" HeaderText="AddressWork" Visible="False" />
                    <asp:BoundField DataField="Email" HeaderText="البريد الالكتروني" />
                    <asp:BoundField DataField="Tel" HeaderText="الهاتف" />
                    <asp:BoundField DataField="Mobile" HeaderText="الموبايل" />
                    <asp:BoundField DataField="TelWork" HeaderText="TelWork" Visible="False" />
                    <asp:CheckBoxField DataField="Smoke" HeaderText="Smoke" Visible="False" />
                    <asp:CheckBoxField DataField="Win" HeaderText="Win" Visible="False" />
                    <asp:BoundField DataField="Sensitive" HeaderText="Sensitive" Visible="False" />
                    <asp:BoundField DataField="Note" HeaderText="الملاحظات" />
                    <asp:BoundField DataField="ImagePath" HeaderText="ImagePath" Visible="False" />
                </Columns>
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <EditRowStyle BackColor="#999999" />
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            </asp:GridView>
            &nbsp;&nbsp;&nbsp; &nbsp; &nbsp;
        </td>
    </tr>
</table>
