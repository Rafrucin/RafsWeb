using RafsWeb.EmailSender;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RafsWeb.EmailSender
{
    public class EmailSenderClass
    {
        public static async Task<string> ExecuteEmail(MailModel model)
        {
            //var apiKey = Environment.GetEnvironmentVariable("SENDGRID_API_KEY");
            var apiKey = ("NOTTRUE");
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("rafal_rucinski@poczta.fm");
            var subject = "From Rafs Web";
            var to = new EmailAddress("rafal_rucinski@poczta.fm");
            var plainTextContent = "";
            var htmlContent = $"Email from: {model.Sender}, {model.Body}";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
            var output = response.StatusCode.ToString();

            if (output=="Accepted")
            {
                return "Thank you!";
            }
            
            return "Something went wrong...";
        }

    }
}
