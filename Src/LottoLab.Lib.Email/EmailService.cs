
using LottoLab.Domain.Data.Models;
using LottoLab.Domain.Interfaces.Common;

namespace LottoLab.Lib.Email
{
    public class EmailService : IEmailSevices
    {
       

        
        public Task BuildBody(EmailTo email,  EmailConfig config)
        {
            throw new NotImplementedException();
        }

        public Task ReplaceParameters(string template, IDictionary<string, string> parameters)
        {
            throw new NotImplementedException();
        }

        public Task SelectTemplate(string templateName)
        {
            throw new NotImplementedException();
        }

        public Task SendAsync(string to, string subject, string body)
        {
            throw new NotImplementedException();
        }
    }
}