using entities;
using Microsoft.AspNetCore.Mvc;


using service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace finalProject.Controllers
{
    [Route("api/[controller]Assignment")]
    [ApiController]
    public class AssignmentController(AssignmentService serv) : ControllerBase
    {

        //AssignmentService serv = new AssignmentService();


        // GET: api/<AssignmentController>
        [HttpGet]
        public List<AssignmentToShow> Get()
        {
            return serv.GetAllAssignmentToShow();
        }

        // GET api/<AssignmentController>/5
        [HttpGet("{id}")]
        public AssignmentToShow Get(int id)
        {
            return serv.GetAssignmentByIdToShow(id);
        }

        // POST api/<AssignmentController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AssignmentController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] AssignmentToUpdate value)
        {
            try
            {
                serv.updateAssignment(id, value);
                return Created();
            }
            catch (Exception exc)
            {
                return BadRequest(exc.Message);
            }
        }

        // DELETE api/<AssignmentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
