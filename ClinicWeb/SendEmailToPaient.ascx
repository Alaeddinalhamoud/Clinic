<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SendEmailToPaient.ascx.cs" Inherits="SendEmailToPaient" %>
<style type="text/css">
    .style1
    {
    }
</style>
<table style="width: 81%; margin-left: 82px; height: 159px;" dir="ltr">
    <tr>
        <td class="style1" align="right">
            <asp:TextBox ID="TextBox1" runat="server" Width="530px" ></asp:TextBox>
        </td>
        <td align="center">
            <asp:Label ID="Label1" runat="server" Text="الرسالة من"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="style1" align="right" >
            <asp:TextBox ID="TextBox2" runat="server" Width="530px"></asp:TextBox>
        </td>
        <td align="center" >
            <asp:Label ID="Label2" runat="server" Text="الرسالة الى"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="style1" align="right" >
            <asp:TextBox ID="TextBox3" runat="server" Width="530px"></asp:TextBox>
        </td>
        <td align="center" >
            <asp:Label ID="Label3" runat="server" Text="الموضوع"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="style1" align="right" >
            &nbsp;</td>
        <td align="center" >
            <asp:Button ID="Button1" runat="server" Text="ارسال" Font-Bold="True" 
                ForeColor="#3399FF" Width="81px" onclick="Button1_Click" />
        </td>
    </tr>
    <tr>
        <td class="style1" align="center"  colspan="2" >
            <asp:TextBox ID="TextBox4" runat="server" style="margin-left: 0px" 
                Height="28px" Width="688px"></asp:TextBox>
        </td>
    </tr>
    </table>
