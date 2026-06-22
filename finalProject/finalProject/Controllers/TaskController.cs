using entities;
using Microsoft.AspNetCore.Mvc;

using service;
using System.Globalization;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace finalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController (TaskService serv) : ControllerBase
    {

        //TaskService serv = new TaskService();


        // GET: api/<TaskController>
        [HttpGet]
        public List<TaskToShow> Get([FromQuery] string? date , string? urgency)
        {

            return serv.GetAllTaskToShow(date , urgency);
        }

        // GET api/<TaskController>/5
        [HttpGet("{id}")]
        public TaskToShow Get(int id)
        {
            return serv.GetTaskByIdToShow(id);
        }

        // POST api/<TaskController>
        [HttpPost]
        public ActionResult Post([FromBody] TaskToAdd value)
        {
            try
            {
                serv.AddPossibleTask(value);
                return Created();
            }
            catch (Exception exc)
            {
                return BadRequest(exc.Message);
            }
        }

        // PUT api/<TaskController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] TaskToUpdate value)
        {
            try
            {
                serv.UpdateTask(id, value);
                return Created();
            }
            catch (Exception exc)
            {
                return BadRequest(exc.Message);
            }

        }

        // DELETE api/<TaskController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }

        [HttpPut("{id}/status")]
        public void UpdateStatus(int id, [FromBody] string status)
        {
            serv.UpdateTaskStatus(id, status);
        }

        [HttpGet("Open")]
        public IEnumerable<TaskToShow> GetOpenedTasks()
        {
            return serv.GetOpenTask();
        }

        [HttpGet("filter")]
        public IEnumerable<TaskToShow> GetFilterTasks([FromQuery] string? date, string? location)
        {
            return serv.FilterT(date , location);
        }



    }
}
