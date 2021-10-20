<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="AdminPage.aspx.cs" Inherits="AdminPage" %>

<%@ Register assembly="SIAHEWebControl" namespace="ShWebControl" tagprefix="shw" %>

<%@ Register assembly="Web.YUI" namespace="Web.YUI" tagprefix="cc1" %>

<asp:Content ID="contact2" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
   
    
    <table class="style16" dir="rtl">
        <tr>
            <td class="style17" style="border: medium outset #3399FF">
                <table class="style16" 
                    style="border: medium double #0000FF; color:Blue ; font-size: medium">
                    <tr>
                        <td class="style21" align="center" 
                            style="border-style: outset; border-width: medium">
                         
                            <asp:HyperLink ID="HyperLink1" runat="server" 
                                NavigateUrl="?UC=BrowesPatientInfo" Font-Bold="True">عرض معلومات المرضى</asp:HyperLink>
                         
                        </td>
                    </tr>
                    <tr>
                        <td class="style21" align="center" 
                            style="border-style: outset; border-width: medium">
                         
                            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="?UC1=UserControlC" 
                                Font-Bold="True">  معلومات الطبيب</asp:HyperLink>
                        </td>
                    </tr>
                    <tr>
                        <td class="style21" align="center" 
                            style="border-style: outset; border-width: medium">
                         
                            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="?UC2=BrowesPaientInfo" Font-Bold="true">بحث عن مريض</asp:HyperLink>
                        </td>
                    </tr>
                    <tr>
                        <td class="style21" align="center" 
                            style="border-style: outset; border-width: medium">
                         
                            <asp:HyperLink ID="HyperLink4" runat="server"  NavigateUrl="?UC3=SendEmailToPaient" Font-Bold="true">ارسال رسالة لمريض</asp:HyperLink>
                        </td>
                    </tr>
                    <tr>
                        <td class="style21">
                         
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style21">
                         
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style21">
                         
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style21">
                         
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style21">
                         
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style23">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style22">
                           
                        </td>
                    </tr>
                </table>
            </td>
            <td class="style18">
                <table align="center" class="style19">
                    <tr>
                        <td class="style20" runat ="server" id="Add_Uc_Here"  dir="rtl">
                        
                            <asp:Panel ID="Panel1" runat="server" Height="509px" ScrollBars="Both" 
                                Width="856px">
                            </asp:Panel>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
   
    
</asp:Content>


<asp:Content ID="Content1" runat="server" contentplaceholderid="head">

    <style type="text/css">
        .style16
        {
            width: 100%;
            height: 540px;
        }
        .style17
        {
            width: 159px;
            height: 583px;
        }
        .style18
        {
            height: 583px;
        }
        .style19
        {
            width: 100%;
            border: 3px solid #0000FF;
        }
        .style20
        {
            height: 544px;
        }
        .style21
        {
            height: 20px;
            width: 167px;
        }
        .style22
        {
            height: 313px;
            width: 167px;
        }
        .style23
        {
            width: 167px;
        }
    </style>

</asp:Content>



