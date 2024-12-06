using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Track.Reports
{
    public class ParticipationReport
    {
        public string IdEvent { get; set; }
        public int Participants { get; set; }
        public int TotalCupos { get; set; }
        public int CuposReservados { get; set; }

        public static List<ParticipationReport> GetDailyParticipation()
        {
            return new List<ParticipationReport>
                {
                    new ParticipationReport { IdEvent = "Conferencia", Participants = 50, TotalCupos = 100, CuposReservados = 60 },
                    new ParticipationReport { IdEvent = "Taller de Liderazgo", Participants = 30, TotalCupos = 50, CuposReservados = 35 },
                    new ParticipationReport { IdEvent = "Feria Universitaria", Participants = 20, TotalCupos = 40, CuposReservados = 25 },
                    new ParticipationReport { IdEvent= "Encuentro Deportivo", Participants = 40, TotalCupos = 80, CuposReservados = 50 },
                };
        }
    }
}

