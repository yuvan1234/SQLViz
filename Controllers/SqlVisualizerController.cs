using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SQLViz.Models;
using SQLViz.Services;

namespace SQLViz.Controllers
{
    [ApiController]
    [Route("api")]
    [EnableCors("AllowAll")]
    public class SqlVisualizerController : ControllerBase
    {
        private readonly SqlParser _sqlParser;

        public SqlVisualizerController()
        {
            _sqlParser = new SqlParser();
        }

        [HttpPost("visualize")]
        public ActionResult VisualizeQuery([FromBody] QueryModel model)
        {
            try
            {
                if (string.IsNullOrEmpty(model.SqlQuery))
                    return BadRequest("SQL query is required");

                var result = _sqlParser.ParseQuery(model.SqlQuery);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}





    
