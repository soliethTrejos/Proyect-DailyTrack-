using Daily_Track.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Track.Dao
{
    public class EventDao
    {
        private readonly string filePath = "events.bin";

        public EventDao() { }

        // Guardar un evento
        public void SaveEvent(Events evento)
        {
            List<Events> eventos = GetAllEvents();
            eventos.Add(evento);
            SaveToFile(eventos);
        }

        // Obtener todos los eventos
        public List<Events> GetAllEvents()
        {
            if (!File.Exists(filePath))
                return new List<Events>();

            List<Events> eventos = new List<Events>();
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            using (BinaryReader reader = new BinaryReader(fileStream))
            {
                while (fileStream.Position < fileStream.Length)
                {
                    Events evento = new Events
                    {
                        Id = reader.ReadInt32(),
                        Name = reader.ReadString(),
                        Description = reader.ReadString(),
                        Type = reader.ReadString(),
                        Time = reader.ReadString(),
                        Duration = reader.ReadString(),
                        Date = DateTime.Parse(reader.ReadString()),
                        Location = reader.ReadString(),
                        Club = reader.ReadString()
                    };
                    eventos.Add(evento);
                }
            }

            return eventos;
        }

        // Eliminar todos los eventos
        public void DeleteAllEvents()
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

        // Guardar en archivo
        private void SaveToFile(List<Events> eventos)
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            using (BinaryWriter writer = new BinaryWriter(fileStream))
            {
                foreach (Events evento in eventos)
                {
                    writer.Write(evento.Id);
                    writer.Write(evento.Name);
                    writer.Write(evento.Description);
                    writer.Write(evento.Type);
                    writer.Write(evento.Time);
                    writer.Write(evento.Duration);
                    writer.Write(evento.Date.ToString());
                    writer.Write(evento.Location);
                    writer.Write(evento.Club);
                }
            }
        }
    }
}
