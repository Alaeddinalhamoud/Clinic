<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BrowesPatientInfo.ascx.cs" Inherits="BrowesPatientInfo" %>



<asp:GridView ID="GridView2" runat="server" AllowPaging="True" 
    AutoGenerateColumns="False" CellPadding="4" DataSourceID="ObjectDataSource1" 
    ForeColor="#333333" GridLines="None" class="style20">
    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
    <Columns>
        <asp:BoundField DataField="PatientID" HeaderText="رقم المريض" 
            SortExpression="PatientID" />
        <asp:BoundField DataField="FirstName" HeaderText="الاسم الاول" 
            SortExpression="FirstName" />
        <asp:BoundField DataField="LastName" HeaderText="الاسم الاخير" 
            SortExpression="LastName" />
        <asp:BoundField DataField="DataOfRegister" HeaderText="تاريخ التسجيل" 
            SortExpression="DataOfRegister" />
        <asp:BoundField DataField="DataOFBirth" HeaderText="DataOFBirth" 
            SortExpression="DataOFBirth" Visible="False" />
        <asp:BoundField DataField="SexID" HeaderText="SexID" SortExpression="SexID" 
            Visible="False" />
        <asp:BoundField DataField="BloodID" HeaderText="BloodID" 
            SortExpression="BloodID" Visible="False" />
        <asp:BoundField DataField="SocialStateID" HeaderText="SocialStateID" 
            SortExpression="SocialStateID" Visible="False" />
        <asp:BoundField DataField="ChidNo" HeaderText="ChidNo" SortExpression="ChidNo" 
            Visible="False" />
        <asp:BoundField DataField="Job" HeaderText="العمل" SortExpression="Job" />
        <asp:BoundField DataField="AddressHome" HeaderText="AddressHome" 
            SortExpression="AddressHome" Visible="False" />
        <asp:BoundField DataField="AddressWork" HeaderText="AddressWork" 
            SortExpression="AddressWork" Visible="False" />
        <asp:BoundField DataField="Email" HeaderText="البريد الالكتروني" 
            SortExpression="Email" />
        <asp:BoundField DataField="Tel" HeaderText="رقم الهاتف" SortExpression="Tel" />
        <asp:BoundField DataField="Mobile" HeaderText="رقم الموبايل" 
            SortExpression="Mobile" />
        <asp:BoundField DataField="TelWork" HeaderText="TelWork" 
            SortExpression="TelWork" Visible="False" />
        <asp:CheckBoxField DataField="Smoke" HeaderText="Smoke" SortExpression="Smoke" 
            Visible="False" />
        <asp:CheckBoxField DataField="Win" HeaderText="Win" SortExpression="Win" 
            Visible="False" />
        <asp:BoundField DataField="Sensitive" HeaderText="Sensitive" 
            SortExpression="Sensitive" Visible="False" />
        <asp:BoundField DataField="Note" HeaderText="ملاحظات" SortExpression="Note" />
        <asp:BoundField DataField="ImagePath" HeaderText="ImagePath" 
            SortExpression="ImagePath" Visible="False" />
    </Columns>
    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
    <EditRowStyle BackColor="#999999" />
    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
</asp:GridView>
<asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
    DeleteMethod="SP_Delete_Patient_By_PatientID" 
    SelectMethod="SP_Browes_Patient_All" TypeName="SP_Tables.SP_Patient">
    <DeleteParameters>
        <asp:Parameter Name="PatientID" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>






  
    
    









  
    
    



