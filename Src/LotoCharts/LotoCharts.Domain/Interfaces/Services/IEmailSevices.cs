namespace LotoCharts.Domain.Interfaces.Services
{
    public interface IEmailSevices
    {
        Task BuildBody(Email email);
        Task SendAsync(string to, string subject, string body);
        Task SelectTemplate(string templateName);
        Task ReplaceParameters(string template, IDictionary<string, string> parameters);
    }
}