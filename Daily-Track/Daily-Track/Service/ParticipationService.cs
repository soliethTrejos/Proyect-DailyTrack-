using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Daily_Track.Models;

namespace Daily_Track.Service
{
    public class ParticipationService
    {
        private readonly string filePath = "participations.bin";

        public void SaveParticipation(Participation participation)
        {
            List<Participation> participations = GetAllParticipations();
            participations.Add(participation);
            SaveToFile(participations);
        }

        public List<Participation> GetAllParticipations()
        {
            if (!File.Exists(filePath))
                return new List<Participation>();

            List<Participation> participations = new List<Participation>();
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            using (BinaryReader reader = new BinaryReader(fileStream))
            {
                while (fileStream.Position < fileStream.Length)
                {
                    Participation participation = new Participation
                    {
                        StudentId = reader.ReadInt32(),
                        EventId = reader.ReadInt32(),
                        ParticipationDate = DateTime.Parse(reader.ReadString())
                    };
                    participations.Add(participation);
                }
            }
            return participations;
        }

        private void SaveToFile(List<Participation> participations)
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            using (BinaryWriter writer = new BinaryWriter(fileStream))
            {
                foreach (Participation participation in participations)
                {
                    writer.Write(participation.StudentId);
                    writer.Write(participation.EventId);
                    writer.Write(participation.ParticipationDate.ToString());
                }
            }
        }
    }
}
