<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DeleteAllAppointment.ascx.cs"
    Inherits="DeleteAllAppointment" %>
<style type="text/css">
    .style1
    {
        width: 994px;
    }
</style>

    <table style="height: 155px; width: 824px" dir="ltr">
        <tr>
            <td colspan="2" align="center">
                <asp:Label ID="Label2" runat="server" Height="22px" Text="Label" Width="145px" Visible="false" ></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="right"class="style1" >
                <asp:TextBox ID="TextBox1" runat="server" Style="margin-left: 0px" 
                    Width="192px" Height="28px"></asp:TextBox>
            </td>
            <td align="center">
                <asp:Label ID="Label1" runat="server" Height="22px" 
                    Text="الغاء المواعيد التي بتاريخ " Width="145px" ForeColor="#3399FF"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center" >
                <asp:Button ID="Button1" runat="server" Text="الغاء" Width="93px"   
                    ForeColor="#3399FF" Font-Bold="true" onclick="Button1_Click" />
            </td>
        </tr>
    </table>

