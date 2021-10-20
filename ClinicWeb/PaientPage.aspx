<%@ Page Language="C#" MasterPageFile="~/MasterPage.master"  AutoEventWireup="true" CodeFile="PaientPage.aspx.cs" Inherits="PaientPage" %>

<asp:Content runat="server" ID="Contact3" ContentPlaceHolderID="ContentPlaceHolder1">
    <p>
        <br />
        <table class="style1" dir="ltr" 
            style="border-style: outset; border-width: medium">
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2" rowspan="7" runat="server" id="Add_User_Control">
                    &nbsp;</td>
                <td style="border-style: outset; border-width: medium" align="center" >
                    <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" 
                        ForeColor="#3399FF" NavigateUrl="?UC=PatientVisits">استعراض الزيارات </asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td style="border-style: outset; border-width: medium" align="center" >
                    <asp:HyperLink ID="HyperLink2" runat="server"  Font-Bold="True" ForeColor="#3399FF" NavigateUrl="?UC1=PerscreptionPatient">استعراض الوصفات</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td style="border-style: outset; border-width: medium" align="center">
                    <asp:HyperLink ID="HyperLink3" runat="server" Font-Bold="True" ForeColor="#3399FF" NavigateUrl="?UC2=PatientInvoice">الفاتورة</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td style="border-style: outset; border-width: medium">
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    </asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="head">

    <style type="text/css">
        .style1
        {
            width: 100%;
            margin-bottom: 9px;
        }
        .style2
        {
            width: 858px;
        }
    </style>

</asp:Content>

