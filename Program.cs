using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();
            client.Host = "smtp.qq.com";//使用QQ的SMTP服务器发送邮件
            client.EnableSsl = true;
            client.UseDefaultCredentials = true;
            client.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
            client.Credentials = new System.Net.NetworkCredential("*******@1oi.cc", "********");//这里使用我的域名邮箱，邮箱的用户名及密码，部分邮箱需要使用授权码代替密码
                                                                                    
            System.Net.Mail.MailMessage Message = new System.Net.Mail.MailMessage();
            Message.From = new System.Net.Mail.MailAddress("*******@1oi.cc");//发件人邮箱
            Message.To.Add("*******@qq.com");//目标邮箱
            //Message.To.Add("123456@qq.com");//
            Message.Subject = "测试标体";
            Message.Body = "测试邮件体";
            Message.SubjectEncoding = System.Text.Encoding.UTF8;
            Message.BodyEncoding = System.Text.Encoding.UTF8;
            Message.Priority = System.Net.Mail.MailPriority.High;
            Message.IsBodyHtml = true;
            client.Send(Message);
        }
    }
}
