using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Track.Models
{
    public class Events
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Time { get; set; }
        public string Duration { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public string Club { get; set; }
        public int TotalCupos { get; set; } 
        public int CuposReservados { get; set; } 
    }
}
