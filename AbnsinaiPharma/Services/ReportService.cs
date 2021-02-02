using AbnsinaiPharma.IServices;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace AbnsinaiPharma.Services
{
    public class ReportService : IReportService
    {
        private IWebHostEnvironment hostingEnv;
        public ReportService(IWebHostEnvironment env)
        {
            this.hostingEnv = env;
        }

        public string GetReport(string fileType, string fileName)
        { 
            string FilePath = Path.Combine(hostingEnv.WebRootPath, fileType);
            string FileNameWithPath = Path.Combine(FilePath, fileName);
            //byte[] bytes = File.ReadAllBytes(FileNameWithPath);
            return FileNameWithPath;
        }
    }
}
