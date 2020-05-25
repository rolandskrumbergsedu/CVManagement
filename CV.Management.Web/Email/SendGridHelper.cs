using CV.Management.Web.Helpers;
using Microsoft.ApplicationInsights;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace CV.Management.Web.Email
{
    public class SendGridHelper
    {
        private readonly TelemetryClient _telemetry = new TelemetryClient();

        public async Task SendMail(string subject, string toEmail, string content)
        {
            try
            {
                var apiKey = ConfigurationHelper.SendGridKey;
                var client = new SendGridClient(apiKey);
                var from = new EmailAddress("no-reply@amrop.lv", "Amrop CV System");

                var to = new EmailAddress(toEmail);

                var htmlContent = $"<p>{content}</p>";
                var msg = MailHelper.CreateSingleEmail(from, to, subject, content, htmlContent);
                var response = await client.SendEmailAsync(msg);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    _telemetry.TrackEvent("EmailSuccess", new Dictionary<string, string> { { "ToEmail", toEmail } });
                }
                else
                {
                    _telemetry.TrackEvent("EmailFailure", new Dictionary<string, string> { 
                        { "ToEmail", toEmail },
                        { "Status", response.StatusCode.ToString() },
                        { "Body", await response.Body.ReadAsStringAsync() }
                    });
                }
            }
            catch(Exception ex)
            {
                _telemetry.TrackException(ex);
                _telemetry.TrackEvent("FailedToSendEmail", new Dictionary<string, string> { { "ToEmail", toEmail } });
            }
        }
    }
}