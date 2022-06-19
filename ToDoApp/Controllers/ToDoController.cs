using Microsoft.AspNetCore.Mvc;
using System;
using ToDoApp.Interfaces;
using ToDoApp.ToDoObjects;

namespace ToDoApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToDoController : Controller
    {

        private readonly IToDoEr _toDoEr;
        public ToDoController(IToDoEr toDoEr)
        {
            _toDoEr = toDoEr;
        }
        [HttpPost("poster")]
        public ActionResult PostToDatabase([FromBody] ToDoRecord thisa)
        {
            _toDoEr.AddRecord(thisa);
            return Ok(thisa);
        }
        [HttpGet("getter")]
        public ActionResult GetData()
        {
            var hello = _toDoEr.ShowRecords();
            return Ok(hello);
        }
        [HttpPut("deleter")]
        public ActionResult DeleteRecord([FromRoute] string thisa)
        {
            _toDoEr.DeleteRecord(Guid.Parse(thisa));
            return Ok();
        }
        [HttpPut("editer")]
        public ActionResult ChangeRecord([FromBody] ToDoRecord thisa)
        {
            _toDoEr.EditRecord(thisa);
            return Ok();
        }
    }
}
