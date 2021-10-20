<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="conect1" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <table dir= "rtl" >
        <tr>
            <td style="border: medium outset #3399FF; margin-right: 160px" class="style16">
                <asp:Panel ID="Panel1" runat="server" Height="178px" Width="225px" Direction="RightToLeft"
                    >
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                    <asp:CheckBox ID="CheckBox1" runat="server" Font-Bold="True" 
                        Text="تسجيل الدخول كمريض" TextAlign="Left" />
                    <asp:Login ID="Login1" runat="server" PasswordLabelText="كلمة المرور:" TitleText="تسجيل الدخول"
                        UserNameLabelText="اسم المستخدم:" LoginButtonText="تسجيل الدخول" RememberMeText="تذكر معلوماتي على هذا الجهاز"
                        
                        OnAuthenticate="Login1_Authenticate1" FailureText="تسجيل الدخول لم يتم بشكل صحيح ,اعد التسجيل مرة اخرى"
                        PasswordRequiredErrorMessage="يجب ادخال كلمة المرور" UserNameRequiredErrorMessage="يجب ادخال اسم المستخدم"
                        Height="159px" Width="267px">
                        
                        <LoginButtonStyle BorderStyle="Double" />
                    </asp:Login>
                </asp:Panel>
            </td>
            <td runat="server" id="Add_UC_H" class="style14" rowspan="3">
            
            </td>
        </tr>
        
        <tr>
            <td style="border-style: outset; border-top-width: medium; border-color: #3399FF" 
                class="style16">
                <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            </td>
        </tr>
        
        <tr>
            <td class="style15">
            </td>
        </tr>
        
    </table>
</asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="head">

    <style type="text/css">
        .style14
        {
            width: 783px;
        }
        .style15
        {
            height: 94px;
        width: 237px;
    }
    .style16
    {
        width: 237px;
    }
    </style>

</asp:Content>

