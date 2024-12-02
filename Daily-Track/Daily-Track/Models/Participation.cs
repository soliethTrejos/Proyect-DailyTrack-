using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Track.Models
{
    internal class Participation
    {
        public int StudentId { get; set; }
        public int EventId { get; set; }
        public DateTime ParticipationDate { get; set; }
    }
}
