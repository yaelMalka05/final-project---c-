using entities;
using Microsoft.AspNetCore.Mvc;
using service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace finalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VolunteerController : ControllerBase
    {

        VolunteerService serv = new VolunteerService();


        // GET: api/<VolunteerController>
        [HttpGet]
        public List<VolunteerToShow> Get([FromQuery] string? sort)
        {
            return serv.GetAllVolunteerToShow(sort);
        }

        // GET api/<VolunteerController>/5
        [HttpGet("{id}")]
        public VolunteerToShow Get(int id)
        {
            return serv.GetVolunteerByIdToShow(id);
        }

        // POST api/<VolunteerController>
        [HttpPost]
        public ActionResult Post([FromBody] VolunteerToAdd value)
        {
            try
            {
                serv.AddVolunteer(value);
                return Created();
            }
            catch (Exception exc)
            {
                return BadRequest(exc.Message);
            }
        }

        // PUT api/<VolunteerController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] VolunteerToUpdate value)
        {
            try
            {
                serv.updateVolunteer(id, value);
                return Created();
            }
            catch (Exception exc)
            {
                return BadRequest(exc.Message);
            }
        }

        // DELETE api/<VolunteerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            //try
            //{
            //    serv.deleteVolunteer(id);
            //    return Ok($"{id} volunteer deleted successfully");
            //}
            //catch (Exception exc)
            //{
            //    return BadRequest(exc.Message);
            //}
        }












    }
}
