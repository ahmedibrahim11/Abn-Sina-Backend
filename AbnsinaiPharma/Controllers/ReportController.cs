using AbnsinaiPharma.IServices;
using Microsoft.AspNetCore.Mvc;


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

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
