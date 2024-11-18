using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyTrack.Models
{
    internal class Participation
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public DateTime RegisteredOn { get; set; }
    }
}
