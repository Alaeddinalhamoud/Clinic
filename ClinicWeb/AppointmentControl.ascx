<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AppointmentControl.ascx.cs" Inherits="AppointmentControl" %>

<style type="text/css">
    .style1
    {
        width: 100%;
        height: 365px;
    }
    </style>
<table class="style1" style="border: medium outset #3399FF" dir="rtl">
    <tr>
        <td  align="center"    >
            
                 <asp:Label ID="Label1" runat="server" Text="الوقت" Font-Bold="True" 
                Font-Size="Medium" ForeColor="#3399FF"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" style="margin-right: 0px" 
                Height="31px" Width="123px" ></asp:TextBox>
        </td>
        
        
    </tr>
    <tr>
        <td colspan="2" align="center" >
         &nbsp;
                &nbsp;
                &nbsp; &nbsp;
                &nbsp;
                 &nbsp;
                &nbsp;
                &nbsp; &nbsp;
                &nbsp;
                
                <asp:Button ID="Button1" runat="server" Text="حفظ" Font-Bold="True" 
                Font-Size="Medium" Height="33px" Width="91px" ForeColor="#3399FF" 
                onclick="Button1_Click" />
                  <asp:Button ID="Button2" runat="server" Text="حذف" Font-Bold="True" 
                Font-Size="Medium" Height="33px" Width="91px" ForeColor="#3399FF" 
                onclick="Button2_Click" />
            
              
        </td>
        
    </tr>
    <tr align="center" >
    <td  dir="rtl" >
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="true" 
            Width="286px">
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <Columns>
                <asp:BoundField DataField="TimeID" HeaderText="الرقم التسلسلي" />
                <asp:BoundField DataField="Time" HeaderText="الوقت" />
            </Columns>
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <EditRowStyle BackColor="#999999" />
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        </asp:GridView>
    </td>
    </tr>
    
</table>
