using AbnsinaiPharma.IServices;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;

namespace AbnsinaiPharma.Services
{
    public class ReportService : IReportService
    {
        private IHostingEnvironment hostingEnv;
        public ReportService(IHostingEnvironment env)
        {
            this.hostingEnv = env;
        }

        public string GetReport(string fileType, string fileName)
        { 
            string FilePath = Path.Combine(hostingEnv.WebRootPath, fileType);
            return Path.Combine(FilePath, fileName);
        }
    }
}
