<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UserControlC.ascx.cs" Inherits="UserControlC" %>
<table style="border-style: double; border-color: #0000FF; width: 100%;">
    <tr>
        <td align="center" class="style14">
            &nbsp;
            <asp:Label ID="lbl_DRName" runat="server" Text="اسم الطبيب" Font-Bold="true"></asp:Label>
        </td>
        <td align="right">
            <asp:TextBox ID="txt_DrName" runat="server" style="margin-bottom: 0px" 
                Width="305px"></asp:TextBox>
            &nbsp;
        </td>
    </tr>
    <tr>
        <td align="center" class="style14">
            <asp:Label ID="lbl_DRName0" runat="server" Text="الاختصاص" Font-Bold="true"></asp:Label>
        </td>
        <td align="right">
        <asp:TextBox ID="txt_Despcription" runat="server" style="margin-bottom: 0px" 
                Width="305px"></asp:TextBox>
            &nbsp;</td>
    </tr>
    <tr>
        <td align="center" class="style14">
            <asp:Label ID="lbl_DRName1" runat="server" Text="الهاتف" Font-Bold="true"></asp:Label>
        </td>
        <td align="right">
        <asp:TextBox ID="txt_Tel" runat="server" style="margin-bottom: 0px" 
                Width="305px"></asp:TextBox>
            &nbsp;</td>
    </tr>
    <tr>
        <td align="center" class="style14">
            <asp:Label ID="lbl_DRName2" runat="server" Text="رقم الموبايل" Font-Bold="true"></asp:Label>
        </td>
        <td align="right">
        <asp:TextBox ID="txt_Mobil" runat="server" style="margin-bottom: 0px" 
                Width="305px"></asp:TextBox>
            &nbsp;</td>
    </tr>
    <tr>
        <td align="center" class="style14">
            <asp:Label ID="lbl_DRName3" runat="server" Text="فاكس" Font-Bold="true"></asp:Label>
        </td>
        <td align="right">
        <asp:TextBox ID="txt_Fax" runat="server" style="margin-bottom: 0px" 
                Width="305px"></asp:TextBox>
            &nbsp;</td>
    </tr>
    <tr>
        <td align="center" class="style14">
            <asp:Label ID="lbl_DRName4" runat="server" Text="البريد الالكتروني" Font-Bold="true"></asp:Label>
        </td>
        <td align="right">
        <asp:TextBox ID="txt_Email" runat="server" style="margin-bottom: 0px" 
                Width="305px"></asp:TextBox>
            &nbsp;</td>
    </tr>
    <tr>
        <td align="center" >
            <asp:Label ID="lbl_DRName5" runat="server" Text="الموقع الالكترني" Font-Bold="true"></asp:Label>
        </td>
        <td align="right">
        <asp:TextBox ID="txt_WebSite" runat="server" style="margin-bottom: 0px" 
                Width="305px"></asp:TextBox>
            &nbsp;</td>
    </tr>
    <tr>
        <td align="center" >
            <asp:Label ID="lbl_DRName6" runat="server" Text="المدينة" Font-Bold="true"></asp:Label>
        </td>
        <td align="right">
        <asp:TextBox ID="txt_City" runat="server" style="margin-bottom: 0px" 
                Width="305px" ></asp:TextBox>
            &nbsp;</td>
    </tr>
    <tr>
        <td align="center" >
            &nbsp;<asp:Label ID="lbl_DRName7" runat="server" Text="العنوان" 
                Font-Bold="true"></asp:Label>
        &nbsp;</td>
        
        <td align="right">
        <asp:TextBox ID="txt_Adress" runat="server" style="margin-right: 0px" 
                Width="305px"></asp:TextBox>
            &nbsp;
        </td>
    </tr>
    
    <tr>
        <td align="center" colspan="2">
            <asp:Button ID="btn_Update" runat="server" BorderStyle="Double" 
                Font-Bold="True" Font-Size="Medium" ForeColor="#0066FF" 
                onclick="btn_Update_Click" Text="تعديل" Width="108px" />
        </td>
        
    </tr>
    
</table>