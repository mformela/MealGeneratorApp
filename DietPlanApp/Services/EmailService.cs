using DietPlanApp.ApiConsumer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace DietPlanApp.Services
{
    public class EmailService
    {
        
            public void SendEmail(EmailApiModel mailModel)
            {
                var smtpClient = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    UseDefaultCredentials = true,
                    Credentials =
                        new NetworkCredential("mail", "pass")
                };
                var mailMessage = new MailMessage
                {
                    Sender = new MailAddress("mail"),
                    From = new MailAddress("mail"),
                    To = { mailModel.To },
                    Body = "tresc maila",
                    IsBodyHtml = true
                };

                smtpClient.Send(mailMessage);
            }
        }
    }

