using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Daily_Track.Archivos
{
    [Serializable]
    internal class Evento
    {
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
    }

    internal class Archivos
    {
        private readonly string filePath = "eventos.bin";

        public void GuardarEventos(List<Evento> eventos)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, eventos);
            }
        }

        public List<Evento> CargarEventos()
        {
            if (!File.Exists(filePath))
                return new List<Evento>();

            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                return (List<Evento>)formatter.Deserialize(fs);
            }
        }
    }
}
