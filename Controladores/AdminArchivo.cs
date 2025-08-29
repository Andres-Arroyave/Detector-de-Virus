using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AppPracticaTCOM.Controladores
{

    /// Clase para administrar operaciones de archivos
    /// Programa: AppPracticaTCOM
    // Autores: Mateo Polanco Alvarez | Carlos Andres Arroyave
    /// Fecha: 27-08-2025
    /// Descripción: Esta clase se encarga de leer, manipular y obtener información de archivos para el análisis de virus
    internal class AdminArchivo
    {
        // Atributos
        private string nombreArchivo;      // Ruta completa del archivo a analizar
        private byte[] bytesArchivo;       // Array de bytes que representa el contenido del archivo


        /// Constructor de la clase AdminArchivo
        
        public AdminArchivo(string archivoSeleccionado)
        {
            nombreArchivo = archivoSeleccionado;
        }

        /// Lee todos los bytes del archivo y los almacena en un Array de bytes que representa el contenido del archivo
        public byte[] LeerBytes()
        {
            // Lógica para leer bytes de un archivo
            try
            {
                bytesArchivo = File.ReadAllBytes(nombreArchivo);
                return bytesArchivo;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al leer el archivo: {ex.Message}");
            }
        }

        /// Obtiene solo el nombre del archivo sin la ruta completa y devuelve el Nombre del archivo sin la ruta
        public string ObtenerNombreArchivo()
        {
            return Path.GetFileName(nombreArchivo);
        }


        /// Convierte los bytes del archivo a una cadena de texto legible y devuelve una Cadena que representa los bytes separados por espacios

        public string ObtenerBytesComoString()
        {
            return string.Join(" ", bytesArchivo.Select(b => b.ToString()));
        }

    
        public void CrearArchivo()
        {
            // Lógica para crear archivos nuevos
            // (Implementar según necesidades específicas)
        }
    }
}