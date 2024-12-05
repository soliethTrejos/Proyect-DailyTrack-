using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Track.Files
{
    internal class File
    {
        static void Main(string[] args)
        {
            string folderPath = Path.Combine(Environment.CurrentDirectory, "Archivos");

            // Crear la carpeta 'Archivos' si no existe
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                Console.WriteLine("La carpeta 'Archivos' se ha creado exitosamente.");
            }

            // Subir un archivo (simulado)
            Console.WriteLine("Ingrese la ruta completa del archivo que desea guardar:");
            string sourcePath = Console.ReadLine();

            if (File.Exists(sourcePath))
            {
                string fileName = Path.GetFileName(sourcePath);
                string destPath = Path.Combine(folderPath, fileName);

                try
                {
                    File.Copy(sourcePath, destPath, true);
                    Console.WriteLine($"Archivo '{fileName}' guardado en la carpeta 'Archivos'.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al guardar el archivo: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("El archivo especificado no existe.");
            }

            // Mostrar lista de archivos en la carpeta
            Console.WriteLine("\nArchivos en la carpeta 'Archivos':");
            string[] files = Directory.GetFiles(folderPath);

            foreach (string file in files)
            {
                Console.WriteLine(Path.GetFileName(file));
            }
        }
    }
}
