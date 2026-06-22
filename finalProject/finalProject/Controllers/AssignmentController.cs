using entities;
using Microsoft.AspNetCore.Mvc;
//using repository;
using service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace finalProject.Controllers
{
    [Route("api/[controller]Assignment")]
    [ApiController]
    public class AssignmentController : ControllerBase
    {

        //AssignmentService serv = new AssignmentService();
        private readonly IAssignmentService serv;
        public AssignmentController(IAssignmentService assignmentService)
        {
            serv = assignmentService;
        }


        // GET: api/<AssignmentController>
        [HttpGet]
        public List<Assignment> Get()
        {
            return serv.GetAllAssignmentToShow().ToList();
        }

        // GET api/<AssignmentController>/5
        [HttpGet("{id}")]
        public Assignment Get(int id)
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
        public ActionResult Put(int id, [FromBody] Assignment value)
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
