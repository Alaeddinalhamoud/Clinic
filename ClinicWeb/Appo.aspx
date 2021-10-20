<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Appo.aspx.cs" Inherits="Appo" Title="Untitled Page" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

  
        <table class="style1" dir ="rtl" >
            <tr>
                <td class="style2" align="center" style="border: medium outset #3399FF"  >
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="?UC=BrowesAllAppointment" Font-Bold="true" >عرض جميع المواعيد</asp:HyperLink>
                </td>
                <td rowspan="6" style="border-style: outset; border-width: medium" runat="server" id="Add_User_Here" align="center" >
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2" align="center" style="border: medium outset #3399FF">
                    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="?UC2=AppointmentControl" Font-Bold="true">التحكم بأوقات المواعيد</asp:HyperLink>
                </td >
            </tr>
            <tr>
                <td  class="style2" align="center" style="border: medium outset #3399FF">
                    <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="?UC3=AddAndDeleteAppointment" Font-Bold="true">حجز موعد</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td class="style2" align="center" style="border: medium outset #3399FF">
                    <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="?UC4=DeleteAllAppointment" Font-Bold="true">الغاء كافة المواعيد</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td class="style2" align="center" style="border: medium outset #3399FF">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2" align="center" style="border: medium outset #3399FF">
                    &nbsp;</td>
            </tr>
        </table>


</asp:Content>

<asp:Content ID="Content3" runat="server" contentplaceholderid="head">

    <style type="text/css">
        .style1
        {
            width: 100%;
            border-style: solid;
            border-width: 3px;
        }
        .style2
        {
            width: 142px;
        }
    </style>

</asp:Content>


