using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AbnsinaiPharma.IServices
{
    public interface IReportService
    {
        string GetReport(string fileType, string fileName);
    }
}
