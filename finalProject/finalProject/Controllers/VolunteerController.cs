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

        //VolunteerService serv = new VolunteerService();
        private readonly IVolunteerService serv;
        public VolunteerController(IVolunteerService volunteerService)
        {
            serv = volunteerService;
        }



        // GET: api/<VolunteerController>
        [HttpGet]
        public List<Volunteer> Get([FromQuery] string? sort)
        {
            return serv.GetAllVolunteerToShow(sort).ToList();
        }

        // GET api/<VolunteerController>/5
        [HttpGet("{id}")]
        public Volunteer Get(int id)
        {
            return serv.GetVolunteerByIdToShow(id);
        }

        // POST api/<VolunteerController>
        [HttpPost]
        public ActionResult Post([FromBody] Volunteer value)
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
        public ActionResult Put(int id, [FromBody] Volunteer value)
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
