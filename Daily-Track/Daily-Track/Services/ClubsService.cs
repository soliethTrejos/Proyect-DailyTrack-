using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Daily_Track.Models;

namespace Daily_Track.Service
{
    public class ClubsService
    {
        private readonly string filePath = "clubs.bin";

        public void SaveClub(Clubs club)
        {
            List<Clubs> clubs = GetAllClubs();
            clubs.Add(club);
            SaveToFile(clubs);
        }

        public List<Clubs> GetAllClubs()
        {
            if (!File.Exists(filePath))
                return new List<Clubs>();

            List<Clubs> clubs = new List<Clubs>();
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            using (BinaryReader reader = new BinaryReader(fileStream))
            {
                while (fileStream.Position < fileStream.Length)
                {
                    Clubs club = new Clubs
                    {
                        Id = reader.ReadInt32(),
                        Name = reader.ReadString(),
                        Description = reader.ReadString()
                    };
                    clubs.Add(club);
                }
            }
            return clubs;
        }

        private void SaveToFile(List<Clubs> clubs)
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            using (BinaryWriter writer = new BinaryWriter(fileStream))
            {
                foreach (Clubs club in clubs)
                {
                    writer.Write(club.Id);
                    writer.Write(club.Name);
                    writer.Write(club.Description);
                }
            }
        }
    }
}
