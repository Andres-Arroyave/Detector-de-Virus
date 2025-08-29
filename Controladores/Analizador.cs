/*
Programa: Detector de Virus
// Autores: Mateo Polanco Alvarez | Carlos Andres Arroyave
// Fecha: 27-08-2025
Descripción: Esta clase contiene la lógica para analizar un archivo y detectar 
si su contenido coincide con la secuencia de bytes de un virus conocido.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppPracticaTCOM.Modelos;

namespace AppPracticaTCOM.Controladores
{
    internal class Analizador
    {
        // Atributos -------------------
        private byte[] bytesArchivo;         // Bytes del archivo a analizar
        private List<Virus> virusList;       // Lista de virus conocidos (patrones a detectar)
        private string virusEncontrado;      // Nombre del virus encontrado (o "no encontrado")
        private int estadoFinal;             // Estado final alcanzado durante la detección

        /// Constructor que recibe los bytes del archivo y prepara la lista de virus.
 
    
        public Analizador(byte[] bytes)
        {
            bytesArchivo = bytes;
            virusEncontrado = "no encontrado";
            estadoFinal = 0;
            InicializarVirus();
        }

        /// Inicializa la lista de virus conocidos con sus secuencias de bytes.
        private void InicializarVirus()
        {
            virusList = new List<Virus>
            {
                new Virus("Usama", new byte[] {15, 30, 15, 49}, 4),
                new Virus("Amtrax", new byte[] {72, 72, 15, 29}, 4),
                new Virus("éBola", new byte[] {29, 32, 53, 29}, 4),
                new Virus("Ah1N1", new byte[] {72, 32, 32, 20}, 4),
                new Virus("Covid19", new byte[] {30, 25, 20, 19}, 4)
            };
        }

      
        /// Analiza el archivo comparando sus bytes con las secuencias de los virus y devuelve
        ///  - virus (string): nombre del virus encontrado, o "no encontrado".
        ///  - estado (int): estado final alcanzado en el análisis.
      
        public (string virus, int estado) Analizar()
        {
            foreach (var virus in virusList)
            {
                int estado = 0;

                for (int i = 0; i < bytesArchivo.Length; i++)
                {
                    if (bytesArchivo[i] == virus.SecuenciaVirus[estado])
                    {
                        estado++;
                        if (estado == virus.SecuenciaVirus.Length)
                        {
                            virusEncontrado = virus.NombreVirus;
                            estadoFinal = estado;
                            return (virusEncontrado, estadoFinal);
                        }
                    }
                    else
                    {
                        // Reinicia el estado si el byte no coincide
                        estado = (bytesArchivo[i] == virus.SecuenciaVirus[0]) ? 1 : 0;
                    }
                }
            }

            return (virusEncontrado, estadoFinal);
        }
    }
}
