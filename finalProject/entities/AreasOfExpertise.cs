using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entities
{
    public class AreasOfExpertise
    {
        public int Id { get; init; }

        public string Expertise { get; set; }

        public List<Volunteer>? ListVolunteer { get; set; }
    }
}
