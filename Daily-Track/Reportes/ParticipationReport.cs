using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Track.Reports
{
    public class ParticipationReport
    {
        public string EventName { get; set; }
        public int Participants { get; set; }
        public int TotalCupos { get; set; }
        public int CuposReservados { get; set; }
        public static List<ParticipationReport> GetDailyParticipation()
        {
            return new List<ParticipationReport>
            {
                new ParticipationReport { EventName = "Conferencia", Participants = 50 },
                new ParticipationReport { EventName = "Taller de Liderazgo", Participants = 30 },
                new ParticipationReport { EventName = "Feria Universitaria", Participants = 20 },
                new ParticipationReport { EventName = "Encuentro Deportivo", Participants = 40 },
            };
        }
    }
}

