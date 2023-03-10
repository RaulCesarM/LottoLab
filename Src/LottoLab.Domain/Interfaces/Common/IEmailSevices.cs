using LottoLab.Domain.Data.Models;

namespace LottoLab.Domain.Interfaces.Common
{
    public interface IEmailSevices
    {
        Task BuildBody(EmailTo email, EmailConfig config);
        Task SendAsync(string to, string subject, string body);
        Task SelectTemplate(string templateName);
        Task ReplaceParameters(string template, IDictionary<string, string> parameters);
    }
}