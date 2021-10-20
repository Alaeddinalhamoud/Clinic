using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Net.Mail;

public partial class SendEmailToPaient : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        MailMessage msg = new MailMessage();
        SmtpClient mailObj = new SmtpClient("smtp.gmail.com");
        msg.From = new MailAddress(TextBox1.Text );
        msg.To.Add(new MailAddress (TextBox2.Text));
        msg.IsBodyHtml = false;
        msg.Subject = TextBox3.Text;
        msg.Body = TextBox4.Text;
        mailObj.Send(msg);

    }
}