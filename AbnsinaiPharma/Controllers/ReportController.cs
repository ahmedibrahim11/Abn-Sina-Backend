using AbnsinaiPharma.DTO;
using AbnsinaiPharma.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using static System.Net.WebRequestMethods;

namespace AbnsinaiPharma.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IReportService _reportService;
        public ReportController(IReportService reportService)
        {
            _reportService = reportService;

        }



        [HttpGet("downloadFile")]
        public FileStream downloadFile(string FileName, string ReportType)
        {
        {
            try
            {
                var currentDirectory = string.Concat(@"wwwroot\" ,ReportType,"/");
                var file = Path.Combine(currentDirectory,FileName);
                return new FileStream(file, FileMode.Open, FileAccess.Read);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
    
}
