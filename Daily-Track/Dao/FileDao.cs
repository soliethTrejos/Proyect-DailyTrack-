using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Track.Dao
{
    public class FileDao
    {
        // Método para verificar si un archivo existe
        public bool FileExists(string filePath)
        {
            return File.Exists(filePath);
        }

        // Método para eliminar un archivo
        public void DeleteFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

        // Método para leer el contenido de un archivo como texto
        public string ReadFile(string filePath)
        {
            if (!File.Exists(filePath))
                return string.Empty;

            string content = File.ReadAllText(filePath);
            return content;
        }

        // Método para escribir contenido en un archivo como texto
        public void WriteFile(string filePath, string content)
        {
            File.WriteAllText(filePath, content);
        }
    }
}

