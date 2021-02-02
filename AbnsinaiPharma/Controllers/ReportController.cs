using AbnsinaiPharma.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

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
        [HttpGet]
        public IActionResult GetStockReportFile(string fileType, string fileName)
        
        {
            var report = _reportService.GetReport("stock", "Daily_Sales_and_Stock_for_AL_ANDALOUS20210110080017.xlsx");
            if(report == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(report);
            }
        }


        [HttpGet("downloadFile")]
        public FileStream downloadFile(string fileName)
        {
            try
            {
                var currentDirectory = @"wwwroot\stock\";
                var file = Path.Combine(currentDirectory, fileName);
                return new FileStream(file, FileMode.Open, FileAccess.Read);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
