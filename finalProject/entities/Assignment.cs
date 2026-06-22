using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entities
{
    public class Assignment
    {
        public int Id { get; init; }

        public int VolunteerId { get; set; }

        public int TaskId { get; set; }

        public DateTime? CompletionReportingTime { get; set; }
    }
}
