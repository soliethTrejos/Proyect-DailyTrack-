using Daily_Track.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Track.Dao
{
    public class ParticipationDao
    {
        private readonly string filePath = "participation.bin";

        public ParticipationDao() { }

        // Método para guardar la participación de un estudiante
        public void SaveParticipation(Participation participation)
        {
            List<Participation> participations = GetAllParticipations(); // Corregido nombre del método
            participations.Add(participation);
            SaveToFile(participations);
        }

        // Método para obtener todas las participaciones
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

        // Método para eliminar todas las participaciones
        public void DeleteAllParticipations()
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

        // Método privado para guardar participaciones en el archivo
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
